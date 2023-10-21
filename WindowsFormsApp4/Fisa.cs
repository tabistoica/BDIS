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
    public partial class Fisa : Form
    {
        public Fisa()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Pacienti Pat = new Pacienti();
            Pat.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Programari Pro = new Programari();
            Pro.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Prescriptii Pre = new Prescriptii();
            Pre.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Tratament Treat = new Tratament();
            Treat.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            DashBoard Dash = new DashBoard();
            Dash.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void Fisa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.vedere' table. You can move, or remove it, as needed.
            this.vedereTableAdapter1.Fill(this.dataSet1.vedere);
            // TODO: This line of code loads data into the 'dentalDbDataSet.vedere' table. You can move, or remove it, as needed.
            this.vedereTableAdapter.Fill(this.dentalDbDataSet.vedere);

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM vedere WHERE PatName=" + "'" + guna2ImageButton1.Text + "'";
                ConnectionString conn = new ConnectionString();
                SqlConnection Con = conn.GetCon();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = query;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds, "vedere");
                DGV.DataSource = ds.Tables["vedere"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
