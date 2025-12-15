
namespace ToyProject
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.newReceptionPatientButton = new DevExpress.XtraEditors.SimpleButton();
            this.newPatientButton = new DevExpress.XtraEditors.SimpleButton();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            this.popupContainerControl2 = new DevExpress.XtraEditors.PopupContainerControl();
            this.gnbSearchGrid = new DevExpress.XtraGrid.GridControl();
            this.gnbGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chartNumberColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phoneNumberColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.genderColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.socialSecurityNumberColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addressColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receptionColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gnbSearchEdit = new DevExpress.XtraEditors.PopupContainerEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.mainMenuControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.mainTab = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.testTab = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.testerTab = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.equipmentTab = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.testItemTab = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.mainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl2)).BeginInit();
            this.popupContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gnbSearchGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gnbGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gnbSearchEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.layoutControl1);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(250, 31);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(697, 635);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.White;
            this.layoutControl1.Controls.Add(this.newReceptionPatientButton);
            this.layoutControl1.Controls.Add(this.newPatientButton);
            this.layoutControl1.Controls.Add(this.mainPanel);
            this.layoutControl1.Controls.Add(this.gnbSearchEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(-1368, 459, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(697, 635);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // newReceptionPatientButton
            // 
            this.newReceptionPatientButton.Location = new System.Drawing.Point(587, 36);
            this.newReceptionPatientButton.Name = "newReceptionPatientButton";
            this.newReceptionPatientButton.Size = new System.Drawing.Size(100, 26);
            this.newReceptionPatientButton.StyleController = this.layoutControl1;
            this.newReceptionPatientButton.TabIndex = 10;
            this.newReceptionPatientButton.Text = "신환접수";
            this.newReceptionPatientButton.Click += new System.EventHandler(this.NewReceptionPatientButtonClick);
            // 
            // newPatientButton
            // 
            this.newPatientButton.Location = new System.Drawing.Point(587, 10);
            this.newPatientButton.Margin = new System.Windows.Forms.Padding(0);
            this.newPatientButton.Name = "newPatientButton";
            this.newPatientButton.Size = new System.Drawing.Size(100, 26);
            this.newPatientButton.StyleController = this.layoutControl1;
            this.newPatientButton.TabIndex = 11;
            this.newPatientButton.Text = "환자등록";
            this.newPatientButton.Click += new System.EventHandler(this.NewPatientButtonClick);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.popupContainerControl2);
            this.mainPanel.Location = new System.Drawing.Point(10, 62);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(677, 563);
            this.mainPanel.TabIndex = 14;
            // 
            // popupContainerControl2
            // 
            this.popupContainerControl2.AutoSize = true;
            this.popupContainerControl2.Controls.Add(this.gnbSearchGrid);
            this.popupContainerControl2.Location = new System.Drawing.Point(78, 50);
            this.popupContainerControl2.Name = "popupContainerControl2";
            this.popupContainerControl2.Size = new System.Drawing.Size(522, 195);
            this.popupContainerControl2.TabIndex = 14;
            // 
            // gnbSearchGrid
            // 
            this.gnbSearchGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gnbSearchGrid.Location = new System.Drawing.Point(0, 0);
            this.gnbSearchGrid.MainView = this.gnbGridView;
            this.gnbSearchGrid.Name = "gnbSearchGrid";
            this.gnbSearchGrid.Size = new System.Drawing.Size(522, 195);
            this.gnbSearchGrid.TabIndex = 1;
            this.gnbSearchGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gnbGridView});
            // 
            // gnbGridView
            // 
            this.gnbGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameColumn,
            this.chartNumberColumn,
            this.phoneNumberColumn,
            this.genderColumn,
            this.socialSecurityNumberColumn,
            this.addressColumn,
            this.receptionColumn});
            this.gnbGridView.GridControl = this.gnbSearchGrid;
            this.gnbGridView.Name = "gnbGridView";
            this.gnbGridView.OptionsBehavior.Editable = false;
            this.gnbGridView.OptionsView.ShowGroupPanel = false;
            this.gnbGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gnbGridView_RowClick);
            // 
            // nameColumn
            // 
            this.nameColumn.Caption = "이름";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Visible = true;
            this.nameColumn.VisibleIndex = 3;
            // 
            // chartNumberColumn
            // 
            this.chartNumberColumn.Caption = "차트번호";
            this.chartNumberColumn.Name = "chartNumberColumn";
            this.chartNumberColumn.Visible = true;
            this.chartNumberColumn.VisibleIndex = 0;
            // 
            // phoneNumberColumn
            // 
            this.phoneNumberColumn.Caption = "전화번호";
            this.phoneNumberColumn.Name = "phoneNumberColumn";
            this.phoneNumberColumn.Visible = true;
            this.phoneNumberColumn.VisibleIndex = 1;
            // 
            // genderColumn
            // 
            this.genderColumn.Caption = "성별";
            this.genderColumn.Name = "genderColumn";
            this.genderColumn.Visible = true;
            this.genderColumn.VisibleIndex = 2;
            // 
            // socialSecurityNumberColumn
            // 
            this.socialSecurityNumberColumn.Caption = "주민등록번호";
            this.socialSecurityNumberColumn.Name = "socialSecurityNumberColumn";
            this.socialSecurityNumberColumn.Visible = true;
            this.socialSecurityNumberColumn.VisibleIndex = 4;
            // 
            // addressColumn
            // 
            this.addressColumn.Caption = "주소";
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.Visible = true;
            this.addressColumn.VisibleIndex = 5;
            // 
            // receptionColumn
            // 
            this.receptionColumn.Name = "receptionColumn";
            this.receptionColumn.Visible = true;
            this.receptionColumn.VisibleIndex = 6;
            // 
            // gnbSearchEdit
            // 
            this.gnbSearchEdit.Location = new System.Drawing.Point(12, 12);
            this.gnbSearchEdit.Name = "gnbSearchEdit";
            this.gnbSearchEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gnbSearchEdit.Properties.PopupControl = this.popupContainerControl2;
            this.gnbSearchEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gnbSearchEdit.Size = new System.Drawing.Size(573, 20);
            this.gnbSearchEdit.StyleController = this.layoutControl1;
            this.gnbSearchEdit.TabIndex = 9;
            this.gnbSearchEdit.EditValueChanged += new System.EventHandler(this.gnbSearchEdit_EditValueChanged);
            this.gnbSearchEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GnbPatientSearchEdit_KeyDown);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(697, 635);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.mainPanel;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem2.Size = new System.Drawing.Size(677, 563);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gnbSearchEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(577, 52);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.newPatientButton;
            this.layoutControlItem4.Location = new System.Drawing.Point(577, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem4.Size = new System.Drawing.Size(100, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.newReceptionPatientButton;
            this.layoutControlItem5.Location = new System.Drawing.Point(577, 26);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(100, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem5.Size = new System.Drawing.Size(100, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // mainMenuControl
            // 
            this.mainMenuControl.AllowItemSelection = true;
            this.mainMenuControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainMenuControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mainTab,
            this.testTab,
            this.accordionControlSeparator1,
            this.accordionControlElement3});
            this.mainMenuControl.Location = new System.Drawing.Point(0, 31);
            this.mainMenuControl.Name = "mainMenuControl";
            this.mainMenuControl.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.mainMenuControl.Size = new System.Drawing.Size(250, 635);
            this.mainMenuControl.TabIndex = 1;
            this.mainMenuControl.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            this.mainMenuControl.SelectedElementChanged += new DevExpress.XtraBars.Navigation.SelectedElementChangedEventHandler(this.SelectedMainMenu);
            // 
            // mainTab
            // 
            this.mainTab.Name = "mainTab";
            this.mainTab.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mainTab.Text = "메인";
            // 
            // testTab
            // 
            this.testTab.Name = "testTab";
            this.testTab.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.testTab.Text = "검사";
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.testerTab,
            this.equipmentTab,
            this.testItemTab});
            this.accordionControlElement3.Expanded = true;
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "병원관리";
            // 
            // testerTab
            // 
            this.testerTab.Name = "testerTab";
            this.testerTab.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.testerTab.Text = "검사자관리";
            // 
            // equipmentTab
            // 
            this.equipmentTab.Name = "equipmentTab";
            this.equipmentTab.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.equipmentTab.Text = "장비관리";
            // 
            // testItemTab
            // 
            this.testItemTab.Name = "testItemTab";
            this.testItemTab.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.testItemTab.Text = "검사항목관리";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(947, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(696, 21);
            this.textBox1.TabIndex = 1;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // mainFormBindingSource
            // 
            this.mainFormBindingSource.DataSource = typeof(ToyProject.MainForm);
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 666);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.mainMenuControl);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.MinimumSize = new System.Drawing.Size(949, 667);
            this.Name = "MainForm";
            this.NavigationControl = this.mainMenuControl;
            this.Text = "U2Toy";
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl2)).EndInit();
            this.popupContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gnbSearchGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gnbGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gnbSearchEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl mainMenuControl;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mainTab;
        private DevExpress.XtraBars.Navigation.AccordionControlElement testTab;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement testerTab;
        private DevExpress.XtraBars.Navigation.AccordionControlElement equipmentTab;
        private DevExpress.XtraBars.Navigation.AccordionControlElement testItemTab;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.BindingSource mainFormBindingSource;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PopupContainerEdit gnbSearchEdit;
        private DevExpress.XtraEditors.SimpleButton newPatientButton;
        private DevExpress.XtraEditors.SimpleButton newReceptionPatientButton;
        private DevExpress.XtraEditors.PanelControl mainPanel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.PopupContainerControl popupContainerControl2;
        private DevExpress.XtraGrid.GridControl gnbSearchGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gnbGridView;
        private DevExpress.XtraGrid.Columns.GridColumn nameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn chartNumberColumn;
        private DevExpress.XtraGrid.Columns.GridColumn phoneNumberColumn;
        private DevExpress.XtraGrid.Columns.GridColumn genderColumn;
        private DevExpress.XtraGrid.Columns.GridColumn socialSecurityNumberColumn;
        private DevExpress.XtraGrid.Columns.GridColumn addressColumn;
        private DevExpress.XtraGrid.Columns.GridColumn receptionColumn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}

