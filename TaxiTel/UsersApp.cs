using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiTel
{
    public partial class UsersApp : Form
    {
        public UsersApp()
        {
            InitializeComponent();
        }

        int ID;

        public void headerGridView()
        {
            dataGridView1.Columns[0].HeaderText = "کد";
            dataGridView1.Columns[1].HeaderText = "شناسه";
        }

        private void UsersApp_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ScrollBars = ScrollBars.Both;


            button_Delete.Enabled = false;
            button_Edit.Enabled = false;

        }

        private void UsersApp_Activated(object sender, EventArgs e)
        {
            Users getUserName = new Users();
            dataGridView1.DataSource = getUserName.getUsers();
            headerGridView();

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            bool status;
            Users add = new Users();

            if (textBox_userName.Text.Trim() != "" && textBox_PassWord.Text.Trim() != "" && textBox_confirmPass.Text.Trim() != "")
                status = add.addUser(textBox_userName.Text.Trim(), textBox_PassWord.Text.Trim(), textBox_confirmPass.Text.Trim());
            else
                status = false;

            if (status == true)
            {
                MessageBox.Show("اطلاعات وارد شده با موفقیت ثبت شد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = add.getUsers();

                textBox_userName.Clear();
                textBox_PassWord.Clear();
                textBox_confirmPass.Clear();
            }
            else
            {
                MessageBox.Show("اطلاعات خواسته شده را وارد کنید.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                textBox_userName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                button_Delete.Enabled = true;
                button_Edit.Enabled = true;
            }
            catch
            { }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            bool status;
            Users edit = new Users();
            
            status = edit.editUser(textBox_userName.Text.Trim(), textBox_PassWord.Text.Trim(), textBox_confirmPass.Text.Trim(),ID);
            if (textBox_userName.Text.Trim() == "" || textBox_PassWord.Text.Trim() == "" || textBox_confirmPass.Text.Trim() == "" )
                status = false;
                if (status == true)
            {
                MessageBox.Show("اطلاعات وارد شده با موفقیت ثبت شد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = edit.getUsers();

                textBox_userName.Clear();
                textBox_PassWord.Clear();
                textBox_confirmPass.Clear();
                button_Delete.Enabled = false;
                button_Edit.Enabled = false;
            }
            else
            {
                MessageBox.Show("اطلاعات خواسته شده را وارد کنید.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void button_Delete_Click(object sender, EventArgs e)
        {

            bool status;
            Users del = new Users();
            status = del.delUser(ID);

            if (status == true)
            {
                MessageBox.Show("اطلاعات  با موفقیت حذف شد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = del.getUsers();

                textBox_userName.Clear();
                textBox_PassWord.Clear();
                textBox_confirmPass.Clear();
                button_Delete.Enabled = false;
                button_Edit.Enabled = false;
            }


        }

        private void button_return_Click(object sender, EventArgs e)
        {
            textBox_userName.Clear();
            textBox_PassWord.Clear();
            textBox_confirmPass.Clear();
            button_Delete.Enabled = false;
            button_Edit.Enabled = false;
        }

    }
}
