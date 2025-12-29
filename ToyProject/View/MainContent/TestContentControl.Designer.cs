
namespace ToyProject.View
{
    partial class TestContentControl
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.testResultView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.desisionColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.judgementColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.testDateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.equipmentColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.equipmentComboboxEdit = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.testerColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.testerComboboxEdit = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.testGridControl = new DevExpress.XtraGrid.GridControl();
            this.testGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.receptionDateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.testCodeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.patientNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.testNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.testItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.referenceValueColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addResultcolumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addResultButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.statusCheckedComboBox = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.refreshButton = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.testContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.progressMenu = new System.Windows.Forms.ToolStripTextBox();
            this.completeMenu = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.testResultView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentComboboxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerComboboxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addResultButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusCheckedComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.testContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // testResultView
            // 
            this.testResultView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.desisionColumn,
            this.judgementColumn,
            this.testDateColumn,
            this.equipmentColumn,
            this.testerColumn});
            this.testResultView.GridControl = this.testGridControl;
            this.testResultView.Name = "testResultView";
            this.testResultView.OptionsView.ShowGroupPanel = false;
            // 
            // desisionColumn
            // 
            this.desisionColumn.Caption = "결과";
            this.desisionColumn.Name = "desisionColumn";
            this.desisionColumn.Visible = true;
            this.desisionColumn.VisibleIndex = 0;
            // 
            // judgementColumn
            // 
            this.judgementColumn.Caption = "판정값";
            this.judgementColumn.Name = "judgementColumn";
            this.judgementColumn.Visible = true;
            this.judgementColumn.VisibleIndex = 1;
            // 
            // testDateColumn
            // 
            this.testDateColumn.Caption = "검사일";
            this.testDateColumn.Name = "testDateColumn";
            this.testDateColumn.Visible = true;
            this.testDateColumn.VisibleIndex = 2;
            // 
            // equipmentColumn
            // 
            this.equipmentColumn.Caption = "검사장비";
            this.equipmentColumn.ColumnEdit = this.equipmentComboboxEdit;
            this.equipmentColumn.Name = "equipmentColumn";
            this.equipmentColumn.Visible = true;
            this.equipmentColumn.VisibleIndex = 3;
            // 
            // equipmentComboboxEdit
            // 
            this.equipmentComboboxEdit.AutoHeight = false;
            this.equipmentComboboxEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.equipmentComboboxEdit.Name = "equipmentComboboxEdit";
            // 
            // testerColumn
            // 
            this.testerColumn.Caption = "검사자";
            this.testerColumn.ColumnEdit = this.testerComboboxEdit;
            this.testerColumn.Name = "testerColumn";
            this.testerColumn.Visible = true;
            this.testerColumn.VisibleIndex = 4;
            // 
            // testerComboboxEdit
            // 
            this.testerComboboxEdit.AutoHeight = false;
            this.testerComboboxEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.testerComboboxEdit.Name = "testerComboboxEdit";
            // 
            // testGridControl
            // 
            gridLevelNode1.LevelTemplate = this.testResultView;
            gridLevelNode1.RelationName = "TestResults";
            this.testGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.testGridControl.Location = new System.Drawing.Point(12, 38);
            this.testGridControl.MainView = this.testGridView;
            this.testGridControl.Margin = new System.Windows.Forms.Padding(0);
            this.testGridControl.Name = "testGridControl";
            this.testGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.equipmentComboboxEdit,
            this.testerComboboxEdit,
            this.addResultButton});
            this.testGridControl.Size = new System.Drawing.Size(1130, 645);
            this.testGridControl.TabIndex = 4;
            this.testGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.testGridView,
            this.testResultView});
            // 
            // testGridView
            // 
            this.testGridView.ActiveFilterEnabled = false;
            this.testGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.receptionDateColumn,
            this.testCodeColumn,
            this.patientNameColumn,
            this.testNameColumn,
            this.testItemName,
            this.referenceValueColumn,
            this.addResultcolumn});
            this.testGridView.GridControl = this.testGridControl;
            this.testGridView.GroupCount = 2;
            this.testGridView.Name = "testGridView";
            this.testGridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.testGridView.OptionsDetail.AllowExpandEmptyDetails = true;
            this.testGridView.OptionsDetail.ShowDetailTabs = false;
            this.testGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.testGridView.OptionsView.ShowGroupPanel = false;
            this.testGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.receptionDateColumn, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.testCodeColumn, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.patientNameColumn, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.testGridView.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.TestGridViewCustomDrawGroupRow);
            this.testGridView.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.TestGridViewPopupMenuShowing);
            // 
            // receptionDateColumn
            // 
            this.receptionDateColumn.Caption = "접수일";
            this.receptionDateColumn.FieldName = "gridColumn1";
            this.receptionDateColumn.Name = "receptionDateColumn";
            this.receptionDateColumn.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.receptionDateColumn.Visible = true;
            this.receptionDateColumn.VisibleIndex = 0;
            // 
            // testCodeColumn
            // 
            this.testCodeColumn.Caption = "검사코드";
            this.testCodeColumn.Name = "testCodeColumn";
            this.testCodeColumn.Visible = true;
            this.testCodeColumn.VisibleIndex = 0;
            // 
            // patientNameColumn
            // 
            this.patientNameColumn.Caption = "환자이름";
            this.patientNameColumn.Name = "patientNameColumn";
            // 
            // testNameColumn
            // 
            this.testNameColumn.Caption = "검사명";
            this.testNameColumn.Name = "testNameColumn";
            // 
            // testItemName
            // 
            this.testItemName.Caption = "검사항목이름";
            this.testItemName.Name = "testItemName";
            this.testItemName.Visible = true;
            this.testItemName.VisibleIndex = 0;
            this.testItemName.Width = 368;
            // 
            // referenceValueColumn
            // 
            this.referenceValueColumn.Caption = "참고치";
            this.referenceValueColumn.Name = "referenceValueColumn";
            this.referenceValueColumn.Visible = true;
            this.referenceValueColumn.VisibleIndex = 1;
            this.referenceValueColumn.Width = 368;
            // 
            // addResultcolumn
            // 
            this.addResultcolumn.ColumnEdit = this.addResultButton;
            this.addResultcolumn.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.addResultcolumn.Name = "addResultcolumn";
            this.addResultcolumn.Visible = true;
            this.addResultcolumn.VisibleIndex = 2;
            this.addResultcolumn.Width = 100;
            // 
            // addResultButton
            // 
            this.addResultButton.AutoHeight = false;
            serializableAppearanceObject1.BackColor = System.Drawing.Color.Gainsboro;
            serializableAppearanceObject1.BackColor2 = System.Drawing.Color.Gainsboro;
            serializableAppearanceObject1.Options.UseBackColor = true;
            this.addResultButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "결과추가", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.addResultButton.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.addResultButton.Name = "addResultButton";
            this.addResultButton.NullText = "결과추가";
            this.addResultButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.addResultButton.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.RepositoryItemButtonEditButtonClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.statusCheckedComboBox);
            this.layoutControl1.Controls.Add(this.saveButton);
            this.layoutControl1.Controls.Add(this.refreshButton);
            this.layoutControl1.Controls.Add(this.testGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(-861, 709, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1154, 721);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "새로고침";
            // 
            // statusCheckedComboBox
            // 
            this.statusCheckedComboBox.Location = new System.Drawing.Point(68, 12);
            this.statusCheckedComboBox.Name = "statusCheckedComboBox";
            this.statusCheckedComboBox.Properties.AllowMultiSelect = true;
            this.statusCheckedComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.statusCheckedComboBox.Properties.ShowButtons = false;
            this.statusCheckedComboBox.Properties.ShowPopupCloseButton = false;
            this.statusCheckedComboBox.Size = new System.Drawing.Size(239, 20);
            this.statusCheckedComboBox.StyleController = this.layoutControl1;
            this.statusCheckedComboBox.TabIndex = 6;
            this.statusCheckedComboBox.EditValueChanged += new System.EventHandler(this.StatusCheckedComboBoxEditValueChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1040, 687);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(102, 22);
            this.saveButton.StyleController = this.layoutControl1;
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "저장";
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(1040, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(102, 22);
            this.refreshButton.StyleController = this.layoutControl1;
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "새로고침";
            this.refreshButton.Click += new System.EventHandler(this.RefreshButtonClick);
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
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1154, 721);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.testGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1134, 649);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.refreshButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(1028, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(106, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.saveButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(1028, 675);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(106, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.statusCheckedComboBox;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(299, 26);
            this.layoutControlItem4.Text = "검사 상태";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(44, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(299, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(729, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 675);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(1028, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // testContextMenu
            // 
            this.testContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressMenu,
            this.completeMenu});
            this.testContextMenu.Name = "testContextMenu";
            this.testContextMenu.Size = new System.Drawing.Size(161, 54);
            // 
            // progressMenu
            // 
            this.progressMenu.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.progressMenu.Name = "progressMenu";
            this.progressMenu.Size = new System.Drawing.Size(100, 23);
            this.progressMenu.Text = "검사 시작";
            this.progressMenu.Click += new System.EventHandler(this.ProgressMenuClick);
            // 
            // completeMenu
            // 
            this.completeMenu.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.completeMenu.Name = "completeMenu";
            this.completeMenu.Size = new System.Drawing.Size(100, 23);
            this.completeMenu.Text = "검사 완료";
            this.completeMenu.Click += new System.EventHandler(this.CompleteMenuClick);
            // 
            // TestContentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "TestContentControl";
            this.Size = new System.Drawing.Size(1154, 721);
            ((System.ComponentModel.ISupportInitialize)(this.testResultView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentComboboxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerComboboxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addResultButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusCheckedComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.testContextMenu.ResumeLayout(false);
            this.testContextMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl testGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView testGridView;
        private DevExpress.XtraGrid.Columns.GridColumn receptionDateColumn;
        private DevExpress.XtraGrid.Columns.GridColumn testCodeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn patientNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn testNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn testItemName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton refreshButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn referenceValueColumn;
        private DevExpress.XtraGrid.Views.Grid.GridView testResultView;
        private DevExpress.XtraGrid.Columns.GridColumn desisionColumn;
        private DevExpress.XtraGrid.Columns.GridColumn judgementColumn;
        private DevExpress.XtraGrid.Columns.GridColumn testDateColumn;
        private DevExpress.XtraGrid.Columns.GridColumn equipmentColumn;
        private DevExpress.XtraGrid.Columns.GridColumn testerColumn;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox equipmentComboboxEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox testerComboboxEdit;
        private System.Windows.Forms.ContextMenuStrip testContextMenu;
        private System.Windows.Forms.ToolStripTextBox progressMenu;
        private System.Windows.Forms.ToolStripTextBox completeMenu;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit addResultButton;
        private DevExpress.XtraGrid.Columns.GridColumn addResultcolumn;
        private DevExpress.XtraEditors.CheckedComboBoxEdit statusCheckedComboBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}
