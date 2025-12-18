using System;
using ToyProject.Model;
using ToyProject.View.IView;

namespace ToyProject.View
{
    public partial class PatientDetailDialogForm : DevExpress.XtraEditors.XtraForm, IPatientDetailDialogView
    {
        public PatientDetailDialogForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            OnSavePatient();
        }

        public void LoadView(Patient patient)
        {
            OnLoadRequest(patient);
        }


        #region IPatientDetailDialogView

        public IPatientEditControl PatientEditControl => patientEditControl;


        public event EventHandler SavePatient;

        private void OnSavePatient()
        {
            SavePatient?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler<Patient> LoadRequest;

        public void OnLoadRequest(Patient args)
        {
            LoadRequest?.Invoke(this, args);
        }

        #endregion
    }
}