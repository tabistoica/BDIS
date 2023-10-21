using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(AdminPass.Text == "")
            {
                MessageBox.Show("Introdu parola pentru admin!");
            }
            else if(AdminPass.Text == "Password")
            {
                Utilizatori U = new Utilizatori();
                U.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Parola gresita. Contacteaza administratorul!");
            }
        }
    }
}
