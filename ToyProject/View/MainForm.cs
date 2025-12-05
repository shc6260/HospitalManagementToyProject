using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
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
        private GridColumn _receptionColumn;
        private BindingList<Patient> _patients;

        public event EventHandler<long> PatientSelected;
        public event EventHandler<long> ReceptionRequested;

        public MainForm()
        {
            InitializeComponent();
            Load += MainForm_Load;
        }


        #region Init Control

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitPatientSearchEdit();
        }

        private void InitPatientSearchEdit()
        {
            gnbPatientSearchEdit.Properties.NullValuePrompt = "환자명, 차트번호, 연락처로 검색...";
            gnbPatientSearchEdit.Properties.ImmediatePopup = true;
            gnbPatientSearchEdit.Properties.PopupFilterMode = PopupFilterMode.Contains;
            gnbPatientSearchEdit.Properties.ShowClearButton = false;

            gnbPatientSearchEdit.CustomDisplayText += (s, e) => e.DisplayText = string.Empty;
            gnbPatientSearchEdit.KeyDown += GnbPatientSearchEdit_KeyDown;

            var view = gnbPatientSearchEdit.Properties.PopupView as GridView;
            if (view != null)
            {
                view.OptionsView.ShowIndicator = false;
                view.OptionsView.ShowColumnHeaders = false;
                view.FocusRectStyle = DrawFocusRectStyle.RowFocus;
                view.OptionsSelection.EnableAppearanceFocusedCell = false;

                view.Columns.Clear();
                view.Columns.AddVisible("ChartNumber", "차트번호");
                view.Columns.AddVisible("Name", "환자명");
                view.Columns.AddVisible("SocialSecurityNumber", "생년월일");
                view.Columns.AddVisible("Gender", "성별");
                view.Columns.AddVisible("PhoneNumber", "연락처");

                view.RowCellClick += View_RowCellClick;

                AddReceptionButtonColumn(view);
            }
        }

        private void AddReceptionButtonColumn(GridView view)
        {
            var repoButtonEdit = new RepositoryItemButtonEdit
            {
                TextEditStyle = TextEditStyles.HideTextEditor
            };
            repoButtonEdit.Buttons[0].Caption = "접수";
            repoButtonEdit.Buttons[0].Kind = ButtonPredefines.Glyph;

            gnbPatientSearchEdit.Properties.RepositoryItems.Add(repoButtonEdit);

            _receptionColumn = view.Columns.AddField("Reception");
            _receptionColumn.Caption = "접수";
            _receptionColumn.Visible = true;
            _receptionColumn.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            _receptionColumn.ColumnEdit = repoButtonEdit;
            _receptionColumn.OptionsColumn.AllowEdit = true;
        }
        #endregion


        #region Helper


        private void GnbPatientSearchEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var view = gnbPatientSearchEdit.Properties.PopupView as GridView;
                var patient = view?.GetFocusedRow() as Patient;
                if (patient != null)
                {
                    PatientSelected?.Invoke(this, patient.Id.Value);
                    e.Handled = true;
                }
            }
        }

        private void View_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            var view = sender as GridView;
            if (view == null || e.RowHandle < 0)
                return;

            var patient = view.GetRow(e.RowHandle) as Patient;
            if (patient == null)
                return;

            if (e.Column == _receptionColumn)
            {
                ReceptionRequested?.Invoke(this, patient.Id.Value);
                return;
            }

            PatientSelected?.Invoke(this, patient.Id.Value);
        }

        #endregion


        #region IMainView

        // IMainView 구현
        public void SetPatientList(IList<Patient> patients)
        {
            _patients = new BindingList<Patient>(patients);
            gnbPatientSearchEdit.Properties.DataSource = _patients;
            gnbPatientSearchEdit.Properties.DisplayMember = "Name";
            gnbPatientSearchEdit.Properties.ValueMember = "Id";
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
            gnbPatientSearchEdit.EditValue = null;
            gnbPatientSearchEdit.ClosePopup();
        }

        #endregion

        private void gnbPatientSearchEdit_Closed(object sender, ClosedEventArgs e)
        {

        }
    }
}
