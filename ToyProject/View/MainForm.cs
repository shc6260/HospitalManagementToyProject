using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ToyProject.Core.Service;
using ToyProject.Model;
using ToyProject.Presenter;
using ToyProject.Presenter.MainContent;
using ToyProject.View;

namespace ToyProject
{
    public partial class MainForm : FluentDesignForm, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
            Load += MainForm_Load;
            _messageService = new MessageService(this);
        }

        private BindingList<Patient> _patients;

        private MessageService _messageService;

        #region Properties

        private MainContentControl _mainContent;

        private MainContentPresenter _mainPresenter;


        private TestContentControl _testContent;

        private TesterContentControl _testerContent;

        private TesterContentPresenter _testerContentPresenter;


        private TestItemContentControl _testItemContent;

        private TestItemContentPresenter _testItemContentPresenter;


        private EquipmentContentControl _equipmentContent;

        private EquipmentContentPresenter _equipmentContentPresenter;

        private PresenterBase _currentPresenter = null;

        #endregion


        #region Init Control

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetMainPanel(nameof(mainTab));
            InitPatientSearchEdit();
        }

        private void InitPatientSearchEdit()
        {
            gnbSearchEdit.Properties.NullValuePrompt = "환자명, 차트번호, 연락처로 검색...";

            nameColumn.FieldName = nameof(Patient.Name);
            chartNumberColumn.FieldName = nameof(Patient.ChartNumber);
            socialSecurityNumberColumn.FieldName = nameof(Patient.SocialSecurityNumber);
            genderColumn.FieldName = nameof(Patient.Gender);
            phoneNumberColumn.FieldName = nameof(Patient.PhoneNumber);
            addressColumn.FieldName = nameof(Patient.Address);


            // 🔹 "접수" 버튼 컬럼 추가
            var buttonEdit = new RepositoryItemButtonEdit
            {
                TextEditStyle = TextEditStyles.HideTextEditor
            };
            buttonEdit.Buttons[0].Caption = "접수";
            buttonEdit.Buttons[0].Kind = ButtonPredefines.Glyph;

            receptionColumn.ColumnEdit = buttonEdit;
        }

        #endregion


        #region Helper

        private void SelectedMainMenu(object sender, DevExpress.XtraBars.Navigation.SelectedElementChangedEventArgs e)
        {
            if (e.Element == null)
                return;

            SetMainPanel(e.Element.Name);
        }

        private async void SetMainPanel(string name)
        {
            mainPanel.Controls.Clear();

            switch (name)
            {
                case nameof(mainTab):
                    if (_mainContent == null)
                    {
                        _mainContent = new MainContentControl();
                        _mainContent.Dock = DockStyle.Fill;
                        _mainPresenter = new MainContentPresenter(_mainContent, _messageService);
                    }

                    _currentPresenter = _mainPresenter;
                    mainPanel.Controls.Add(_mainContent);
                    break;

                case nameof(testTab):
                    if (_testContent == null)
                    {
                        _testContent = new TestContentControl();
                        _testContent.Dock = DockStyle.Fill;
                    }

                    mainPanel.Controls.Add(_testContent);

                    break;

                case nameof(testerTab):
                    if (_testerContent == null)
                    {
                        _testerContent = new TesterContentControl();
                        _testerContent.Dock = DockStyle.Fill;
                        _testerContentPresenter = new TesterContentPresenter(_testerContent, _messageService);
                    }

                    _currentPresenter = _testerContentPresenter;
                    mainPanel.Controls.Add(_testerContent);

                    break;

                case nameof(testItemTab):
                    if (_testItemContent == null)
                    {
                        _testItemContent = new TestItemContentControl();
                        _testItemContent.Dock = DockStyle.Fill;
                        _testItemContentPresenter = new TestItemContentPresenter(_testItemContent, _messageService);
                    }

                    _currentPresenter = _testItemContentPresenter;
                    mainPanel.Controls.Add(_testItemContent);

                    break;

                case nameof(equipmentTab):
                    if (_equipmentContent == null)
                    {
                        _equipmentContent = new EquipmentContentControl();
                        _equipmentContent.Dock = DockStyle.Fill;
                        _equipmentContentPresenter = new EquipmentContentPresenter(_equipmentContent, _messageService);
                    }

                    _currentPresenter = _equipmentContentPresenter;
                    mainPanel.Controls.Add(_equipmentContent);

                    break;

                default:
                    break;
            }

            if (_currentPresenter == null)
                return;

            await _currentPresenter.Refresh();
        }

        private void gnbSearchEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (gnbSearchEdit.IsPopupOpen == false)
            {
                gnbSearchEdit.ShowPopup();
                gnbSearchEdit.Focus();
            }

            OnSearchTextChanged();
        }

        private void gnbGridView_RowClick(object sender, RowClickEventArgs e)
        {
            var view = sender as GridView;
            if (view == null || e.RowHandle < 0)
                return;

            var patient = view.GetRow(e.RowHandle) as Patient;
            if (patient == null)
                return;

            if (e.HitInfo.Column == receptionColumn)
            {
                OnReceptionRequested(patient);
                return;
            }

            gnbSearchEdit.ClosePopup();
            gnbSearchEdit.Text = null;

            OnPatientSelected(patient);
        }

        private void GnbPatientSearchEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var view = gnbGridView;
                var patient = view?.GetFocusedRow() as Patient;
                if (patient != null)
                {
                    OnPatientSelected(patient);
                    e.Handled = true;
                }
            }
        }

        private void NewPatientButtonClick(object sender, EventArgs e)
        {
            DialogExtension.ShowNewPatientDialog(this);
        }

        private void NewReceptionPatientButtonClick(object sender, EventArgs e)
        {
            DialogExtension.ShowNewPatientReceptionDialog(this);
        }

        #endregion


        #region IMainView

        public void SetPatientList(IEnumerable<Patient> patients)
        {
            _patients = new BindingList<Patient>(patients.ToArray());
            gnbSearchGrid.DataSource = _patients;
        }

        public void ShowPatientDetail(Patient patient)
        {
            var patientDetail = new PatientDetailDialogForm();
            new PatientDetailDialogPresenter(patientDetail, patient);
            patientDetail.Show();
        }

        public void ShowReceptionMessage(Patient patient)
        {
            DialogExtension.ShowNewReceptionDialog(this, patient);
        }

        public void ClearSearch()
        {
            gnbSearchEdit.EditValue = null;
            gnbSearchEdit.ClosePopup();
        }


        public event EventHandler<long> PatientSelected;

        private void OnPatientSelected(Patient patient)
        {
            if (patient.Id == null)
                return;

            PatientSelected?.Invoke(this, patient.Id.Value);
        }

        public event EventHandler<long> ReceptionRequested;

        private void OnReceptionRequested(Patient patient)
        {
            if (patient.Id == null)
                return;

            ReceptionRequested?.Invoke(this, patient.Id.Value);
        }

        public event EventHandler<string> SearchTextChanged;

        private void OnSearchTextChanged()
        {
            if (string.IsNullOrWhiteSpace(gnbSearchEdit.Text))
                return;

            SearchTextChanged?.Invoke(this, gnbSearchEdit.Text);
        }

        #endregion
    }
}
