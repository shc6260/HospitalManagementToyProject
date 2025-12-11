using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ToyProject.Model;
using ToyProject.View.IView.MainContent;

namespace ToyProject.View
{
    public partial class TestItemContentControl : UserControl, ITestItemContentControlView
    {
        public TestItemContentControl()
        {
            InitializeComponent();
            testItemGridView.MouseUp += OnTestItemGridViewMouseUp;

        }

        private TestItem _selectedTestItem;

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

            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Location);

            if (hitInfo.InRow || hitInfo.InRowCell)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                testerRowContextMenu.Show(Control.MousePosition);
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
            if (string.IsNullOrWhiteSpace(codeTextEdit.Text) 
                || string.IsNullOrWhiteSpace(nameTextEdit.Text) 
                || string.IsNullOrWhiteSpace(referenceMinTextEdit.Text) 
                || string.IsNullOrWhiteSpace(referenceMaxTextEdit.Text))
            {
                XtraMessageBox.Show(this, "빈 값이 있습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

        #endregion

    }
}
