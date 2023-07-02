namespace TaxiTel
{
    partial class UsersApp
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button_return = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_confirmPass = new System.Windows.Forms.TextBox();
            this.textBox_PassWord = new System.Windows.Forms.TextBox();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(584, 461);
            this.splitContainer1.SplitterDistance = 188;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.button_return);
            this.splitContainer2.Panel1.Controls.Add(this.button_Delete);
            this.splitContainer2.Panel1.Controls.Add(this.button_Edit);
            this.splitContainer2.Panel1.Controls.Add(this.button_Add);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Size = new System.Drawing.Size(584, 188);
            this.splitContainer2.SplitterDistance = 194;
            this.splitContainer2.TabIndex = 0;
            // 
            // button_return
            // 
            this.button_return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_return.Location = new System.Drawing.Point(39, 135);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(90, 35);
            this.button_return.TabIndex = 6;
            this.button_return.Text = "خالی کردن";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Delete.Location = new System.Drawing.Point(39, 94);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(90, 35);
            this.button_Delete.TabIndex = 5;
            this.button_Delete.Text = "حذف";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Edit.Location = new System.Drawing.Point(39, 53);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(90, 35);
            this.button_Edit.TabIndex = 4;
            this.button_Edit.Text = "ویرایش";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Add
            // 
            this.button_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Add.Location = new System.Drawing.Point(39, 12);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(90, 35);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = "اضافه";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_confirmPass);
            this.groupBox1.Controls.Add(this.textBox_PassWord);
            this.groupBox1.Controls.Add(this.textBox_userName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(386, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات کاربر";
            // 
            // textBox_confirmPass
            // 
            this.textBox_confirmPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_confirmPass.Location = new System.Drawing.Point(93, 128);
            this.textBox_confirmPass.Name = "textBox_confirmPass";
            this.textBox_confirmPass.PasswordChar = '*';
            this.textBox_confirmPass.Size = new System.Drawing.Size(127, 20);
            this.textBox_confirmPass.TabIndex = 2;
            // 
            // textBox_PassWord
            // 
            this.textBox_PassWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_PassWord.Location = new System.Drawing.Point(93, 94);
            this.textBox_PassWord.Name = "textBox_PassWord";
            this.textBox_PassWord.PasswordChar = '*';
            this.textBox_PassWord.Size = new System.Drawing.Size(127, 20);
            this.textBox_PassWord.TabIndex = 1;
            // 
            // textBox_userName
            // 
            this.textBox_userName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_userName.Location = new System.Drawing.Point(93, 55);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(127, 20);
            this.textBox_userName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "تکرار رمز عبور :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "رمز عبور :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // UsersApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UsersApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کاربران";
            this.Activated += new System.EventHandler(this.UsersApp_Activated);
            this.Load += new System.EventHandler(this.UsersApp_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_confirmPass;
        private System.Windows.Forms.TextBox textBox_PassWord;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}