using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            adaugare_pac add = new adaugare_pac();
            addUserControl(add);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            button2.Visible = false;
            button4.Location = button2.Location;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            button4.Visible = false;
            button2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            adaugare_pac add = new adaugare_pac();
            addUserControl(add);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            modificare_pac mod = new modificare_pac();
            addUserControl(mod);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            stergere_pac sterg = new stergere_pac();
            addUserControl(sterg);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            cautare_pac caut = new cautare_pac();
            addUserControl(caut);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            adaugare_cons add = new adaugare_cons();
            addUserControl(add);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            modificare_cons mod = new modificare_cons();
            addUserControl(mod);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            stergere_cons sterg = new stergere_cons();
            addUserControl(sterg);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            fisa_pac pac = new fisa_pac();
            addUserControl(pac);
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            fisa_afec afec = new fisa_afec();
            addUserControl(afec);
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
