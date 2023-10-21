
namespace WindowsFormsApp1
{
    partial class fisa_pac
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
            this.search_btn = new System.Windows.Forms.Button();
            this.cnptb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport11 = new WindowsFormsApp1.CrystalReport1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRENUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nASTEREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nRCONSULTATIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIAGNOSTICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDICAMENTATIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATACONSULTATIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vEDEREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new WindowsFormsApp1.DataSet2();
            this.vEDERETableAdapter = new WindowsFormsApp1.DataSet2TableAdapters.VEDERETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEDEREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(456, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 38);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fisa pacientului";
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.search_btn.Image = global::WindowsFormsApp1.Properties.Resources.search__2_;
            this.search_btn.Location = new System.Drawing.Point(665, 70);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(56, 38);
            this.search_btn.TabIndex = 18;
            this.search_btn.Text = "\r\n";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // cnptb
            // 
            this.cnptb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cnptb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cnptb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnptb.Location = new System.Drawing.Point(378, 74);
            this.cnptb.Name = "cnptb";
            this.cnptb.Size = new System.Drawing.Size(282, 30);
            this.cnptb.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cautare dupa CNP-ul pacientului:";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(53, 283);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport11;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1085, 379);
            this.crystalReportViewer1.TabIndex = 19;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNPDataGridViewTextBoxColumn,
            this.nUMEDataGridViewTextBoxColumn,
            this.pRENUMEDataGridViewTextBoxColumn,
            this.nASTEREDataGridViewTextBoxColumn,
            this.nRCONSULTATIEDataGridViewTextBoxColumn,
            this.dIAGNOSTICDataGridViewTextBoxColumn,
            this.mEDICAMENTATIEDataGridViewTextBoxColumn,
            this.dATACONSULTATIEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vEDEREBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(53, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 131);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            // 
            // nUMEDataGridViewTextBoxColumn
            // 
            this.nUMEDataGridViewTextBoxColumn.DataPropertyName = "NUME";
            this.nUMEDataGridViewTextBoxColumn.HeaderText = "NUME";
            this.nUMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nUMEDataGridViewTextBoxColumn.Name = "nUMEDataGridViewTextBoxColumn";
            // 
            // pRENUMEDataGridViewTextBoxColumn
            // 
            this.pRENUMEDataGridViewTextBoxColumn.DataPropertyName = "PRENUME";
            this.pRENUMEDataGridViewTextBoxColumn.HeaderText = "PRENUME";
            this.pRENUMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRENUMEDataGridViewTextBoxColumn.Name = "pRENUMEDataGridViewTextBoxColumn";
            // 
            // nASTEREDataGridViewTextBoxColumn
            // 
            this.nASTEREDataGridViewTextBoxColumn.DataPropertyName = "NASTERE";
            this.nASTEREDataGridViewTextBoxColumn.HeaderText = "NASTERE";
            this.nASTEREDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nASTEREDataGridViewTextBoxColumn.Name = "nASTEREDataGridViewTextBoxColumn";
            // 
            // nRCONSULTATIEDataGridViewTextBoxColumn
            // 
            this.nRCONSULTATIEDataGridViewTextBoxColumn.DataPropertyName = "NR_CONSULTATIE";
            this.nRCONSULTATIEDataGridViewTextBoxColumn.HeaderText = "NR_CONSULTATIE";
            this.nRCONSULTATIEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nRCONSULTATIEDataGridViewTextBoxColumn.Name = "nRCONSULTATIEDataGridViewTextBoxColumn";
            // 
            // dIAGNOSTICDataGridViewTextBoxColumn
            // 
            this.dIAGNOSTICDataGridViewTextBoxColumn.DataPropertyName = "DIAGNOSTIC";
            this.dIAGNOSTICDataGridViewTextBoxColumn.HeaderText = "DIAGNOSTIC";
            this.dIAGNOSTICDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIAGNOSTICDataGridViewTextBoxColumn.Name = "dIAGNOSTICDataGridViewTextBoxColumn";
            // 
            // mEDICAMENTATIEDataGridViewTextBoxColumn
            // 
            this.mEDICAMENTATIEDataGridViewTextBoxColumn.DataPropertyName = "MEDICAMENTATIE";
            this.mEDICAMENTATIEDataGridViewTextBoxColumn.HeaderText = "MEDICAMENTATIE";
            this.mEDICAMENTATIEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mEDICAMENTATIEDataGridViewTextBoxColumn.Name = "mEDICAMENTATIEDataGridViewTextBoxColumn";
            // 
            // dATACONSULTATIEDataGridViewTextBoxColumn
            // 
            this.dATACONSULTATIEDataGridViewTextBoxColumn.DataPropertyName = "DATA_CONSULTATIE";
            this.dATACONSULTATIEDataGridViewTextBoxColumn.HeaderText = "DATA_CONSULTATIE";
            this.dATACONSULTATIEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dATACONSULTATIEDataGridViewTextBoxColumn.Name = "dATACONSULTATIEDataGridViewTextBoxColumn";
            // 
            // vEDEREBindingSource
            // 
            this.vEDEREBindingSource.DataMember = "VEDERE";
            this.vEDEREBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vEDERETableAdapter
            // 
            this.vEDERETableAdapter.ClearBeforeFill = true;
            // 
            // fisa_pac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.cnptb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "fisa_pac";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.fisa_pac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEDEREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox cnptb;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalReport1 CrystalReport11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRENUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nASTEREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRCONSULTATIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIAGNOSTICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDICAMENTATIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATACONSULTATIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vEDEREBindingSource;
        private DataSet2 dataSet2;
        private DataSet2TableAdapters.VEDERETableAdapter vEDERETableAdapter;
    }
}
