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
    public partial class adaugare_cons : UserControl
    {
        DataSet ds;
        OracleConnection conn = new OracleConnection(@"TNS_ADMIN=C:\Users\tabit\Oracle\network\admin;USER ID=STUDENT;DATA SOURCE=localhost:1521/xe;PERSIST SECURITY INFO=True;PASSWORD=student");

        public adaugare_cons()
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

        private void adaugare_cons_Load(object sender, EventArgs e)
        {
            try
            {
                showdata();

                conn.Open();
                OracleCommand cmd = new OracleCommand("Select cnp from pacienti", conn);
                OracleDataReader dr;
                dr = cmd.ExecuteReader();
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    collection.Add(dr["cnp"].ToString());
                }
                cnptb.AutoCompleteCustomSource = collection;
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Proceduri Pro = new Proceduri();
                string query = "INSERT INTO consultatii VALUES ('" + cnptb.Text + "','" + nrcons.Text + "','" + get_date() + "','" + diagnostic.Text + "','" + medi.Text + "')";
                Pro.Add(query);
                MessageBox.Show("OK‐ adaugat");
                showdata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Introduceti date in toate campurile!\n\n " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
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
