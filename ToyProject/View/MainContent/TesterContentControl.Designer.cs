
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.testerSearchContol = new DevExpress.XtraEditors.SearchControl();
            this.testerGridControl = new DevExpress.XtraGrid.GridControl();
            this.testerGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.licenseNumberColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.officeInfoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.enabledColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.testerRowContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteContextMenu = new System.Windows.Forms.ToolStripTextBox();
            this.activateContextMenu = new System.Windows.Forms.ToolStripTextBox();
            this.editContextMenu = new System.Windows.Forms.ToolStripTextBox();
            this.addTesterButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).BeginInit();
            this.splitContainerControl2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).BeginInit();
            this.splitContainerControl2.Panel2.SuspendLayout();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testerSearchContol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerGridView)).BeginInit();
            this.testerRowContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.testerGridControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1163, 597);
            this.splitContainerControl1.SplitterPosition = 21;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            // 
            // splitContainerControl2.Panel1
            // 
            this.splitContainerControl2.Panel1.Controls.Add(this.testerSearchContol);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            // 
            // splitContainerControl2.Panel2
            // 
            this.splitContainerControl2.Panel2.Controls.Add(this.addTesterButton);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1163, 21);
            this.splitContainerControl2.SplitterPosition = 149;
            this.splitContainerControl2.TabIndex = 0;
            // 
            // testerSearchContol
            // 
            this.testerSearchContol.Client = this.testerGridControl;
            this.testerSearchContol.Dock = System.Windows.Forms.DockStyle.Top;
            this.testerSearchContol.Location = new System.Drawing.Point(0, 0);
            this.testerSearchContol.Name = "testerSearchContol";
            this.testerSearchContol.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.testerSearchContol.Properties.Client = this.testerGridControl;
            this.testerSearchContol.Size = new System.Drawing.Size(1004, 20);
            this.testerSearchContol.TabIndex = 0;
            // 
            // testerGridControl
            // 
            this.testerGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testerGridControl.Location = new System.Drawing.Point(0, 0);
            this.testerGridControl.MainView = this.testerGridView;
            this.testerGridControl.Name = "testerGridControl";
            this.testerGridControl.Size = new System.Drawing.Size(1163, 566);
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
            // testerRowContextMenu
            // 
            this.testerRowContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteContextMenu,
            this.activateContextMenu,
            this.editContextMenu});
            this.testerRowContextMenu.Name = "contextMenuStrip1";
            this.testerRowContextMenu.Size = new System.Drawing.Size(161, 79);
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
            // addTesterButton
            // 
            this.addTesterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTesterButton.Location = new System.Drawing.Point(0, 0);
            this.addTesterButton.Name = "addTesterButton";
            this.addTesterButton.Size = new System.Drawing.Size(149, 21);
            this.addTesterButton.TabIndex = 0;
            this.addTesterButton.Text = "검사자 등록";
            this.addTesterButton.Click += new System.EventHandler(this.AddTesterButtonClick);
            // 
            // TesterContentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "TesterContentControl";
            this.Size = new System.Drawing.Size(1163, 597);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).EndInit();
            this.splitContainerControl2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).EndInit();
            this.splitContainerControl2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testerSearchContol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerGridView)).EndInit();
            this.testerRowContextMenu.ResumeLayout(false);
            this.testerRowContextMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.SearchControl testerSearchContol;
        private DevExpress.XtraGrid.GridControl testerGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView testerGridView;
        private DevExpress.XtraGrid.Columns.GridColumn nameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn licenseNumberColumn;
        private DevExpress.XtraGrid.Columns.GridColumn officeInfoColumn;
        private DevExpress.XtraGrid.Columns.GridColumn enabledColumn;
        private System.Windows.Forms.ContextMenuStrip testerRowContextMenu;
        private System.Windows.Forms.ToolStripTextBox deleteContextMenu;
        private System.Windows.Forms.ToolStripTextBox activateContextMenu;
        private System.Windows.Forms.ToolStripTextBox editContextMenu;
        private DevExpress.XtraEditors.SimpleButton addTesterButton;
    }
}
