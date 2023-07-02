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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        public void headerGridView()
        {
            dataGridView1.Columns[0].HeaderText = "کد";
            dataGridView1.Columns[1].HeaderText = "تاریخ";
            dataGridView1.Columns[2].HeaderText = "زمان";
            dataGridView1.Columns[3].HeaderText = "نام و نام خانوادگی راننده";
            dataGridView1.Columns[4].HeaderText = "نامو نام خانوادگی مشتری";
            dataGridView1.Columns[5].HeaderText = "هزینه";
            dataGridView1.Columns[6].HeaderText = "سهم راننده";         
            
        }

        private void Report_Activated(object sender, EventArgs e)
        {
            ReportService report = new ReportService();
            dataGridView1.DataSource = report.getServices();
            
            headerGridView();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportService report = new ReportService();
            dataGridView1.DataSource = report.getServices();

        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            stiReport1.Show();
        }

       
    }
}
