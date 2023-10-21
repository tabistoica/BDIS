using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Proceduri
    {
        OracleConnection conn = new OracleConnection(@"TNS_ADMIN=C:\Users\tabit\Oracle\network\admin;USER ID=STUDENT;DATA SOURCE=localhost:1521/xe;PERSIST SECURITY INFO=True;PASSWORD=student");
        OracleDataAdapter da;
        DataSet ds;
        OracleCommandBuilder comanda;
        OracleCommand cmd;
        OracleDataReader dr;

        // Afisare
        public DataSet Show(string query)
        {
            da = new OracleDataAdapter(query, conn);
            ds = new DataSet();
            da.Fill(ds);
            comanda = new OracleCommandBuilder(da);
            return ds;
        }

        //Adaugare
        public void Add(string query)
        {
            conn.Open();
            cmd = new OracleCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Stergere
        public void Delete(string query)
        {
            conn.Open();
            cmd = new OracleCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Modificare
        public void Update(string query)
        {
            conn.Open();
            cmd = new OracleCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //obtine valoarea interogarii
        public string Value(string query)
        {
            conn.Open();
            cmd = new OracleCommand(query, conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            string val = dr.GetValue(0).ToString();
            conn.Close();
            return val;
        }
    }
}
