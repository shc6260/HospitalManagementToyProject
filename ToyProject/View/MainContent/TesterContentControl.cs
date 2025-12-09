using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ToyProject.Model;
using ToyProject.View.IView;

namespace ToyProject.View
{
    public partial class TesterContentControl : UserControl, ITesterContentControlView
    {
        public TesterContentControl()
        {
            InitializeComponent();
            testerGridView.MouseUp += OnTesterGridViewMouseUp;
        }

        #region Init Control

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            InitTesterGridControl();
            OnLoaded();
        }

        private void InitTesterGridControl()
        {
            testerSearchContol.Properties.NullValuePrompt = "이름 검색...";

            nameColumn.FieldName = nameof(Tester.Name);
            licenseNumberColumn.FieldName = nameof(Tester.LicenseNumber);
            officeInfoColumn.FieldName = nameof(Tester.OfficeInfo);
            enabledColumn.FieldName = nameof(Tester.Enabled);
        }

        #endregion


        #region Helpers

        private void OnTesterGridViewMouseUp(object sender, MouseEventArgs e)
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
            var row = testerGridView.GetFocusedRow() as Tester;
            if (row == null)
                return;

            OnTesterDeleteRequested(row);
            testerRowContextMenu.Close();
        }

        private void ActivateContextMenuClick(object sender, EventArgs e)
        {
            var row = testerGridView.GetFocusedRow() as Tester;
            if (row == null)
                return;

            OnToggleActiveRequested(row);
            testerRowContextMenu.Close();
        }

        private void EditContextMenuClick(object sender, EventArgs e)
        {
            var row = testerGridView.GetFocusedRow() as Tester;
            if (row == null)
                return;

            var result = ShowManagementDialog(row);
            if (result == null)
                return;

            OnUpdateTesterRequested(result);
            testerRowContextMenu.Close();
        }

        private void AddTesterButtonClick(object sender, EventArgs e)
        {
            var result = ShowManagementDialog(null);
            if (result == null)
                return;

            OnUpdateTesterRequested(result);
        }

        public Tester ShowManagementDialog(Tester item)
        {
            var form = new TesterManagementDialogForm(item);
            form.ShowDialog();

            return form.GetResult();
        }

        #endregion


        #region ITesterContentControlView

        public void SetTesterList(IEnumerable<Tester> items)
        {
            testerGridControl.DataSource = new BindingList<Tester>(items.ToArray());
        }

        public event EventHandler<Tester> UpdateTesterRequested;

        private void OnUpdateTesterRequested(Tester item)
        {
            UpdateTesterRequested?.Invoke(this, item);
        }

        public event EventHandler<Tester> TesterDeleteRequested;

        private void OnTesterDeleteRequested(Tester item)
        {
            TesterDeleteRequested?.Invoke(this, item);
        }

        public event EventHandler<Tester> ToggleActiveRequested;

        private void OnToggleActiveRequested(Tester item)
        {
            ToggleActiveRequested?.Invoke(this, item);
        }

        public event EventHandler Loaded;

        private void OnLoaded()
        {
            Loaded?.Invoke(this, EventArgs.Empty);
        }

        #endregion
    }
}
