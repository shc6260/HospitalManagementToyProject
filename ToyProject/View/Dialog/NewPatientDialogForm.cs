using System;
using System.Windows.Forms;
using ToyProject.View.IView;

namespace ToyProject.View.Dialog
{
    public partial class NewPatientDialogForm : Form, INewPatientDialogView
    {
        public NewPatientDialogForm()
        {
            InitializeComponent();
        }


        #region Helpers

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            OnSavePatient();
            Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        } 

        #endregion


        #region INewPatientDialogView

        public IPatientEditControl PatientEditControl => patientEditControl;


        public event EventHandler SavePatient;

        private void OnSavePatient()
        {
            SavePatient?.Invoke(this, EventArgs.Empty);
        }

        #endregion
    }
}
