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
    public partial class EquipmentContentControl : UserControl, IEquipmentContentControlView
    {
        public EquipmentContentControl()
        {
            InitializeComponent();
            equipGridView.MouseUp += OnEquipGridViewMouseUp;
        }

        #region Init Control

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            InitEquipGridControl();
            OnLoaded();
        }

        private void InitEquipGridControl()
        {
            equipSearchContol.Properties.NullValuePrompt = "검색...";

            codeColumn.FieldName = nameof(Equipment.EquipmentCode);
            nameColumn.FieldName = nameof(Equipment.Name);
            enabledColumn.FieldName = nameof(Equipment.Enabled);
        }

        #endregion


        #region Helpers

        private void OnEquipGridViewMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Location);

            if (hitInfo.InRow || hitInfo.InRowCell)
            {
                view.FocusedRowHandle = hitInfo.RowHandle;
                equipRowContextMenu.Show(Control.MousePosition);
            }
        }

        private void DeleteContextMenuClick(object sender, EventArgs e)
        {
            var row = equipGridView.GetFocusedRow() as Equipment;
            if (row == null)
                return;

            OnDeleteEquipRequested(row);
            equipRowContextMenu.Close();
        }

        private void ActivateContextMenuClick(object sender, EventArgs e)
        {
            var row = equipGridView.GetFocusedRow() as Equipment;
            if (row == null)
                return;

            OnToggleActiveRequested(row);
            equipRowContextMenu.Close();
        }

        private void EditContextMenuClick(object sender, EventArgs e)
        {
            var row = equipGridView.GetFocusedRow() as Equipment;
            if (row == null)
                return;

            var result = ShowManagementDialog(row);
            if (result == null)
                return;

            OnUpdateEquipRequested(result);
            equipRowContextMenu.Close();
        }

        private void addEquipButton_Click(object sender, EventArgs e)
        {
            var result = ShowManagementDialog(null);
            if (result == null)
                return;

            OnUpdateEquipRequested(result);
        }

        public Equipment ShowManagementDialog(Equipment item)
        {
            var form = new EquipmentManagementDialogForm(item);
            form.ShowDialog();

            return form.GetResult();
        }

        #endregion


        #region IEquipmentContentControlView

        public void SetEquipmentsList(IEnumerable<Equipment> items)
        {
            equipGridControl.DataSource = new BindingList<Equipment>(items.ToArray());
        }

        public event EventHandler<Equipment> UpdateEquipRequested;

        private void OnUpdateEquipRequested(Equipment item)
        {
            UpdateEquipRequested?.Invoke(this, item);
        }


        public event EventHandler<Equipment> DeleteEquipRequested;

        private void OnDeleteEquipRequested(Equipment item)
        {
            DeleteEquipRequested?.Invoke(this, item);
        }


        public event EventHandler<Equipment> ToggleActiveRequested;

        private void OnToggleActiveRequested(Equipment item)
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
