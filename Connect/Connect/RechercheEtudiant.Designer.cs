namespace Connect
{
    partial class RechercheEtudiant
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
            this.dataGridViewRechercheEtudiant = new System.Windows.Forms.DataGridView();
            this.etudiantidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nometudiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenometudiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneetudiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languesetudiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainerechercheetudiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permisvoitureetudiantDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.etudiantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.connectds = new Connect.Connectds();
            this.etudiantTableAdapter = new Connect.ConnectdsTableAdapters.etudiantTableAdapter();
            this.buttonSelectionRechercheEtudiant = new System.Windows.Forms.Button();
            this.buttonFermerRechercheEtudiant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRechercheEtudiant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectds)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRechercheEtudiant
            // 
            this.dataGridViewRechercheEtudiant.AllowUserToAddRows = false;
            this.dataGridViewRechercheEtudiant.AllowUserToDeleteRows = false;
            this.dataGridViewRechercheEtudiant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRechercheEtudiant.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRechercheEtudiant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRechercheEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRechercheEtudiant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.etudiantidDataGridViewTextBoxColumn,
            this.nometudiantDataGridViewTextBoxColumn,
            this.prenometudiantDataGridViewTextBoxColumn,
            this.telephoneetudiantDataGridViewTextBoxColumn,
            this.languesetudiantDataGridViewTextBoxColumn,
            this.domainerechercheetudiantDataGridViewTextBoxColumn,
            this.permisvoitureetudiantDataGridViewCheckBoxColumn});
            this.dataGridViewRechercheEtudiant.DataSource = this.etudiantBindingSource;
            this.dataGridViewRechercheEtudiant.Location = new System.Drawing.Point(31, 31);
            this.dataGridViewRechercheEtudiant.Name = "dataGridViewRechercheEtudiant";
            this.dataGridViewRechercheEtudiant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRechercheEtudiant.Size = new System.Drawing.Size(935, 188);
            this.dataGridViewRechercheEtudiant.TabIndex = 0;
            // 
            // etudiantidDataGridViewTextBoxColumn
            // 
            this.etudiantidDataGridViewTextBoxColumn.DataPropertyName = "etudiant_id";
            this.etudiantidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.etudiantidDataGridViewTextBoxColumn.Name = "etudiantidDataGridViewTextBoxColumn";
            this.etudiantidDataGridViewTextBoxColumn.ReadOnly = true;
            this.etudiantidDataGridViewTextBoxColumn.Width = 50;
            // 
            // nometudiantDataGridViewTextBoxColumn
            // 
            this.nometudiantDataGridViewTextBoxColumn.DataPropertyName = "nom_etudiant";
            this.nometudiantDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nometudiantDataGridViewTextBoxColumn.Name = "nometudiantDataGridViewTextBoxColumn";
            this.nometudiantDataGridViewTextBoxColumn.Width = 120;
            // 
            // prenometudiantDataGridViewTextBoxColumn
            // 
            this.prenometudiantDataGridViewTextBoxColumn.DataPropertyName = "prenom_etudiant";
            this.prenometudiantDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenometudiantDataGridViewTextBoxColumn.Name = "prenometudiantDataGridViewTextBoxColumn";
            this.prenometudiantDataGridViewTextBoxColumn.Width = 120;
            // 
            // telephoneetudiantDataGridViewTextBoxColumn
            // 
            this.telephoneetudiantDataGridViewTextBoxColumn.DataPropertyName = "telephone_etudiant";
            this.telephoneetudiantDataGridViewTextBoxColumn.HeaderText = "Téléphone";
            this.telephoneetudiantDataGridViewTextBoxColumn.Name = "telephoneetudiantDataGridViewTextBoxColumn";
            // 
            // languesetudiantDataGridViewTextBoxColumn
            // 
            this.languesetudiantDataGridViewTextBoxColumn.DataPropertyName = "langues_etudiant";
            this.languesetudiantDataGridViewTextBoxColumn.HeaderText = "Langues";
            this.languesetudiantDataGridViewTextBoxColumn.Name = "languesetudiantDataGridViewTextBoxColumn";
            this.languesetudiantDataGridViewTextBoxColumn.Width = 150;
            // 
            // domainerechercheetudiantDataGridViewTextBoxColumn
            // 
            this.domainerechercheetudiantDataGridViewTextBoxColumn.DataPropertyName = "domaine_recherche_etudiant";
            this.domainerechercheetudiantDataGridViewTextBoxColumn.HeaderText = "Domaine Recherché";
            this.domainerechercheetudiantDataGridViewTextBoxColumn.Name = "domainerechercheetudiantDataGridViewTextBoxColumn";
            this.domainerechercheetudiantDataGridViewTextBoxColumn.Width = 300;
            // 
            // permisvoitureetudiantDataGridViewCheckBoxColumn
            // 
            this.permisvoitureetudiantDataGridViewCheckBoxColumn.DataPropertyName = "permis_voiture_etudiant";
            this.permisvoitureetudiantDataGridViewCheckBoxColumn.HeaderText = "Permis voiture";
            this.permisvoitureetudiantDataGridViewCheckBoxColumn.Name = "permisvoitureetudiantDataGridViewCheckBoxColumn";
            this.permisvoitureetudiantDataGridViewCheckBoxColumn.Width = 50;
            // 
            // etudiantBindingSource
            // 
            this.etudiantBindingSource.DataMember = "etudiant";
            this.etudiantBindingSource.DataSource = this.connectds;
            // 
            // connectds
            // 
            this.connectds.DataSetName = "Connectds";
            this.connectds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etudiantTableAdapter
            // 
            this.etudiantTableAdapter.ClearBeforeFill = true;
            // 
            // buttonSelectionRechercheEtudiant
            // 
            this.buttonSelectionRechercheEtudiant.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSelectionRechercheEtudiant.Location = new System.Drawing.Point(114, 263);
            this.buttonSelectionRechercheEtudiant.Name = "buttonSelectionRechercheEtudiant";
            this.buttonSelectionRechercheEtudiant.Size = new System.Drawing.Size(126, 23);
            this.buttonSelectionRechercheEtudiant.TabIndex = 1;
            this.buttonSelectionRechercheEtudiant.Text = "Sélectionner";
            this.buttonSelectionRechercheEtudiant.UseVisualStyleBackColor = true;
            this.buttonSelectionRechercheEtudiant.Click += new System.EventHandler(this.buttonSelectionRechercheEtudiant_Click);
            // 
            // buttonFermerRechercheEtudiant
            // 
            this.buttonFermerRechercheEtudiant.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonFermerRechercheEtudiant.Location = new System.Drawing.Point(784, 263);
            this.buttonFermerRechercheEtudiant.Name = "buttonFermerRechercheEtudiant";
            this.buttonFermerRechercheEtudiant.Size = new System.Drawing.Size(126, 23);
            this.buttonFermerRechercheEtudiant.TabIndex = 2;
            this.buttonFermerRechercheEtudiant.Text = "Fermer";
            this.buttonFermerRechercheEtudiant.UseVisualStyleBackColor = true;
            this.buttonFermerRechercheEtudiant.Click += new System.EventHandler(this.buttonFermerRechercheEtudiant_Click);
            // 
            // RechercheEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 327);
            this.Controls.Add(this.buttonFermerRechercheEtudiant);
            this.Controls.Add(this.buttonSelectionRechercheEtudiant);
            this.Controls.Add(this.dataGridViewRechercheEtudiant);
            this.Name = "RechercheEtudiant";
            this.Text = "Etudiant(s) Disponible(s)";
            this.Load += new System.EventHandler(this.RechercheEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRechercheEtudiant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRechercheEtudiant;
        private Connectds connectds;
        private System.Windows.Forms.BindingSource etudiantBindingSource;
        private ConnectdsTableAdapters.etudiantTableAdapter etudiantTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn etudiantidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nometudiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenometudiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneetudiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languesetudiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainerechercheetudiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn permisvoitureetudiantDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button buttonSelectionRechercheEtudiant;
        private System.Windows.Forms.Button buttonFermerRechercheEtudiant;
    }
}