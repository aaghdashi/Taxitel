namespace TaxiTel
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_Print = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stiReportDataSource2 = new Stimulsoft.Report.Design.StiReportDataSource("dataGridView1", this.dataGridView1);
            this.stiReportDataSource1 = new Stimulsoft.Report.Design.StiReportDataSource("dataGridView1", this.dataGridView1);
            this.stiReportDataSource3 = new Stimulsoft.Report.Design.StiReportDataSource("Report", this);
            this.stiReportDataSource4 = new Stimulsoft.Report.Design.StiReportDataSource("Report", this);
            this.stiReportDataSource5 = new Stimulsoft.Report.Design.StiReportDataSource("dataGridView1", this.dataGridView1);
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_Print);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(884, 461);
            this.splitContainer1.SplitterDistance = 76;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_Print
            // 
            this.button_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Print.Location = new System.Drawing.Point(417, 24);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(159, 40);
            this.button_Print.TabIndex = 11;
            this.button_Print.Text = "چاپ";
            this.button_Print.UseVisualStyleBackColor = true;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(596, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "بازآوری";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(884, 381);
            this.dataGridView1.TabIndex = 0;
            // 
            // stiReportDataSource2
            // 
            this.stiReportDataSource2.Item = this.dataGridView1;
            this.stiReportDataSource2.Name = "dataGridView1";
            // 
            // stiReportDataSource1
            // 
            this.stiReportDataSource1.Item = this.dataGridView1;
            this.stiReportDataSource1.Name = "dataGridView1";
            // 
            // stiReportDataSource3
            // 
            this.stiReportDataSource3.Item = this;
            this.stiReportDataSource3.Name = "Report";
            // 
            // stiReportDataSource4
            // 
            this.stiReportDataSource4.Item = this;
            this.stiReportDataSource4.Name = "Report";
            // 
            // stiReportDataSource5
            // 
            this.stiReportDataSource5.Item = this.dataGridView1;
            this.stiReportDataSource5.Name = "dataGridView1";
            // 
            // stiReport1
            // 
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportGuid = "4324b63fedf149779922367706c0bd42";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = resources.GetString("stiReport1.ReportSource");
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش کارکرد";
            this.Activated += new System.EventHandler(this.Report_Activated);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource1;
        private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource2;
        private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource3;
        private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource4;
        private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource5;
        private Stimulsoft.Report.StiReport stiReport1;
    }
}