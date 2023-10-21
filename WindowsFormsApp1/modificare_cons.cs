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
    public partial class modificare_cons : UserControl
    {
        DataSet ds;
        OracleConnection conn = new OracleConnection(@"TNS_ADMIN=C:\Users\tabit\Oracle\network\admin;USER ID=STUDENT;DATA SOURCE=localhost:1521/xe;PERSIST SECURITY INFO=True;PASSWORD=student");

        public modificare_cons()
        {
            InitializeComponent();
        }

        public void showdata()
        {
            Proceduri Pro = new Proceduri();
            string query = "SELECT * FROM consultatii";

            ds = Pro.Show(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        public string get_date()
        {
            DateTime dt = DateTime.ParseExact(datactb.Text, "d/MM/yyyy", null);
            string date = dt.ToString("dd-MMM-yyyy");
            return date;
        }

        private void modificare_cons_Load(object sender, EventArgs e)
        {
            try
            {
                showdata();
                cnptb.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                nrcons.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                datactb.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                diagnostic.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                medi.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mod_btn_Click(object sender, EventArgs e)
        {
            Proceduri Pro = new Proceduri();
            try
            {
                string query = "Update consultatii set nr_consultatie='" + nrcons.Text + "',data_consultatie='" + get_date() 
                            + "',diagnostic='" + diagnostic.Text + "',medicamentatie='" + medi.Text 
                            + "' where cnp=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Pro.Update(query);
                MessageBox.Show("Datele au fost editate!");
                showdata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecteaza un rand din tabel!\n\n" + ex.Message);
            }
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

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            cnptb.Clear();
            nrcons.Clear();
            datactb.Clear();
            diagnostic.Clear();
            medi.Clear();
        }
    }
}
