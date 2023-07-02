using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HM_FarsiCalendar;
using System.Data.SqlClient;
namespace TaxiTel
{
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
        }

        public void controlClear()
        {
            textBox_name.Clear();
            textBox_family.Clear();
            checkBox_enable.CheckState=CheckState.Unchecked;
            comboBox_gender.SelectedText="";
            comboBox_maritalStatus.Text="";
            textBox_fatherName.Clear();
            textBox_CirtificatedID.Clear();
            textBox_CodeID.Clear();
            textBox_tel.Clear();
            textBox_mobile.Clear();
            hM_FarsiCalendar_dateBegin.Text="";
            hM_FarsiCalendar_dateEnd.Text="";
            textBox_Ownername.Clear();
            comboBox_typeVehicle.SelectedText="";
            textBox_color.Clear();
            textBox_NO.Clear();
            comboBox_statusTerrafic.SelectedText="";
            checkBox_insuranceStatus.CheckState=CheckState.Unchecked;
            textBox_companyName.Clear();
            textBox_NOinsurance.Clear();
            textBox_address.Clear();
        }


        public void headerGridView()
        {
            dataGridView1.Columns[0].HeaderText = "کد";
            dataGridView1.Columns[1].HeaderText = "نام";
            dataGridView1.Columns[2].HeaderText = "نام خانوادگی";
            dataGridView1.Columns[3].HeaderText = "فعال";
            dataGridView1.Columns[4].HeaderText = "جنسیت";
            dataGridView1.Columns[5].HeaderText = "وضعیت تاهل";
            dataGridView1.Columns[6].HeaderText = "نام پدر";
            dataGridView1.Columns[7].HeaderText = "شماره شناسنامه";
            dataGridView1.Columns[8].HeaderText = "کد ملی";
            dataGridView1.Columns[9].HeaderText = "تلفن";
            dataGridView1.Columns[10].HeaderText = "همراه";
            dataGridView1.Columns[11].HeaderText = "نشانی";
            dataGridView1.Columns[12].HeaderText = "تاریخ شروع";
            dataGridView1.Columns[13].HeaderText = "تاریخ پایان";
            dataGridView1.Columns[14].HeaderText = "مالک خودرو";
            dataGridView1.Columns[15].HeaderText = "نوع ماشین";
            dataGridView1.Columns[16].HeaderText = "رنگ";
            dataGridView1.Columns[17].HeaderText = "پلاک";
            dataGridView1.Columns[18].HeaderText = "وضعیت ترافیک";
            dataGridView1.Columns[19].HeaderText = "وضعیت بیمه";
            dataGridView1.Columns[20].HeaderText = "شرکت بیمه";
            dataGridView1.Columns[21].HeaderText = "شماره بیمه نامه";
        }

        public void headerGridViewService()
        {
            
            dataGridView_Service.Columns[0].HeaderText = "کد سرویس";
            dataGridView_Service.Columns[1].HeaderText = "تاریخ";
            dataGridView_Service.Columns[2].HeaderText = "ساعت";
            dataGridView_Service.Columns[3].HeaderText = "مشتری";
            dataGridView_Service.Columns[4].HeaderText = "کرایه";
            dataGridView_Service.Columns[5].HeaderText = "سهم راننده";
        }
        bool _enable;
        bool _gender;
        bool _statusMarital;
        bool _statusTerrafic;
        bool _insurance;
        bool _status;
        int ID;

        private void button_add_Click(object sender, EventArgs e)
        {


            switch (comboBox_gender.SelectedIndex)
            {
                case 0:
                    _gender = false;
                    break;
                case 1:
                    _gender = true;
                    break;
            }

              switch (comboBox_statusTerrafic.SelectedIndex)
            {
                case 0:
                    _statusTerrafic = false;
                    break;
                case 1:
                    _statusTerrafic = true;
                    break;
            }
            switch (comboBox_maritalStatus.SelectedIndex)
            {
                case 0:
                    _statusMarital = false;
                    break;
                case 1:
                    _statusMarital = true;
                    break;
            }

            switch (checkBox_enable.CheckState)
            {
                case CheckState.Checked:
                    _enable = true;
                    break;

                case CheckState.Unchecked:
                    _enable = false;
                    break;

            }

             switch (checkBox_insuranceStatus.CheckState)
            {
                case CheckState.Checked:
                    _insurance = true;
                    break;

                case CheckState.Unchecked:
                    _insurance = false;
                    break;

            }
            string _command = "INSERT INTO Driver_tbl ([Name],[Family],[Enable] ,[Gender] ,[MaritalStatus],[FatherName],[CirtificatedID],[CodeID],[Tel],[Mobile],[Address],[DateBegin],[DateEnd],[NameOwner],[type],[Color],[NO],[StatusTraffic],[Insurance],[InsuranceName],[InsuranceNo],[Status]) VALUES ('"+textBox_name.Text+"','"+ textBox_family.Text+"','"+ _enable+"','"+ _gender+"','"+ _statusMarital+"','"+ textBox_fatherName.Text+"','"+ textBox_CirtificatedID.Text+"','"+ textBox_CodeID.Text+"','"+ textBox_tel.Text+"','"+ textBox_mobile.Text+"','"+ textBox_address.Text+"','"+ hM_FarsiCalendar_dateBegin.Text+"','"+ hM_FarsiCalendar_dateEnd.Text+"','"+ textBox_Ownername.Text+"','"+ comboBox_typeVehicle.SelectedText.ToString()+"','"+ textBox_color.Text+"','"+ textBox_NO.Text+"','"+ _statusTerrafic+"','"+ _insurance+"','"+textBox_companyName.Text+"','"+textBox_NOinsurance.Text+"','False')";

            Drive newDriver = new Drive();


            if (textBox_name.Text.Trim() != "" && textBox_family.Text.Trim() != "" && textBox_CirtificatedID.Text.Trim() != "" && textBox_CodeID.Text.Trim() != "" && textBox_mobile.Text.Trim() != "" && textBox_tel.Text.Trim() != "" && textBox_NO.Text.Trim() != "" && textBox_companyName.Text.Trim() != "" && textBox_NOinsurance.Text.Trim() != "")
            {
                _status = newDriver.addDriver(_command);
            }
            else
            {
                MessageBox.Show("اطلاعات خواسته شده را وارد کنید.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;    
            }
            if (textBox_CodeID.TextLength < 10)
            {
                MessageBox.Show("لطفا کد ملی  را درست وارد کنید.", "توجه!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox_mobile.TextLength < 11)
            {
                MessageBox.Show("لطفا شماره تلفن  را درست وارد کنید.", "توجه!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
                         if (_status == true)
            {
                MessageBox.Show("اطلاعات وارد شده با موفقیت ثبت شد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = newDriver.getDrivers();
                button_delete.Enabled = false;
                button_edit.Enabled = false;
                controlClear();
            }
        }

        private void Driver_Activated(object sender, EventArgs e)
        {
            Drive newDriver = new Drive();
            dataGridView1.DataSource = newDriver.showDrivers();
            headerGridView();
            
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ScrollBars=ScrollBars.Both;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Drive newDriver = new Drive();
            dataGridView1.DataSource = newDriver.showDrivers();
        }


        private void button_edit_Click(object sender, EventArgs e)
        {

            switch (comboBox_gender.SelectedIndex)
            {
                case 0:
                    _gender = false;
                    break;
                case 1:
                    _gender = true;
                    break;
            }

            switch (comboBox_statusTerrafic.SelectedIndex)
            {
                case 0:
                    _statusTerrafic = false;
                    break;
                case 1:
                    _statusTerrafic = true;
                    break;
            }
            switch (comboBox_maritalStatus.SelectedIndex)
            {
                case 0:
                    _statusMarital = false;
                    break;
                case 1:
                    _statusMarital = true;
                    break;
            }

            switch (checkBox_enable.CheckState)
            {
                case CheckState.Checked:
                    _enable = true;
                    break;

                case CheckState.Unchecked:
                    _enable = false;
                    break;

            }

            switch (checkBox_insuranceStatus.CheckState)
            {
                case CheckState.Checked:
                    _insurance = true;
                    break;

                case CheckState.Unchecked:
                    _insurance = false;
                    break;

            }
            string _command = "UPDATE Driver_tbl SET Name= '" + textBox_name.Text + "',Family='" + textBox_family.Text + "',Enable='" + _enable + "',Gender='" + _gender + "',MaritalStatus='" + _statusMarital + "',FatherName='" + textBox_fatherName.Text + "',CirtificatedID='" + textBox_CirtificatedID.Text + "',CodeID='" + textBox_CodeID.Text + "',Tel='" + textBox_tel.Text + "',Mobile='" + textBox_mobile.Text + "',Address='" + textBox_address.Text + "',DateBegin='" + hM_FarsiCalendar_dateBegin.Text + "',DateEnd='" + hM_FarsiCalendar_dateEnd.Text + "',NameOwner='" + textBox_Ownername.Text + "',type='" + comboBox_typeVehicle.SelectedText.ToString() + "',Color='" + textBox_color.Text + "',NO='" + textBox_NO.Text + "',StatusTraffic='" + _statusTerrafic + "',Insurance='" + _insurance + "',InsuranceName='" + textBox_companyName.Text + "',InsuranceNo='" + textBox_NOinsurance.Text + "' WHERE ID='"+textBox_ID.Text+"'";

            if (ID != 0)
            {
                Drive newDriver = new Drive();

                if (textBox_name.Text.Trim() != "" && textBox_family.Text.Trim() != "" && textBox_CirtificatedID.Text.Trim() != "" && textBox_CodeID.Text.Trim() != "" && textBox_mobile.Text.Trim() != "" && textBox_tel.Text.Trim() != "" && textBox_NO.Text.Trim() != "" && textBox_companyName.Text.Trim() != "" && textBox_NOinsurance.Text.Trim() != "")
                {
                    _status = newDriver.addDriver(_command);
                }
                else
                {
                    MessageBox.Show("اطلاعات خواسته شده را وارد کنید.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox_CodeID.TextLength < 10 || textBox_mobile.TextLength < 11)
                {
                    MessageBox.Show("لطفا کد ملی و شماره موبایل را درست وارد کنید.", "توجه!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

           
            if (_status == true)
            {
                MessageBox.Show("اطلاعات وارد شده با موفقیت ثبت شد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = newDriver.showDrivers();
                button_delete.Enabled = false;
                button_edit.Enabled = false;
                controlClear();
            } 
            }
            else
            {
                MessageBox.Show("عملیات انجام نشد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                Drive serviceDriver = new Drive();
                dataGridView_Service.DataSource = serviceDriver.ReportService(ID);
                headerGridViewService();

                dataGridView_Service.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_Service.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView_Service.ScrollBars = ScrollBars.Both;

                button_delete.Enabled = true;
                button_edit.Enabled = true;
                tabControl_service.SelectedTab = tabPage1;
                textBox_ID.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value).ToString();
                textBox_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox_family.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                if (Convert.ToBoolean(dataGridView1.CurrentRow.Cells[3].Value) == true)
                    checkBox_enable.Checked = true;
                else
                    checkBox_enable.Checked = false;

                switch (Convert.ToBoolean(dataGridView1.CurrentRow.Cells[4].Value))
                {
                    case false:
                        comboBox_gender.SelectedIndex = 0;
                        break;

                    case true:
                        comboBox_gender.SelectedIndex = 1;
                        break;

                }

                switch (Convert.ToBoolean(dataGridView1.CurrentRow.Cells[5].Value))
                {
                    case false:
                        comboBox_maritalStatus.SelectedIndex = 0;
                        break;

                    case true:
                        comboBox_maritalStatus.SelectedIndex = 1;
                        break;

                }

                textBox_fatherName.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox_CirtificatedID.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBox_CodeID.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBox_tel.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                textBox_mobile.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                textBox_address.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                hM_FarsiCalendar_dateBegin.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                hM_FarsiCalendar_dateEnd.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                textBox_Ownername.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                comboBox_typeVehicle.SelectedText = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                textBox_color.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                textBox_NO.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();


                switch (Convert.ToInt64(dataGridView1.CurrentRow.Cells[18].Value))
                {
                    case 0:
                        comboBox_statusTerrafic.SelectedIndex = 0;
                        break;
                    case 1:
                        comboBox_statusTerrafic.SelectedIndex = 1;
                        break;
                }

                if (Convert.ToBoolean(dataGridView1.CurrentRow.Cells[19].Value) == true)
                    checkBox_insuranceStatus.Checked = true;
                else
                    checkBox_insuranceStatus.Checked = true;

                textBox_companyName.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
                textBox_NOinsurance.Text = dataGridView1.CurrentRow.Cells[21].Value.ToString();
            }
            catch { }

            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter;
            SqlDataReader dataReader;
            connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\TaxiTel\TaxiTel\AppData\Taxi.mdf;Integrated Security=True;Connect Timeout=30");
            command = new SqlCommand();
            adapter = new SqlDataAdapter("", connection);

            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT SUM(Destination_tbl.Price*0.75) AS 'Driver',SUM(Destination_tbl.Price*0.25) AS 'Agency' FROM Service_tbl INNER JOIN Customer_tbl ON Service_tbl.ID_Customer = Customer_tbl.ID INNER JOIN Driver_tbl ON Service_tbl.ID_Driver = Driver_tbl.ID INNER JOIN Destination_tbl ON Service_tbl.ID_Destination = Destination_tbl.ID WHERE Service_tbl.ID_Driver='"+ID+"'";
                dataReader = command.ExecuteReader();
                dataReader.Read();
                
                if (dataReader.HasRows)
                {
                    textBox_DriverQ.Text = dataReader[0].ToString();
                    textBox_AgencQ.Text = dataReader[1].ToString();
                }
            }
            finally
            {
                connection.Close();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Drive newDriver = new Drive();

            if (ID != 0)
            {
                newDriver.delDriver(ID);
                MessageBox.Show("اطلاعات  با موفقیت حذف شد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("عملیات انجام نشد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView1.DataSource = newDriver.getDrivers();
            button_delete.Enabled = false;
            button_edit.Enabled = false;

        }

        private void Driver_Load(object sender, EventArgs e)
        {
            button_delete.Enabled = false;
            button_edit.Enabled = false;
        }

        private void textBox_CirtificatedID_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void textBox_tel_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void textBox_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void textBox_searchCode_TextChanged(object sender, EventArgs e)
        {
            Drive newDriver = new Drive();
            dataGridView1.DataSource = newDriver.search(textBox_searchCode.Text,textBox_searchName.Text,textBox_searchFamily.Text,textBox_searchCirtification.Text);
        }

        private void textBox_searchName_TextChanged(object sender, EventArgs e)
        {
            Drive newDriver = new Drive();
            dataGridView1.DataSource = newDriver.search(textBox_searchCode.Text, textBox_searchName.Text, textBox_searchFamily.Text, textBox_searchCirtification.Text);
        }

        private void textBox_searchFamily_TextChanged(object sender, EventArgs e)
        {
            Drive newDriver = new Drive();
            dataGridView1.DataSource = newDriver.search(textBox_searchCode.Text, textBox_searchName.Text, textBox_searchFamily.Text, textBox_searchCirtification.Text);
        }

        private void textBox_searchCirtification_TextChanged(object sender, EventArgs e)
        {
            Drive newDriver = new Drive();
            dataGridView1.DataSource = newDriver.search(textBox_searchCode.Text, textBox_searchName.Text, textBox_searchFamily.Text, textBox_searchCirtification.Text);
        }

        private void textBox_CodeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void tabControl_service_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_service.SelectedIndex==0)
            {
                this.Size = new Size(800,650);
            }
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            textBox_Ownername.Text = textBox_name.Text.Trim() + " " + textBox_family.Text.Trim();
        }

        private void textBox_family_TextChanged(object sender, EventArgs e)
        {
            textBox_Ownername.Text = textBox_name.Text.Trim() + " " + textBox_family.Text.Trim();
        }

        private void textBox_NOinsurance_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_NOinsurance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void textBox_Ownername_TextChanged(object sender, EventArgs e)
        {

        }        

    }
}
