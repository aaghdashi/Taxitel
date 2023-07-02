using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TaxiTel
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        int ID;
        bool _status;

        public void controlClear()
        {
             textBox_name.Clear();
             textBox_family.Clear();
             hM_FarsiCalendar_date.Text="";
             textBox_mobile.Clear();
             textBox_postalcode.Clear();
             textBox_tel.Clear();
             textBox_address.Clear();
             textBox_note.Clear();
        }

        public void headerGridView()
        {
            dataGridView_customer.Columns[0].HeaderText = "کد";
            dataGridView_customer.Columns[1].HeaderText = "نام";
            dataGridView_customer.Columns[2].HeaderText = "نام خانوادگی";
            dataGridView_customer.Columns[3].HeaderText = "تاریخ";
            dataGridView_customer.Columns[4].HeaderText = "تلفن";
            dataGridView_customer.Columns[5].HeaderText = "همراه";
            dataGridView_customer.Columns[6].HeaderText = "کد پستی";
            dataGridView_customer.Columns[7].HeaderText = "نسانی";
            dataGridView_customer.Columns[8].HeaderText = "یادداشت";



            dataGridView_service.Columns[0].HeaderText = "کد سرویس";
            dataGridView_service.Columns[1].HeaderText = "تاریخ";
            dataGridView_service.Columns[2].HeaderText = "ساعت";
            dataGridView_service.Columns[3].HeaderText = "راننده";
            dataGridView_service.Columns[4].HeaderText = "کرایه";
            dataGridView_service.Columns[5].HeaderText = "سهم راننده";
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string _command = "INSERT INTO Customer_tbl([Name],[Family],[DateSubscrib],[Mobile],[PostalCode],[Tel],[Address],[Note]) VALUES ('" + textBox_name.Text + "','" + textBox_family.Text + "','"+hM_FarsiCalendar_date.Text+"','"+textBox_mobile.Text+"','"+textBox_postalcode.Text+"','"+textBox_tel.Text+"','"+textBox_address.Text+"','"+textBox_note.Text+"')";
            
            Customers newCustomer = new Customers();
            

            if (textBox_name.Text.Trim() != "" && textBox_family.Text.Trim() != "" && textBox_tel.Text.Trim() != "" && textBox_mobile.Text.Trim() != "" && textBox_address.Text.Trim() != "")
            {

                _status = newCustomer.addCustomer(_command);
               
            }
            else
            {

                MessageBox.Show("اطلاعات خواسته شده را وارد کنید.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
               
            if (textBox_mobile.TextLength < 11)
            {
                MessageBox.Show("لطفا شماره موبایل را درست وارد کنید.", "توجه!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            
            if (_status == true)
            {
                MessageBox.Show("اطلاعات وارد شده با موفقیت ثبت شد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView_customer.DataSource = newCustomer.getCustomers();
                button_delete.Enabled = false;
                button_edit.Enabled = false;
                controlClear();
            }
        }

        private void Customer_Activated(object sender, EventArgs e)
        {
            Customers list_customer = new Customers();
            dataGridView_customer.DataSource = list_customer.getCustomers();


            serviceClass newService = new serviceClass();
            dataGridView_service.DataSource = newService.getServices(Convert.ToInt32(dataGridView_customer.CurrentRow.Cells[0].Value));
;
            headerGridView();

        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            string _command = "UPDATE Customer_tbl SET Name= '" + textBox_name.Text + "',Family='" + textBox_family.Text + "',DateSubscrib='" + hM_FarsiCalendar_date.Text + "',Mobile='" + textBox_mobile.Text + "',PostalCode='"+textBox_postalcode.Text+"',Tel='" + textBox_tel.Text + "',Address='" + textBox_address.Text + "',Note='" + textBox_note.Text + "' WHERE ID='"+textBox_ID.Text+"'";


            if (ID != 0)
            {

                Customers newCustomer = new Customers();
                if (textBox_name.Text.Trim() != "" && textBox_family.Text.Trim() != "" && textBox_tel.Text.Trim() != "" && textBox_mobile.Text.Trim() != "" && textBox_address.Text.Trim() != "")
                {

                    _status = newCustomer.addCustomer(_command);

                }
                else
                {

                    MessageBox.Show("اطلاعات خواسته شده را وارد کنید.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (textBox_mobile.TextLength < 11)
                {
                    MessageBox.Show("لطفا شماره موبایل را درست وارد کنید.", "توجه!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                if (_status == true)
                {
                    MessageBox.Show("اطلاعات وارد شده با موفقیت ثبت شد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView_customer.DataSource = newCustomer.getCustomers();
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

        private void button4_Click(object sender, EventArgs e)
        {
            controlClear();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Customers newCustomer = new Customers();

            if (ID != 0)
            {
                newCustomer.delCustomer(ID);
                MessageBox.Show("اطلاعات وارد شده با موفقیت ثبت شد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("عملیات انجام نشد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView_customer.DataSource = newCustomer.getCustomers();
            controlClear();
            button_delete.Enabled = false;
            button_edit.Enabled = false;
        }

        private void dataGridView_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_delete.Enabled = true;
            button_edit.Enabled = true;
            tabControl1.SelectedTab = tabPage1;
            DataTable dt = new DataTable();
            dt.Clear();
            try
            {
                ID = Convert.ToInt32(dataGridView_customer.CurrentRow.Cells[0].Value);
                serviceClass newService = new serviceClass();

                dataGridView_service.DataSource = newService.getServices(Convert.ToInt32(dataGridView_customer.CurrentRow.Cells[0].Value));
//                textBox_DriverQ.Text=
                textBox_ID.Text = dataGridView_customer.CurrentRow.Cells[0].Value.ToString();
                textBox_name.Text = dataGridView_customer.CurrentRow.Cells[1].Value.ToString();
                textBox_family.Text = dataGridView_customer.CurrentRow.Cells[2].Value.ToString();
                hM_FarsiCalendar_date.Text = dataGridView_customer.CurrentRow.Cells[3].Value.ToString();
                textBox_mobile.Text = dataGridView_customer.CurrentRow.Cells[4].Value.ToString();
                textBox_postalcode.Text = dataGridView_customer.CurrentRow.Cells[5].Value.ToString();
                textBox_tel.Text = dataGridView_customer.CurrentRow.Cells[6].Value.ToString();
                textBox_address.Text = dataGridView_customer.CurrentRow.Cells[7].Value.ToString();
                textBox_note.Text = dataGridView_customer.CurrentRow.Cells[8].Value.ToString();
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
                command.CommandText = "SELECT SUM(Destination_tbl.Price*0.75) AS 'Driver',SUM(Destination_tbl.Price*0.25) AS 'Agency' FROM Service_tbl INNER JOIN Customer_tbl ON Service_tbl.ID_Customer = Customer_tbl.ID INNER JOIN Driver_tbl ON Service_tbl.ID_Driver = Driver_tbl.ID INNER JOIN Destination_tbl ON Service_tbl.ID_Destination = Destination_tbl.ID WHERE Service_tbl.ID_Customer='" + Convert.ToInt32(dataGridView_customer.CurrentRow.Cells[0].Value) + "'";
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

        private void Customer_Load(object sender, EventArgs e)
        {
            button_delete.Enabled = false;
            button_edit.Enabled = false;

            
            dataGridView_customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_customer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_customer.ScrollBars = ScrollBars.Both;
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            Customers newCustomer = new Customers();
            dataGridView_customer.DataSource = newCustomer.getCustomers();
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox_postalcode_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void textBox_searchCode_TextChanged(object sender, EventArgs e)
        {
            Customers newCustomer = new Customers();
            dataGridView_customer.DataSource = newCustomer.search(textBox_searchCode.Text.Trim(),textBox_searchName.Text,textBox_searchFamily.Text);
        }

        private void textBox_searchName_TextChanged(object sender, EventArgs e)
        {
            Customers newCustomer = new Customers();
            dataGridView_customer.DataSource = newCustomer.search(textBox_searchCode.Text.Trim(), textBox_searchName.Text, textBox_searchFamily.Text);
        }

        private void textBox_searchFamily_TextChanged(object sender, EventArgs e)
        {
            Customers newCustomer = new Customers();
            dataGridView_customer.DataSource = newCustomer.search(textBox_searchCode.Text.Trim(), textBox_searchName.Text, textBox_searchFamily.Text);
        }

        private void dataGridView_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
