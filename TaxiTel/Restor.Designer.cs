namespace TaxiTel
{
    partial class Restore
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_restore = new System.Windows.Forms.Button();
            this.button_ignore = new System.Windows.Forms.Button();
            this.button_choose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 20);
            this.textBox1.TabIndex = 5;
            // 
            // button_restore
            // 
            this.button_restore.Location = new System.Drawing.Point(204, 64);
            this.button_restore.Name = "button_restore";
            this.button_restore.Size = new System.Drawing.Size(93, 23);
            this.button_restore.TabIndex = 2;
            this.button_restore.Text = "بازیابی";
            this.button_restore.UseVisualStyleBackColor = true;
            this.button_restore.Click += new System.EventHandler(this.button_restore_Click);
            // 
            // button_ignore
            // 
            this.button_ignore.Location = new System.Drawing.Point(114, 64);
            this.button_ignore.Name = "button_ignore";
            this.button_ignore.Size = new System.Drawing.Size(75, 23);
            this.button_ignore.TabIndex = 3;
            this.button_ignore.Text = "انصراف";
            this.button_ignore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_ignore.UseVisualStyleBackColor = true;
            this.button_ignore.Click += new System.EventHandler(this.button_ignore_Click);
            // 
            // button_choose
            // 
            this.button_choose.Location = new System.Drawing.Point(380, 24);
            this.button_choose.Name = "button_choose";
            this.button_choose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_choose.Size = new System.Drawing.Size(92, 23);
            this.button_choose.TabIndex = 4;
            this.button_choose.Text = "انتخاب فایل ...";
            this.button_choose.UseVisualStyleBackColor = true;
            this.button_choose.Click += new System.EventHandler(this.button_choose_Click);
            // 
            // Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 111);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_restore);
            this.Controls.Add(this.button_ignore);
            this.Controls.Add(this.button_choose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Restore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پشتیبان گیری";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_restore;
        private System.Windows.Forms.Button button_ignore;
        private System.Windows.Forms.Button button_choose;
    }
}