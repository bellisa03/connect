namespace Connect
{
    partial class HomePage
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemAccueil = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNewEnt = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNewJob = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNewEtu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFermer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEnt = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemListEnt = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNewEnt2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRechercheEnt = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNewJob2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemShowJob = new System.Windows.Forms.ToolStripMenuItem();
            this.etudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemListEtu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNewEtu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRechercheEtu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAccueil,
            this.ToolStripMenuItemEnt,
            this.etudiantToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1384, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // ToolStripMenuItemAccueil
            // 
            this.ToolStripMenuItemAccueil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNewEnt,
            this.ToolStripMenuItemNewJob,
            this.ToolStripMenuItemNewEtu,
            this.ToolStripMenuItemFermer});
            this.ToolStripMenuItemAccueil.Name = "ToolStripMenuItemAccueil";
            this.ToolStripMenuItemAccueil.Size = new System.Drawing.Size(58, 20);
            this.ToolStripMenuItemAccueil.Text = "Accueil";
            // 
            // ToolStripMenuItemNewEnt
            // 
            this.ToolStripMenuItemNewEnt.Name = "ToolStripMenuItemNewEnt";
            this.ToolStripMenuItemNewEnt.Size = new System.Drawing.Size(176, 22);
            this.ToolStripMenuItemNewEnt.Text = "Nouvelle Entreprise";
            this.ToolStripMenuItemNewEnt.Click += new System.EventHandler(this.ToolStripMenuItemNewEnt_Click);
            // 
            // ToolStripMenuItemNewJob
            // 
            this.ToolStripMenuItemNewJob.Name = "ToolStripMenuItemNewJob";
            this.ToolStripMenuItemNewJob.Size = new System.Drawing.Size(176, 22);
            this.ToolStripMenuItemNewJob.Text = "Nouveau Job";
            this.ToolStripMenuItemNewJob.Click += new System.EventHandler(this.ToolStripMenuItemNewJob_Click);
            // 
            // ToolStripMenuItemNewEtu
            // 
            this.ToolStripMenuItemNewEtu.Name = "ToolStripMenuItemNewEtu";
            this.ToolStripMenuItemNewEtu.Size = new System.Drawing.Size(176, 22);
            this.ToolStripMenuItemNewEtu.Text = "Nouvel Etudiant";
            this.ToolStripMenuItemNewEtu.Click += new System.EventHandler(this.ToolStripMenuItemNewEtu_Click);
            // 
            // ToolStripMenuItemFermer
            // 
            this.ToolStripMenuItemFermer.Name = "ToolStripMenuItemFermer";
            this.ToolStripMenuItemFermer.Size = new System.Drawing.Size(176, 22);
            this.ToolStripMenuItemFermer.Text = "Fermer Connect";
            this.ToolStripMenuItemFermer.Click += new System.EventHandler(this.fermerConnectToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemEnt
            // 
            this.ToolStripMenuItemEnt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemListEnt,
            this.ToolStripMenuItemNewEnt2,
            this.ToolStripMenuItemRechercheEnt,
            this.ToolStripMenuItemNewJob2,
            this.ToolStripMenuItemShowJob});
            this.ToolStripMenuItemEnt.Name = "ToolStripMenuItemEnt";
            this.ToolStripMenuItemEnt.Size = new System.Drawing.Size(71, 20);
            this.ToolStripMenuItemEnt.Text = "Entreprise";
            // 
            // ToolStripMenuItemListEnt
            // 
            this.ToolStripMenuItemListEnt.Name = "ToolStripMenuItemListEnt";
            this.ToolStripMenuItemListEnt.Size = new System.Drawing.Size(184, 22);
            this.ToolStripMenuItemListEnt.Text = "Afficher la liste";
            this.ToolStripMenuItemListEnt.Click += new System.EventHandler(this.ToolStripMenuItemListEnt_Click);
            // 
            // ToolStripMenuItemNewEnt2
            // 
            this.ToolStripMenuItemNewEnt2.Name = "ToolStripMenuItemNewEnt2";
            this.ToolStripMenuItemNewEnt2.Size = new System.Drawing.Size(184, 22);
            this.ToolStripMenuItemNewEnt2.Text = "Nouvelle Entreprise";
            this.ToolStripMenuItemNewEnt2.Click += new System.EventHandler(this.ToolStripMenuItemNewEnt_Click);
            // 
            // ToolStripMenuItemRechercheEnt
            // 
            this.ToolStripMenuItemRechercheEnt.Name = "ToolStripMenuItemRechercheEnt";
            this.ToolStripMenuItemRechercheEnt.Size = new System.Drawing.Size(184, 22);
            this.ToolStripMenuItemRechercheEnt.Text = "Recherche Entreprise";
            this.ToolStripMenuItemRechercheEnt.Click += new System.EventHandler(this.ToolStripMenuItemListEnt_Click);
            // 
            // ToolStripMenuItemNewJob2
            // 
            this.ToolStripMenuItemNewJob2.Name = "ToolStripMenuItemNewJob2";
            this.ToolStripMenuItemNewJob2.Size = new System.Drawing.Size(184, 22);
            this.ToolStripMenuItemNewJob2.Text = "Nouveau Job";
            this.ToolStripMenuItemNewJob2.Click += new System.EventHandler(this.ToolStripMenuItemNewJob_Click);
            // 
            // ToolStripMenuItemShowJob
            // 
            this.ToolStripMenuItemShowJob.Name = "ToolStripMenuItemShowJob";
            this.ToolStripMenuItemShowJob.Size = new System.Drawing.Size(184, 22);
            this.ToolStripMenuItemShowJob.Text = "Consulter Job";
            this.ToolStripMenuItemShowJob.Click += new System.EventHandler(this.ToolStripMenuItemShowJob_Click);
            // 
            // etudiantToolStripMenuItem
            // 
            this.etudiantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemListEtu,
            this.ToolStripMenuItemNewEtu2,
            this.ToolStripMenuItemRechercheEtu});
            this.etudiantToolStripMenuItem.Name = "etudiantToolStripMenuItem";
            this.etudiantToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.etudiantToolStripMenuItem.Text = "Etudiant";
            // 
            // ToolStripMenuItemListEtu
            // 
            this.ToolStripMenuItemListEtu.Name = "ToolStripMenuItemListEtu";
            this.ToolStripMenuItemListEtu.Size = new System.Drawing.Size(176, 22);
            this.ToolStripMenuItemListEtu.Text = "Afficher la liste";
            this.ToolStripMenuItemListEtu.Click += new System.EventHandler(this.ToolStripMenuItemListEtu_Click);
            // 
            // ToolStripMenuItemNewEtu2
            // 
            this.ToolStripMenuItemNewEtu2.Name = "ToolStripMenuItemNewEtu2";
            this.ToolStripMenuItemNewEtu2.Size = new System.Drawing.Size(176, 22);
            this.ToolStripMenuItemNewEtu2.Text = "Nouvel Etudiant";
            this.ToolStripMenuItemNewEtu2.Click += new System.EventHandler(this.ToolStripMenuItemNewEtu_Click);
            // 
            // ToolStripMenuItemRechercheEtu
            // 
            this.ToolStripMenuItemRechercheEtu.Name = "ToolStripMenuItemRechercheEtu";
            this.ToolStripMenuItemRechercheEtu.Size = new System.Drawing.Size(176, 22);
            this.ToolStripMenuItemRechercheEtu.Text = "Recherche Etudiant";
            this.ToolStripMenuItemRechercheEtu.Click += new System.EventHandler(this.ToolStripMenuItemListEtu_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 839);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1384, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "HomePage";
            this.Text = "Connect - SummerJob";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAccueil;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNewEnt;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNewJob;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNewEtu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFermer;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEnt;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemListEnt;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNewEnt2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRechercheEnt;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNewJob2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemShowJob;
        private System.Windows.Forms.ToolStripMenuItem etudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemListEtu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNewEtu2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRechercheEtu;
    }
}



