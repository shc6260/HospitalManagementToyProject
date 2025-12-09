
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.equipSearchContol = new DevExpress.XtraEditors.SearchControl();
            this.equipGridControl = new DevExpress.XtraGrid.GridControl();
            this.equipGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.codeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.enabledColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addEquipButton = new DevExpress.XtraEditors.SimpleButton();
            this.equipRowContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteContextMenu = new System.Windows.Forms.ToolStripTextBox();
            this.activateContextMenu = new System.Windows.Forms.ToolStripTextBox();
            this.editContextMenu = new System.Windows.Forms.ToolStripTextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.equipSearchContol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipGridView)).BeginInit();
            this.equipRowContextMenu.SuspendLayout();
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
            this.splitContainerControl1.Panel2.Controls.Add(this.equipGridControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1036, 624);
            this.splitContainerControl1.SplitterPosition = 21;
            this.splitContainerControl1.TabIndex = 1;
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
            this.splitContainerControl2.Panel1.Controls.Add(this.equipSearchContol);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            // 
            // splitContainerControl2.Panel2
            // 
            this.splitContainerControl2.Panel2.Controls.Add(this.addEquipButton);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1036, 21);
            this.splitContainerControl2.SplitterPosition = 149;
            this.splitContainerControl2.TabIndex = 0;
            // 
            // equipSearchContol
            // 
            this.equipSearchContol.Client = this.equipGridControl;
            this.equipSearchContol.Dock = System.Windows.Forms.DockStyle.Top;
            this.equipSearchContol.Location = new System.Drawing.Point(0, 0);
            this.equipSearchContol.Name = "equipSearchContol";
            this.equipSearchContol.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.equipSearchContol.Properties.Client = this.equipGridControl;
            this.equipSearchContol.Size = new System.Drawing.Size(877, 20);
            this.equipSearchContol.TabIndex = 0;
            // 
            // equipGridControl
            // 
            this.equipGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipGridControl.Location = new System.Drawing.Point(0, 0);
            this.equipGridControl.MainView = this.equipGridView;
            this.equipGridControl.Name = "equipGridControl";
            this.equipGridControl.Size = new System.Drawing.Size(1036, 593);
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
            // addEquipButton
            // 
            this.addEquipButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addEquipButton.Location = new System.Drawing.Point(0, 0);
            this.addEquipButton.Name = "addEquipButton";
            this.addEquipButton.Size = new System.Drawing.Size(149, 21);
            this.addEquipButton.TabIndex = 0;
            this.addEquipButton.Text = "장비 등록";
            this.addEquipButton.Click += new System.EventHandler(this.addEquipButton_Click);
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
            // EquipmentContentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "EquipmentContentControl";
            this.Size = new System.Drawing.Size(1036, 624);
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
            ((System.ComponentModel.ISupportInitialize)(this.equipSearchContol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipGridView)).EndInit();
            this.equipRowContextMenu.ResumeLayout(false);
            this.equipRowContextMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
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
    }
}
