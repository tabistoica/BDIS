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
    public partial class Utilizatori : Form
    {
        public Utilizatori()
        {
            InitializeComponent();
        }

        void populate()
        {
            Proceduri Pat = new Proceduri();
            string query = "select * from UserTbl";

            DataSet ds = Pat.Show(query);
            UsersDGV.DataSource = ds.Tables[0];
        }

        private void Utilizatori_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into UserTbl values('" + UnameTb.Text + "','" + PasswordTb.Text + "','" + PhoneTb.Text + "')";
            Proceduri Pat = new Proceduri();
            try
            {
                Pat.Add(query);
                MessageBox.Show("Utilizator adaugat!");
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Proceduri Pat = new Proceduri();
            if (key == 0)
            {
                MessageBox.Show("Selecteaza utilizatorul din lista!");
            }
            else
            {
                try
                {
                    string query = "Update UserTbl set Uname='" + UnameTb.Text + "',Upass='" + PasswordTb.Text + "',Phone='" + PhoneTb.Text + "' where Uid=" + key + ";";
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

        private void button2_Click(object sender, EventArgs e)
        {
            Proceduri Pat = new Proceduri();
            if (key == 0)
            {
                MessageBox.Show("Selecteaza utilizatorul din lista!");
            }
            else
            {
                try
                {
                    string query = "Delete from UserTbl where Uid=" + key + "";
                    Pat.Delete(query);
                    MessageBox.Show("Utilizatorul a fost sters din lista!");
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int key = 0;
        private void UsersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnameTb.Text = UsersDGV.SelectedRows[0].Cells[1].Value.ToString();
            PasswordTb.Text = UsersDGV.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTb.Text = UsersDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (UnameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(UsersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
