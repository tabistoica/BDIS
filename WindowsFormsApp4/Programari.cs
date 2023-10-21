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
    public partial class Programari : Form
    {
        public Programari()
        {
            InitializeComponent();
        }
        ConnectionString MyCon = new ConnectionString();

        private void fillPatient()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PatName from PatientTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PatName", typeof(string));
            dt.Load(rdr);
            PatientCb.ValueMember = "PatName";
            PatientCb.DataSource = dt;
            Con.Close();
        }

        private void fillTreatment()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select TreatName from TreatmentTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TreatName", typeof(string));
            dt.Load(rdr);
            TreatmentCb.ValueMember = "TreatName";
            TreatmentCb.DataSource = dt;
            Con.Close();
        }
        void populate()
        {
            Proceduri Pat = new Proceduri();
            string query = "select * from AppointmentTbl";

            DataSet ds = Pat.Show(query);
            AppointmentDGV.DataSource = ds.Tables[0];
        }

        void filter()
        {
            Proceduri Pat = new Proceduri();
            string query = "select * from AppointmentTbl where Patient like '%" + guna2TextBox1.Text + "%'";

            DataSet ds = Pat.Show(query);
            AppointmentDGV.DataSource = ds.Tables[0];
        }

        private void Programari_Load(object sender, EventArgs e)
        {
            fillPatient();
            fillTreatment();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into AppointmentTbl values('" + PatientCb.SelectedValue.ToString() + "','" + TreatmentCb.SelectedValue.ToString() + "','" + Date.Value.Date + "','" + Time.Value.TimeOfDay + "')";
            Proceduri Pat = new Proceduri();
            try
            {
                Pat.Add(query);
                MessageBox.Show("Programare inregistrata!");
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Proceduri Pat = new Proceduri();
            if (key == 0)
            {
                MessageBox.Show("Selecteaza programarea din lista!");
            }
            else
            {
                try
                {
                    string query = "Update AppointmentTbl set Patient='" + PatientCb.SelectedValue.ToString() + "',Treatment='" + TreatmentCb.SelectedValue.ToString() + "',ApDate='" + Date.Value.Date + "',ApTime='" + Time.Value.TimeOfDay + "' where ApId=" + key + ";";
                    Pat.Update(query);
                    MessageBox.Show("Datele au fost editate cu succes!");
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proceduri Pat = new Proceduri();
            if (key == 0)
            {
                MessageBox.Show("Selecteaza programarea din lista!");
            }
            else
            {
                try
                {
                    string query = "Delete from AppointmentTbl where ApId=" + key + "";
                    Pat.Delete(query);
                    MessageBox.Show("Programarea a fost anulata!");
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        int key = 0;
        private void AppointmentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatientCb.SelectedValue = AppointmentDGV.SelectedRows[0].Cells[1].Value.ToString();
            TreatmentCb.SelectedValue = AppointmentDGV.SelectedRows[0].Cells[2].Value.ToString();
            string pat = AppointmentDGV.SelectedRows[0].Cells[2].Value.ToString();
            if (pat == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(AppointmentDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void guna2TextBox1_TextChange(object sender, EventArgs e)
        {
            filter();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            Pacienti Pat = new Pacienti();
            Pat.Show();
            this.Hide();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            Tratament Treat = new Tratament();
            Treat.Show();
            this.Hide();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            Prescriptii Pres = new Prescriptii();
            Pres.Show();
            this.Hide();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            DashBoard Dash = new DashBoard();
            Dash.Show();
            this.Hide();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
