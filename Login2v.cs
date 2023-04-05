using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static TheFinal.Login1v;

namespace TheFinal
{
    public partial class Login2v : Form
    {
        Authentication TTT = new Authentication();
        public Login2v()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            bool success = TTT.Login(username, password);
            if (success)
            {
                this.Hide();
                Home1b f2 = new Home1b();
                f2.Show();
            }
            else
            {
                MessageBox.Show("User หรือ Password ไม่ถูกต้อง");
            }

        }

        private void Login2v_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f0 = new Form1();
            f0.Show();
        }
    }
}
