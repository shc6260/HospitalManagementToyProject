using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ToyProject.Model;
using ToyProject.View.IView;
using System.ComponentModel;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

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
            testGridControl.DataSource = new BindingList<Test>();
            receptionDateEdit.DateTime = DateTime.Now;
        }

        private void InitTestItemGridControl()
        {
            testNameColumn.FieldName = nameof(Test.TestName);
            TestItemsColumn.FieldName = nameof(Test.DisplayTestItem);
        }

        #endregion


        #region Helpers

        private void AddTestButtonClick(object sender, EventArgs e)
        {
            var result = DialogExtension.ShowCreateTestDialog(ParentForm);
            if (result == null)
                return;

            var tests = testGridControl.DataSource as BindingList<Test>;
            tests.Add(result);
        }

        private void TestGridViewMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Location);

            if (hitInfo.InRow || hitInfo.InRowCell)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                testItemRowContextMenu.Show(Control.MousePosition);
            }
        }

        private void DeleteContextMenuClick(object sender, EventArgs e)
        {
            var row = testGridView.FocusedRowHandle;
            testGridView.DeleteRow(row);

            testItemRowContextMenu.Close();
        }

        private void EditContextMenuClick(object sender, EventArgs e)
        {
            var row = testGridView.GetFocusedRow() as Test;
            if (row == null)
                return;

            testItemRowContextMenu.Close();
            var result = this.ShowCreateTestDialog(row);
            if (result == null)
                return;

            var tests = testGridControl.DataSource as BindingList<Test>;
            var index = tests.IndexOf(row);
            tests.Remove(row);
            tests.Insert(index, new Test(row.Id, row.TestCode, result.TestName, row.Status, result.TestItems));
        }

        #endregion


        public Reception GetReception()
        {
            var allTests = testGridControl.DataSource as IEnumerable<Test>;

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
                allTests
            );
        }

        public void SetData(Reception reception)
        {
            if (reception == null)
                return;

            emergencyCheckBox.Checked = reception.IsEmergency;
            nightCheckBox.Checked = reception.IsEmergency;
            receptionMemoTextEdit.Text = reception.Memo;
            insuredComboBox.SelectedText = reception.InsuredInfo;
            specificalTextEdit.Text = reception.SpecificalCode;
            insurenceTextEdit.Text = reception.InsuranceInfo;
            checkupTextEdit.Text = reception.CheckupTargetInfo;
            receptionDateEdit.DateTime = reception.ReceptionDate;
            testGridControl.DataSource = new BindingList<Test>(reception.Tests.ToList());

        }
    }
}
