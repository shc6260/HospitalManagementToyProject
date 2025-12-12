using System;
using System.Windows.Forms;
using ToyProject.Model;
using ToyProject.View.IView;

namespace ToyProject.View.Dialog
{
    public partial class ReceptionDialogForm : Form, IReceptionDialogView
    {
        public ReceptionDialogForm()
        {
            InitializeComponent();
        }

        #region Helpers

        public void LoadNew(Patient patient)
        {
            SetPatientInfo(patient.Name, patient.ChartNumber);
            OnLoadRequestByPatient(patient);
        }

        public void LoadReception(ReceptionWithPatientSimpleResponse reception)
        {
            SetPatientInfo(reception.PatientName, reception.Chartnumber);
            OnLoadRequestByPatient(reception);
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            OnCancelReceptionRequest();
            Close();
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            OnSaveReceptionRequest();
            Close();
        }

        private void CancelReceptionButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        #endregion


        #region IReceptionDialogView

        public IReceptionControlView IReceptionControlView => receptionControl;


        public event EventHandler CancelReceptionRequest;

        public void OnCancelReceptionRequest()
        {
            CancelReceptionRequest?.Invoke(this, EventArgs.Empty);
        }


        public event EventHandler SaveReceptionRequest;

        public void OnSaveReceptionRequest()
        {
            SaveReceptionRequest?.Invoke(this, EventArgs.Empty);
        }


        public event EventHandler<Patient> LoadRequestByPatient;

        private void OnLoadRequestByPatient(Patient patient)
        {
            LoadRequestByPatient?.Invoke(this, patient);
        }


        public event EventHandler<ReceptionWithPatientSimpleResponse> LoadRequestByReceptionSimple;

        private void OnLoadRequestByPatient(ReceptionWithPatientSimpleResponse receptionSimple)
        {
            LoadRequestByReceptionSimple?.Invoke(this, receptionSimple);
        }

        public void SetPatientInfo(string name, string chartnumber)
        {
            patientInfoLabel.Text = $"환자정보 : {name}|{chartnumber}";
        }

        #endregion
    }
}
