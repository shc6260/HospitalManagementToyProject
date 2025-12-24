using System;
using ToyProject.Core.Service;
using ToyProject.Model;
using ToyProject.Properties;

namespace ToyProject.View
{
    public partial class TesterManagementDialogForm : DevExpress.XtraEditors.XtraForm
    {
        public TesterManagementDialogForm(Tester tester)
        {
            InitializeComponent();
            _selectTester = tester;
        }

        private Tester _selectTester;
        private Tester _result;


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (_selectTester == null)
                return;

            licenseNumberTextEdit.Text = _selectTester.LicenseNumber;
            nameTextEdit.Text = _selectTester.Name;
            officeInfoTextEdit.Text = _selectTester.OfficeInfo;
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(licenseNumberTextEdit.Text) || string.IsNullOrWhiteSpace(nameTextEdit.Text) || string.IsNullOrWhiteSpace(officeInfoTextEdit.Text))
            {
                this.CreateMessageService().ShowError(Resources.Strings_noValueMessage);
                return;
            }

            _result = new Tester
            (
                _selectTester?.Id,
                licenseNumberTextEdit.Text,
                nameTextEdit.Text,
                officeInfoTextEdit.Text,
                _selectTester?.IsEnabled ?? true
            );

            Close();
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            _result = null;

            Close();
        }

        public Tester GetResult()
        {
            return _result;
        }
    }
}
