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
    public partial class cautare_pac : UserControl
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
            string query = "SELECT * FROM consultatii WHERE cnp LIKE '" + textBox1.Text + "%'";

            DataSet ds = Pro.Show(query);
            dataGridView1.DataSource = ds.Tables[0];

            if (Pro.Value("select cnp from pacienti where cnp like '" + textBox1.Text + "%'") == "")
            {
                label9.ForeColor = System.Drawing.Color.Red;
                label9.Text = "Nu exista...";
            }
            else
            {
                label9.ForeColor = System.Drawing.Color.Green;
                label9.Text = "Exista...";

                maskedTbCNP.Text = Pro.Value("select cnp from pacienti where cnp like '" + textBox1.Text + "%'");
                numetb.Text = Pro.Value("select nume from pacienti where cnp like '" + maskedTbCNP.Text + "%'");
                prenumetb.Text = Pro.Value("select prenume from pacienti where cnp like '" + maskedTbCNP.Text + "%'");
                adresatb.Text = Pro.Value("select adresa from pacienti where cnp like '" + maskedTbCNP.Text + "%'");
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

        public cautare_pac()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            numetb.Clear();
            maskedTbCNP.Clear();
            textBox1.Clear();
            prenumetb.Clear();
            adresatb.Clear();
            datantb.Clear();
            varstatb.Clear();
        }

        private void cautare_pac_Load(object sender, EventArgs e)
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
    }
}
