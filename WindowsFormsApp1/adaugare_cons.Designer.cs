
namespace WindowsFormsApp1
{
    partial class adaugare_cons
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mod_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nRCONSULTATIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATACONSULTATIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIAGNOSTICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDICAMENTATIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSULTATIIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.cONSULTATIITableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.CONSULTATIITableAdapter();
            this.medi = new System.Windows.Forms.TextBox();
            this.diagnostic = new System.Windows.Forms.TextBox();
            this.nrcons = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.datactb = new System.Windows.Forms.MaskedTextBox();
            this.cnptb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTATIIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(456, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(343, 38);
            this.label7.TabIndex = 12;
            this.label7.Text = "Adaugare consultatie";
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
            this.groupBox1.TabIndex = 33;
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
            this.nRCONSULTATIEDataGridViewTextBoxColumn,
            this.dATACONSULTATIEDataGridViewTextBoxColumn,
            this.dIAGNOSTICDataGridViewTextBoxColumn,
            this.mEDICAMENTATIEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cONSULTATIIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 280);
            this.dataGridView1.TabIndex = 34;
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.FillWeight = 94.07449F;
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nRCONSULTATIEDataGridViewTextBoxColumn
            // 
            this.nRCONSULTATIEDataGridViewTextBoxColumn.DataPropertyName = "NR_CONSULTATIE";
            this.nRCONSULTATIEDataGridViewTextBoxColumn.FillWeight = 99.88876F;
            this.nRCONSULTATIEDataGridViewTextBoxColumn.HeaderText = "NR_CONSULTATIE";
            this.nRCONSULTATIEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nRCONSULTATIEDataGridViewTextBoxColumn.Name = "nRCONSULTATIEDataGridViewTextBoxColumn";
            this.nRCONSULTATIEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATACONSULTATIEDataGridViewTextBoxColumn
            // 
            this.dATACONSULTATIEDataGridViewTextBoxColumn.DataPropertyName = "DATA_CONSULTATIE";
            this.dATACONSULTATIEDataGridViewTextBoxColumn.FillWeight = 102.9521F;
            this.dATACONSULTATIEDataGridViewTextBoxColumn.HeaderText = "DATA_CONSULTATIE";
            this.dATACONSULTATIEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dATACONSULTATIEDataGridViewTextBoxColumn.Name = "dATACONSULTATIEDataGridViewTextBoxColumn";
            this.dATACONSULTATIEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIAGNOSTICDataGridViewTextBoxColumn
            // 
            this.dIAGNOSTICDataGridViewTextBoxColumn.DataPropertyName = "DIAGNOSTIC";
            this.dIAGNOSTICDataGridViewTextBoxColumn.FillWeight = 103.0846F;
            this.dIAGNOSTICDataGridViewTextBoxColumn.HeaderText = "DIAGNOSTIC";
            this.dIAGNOSTICDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIAGNOSTICDataGridViewTextBoxColumn.Name = "dIAGNOSTICDataGridViewTextBoxColumn";
            this.dIAGNOSTICDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mEDICAMENTATIEDataGridViewTextBoxColumn
            // 
            this.mEDICAMENTATIEDataGridViewTextBoxColumn.DataPropertyName = "MEDICAMENTATIE";
            this.mEDICAMENTATIEDataGridViewTextBoxColumn.HeaderText = "MEDICAMENTATIE";
            this.mEDICAMENTATIEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mEDICAMENTATIEDataGridViewTextBoxColumn.Name = "mEDICAMENTATIEDataGridViewTextBoxColumn";
            this.mEDICAMENTATIEDataGridViewTextBoxColumn.ReadOnly = true;
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
            // cONSULTATIITableAdapter
            // 
            this.cONSULTATIITableAdapter.ClearBeforeFill = true;
            // 
            // medi
            // 
            this.medi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.medi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medi.Location = new System.Drawing.Point(584, 182);
            this.medi.Multiline = true;
            this.medi.Name = "medi";
            this.medi.Size = new System.Drawing.Size(258, 82);
            this.medi.TabIndex = 69;
            // 
            // diagnostic
            // 
            this.diagnostic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diagnostic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnostic.Location = new System.Drawing.Point(504, 121);
            this.diagnostic.Name = "diagnostic";
            this.diagnostic.Size = new System.Drawing.Size(338, 23);
            this.diagnostic.TabIndex = 68;
            // 
            // nrcons
            // 
            this.nrcons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nrcons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrcons.Location = new System.Drawing.Point(186, 182);
            this.nrcons.Name = "nrcons";
            this.nrcons.Size = new System.Drawing.Size(168, 23);
            this.nrcons.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 64;
            this.label4.Text = "Diagnostic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(406, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 62;
            this.label6.Text = "Medicamentatie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 61;
            this.label3.Text = "Data consult";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 60;
            this.label2.Text = "CNP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(59, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 63;
            this.label8.Text = "Nr consult";
            // 
            // datactb
            // 
            this.datactb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datactb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datactb.Location = new System.Drawing.Point(207, 236);
            this.datactb.Mask = "00/00/0000";
            this.datactb.Name = "datactb";
            this.datactb.Size = new System.Drawing.Size(181, 23);
            this.datactb.TabIndex = 70;
            this.datactb.ValidatingType = typeof(System.DateTime);
            // 
            // cnptb
            // 
            this.cnptb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cnptb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cnptb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cnptb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnptb.Location = new System.Drawing.Point(139, 129);
            this.cnptb.Name = "cnptb";
            this.cnptb.Size = new System.Drawing.Size(168, 23);
            this.cnptb.TabIndex = 71;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 700);
            this.panel1.TabIndex = 72;
            // 
            // adaugare_cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.cnptb);
            this.Controls.Add(this.datactb);
            this.Controls.Add(this.medi);
            this.Controls.Add(this.diagnostic);
            this.Controls.Add(this.nrcons);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "adaugare_cons";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.adaugare_cons_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTATIIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button mod_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRCONSULTATIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATACONSULTATIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIAGNOSTICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDICAMENTATIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cONSULTATIIBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.CONSULTATIITableAdapter cONSULTATIITableAdapter;
        private System.Windows.Forms.TextBox medi;
        private System.Windows.Forms.TextBox diagnostic;
        private System.Windows.Forms.TextBox nrcons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox datactb;
        private System.Windows.Forms.TextBox cnptb;
        private System.Windows.Forms.Panel panel1;
    }
}
