
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
            this.label2 = new System.Windows.Forms.Label();
            this.FooterStackPanel = new DevExpress.Utils.Layout.StackPanel();
            this.SaveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.CloseBtn = new DevExpress.XtraEditors.SimpleButton();
            this.FooterPanel = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.patientEditControl = new ToyProject.View.PatientEditControl();
            ((System.ComponentModel.ISupportInitialize)(this.FooterStackPanel)).BeginInit();
            this.FooterStackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FooterPanel)).BeginInit();
            this.FooterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "환자상세";
            // 
            // FooterStackPanel
            // 
            this.FooterStackPanel.AutoSize = true;
            this.FooterPanel.SetColumn(this.FooterStackPanel, 0);
            this.FooterStackPanel.Controls.Add(this.SaveBtn);
            this.FooterStackPanel.Controls.Add(this.CloseBtn);
            this.FooterStackPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.FooterStackPanel.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.RightToLeft;
            this.FooterStackPanel.Location = new System.Drawing.Point(1082, 587);
            this.FooterStackPanel.Name = "FooterStackPanel";
            this.FooterPanel.SetRow(this.FooterStackPanel, 2);
            this.FooterStackPanel.Size = new System.Drawing.Size(135, 54);
            this.FooterStackPanel.TabIndex = 2;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(69, 16);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(63, 22);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "저장";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(3, 16);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(63, 22);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "닫기";
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // FooterPanel
            // 
            this.FooterPanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.FooterPanel.Controls.Add(this.FooterStackPanel);
            this.FooterPanel.Controls.Add(this.label2);
            this.FooterPanel.Controls.Add(this.tablePanel2);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FooterPanel.Location = new System.Drawing.Point(0, 0);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 49F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 535F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.FooterPanel.Size = new System.Drawing.Size(1220, 644);
            this.FooterPanel.TabIndex = 0;
            // 
            // tablePanel2
            // 
            this.tablePanel2.AutoSize = true;
            this.FooterPanel.SetColumn(this.tablePanel2, 0);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)});
            this.tablePanel2.Controls.Add(this.patientEditControl);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(3, 52);
            this.tablePanel2.Name = "tablePanel2";
            this.FooterPanel.SetRow(this.tablePanel2, 1);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(1214, 529);
            this.tablePanel2.TabIndex = 0;
            // 
            // patientEditControl
            // 
            this.tablePanel2.SetColumn(this.patientEditControl, 0);
            this.patientEditControl.Location = new System.Drawing.Point(3, 3);
            this.patientEditControl.Name = "patientEditControl";
            this.tablePanel2.SetRow(this.patientEditControl, 0);
            this.patientEditControl.Size = new System.Drawing.Size(601, 523);
            this.patientEditControl.TabIndex = 0;
            // 
            // PatientDetailDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 644);
            this.Controls.Add(this.FooterPanel);
            this.Name = "PatientDetailDialogForm";
            this.Text = "환자상세";
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

        private System.Windows.Forms.Label label2;
        private DevExpress.Utils.Layout.StackPanel FooterStackPanel;
        private DevExpress.XtraEditors.SimpleButton SaveBtn;
        private DevExpress.XtraEditors.SimpleButton CloseBtn;
        private DevExpress.Utils.Layout.TablePanel FooterPanel;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private PatientEditControl patientEditControl;
    }
}