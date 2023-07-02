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
    public partial class Destination : Form
    {
        public Destination()
        {
            InitializeComponent();
        }

        int  ID;

        public void headerGridView()
        {
            dataGridViewDestination.Columns[0].HeaderText = "کد";
            dataGridViewDestination.Columns[1].HeaderText = "نشانی";
            dataGridViewDestination.Columns[2].HeaderText = "کرایه";
            dataGridViewDestination.Columns[3].HeaderText = "زوج و فرد";
        }

        private void button_add_Click(object sender, EventArgs e)
        {           
            bool status;
            bool checkStatus;

            Dest Destination = new Dest();
            
            if (checkBox_status.Checked)
                checkStatus=true;
            else
                checkStatus=false;
            status = Destination.add(textBox_address.Text.Trim(), textBox_price.Text.Trim(), checkStatus);

                if (textBox_address.Text.Trim () != null || textBox_price.Text.Trim () != null)

                if (status == true)
                {
                    MessageBox.Show("اطلاعات وارد شده با موفقیت ثبت شد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewDestination.DataSource = Destination.getAll();

                    textBox_address.Clear();
                    textBox_price.Clear();
                    checkBox_status.CheckState=CheckState.Unchecked;
                }
            
            if (status ==false  )
            {
                MessageBox.Show("اطلاعات وارد شده  ثبت نشد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Destination_Activated(object sender, EventArgs e)
        {
            Dest Destination = new Dest();

            dataGridViewDestination.DataSource = Destination.getAll();
            headerGridView();

            dataGridViewDestination.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridViewDestination_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dataGridViewDestination.CurrentRow.Cells[0].Value);
                textBox_address.Text = dataGridViewDestination.CurrentRow.Cells[1].Value.ToString();
                textBox_price.Text = dataGridViewDestination.CurrentRow.Cells[2].Value.ToString();
                if (Convert.ToBoolean(dataGridViewDestination.CurrentRow.Cells[3].Value) == true)
                    checkBox_status.CheckState = CheckState.Checked;
                else
                    checkBox_status.CheckState = CheckState.Unchecked;
            }
            catch { }
            button_delete.Enabled = true;
            button_edit.Enabled = true;
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            bool status;
            bool checkStatus;

            Dest Destination = new Dest();

            if (checkBox_status.Checked)
                checkStatus = true;
            else
                checkStatus = false;

            if (textBox_address.Text != null && textBox_price.Text != null)
            {
                status = Destination.edit(textBox_address.Text.Trim(), textBox_price.Text.Trim(), checkStatus,ID);
                button_delete.Enabled = false;
                button_edit.Enabled = false;
                if (status == true)
                {
                    MessageBox.Show("اطلاعات وارد شده با موفقیت ثبت شد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewDestination.DataSource = Destination.getAll();

                    textBox_address.Clear();
                    textBox_price.Clear();
                    checkBox_status.CheckState = CheckState.Unchecked;
                }
            }
            else
            {
                MessageBox.Show("اطلاعات وارد شده با ثبت نشد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Dest Destination = new Dest();
            if (ID != 0)
            {
                Destination.del(ID);
                MessageBox.Show("اطلاعات وارد شده با موفقیت ثبت شد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("عملیات انجام نشد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            dataGridViewDestination.DataSource = Destination.getAll();
            button_delete.Enabled = false;
            button_edit.Enabled = false;
        }

        private void Destination_Load(object sender, EventArgs e)
        {
            button_delete.Enabled = false;
            button_edit.Enabled = false;
        }

        private void textBox_price_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
        }
       
    }
}
