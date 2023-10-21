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
    public partial class stergere_cons : UserControl
    {
        DataSet ds;
        OracleConnection conn = new OracleConnection(@"TNS_ADMIN=C:\Users\tabit\Oracle\network\admin;USER ID=STUDENT;DATA SOURCE=localhost:1521/xe;PERSIST SECURITY INFO=True;PASSWORD=student");

        public void showdata()
        {
            Proceduri Pro = new Proceduri();
            string query = "SELECT * FROM consultatii";

            ds = Pro.Show(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        public void filter()
        {
            Proceduri Pro = new Proceduri();
            string query = "SELECT * FROM consultatii WHERE cnp LIKE '" + textBox1.Text + "%'";

            DataSet ds = Pro.Show(query);
            dataGridView1.DataSource = ds.Tables[0];
            if (dataGridView1.Rows.Count < 1)
            {
                label9.ForeColor = System.Drawing.Color.Red;
                label9.Text = "Nu exista...";

                cnptb.Clear();
                nrcons.Clear();
                datactb.Clear();
                diagnostic.Clear();
                medi.Clear();
            }
            else
            {
                label9.ForeColor = System.Drawing.Color.Green;
                label9.Text = "Exista...";

                cnptb.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                nrcons.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                datactb.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                diagnostic.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                medi.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            }
            if (textBox1.Text == "")
            {
                label9.Text = "";
                cnptb.Clear();
                nrcons.Clear();
                datactb.Clear();
                diagnostic.Clear();
                medi.Clear();
            }
        }

        public stergere_cons()
        {
            InitializeComponent();
        }

        private void stergere_cons_Load(object sender, EventArgs e)
        {
            try
            {
                showdata();
            }
            catch (Exception ex)
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

        private void del_btn_Click(object sender, EventArgs e)
        {
            Proceduri Pro = new Proceduri();
            DialogResult dialog = MessageBox.Show("Doriti stergerea datelor?", "Stergere", MessageBoxButtons.YesNo);
            try
            {
                if (dialog == DialogResult.Yes)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        string query = "DELETE FROM consultatii WHERE cnp=" + cnptb.Text + " and nr_consultatie=" + nrcons.Text;
                        Pro.Delete(query);
                        textBox1.Clear();
                        MessageBox.Show("Datele consultatiei au fost sterse!");
                        showdata();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nu exista date!\n\nSelectati o inregistrare din lista sau cautati in functie de cnp-ul pacientului!\n\n" + ex.Message);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            cnptb.Clear();
            nrcons.Clear();
            datactb.Clear();
            diagnostic.Clear();
            medi.Clear();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                cnptb.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                nrcons.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                datactb.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                diagnostic.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                medi.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
    }
}
