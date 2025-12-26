using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ToyProject.Core.Validation;
using ToyProject.Model;
using ToyProject.View.Helper;
using ToyProject.View.IView.MainContent;

namespace ToyProject.View
{
    public partial class TestItemContentControl : UserControl, ITestItemContentControlView
    {
        public TestItemContentControl()
        {
            InitializeComponent();
            BuildFieldMap();
            ErrorProviderHelper.HookClearOnChange(new Control[] { nameTextEdit }, errorProvider1);

            testItemGridView.MouseUp += OnTestItemGridViewMouseUp;
        }

        private TestItem _selectedTestItem;
        private Dictionary<string, Control> _fieldMap;


        #region Init Control

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            InitTesterGridControl();
        }

        private void InitTesterGridControl()
        {
            testItemSearchContol.Properties.NullValuePrompt = "검색...";

            codeColumn.FieldName = nameof(TestItem.TestItemCode);
            nameColumn.FieldName = nameof(TestItem.Name);
            referenceValueColumn.FieldName = nameof(TestItem.DisplayReferenceValue);
            enabledColumn.FieldName = nameof(TestItem.IsEnabled);
        }

        #endregion


        #region Helpers

        private void OnTestItemGridViewMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            var view = sender as GridView;
            var hitInfo = view.CalcHitInfo(e.Location);
            var item = view.GetRow(hitInfo.RowHandle) as TestItem;

            if (hitInfo.InRow || hitInfo.InRowCell)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                testerRowContextMenu.Show(Control.MousePosition);
                activateContextMenu.Text = item?.IsEnabled == false ? "활성화" : "비활성화";
            }
        }

        private void DeleteContextMenuClick(object sender, EventArgs e)
        {
            var row = testItemGridView.GetFocusedRow() as TestItem;
            if (row == null)
                return;

            OnDeleteTestItemRequested(row);
            testerRowContextMenu.Close();
        }

        private void ActivateContextMenuClick(object sender, EventArgs e)
        {
            var row = testItemGridView.GetFocusedRow() as TestItem;
            if (row == null)
                return;

            OnToggleActiveRequested(row);
            testerRowContextMenu.Close();
        }

        private void ResetButtonClick(object sender, EventArgs e)
        {
            codeTextEdit.Text = null;
            nameTextEdit.Text = null;
            referenceMinTextEdit.Text = null;
            referenceMaxTextEdit.Text = null;
            _selectedTestItem = null;
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            var saveItem = TestItem.From
            (
                _selectedTestItem?.Id,
                codeTextEdit.Text,
                nameTextEdit.Text,
                referenceMinTextEdit.Text,
                referenceMaxTextEdit.Text,
                _selectedTestItem?.IsEnabled ?? true
            );

            OnUpdateTestItemRequested(saveItem);
        }

        private void TestItemGridViewRowClick(object sender, RowClickEventArgs e)
        {
            var view = sender as GridView;
            if (view == null || e.RowHandle < 0)
                return;

            var item = view.GetRow(e.RowHandle) as TestItem;
            _selectedTestItem = item;
            codeTextEdit.Text = _selectedTestItem?.TestItemCode;
            nameTextEdit.Text = _selectedTestItem?.Name;
            referenceMinTextEdit.Text = _selectedTestItem?.ReferenceMinValue.ToString();
            referenceMaxTextEdit.Text = _selectedTestItem?.ReferenceMaxValue.ToString();
        }

        private void BuildFieldMap()
        {
            _fieldMap = new Dictionary<string, Control>
            {
                { nameof(TestItem.Name), nameTextEdit },
                { nameof(TestItem.TestItemCode), codeTextEdit },
                { nameof(TestItem.ReferenceMinValue), referenceMinTextEdit },
                { nameof(TestItem.ReferenceMaxValue), referenceMaxTextEdit }
            };
        }

        #endregion


        #region ITestItemContentControlView

        public event EventHandler<TestItem> UpdateTestItemRequested;

        private void OnUpdateTestItemRequested(TestItem item)
        {
            UpdateTestItemRequested?.Invoke(this, item);
        }


        public event EventHandler<TestItem> DeleteTestItemRequested;

        private void OnDeleteTestItemRequested(TestItem item)
        {
            DeleteTestItemRequested?.Invoke(this, item);
        }


        public event EventHandler<TestItem> ToggleActiveRequested;

        private void OnToggleActiveRequested(TestItem item)
        {
            ToggleActiveRequested?.Invoke(this, item);
        }

        public void SetTestItemList(IEnumerable<TestItem> items)
        {

            testItemGridControl.DataSource = new BindingList<TestItem>(items.ToArray());
        }

        public void ShowErrors(ValidationResult validationResult)
        {
            ErrorProviderHelper.ShowErrors(errorProvider1, _fieldMap, validationResult);
        }

        #endregion
    }
}
