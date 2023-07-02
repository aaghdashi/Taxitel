namespace TaxiTel
{
    partial class DestinationSearch
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_select = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDestination = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestination)).BeginInit();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_status);
            this.splitContainer1.Panel1.Controls.Add(this.button_refresh);
            this.splitContainer1.Panel1.Controls.Add(this.button_select);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_id);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewDestination);
            this.splitContainer1.Size = new System.Drawing.Size(484, 461);
            this.splitContainer1.SplitterDistance = 116;
            this.splitContainer1.TabIndex = 0;
            // 
            // comboBox_status
            // 
            this.comboBox_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_status.AutoCompleteCustomSource.AddRange(new string[] {
            "هر دو",
            "زوج",
            "فرد"});
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Items.AddRange(new object[] {
            "",
            "زوج",
            "فرد"});
            this.comboBox_status.Location = new System.Drawing.Point(213, 69);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(155, 21);
            this.comboBox_status.TabIndex = 13;
            this.comboBox_status.SelectedIndexChanged += new System.EventHandler(this.comboBox_status_SelectedIndexChanged);
            // 
            // button_refresh
            // 
            this.button_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_refresh.Location = new System.Drawing.Point(39, 58);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 40);
            this.button_refresh.TabIndex = 12;
            this.button_refresh.Text = "بازآوری";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_select
            // 
            this.button_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_select.Location = new System.Drawing.Point(39, 19);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(75, 40);
            this.button_select.TabIndex = 11;
            this.button_select.Text = "انتخاب";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_id.Location = new System.Drawing.Point(213, 30);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(155, 20);
            this.textBox_id.TabIndex = 6;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_address_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 72);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "طرح زوج و فرد :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 33);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "کد :";
            // 
            // dataGridViewDestination
            // 
            this.dataGridViewDestination.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDestination.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDestination.Name = "dataGridViewDestination";
            this.dataGridViewDestination.Size = new System.Drawing.Size(484, 341);
            this.dataGridViewDestination.TabIndex = 1;
            this.dataGridViewDestination.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDestination_CellClick);
            // 
            // DestinationSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DestinationSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جستجوی مقصد";
            this.Activated += new System.EventHandler(this.DestinationSearch_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DestinationSearch_FormClosed);
            this.Load += new System.EventHandler(this.DestinationSearch_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestination)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDestination;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.Label label2;


    }
}