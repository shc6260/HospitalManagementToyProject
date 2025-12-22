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


        #region Helpers

        private void SocialSecurityNumberTxtEditValueChanged(object sender, System.EventArgs e)
        {
            var ssn = SocialSecurityNumberTxt.Text;
            if (string.IsNullOrWhiteSpace(ssn))
                return;

            // '-' 제거
            var normalized = ssn.Replace("-", "").Trim();

            // 최소 길이 체크
            if (normalized.Length < 7)
                return;

            char genderCode = normalized[6];

            switch (genderCode)
            {
                case '1':
                case '3':
                    GenderTxt.Text = "남";
                    break;

                case '2':
                case '4':
                    GenderTxt.Text = "여";
                    break;
            }
        } 

        #endregion


        #region IPatientEditControl

        public Patient GetPatient()
        {
            return Patient.From
            (
                null,
                null,
                NameTxt.Text,
                SocialSecurityNumberTxt.Text,
                null,
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
            AddressTxt.Text = patient.Address;
            QualificationTxt.Text = patient.QualificationInfo;
            PatientMemoTxt.Text = patient.Memo;
        } 

        #endregion
    }
}
