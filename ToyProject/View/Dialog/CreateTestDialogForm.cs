using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ToyProject.Core.Service;
using ToyProject.Core.Validation;
using ToyProject.Model;
using ToyProject.Presenter.Validation;
using ToyProject.View.Helper;
using ToyProject.View.IView;

namespace ToyProject.View.Dialog
{
    public partial class CreateTestDialogForm : Form, ICreateTestDialogView
    {
        public CreateTestDialogForm()
        {
            InitializeComponent();
            BuildFieldMap();
            ErrorProviderHelper.HookClearOnChange(new Control[] { nameTextEdit }, errorProvider1);
            testItemGridView.SelectionChanged += (s, e) => errorProvider1.SetError(testItemGridControl, string.Empty);
        }

        public bool IsOk { get; private set; }
        private Dictionary<string, Control> _fieldMap;

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

            testItemGridView.OptionsFind.FindFilterColumns = nameof(TestItem.Name);
        }

        #endregion


        #region Helpers

        public void LoadView(Test test)
        {
            nameTextEdit.Text = test?.TestName;
            OnLoadRequest(test);
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

        private void ApplySelection(IEnumerable<TestItem> selectedItems)
        {
            if (selectedItems == null || selectedItems.Count() < 1)
                return;

            var selectedIds = selectedItems.Select(i => i.Id.Value).ToArray();

            testItemGridView.BeginSelection();
            try
            {
                testItemGridView.ClearSelection();

                for (int i = 0; i < testItemGridView.RowCount; i++)
                {
                    var row = testItemGridView.GetRow(i) as TestItem;
                    if (row == null)
                        continue;

                    if (selectedIds.Contains(row.Id ?? -1))
                    {
                        testItemGridView.SelectRow(i);
                    }
                }
            }
            finally
            {
                testItemGridView.EndSelection();
            }
        }

        public Test GetResult()
        {
            return Test.FromAdd(nameTextEdit.Text, GetSelectedtestItems().ToArray());
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            var selectedItems = GetSelectedtestItems().ToArray();
            var validationResult = TestValidator.Validate(nameTextEdit.Text, selectedItems);
            ErrorProviderHelper.ShowErrors(errorProvider1, _fieldMap, validationResult);

            if (validationResult.IsValid == false)
            {
                this.CreateMessageService().ShowError(validationResult.ErrorMessage);
                return;
            }

            IsOk = true;
            Close();
        }

        private void CancleButtonClick(object sender, EventArgs e)
        {
            IsOk = false;
            Close();
        }

        #endregion


        #region ICreateTestDialogView


        public event EventHandler<Test> LoadRequest;

        public void OnLoadRequest(Test args)
        {
            LoadRequest?.Invoke(this, args);
        }


        public void SetTestItems(IEnumerable<TestItem> testItems, IEnumerable<TestItem> selectedItems = null)
        {
            testItemGridControl.DataSource = new BindingList<TestItem>(testItems.ToArray());
            ApplySelection(selectedItems);
        }

        private void BuildFieldMap()
        {
            _fieldMap = new Dictionary<string, Control>
            {
                { nameof(Test.TestName), nameTextEdit },
                { nameof(Test.TestItems), testItemGridControl }
            };
        }

        #endregion
    }
}
