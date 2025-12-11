
namespace ToyProject.View
{
    partial class EquipmentContentControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.equipSearchContol = new DevExpress.XtraEditors.SearchControl();
            this.equipGridControl = new DevExpress.XtraGrid.GridControl();
            this.equipGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.codeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.enabledColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.addEquipButton = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.equipRowContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteContextMenu = new System.Windows.Forms.ToolStripTextBox();
            this.activateContextMenu = new System.Windows.Forms.ToolStripTextBox();
            this.editContextMenu = new System.Windows.Forms.ToolStripTextBox();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.equipSearchContol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.equipRowContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // equipSearchContol
            // 
            this.equipSearchContol.Client = this.equipGridControl;
            this.equipSearchContol.Location = new System.Drawing.Point(2, 2);
            this.equipSearchContol.Name = "equipSearchContol";
            this.equipSearchContol.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.equipSearchContol.Properties.Client = this.equipGridControl;
            this.equipSearchContol.Size = new System.Drawing.Size(932, 20);
            this.equipSearchContol.StyleController = this.layoutControl1;
            this.equipSearchContol.TabIndex = 0;
            // 
            // equipGridControl
            // 
            this.equipGridControl.Location = new System.Drawing.Point(0, 26);
            this.equipGridControl.MainView = this.equipGridView;
            this.equipGridControl.Name = "equipGridControl";
            this.equipGridControl.Size = new System.Drawing.Size(1036, 598);
            this.equipGridControl.TabIndex = 0;
            this.equipGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.equipGridView});
            // 
            // equipGridView
            // 
            this.equipGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.codeColumn,
            this.nameColumn,
            this.enabledColumn});
            this.equipGridView.GridControl = this.equipGridControl;
            this.equipGridView.Name = "equipGridView";
            this.equipGridView.OptionsBehavior.Editable = false;
            this.equipGridView.OptionsView.ShowGroupPanel = false;
            // 
            // codeColumn
            // 
            this.codeColumn.Caption = "코드";
            this.codeColumn.Name = "codeColumn";
            this.codeColumn.Visible = true;
            this.codeColumn.VisibleIndex = 1;
            // 
            // nameColumn
            // 
            this.nameColumn.Caption = "이름";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Visible = true;
            this.nameColumn.VisibleIndex = 0;
            // 
            // enabledColumn
            // 
            this.enabledColumn.Caption = "활성화여부";
            this.enabledColumn.Name = "enabledColumn";
            this.enabledColumn.Visible = true;
            this.enabledColumn.VisibleIndex = 2;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.addEquipButton);
            this.layoutControl1.Controls.Add(this.equipSearchContol);
            this.layoutControl1.Controls.Add(this.equipGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1106, 270, 650, 425);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1036, 624);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // addEquipButton
            // 
            this.addEquipButton.Location = new System.Drawing.Point(936, 0);
            this.addEquipButton.Name = "addEquipButton";
            this.addEquipButton.Size = new System.Drawing.Size(100, 22);
            this.addEquipButton.StyleController = this.layoutControl1;
            this.addEquipButton.TabIndex = 0;
            this.addEquipButton.Text = "장비 등록";
            this.addEquipButton.Click += new System.EventHandler(this.addEquipButton_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(1036, 624);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.equipSearchContol;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(936, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.addEquipButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(936, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(100, 22);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(100, 22);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem3.Size = new System.Drawing.Size(100, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // equipRowContextMenu
            // 
            this.equipRowContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteContextMenu,
            this.activateContextMenu,
            this.editContextMenu});
            this.equipRowContextMenu.Name = "contextMenuStrip1";
            this.equipRowContextMenu.Size = new System.Drawing.Size(161, 79);
            // 
            // deleteContextMenu
            // 
            this.deleteContextMenu.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.deleteContextMenu.Name = "deleteContextMenu";
            this.deleteContextMenu.ReadOnly = true;
            this.deleteContextMenu.Size = new System.Drawing.Size(100, 23);
            this.deleteContextMenu.Text = "삭제";
            this.deleteContextMenu.Click += new System.EventHandler(this.DeleteContextMenuClick);
            // 
            // activateContextMenu
            // 
            this.activateContextMenu.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.activateContextMenu.Name = "activateContextMenu";
            this.activateContextMenu.ReadOnly = true;
            this.activateContextMenu.Size = new System.Drawing.Size(100, 23);
            this.activateContextMenu.Text = "비활성화";
            this.activateContextMenu.Click += new System.EventHandler(this.ActivateContextMenuClick);
            // 
            // editContextMenu
            // 
            this.editContextMenu.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.editContextMenu.Name = "editContextMenu";
            this.editContextMenu.ReadOnly = true;
            this.editContextMenu.Size = new System.Drawing.Size(100, 23);
            this.editContextMenu.Text = "수정";
            this.editContextMenu.Click += new System.EventHandler(this.EditContextMenuClick);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.equipGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 2, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(1036, 600);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // EquipmentContentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "EquipmentContentControl";
            this.Size = new System.Drawing.Size(1036, 624);
            ((System.ComponentModel.ISupportInitialize)(this.equipSearchContol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.equipRowContextMenu.ResumeLayout(false);
            this.equipRowContextMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SearchControl equipSearchContol;
        private DevExpress.XtraGrid.GridControl equipGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView equipGridView;
        private DevExpress.XtraGrid.Columns.GridColumn codeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn nameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn enabledColumn;
        private DevExpress.XtraEditors.SimpleButton addEquipButton;
        private System.Windows.Forms.ContextMenuStrip equipRowContextMenu;
        private System.Windows.Forms.ToolStripTextBox deleteContextMenu;
        private System.Windows.Forms.ToolStripTextBox activateContextMenu;
        private System.Windows.Forms.ToolStripTextBox editContextMenu;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
