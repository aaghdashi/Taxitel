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
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }
        string MasterPath = "";

        private void button_choose_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browse = new FolderBrowserDialog();
            if (browse.ShowDialog() == DialogResult.OK)
            {
                MasterPath = browse.SelectedPath;
                textBox1.Text = MasterPath;
            }
        }

        private void button_backup_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=null)
            {
                MessageBox.Show("در حین عملیات به چیزی دست نزنید");
                System.IO.Directory.CreateDirectory(MasterPath + @"\Backupajans");
                //پشتیبان گیری از بانک اطلاعاتی
                main newback = new main();
                try
                {
                    string query = "BACKUP DATABASE ajans TO DISK = '" + MasterPath + @"\Backupajans" + "\\ajans.MDF" + "'";
                    newback.backup(query);
                    MessageBox.Show("پشتیبان گیری به درستی انجام شد");
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

        private void button_ignore_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
