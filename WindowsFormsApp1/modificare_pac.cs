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
    public partial class modificare_pac : UserControl
    {
        DataSet ds;
        OracleConnection conn = new OracleConnection(@"TNS_ADMIN=C:\Users\tabit\Oracle\network\admin;USER ID=STUDENT;DATA SOURCE=localhost:1521/xe;PERSIST SECURITY INFO=True;PASSWORD=student");

        public modificare_pac()
        {
            InitializeComponent();
        }

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

        private void modificare_pac_Load(object sender, EventArgs e)
        {
            try
            {
                showdata();
                maskedTbCNP.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                numetb.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                prenumetb.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                adresatb.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                datantb.Text = get_date().ToString("dd-MMM-yyyy");
                varstatb.Text = get_age().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            maskedTbCNP.Clear();
            numetb.Clear();
            prenumetb.Clear();
            adresatb.Clear();
            datantb.Clear();
            varstatb.Clear();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            Proceduri Pro = new Proceduri();
            try
            {
                string query = "Update pacienti set nume='" + numetb.Text + "',prenume='" + prenumetb.Text
                            + "',adresa='" + adresatb.Text + "' where cnp=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
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
                maskedTbCNP.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                numetb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                prenumetb.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                adresatb.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                datantb.Text = get_date().ToString("dd-MMM-yyyy");
                varstatb.Text = get_age().ToString();
            }
        }
    }
}
