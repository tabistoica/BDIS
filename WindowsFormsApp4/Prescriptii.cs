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
    public partial class Prescriptii : Form
    {
        public Prescriptii()
        {
            InitializeComponent();
        }
        ConnectionString MyCon = new ConnectionString();

        private void fillPatient()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Patient from AppointmentTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Patient", typeof(string));
            dt.Load(rdr);
            PatId.ValueMember = "Patient";
            PatId.DataSource = dt;
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
            dt.Columns.Add("Patient", typeof(string));
            dt.Load(rdr);
            PatId.ValueMember = "Patient";
            PatId.DataSource = dt;
            Con.Close();
        }

        private void GetTreatment()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from AppointmentTbl where Patient='" + PatId.SelectedValue.ToString() + "'", Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                TreatmentTb.Text = dr["Treatment"].ToString();
            }
            Con.Close();
        }

        private void GetPrice()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from TreatmentTbl where TreatName='" + TreatmentTb.Text + "'", Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TreatCostTb.Text = dr["TreatCost"].ToString();
            }
            Con.Close();
        }

        void populate()
        {
            Proceduri Pat = new Proceduri();
            string query = "select * from PrescriptionTbl";

            DataSet ds = Pat.Show(query);
            PrescriptionsDGV.DataSource = ds.Tables[0];
        }

        void filter()
        {
            Proceduri Pat = new Proceduri();
            string query = "select * from PrescriptionTbl where PatName like '%" + guna2TextBox1.Text + "%'";

            DataSet ds = Pat.Show(query);
            PrescriptionsDGV.DataSource = ds.Tables[0];
        }

        private void Prescriptii_Load(object sender, EventArgs e)
        {
            fillPatient();
            populate();
        }

        private void PatId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTreatment();
        }

        private void TreatmentTb_TextChanged(object sender, EventArgs e)
        {
            GetPrice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into PrescriptionTbl values('" + PatId.SelectedValue.ToString() + "','" + TreatmentTb.Text + "'," + TreatCostTb.Text + ",'" + MedicinesTb.Text + "'," + QtyTb.Text + ")";
            Proceduri Pat = new Proceduri();
            try
            {
                Pat.Add(query);
                MessageBox.Show("Prescriptie adaugata!");
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int key = 0;
        private void PrescriptionsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatId.SelectedValue = PrescriptionsDGV.SelectedRows[0].Cells[1].Value.ToString();
            TreatmentTb.Text = PrescriptionsDGV.SelectedRows[0].Cells[2].Value.ToString();
            TreatCostTb.Text = PrescriptionsDGV.SelectedRows[0].Cells[3].Value.ToString();
            MedicinesTb.Text = PrescriptionsDGV.SelectedRows[0].Cells[4].Value.ToString();
            QtyTb.Text = PrescriptionsDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (TreatmentTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PrescriptionsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proceduri Pat = new Proceduri();
            if (key == 0)
            {
                MessageBox.Show("Selecteaza prescriptia din lista!");
            }
            else
            {
                try
                {
                    string query = "Delete from PrescriptionTbl where PrescId=" + key + "";
                    Pat.Delete(query);
                    MessageBox.Show("Prescriptia a fost stearsa din lista!");
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2TextBox1_TextChange(object sender, EventArgs e)
        {
            filter();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;
        private void button3_Click(object sender, EventArgs e)
        {
            int height = PrescriptionsDGV.Height;
            PrescriptionsDGV.Height = PrescriptionsDGV.RowCount * PrescriptionsDGV.RowTemplate.Height * 2;
            bitmap = new Bitmap(PrescriptionsDGV.Width, PrescriptionsDGV.Height);
            PrescriptionsDGV.DrawToBitmap(bitmap, new Rectangle(0, 10, PrescriptionsDGV.Width, PrescriptionsDGV.Height));
            PrescriptionsDGV.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Pacienti Pat = new Pacienti();
            Pat.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Tratament Treat = new Tratament();
            Treat.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Programari Pro = new Programari();
            Pro.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            DashBoard Dash = new DashBoard();
            Dash.Show();
            this.Hide();
        }
    }
}
