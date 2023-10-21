
namespace WindowsFormsApp1
{
    partial class modificare_pac
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
            this.label7 = new System.Windows.Forms.Label();
            this.varstatb = new System.Windows.Forms.TextBox();
            this.datantb = new System.Windows.Forms.TextBox();
            this.adresatb = new System.Windows.Forms.TextBox();
            this.prenumetb = new System.Windows.Forms.TextBox();
            this.numetb = new System.Windows.Forms.TextBox();
            this.maskedTbCNP = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pACIENTITableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.PACIENTITableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.pACIENTIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRENUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nASTEREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vARSTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(455, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(299, 38);
            this.label7.TabIndex = 27;
            this.label7.Text = "Modificare pacient";
            // 
            // varstatb
            // 
            this.varstatb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.varstatb.Enabled = false;
            this.varstatb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varstatb.Location = new System.Drawing.Point(594, 239);
            this.varstatb.Name = "varstatb";
            this.varstatb.Size = new System.Drawing.Size(251, 23);
            this.varstatb.TabIndex = 26;
            // 
            // datantb
            // 
            this.datantb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datantb.Enabled = false;
            this.datantb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datantb.Location = new System.Drawing.Point(594, 182);
            this.datantb.Name = "datantb";
            this.datantb.Size = new System.Drawing.Size(251, 23);
            this.datantb.TabIndex = 25;
            // 
            // adresatb
            // 
            this.adresatb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adresatb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresatb.Location = new System.Drawing.Point(594, 123);
            this.adresatb.Name = "adresatb";
            this.adresatb.Size = new System.Drawing.Size(251, 23);
            this.adresatb.TabIndex = 24;
            // 
            // prenumetb
            // 
            this.prenumetb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prenumetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenumetb.Location = new System.Drawing.Point(154, 237);
            this.prenumetb.Name = "prenumetb";
            this.prenumetb.Size = new System.Drawing.Size(249, 23);
            this.prenumetb.TabIndex = 23;
            // 
            // numetb
            // 
            this.numetb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numetb.Location = new System.Drawing.Point(154, 181);
            this.numetb.Name = "numetb";
            this.numetb.Size = new System.Drawing.Size(249, 23);
            this.numetb.TabIndex = 22;
            // 
            // maskedTbCNP
            // 
            this.maskedTbCNP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTbCNP.Enabled = false;
            this.maskedTbCNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTbCNP.Location = new System.Drawing.Point(154, 127);
            this.maskedTbCNP.Mask = "0000000000000";
            this.maskedTbCNP.Name = "maskedTbCNP";
            this.maskedTbCNP.Size = new System.Drawing.Size(249, 23);
            this.maskedTbCNP.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(460, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Adresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(460, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Varsta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Prenume";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "CNP";
            // 
            // pACIENTITableAdapter
            // 
            this.pACIENTITableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(460, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Data nasterii";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nume";
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
            this.nUMEDataGridViewTextBoxColumn,
            this.pRENUMEDataGridViewTextBoxColumn,
            this.aDRESADataGridViewTextBoxColumn,
            this.nASTEREDataGridViewTextBoxColumn,
            this.vARSTADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pACIENTIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 55;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1112, 319);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nUMEDataGridViewTextBoxColumn
            // 
            this.nUMEDataGridViewTextBoxColumn.DataPropertyName = "NUME";
            this.nUMEDataGridViewTextBoxColumn.HeaderText = "NUME";
            this.nUMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nUMEDataGridViewTextBoxColumn.Name = "nUMEDataGridViewTextBoxColumn";
            this.nUMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRENUMEDataGridViewTextBoxColumn
            // 
            this.pRENUMEDataGridViewTextBoxColumn.DataPropertyName = "PRENUME";
            this.pRENUMEDataGridViewTextBoxColumn.HeaderText = "PRENUME";
            this.pRENUMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRENUMEDataGridViewTextBoxColumn.Name = "pRENUMEDataGridViewTextBoxColumn";
            this.pRENUMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDRESADataGridViewTextBoxColumn
            // 
            this.aDRESADataGridViewTextBoxColumn.DataPropertyName = "ADRESA";
            this.aDRESADataGridViewTextBoxColumn.HeaderText = "ADRESA";
            this.aDRESADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDRESADataGridViewTextBoxColumn.Name = "aDRESADataGridViewTextBoxColumn";
            this.aDRESADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nASTEREDataGridViewTextBoxColumn
            // 
            this.nASTEREDataGridViewTextBoxColumn.DataPropertyName = "NASTERE";
            this.nASTEREDataGridViewTextBoxColumn.HeaderText = "NASTERE";
            this.nASTEREDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nASTEREDataGridViewTextBoxColumn.Name = "nASTEREDataGridViewTextBoxColumn";
            this.nASTEREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vARSTADataGridViewTextBoxColumn
            // 
            this.vARSTADataGridViewTextBoxColumn.DataPropertyName = "VARSTA";
            this.vARSTADataGridViewTextBoxColumn.HeaderText = "VARSTA";
            this.vARSTADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vARSTADataGridViewTextBoxColumn.Name = "vARSTADataGridViewTextBoxColumn";
            this.vARSTADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.update_btn);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.cancel_btn);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(900, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 295);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actiuni";
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.update_btn.Location = new System.Drawing.Point(49, 97);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(133, 43);
            this.update_btn.TabIndex = 14;
            this.update_btn.Text = "Modifica";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 700);
            this.panel1.TabIndex = 33;
            // 
            // modificare_pac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.varstatb);
            this.Controls.Add(this.datantb);
            this.Controls.Add(this.adresatb);
            this.Controls.Add(this.prenumetb);
            this.Controls.Add(this.numetb);
            this.Controls.Add(this.maskedTbCNP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "modificare_pac";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.modificare_pac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox varstatb;
        private System.Windows.Forms.TextBox datantb;
        private System.Windows.Forms.TextBox adresatb;
        private System.Windows.Forms.TextBox prenumetb;
        private System.Windows.Forms.TextBox numetb;
        private System.Windows.Forms.MaskedTextBox maskedTbCNP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DataSet1TableAdapters.PACIENTITableAdapter pACIENTITableAdapter;
        private System.Windows.Forms.Label label5;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pACIENTIBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRENUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nASTEREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vARSTADataGridViewTextBoxColumn;
    }
}
