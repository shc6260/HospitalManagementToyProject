using System;
using System.Windows.Forms;
using ToyProject.View.IView;

namespace ToyProject.View.Dialog
{
    public partial class NewPatientReceptionDialogForm : Form, INewPatientReceptionView
    {
        public NewPatientReceptionDialogForm()
        {
            InitializeComponent();
        }


        #region Helpers

        private void CloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            OnSavePatient();
        } 

        #endregion


        #region INewPatientReceptionView

        public IPatientEditControl PatientEditControl => patientEditControl1;

        public IReceptionControlView IReceptionControlView => receptionControl1;


        public event EventHandler SavePatient;

        private void OnSavePatient()
        {
            SavePatient?.Invoke(this, EventArgs.Empty);
        }

        #endregion
    }
}
