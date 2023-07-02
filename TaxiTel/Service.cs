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
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }

        bool _status;

        public void controlClear()
        {
            textBox_customerCode.Clear();
            textBox_customerName.Clear();
            textBox_customerFamily.Clear();
            textBox_customerMobile.Clear();
            textBox_customerTel.Clear();
            textBox_customerAddress.Clear();
            textBox_destinationCode.Clear();
            textBox_destinationPrice.Clear();
            textBox_destinationZone.Clear();
            textBox_driverCode.Clear();
            textBox_driverName.Clear();
            textBox_driverFamily.Clear();
            textBox_driverMobile.Clear();
            textBox_type.Clear();

        }


        public void headerGridView()
        {
            dataGridView1.Columns[0].HeaderText = "کد";
            dataGridView1.Columns[1].HeaderText = "کد مشتری";
            dataGridView1.Columns[2].HeaderText = "کد راننده";
            dataGridView1.Columns[3].HeaderText = "کد مقصد";
            dataGridView1.Columns[4].HeaderText = "تاریخ";
            dataGridView1.Columns[5].HeaderText = "ساعت رفت";
            dataGridView1.Columns[6].HeaderText = "ساعت برگشت";
            dataGridView1.Columns[7].HeaderText = "نام";
            dataGridView1.Columns[8].HeaderText = "نام خانوادگی";
            dataGridView1.Columns[9].HeaderText = "آدرس";

        }

        private void Service_Load(object sender, EventArgs e)
        {
            button_delete.Enabled = false;
            button_edit.Enabled = false;
        }

        private void button_SearchCustomer_Click(object sender, EventArgs e)
        {
            CustomerSearch newSearch = new CustomerSearch();
            newSearch.ShowDialog();
        }

        private void Service_Activated(object sender, EventArgs e)
        {
            serviceClass newService = new serviceClass();
            dataGridView1.DataSource = newService.getServices();
            headerGridView();
        }

        private void button_searchDriver_Click(object sender, EventArgs e)
        {
            DriverSearch newSearch = new DriverSearch();
            newSearch.ShowDialog();
        }

        private void button_searchDestination_Click(object sender, EventArgs e)
        {
            DestinationSearch newSearch = new DestinationSearch();
            newSearch.ShowDialog();
        }

        private void Service_Shown(object sender, EventArgs e)
        {
        }

        private void Service_MouseEnter(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            serviceClass newService = new serviceClass();
            if (newService.IdCustomer != 0)
            {
                dt = newService.getCustomer();
                
                textBox_customerCode.Text = dt.Rows[0][0].ToString();
                textBox_customerName.Text = dt.Rows[0][1].ToString();
                textBox_customerFamily.Text = dt.Rows[0][2].ToString();
                textBox_customerMobile.Text = dt.Rows[0][3].ToString();
                textBox_customerTel.Text = dt.Rows[0][4].ToString();
                textBox_customerAddress.Text = dt.Rows[0][5].ToString();
                dt.Clear();
            }
            if (newService.IdDestination != 0)
            {
                dt = newService.getDetination();

                textBox_destinationCode.Text = dt.Rows[0][0].ToString();
                textBox_destinationPrice.Text = dt.Rows[0][2].ToString(); 
                textBox_destinationZone.Text = dt.Rows[0][1].ToString();
                
                dt.Clear();
            }
            if (newService.IdDriver != 0)
            {
                dt = newService.getDriver();

                textBox_driverCode.Text = dt.Rows[0][0].ToString();
                textBox_driverName.Text = dt.Rows[0][1].ToString();
                textBox_driverFamily.Text = dt.Rows[0][2].ToString();
                textBox_driverMobile.Text = dt.Rows[0][3].ToString();
                textBox_type.Text = dt.Rows[0][4].ToString();
                dt.Clear();
            }

        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            controlClear();
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            serviceClass newService = new serviceClass();
            dataGridView1.DataSource = newService.getService(textBox_searchIdService.Text, textBox_serchIdCustomer.Text, textBox_searchIdDriver.Text, textBox_searchIdDestination.Text);

        }

        private void textBox_searchIdService_TextChanged(object sender, EventArgs e)
        {
            serviceClass newService = new serviceClass();
            dataGridView1.DataSource = newService.getService(textBox_searchIdService.Text, textBox_serchIdCustomer.Text, textBox_searchIdDriver.Text, textBox_searchIdDestination.Text);
        }

        private void textBox_serchIdCustomer_TextChanged(object sender, EventArgs e)
        {
            serviceClass newService = new serviceClass();
            dataGridView1.DataSource = newService.getService(textBox_searchIdService.Text, textBox_serchIdCustomer.Text, textBox_searchIdDriver.Text, textBox_searchIdDestination.Text);

        }

        private void textBox_searchIdDestination_TextChanged(object sender, EventArgs e)
        {
            serviceClass newService = new serviceClass();
            dataGridView1.DataSource = newService.getService(textBox_searchIdService.Text, textBox_serchIdCustomer.Text, textBox_searchIdDriver.Text, textBox_searchIdDestination.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            serviceClass newService = new serviceClass();
            dataGridView1.DataSource = newService.getServices();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            serviceClass newService = new serviceClass();

            button_edit.Enabled = true;
            button_delete.Enabled = true;

            try
            {
                newService.IdService = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                newService.IdCustomer = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                newService.IdDriver = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
                newService.IdDestination = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
                hM_FarsiCalendar_serviceDate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox_serviceTimeGo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox_serviceTimeBack.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
            catch
            { }
            DataTable dt = new DataTable();
            tabControl1.SelectedTab = tabPage1;

            if (newService.IdCustomer != 0)
            {
                dt = newService.getCustomer();

                textBox_customerCode.Text = dt.Rows[0][0].ToString();
                textBox_customerName.Text = dt.Rows[0][1].ToString();
                textBox_customerFamily.Text = dt.Rows[0][2].ToString();
                textBox_customerMobile.Text = dt.Rows[0][3].ToString();
                textBox_customerTel.Text = dt.Rows[0][4].ToString();
                textBox_customerAddress.Text = dt.Rows[0][5].ToString();
                dt.Clear();
            }
            if (newService.IdDestination != 0)
            {
                dt = newService.getDetination();

                textBox_destinationCode.Text = dt.Rows[0][0].ToString();
                textBox_destinationPrice.Text = dt.Rows[0][1].ToString();
                textBox_destinationZone.Text = dt.Rows[0][2].ToString();

                dt.Clear();
            }
            if (newService.IdDriver != 0)
            {
                dt = newService.getDriver();

                textBox_driverCode.Text = dt.Rows[0][0].ToString();
                textBox_driverName.Text = dt.Rows[0][1].ToString();
                textBox_driverFamily.Text = dt.Rows[0][2].ToString();
                textBox_driverMobile.Text = dt.Rows[0][3].ToString();
                textBox_type.Text = dt.Rows[0][4].ToString();
                dt.Clear();
           }
        }


        private void button_add_Click(object sender, EventArgs e)
        {

            serviceClass service = new serviceClass();

            string _command = "INSERT INTO Service_tbl (Date ,TimeBegin,TimeEnd,ID_Customer,ID_Driver,ID_Destination,Address)     VALUES ('" + hM_FarsiCalendar_serviceDate.Text + "','" + textBox_serviceTimeGo.Text + "','" + textBox_serviceTimeBack.Text + "','" + textBox_customerCode.Text + "','" + textBox_driverCode.Text + "','" + textBox_destinationCode.Text + "','" + textBox_destinationAddress.Text + "')";

            serviceClass newService = new serviceClass();
            _status = newService.addService(_command);

            if (_status == true)
            {
                MessageBox.Show("اطلاعات وارد شده با موفقیت ثبت شد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);

                button_delete.Enabled = false;
                button_edit.Enabled = false;
                controlClear();
            }

            else
            {
                MessageBox.Show("اطلاعات وارد شده با ثبت نشد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void button_edit_Click(object sender, EventArgs e)
        {


            serviceClass newService = new serviceClass();
            string _command = "UPDATE Service_tbl  SET Date='" + hM_FarsiCalendar_serviceDate.Text + "', TimeBegin='" + textBox_serviceTimeGo.Text + "',TimeEnd='" + textBox_serviceTimeBack.Text + "',ID_Customer='" + textBox_customerCode.Text + "',ID_Driver='" + textBox_driverCode.Text + "',ID_Destination='" + textBox_destinationCode.Text + "',Address='" + textBox_destinationAddress.Text + "' WHERE ID='" + newService.IdService + "'";

            _status = newService.addService(_command);


                if (_status == true)
                {
                    MessageBox.Show("اطلاعات وارد شده با موفقیت ثبت شد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = newService.getServices();
                    button_delete.Enabled = false;
                    button_edit.Enabled = false;
                    controlClear();
                }
            else
            {
                MessageBox.Show("عملیات انجام نشد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                newService.Clear();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            serviceClass newService = new serviceClass();

            _status = newService.deleteService(newService.IdService);


            if (_status == true)
            {
                MessageBox.Show("اطلاعات وارد شده با موفقیت ثبت شد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("عملیات انجام نشد.", "انجام عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView1.DataSource = newService.getServices();
            controlClear();
            button_delete.Enabled = false;
            button_edit.Enabled = false;
            newService.Clear();
        }        
    }
}
