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
    public partial class Restore : Form
    {
        public Restore()
        {
            InitializeComponent();
        }
        string path;
        private void button_ignore_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_restore_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length > 0)
            {
                main newback = new main();

                try
                {
                   
                    //USE master RESTORE DATABASE [نام بانک اطلاعاتی] FROM DISK = 'مسیر فایل بانک اطلاعاتی'
                    string query = "" + "USE master" + " RESTORE DATABASE [ajans] FROM DISK = '" + path + "'";
                    newback.backup(query);

                    MessageBox.Show("بازیابی به درستی انجام شد");
                }
                catch
                {
                    MessageBox.Show("اشکال در ارتباط با بانک اطلاعاتی");
                }
            }
            else
            {
                MessageBox.Show(" ! " + "مسیر انتخاب نشده است", "خطا");

            }
        }

        private void button_choose_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Restore File (*.MDF) |*.MDF";
            if (op.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = op.FileName;
                path = op.FileName;
            }
        }
    }
}
