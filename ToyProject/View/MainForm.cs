using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ToyProject.Model;
using ToyProject.Presenter;
using ToyProject.View;

namespace ToyProject
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
            Load += MainForm_Load;
        }

        private BindingList<Patient> _patients;

        #region Properties

        private MainContentControl _mainContent;

        private MainContentControl MainContent
        {
            get
            {
                if (_mainContent == null)
                {
                    _mainContent = new MainContentControl();
                    _mainContent.Dock = DockStyle.Fill;
                }

                return _mainContent;
            }
        }

        private TestContentControl _testContent;

        private TestContentControl TestContent
        {
            get
            {
                if (_testContent == null)
                {
                    _testContent = new TestContentControl();
                    _testContent.Dock = DockStyle.Fill;
                }

                return _testContent;
            }
        }

        private TesterContentControl _testerContent;

        private TestContentControl TesterContent
        {
            get
            {
                if (_testerContent == null)
                {
                    _testerContent = new TesterContentControl();
                    _testerContent.Dock = DockStyle.Fill;
                }

                return _testContent;
            }
        }

        private TestItemContentControl _testItemContent;

        private TestItemContentControl TestItemContent
        {
            get
            {
                if (_testItemContent == null)
                {
                    _testItemContent = new TestItemContentControl();
                    _testItemContent.Dock = DockStyle.Fill;
                }

                return _testItemContent;
            }
        }

        private EquipmentContentControl _equipmentContent;

        private EquipmentContentControl EquipmentContent
        {
            get
            {
                if (_equipmentContent == null)
                {
                    _equipmentContent = new EquipmentContentControl();
                    _equipmentContent.Dock = DockStyle.Fill;
                }

                return _equipmentContent;
            }
        } 

        #endregion

        #region Init Control

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Add(MainContent);
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

            mainPanel.Controls.Clear();

            switch (e.Element.Name)
            {
                case nameof(mainTab):
                    mainPanel.Controls.Add(MainContent);
                    break;

                case nameof(testTab):
                    mainPanel.Controls.Add(TestContent);

                    break;

                case nameof(testerTab):
                    mainPanel.Controls.Add(TesterContent);

                    break;

                case nameof(testItemTab):
                    mainPanel.Controls.Add(TestItemContent);

                    break;

                case nameof(equipmentTab):
                    mainPanel.Controls.Add(EquipmentContent);

                    break;

                default:
                    break;
            }
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

        #endregion

        #region IMainView

        // IMainView 구현
        public void SetPatientList(IList<Patient> patients)
        {
            _patients = new BindingList<Patient>(patients);
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
            XtraMessageBox.Show(this,
                $"[접수 완료]\n차트번호: {patient.ChartNumber}\n이름: {patient.Name}",
                "접수",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void ClearSearch()
        {
            gnbSearchEdit.EditValue = null;
            gnbSearchEdit.ClosePopup();
        }

        #endregion

        #region Events

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
            SearchTextChanged?.Invoke(this, gnbSearchEdit.Text);
        }

        #endregion
    }
}
