namespace TaxiTel
{
    partial class Destination
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
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.checkBox_status = new System.Windows.Forms.CheckBox();
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
            this.splitContainer1.Panel1.Controls.Add(this.button_delete);
            this.splitContainer1.Panel1.Controls.Add(this.button_edit);
            this.splitContainer1.Panel1.Controls.Add(this.button_add);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_price);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_address);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox_status);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewDestination);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(484, 461);
            this.splitContainer1.SplitterDistance = 128;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_delete
            // 
            this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_delete.Location = new System.Drawing.Point(24, 84);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 40);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "حذف";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_edit.Location = new System.Drawing.Point(24, 46);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 40);
            this.button_edit.TabIndex = 4;
            this.button_edit.Text = "ویرایش";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add.Location = new System.Drawing.Point(24, 7);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 40);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "افزودن";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_price
            // 
            this.textBox_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_price.Location = new System.Drawing.Point(235, 57);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(150, 20);
            this.textBox_price.TabIndex = 1;
            this.textBox_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_price_KeyPress);
            // 
            // textBox_address
            // 
            this.textBox_address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_address.Location = new System.Drawing.Point(235, 26);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(150, 20);
            this.textBox_address.TabIndex = 0;
            // 
            // checkBox_status
            // 
            this.checkBox_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_status.AutoSize = true;
            this.checkBox_status.Location = new System.Drawing.Point(299, 96);
            this.checkBox_status.Name = "checkBox_status";
            this.checkBox_status.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_status.Size = new System.Drawing.Size(133, 17);
            this.checkBox_status.TabIndex = 2;
            this.checkBox_status.Text = "محدوده طرح زوج و فرد";
            this.checkBox_status.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 61);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "کرایه :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 30);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نشانی :";
            // 
            // dataGridViewDestination
            // 
            this.dataGridViewDestination.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDestination.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDestination.Name = "dataGridViewDestination";
            this.dataGridViewDestination.Size = new System.Drawing.Size(484, 329);
            this.dataGridViewDestination.TabIndex = 0;
            this.dataGridViewDestination.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDestination_CellClick);
            // 
            // Destination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Destination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مقصد";
            this.Activated += new System.EventHandler(this.Destination_Activated);
            this.Load += new System.EventHandler(this.Destination_Load);
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
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.CheckBox checkBox_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDestination;
    }
}