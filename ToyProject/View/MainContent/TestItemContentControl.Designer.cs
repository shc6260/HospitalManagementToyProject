
namespace ToyProject.View
{
    partial class TestItemContentControl
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.testItemSearchContol = new DevExpress.XtraEditors.SearchControl();
            this.testItemGridControl = new DevExpress.XtraGrid.GridControl();
            this.testItemGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.codeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.referenceValueColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.enabledColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.resetButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.referenceMinTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.referenceMaxTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.testerRowContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteContextMenu = new System.Windows.Forms.ToolStripTextBox();
            this.activateContextMenu = new System.Windows.Forms.ToolStripTextBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testItemSearchContol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testItemGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testItemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceMinTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceMaxTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.testerRowContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.splitContainerControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.layoutControl1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1402, 681);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(3, 3);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.testItemSearchContol);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.testItemGridControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(695, 675);
            this.splitContainerControl1.SplitterPosition = 21;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // testItemSearchContol
            // 
            this.testItemSearchContol.Client = this.testItemGridControl;
            this.testItemSearchContol.Dock = System.Windows.Forms.DockStyle.Top;
            this.testItemSearchContol.Location = new System.Drawing.Point(0, 0);
            this.testItemSearchContol.Name = "testItemSearchContol";
            this.testItemSearchContol.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.testItemSearchContol.Properties.Client = this.testItemGridControl;
            this.testItemSearchContol.Size = new System.Drawing.Size(695, 20);
            this.testItemSearchContol.TabIndex = 1;
            // 
            // testItemGridControl
            // 
            this.testItemGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testItemGridControl.Location = new System.Drawing.Point(0, 0);
            this.testItemGridControl.MainView = this.testItemGridView;
            this.testItemGridControl.Name = "testItemGridControl";
            this.testItemGridControl.Size = new System.Drawing.Size(695, 644);
            this.testItemGridControl.TabIndex = 0;
            this.testItemGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.testItemGridView});
            // 
            // testItemGridView
            // 
            this.testItemGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.codeColumn,
            this.nameColumn,
            this.referenceValueColumn,
            this.enabledColumn});
            this.testItemGridView.GridControl = this.testItemGridControl;
            this.testItemGridView.Name = "testItemGridView";
            this.testItemGridView.OptionsBehavior.Editable = false;
            this.testItemGridView.OptionsView.ShowGroupPanel = false;
            this.testItemGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.TestItemGridViewRowClick);
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
            // referenceValueColumn
            // 
            this.referenceValueColumn.Caption = "참고치";
            this.referenceValueColumn.Name = "referenceValueColumn";
            this.referenceValueColumn.Visible = true;
            this.referenceValueColumn.VisibleIndex = 2;
            // 
            // enabledColumn
            // 
            this.enabledColumn.Caption = "활성화여부";
            this.enabledColumn.Name = "enabledColumn";
            this.enabledColumn.Visible = true;
            this.enabledColumn.VisibleIndex = 3;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.resetButton);
            this.layoutControl1.Controls.Add(this.saveButton);
            this.layoutControl1.Controls.Add(this.codeTextEdit);
            this.layoutControl1.Controls.Add(this.nameTextEdit);
            this.layoutControl1.Controls.Add(this.referenceMinTextEdit);
            this.layoutControl1.Controls.Add(this.referenceMaxTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(704, 3);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1458, 359, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(695, 675);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(559, 643);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(63, 22);
            this.resetButton.StyleController = this.layoutControl1;
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "초기화";
            this.resetButton.Click += new System.EventHandler(this.ResetButtonClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(622, 643);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(63, 22);
            this.saveButton.StyleController = this.layoutControl1;
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "저장";
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // codeTextEdit
            // 
            this.codeTextEdit.Location = new System.Drawing.Point(54, 48);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Size = new System.Drawing.Size(629, 20);
            this.codeTextEdit.StyleController = this.layoutControl1;
            this.codeTextEdit.TabIndex = 5;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.Location = new System.Drawing.Point(54, 72);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(629, 20);
            this.nameTextEdit.StyleController = this.layoutControl1;
            this.nameTextEdit.TabIndex = 6;
            // 
            // referenceMinTextEdit
            // 
            this.referenceMinTextEdit.Location = new System.Drawing.Point(54, 96);
            this.referenceMinTextEdit.Name = "referenceMinTextEdit";
            this.referenceMinTextEdit.Size = new System.Drawing.Size(264, 20);
            this.referenceMinTextEdit.StyleController = this.layoutControl1;
            this.referenceMinTextEdit.TabIndex = 7;
            // 
            // referenceMaxTextEdit
            // 
            this.referenceMaxTextEdit.Location = new System.Drawing.Point(401, 96);
            this.referenceMaxTextEdit.Name = "referenceMaxTextEdit";
            this.referenceMaxTextEdit.Size = new System.Drawing.Size(282, 20);
            this.referenceMaxTextEdit.StyleController = this.layoutControl1;
            this.referenceMaxTextEdit.TabIndex = 8;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem2,
            this.emptySpaceItem5,
            this.emptySpaceItem7,
            this.emptySpaceItem6,
            this.layoutControlItem1,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(695, 675);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.codeTextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(675, 24);
            this.layoutControlItem2.Text = "코드";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(30, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.nameTextEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(675, 24);
            this.layoutControlItem3.Text = "이름";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(30, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.referenceMinTextEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(310, 24);
            this.layoutControlItem4.Text = "참고치";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(30, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.referenceMaxTextEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(347, 84);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(328, 24);
            this.layoutControlItem5.Text = "~";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(30, 14);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 108);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(675, 525);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(675, 36);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(310, 84);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(37, 24);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(0, 633);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(549, 22);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.saveButton;
            this.layoutControlItem1.Location = new System.Drawing.Point(612, 633);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(63, 22);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(63, 22);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(63, 22);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.resetButton;
            this.layoutControlItem6.Location = new System.Drawing.Point(549, 633);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(63, 22);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(63, 22);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem6.Size = new System.Drawing.Size(63, 22);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(0, 0);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // testerRowContextMenu
            // 
            this.testerRowContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteContextMenu,
            this.activateContextMenu});
            this.testerRowContextMenu.Name = "contextMenuStrip1";
            this.testerRowContextMenu.Size = new System.Drawing.Size(161, 54);
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
            // TestItemContentControl
            // 
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "TestItemContentControl";
            this.Size = new System.Drawing.Size(1402, 681);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testItemSearchContol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testItemGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testItemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceMinTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceMaxTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.testerRowContextMenu.ResumeLayout(false);
            this.testerRowContextMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl testItemGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView testItemGridView;
        private DevExpress.XtraGrid.Columns.GridColumn nameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn codeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn referenceValueColumn;
        private DevExpress.XtraGrid.Columns.GridColumn enabledColumn;
        private DevExpress.XtraEditors.SearchControl testItemSearchContol;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.TextEdit codeTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit referenceMinTextEdit;
        private DevExpress.XtraEditors.TextEdit referenceMaxTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton resetButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.ContextMenuStrip testerRowContextMenu;
        private System.Windows.Forms.ToolStripTextBox deleteContextMenu;
        private System.Windows.Forms.ToolStripTextBox activateContextMenu;
    }
}
