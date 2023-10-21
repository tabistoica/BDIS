using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AdminLogin log = new AdminLogin();
            log.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        ConnectionString MyConnection = new ConnectionString();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = MyConnection.GetCon();
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTbl where Uname='" + UnameTb.Text + "' and Upass='" + UpassTb.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Programari App = new Programari();
                App.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nume Utilizator sau parola gresita!");
                UnameTb.Text = "";
                UpassTb.Text = "";
            }
            Con.Close();
        }
    }
}
