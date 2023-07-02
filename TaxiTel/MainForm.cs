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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا می خواهید خارج شوید؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void کاربرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersApp newform = new UsersApp();
            newform.MdiParent = this;
            newform.Show();

        }

        private void ماشینحسابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void نقاشیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint");
        }

        private void هاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer newform = new Customer();
            newform.MdiParent = this;
            newform.Show();
        }

        private void مسیرهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Destination newform = new Destination();
            newform.MdiParent = this;
            newform.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void رانندگانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Driver newform = new Driver();
            newform.MdiParent = this;
            newform.Show();
        }

        private void سرویسجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Service newform = new Service();
            newform.MdiParent = this;
            newform.Show();
        }

        private void پشتیبانگیریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backup newback = new Backup();
            newback.MdiParent = this;
            newback.Show();
        }

        private void بازیابیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restore newRestore = new Restore();
            newRestore.MdiParent = this;
            newRestore.Show();
        }

        private void دربارهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about newform = new about();
            newform.MdiParent = this;
            newform.Show();

        }

        private void حضوروغیابToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Attendence newform = new Attendence();
            newform.MdiParent = this;
            newform.Show();
        }   

     

        private void گزارشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report newform = new Report();
            newform.MdiParent = this;
            newform.Show();
        }     
    }
}
