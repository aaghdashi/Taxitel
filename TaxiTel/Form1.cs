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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        main Login = new main();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {
            bool status;
            if (textBox_UserName.Text != "" && textBox_PassWord.Text != "")
            {
                status = Login.login(textBox_UserName.Text.Trim(), textBox_PassWord.Text.Trim());

                if (status== true)
                {
                    MainForm fm = new MainForm();
                    fm.ShowDialog();


                }
                else
                {

                    if (MessageBox.Show("اطلاعات وارد شده صحیح نیست خارج می شوید؟", "تایید هویت", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                        Application.Exit();

                    textBox_UserName.Clear();
                    textBox_PassWord.Clear();
                }

            }


            else
            {

                MessageBox.Show("فیلد های خالی تکمیل شود", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا می خواهید خارج شوید؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        }
    }
