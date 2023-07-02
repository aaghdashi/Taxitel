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
    public partial class Attendence : Form
    {
        public Attendence()
        {
            InitializeComponent();
        }

        public void headerGridView()
        {
            dataGridView1.Columns[0].HeaderText = "کد";
            dataGridView1.Columns[1].HeaderText = "نام";
            dataGridView1.Columns[2].HeaderText = "نام خانوادگی";
            dataGridView1.Columns[3].HeaderText = "حاضر";

        }

        private void Attendence_Activated(object sender, EventArgs e)
        {
            Drive newDriver = new Drive();
            dataGridView1.DataSource = newDriver.ListDrivers();
            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ScrollBars = ScrollBars.Both;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            headerGridView();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool _status;
            try
            {
                button_edit.Enabled = true;
                textBox_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox_family.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                _status = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[3].Value);
                switch (_status)
                {
                    case false:
                        checkBox_enable.Checked = false;
                        break;
                    case true:
                        checkBox_enable.Checked = true;
                        break;
                }
            }
            catch
            {
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            Drive newDriver = new Drive();
            dataGridView1.DataSource = newDriver.ListDrivers();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_name.Clear();
            textBox_family.Clear();
            checkBox_enable.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            Drive newDriver = new Drive();
            bool _status;
            Boolean _enabled=false;
            switch (Convert.ToBoolean(checkBox_enable.CheckState))
                {
                    case false:
                        _enabled = false;
                        break;
                    case true:
                        _enabled = true;
                        break;
                }

            if (textBox_id.Text != null)
            {
                _status = newDriver.attendenceDriver(Convert.ToInt32(textBox_id.Text), _enabled);
                if (_status == true)
                {
                    MessageBox.Show("اطلاعات وارد شده با موفقیت ثبت شد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = newDriver.ListDrivers();
                    button_edit.Enabled = false;
                }
                else
                {
                    MessageBox.Show("اطلاعات وارد شده ثبت نشد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Drive newDriver = new Drive();

            if (radioButton1.Checked)
            {
                dataGridView1.DataSource= newDriver.ListDrivers(true);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Drive newDriver = new Drive();

            if (radioButton2.Checked)
            {
                dataGridView1.DataSource = newDriver.ListDrivers(false);
            }
        }
    }
}
