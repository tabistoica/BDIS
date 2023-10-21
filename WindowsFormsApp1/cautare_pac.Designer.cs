
namespace WindowsFormsApp1
{
    partial class cautare_pac
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NR_CONSULTATIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_CONSULTATIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIAGNOSTIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDICAMENTATIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSULTATIIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.pACIENTIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pACIENTITableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.PACIENTITableAdapter();
            this.cONSULTATIITableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.CONSULTATIITableAdapter();
            this.varstatb = new System.Windows.Forms.TextBox();
            this.datantb = new System.Windows.Forms.TextBox();
            this.adresatb = new System.Windows.Forms.TextBox();
            this.prenumetb = new System.Windows.Forms.TextBox();
            this.numetb = new System.Windows.Forms.TextBox();
            this.maskedTbCNP = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTATIIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTIBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(456, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 38);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cautare pacient";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cautare dupa CNP-ul pacientului:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNPDataGridViewTextBoxColumn,
            this.NR_CONSULTATIE,
            this.DATA_CONSULTATIE,
            this.DIAGNOSTIC,
            this.MEDICAMENTATIE});
            this.dataGridView1.DataSource = this.cONSULTATIIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(56, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 280);
            this.dataGridView1.TabIndex = 16;
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NR_CONSULTATIE
            // 
            this.NR_CONSULTATIE.DataPropertyName = "NR_CONSULTATIE";
            this.NR_CONSULTATIE.HeaderText = "NR_CONSULTATIE";
            this.NR_CONSULTATIE.MinimumWidth = 10;
            this.NR_CONSULTATIE.Name = "NR_CONSULTATIE";
            this.NR_CONSULTATIE.ReadOnly = true;
            // 
            // DATA_CONSULTATIE
            // 
            this.DATA_CONSULTATIE.DataPropertyName = "DATA_CONSULTATIE";
            this.DATA_CONSULTATIE.HeaderText = "DATA_CONSULTATIE";
            this.DATA_CONSULTATIE.MinimumWidth = 10;
            this.DATA_CONSULTATIE.Name = "DATA_CONSULTATIE";
            this.DATA_CONSULTATIE.ReadOnly = true;
            // 
            // DIAGNOSTIC
            // 
            this.DIAGNOSTIC.DataPropertyName = "DIAGNOSTIC";
            this.DIAGNOSTIC.HeaderText = "DIAGNOSTIC";
            this.DIAGNOSTIC.MinimumWidth = 10;
            this.DIAGNOSTIC.Name = "DIAGNOSTIC";
            this.DIAGNOSTIC.ReadOnly = true;
            // 
            // MEDICAMENTATIE
            // 
            this.MEDICAMENTATIE.DataPropertyName = "MEDICAMENTATIE";
            this.MEDICAMENTATIE.HeaderText = "MEDICAMENTATIE";
            this.MEDICAMENTATIE.MinimumWidth = 10;
            this.MEDICAMENTATIE.Name = "MEDICAMENTATIE";
            this.MEDICAMENTATIE.ReadOnly = true;
            // 
            // cONSULTATIIBindingSource
            // 
            this.cONSULTATIIBindingSource.DataMember = "CONSULTATII";
            this.cONSULTATIIBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pACIENTIBindingSource
            // 
            this.pACIENTIBindingSource.DataMember = "PACIENTI";
            this.pACIENTIBindingSource.DataSource = this.dataSet1;
            // 
            // pACIENTITableAdapter
            // 
            this.pACIENTITableAdapter.ClearBeforeFill = true;
            // 
            // cONSULTATIITableAdapter
            // 
            this.cONSULTATIITableAdapter.ClearBeforeFill = true;
            // 
            // varstatb
            // 
            this.varstatb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.varstatb.Enabled = false;
            this.varstatb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varstatb.Location = new System.Drawing.Point(606, 285);
            this.varstatb.Name = "varstatb";
            this.varstatb.Size = new System.Drawing.Size(247, 23);
            this.varstatb.TabIndex = 38;
            // 
            // datantb
            // 
            this.datantb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datantb.Enabled = false;
            this.datantb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datantb.Location = new System.Drawing.Point(606, 228);
            this.datantb.Name = "datantb";
            this.datantb.Size = new System.Drawing.Size(247, 23);
            this.datantb.TabIndex = 37;
            // 
            // adresatb
            // 
            this.adresatb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adresatb.Enabled = false;
            this.adresatb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresatb.Location = new System.Drawing.Point(606, 169);
            this.adresatb.Name = "adresatb";
            this.adresatb.Size = new System.Drawing.Size(247, 23);
            this.adresatb.TabIndex = 36;
            // 
            // prenumetb
            // 
            this.prenumetb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prenumetb.Enabled = false;
            this.prenumetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenumetb.Location = new System.Drawing.Point(166, 283);
            this.prenumetb.Name = "prenumetb";
            this.prenumetb.Size = new System.Drawing.Size(245, 23);
            this.prenumetb.TabIndex = 35;
            // 
            // numetb
            // 
            this.numetb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numetb.Enabled = false;
            this.numetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numetb.Location = new System.Drawing.Point(166, 227);
            this.numetb.Name = "numetb";
            this.numetb.Size = new System.Drawing.Size(245, 23);
            this.numetb.TabIndex = 34;
            // 
            // maskedTbCNP
            // 
            this.maskedTbCNP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTbCNP.Enabled = false;
            this.maskedTbCNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTbCNP.Location = new System.Drawing.Point(166, 173);
            this.maskedTbCNP.Mask = "0000000000000";
            this.maskedTbCNP.Name = "maskedTbCNP";
            this.maskedTbCNP.Size = new System.Drawing.Size(245, 23);
            this.maskedTbCNP.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(472, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Adresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(472, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Varsta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Prenume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "CNP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(472, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Data nasterii";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Nume";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.cancel);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(900, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 295);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actiuni";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(49, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 43);
            this.button4.TabIndex = 14;
            this.button4.Text = "Modifica";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(49, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 43);
            this.button2.TabIndex = 12;
            this.button2.Text = "Adauga";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(49, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 43);
            this.button3.TabIndex = 13;
            this.button3.Text = "Sterge";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel.Location = new System.Drawing.Point(49, 220);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(133, 43);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Resetare";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 700);
            this.panel1.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.search__2_;
            this.pictureBox1.Location = new System.Drawing.Point(641, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(387, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 30);
            this.textBox1.TabIndex = 43;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cautare_pac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.varstatb);
            this.Controls.Add(this.datantb);
            this.Controls.Add(this.adresatb);
            this.Controls.Add(this.prenumetb);
            this.Controls.Add(this.numetb);
            this.Controls.Add(this.maskedTbCNP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "cautare_pac";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.cautare_pac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTATIIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTIBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pACIENTIBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.PACIENTITableAdapter pACIENTITableAdapter;
        private System.Windows.Forms.BindingSource cONSULTATIIBindingSource;
        private DataSet1TableAdapters.CONSULTATIITableAdapter cONSULTATIITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NR_CONSULTATIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_CONSULTATIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIAGNOSTIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDICAMENTATIE;
        private System.Windows.Forms.TextBox varstatb;
        private System.Windows.Forms.TextBox datantb;
        private System.Windows.Forms.TextBox adresatb;
        private System.Windows.Forms.TextBox prenumetb;
        private System.Windows.Forms.TextBox numetb;
        private System.Windows.Forms.MaskedTextBox maskedTbCNP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
