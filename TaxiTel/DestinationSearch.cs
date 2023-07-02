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
    public partial class DestinationSearch : Form
    {
        public DestinationSearch()
        {
            InitializeComponent();
        }
        bool? status;
        public void headerGridView()
        {
            dataGridViewDestination.Columns[0].HeaderText = "کد";
            dataGridViewDestination.Columns[1].HeaderText = "نشانی";
            dataGridViewDestination.Columns[2].HeaderText = "کرایه";
            dataGridViewDestination.Columns[3].HeaderText = "زوج و فرد";
        }
        private void textBox_address_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox_status.SelectedIndex)
            {
                case 0:
                    status = null;
                    break;
                case 1:
                    status = true;
                    break;
                case 2:
                    status = false;
                    break;

            }
            Dest newDest = new Dest();
            dataGridViewDestination.DataSource = newDest.search(textBox_id.Text, status);
        }

        private void comboBox_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_status.SelectedIndex)
            {
                case 0:
                    status = null;
                    break;
                case 1:
                    status = true;
                    break;
                case 2:
                    status = false;
                    break;
            }
            Dest newDest = new Dest();
            dataGridViewDestination.DataSource = newDest.search(textBox_id.Text, status);
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            serviceClass newService = new serviceClass();
            try
            {
                newService.IdDestination = Convert.ToInt32(dataGridViewDestination.CurrentRow.Cells[0].Value);
                this.Close();
            }
            catch { }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            Dest newDest = new Dest();
            dataGridViewDestination.DataSource = newDest.getAll();

        }

        private void DestinationSearch_Activated(object sender, EventArgs e)
        {
            Dest newDest = new Dest();
            dataGridViewDestination.DataSource = newDest.getAll();

            headerGridView();

            dataGridViewDestination.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private void DestinationSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Service.ActiveForm.Select();
        }

        private void DestinationSearch_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewDestination_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_id.Text = dataGridViewDestination.CurrentRow.Cells[0].Value.ToString();
                switch (Convert.ToBoolean(dataGridViewDestination.CurrentRow.Cells[0].Value))
                {
                    case true:
                        comboBox_status.SelectedIndex = 1;
                        break;
                    case false:
                        comboBox_status.SelectedIndex = 2;
                        break;
                    default :
                        comboBox_status.SelectedIndex = 0;
                        break;
                }
                if (Convert.ToBoolean(dataGridViewDestination.CurrentRow.Cells[2].Value) == true) { }
                //else
            }
            catch { }
        }
    }
}
