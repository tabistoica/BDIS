using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class stergere_pac : UserControl
    {
        DataSet ds;
        OracleConnection conn = new OracleConnection(@"TNS_ADMIN=C:\Users\tabit\Oracle\network\admin;USER ID=STUDENT;DATA SOURCE=localhost:1521/xe;PERSIST SECURITY INFO=True;PASSWORD=student");

        public void showdata()
        {
            Proceduri Pro = new Proceduri();
            string query = "SELECT * FROM pacienti";

            ds = Pro.Show(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        public DateTime get_date()
        {
            string date = maskedTbCNP.Text.Substring(5, 2) + "/" + maskedTbCNP.Text.Substring(3, 2) + "/" + maskedTbCNP.Text.Substring(1, 2);
            DateTime dt = DateTime.ParseExact(date, "d/MM/yy", null);
            return dt;
        }

        public int get_age()
        {
            int age = (int)((DateTime.Now - get_date()).TotalDays / 365.242199);
            return age;
        }

        public void filter()
        {
            Proceduri Pro = new Proceduri();
            string query = "SELECT * FROM pacienti WHERE cnp LIKE '" + textBox1.Text + "%'";

            DataSet ds = Pro.Show(query);
            dataGridView1.DataSource = ds.Tables[0];
            if (dataGridView1.Rows.Count < 1)
            {
                label9.ForeColor = System.Drawing.Color.Red;
                label9.Text = "Nu exista...";

                maskedTbCNP.Clear();
                numetb.Clear();
                prenumetb.Clear();
                adresatb.Clear();
                datantb.Clear();
                varstatb.Clear();
            }
            else
            {
                label9.ForeColor = System.Drawing.Color.Green;
                label9.Text = "Exista...";

                maskedTbCNP.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                numetb.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                prenumetb.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                adresatb.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                datantb.Text = get_date().ToString("dd-MMM-yyyy");
                varstatb.Text = get_age().ToString();
            }
            if (textBox1.Text == "")
            {
                label9.Text = "";
                maskedTbCNP.Clear();
                numetb.Clear();
                prenumetb.Clear();
                adresatb.Clear();
                datantb.Clear();
                varstatb.Clear();
            }
        }

        public stergere_pac()
        {
            InitializeComponent();
        }

        private void stergere_pac_Load(object sender, EventArgs e)
        {
            try
            {
                showdata();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Proceduri Pro = new Proceduri();
            DialogResult dialog = MessageBox.Show("ATENTIE!!!\n\nOdata cu stergerea unui pacient se vor sterge si toate datele privin consultatiile!\n\n"
                + "Doriti stergerea datelor?","Stergere", MessageBoxButtons.YesNo);
            try
            {
                if (dialog == DialogResult.Yes)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //sterge date pacient si consultatii
                        string query = "DELETE FROM pacienti WHERE cnp=" + maskedTbCNP.Text + "";
                        Pro.Delete(query);
                        textBox1.Clear();
                        MessageBox.Show("Datele pacientului au fost sterse!");
                        showdata();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            maskedTbCNP.Clear();
            numetb.Clear();
            prenumetb.Clear();
            adresatb.Clear();
            datantb.Clear();
            varstatb.Clear();
        }
    }
}
