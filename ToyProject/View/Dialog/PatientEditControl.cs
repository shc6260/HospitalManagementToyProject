using ToyProject.Model;
using ToyProject.View.IView;

namespace ToyProject.View
{
    public partial class PatientEditControl : DevExpress.XtraEditors.XtraUserControl, IPatientEditControl
    {
        public PatientEditControl()
        {
            InitializeComponent();
        }

        public Patient GetPatient()
        {
            return Patient.From
            (
                null,
                null,
                NameTxt.Text,
                SocialSecurityNumberTxt.Text,
                GenderTxt.Text,
                PhoneNumberTxt.Text,
                AddressTxt.Text,
                PatientMemoTxt.Text,
                QualificationTxt.Text
            );
        }

        public void SetPatient(Patient patient)
        {
            if (patient == null)
                return;

            NameTxt.Text = patient.Name;
            PhoneNumberTxt.Text = patient.PhoneNumber;
            SocialSecurityNumberTxt.Text = patient.SocialSecurityNumber;
            GenderTxt.Text = patient.Gender;
            AddressTxt.Text = patient.Address;
            QualificationTxt.Text = patient.QualificationInfo;
            PatientMemoTxt.Text = patient.Memo;
        }
    }
}
