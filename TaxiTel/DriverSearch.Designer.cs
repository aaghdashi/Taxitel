namespace TaxiTel
{
    partial class DriverSearch
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_select = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.textBox_searchCirtification = new System.Windows.Forms.TextBox();
            this.textBox_searchFamily = new System.Windows.Forms.TextBox();
            this.textBox_searchName = new System.Windows.Forms.TextBox();
            this.textBox_searchCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 461);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "جستجو راننده";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel1.Controls.Add(this.button_select);
            this.splitContainer1.Panel1.Controls.Add(this.button_refresh);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_searchCirtification);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_searchFamily);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_searchName);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_searchCode);
            this.splitContainer1.Panel1.Controls.Add(this.label16);
            this.splitContainer1.Panel1.Controls.Add(this.label15);
            this.splitContainer1.Panel1.Controls.Add(this.label14);
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(770, 429);
            this.splitContainer1.SplitterDistance = 120;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_select
            // 
            this.button_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_select.Location = new System.Drawing.Point(134, 62);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(75, 48);
            this.button_select.TabIndex = 4;
            this.button_select.Text = "انتخاب";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_refresh.Location = new System.Drawing.Point(134, 8);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 48);
            this.button_refresh.TabIndex = 4;
            this.button_refresh.Text = "بازآوری";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // textBox_searchCirtification
            // 
            this.textBox_searchCirtification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_searchCirtification.Location = new System.Drawing.Point(262, 62);
            this.textBox_searchCirtification.Name = "textBox_searchCirtification";
            this.textBox_searchCirtification.Size = new System.Drawing.Size(150, 20);
            this.textBox_searchCirtification.TabIndex = 3;
            this.textBox_searchCirtification.TextChanged += new System.EventHandler(this.textBox_searchCirtification_TextChanged);
            // 
            // textBox_searchFamily
            // 
            this.textBox_searchFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_searchFamily.Location = new System.Drawing.Point(262, 36);
            this.textBox_searchFamily.Name = "textBox_searchFamily";
            this.textBox_searchFamily.Size = new System.Drawing.Size(150, 20);
            this.textBox_searchFamily.TabIndex = 1;
            this.textBox_searchFamily.TextChanged += new System.EventHandler(this.textBox_searchFamily_TextChanged);
            // 
            // textBox_searchName
            // 
            this.textBox_searchName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_searchName.Location = new System.Drawing.Point(539, 62);
            this.textBox_searchName.Name = "textBox_searchName";
            this.textBox_searchName.Size = new System.Drawing.Size(150, 20);
            this.textBox_searchName.TabIndex = 2;
            this.textBox_searchName.TextChanged += new System.EventHandler(this.textBox_searchName_TextChanged);
            // 
            // textBox_searchCode
            // 
            this.textBox_searchCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_searchCode.Location = new System.Drawing.Point(539, 36);
            this.textBox_searchCode.Name = "textBox_searchCode";
            this.textBox_searchCode.Size = new System.Drawing.Size(150, 20);
            this.textBox_searchCode.TabIndex = 0;
            this.textBox_searchCode.TextChanged += new System.EventHandler(this.textBox_searchCode_TextChanged);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(418, 67);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label16.Size = new System.Drawing.Size(89, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "شماره شناسنامه :";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(418, 41);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "نام خانوادگی :";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(695, 67);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "نام :";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(695, 39);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "کد راننده :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // DriverSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DriverSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جستجوی راننده";
            this.Activated += new System.EventHandler(this.DriverSearch_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DriverSearch_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.TextBox textBox_searchCirtification;
        private System.Windows.Forms.TextBox textBox_searchFamily;
        private System.Windows.Forms.TextBox textBox_searchName;
        private System.Windows.Forms.TextBox textBox_searchCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_select;
    }
}