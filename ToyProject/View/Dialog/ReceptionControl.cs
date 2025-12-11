using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ToyProject.Model;
using ToyProject.View.IView;
using System.ComponentModel;


namespace ToyProject.View.Dialog
{
    public partial class ReceptionControl : UserControl, IReceptionControlView
    {
        public ReceptionControl()
        {
            InitializeComponent();
        }

        #region Init Control

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            InitTestItemGridControl();
        }

        private void InitTestItemGridControl()
        {
            nameColumn.FieldName = nameof(TestItem.Name);
            codeColumn.FieldName = nameof(TestItem.TestItemCode);
            referenceValueColumn.FieldName = nameof(TestItem.DisplayReferenceValue);
        }

        #endregion


        public Reception GetReception()
        {
            return new Reception
            (
                null,
                null,
                emergencyCheckBox.Checked,
                nightCheckBox.Checked,
                receptionMemoTextEdit.Text,
                insuredComboBox.SelectedText,
                specificalTextEdit.Text,
                insurenceTextEdit.Text,
                checkupTextEdit.Text,
                receptionDateEdit.DateTime,
                GetSelectedtestItems()
            );
        }

        private IEnumerable<TestItem> GetSelectedtestItems()
        {
            var rows = testItemGridView.GetSelectedRows();
            foreach (var handle in rows)
            {
                var item = testItemGridView.GetRow(handle) as TestItem;
                if (item == null)
                    continue;

                yield return item;
            }
        }

        public void SetData(IEnumerable<TestItem> testItems)
        {
            testItemGridControl.DataSource = new BindingList<TestItem>(testItems.ToArray());
        }
    }
}
