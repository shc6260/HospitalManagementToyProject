
namespace ToyProject.View.Dialog
{
    partial class ReceptionControl
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
            this.testItemGridControl = new DevExpress.XtraGrid.GridControl();
            this.testItemGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.codeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.referenceValueColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receptionDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.specificalTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.checkupTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.insurenceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.insuredComboBox = new System.Windows.Forms.ComboBox();
            this.emergencyCheckBox = new System.Windows.Forms.CheckBox();
            this.nightCheckBox = new System.Windows.Forms.CheckBox();
            this.receptionMemoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.sd = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testItemGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testItemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificalTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkupTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurenceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionMemoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.testItemGridControl);
            this.layoutControl1.Controls.Add(this.receptionDateEdit);
            this.layoutControl1.Controls.Add(this.specificalTextEdit);
            this.layoutControl1.Controls.Add(this.checkupTextEdit);
            this.layoutControl1.Controls.Add(this.insurenceTextEdit);
            this.layoutControl1.Controls.Add(this.insuredComboBox);
            this.layoutControl1.Controls.Add(this.emergencyCheckBox);
            this.layoutControl1.Controls.Add(this.nightCheckBox);
            this.layoutControl1.Controls.Add(this.receptionMemoTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1090, 384, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(770, 733);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // testItemGridControl
            // 
            this.testItemGridControl.Location = new System.Drawing.Point(12, 133);
            this.testItemGridControl.MainView = this.testItemGridView;
            this.testItemGridControl.Name = "testItemGridControl";
            this.testItemGridControl.Size = new System.Drawing.Size(746, 346);
            this.testItemGridControl.TabIndex = 16;
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
            this.testItemGridView.OptionsSelection.CheckBoxSelectorColumnWidth = 20;
            this.testItemGridView.OptionsSelection.MultiSelect = true;
            this.testItemGridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
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
            // receptionDateEdit
            // 
            this.receptionDateEdit.EditValue = null;
            this.receptionDateEdit.Location = new System.Drawing.Point(564, 12);
            this.receptionDateEdit.Name = "receptionDateEdit";
            this.receptionDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.receptionDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.receptionDateEdit.Size = new System.Drawing.Size(194, 20);
            this.receptionDateEdit.StyleController = this.layoutControl1;
            this.receptionDateEdit.TabIndex = 10;
            // 
            // specificalTextEdit
            // 
            this.specificalTextEdit.Location = new System.Drawing.Point(84, 61);
            this.specificalTextEdit.Name = "specificalTextEdit";
            this.specificalTextEdit.Size = new System.Drawing.Size(674, 20);
            this.specificalTextEdit.StyleController = this.layoutControl1;
            this.specificalTextEdit.TabIndex = 9;
            // 
            // checkupTextEdit
            // 
            this.checkupTextEdit.Location = new System.Drawing.Point(84, 109);
            this.checkupTextEdit.Name = "checkupTextEdit";
            this.checkupTextEdit.Size = new System.Drawing.Size(674, 20);
            this.checkupTextEdit.StyleController = this.layoutControl1;
            this.checkupTextEdit.TabIndex = 8;
            // 
            // insurenceTextEdit
            // 
            this.insurenceTextEdit.Location = new System.Drawing.Point(84, 85);
            this.insurenceTextEdit.Name = "insurenceTextEdit";
            this.insurenceTextEdit.Size = new System.Drawing.Size(674, 20);
            this.insurenceTextEdit.StyleController = this.layoutControl1;
            this.insurenceTextEdit.TabIndex = 7;
            // 
            // insuredComboBox
            // 
            this.insuredComboBox.FormattingEnabled = true;
            this.insuredComboBox.Location = new System.Drawing.Point(245, 36);
            this.insuredComboBox.Name = "insuredComboBox";
            this.insuredComboBox.Size = new System.Drawing.Size(513, 20);
            this.insuredComboBox.TabIndex = 6;
            // 
            // emergencyCheckBox
            // 
            this.emergencyCheckBox.Location = new System.Drawing.Point(12, 36);
            this.emergencyCheckBox.Name = "emergencyCheckBox";
            this.emergencyCheckBox.Size = new System.Drawing.Size(71, 20);
            this.emergencyCheckBox.TabIndex = 5;
            this.emergencyCheckBox.Text = "응급";
            this.emergencyCheckBox.UseVisualStyleBackColor = true;
            // 
            // nightCheckBox
            // 
            this.nightCheckBox.Location = new System.Drawing.Point(87, 36);
            this.nightCheckBox.Name = "nightCheckBox";
            this.nightCheckBox.Size = new System.Drawing.Size(82, 20);
            this.nightCheckBox.TabIndex = 4;
            this.nightCheckBox.Text = "야간";
            this.nightCheckBox.UseVisualStyleBackColor = true;
            // 
            // receptionMemoTextEdit
            // 
            this.receptionMemoTextEdit.Location = new System.Drawing.Point(12, 501);
            this.receptionMemoTextEdit.Name = "receptionMemoTextEdit";
            this.receptionMemoTextEdit.Properties.AutoHeight = false;
            this.receptionMemoTextEdit.Size = new System.Drawing.Size(746, 220);
            this.receptionMemoTextEdit.StyleController = this.layoutControl1;
            this.receptionMemoTextEdit.TabIndex = 11;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.emptySpaceItem2,
            this.sd,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem9,
            this.simpleLabelItem1,
            this.layoutControlItem8});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(770, 733);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.nightCheckBox;
            this.layoutControlItem1.Location = new System.Drawing.Point(75, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(86, 25);
            this.layoutControlItem1.Text = "야간";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.insurenceTextEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 73);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(750, 24);
            this.layoutControlItem4.Text = "보험정보";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.checkupTextEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 97);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(750, 24);
            this.layoutControlItem5.Text = "검진정보";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.receptionDateEdit;
            this.layoutControlItem7.Location = new System.Drawing.Point(507, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(243, 24);
            this.layoutControlItem7.Text = "접수시간";
            this.layoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(40, 14);
            this.layoutControlItem7.TextToControlDistance = 5;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 471);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(750, 18);
            this.simpleLabelItem1.Text = "접수메모";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.receptionMemoTextEdit;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 489);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(54, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(750, 224);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(507, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // sd
            // 
            this.sd.Control = this.emergencyCheckBox;
            this.sd.Location = new System.Drawing.Point(0, 24);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(75, 25);
            this.sd.Text = "응급";
            this.sd.TextSize = new System.Drawing.Size(0, 0);
            this.sd.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.insuredComboBox;
            this.layoutControlItem3.Location = new System.Drawing.Point(161, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(589, 25);
            this.layoutControlItem3.Text = "급여구분";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.specificalTextEdit;
            this.layoutControlItem6.CustomizationFormText = "산정특례코드";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 49);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(750, 24);
            this.layoutControlItem6.Text = "산정특례정보";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.testItemGridControl;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 121);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(0, 350);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(750, 350);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // ReceptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ReceptionControl";
            this.Size = new System.Drawing.Size(770, 733);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testItemGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testItemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specificalTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkupTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurenceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionMemoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.DateEdit receptionDateEdit;
        private DevExpress.XtraEditors.TextEdit specificalTextEdit;
        private DevExpress.XtraEditors.TextEdit checkupTextEdit;
        private DevExpress.XtraEditors.TextEdit insurenceTextEdit;
        private System.Windows.Forms.ComboBox insuredComboBox;
        private System.Windows.Forms.CheckBox emergencyCheckBox;
        private System.Windows.Forms.CheckBox nightCheckBox;
        private DevExpress.XtraEditors.TextEdit receptionMemoTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem sd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.GridControl testItemGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView testItemGridView;
        private DevExpress.XtraGrid.Columns.GridColumn codeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn nameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn referenceValueColumn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
    }
}
