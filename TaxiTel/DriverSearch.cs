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
    public partial class DriverSearch : Form
    {
        public DriverSearch()
        {
            InitializeComponent();
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
        private void button_select_Click(object sender, EventArgs e)
        {
            serviceClass newService = new serviceClass();
            try
            {
                newService.IdDriver = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                this.Close();
            }
            catch
            {
            }
        }

        private void textBox_searchFamily_TextChanged(object sender, EventArgs e)
        {
            Drive newDriver = new Drive();
            dataGridView1.DataSource = newDriver.search(textBox_searchCode.Text, textBox_searchName.Text, textBox_searchFamily.Text, textBox_searchCirtification.Text);


        }

        private void textBox_searchCode_TextChanged(object sender, EventArgs e)
        {
            Drive newDriver = new Drive();
            dataGridView1.DataSource = newDriver.search(textBox_searchCode.Text, textBox_searchName.Text, textBox_searchFamily.Text, textBox_searchCirtification.Text);

        }

        private void textBox_searchName_TextChanged(object sender, EventArgs e)
        {
            Drive newDriver = new Drive();
            dataGridView1.DataSource = newDriver.search(textBox_searchCode.Text, textBox_searchName.Text, textBox_searchFamily.Text, textBox_searchCirtification.Text);

        }

        private void textBox_searchCirtification_TextChanged(object sender, EventArgs e)
        {
            Drive newDriver = new Drive();
            dataGridView1.DataSource = newDriver.search(textBox_searchCode.Text, textBox_searchName.Text, textBox_searchFamily.Text, textBox_searchCirtification.Text);

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            Drive newDriver = new Drive();
            dataGridView1.DataSource = newDriver.getDrivers();

        }

        private void DriverSearch_Activated(object sender, EventArgs e)
        {
            Drive newDriver = new Drive();
            dataGridView1.DataSource = newDriver.getDrivers();
            headerGridView();

        }

        private void DriverSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Service.ActiveForm.Select();
        }
    }
}
