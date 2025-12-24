using System;
using System.Windows.Forms;
using ToyProject.Core.Service;
using ToyProject.Model;

namespace ToyProject.View
{
    public partial class EquipmentManagementDialogForm : Form
    {
        public EquipmentManagementDialogForm(Equipment selectedEquip)
        {
            InitializeComponent();
            _selectedEquip = selectedEquip;
        }

        private Equipment _selectedEquip;
        private Equipment _result;

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

            if (string.IsNullOrWhiteSpace(codeTextEdit.Text) || string.IsNullOrWhiteSpace(nameTextEdit.Text))
            {
                this.CreateMessageService().ShowError(ToyProject.Properties.Resources.Strings_noValueMessage);
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
    }
}
