using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class adaugare_pac : UserControl
    {
        DataSet ds;
        OracleConnection conn = new OracleConnection(@"TNS_ADMIN=C:\Users\tabit\Oracle\network\admin;USER ID=STUDENT;DATA SOURCE=localhost:1521/xe;PERSIST SECURITY INFO=True;PASSWORD=student");

        public adaugare_pac()
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Proceduri Pro = new Proceduri();
                string query = "INSERT INTO pacienti VALUES ('" + maskedTbCNP.Text + "','" + numetb.Text + "','" + prenumetb.Text + "','"
                        + adresatb.Text + "','" + datantb.Text + "','" + varstatb.Text + "')";
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

        private void adaugare_pac_Load(object sender, EventArgs e)
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

        private void maskedTbCNP_Validating(object sender, CancelEventArgs e)
        {
            MaskedTextBox tb = sender as MaskedTextBox;
            if (tb != null)
            {
                int i = tb.Text.Length;
                //Set your desired minimumlength here '13'
                if (i < 13)
                {

                    MessageBox.Show("CNP-ul trebuie sa contina 13 cifre");
                    return;

                }
            }
            else e.Cancel = true;
        }

        private void maskedTbCNP_TextChanged(object sender, EventArgs e)
        {
            if (maskedTbCNP.MaskCompleted)
            {
                try
                {
                    datantb.Text = get_date().ToString("dd-MMM-yyyy");
                    varstatb.Text = get_age().ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("CNP-ul nu este valid!\n\n " + ex.Message);
                    maskedTbCNP.Clear();
                }
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
    }
}
