
namespace ToyProject.View
{
    partial class TesterContentControl
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
            this.testerRowContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.activateContextMenu = new System.Windows.Forms.ToolStripTextBox();
            this.editContextMenu = new System.Windows.Forms.ToolStripTextBox();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.addTesterButton = new DevExpress.XtraEditors.SimpleButton();
            this.testerSearchContol = new DevExpress.XtraEditors.SearchControl();
            this.testerGridControl = new DevExpress.XtraGrid.GridControl();
            this.testerGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.licenseNumberColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.officeInfoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.enabledColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.testerRowContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testerSearchContol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // testerRowContextMenu
            // 
            this.testerRowContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activateContextMenu,
            this.editContextMenu});
            this.testerRowContextMenu.Name = "contextMenuStrip1";
            this.testerRowContextMenu.Size = new System.Drawing.Size(181, 76);
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
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.addTesterButton);
            this.layoutControl1.Controls.Add(this.testerSearchContol);
            this.layoutControl1.Controls.Add(this.testerGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1207, 327, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1163, 597);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // addTesterButton
            // 
            this.addTesterButton.Location = new System.Drawing.Point(1064, 13);
            this.addTesterButton.Margin = new System.Windows.Forms.Padding(0);
            this.addTesterButton.MaximumSize = new System.Drawing.Size(92, 22);
            this.addTesterButton.Name = "addTesterButton";
            this.addTesterButton.Size = new System.Drawing.Size(86, 22);
            this.addTesterButton.StyleController = this.layoutControl1;
            this.addTesterButton.TabIndex = 0;
            this.addTesterButton.Text = "검사자 등록";
            this.addTesterButton.Click += new System.EventHandler(this.AddTesterButtonClick);
            // 
            // testerSearchContol
            // 
            this.testerSearchContol.Client = this.testerGridControl;
            this.testerSearchContol.Location = new System.Drawing.Point(12, 14);
            this.testerSearchContol.Name = "testerSearchContol";
            this.testerSearchContol.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.testerSearchContol.Properties.Client = this.testerGridControl;
            this.testerSearchContol.Size = new System.Drawing.Size(496, 20);
            this.testerSearchContol.StyleController = this.layoutControl1;
            this.testerSearchContol.TabIndex = 0;
            // 
            // testerGridControl
            // 
            this.testerGridControl.Location = new System.Drawing.Point(10, 38);
            this.testerGridControl.MainView = this.testerGridView;
            this.testerGridControl.Name = "testerGridControl";
            this.testerGridControl.Size = new System.Drawing.Size(1143, 549);
            this.testerGridControl.TabIndex = 0;
            this.testerGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.testerGridView});
            // 
            // testerGridView
            // 
            this.testerGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameColumn,
            this.licenseNumberColumn,
            this.officeInfoColumn,
            this.enabledColumn});
            this.testerGridView.GridControl = this.testerGridControl;
            this.testerGridView.Name = "testerGridView";
            this.testerGridView.OptionsBehavior.Editable = false;
            this.testerGridView.OptionsView.ShowGroupPanel = false;
            // 
            // nameColumn
            // 
            this.nameColumn.Caption = "이름";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Visible = true;
            this.nameColumn.VisibleIndex = 0;
            // 
            // licenseNumberColumn
            // 
            this.licenseNumberColumn.Caption = "면허번호";
            this.licenseNumberColumn.Name = "licenseNumberColumn";
            this.licenseNumberColumn.Visible = true;
            this.licenseNumberColumn.VisibleIndex = 1;
            // 
            // officeInfoColumn
            // 
            this.officeInfoColumn.Caption = "진료실";
            this.officeInfoColumn.Name = "officeInfoColumn";
            this.officeInfoColumn.Visible = true;
            this.officeInfoColumn.VisibleIndex = 2;
            // 
            // enabledColumn
            // 
            this.enabledColumn.Caption = "활성화여부";
            this.enabledColumn.Name = "enabledColumn";
            this.enabledColumn.Visible = true;
            this.enabledColumn.VisibleIndex = 3;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(1163, 597);
            this.Root.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.testerGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(1143, 549);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem2.Control = this.testerSearchContol;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(500, 28);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(500, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(500, 28);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.addTesterButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(1051, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem3.Size = new System.Drawing.Size(92, 28);
            this.layoutControlItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(500, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(551, 28);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(603, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(440, 28);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // TesterContentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "TesterContentControl";
            this.Size = new System.Drawing.Size(1163, 597);
            this.testerRowContextMenu.ResumeLayout(false);
            this.testerRowContextMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testerSearchContol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip testerRowContextMenu;
        private System.Windows.Forms.ToolStripTextBox activateContextMenu;
        private System.Windows.Forms.ToolStripTextBox editContextMenu;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton addTesterButton;
        private DevExpress.XtraEditors.SearchControl testerSearchContol;
        private DevExpress.XtraGrid.GridControl testerGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView testerGridView;
        private DevExpress.XtraGrid.Columns.GridColumn nameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn licenseNumberColumn;
        private DevExpress.XtraGrid.Columns.GridColumn officeInfoColumn;
        private DevExpress.XtraGrid.Columns.GridColumn enabledColumn;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
