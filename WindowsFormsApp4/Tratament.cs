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
    public partial class Tratament : Form
    {
        public Tratament()
        {
            InitializeComponent();
        }
        void populate()
        {
            Proceduri Pat = new Proceduri();
            string query = "select * from TreatmentTbl";

            DataSet ds = Pat.Show(query);
            TreatmentDGV.DataSource = ds.Tables[0];
        }

        void filter()
        {
            Proceduri Pat = new Proceduri();
            string query = "select * from TreatmentTbl where TreatName like '%" + guna2TextBox1.Text + "%'";

            DataSet ds = Pat.Show(query);
            TreatmentDGV.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into TreatmentTbl values('" + TreatNameTb.Text + "','" + TreatCost.Text + "','" + TreatDesc.Text + "')";
            Proceduri Pat = new Proceduri();
            try
            {
                Pat.Add(query);
                MessageBox.Show("Tratament adaugat!");
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int key = 0;
        private void Tratament_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Proceduri Pat = new Proceduri();
            if (key == 0)
            {
                MessageBox.Show("Selecteaza tratamentul din lista!");
            }
            else
            {
                try
                {
                    string query = "Update TreatmentTbl set TreatName='" + TreatNameTb.Text + "',TreatCost='" + TreatCost.Text + "',TreatDesc='" + TreatDesc.Text + "' where TreatId=" + key + ";";
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
                MessageBox.Show("Selecteaza tratamentul din lista!");
            }
            else
            {
                try
                {
                    string query = "Delete from TreatmentTbl where TreatId=" + key + "";
                    Pat.Delete(query);
                    MessageBox.Show("Tratamentul a fost sters din lista!");
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TreatmentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TreatNameTb.Text = TreatmentDGV.SelectedRows[0].Cells[1].Value.ToString();
            TreatCost.Text = TreatmentDGV.SelectedRows[0].Cells[2].Value.ToString();
            TreatDesc.Text = TreatmentDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (TreatNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TreatmentDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void guna2TextBox1_TextChange(object sender, EventArgs e)
        {
            filter();
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
            Prescriptii Pres = new Prescriptii();
            Pres.Show();
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
    }
}
