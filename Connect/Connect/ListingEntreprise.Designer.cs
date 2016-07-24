namespace Connect
{
    partial class ListingEntreprise
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
            this.dataGridViewListEntreprise = new System.Windows.Forms.DataGridView();
            this.buttonListEntrepriseAfficher = new System.Windows.Forms.Button();
            this.buttonListEntrepriseFermer = new System.Windows.Forms.Button();
            this.comboBoxListEntreprise = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListEntreprise)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListEntreprise
            // 
            this.dataGridViewListEntreprise.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListEntreprise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListEntreprise.Location = new System.Drawing.Point(12, 77);
            this.dataGridViewListEntreprise.Name = "dataGridViewListEntreprise";
            this.dataGridViewListEntreprise.Size = new System.Drawing.Size(626, 150);
            this.dataGridViewListEntreprise.TabIndex = 0;
            // 
            // buttonListEntrepriseAfficher
            // 
            this.buttonListEntrepriseAfficher.Location = new System.Drawing.Point(72, 277);
            this.buttonListEntrepriseAfficher.Name = "buttonListEntrepriseAfficher";
            this.buttonListEntrepriseAfficher.Size = new System.Drawing.Size(194, 23);
            this.buttonListEntrepriseAfficher.TabIndex = 3;
            this.buttonListEntrepriseAfficher.Text = "Afficher Entreprise Sélectionnée";
            this.buttonListEntrepriseAfficher.UseVisualStyleBackColor = true;
            this.buttonListEntrepriseAfficher.Click += new System.EventHandler(this.buttonListEntrepriseAfficher_Click);
            // 
            // buttonListEntrepriseFermer
            // 
            this.buttonListEntrepriseFermer.Location = new System.Drawing.Point(388, 277);
            this.buttonListEntrepriseFermer.Name = "buttonListEntrepriseFermer";
            this.buttonListEntrepriseFermer.Size = new System.Drawing.Size(75, 23);
            this.buttonListEntrepriseFermer.TabIndex = 4;
            this.buttonListEntrepriseFermer.Text = "Fermer";
            this.buttonListEntrepriseFermer.UseVisualStyleBackColor = true;
            this.buttonListEntrepriseFermer.Click += new System.EventHandler(this.buttonListEntrepriseFermer_Click);
            // 
            // comboBoxListEntreprise
            // 
            this.comboBoxListEntreprise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListEntreprise.FormattingEnabled = true;
            this.comboBoxListEntreprise.Location = new System.Drawing.Point(12, 34);
            this.comboBoxListEntreprise.Name = "comboBoxListEntreprise";
            this.comboBoxListEntreprise.Size = new System.Drawing.Size(254, 21);
            this.comboBoxListEntreprise.TabIndex = 5;
            // 
            // ListingEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 338);
            this.Controls.Add(this.comboBoxListEntreprise);
            this.Controls.Add(this.buttonListEntrepriseFermer);
            this.Controls.Add(this.buttonListEntrepriseAfficher);
            this.Controls.Add(this.dataGridViewListEntreprise);
            this.Name = "ListingEntreprise";
            this.Text = "Listing Entreprises";
            this.Load += new System.EventHandler(this.ListingEntreprise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListEntreprise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListEntreprise;
        private System.Windows.Forms.Button buttonListEntrepriseAfficher;
        private System.Windows.Forms.Button buttonListEntrepriseFermer;
        private System.Windows.Forms.ComboBox comboBoxListEntreprise;
    }
}