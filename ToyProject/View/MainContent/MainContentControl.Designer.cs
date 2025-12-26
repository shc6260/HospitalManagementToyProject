
namespace ToyProject.View
{
    partial class MainContentControl
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.receptionGridControl = new DevExpress.XtraGrid.GridControl();
            this.receptionGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chartNumberColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receptionDtColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.fromDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.receptionSearchButton = new DevExpress.XtraEditors.SimpleButton();
            this.todayButton = new DevExpress.XtraEditors.SimpleButton();
            this.prevButton = new DevExpress.XtraEditors.SimpleButton();
            this.nextButton = new DevExpress.XtraEditors.SimpleButton();
            this.weekdateButton = new DevExpress.XtraEditors.SimpleButton();
            this.monthdateButton = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.equipRowContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editReceptionMenu = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receptionGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            this.equipRowContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.receptionGridControl);
            this.layoutControl1.Controls.Add(this.toDateEdit);
            this.layoutControl1.Controls.Add(this.fromDateEdit);
            this.layoutControl1.Controls.Add(this.receptionSearchButton);
            this.layoutControl1.Controls.Add(this.todayButton);
            this.layoutControl1.Controls.Add(this.prevButton);
            this.layoutControl1.Controls.Add(this.nextButton);
            this.layoutControl1.Controls.Add(this.weekdateButton);
            this.layoutControl1.Controls.Add(this.monthdateButton);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(344, 443, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1200, 692);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // receptionGridControl
            // 
            this.receptionGridControl.Location = new System.Drawing.Point(12, 38);
            this.receptionGridControl.MainView = this.receptionGridView;
            this.receptionGridControl.Name = "receptionGridControl";
            this.receptionGridControl.Size = new System.Drawing.Size(1176, 642);
            this.receptionGridControl.TabIndex = 6;
            this.receptionGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.receptionGridView});
            // 
            // receptionGridView
            // 
            this.receptionGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameColumn,
            this.chartNumberColumn,
            this.receptionDtColumn});
            this.receptionGridView.GridControl = this.receptionGridControl;
            this.receptionGridView.Name = "receptionGridView";
            this.receptionGridView.OptionsBehavior.Editable = false;
            this.receptionGridView.OptionsView.ShowGroupPanel = false;
            this.receptionGridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ReceptionGridViewMouseUp);
            // 
            // nameColumn
            // 
            this.nameColumn.Caption = "이름";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Visible = true;
            this.nameColumn.VisibleIndex = 0;
            // 
            // chartNumberColumn
            // 
            this.chartNumberColumn.Caption = "차트번호";
            this.chartNumberColumn.Name = "chartNumberColumn";
            this.chartNumberColumn.Visible = true;
            this.chartNumberColumn.VisibleIndex = 1;
            // 
            // receptionDtColumn
            // 
            this.receptionDtColumn.Caption = "접수일시";
            this.receptionDtColumn.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.receptionDtColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.receptionDtColumn.FieldName = "receptionDtColumn";
            this.receptionDtColumn.Name = "receptionDtColumn";
            this.receptionDtColumn.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.receptionDtColumn.Visible = true;
            this.receptionDtColumn.VisibleIndex = 2;
            // 
            // toDateEdit
            // 
            this.toDateEdit.EditValue = null;
            this.toDateEdit.Location = new System.Drawing.Point(252, 13);
            this.toDateEdit.Name = "toDateEdit";
            this.toDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDateEdit.Size = new System.Drawing.Size(156, 20);
            this.toDateEdit.StyleController = this.layoutControl1;
            this.toDateEdit.TabIndex = 5;
            // 
            // fromDateEdit
            // 
            this.fromDateEdit.EditValue = null;
            this.fromDateEdit.Location = new System.Drawing.Point(54, 13);
            this.fromDateEdit.Name = "fromDateEdit";
            this.fromDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDateEdit.Size = new System.Drawing.Size(154, 20);
            this.fromDateEdit.StyleController = this.layoutControl1;
            this.fromDateEdit.TabIndex = 4;
            this.fromDateEdit.DateTimeChanged += new System.EventHandler(this.FromDateEditDateTimeChanged);
            // 
            // receptionSearchButton
            // 
            this.receptionSearchButton.Location = new System.Drawing.Point(816, 13);
            this.receptionSearchButton.Name = "receptionSearchButton";
            this.receptionSearchButton.Size = new System.Drawing.Size(372, 20);
            this.receptionSearchButton.StyleController = this.layoutControl1;
            this.receptionSearchButton.TabIndex = 7;
            this.receptionSearchButton.Text = "조회";
            this.receptionSearchButton.Click += new System.EventHandler(this.ReceptionSearchButtonClick);
            // 
            // todayButton
            // 
            this.todayButton.Location = new System.Drawing.Point(572, 13);
            this.todayButton.Name = "todayButton";
            this.todayButton.Size = new System.Drawing.Size(56, 20);
            this.todayButton.StyleController = this.layoutControl1;
            this.todayButton.TabIndex = 7;
            this.todayButton.Text = "오늘";
            this.todayButton.Click += new System.EventHandler(this.TodayButtonClick);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(412, 12);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(16, 22);
            this.prevButton.StyleController = this.layoutControl1;
            this.prevButton.TabIndex = 8;
            this.prevButton.Text = "<";
            this.prevButton.Click += new System.EventHandler(this.PrevButtonClick);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(432, 12);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(16, 22);
            this.nextButton.StyleController = this.layoutControl1;
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = ">";
            this.nextButton.Click += new System.EventHandler(this.NextButtonClick);
            // 
            // weekdateButton
            // 
            this.weekdateButton.Location = new System.Drawing.Point(452, 12);
            this.weekdateButton.Name = "weekdateButton";
            this.weekdateButton.Size = new System.Drawing.Size(56, 22);
            this.weekdateButton.StyleController = this.layoutControl1;
            this.weekdateButton.TabIndex = 10;
            this.weekdateButton.Text = "이번주";
            this.weekdateButton.Click += new System.EventHandler(this.WeekdateButtonClick);
            // 
            // monthdateButton
            // 
            this.monthdateButton.Location = new System.Drawing.Point(512, 12);
            this.monthdateButton.Name = "monthdateButton";
            this.monthdateButton.Size = new System.Drawing.Size(56, 22);
            this.monthdateButton.StyleController = this.layoutControl1;
            this.monthdateButton.TabIndex = 11;
            this.monthdateButton.Text = "이번달";
            this.monthdateButton.Click += new System.EventHandler(this.MonthdateButtonClick);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem10});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1200, 692);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem2.Control = this.toDateEdit;
            this.layoutControlItem2.CustomizationFormText = "   ~";
            this.layoutControlItem2.Location = new System.Drawing.Point(200, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2);
            this.layoutControlItem2.Size = new System.Drawing.Size(200, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = " ~";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(20, 14);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(620, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(184, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.receptionGridControl;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1180, 646);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem5.Control = this.todayButton;
            this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem5.Location = new System.Drawing.Point(560, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(31, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(60, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "layoutControlItem4";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem4.Control = this.receptionSearchButton;
            this.layoutControlItem4.Location = new System.Drawing.Point(804, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(31, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(376, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem1.Control = this.fromDateEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(200, 26);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0);
            this.layoutControlItem1.Text = "날짜";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(20, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.prevButton;
            this.layoutControlItem6.Location = new System.Drawing.Point(400, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(20, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.nextButton;
            this.layoutControlItem7.Location = new System.Drawing.Point(420, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(20, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.weekdateButton;
            this.layoutControlItem8.Location = new System.Drawing.Point(440, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(60, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.monthdateButton;
            this.layoutControlItem10.Location = new System.Drawing.Point(500, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(60, 26);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // equipRowContextMenu
            // 
            this.equipRowContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editReceptionMenu});
            this.equipRowContextMenu.Name = "contextMenuStrip1";
            this.equipRowContextMenu.Size = new System.Drawing.Size(161, 29);
            // 
            // editReceptionMenu
            // 
            this.editReceptionMenu.Name = "editReceptionMenu";
            this.editReceptionMenu.ReadOnly = true;
            this.editReceptionMenu.Size = new System.Drawing.Size(100, 23);
            this.editReceptionMenu.Text = "수정";
            this.editReceptionMenu.Click += new System.EventHandler(this.EditReceptionMenuClick);
            // 
            // MainContentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "MainContentControl";
            this.Size = new System.Drawing.Size(1200, 692);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receptionGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            this.equipRowContextMenu.ResumeLayout(false);
            this.equipRowContextMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.DateEdit toDateEdit;
        private DevExpress.XtraEditors.DateEdit fromDateEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl receptionGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView receptionGridView;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton receptionSearchButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn nameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn chartNumberColumn;
        private DevExpress.XtraGrid.Columns.GridColumn receptionDtColumn;
        private DevExpress.XtraEditors.SimpleButton todayButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.ContextMenuStrip equipRowContextMenu;
        private System.Windows.Forms.ToolStripTextBox editReceptionMenu;
        private DevExpress.XtraEditors.SimpleButton prevButton;
        private DevExpress.XtraEditors.SimpleButton nextButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton weekdateButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.SimpleButton monthdateButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
    }
}
