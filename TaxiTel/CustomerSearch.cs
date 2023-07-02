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
    public partial class CustomerSearch : Form
    {
        public CustomerSearch()
        {
            InitializeComponent();
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


        }

        private void textBox_searchCode_TextChanged(object sender, EventArgs e)
        {
            Customers newCustomer = new Customers();
            dataGridView_customer.DataSource = newCustomer.search(textBox_searchCode.Text.Trim(), textBox_searchName.Text, textBox_searchFamily.Text);

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

        private void button_refresh_Click(object sender, EventArgs e)
        {
            Customers newCustomer = new Customers();
            dataGridView_customer.DataSource = newCustomer.getCustomers();

        }

        private void CustomerSearch_Activated(object sender, EventArgs e)
        {
            Customers newCustomer = new Customers();
            dataGridView_customer.DataSource = newCustomer.getCustomers();

            headerGridView();
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            serviceClass newService = new serviceClass();
            try
            {
                newService.IdCustomer = Convert.ToInt32(dataGridView_customer.CurrentRow.Cells[0].Value);
                this.Close();
            }
            catch { }
           
        }

        private void CustomerSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Service.ActiveForm.Select();
        }

        private void button_newCustomer_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer();
            newCustomer.ShowDialog();
        }

    }
}
