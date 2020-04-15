namespace CSV_Einlesen
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_open_file = new System.Windows.Forms.Button();
            this.tb_filepath = new System.Windows.Forms.TextBox();
            this.lbl_filepath = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.DataGridView();
            this.import = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btn_save = new System.Windows.Forms.Button();
            this.tblProjekteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eictronic_V1_1DataSet = new CSV_Einlesen.Eictronic_V1_1DataSet();
            this.tblProjekteTableAdapter = new CSV_Einlesen.Eictronic_V1_1DataSetTableAdapters.tblProjekteTableAdapter();
            this.cmb_projekt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjekteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eictronic_V1_1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_open_file
            // 
            this.btn_open_file.Location = new System.Drawing.Point(713, 12);
            this.btn_open_file.Name = "btn_open_file";
            this.btn_open_file.Size = new System.Drawing.Size(75, 31);
            this.btn_open_file.TabIndex = 0;
            this.btn_open_file.Text = "Datei öffnen";
            this.btn_open_file.UseVisualStyleBackColor = true;
            this.btn_open_file.Click += new System.EventHandler(this.btn_open_file_Click);
            // 
            // tb_filepath
            // 
            this.tb_filepath.Location = new System.Drawing.Point(49, 18);
            this.tb_filepath.Name = "tb_filepath";
            this.tb_filepath.Size = new System.Drawing.Size(658, 20);
            this.tb_filepath.TabIndex = 1;
            // 
            // lbl_filepath
            // 
            this.lbl_filepath.AutoSize = true;
            this.lbl_filepath.Location = new System.Drawing.Point(12, 21);
            this.lbl_filepath.Name = "lbl_filepath";
            this.lbl_filepath.Size = new System.Drawing.Size(31, 13);
            this.lbl_filepath.TabIndex = 2;
            this.lbl_filepath.Text = "Input";
            // 
            // table
            // 
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.import});
            this.table.Location = new System.Drawing.Point(12, 49);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(1827, 868);
            this.table.TabIndex = 3;
            this.table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellContentClick);
            // 
            // import
            // 
            this.import.HeaderText = "import";
            this.import.Name = "import";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 929);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(794, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 31);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Hochladen";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tblProjekteBindingSource
            // 
            this.tblProjekteBindingSource.DataMember = "tblProjekte";
            this.tblProjekteBindingSource.DataSource = this.eictronic_V1_1DataSet;
            // 
            // eictronic_V1_1DataSet
            // 
            this.eictronic_V1_1DataSet.DataSetName = "Eictronic_V1_1DataSet";
            this.eictronic_V1_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProjekteTableAdapter
            // 
            this.tblProjekteTableAdapter.ClearBeforeFill = true;
            // 
            // cmb_projekt
            // 
            this.cmb_projekt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_projekt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_projekt.FormattingEnabled = true;
            this.cmb_projekt.Location = new System.Drawing.Point(925, 13);
            this.cmb_projekt.Name = "cmb_projekt";
            this.cmb_projekt.Size = new System.Drawing.Size(259, 21);
            this.cmb_projekt.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1851, 929);
            this.Controls.Add(this.cmb_projekt);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.table);
            this.Controls.Add(this.lbl_filepath);
            this.Controls.Add(this.tb_filepath);
            this.Controls.Add(this.btn_open_file);
            this.Name = "MainForm";
            this.Text = "CSV einlesen";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjekteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eictronic_V1_1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_open_file;
        private System.Windows.Forms.TextBox tb_filepath;
        private System.Windows.Forms.Label lbl_filepath;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridViewCheckBoxColumn import;
        private Eictronic_V1_1DataSet eictronic_V1_1DataSet;
        private System.Windows.Forms.BindingSource tblProjekteBindingSource;
        private Eictronic_V1_1DataSetTableAdapters.tblProjekteTableAdapter tblProjekteTableAdapter;
        private System.Windows.Forms.ComboBox cmb_projekt;
    }
}

