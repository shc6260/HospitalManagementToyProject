using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ToyProject.Core.Service;
using ToyProject.Core.Validation;
using ToyProject.Model;
using ToyProject.View.Helper;

namespace ToyProject.View
{
    public partial class EquipmentManagementDialogForm : Form
    {
        public EquipmentManagementDialogForm(Equipment selectedEquip)
        {
            InitializeComponent();
            _selectedEquip = selectedEquip;
            BuildFieldMap();
            ErrorProviderHelper.HookClearOnChange(_fieldMap.Values, errorProvider1);
        }

        private Equipment _selectedEquip;
        private Equipment _result;
        private Dictionary<string, Control> _fieldMap;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (_selectedEquip == null)
                return;

            codeTextEdit.Text = _selectedEquip.EquipmentCode;
            nameTextEdit.Text = _selectedEquip.Name;
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            _result = new Equipment
            (
               _selectedEquip?.Id,
              codeTextEdit.Text,
              nameTextEdit.Text,
               _selectedEquip?.IsEnabled ?? true
            );

            var validationResult = new ValidationResult();
            validationResult.AddRequired(nameof(Equipment.EquipmentCode), _result.EquipmentCode);
            validationResult.AddRequired(nameof(Equipment.Name), _result.Name);
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

        public Equipment GetResult()
        {
            return _result;
        }

        private void BuildFieldMap()
        {
            _fieldMap = new Dictionary<string, Control>
            {
                { nameof(Equipment.EquipmentCode), codeTextEdit },
                { nameof(Equipment.Name), nameTextEdit }
            };
        }
    }
}
