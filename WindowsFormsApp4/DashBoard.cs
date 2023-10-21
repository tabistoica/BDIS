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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        ConnectionString MyConnection = new ConnectionString();
        private void DashBoard_Load(object sender, EventArgs e)
        {
            PendingAppProgress.Value = 100;
            UsersProgress.Value = 100;
            Patients.Value = 100;
            NextApp.Value = 100;
            SqlConnection Con = MyConnection.GetCon();
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AppointmentTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Pendinglbl.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from PatientTbl", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Patientslbl.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from UserTbl", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            Userslbl.Text = dt2.Rows[0][0].ToString();
            SqlDataAdapter sda3 = new SqlDataAdapter("select min(ApDate) from AppointmentTbl", Con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            Nextlbl.Text = dt3.Rows[0][0].ToString();
            Con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Programari App = new Programari();
            App.Show();
            this.Hide();
        }
    }
}
