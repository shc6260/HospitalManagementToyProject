
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gnbSplitContainer = new System.Windows.Forms.SplitContainer();
            this.gnbSearchEdit = new DevExpress.XtraEditors.PopupContainerEdit();
            this.popupContainerControl1 = new DevExpress.XtraEditors.PopupContainerControl();
            this.gnbSearchGrid = new DevExpress.XtraGrid.GridControl();
            this.gnbGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chartNumberColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phoneNumberColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.genderColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.socialSecurityNumberColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addressColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receptionColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addPatientButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gnbSplitContainer)).BeginInit();
            this.gnbSplitContainer.Panel1.SuspendLayout();
            this.gnbSplitContainer.Panel2.SuspendLayout();
            this.gnbSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gnbSearchEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).BeginInit();
            this.popupContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gnbSearchGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gnbGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.splitContainerControl1);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(250, 31);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(697, 635);
            this.fluentDesignFormContainer1.TabIndex = 0;
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
            this.splitContainerControl1.Panel1.Controls.Add(this.gnbSplitContainer);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.mainPanel);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(697, 635);
            this.splitContainerControl1.SplitterPosition = 66;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // gnbSplitContainer
            // 
            this.gnbSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gnbSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.gnbSplitContainer.Name = "gnbSplitContainer";
            // 
            // gnbSplitContainer.Panel1
            // 
            this.gnbSplitContainer.Panel1.Controls.Add(this.gnbSearchEdit);
            this.gnbSplitContainer.Panel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            // 
            // gnbSplitContainer.Panel2
            // 
            this.gnbSplitContainer.Panel2.Controls.Add(this.addPatientButton);
            this.gnbSplitContainer.Panel2.Controls.Add(this.simpleButton1);
            this.gnbSplitContainer.Size = new System.Drawing.Size(697, 66);
            this.gnbSplitContainer.SplitterDistance = 592;
            this.gnbSplitContainer.TabIndex = 2;
            // 
            // gnbSearchEdit
            // 
            this.gnbSearchEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.gnbSearchEdit.Location = new System.Drawing.Point(5, 0);
            this.gnbSearchEdit.Name = "gnbSearchEdit";
            this.gnbSearchEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gnbSearchEdit.Properties.PopupControl = this.popupContainerControl1;
            this.gnbSearchEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gnbSearchEdit.Size = new System.Drawing.Size(587, 20);
            this.gnbSearchEdit.TabIndex = 1;
            this.gnbSearchEdit.EditValueChanged += new System.EventHandler(this.gnbSearchEdit_EditValueChanged);
            this.gnbSearchEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GnbPatientSearchEdit_KeyDown);
            // 
            // popupContainerControl1
            // 
            this.popupContainerControl1.AutoSize = true;
            this.popupContainerControl1.Controls.Add(this.gnbSearchGrid);
            this.popupContainerControl1.Location = new System.Drawing.Point(139, 33);
            this.popupContainerControl1.Name = "popupContainerControl1";
            this.popupContainerControl1.Size = new System.Drawing.Size(522, 195);
            this.popupContainerControl1.TabIndex = 2;
            // 
            // gnbSearchGrid
            // 
            this.gnbSearchGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gnbSearchGrid.Location = new System.Drawing.Point(0, 0);
            this.gnbSearchGrid.MainView = this.gnbGridView;
            this.gnbSearchGrid.Name = "gnbSearchGrid";
            this.gnbSearchGrid.Size = new System.Drawing.Size(522, 195);
            this.gnbSearchGrid.TabIndex = 0;
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
            // addPatientButton
            // 
            this.addPatientButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPatientButton.Location = new System.Drawing.Point(0, 23);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(101, 23);
            this.addPatientButton.TabIndex = 1;
            this.addPatientButton.Text = "환자등록";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.simpleButton1.Location = new System.Drawing.Point(0, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(101, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "신환접수";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.popupContainerControl1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(697, 559);
            this.mainPanel.TabIndex = 0;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 666);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.mainMenuControl);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "MainForm";
            this.NavigationControl = this.mainMenuControl;
            this.Text = "Form1";
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.gnbSplitContainer.Panel1.ResumeLayout(false);
            this.gnbSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gnbSplitContainer)).EndInit();
            this.gnbSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gnbSearchEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).EndInit();
            this.popupContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gnbSearchGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gnbGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
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
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SplitContainer gnbSplitContainer;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl mainPanel;
        private DevExpress.XtraEditors.PopupContainerEdit gnbSearchEdit;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private DevExpress.XtraEditors.PopupContainerControl popupContainerControl1;
        private DevExpress.XtraGrid.GridControl gnbSearchGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gnbGridView;
        private DevExpress.XtraGrid.Columns.GridColumn nameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn chartNumberColumn;
        private DevExpress.XtraGrid.Columns.GridColumn phoneNumberColumn;
        private DevExpress.XtraGrid.Columns.GridColumn genderColumn;
        private DevExpress.XtraGrid.Columns.GridColumn socialSecurityNumberColumn;
        private DevExpress.XtraGrid.Columns.GridColumn addressColumn;
        private DevExpress.XtraGrid.Columns.GridColumn receptionColumn;
        private System.Windows.Forms.BindingSource mainFormBindingSource;
        private DevExpress.XtraEditors.SimpleButton addPatientButton;
    }
}

