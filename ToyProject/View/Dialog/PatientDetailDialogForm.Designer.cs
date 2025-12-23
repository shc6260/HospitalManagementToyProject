
namespace ToyProject.View
{
    partial class PatientDetailDialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.testResultView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.desisionColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.judgementColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.testDateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.equipmentColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.testerColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.testGridControl = new DevExpress.XtraGrid.GridControl();
            this.testGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.receptionDateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.testCodeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.testNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.testItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.referenceValueColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FooterStackPanel = new DevExpress.Utils.Layout.StackPanel();
            this.CloseBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SaveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.FooterPanel = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.patientEditControl = new ToyProject.View.PatientEditControl();
            ((System.ComponentModel.ISupportInitialize)(this.testResultView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FooterStackPanel)).BeginInit();
            this.FooterStackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FooterPanel)).BeginInit();
            this.FooterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
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
            this.testResultView.OptionsBehavior.ReadOnly = true;
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
            this.equipmentColumn.Name = "equipmentColumn";
            this.equipmentColumn.Visible = true;
            this.equipmentColumn.VisibleIndex = 3;
            // 
            // testerColumn
            // 
            this.testerColumn.Caption = "검사자";
            this.testerColumn.Name = "testerColumn";
            this.testerColumn.Visible = true;
            this.testerColumn.VisibleIndex = 4;
            // 
            // testGridControl
            // 
            this.tablePanel2.SetColumn(this.testGridControl, 1);
            this.testGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.testResultView;
            gridLevelNode1.RelationName = "Results";
            this.testGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.testGridControl.Location = new System.Drawing.Point(586, 0);
            this.testGridControl.MainView = this.testGridView;
            this.testGridControl.Margin = new System.Windows.Forms.Padding(0);
            this.testGridControl.Name = "testGridControl";
            this.tablePanel2.SetRow(this.testGridControl, 0);
            this.testGridControl.Size = new System.Drawing.Size(586, 529);
            this.testGridControl.TabIndex = 5;
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
            this.testNameColumn,
            this.testItemName,
            this.referenceValueColumn});
            this.testGridView.GridControl = this.testGridControl;
            this.testGridView.GroupCount = 2;
            this.testGridView.Name = "testGridView";
            this.testGridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.testGridView.OptionsBehavior.ReadOnly = true;
            this.testGridView.OptionsDetail.AllowExpandEmptyDetails = true;
            this.testGridView.OptionsDetail.ShowDetailTabs = false;
            this.testGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.testGridView.OptionsView.ShowGroupPanel = false;
            this.testGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.receptionDateColumn, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.testCodeColumn, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.testGridView.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.TestGridViewCustomDrawGroupRow);
            this.testGridView.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.TestGridViewCustomDrawEmptyForeground);
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
            // testNameColumn
            // 
            this.testNameColumn.Caption = "검사명";
            this.testNameColumn.Name = "testNameColumn";
            this.testNameColumn.Visible = true;
            this.testNameColumn.VisibleIndex = 0;
            // 
            // testItemName
            // 
            this.testItemName.Caption = "검사항목이름";
            this.testItemName.Name = "testItemName";
            this.testItemName.Visible = true;
            this.testItemName.VisibleIndex = 1;
            // 
            // referenceValueColumn
            // 
            this.referenceValueColumn.Caption = "참고치";
            this.referenceValueColumn.Name = "referenceValueColumn";
            this.referenceValueColumn.Visible = true;
            this.referenceValueColumn.VisibleIndex = 2;
            // 
            // FooterStackPanel
            // 
            this.FooterStackPanel.AutoSize = true;
            this.FooterPanel.SetColumn(this.FooterStackPanel, 0);
            this.FooterStackPanel.Controls.Add(this.CloseBtn);
            this.FooterStackPanel.Controls.Add(this.SaveBtn);
            this.FooterStackPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.FooterStackPanel.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.RightToLeft;
            this.FooterStackPanel.Location = new System.Drawing.Point(1040, 538);
            this.FooterStackPanel.Name = "FooterStackPanel";
            this.FooterPanel.SetRow(this.FooterStackPanel, 1);
            this.FooterStackPanel.Size = new System.Drawing.Size(135, 47);
            this.FooterStackPanel.TabIndex = 2;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(69, 12);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(63, 22);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "닫기";
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(0, 12);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(63, 22);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "저장";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // FooterPanel
            // 
            this.FooterPanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.FooterPanel.Controls.Add(this.FooterStackPanel);
            this.FooterPanel.Controls.Add(this.tablePanel2);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FooterPanel.Location = new System.Drawing.Point(10, 10);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 535F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.FooterPanel.Size = new System.Drawing.Size(1178, 588);
            this.FooterPanel.TabIndex = 0;
            // 
            // tablePanel2
            // 
            this.tablePanel2.AutoSize = true;
            this.FooterPanel.SetColumn(this.tablePanel2, 0);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)});
            this.tablePanel2.Controls.Add(this.testGridControl);
            this.tablePanel2.Controls.Add(this.patientEditControl);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(3, 3);
            this.tablePanel2.Name = "tablePanel2";
            this.FooterPanel.SetRow(this.tablePanel2, 0);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(1172, 529);
            this.tablePanel2.TabIndex = 0;
            // 
            // patientEditControl
            // 
            this.tablePanel2.SetColumn(this.patientEditControl, 0);
            this.patientEditControl.Location = new System.Drawing.Point(3, 3);
            this.patientEditControl.Name = "patientEditControl";
            this.tablePanel2.SetRow(this.patientEditControl, 0);
            this.patientEditControl.Size = new System.Drawing.Size(580, 523);
            this.patientEditControl.TabIndex = 0;
            // 
            // PatientDetailDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 608);
            this.Controls.Add(this.FooterPanel);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(1200, 640);
            this.Name = "PatientDetailDialogForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "환자상세";
            ((System.ComponentModel.ISupportInitialize)(this.testResultView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FooterStackPanel)).EndInit();
            this.FooterStackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FooterPanel)).EndInit();
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.StackPanel FooterStackPanel;
        private DevExpress.XtraEditors.SimpleButton SaveBtn;
        private DevExpress.XtraEditors.SimpleButton CloseBtn;
        private DevExpress.Utils.Layout.TablePanel FooterPanel;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private PatientEditControl patientEditControl;
        private DevExpress.XtraGrid.GridControl testGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView testResultView;
        private DevExpress.XtraGrid.Columns.GridColumn desisionColumn;
        private DevExpress.XtraGrid.Columns.GridColumn judgementColumn;
        private DevExpress.XtraGrid.Columns.GridColumn testDateColumn;
        private DevExpress.XtraGrid.Columns.GridColumn equipmentColumn;
        private DevExpress.XtraGrid.Columns.GridColumn testerColumn;
        private DevExpress.XtraGrid.Views.Grid.GridView testGridView;
        private DevExpress.XtraGrid.Columns.GridColumn receptionDateColumn;
        private DevExpress.XtraGrid.Columns.GridColumn testCodeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn testNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn testItemName;
        private DevExpress.XtraGrid.Columns.GridColumn referenceValueColumn;
    }
}