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

        public void LoadView(Patient patient)
        {
            SetPatientInfo(patient);
            OnLoadView(patient);
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


        public event EventHandler<Patient> LoadRequest;

        private void OnLoadView(Patient patient)
        {
            LoadRequest?.Invoke(this, patient);
        }


        public void SetPatientInfo(Patient patient)
        {
            patientInfoLabel.Text = $"환자정보 : {patient.Name}|{patient.ChartNumber}";
        }

        #endregion
    }
}
