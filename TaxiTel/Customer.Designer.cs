namespace TaxiTel
{
    partial class Customer
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_note = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_postalcode = new System.Windows.Forms.TextBox();
            this.textBox_mobile = new System.Windows.Forms.TextBox();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.textBox_family = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.hM_FarsiCalendar_date = new HM_FarsiCalendar.HM_FarsiCalendar();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_AgencQ = new System.Windows.Forms.TextBox();
            this.textBox_DriverQ = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView_service = new System.Windows.Forms.DataGridView();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customer)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_service)).BeginInit();
            this.SuspendLayout();
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
            // button_refresh
            // 
            this.button_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_refresh.Location = new System.Drawing.Point(407, 76);
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
            this.groupBox1.Location = new System.Drawing.Point(47, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(333, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "توجه!";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(315, 53);
            this.label13.TabIndex = 0;
            this.label13.Text = "برای انجام عمل ویرایش و حذف بر روی رکورد مورد نظر کلیک کنید و در بخش اطلاعات مشتر" +
    "کین عملیات مورد نظر خود را انجام دهید.";
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
            this.textBox_searchCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox9_KeyPress);
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
            this.dataGridView_customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_customer_CellClick);
            this.dataGridView_customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_customer_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button_delete);
            this.tabPage1.Controls.Add(this.button_edit);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox_note);
            this.tabPage1.Controls.Add(this.textBox_address);
            this.tabPage1.Controls.Add(this.textBox_postalcode);
            this.tabPage1.Controls.Add(this.textBox_mobile);
            this.tabPage1.Controls.Add(this.textBox_tel);
            this.tabPage1.Controls.Add(this.textBox_family);
            this.tabPage1.Controls.Add(this.textBox_name);
            this.tabPage1.Controls.Add(this.textBox_ID);
            this.tabPage1.Controls.Add(this.hM_FarsiCalendar_date);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "اطلاعات مشترک";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(725, 242);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 17);
            this.label20.TabIndex = 12;
            this.label20.Text = "*";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(656, 180);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 17);
            this.label19.TabIndex = 12;
            this.label19.Text = "*";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(369, 117);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 17);
            this.label18.TabIndex = 12;
            this.label18.Text = "*";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(412, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 17);
            this.label17.TabIndex = 12;
            this.label17.Text = "*";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(638, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 17);
            this.label16.TabIndex = 12;
            this.label16.Text = "*";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(39, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 50);
            this.button4.TabIndex = 11;
            this.button4.Text = "خالی کردن";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_delete
            // 
            this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_delete.Location = new System.Drawing.Point(39, 201);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 50);
            this.button_delete.TabIndex = 10;
            this.button_delete.Text = "حذف";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_edit.Location = new System.Drawing.Point(39, 135);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 50);
            this.button_edit.TabIndex = 9;
            this.button_edit.Text = "ویرایش";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(39, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "افزودن";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_note
            // 
            this.textBox_note.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_note.Location = new System.Drawing.Point(184, 330);
            this.textBox_note.Multiline = true;
            this.textBox_note.Name = "textBox_note";
            this.textBox_note.Size = new System.Drawing.Size(485, 74);
            this.textBox_note.TabIndex = 7;
            // 
            // textBox_address
            // 
            this.textBox_address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_address.Location = new System.Drawing.Point(184, 239);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(485, 68);
            this.textBox_address.TabIndex = 6;
            // 
            // textBox_postalcode
            // 
            this.textBox_postalcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_postalcode.Location = new System.Drawing.Point(184, 177);
            this.textBox_postalcode.Name = "textBox_postalcode";
            this.textBox_postalcode.Size = new System.Drawing.Size(150, 20);
            this.textBox_postalcode.TabIndex = 5;
            this.textBox_postalcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_postalcode_KeyPress);
            // 
            // textBox_mobile
            // 
            this.textBox_mobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_mobile.Location = new System.Drawing.Point(457, 177);
            this.textBox_mobile.MaxLength = 11;
            this.textBox_mobile.Name = "textBox_mobile";
            this.textBox_mobile.Size = new System.Drawing.Size(150, 20);
            this.textBox_mobile.TabIndex = 4;
            this.textBox_mobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_mobile_KeyPress);
            // 
            // textBox_tel
            // 
            this.textBox_tel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_tel.Location = new System.Drawing.Point(184, 116);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(150, 20);
            this.textBox_tel.TabIndex = 3;
            this.textBox_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_tel_KeyPress);
            // 
            // textBox_family
            // 
            this.textBox_family.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_family.Location = new System.Drawing.Point(184, 55);
            this.textBox_family.Name = "textBox_family";
            this.textBox_family.Size = new System.Drawing.Size(150, 20);
            this.textBox_family.TabIndex = 1;
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_name.Location = new System.Drawing.Point(457, 55);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(150, 20);
            this.textBox_name.TabIndex = 0;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ID.Enabled = false;
            this.textBox_ID.Location = new System.Drawing.Point(510, 18);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(150, 20);
            this.textBox_ID.TabIndex = 9;
            this.textBox_ID.TabStop = false;
            // 
            // hM_FarsiCalendar_date
            // 
            this.hM_FarsiCalendar_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hM_FarsiCalendar_date.BodyBackColor = System.Drawing.Color.White;
            this.hM_FarsiCalendar_date.BodyForeColor = System.Drawing.Color.Black;
            this.hM_FarsiCalendar_date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.hM_FarsiCalendar_date.HeaderBackColor = System.Drawing.Color.Gray;
            this.hM_FarsiCalendar_date.HeaderFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.hM_FarsiCalendar_date.HeaderForeColor = System.Drawing.Color.White;
            this.hM_FarsiCalendar_date.Location = new System.Drawing.Point(482, 111);
            this.hM_FarsiCalendar_date.Max_Date = "1400/12/30";
            this.hM_FarsiCalendar_date.Min_Date = "1350/01/01";
            this.hM_FarsiCalendar_date.Name = "hM_FarsiCalendar_date";
            this.hM_FarsiCalendar_date.SelectedBackColor = System.Drawing.Color.Blue;
            this.hM_FarsiCalendar_date.SelectedForeColor = System.Drawing.Color.White;
            this.hM_FarsiCalendar_date.Size = new System.Drawing.Size(125, 21);
            this.hM_FarsiCalendar_date.TabIndex = 2;
            this.hM_FarsiCalendar_date.TitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(687, 337);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "یاد داشت :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(681, 242);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "نشانی :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 180);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "کد پستی :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(613, 180);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "همراه :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 119);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "تلفن :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 119);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "تاریخ ثبت اشتراک :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 58);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام خانوادگی :";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(666, 21);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "کد اشتراک :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 58);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.dataGridView_service);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(776, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "گزارش سرویس های مشترک";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.textBox_AgencQ);
            this.groupBox2.Controls.Add(this.textBox_DriverQ);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(770, 61);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(368, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "مجموع سهم آژانس :";
            // 
            // textBox_AgencQ
            // 
            this.textBox_AgencQ.Location = new System.Drawing.Point(262, 28);
            this.textBox_AgencQ.Name = "textBox_AgencQ";
            this.textBox_AgencQ.ReadOnly = true;
            this.textBox_AgencQ.Size = new System.Drawing.Size(100, 20);
            this.textBox_AgencQ.TabIndex = 1;
            // 
            // textBox_DriverQ
            // 
            this.textBox_DriverQ.Location = new System.Drawing.Point(553, 28);
            this.textBox_DriverQ.Name = "textBox_DriverQ";
            this.textBox_DriverQ.ReadOnly = true;
            this.textBox_DriverQ.Size = new System.Drawing.Size(100, 20);
            this.textBox_DriverQ.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(659, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "مجموع سهم راننده :";
            // 
            // dataGridView_service
            // 
            this.dataGridView_service.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_service.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_service.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_service.Name = "dataGridView_service";
            this.dataGridView_service.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_service.Size = new System.Drawing.Size(770, 429);
            this.dataGridView_service.TabIndex = 2;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مشتریان";
            this.Activated += new System.EventHandler(this.Customer_Activated);
            this.Load += new System.EventHandler(this.Customer_Load);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customer)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_service)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_note;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_postalcode;
        private System.Windows.Forms.TextBox textBox_mobile;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.TextBox textBox_family;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_ID;
        private HM_FarsiCalendar.HM_FarsiCalendar hM_FarsiCalendar_date;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_searchFamily;
        private System.Windows.Forms.TextBox textBox_searchName;
        private System.Windows.Forms.TextBox textBox_searchCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView_customer;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.DataGridView dataGridView_service;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_AgencQ;
        private System.Windows.Forms.TextBox textBox_DriverQ;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;

    }
}