using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ToyProject.Core.Service;
using ToyProject.Core.Validation;
using ToyProject.Model;
using ToyProject.View.Helper;

namespace ToyProject.View
{
    public partial class TesterManagementDialogForm : DevExpress.XtraEditors.XtraForm
    {
        public TesterManagementDialogForm(Tester tester)
        {
            InitializeComponent();
            _selectTester = tester;
            BuildFieldMap();
            ErrorProviderHelper.HookClearOnChange(_fieldMap.Values, errorProvider1);
        }

        private Tester _selectTester;
        private Tester _result;
        private Dictionary<string, Control> _fieldMap;


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
            _result = new Tester
            (
                _selectTester?.Id,
                licenseNumberTextEdit.Text,
                nameTextEdit.Text,
                officeInfoTextEdit.Text,
                _selectTester?.IsEnabled ?? true
            );

            var validationResult = new ValidationResult();
            validationResult.AddRequired(nameof(Tester.LicenseNumber), _result.LicenseNumber);
            validationResult.AddRequired(nameof(Tester.Name), _result.Name);
            validationResult.AddRequired(nameof(Tester.OfficeInfo), _result.OfficeInfo);
            ErrorProviderHelper.ShowErrors(errorProvider1, _fieldMap, validationResult);

            if (validationResult.IsValid == false)
            {
                this.CreateMessageService().ShowError(validationResult.ErrorMessage);
                return;
            }

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

        private void BuildFieldMap()
        {
            _fieldMap = new Dictionary<string, Control>
            {
                { nameof(Tester.LicenseNumber), licenseNumberTextEdit },
                { nameof(Tester.Name), nameTextEdit },
                { nameof(Tester.OfficeInfo), officeInfoTextEdit }
            };
        }
    }
}
