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
        private BindingList<Patient> _patients;

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
