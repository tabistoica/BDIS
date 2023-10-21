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
    public partial class fisa_afec : UserControl
    {
        DataSet ds;
        OracleConnection conn = new OracleConnection(@"TNS_ADMIN=C:\Users\tabit\Oracle\network\admin;USER ID=STUDENT;DATA SOURCE=localhost:1521/xe;PERSIST SECURITY INFO=True;PASSWORD=student");
        OracleDataAdapter da;
        String query;

        public fisa_afec()
        {
            InitializeComponent();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                query = "SELECT * FROM vedere WHERE diagnostic=" + "'" + diagtb.Text + "'";
                da = new OracleDataAdapter(query, conn);
                ds = new DataSet();
                da.Fill(ds, "vedere");
                dataGridView1.DataSource = ds.Tables["vedere"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            CrystalReport2 raport = new CrystalReport2();
            raport.SetDataSource(ds.Tables["vedere"]);
            crystalReportViewer1.ReportSource = raport;
        }

        private void fisa_afec_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("Select diagnostic from vedere", conn);
                OracleDataReader dr;
                dr = cmd.ExecuteReader();
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

                while (dr.Read())
                {
                    collection.Add(dr["diagnostic"].ToString());
                }
                diagtb.AutoCompleteCustomSource = collection;
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
