
namespace ToyProject.View.Dialog
{
    partial class CreateTestDialogForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancleButton = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.testItemGridControl = new DevExpress.XtraGrid.GridControl();
            this.testItemGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.codeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.referenceValueColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testItemGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testItemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.label2);
            this.layoutControl1.Controls.Add(this.nameTextEdit);
            this.layoutControl1.Controls.Add(this.saveButton);
            this.layoutControl1.Controls.Add(this.cancleButton);
            this.layoutControl1.Controls.Add(this.label1);
            this.layoutControl1.Controls.Add(this.testItemGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1154, 325, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(958, 424);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(923, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "검사항목";
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.Location = new System.Drawing.Point(64, 45);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(882, 20);
            this.nameTextEdit.StyleController = this.layoutControl1;
            this.nameTextEdit.TabIndex = 21;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(325, 390);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(308, 22);
            this.saveButton.StyleController = this.layoutControl1;
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "저장";
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // cancleButton
            // 
            this.cancleButton.Location = new System.Drawing.Point(637, 390);
            this.cancleButton.Name = "cancleButton";
            this.cancleButton.Size = new System.Drawing.Size(309, 22);
            this.cancleButton.StyleController = this.layoutControl1;
            this.cancleButton.TabIndex = 19;
            this.cancleButton.Text = "닫기";
            this.cancleButton.Click += new System.EventHandler(this.CancleButtonClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(923, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "검사등록";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testItemGridControl
            // 
            this.testItemGridControl.Location = new System.Drawing.Point(12, 93);
            this.testItemGridControl.MainView = this.testItemGridView;
            this.testItemGridControl.Name = "testItemGridControl";
            this.testItemGridControl.Size = new System.Drawing.Size(934, 293);
            this.testItemGridControl.TabIndex = 17;
            this.testItemGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.testItemGridView});
            // 
            // testItemGridView
            // 
            this.testItemGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.codeColumn,
            this.nameColumn,
            this.referenceValueColumn});
            this.testItemGridView.GridControl = this.testItemGridControl;
            this.testItemGridView.Name = "testItemGridView";
            this.testItemGridView.OptionsBehavior.Editable = false;
            this.testItemGridView.OptionsFind.AlwaysVisible = true;
            this.testItemGridView.OptionsFind.FindDelay = 300;
            this.testItemGridView.OptionsFind.FindNullPrompt = "검사명 검색..";
            this.testItemGridView.OptionsSelection.CheckBoxSelectorColumnWidth = 20;
            this.testItemGridView.OptionsSelection.MultiSelect = true;
            this.testItemGridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.testItemGridView.OptionsView.ShowGroupPanel = false;
            // 
            // codeColumn
            // 
            this.codeColumn.Caption = "코드";
            this.codeColumn.Name = "codeColumn";
            this.codeColumn.Visible = true;
            this.codeColumn.VisibleIndex = 2;
            // 
            // nameColumn
            // 
            this.nameColumn.Caption = "이름";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Visible = true;
            this.nameColumn.VisibleIndex = 1;
            // 
            // referenceValueColumn
            // 
            this.referenceValueColumn.Caption = "참고치";
            this.referenceValueColumn.Name = "referenceValueColumn";
            this.referenceValueColumn.Visible = true;
            this.referenceValueColumn.VisibleIndex = 3;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(958, 424);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.testItemGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 81);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(938, 297);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.label1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(927, 33);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(927, 33);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(938, 33);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "검사등록";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cancleButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(625, 378);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(313, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.saveButton;
            this.layoutControlItem4.Location = new System.Drawing.Point(313, 378);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(312, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 378);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(313, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.nameTextEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 33);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(938, 24);
            this.layoutControlItem5.Text = "검사이름";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(40, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.label2;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 57);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(927, 24);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(927, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(938, 24);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "검사항목";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // CreateTestDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 424);
            this.Controls.Add(this.layoutControl1);
            this.Name = "CreateTestDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testItemGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testItemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl testItemGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView testItemGridView;
        private DevExpress.XtraGrid.Columns.GridColumn codeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn nameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn referenceValueColumn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton cancleButton;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}
