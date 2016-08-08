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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewListEntreprise = new System.Windows.Forms.DataGridView();
            this.buttonListEntrepriseAfficher = new System.Windows.Forms.Button();
            this.buttonListEntrepriseFermer = new System.Windows.Forms.Button();
            this.comboBoxListEntreprise = new System.Windows.Forms.ComboBox();
            this.buttonDeleteEnt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListEntreprise)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListEntreprise
            // 
            this.dataGridViewListEntreprise.AllowUserToAddRows = false;
            this.dataGridViewListEntreprise.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListEntreprise.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListEntreprise.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListEntreprise.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewListEntreprise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListEntreprise.Location = new System.Drawing.Point(12, 77);
            this.dataGridViewListEntreprise.MultiSelect = false;
            this.dataGridViewListEntreprise.Name = "dataGridViewListEntreprise";
            this.dataGridViewListEntreprise.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListEntreprise.Size = new System.Drawing.Size(1032, 408);
            this.dataGridViewListEntreprise.TabIndex = 0;
            // 
            // buttonListEntrepriseAfficher
            // 
            this.buttonListEntrepriseAfficher.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonListEntrepriseAfficher.Location = new System.Drawing.Point(89, 537);
            this.buttonListEntrepriseAfficher.Name = "buttonListEntrepriseAfficher";
            this.buttonListEntrepriseAfficher.Size = new System.Drawing.Size(194, 23);
            this.buttonListEntrepriseAfficher.TabIndex = 3;
            this.buttonListEntrepriseAfficher.Text = "Afficher Entreprise Sélectionnée";
            this.buttonListEntrepriseAfficher.UseVisualStyleBackColor = true;
            this.buttonListEntrepriseAfficher.Click += new System.EventHandler(this.buttonListEntrepriseAfficher_Click);
            // 
            // buttonListEntrepriseFermer
            // 
            this.buttonListEntrepriseFermer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonListEntrepriseFermer.Location = new System.Drawing.Point(797, 537);
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
            // buttonDeleteEnt
            // 
            this.buttonDeleteEnt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDeleteEnt.Location = new System.Drawing.Point(429, 537);
            this.buttonDeleteEnt.Name = "buttonDeleteEnt";
            this.buttonDeleteEnt.Size = new System.Drawing.Size(194, 23);
            this.buttonDeleteEnt.TabIndex = 6;
            this.buttonDeleteEnt.Text = "Supprimer Entreprise Sélectionnée";
            this.buttonDeleteEnt.UseVisualStyleBackColor = true;
            this.buttonDeleteEnt.Click += new System.EventHandler(this.buttonDeleteEnt_Click);
            // 
            // ListingEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 596);
            this.Controls.Add(this.buttonDeleteEnt);
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
        private System.Windows.Forms.Button buttonDeleteEnt;
    }
}