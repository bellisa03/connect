namespace Connect
{
    partial class ListingJobs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxEntrepriseListingJob = new System.Windows.Forms.ComboBox();
            this.labelEntrepriseListingJob = new System.Windows.Forms.Label();
            this.dataGridViewListingJob = new System.Windows.Forms.DataGridView();
            this.buttonAfficherJob = new System.Windows.Forms.Button();
            this.buttonAjouterJob = new System.Windows.Forms.Button();
            this.buttonDeleteJob = new System.Windows.Forms.Button();
            this.buttonFermerJob = new System.Windows.Forms.Button();
            this.buttonSelectEntrepriseJob = new System.Windows.Forms.Button();
            this.connectds = new Connect.Connectds();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListingJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectds)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEntrepriseListingJob
            // 
            this.comboBoxEntrepriseListingJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEntrepriseListingJob.FormattingEnabled = true;
            this.comboBoxEntrepriseListingJob.Location = new System.Drawing.Point(94, 30);
            this.comboBoxEntrepriseListingJob.Name = "comboBoxEntrepriseListingJob";
            this.comboBoxEntrepriseListingJob.Size = new System.Drawing.Size(254, 21);
            this.comboBoxEntrepriseListingJob.TabIndex = 0;
            this.comboBoxEntrepriseListingJob.Visible = false;
            // 
            // labelEntrepriseListingJob
            // 
            this.labelEntrepriseListingJob.AutoSize = true;
            this.labelEntrepriseListingJob.Location = new System.Drawing.Point(25, 33);
            this.labelEntrepriseListingJob.Name = "labelEntrepriseListingJob";
            this.labelEntrepriseListingJob.Size = new System.Drawing.Size(54, 13);
            this.labelEntrepriseListingJob.TabIndex = 1;
            this.labelEntrepriseListingJob.Text = "Entreprise";
            this.labelEntrepriseListingJob.Visible = false;
            // 
            // dataGridViewListingJob
            // 
            this.dataGridViewListingJob.AllowUserToAddRows = false;
            this.dataGridViewListingJob.AllowUserToDeleteRows = false;
            this.dataGridViewListingJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListingJob.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListingJob.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewListingJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListingJob.Location = new System.Drawing.Point(28, 81);
            this.dataGridViewListingJob.MultiSelect = false;
            this.dataGridViewListingJob.Name = "dataGridViewListingJob";
            this.dataGridViewListingJob.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListingJob.Size = new System.Drawing.Size(869, 223);
            this.dataGridViewListingJob.TabIndex = 2;
            // 
            // buttonAfficherJob
            // 
            this.buttonAfficherJob.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAfficherJob.Location = new System.Drawing.Point(94, 336);
            this.buttonAfficherJob.Name = "buttonAfficherJob";
            this.buttonAfficherJob.Size = new System.Drawing.Size(95, 23);
            this.buttonAfficherJob.TabIndex = 3;
            this.buttonAfficherJob.Text = "Afficher";
            this.buttonAfficherJob.UseVisualStyleBackColor = true;
            this.buttonAfficherJob.Click += new System.EventHandler(this.buttonAfficherJob_Click);
            // 
            // buttonAjouterJob
            // 
            this.buttonAjouterJob.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAjouterJob.Location = new System.Drawing.Point(218, 336);
            this.buttonAjouterJob.Name = "buttonAjouterJob";
            this.buttonAjouterJob.Size = new System.Drawing.Size(95, 23);
            this.buttonAjouterJob.TabIndex = 4;
            this.buttonAjouterJob.Text = "Ajouter";
            this.buttonAjouterJob.UseVisualStyleBackColor = true;
            this.buttonAjouterJob.Click += new System.EventHandler(this.buttonAjouterJob_Click);
            // 
            // buttonDeleteJob
            // 
            this.buttonDeleteJob.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDeleteJob.Location = new System.Drawing.Point(345, 336);
            this.buttonDeleteJob.Name = "buttonDeleteJob";
            this.buttonDeleteJob.Size = new System.Drawing.Size(95, 23);
            this.buttonDeleteJob.TabIndex = 5;
            this.buttonDeleteJob.Text = "Supprimer";
            this.buttonDeleteJob.UseVisualStyleBackColor = true;
            this.buttonDeleteJob.Click += new System.EventHandler(this.buttonDeleteJob_Click);
            // 
            // buttonFermerJob
            // 
            this.buttonFermerJob.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonFermerJob.Location = new System.Drawing.Point(717, 336);
            this.buttonFermerJob.Name = "buttonFermerJob";
            this.buttonFermerJob.Size = new System.Drawing.Size(95, 23);
            this.buttonFermerJob.TabIndex = 6;
            this.buttonFermerJob.Text = "Fermer";
            this.buttonFermerJob.UseVisualStyleBackColor = true;
            this.buttonFermerJob.Click += new System.EventHandler(this.buttonFermerJob_Click);
            // 
            // buttonSelectEntrepriseJob
            // 
            this.buttonSelectEntrepriseJob.Location = new System.Drawing.Point(521, 30);
            this.buttonSelectEntrepriseJob.Name = "buttonSelectEntrepriseJob";
            this.buttonSelectEntrepriseJob.Size = new System.Drawing.Size(152, 23);
            this.buttonSelectEntrepriseJob.TabIndex = 7;
            this.buttonSelectEntrepriseJob.Text = "Sélectionner Entreprise";
            this.buttonSelectEntrepriseJob.UseVisualStyleBackColor = true;
            this.buttonSelectEntrepriseJob.Click += new System.EventHandler(this.buttonSelectEntrepriseJob_Click);
            // 
            // connectds
            // 
            this.connectds.DataSetName = "Connectds";
            this.connectds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ListingJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 397);
            this.Controls.Add(this.buttonSelectEntrepriseJob);
            this.Controls.Add(this.buttonFermerJob);
            this.Controls.Add(this.buttonDeleteJob);
            this.Controls.Add(this.buttonAjouterJob);
            this.Controls.Add(this.buttonAfficherJob);
            this.Controls.Add(this.dataGridViewListingJob);
            this.Controls.Add(this.labelEntrepriseListingJob);
            this.Controls.Add(this.comboBoxEntrepriseListingJob);
            this.Name = "ListingJobs";
            this.Text = "ListingJobs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListingJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEntrepriseListingJob;
        private System.Windows.Forms.Label labelEntrepriseListingJob;
        private System.Windows.Forms.DataGridView dataGridViewListingJob;
        private Connectds connectds;
        private System.Windows.Forms.Button buttonAfficherJob;
        private System.Windows.Forms.Button buttonAjouterJob;
        private System.Windows.Forms.Button buttonDeleteJob;
        private System.Windows.Forms.Button buttonFermerJob;
        private System.Windows.Forms.Button buttonSelectEntrepriseJob;
    }
}