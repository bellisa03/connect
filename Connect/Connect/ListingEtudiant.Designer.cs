namespace Connect
{
    partial class ListingEtudiant
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonDeleteEtudiant = new System.Windows.Forms.Button();
            this.buttonListEtudiantFermer = new System.Windows.Forms.Button();
            this.buttonListEtudiantAfficher = new System.Windows.Forms.Button();
            this.dataGridViewListEtudiant = new System.Windows.Forms.DataGridView();
            this.connectds = new Connect.Connectds();
            this.etudiantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etudiantTableAdapter = new Connect.ConnectdsTableAdapters.etudiantTableAdapter();
            this.etudiantidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nometudiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenometudiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenaissanceetudiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexeetudiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneetudiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeetudesetudiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anneescolaireetudiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ecoleetudiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permisvoitureetudiantDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comboBoxListEtudiant = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListEtudiant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeleteEtudiant
            // 
            this.buttonDeleteEtudiant.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDeleteEtudiant.Location = new System.Drawing.Point(390, 397);
            this.buttonDeleteEtudiant.Name = "buttonDeleteEtudiant";
            this.buttonDeleteEtudiant.Size = new System.Drawing.Size(116, 23);
            this.buttonDeleteEtudiant.TabIndex = 9;
            this.buttonDeleteEtudiant.Text = "Supprimer";
            this.buttonDeleteEtudiant.UseVisualStyleBackColor = true;
            this.buttonDeleteEtudiant.Click += new System.EventHandler(this.buttonDeleteEtudiant_Click);
            // 
            // buttonListEtudiantFermer
            // 
            this.buttonListEtudiantFermer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonListEtudiantFermer.Location = new System.Drawing.Point(650, 397);
            this.buttonListEtudiantFermer.Name = "buttonListEtudiantFermer";
            this.buttonListEtudiantFermer.Size = new System.Drawing.Size(116, 23);
            this.buttonListEtudiantFermer.TabIndex = 8;
            this.buttonListEtudiantFermer.Text = "Fermer";
            this.buttonListEtudiantFermer.UseVisualStyleBackColor = true;
            this.buttonListEtudiantFermer.Click += new System.EventHandler(this.buttonListEtudiantFermer_Click);
            // 
            // buttonListEtudiantAfficher
            // 
            this.buttonListEtudiantAfficher.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonListEtudiantAfficher.Location = new System.Drawing.Point(122, 397);
            this.buttonListEtudiantAfficher.Name = "buttonListEtudiantAfficher";
            this.buttonListEtudiantAfficher.Size = new System.Drawing.Size(116, 23);
            this.buttonListEtudiantAfficher.TabIndex = 7;
            this.buttonListEtudiantAfficher.Text = "Profil complet";
            this.buttonListEtudiantAfficher.UseVisualStyleBackColor = true;
            this.buttonListEtudiantAfficher.Click += new System.EventHandler(this.buttonListEtudiantAfficher_Click);
            // 
            // dataGridViewListEtudiant
            // 
            this.dataGridViewListEtudiant.AllowUserToAddRows = false;
            this.dataGridViewListEtudiant.AllowUserToDeleteRows = false;
            this.dataGridViewListEtudiant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListEtudiant.AutoGenerateColumns = false;
            this.dataGridViewListEtudiant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListEtudiant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewListEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListEtudiant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.etudiantidDataGridViewTextBoxColumn,
            this.nometudiantDataGridViewTextBoxColumn,
            this.prenometudiantDataGridViewTextBoxColumn,
            this.datenaissanceetudiantDataGridViewTextBoxColumn,
            this.sexeetudiantDataGridViewTextBoxColumn,
            this.telephoneetudiantDataGridViewTextBoxColumn,
            this.typeetudesetudiantDataGridViewTextBoxColumn,
            this.anneescolaireetudiantDataGridViewTextBoxColumn,
            this.ecoleetudiantDataGridViewTextBoxColumn,
            this.permisvoitureetudiantDataGridViewCheckBoxColumn});
            this.dataGridViewListEtudiant.DataSource = this.etudiantBindingSource;
            this.dataGridViewListEtudiant.Location = new System.Drawing.Point(40, 75);
            this.dataGridViewListEtudiant.Name = "dataGridViewListEtudiant";
            this.dataGridViewListEtudiant.ReadOnly = true;
            this.dataGridViewListEtudiant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListEtudiant.Size = new System.Drawing.Size(817, 294);
            this.dataGridViewListEtudiant.TabIndex = 11;
            // 
            // connectds
            // 
            this.connectds.DataSetName = "Connectds";
            this.connectds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etudiantBindingSource
            // 
            this.etudiantBindingSource.DataMember = "etudiant";
            this.etudiantBindingSource.DataSource = this.connectds;
            // 
            // etudiantTableAdapter
            // 
            this.etudiantTableAdapter.ClearBeforeFill = true;
            // 
            // etudiantidDataGridViewTextBoxColumn
            // 
            this.etudiantidDataGridViewTextBoxColumn.DataPropertyName = "etudiant_id";
            this.etudiantidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.etudiantidDataGridViewTextBoxColumn.Name = "etudiantidDataGridViewTextBoxColumn";
            this.etudiantidDataGridViewTextBoxColumn.ReadOnly = true;
            this.etudiantidDataGridViewTextBoxColumn.Width = 45;
            // 
            // nometudiantDataGridViewTextBoxColumn
            // 
            this.nometudiantDataGridViewTextBoxColumn.DataPropertyName = "nom_etudiant";
            this.nometudiantDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nometudiantDataGridViewTextBoxColumn.Name = "nometudiantDataGridViewTextBoxColumn";
            this.nometudiantDataGridViewTextBoxColumn.ReadOnly = true;
            this.nometudiantDataGridViewTextBoxColumn.Width = 57;
            // 
            // prenometudiantDataGridViewTextBoxColumn
            // 
            this.prenometudiantDataGridViewTextBoxColumn.DataPropertyName = "prenom_etudiant";
            this.prenometudiantDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prenometudiantDataGridViewTextBoxColumn.Name = "prenometudiantDataGridViewTextBoxColumn";
            this.prenometudiantDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenometudiantDataGridViewTextBoxColumn.Width = 74;
            // 
            // datenaissanceetudiantDataGridViewTextBoxColumn
            // 
            this.datenaissanceetudiantDataGridViewTextBoxColumn.DataPropertyName = "date_naissance_etudiant";
            this.datenaissanceetudiantDataGridViewTextBoxColumn.HeaderText = "Date de naissance";
            this.datenaissanceetudiantDataGridViewTextBoxColumn.Name = "datenaissanceetudiantDataGridViewTextBoxColumn";
            this.datenaissanceetudiantDataGridViewTextBoxColumn.ReadOnly = true;
            this.datenaissanceetudiantDataGridViewTextBoxColumn.Width = 126;
            // 
            // sexeetudiantDataGridViewTextBoxColumn
            // 
            this.sexeetudiantDataGridViewTextBoxColumn.DataPropertyName = "sexe_etudiant";
            this.sexeetudiantDataGridViewTextBoxColumn.HeaderText = "Sexe";
            this.sexeetudiantDataGridViewTextBoxColumn.Name = "sexeetudiantDataGridViewTextBoxColumn";
            this.sexeetudiantDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexeetudiantDataGridViewTextBoxColumn.Width = 60;
            // 
            // telephoneetudiantDataGridViewTextBoxColumn
            // 
            this.telephoneetudiantDataGridViewTextBoxColumn.DataPropertyName = "telephone_etudiant";
            this.telephoneetudiantDataGridViewTextBoxColumn.HeaderText = "Téléphone";
            this.telephoneetudiantDataGridViewTextBoxColumn.Name = "telephoneetudiantDataGridViewTextBoxColumn";
            this.telephoneetudiantDataGridViewTextBoxColumn.ReadOnly = true;
            this.telephoneetudiantDataGridViewTextBoxColumn.Width = 92;
            // 
            // typeetudesetudiantDataGridViewTextBoxColumn
            // 
            this.typeetudesetudiantDataGridViewTextBoxColumn.DataPropertyName = "type_etudes_etudiant";
            this.typeetudesetudiantDataGridViewTextBoxColumn.HeaderText = "Etude";
            this.typeetudesetudiantDataGridViewTextBoxColumn.Name = "typeetudesetudiantDataGridViewTextBoxColumn";
            this.typeetudesetudiantDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeetudesetudiantDataGridViewTextBoxColumn.Width = 65;
            // 
            // anneescolaireetudiantDataGridViewTextBoxColumn
            // 
            this.anneescolaireetudiantDataGridViewTextBoxColumn.DataPropertyName = "annee_scolaire_etudiant";
            this.anneescolaireetudiantDataGridViewTextBoxColumn.HeaderText = "Année scolaire";
            this.anneescolaireetudiantDataGridViewTextBoxColumn.Name = "anneescolaireetudiantDataGridViewTextBoxColumn";
            this.anneescolaireetudiantDataGridViewTextBoxColumn.ReadOnly = true;
            this.anneescolaireetudiantDataGridViewTextBoxColumn.Width = 106;
            // 
            // ecoleetudiantDataGridViewTextBoxColumn
            // 
            this.ecoleetudiantDataGridViewTextBoxColumn.DataPropertyName = "ecole_etudiant";
            this.ecoleetudiantDataGridViewTextBoxColumn.HeaderText = "Ecole";
            this.ecoleetudiantDataGridViewTextBoxColumn.Name = "ecoleetudiantDataGridViewTextBoxColumn";
            this.ecoleetudiantDataGridViewTextBoxColumn.ReadOnly = true;
            this.ecoleetudiantDataGridViewTextBoxColumn.Width = 64;
            // 
            // permisvoitureetudiantDataGridViewCheckBoxColumn
            // 
            this.permisvoitureetudiantDataGridViewCheckBoxColumn.DataPropertyName = "permis_voiture_etudiant";
            this.permisvoitureetudiantDataGridViewCheckBoxColumn.HeaderText = "Permis voiture";
            this.permisvoitureetudiantDataGridViewCheckBoxColumn.Name = "permisvoitureetudiantDataGridViewCheckBoxColumn";
            this.permisvoitureetudiantDataGridViewCheckBoxColumn.ReadOnly = true;
            this.permisvoitureetudiantDataGridViewCheckBoxColumn.Width = 84;
            // 
            // comboBoxListEtudiant
            // 
            this.comboBoxListEtudiant.DataSource = this.etudiantBindingSource;
            this.comboBoxListEtudiant.DisplayMember = "etudiant_id";
            this.comboBoxListEtudiant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListEtudiant.FormattingEnabled = true;
            this.comboBoxListEtudiant.Location = new System.Drawing.Point(80, 31);
            this.comboBoxListEtudiant.Name = "comboBoxListEtudiant";
            this.comboBoxListEtudiant.Size = new System.Drawing.Size(118, 21);
            this.comboBoxListEtudiant.TabIndex = 12;
            this.comboBoxListEtudiant.ValueMember = "etudiant_id";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(50, 34);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(24, 13);
            this.labelID.TabIndex = 13;
            this.labelID.Text = "ID :";
            // 
            // ListingEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 460);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.comboBoxListEtudiant);
            this.Controls.Add(this.dataGridViewListEtudiant);
            this.Controls.Add(this.buttonDeleteEtudiant);
            this.Controls.Add(this.buttonListEtudiantFermer);
            this.Controls.Add(this.buttonListEtudiantAfficher);
            this.Name = "ListingEtudiant";
            this.Text = "Listing Etudiants";
            this.Load += new System.EventHandler(this.ListingEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListEtudiant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteEtudiant;
        private System.Windows.Forms.Button buttonListEtudiantFermer;
        private System.Windows.Forms.Button buttonListEtudiantAfficher;
        private System.Windows.Forms.DataGridView dataGridViewListEtudiant;
        private Connectds connectds;
        private System.Windows.Forms.BindingSource etudiantBindingSource;
        private ConnectdsTableAdapters.etudiantTableAdapter etudiantTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn etudiantidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nometudiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenometudiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datenaissanceetudiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexeetudiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneetudiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeetudesetudiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anneescolaireetudiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ecoleetudiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn permisvoitureetudiantDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxListEtudiant;
        private System.Windows.Forms.Label labelID;
    }
}