
namespace WindowsFormsApp1
{
    partial class adaugare_pac
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRENUME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NASTERE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VARSTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pACIENTIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.pACIENTITableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.PACIENTITableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTbCNP = new System.Windows.Forms.MaskedTextBox();
            this.numetb = new System.Windows.Forms.TextBox();
            this.prenumetb = new System.Windows.Forms.TextBox();
            this.adresatb = new System.Windows.Forms.TextBox();
            this.varstatb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mod_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datantb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.NUME,
            this.PRENUME,
            this.ADRESA,
            this.NASTERE,
            this.VARSTA});
            this.dataGridView1.DataSource = this.pACIENTIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 337);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 55;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1112, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NUME
            // 
            this.NUME.DataPropertyName = "NUME";
            this.NUME.HeaderText = "NUME";
            this.NUME.MinimumWidth = 6;
            this.NUME.Name = "NUME";
            this.NUME.ReadOnly = true;
            // 
            // PRENUME
            // 
            this.PRENUME.DataPropertyName = "PRENUME";
            this.PRENUME.HeaderText = "PRENUME";
            this.PRENUME.MinimumWidth = 6;
            this.PRENUME.Name = "PRENUME";
            this.PRENUME.ReadOnly = true;
            // 
            // ADRESA
            // 
            this.ADRESA.DataPropertyName = "ADRESA";
            this.ADRESA.HeaderText = "ADRESA";
            this.ADRESA.MinimumWidth = 6;
            this.ADRESA.Name = "ADRESA";
            this.ADRESA.ReadOnly = true;
            // 
            // NASTERE
            // 
            this.NASTERE.DataPropertyName = "NASTERE";
            this.NASTERE.HeaderText = "DATA DE NASTERE";
            this.NASTERE.MinimumWidth = 6;
            this.NASTERE.Name = "NASTERE";
            this.NASTERE.ReadOnly = true;
            // 
            // VARSTA
            // 
            this.VARSTA.DataPropertyName = "VARSTA";
            this.VARSTA.HeaderText = "VARSTA";
            this.VARSTA.MinimumWidth = 6;
            this.VARSTA.Name = "VARSTA";
            this.VARSTA.ReadOnly = true;
            // 
            // pACIENTIBindingSource
            // 
            this.pACIENTIBindingSource.DataMember = "PACIENTI";
            this.pACIENTIBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pACIENTITableAdapter
            // 
            this.pACIENTITableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "CNP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(467, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(467, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Data nasterii";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(467, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Varsta";
            // 
            // maskedTbCNP
            // 
            this.maskedTbCNP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTbCNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTbCNP.Location = new System.Drawing.Point(161, 124);
            this.maskedTbCNP.Mask = "0000000000000";
            this.maskedTbCNP.Name = "maskedTbCNP";
            this.maskedTbCNP.Size = new System.Drawing.Size(241, 23);
            this.maskedTbCNP.TabIndex = 5;
            this.maskedTbCNP.TextChanged += new System.EventHandler(this.maskedTbCNP_TextChanged);
            this.maskedTbCNP.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTbCNP_Validating);
            // 
            // numetb
            // 
            this.numetb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numetb.Location = new System.Drawing.Point(161, 178);
            this.numetb.Name = "numetb";
            this.numetb.Size = new System.Drawing.Size(241, 23);
            this.numetb.TabIndex = 6;
            // 
            // prenumetb
            // 
            this.prenumetb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prenumetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenumetb.Location = new System.Drawing.Point(161, 234);
            this.prenumetb.Name = "prenumetb";
            this.prenumetb.Size = new System.Drawing.Size(241, 23);
            this.prenumetb.TabIndex = 7;
            // 
            // adresatb
            // 
            this.adresatb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adresatb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresatb.Location = new System.Drawing.Point(601, 120);
            this.adresatb.Name = "adresatb";
            this.adresatb.Size = new System.Drawing.Size(243, 23);
            this.adresatb.TabIndex = 8;
            // 
            // varstatb
            // 
            this.varstatb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.varstatb.Enabled = false;
            this.varstatb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varstatb.Location = new System.Drawing.Point(601, 236);
            this.varstatb.Name = "varstatb";
            this.varstatb.Size = new System.Drawing.Size(243, 23);
            this.varstatb.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(456, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 38);
            this.label7.TabIndex = 11;
            this.label7.Text = "Adaugare pacient";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mod_btn);
            this.groupBox1.Controls.Add(this.add_btn);
            this.groupBox1.Controls.Add(this.del_btn);
            this.groupBox1.Controls.Add(this.cancel_btn);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(900, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 295);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actiuni";
            // 
            // mod_btn
            // 
            this.mod_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.mod_btn.Enabled = false;
            this.mod_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mod_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mod_btn.Location = new System.Drawing.Point(49, 97);
            this.mod_btn.Name = "mod_btn";
            this.mod_btn.Size = new System.Drawing.Size(133, 43);
            this.mod_btn.TabIndex = 14;
            this.mod_btn.Text = "Modifica";
            this.mod_btn.UseVisualStyleBackColor = false;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.add_btn.Location = new System.Drawing.Point(49, 36);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(133, 43);
            this.add_btn.TabIndex = 12;
            this.add_btn.Text = "Adauga";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.Crimson;
            this.del_btn.Enabled = false;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.del_btn.Location = new System.Drawing.Point(49, 159);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(133, 43);
            this.del_btn.TabIndex = 13;
            this.del_btn.Text = "Sterge";
            this.del_btn.UseVisualStyleBackColor = false;
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel_btn.Location = new System.Drawing.Point(49, 220);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(133, 43);
            this.cancel_btn.TabIndex = 4;
            this.cancel_btn.Text = "Resetare";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datantb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 700);
            this.panel1.TabIndex = 33;
            // 
            // datantb
            // 
            this.datantb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datantb.Enabled = false;
            this.datantb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datantb.Location = new System.Drawing.Point(601, 178);
            this.datantb.Name = "datantb";
            this.datantb.Size = new System.Drawing.Size(243, 23);
            this.datantb.TabIndex = 9;
            // 
            // adaugare_pac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.varstatb);
            this.Controls.Add(this.adresatb);
            this.Controls.Add(this.prenumetb);
            this.Controls.Add(this.numetb);
            this.Controls.Add(this.maskedTbCNP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "adaugare_pac";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.adaugare_pac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pACIENTIBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.PACIENTITableAdapter pACIENTITableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTbCNP;
        private System.Windows.Forms.TextBox numetb;
        private System.Windows.Forms.TextBox prenumetb;
        private System.Windows.Forms.TextBox adresatb;
        private System.Windows.Forms.TextBox varstatb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button mod_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRENUME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADRESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NASTERE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VARSTA;
        private System.Windows.Forms.TextBox datantb;
    }
}
