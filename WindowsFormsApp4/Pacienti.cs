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
    public partial class Pacienti : Form
    {
        public Pacienti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into PatientTbl values('" + PatNameTb.Text + "','" + PatPhoneTb.Text + "','" + AddressTb.Text + "','" + DOBDate.Value.Date + "','" + GenTb.SelectedItem.ToString() + "','" + AllergyTb.Text + "')";
            Proceduri Pat = new Proceduri();
            try
            {
                Pat.Add(query);
                MessageBox.Show("Pacient adaugat!");
                populate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void populate()
        {
            Proceduri Pat = new Proceduri();
            string query = "select * from PatientTbl";

            DataSet ds = Pat.Show(query);
            PatientDGV.DataSource = ds.Tables[0];
        }
        void filter()
        {
            Proceduri Pat = new Proceduri();
            string query = "select * from PatientTbl where PatName like '%" + guna2TextBox1.Text + "%'";

            DataSet ds = Pat.Show(query);
            PatientDGV.DataSource = ds.Tables[0];
        }
        private void Pacienti_Load(object sender, EventArgs e)
        {
            populate();
        }
        int key = 0;
        private void PatientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatNameTb.Text = PatientDGV.SelectedRows[0].Cells[1].Value.ToString();
            PatPhoneTb.Text = PatientDGV.SelectedRows[0].Cells[2].Value.ToString();
            AddressTb.Text = PatientDGV.SelectedRows[0].Cells[3].Value.ToString();
            GenTb.SelectedItem = PatientDGV.SelectedRows[0].Cells[5].Value.ToString();
            AllergyTb.Text = PatientDGV.SelectedRows[0].Cells[6].Value.ToString();
            if(PatNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PatientDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proceduri Pat = new Proceduri();
            if(key == 0)
            {
                MessageBox.Show("Selecteaza pacientul din lista!");
            }
            else
            {
                try
                {
                    string query = "Delete from PatientTbl where PatId=" + key + "";
                    Pat.Delete(query);
                    MessageBox.Show("Pacientul a fost sters din lista!");
                    populate();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Proceduri Pat = new Proceduri();
            if (key == 0)
            {
                MessageBox.Show("Selecteaza pacientul din lista!");
            }
            else
            {
                try
                {
                    string query = "Update PatientTbl set PatName='"+PatNameTb.Text+"',PatPhone='"+PatPhoneTb.Text+"',PatAddress='"+AddressTb.Text+"',PatDOB='"+DOBDate.Value.Date+"',PatGender='"+GenTb.SelectedItem.ToString()+"',PatAllergies='"+AllergyTb.Text+"' where PatId="+key+";";
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

        private void guna2TextBox1_TextChange(object sender, EventArgs e)
        {
            filter();
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

        private void label11_Click(object sender, EventArgs e)
        {
            Prescriptii Pre = new Prescriptii();
            Pre.Show();
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

        private void label5_Click(object sender, EventArgs e)
        {
            Fisa fis = new Fisa();
            fis.Show();
            this.Hide();
        }
    }
}
