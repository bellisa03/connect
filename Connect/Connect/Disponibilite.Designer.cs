namespace Connect
{
    partial class Disponibilite
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelIdEtudiant = new System.Windows.Forms.Label();
            this.textBoxIdEtudiant = new System.Windows.Forms.TextBox();
            this.labelDebutPeriode = new System.Windows.Forms.Label();
            this.labelFinPeriode = new System.Windows.Forms.Label();
            this.datePickerDebutPeriode = new System.Windows.Forms.DateTimePicker();
            this.datePickerFinPeriode = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewPeriode = new System.Windows.Forms.DataGridView();
            this.periodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.connectds = new Connect.Connectds();
            this.periodeTableAdapter = new Connect.ConnectdsTableAdapters.periodeTableAdapter();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.buttonValiderDisponibilite = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelEtudiant = new System.Windows.Forms.Label();
            this.buttonSupprimerDisponibilite = new System.Windows.Forms.Button();
            this.etudiantidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finperiodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debutperiodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelChamps = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeriode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectds)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIdEtudiant
            // 
            this.labelIdEtudiant.AutoSize = true;
            this.labelIdEtudiant.Location = new System.Drawing.Point(45, 44);
            this.labelIdEtudiant.Name = "labelIdEtudiant";
            this.labelIdEtudiant.Size = new System.Drawing.Size(18, 13);
            this.labelIdEtudiant.TabIndex = 0;
            this.labelIdEtudiant.Text = "ID";
            // 
            // textBoxIdEtudiant
            // 
            this.textBoxIdEtudiant.Location = new System.Drawing.Point(69, 41);
            this.textBoxIdEtudiant.Name = "textBoxIdEtudiant";
            this.textBoxIdEtudiant.ReadOnly = true;
            this.textBoxIdEtudiant.Size = new System.Drawing.Size(76, 20);
            this.textBoxIdEtudiant.TabIndex = 1;
            // 
            // labelDebutPeriode
            // 
            this.labelDebutPeriode.AutoSize = true;
            this.labelDebutPeriode.Location = new System.Drawing.Point(45, 97);
            this.labelDebutPeriode.Name = "labelDebutPeriode";
            this.labelDebutPeriode.Size = new System.Drawing.Size(104, 13);
            this.labelDebutPeriode.TabIndex = 2;
            this.labelDebutPeriode.Text = "Début de la période*";
            // 
            // labelFinPeriode
            // 
            this.labelFinPeriode.AutoSize = true;
            this.labelFinPeriode.Location = new System.Drawing.Point(45, 130);
            this.labelFinPeriode.Name = "labelFinPeriode";
            this.labelFinPeriode.Size = new System.Drawing.Size(89, 13);
            this.labelFinPeriode.TabIndex = 4;
            this.labelFinPeriode.Text = "Fin de la période*";
            // 
            // datePickerDebutPeriode
            // 
            this.datePickerDebutPeriode.Location = new System.Drawing.Point(175, 91);
            this.datePickerDebutPeriode.Name = "datePickerDebutPeriode";
            this.datePickerDebutPeriode.Size = new System.Drawing.Size(200, 20);
            this.datePickerDebutPeriode.TabIndex = 5;
            // 
            // datePickerFinPeriode
            // 
            this.datePickerFinPeriode.Location = new System.Drawing.Point(175, 124);
            this.datePickerFinPeriode.Name = "datePickerFinPeriode";
            this.datePickerFinPeriode.Size = new System.Drawing.Size(200, 20);
            this.datePickerFinPeriode.TabIndex = 6;
            // 
            // dataGridViewPeriode
            // 
            this.dataGridViewPeriode.AllowUserToAddRows = false;
            this.dataGridViewPeriode.AutoGenerateColumns = false;
            this.dataGridViewPeriode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPeriode.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPeriode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeriode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.periodeidDataGridViewTextBoxColumn,
            this.debutperiodeDataGridViewTextBoxColumn,
            this.finperiodeDataGridViewTextBoxColumn,
            this.etudiantidDataGridViewTextBoxColumn});
            this.dataGridViewPeriode.DataSource = this.periodeBindingSource;
            this.dataGridViewPeriode.Location = new System.Drawing.Point(48, 203);
            this.dataGridViewPeriode.MultiSelect = false;
            this.dataGridViewPeriode.Name = "dataGridViewPeriode";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPeriode.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPeriode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPeriode.Size = new System.Drawing.Size(370, 150);
            this.dataGridViewPeriode.TabIndex = 7;
            // 
            // periodeBindingSource
            // 
            this.periodeBindingSource.DataMember = "periode";
            this.periodeBindingSource.DataSource = this.connectds;
            // 
            // connectds
            // 
            this.connectds.DataSetName = "Connectds";
            this.connectds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // periodeTableAdapter
            // 
            this.periodeTableAdapter.ClearBeforeFill = true;
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(343, 379);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(75, 23);
            this.buttonFermer.TabIndex = 8;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // buttonValiderDisponibilite
            // 
            this.buttonValiderDisponibilite.Location = new System.Drawing.Point(158, 163);
            this.buttonValiderDisponibilite.Name = "buttonValiderDisponibilite";
            this.buttonValiderDisponibilite.Size = new System.Drawing.Size(138, 23);
            this.buttonValiderDisponibilite.TabIndex = 9;
            this.buttonValiderDisponibilite.Text = "Ajouter disponibilité";
            this.buttonValiderDisponibilite.UseVisualStyleBackColor = true;
            this.buttonValiderDisponibilite.Click += new System.EventHandler(this.buttonValiderDisponibilite_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(245, 41);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.ReadOnly = true;
            this.textBoxNom.Size = new System.Drawing.Size(173, 20);
            this.textBoxNom.TabIndex = 13;
            // 
            // labelEtudiant
            // 
            this.labelEtudiant.AutoSize = true;
            this.labelEtudiant.Location = new System.Drawing.Point(193, 44);
            this.labelEtudiant.Name = "labelEtudiant";
            this.labelEtudiant.Size = new System.Drawing.Size(46, 13);
            this.labelEtudiant.TabIndex = 12;
            this.labelEtudiant.Text = "Etudiant";
            // 
            // buttonSupprimerDisponibilite
            // 
            this.buttonSupprimerDisponibilite.Location = new System.Drawing.Point(48, 379);
            this.buttonSupprimerDisponibilite.Name = "buttonSupprimerDisponibilite";
            this.buttonSupprimerDisponibilite.Size = new System.Drawing.Size(200, 23);
            this.buttonSupprimerDisponibilite.TabIndex = 14;
            this.buttonSupprimerDisponibilite.Text = "Supprimer disponibilité sélectionnée";
            this.buttonSupprimerDisponibilite.UseVisualStyleBackColor = true;
            this.buttonSupprimerDisponibilite.Click += new System.EventHandler(this.buttonSupprimerDisponibilite_Click);
            // 
            // etudiantidDataGridViewTextBoxColumn
            // 
            this.etudiantidDataGridViewTextBoxColumn.DataPropertyName = "etudiant_id";
            this.etudiantidDataGridViewTextBoxColumn.HeaderText = "etudiant_id";
            this.etudiantidDataGridViewTextBoxColumn.Name = "etudiantidDataGridViewTextBoxColumn";
            this.etudiantidDataGridViewTextBoxColumn.Visible = false;
            // 
            // finperiodeDataGridViewTextBoxColumn
            // 
            this.finperiodeDataGridViewTextBoxColumn.DataPropertyName = "fin_periode";
            this.finperiodeDataGridViewTextBoxColumn.HeaderText = "Fin";
            this.finperiodeDataGridViewTextBoxColumn.Name = "finperiodeDataGridViewTextBoxColumn";
            // 
            // debutperiodeDataGridViewTextBoxColumn
            // 
            this.debutperiodeDataGridViewTextBoxColumn.DataPropertyName = "debut_periode";
            this.debutperiodeDataGridViewTextBoxColumn.HeaderText = "Début";
            this.debutperiodeDataGridViewTextBoxColumn.Name = "debutperiodeDataGridViewTextBoxColumn";
            // 
            // periodeidDataGridViewTextBoxColumn
            // 
            this.periodeidDataGridViewTextBoxColumn.DataPropertyName = "periode_id";
            this.periodeidDataGridViewTextBoxColumn.HeaderText = "Période";
            this.periodeidDataGridViewTextBoxColumn.Name = "periodeidDataGridViewTextBoxColumn";
            this.periodeidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // labelChamps
            // 
            this.labelChamps.AutoSize = true;
            this.labelChamps.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChamps.Location = new System.Drawing.Point(45, 414);
            this.labelChamps.Name = "labelChamps";
            this.labelChamps.Size = new System.Drawing.Size(105, 13);
            this.labelChamps.TabIndex = 29;
            this.labelChamps.Text = "*Champs obligatoires";
            // 
            // Disponibilite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 436);
            this.Controls.Add(this.labelChamps);
            this.Controls.Add(this.buttonSupprimerDisponibilite);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelEtudiant);
            this.Controls.Add(this.buttonValiderDisponibilite);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.dataGridViewPeriode);
            this.Controls.Add(this.datePickerFinPeriode);
            this.Controls.Add(this.datePickerDebutPeriode);
            this.Controls.Add(this.labelFinPeriode);
            this.Controls.Add(this.labelDebutPeriode);
            this.Controls.Add(this.textBoxIdEtudiant);
            this.Controls.Add(this.labelIdEtudiant);
            this.Name = "Disponibilite";
            this.Text = "Disponibilité Etudiant";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeriode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdEtudiant;
        private System.Windows.Forms.TextBox textBoxIdEtudiant;
        private System.Windows.Forms.Label labelDebutPeriode;
        private System.Windows.Forms.Label labelFinPeriode;
        private System.Windows.Forms.DateTimePicker datePickerDebutPeriode;
        private System.Windows.Forms.DateTimePicker datePickerFinPeriode;
        private System.Windows.Forms.DataGridView dataGridViewPeriode;
        private Connectds connectds;
        private System.Windows.Forms.BindingSource periodeBindingSource;
        private ConnectdsTableAdapters.periodeTableAdapter periodeTableAdapter;
        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Button buttonValiderDisponibilite;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelEtudiant;
        private System.Windows.Forms.Button buttonSupprimerDisponibilite;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debutperiodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finperiodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etudiantidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelChamps;
    }
}