
namespace WindowsFormsApp1
{
    partial class fisa_afec
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
            this.diagtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet2 = new WindowsFormsApp1.DataSet2();
            this.vEDEREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEDERETableAdapter = new WindowsFormsApp1.DataSet2TableAdapters.VEDERETableAdapter();
            this.dIAGNOSTICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRENUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrystalReport21 = new WindowsFormsApp1.CrystalReport2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEDEREBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(456, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 38);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fisa afectiunii";
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.search_btn.Image = global::WindowsFormsApp1.Properties.Resources.search__2_;
            this.search_btn.Location = new System.Drawing.Point(683, 70);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(56, 38);
            this.search_btn.TabIndex = 18;
            this.search_btn.Text = "\r\n";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // diagtb
            // 
            this.diagtb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.diagtb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.diagtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagtb.Location = new System.Drawing.Point(396, 74);
            this.diagtb.Name = "diagtb";
            this.diagtb.Size = new System.Drawing.Size(282, 30);
            this.diagtb.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cautare dupa denumirea afectiunii:";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(53, 277);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport21;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1085, 385);
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
            this.dIAGNOSTICDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.nUMEDataGridViewTextBoxColumn,
            this.pRENUMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vEDEREBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(53, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 131);
            this.dataGridView1.TabIndex = 21;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vEDEREBindingSource
            // 
            this.vEDEREBindingSource.DataMember = "VEDERE";
            this.vEDEREBindingSource.DataSource = this.dataSet2;
            // 
            // vEDERETableAdapter
            // 
            this.vEDERETableAdapter.ClearBeforeFill = true;
            // 
            // dIAGNOSTICDataGridViewTextBoxColumn
            // 
            this.dIAGNOSTICDataGridViewTextBoxColumn.DataPropertyName = "DIAGNOSTIC";
            this.dIAGNOSTICDataGridViewTextBoxColumn.HeaderText = "DIAGNOSTIC";
            this.dIAGNOSTICDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIAGNOSTICDataGridViewTextBoxColumn.Name = "dIAGNOSTICDataGridViewTextBoxColumn";
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
            // fisa_afec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.diagtb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "fisa_afec";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.fisa_afec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEDEREBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox diagtb;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CrystalReport2 CrystalReport21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIAGNOSTICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRENUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vEDEREBindingSource;
        private DataSet2 dataSet2;
        private DataSet2TableAdapters.VEDERETableAdapter vEDERETableAdapter;
    }
}
