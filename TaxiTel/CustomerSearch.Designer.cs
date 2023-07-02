namespace TaxiTel
{
    partial class CustomerSearch
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button_select = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_searchFamily = new System.Windows.Forms.TextBox();
            this.textBox_searchName = new System.Windows.Forms.TextBox();
            this.textBox_searchCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView_customer = new System.Windows.Forms.DataGridView();
            this.button_newCustomer = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 461);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "لیست مشترکین";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer2.Panel1.Controls.Add(this.button_newCustomer);
            this.splitContainer2.Panel1.Controls.Add(this.button_select);
            this.splitContainer2.Panel1.Controls.Add(this.button_refresh);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.textBox_searchFamily);
            this.splitContainer2.Panel1.Controls.Add(this.textBox_searchName);
            this.splitContainer2.Panel1.Controls.Add(this.textBox_searchCode);
            this.splitContainer2.Panel1.Controls.Add(this.label12);
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView_customer);
            this.splitContainer2.Size = new System.Drawing.Size(770, 429);
            this.splitContainer2.SplitterDistance = 138;
            this.splitContainer2.TabIndex = 0;
            // 
            // button_select
            // 
            this.button_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_select.Location = new System.Drawing.Point(409, 50);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(75, 40);
            this.button_select.TabIndex = 3;
            this.button_select.Text = "انتخاب";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_refresh.Location = new System.Drawing.Point(409, 5);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 40);
            this.button_refresh.TabIndex = 3;
            this.button_refresh.Text = "بازآوری";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(49, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(333, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "توجه!";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(315, 53);
            this.label13.TabIndex = 0;
            this.label13.Text = "برای انتخاب مشترک مورد نظر روی رکورد مورد نظر کلیک کرده و سپس بر روی دکه انتخاب ک" +
    "لیک کنید.";
            // 
            // textBox_searchFamily
            // 
            this.textBox_searchFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_searchFamily.Location = new System.Drawing.Point(511, 96);
            this.textBox_searchFamily.Name = "textBox_searchFamily";
            this.textBox_searchFamily.Size = new System.Drawing.Size(150, 20);
            this.textBox_searchFamily.TabIndex = 2;
            this.textBox_searchFamily.TextChanged += new System.EventHandler(this.textBox_searchFamily_TextChanged);
            // 
            // textBox_searchName
            // 
            this.textBox_searchName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_searchName.Location = new System.Drawing.Point(511, 59);
            this.textBox_searchName.Name = "textBox_searchName";
            this.textBox_searchName.Size = new System.Drawing.Size(150, 20);
            this.textBox_searchName.TabIndex = 1;
            this.textBox_searchName.TextChanged += new System.EventHandler(this.textBox_searchName_TextChanged);
            // 
            // textBox_searchCode
            // 
            this.textBox_searchCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_searchCode.Location = new System.Drawing.Point(511, 24);
            this.textBox_searchCode.Name = "textBox_searchCode";
            this.textBox_searchCode.Size = new System.Drawing.Size(150, 20);
            this.textBox_searchCode.TabIndex = 0;
            this.textBox_searchCode.TextChanged += new System.EventHandler(this.textBox_searchCode_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(667, 99);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "نام خانوادگی :";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(667, 62);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "نام مشترک :";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(667, 27);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "کد اشتراک :";
            // 
            // dataGridView_customer
            // 
            this.dataGridView_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_customer.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_customer.Name = "dataGridView_customer";
            this.dataGridView_customer.Size = new System.Drawing.Size(770, 287);
            this.dataGridView_customer.TabIndex = 0;
            // 
            // button_newCustomer
            // 
            this.button_newCustomer.Location = new System.Drawing.Point(409, 92);
            this.button_newCustomer.Name = "button_newCustomer";
            this.button_newCustomer.Size = new System.Drawing.Size(75, 41);
            this.button_newCustomer.TabIndex = 4;
            this.button_newCustomer.Text = "مشتری جدید";
            this.button_newCustomer.UseVisualStyleBackColor = true;
            this.button_newCustomer.Click += new System.EventHandler(this.button_newCustomer_Click);
            // 
            // CustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomerSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جستجوی مشتریان";
            this.Activated += new System.EventHandler(this.CustomerSearch_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerSearch_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_searchFamily;
        private System.Windows.Forms.TextBox textBox_searchName;
        private System.Windows.Forms.TextBox textBox_searchCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView_customer;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Button button_newCustomer;
    }
}