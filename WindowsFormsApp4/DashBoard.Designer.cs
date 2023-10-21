
namespace WindowsFormsApp4
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.PendingAppProgress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Pendinglbl = new System.Windows.Forms.Label();
            this.Patients = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.Patientslbl = new System.Windows.Forms.Label();
            this.UsersProgress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.Userslbl = new System.Windows.Forms.Label();
            this.NextApp = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.Nextlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.PendingAppProgress.SuspendLayout();
            this.Patients.SuspendLayout();
            this.UsersProgress.SuspendLayout();
            this.NextApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1318, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "X";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp4.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(539, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1349, 155);
            this.panel1.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Teal;
            this.label15.Location = new System.Drawing.Point(542, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(195, 39);
            this.label15.TabIndex = 15;
            this.label15.Text = "Dashboard";
            // 
            // PendingAppProgress
            // 
            this.PendingAppProgress.Controls.Add(this.label1);
            this.PendingAppProgress.Controls.Add(this.Pendinglbl);
            this.PendingAppProgress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.PendingAppProgress.FillThickness = 18;
            this.PendingAppProgress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PendingAppProgress.ForeColor = System.Drawing.Color.White;
            this.PendingAppProgress.Location = new System.Drawing.Point(116, 242);
            this.PendingAppProgress.Minimum = 0;
            this.PendingAppProgress.Name = "PendingAppProgress";
            this.PendingAppProgress.ProgressColor = System.Drawing.Color.Teal;
            this.PendingAppProgress.ProgressColor2 = System.Drawing.Color.Teal;
            this.PendingAppProgress.ProgressThickness = 18;
            this.PendingAppProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PendingAppProgress.Size = new System.Drawing.Size(258, 258);
            this.PendingAppProgress.TabIndex = 16;
            this.PendingAppProgress.Text = "guna2CircleProgressBar1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(28, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 75);
            this.label1.TabIndex = 17;
            this.label1.Text = "Programari";
            // 
            // Pendinglbl
            // 
            this.Pendinglbl.AutoSize = true;
            this.Pendinglbl.Font = new System.Drawing.Font("Javanese Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pendinglbl.ForeColor = System.Drawing.Color.Teal;
            this.Pendinglbl.Location = new System.Drawing.Point(104, 131);
            this.Pendinglbl.Name = "Pendinglbl";
            this.Pendinglbl.Size = new System.Drawing.Size(58, 75);
            this.Pendinglbl.TabIndex = 16;
            this.Pendinglbl.Text = "N";
            // 
            // Patients
            // 
            this.Patients.Controls.Add(this.label2);
            this.Patients.Controls.Add(this.Patientslbl);
            this.Patients.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.Patients.FillThickness = 18;
            this.Patients.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Patients.ForeColor = System.Drawing.Color.White;
            this.Patients.Location = new System.Drawing.Point(665, 242);
            this.Patients.Minimum = 0;
            this.Patients.Name = "Patients";
            this.Patients.ProgressColor = System.Drawing.Color.Turquoise;
            this.Patients.ProgressColor2 = System.Drawing.Color.Turquoise;
            this.Patients.ProgressThickness = 18;
            this.Patients.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Patients.Size = new System.Drawing.Size(258, 258);
            this.Patients.TabIndex = 17;
            this.Patients.Text = "guna2CircleProgressBar1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Turquoise;
            this.label2.Location = new System.Drawing.Point(49, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 75);
            this.label2.TabIndex = 18;
            this.label2.Text = "Pacienti";
            // 
            // Patientslbl
            // 
            this.Patientslbl.AutoSize = true;
            this.Patientslbl.Font = new System.Drawing.Font("Javanese Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patientslbl.ForeColor = System.Drawing.Color.Teal;
            this.Patientslbl.Location = new System.Drawing.Point(102, 131);
            this.Patientslbl.Name = "Patientslbl";
            this.Patientslbl.Size = new System.Drawing.Size(58, 75);
            this.Patientslbl.TabIndex = 17;
            this.Patientslbl.Text = "N";
            // 
            // UsersProgress
            // 
            this.UsersProgress.Controls.Add(this.label5);
            this.UsersProgress.Controls.Add(this.Userslbl);
            this.UsersProgress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.UsersProgress.FillThickness = 18;
            this.UsersProgress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UsersProgress.ForeColor = System.Drawing.Color.White;
            this.UsersProgress.Location = new System.Drawing.Point(390, 486);
            this.UsersProgress.Minimum = 0;
            this.UsersProgress.Name = "UsersProgress";
            this.UsersProgress.ProgressColor = System.Drawing.Color.MediumSlateBlue;
            this.UsersProgress.ProgressColor2 = System.Drawing.Color.MediumSlateBlue;
            this.UsersProgress.ProgressThickness = 18;
            this.UsersProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.UsersProgress.Size = new System.Drawing.Size(258, 258);
            this.UsersProgress.TabIndex = 18;
            this.UsersProgress.Text = "guna2CircleProgressBar1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Javanese Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Location = new System.Drawing.Point(32, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 75);
            this.label5.TabIndex = 19;
            this.label5.Text = "Utilizatori";
            // 
            // Userslbl
            // 
            this.Userslbl.AutoSize = true;
            this.Userslbl.Font = new System.Drawing.Font("Javanese Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userslbl.ForeColor = System.Drawing.Color.Teal;
            this.Userslbl.Location = new System.Drawing.Point(101, 135);
            this.Userslbl.Name = "Userslbl";
            this.Userslbl.Size = new System.Drawing.Size(58, 75);
            this.Userslbl.TabIndex = 17;
            this.Userslbl.Text = "N";
            // 
            // NextApp
            // 
            this.NextApp.Controls.Add(this.label6);
            this.NextApp.Controls.Add(this.Nextlbl);
            this.NextApp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.NextApp.FillThickness = 18;
            this.NextApp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NextApp.ForeColor = System.Drawing.Color.White;
            this.NextApp.Location = new System.Drawing.Point(943, 486);
            this.NextApp.Minimum = 0;
            this.NextApp.Name = "NextApp";
            this.NextApp.ProgressColor = System.Drawing.Color.CornflowerBlue;
            this.NextApp.ProgressColor2 = System.Drawing.Color.CornflowerBlue;
            this.NextApp.ProgressThickness = 18;
            this.NextApp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.NextApp.Size = new System.Drawing.Size(258, 258);
            this.NextApp.TabIndex = 19;
            this.NextApp.Text = "guna2CircleProgressBar1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Javanese Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label6.Location = new System.Drawing.Point(44, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 75);
            this.label6.TabIndex = 20;
            this.label6.Text = "Urmeaza";
            // 
            // Nextlbl
            // 
            this.Nextlbl.AutoSize = true;
            this.Nextlbl.BackColor = System.Drawing.Color.Transparent;
            this.Nextlbl.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nextlbl.ForeColor = System.Drawing.Color.Teal;
            this.Nextlbl.Location = new System.Drawing.Point(18, 135);
            this.Nextlbl.Name = "Nextlbl";
            this.Nextlbl.Size = new System.Drawing.Size(50, 64);
            this.Nextlbl.TabIndex = 17;
            this.Nextlbl.Text = "N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(1207, 768);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 34);
            this.label3.TabIndex = 20;
            this.label3.Text = "Inapoi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1349, 832);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NextApp);
            this.Controls.Add(this.UsersProgress);
            this.Controls.Add(this.Patients);
            this.Controls.Add(this.PendingAppProgress);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PendingAppProgress.ResumeLayout(false);
            this.PendingAppProgress.PerformLayout();
            this.Patients.ResumeLayout(false);
            this.Patients.PerformLayout();
            this.UsersProgress.ResumeLayout(false);
            this.UsersProgress.PerformLayout();
            this.NextApp.ResumeLayout(false);
            this.NextApp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2CircleProgressBar PendingAppProgress;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Patients;
        private Guna.UI2.WinForms.Guna2CircleProgressBar UsersProgress;
        private Guna.UI2.WinForms.Guna2CircleProgressBar NextApp;
        private System.Windows.Forms.Label Pendinglbl;
        private System.Windows.Forms.Label Patientslbl;
        private System.Windows.Forms.Label Userslbl;
        private System.Windows.Forms.Label Nextlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}