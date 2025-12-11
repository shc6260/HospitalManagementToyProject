using System;
using System.Windows.Forms;
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            _result = new Equipment
            (
               _selectedEquip?.Id,
              codeTextEdit.Text,
              nameTextEdit.Text,
              _selectedEquip?.IsEnabled ?? true
            );

            Close();
        }


        private void closeButton_Click(object sender, EventArgs e)
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
