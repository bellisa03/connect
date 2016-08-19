using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect
{
    public partial class HomePage : Form
    {
        
        public HomePage()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemNewEnt_Click(object sender, EventArgs e)
        {
            FormEntreprise entreprise = new FormEntreprise();
            entreprise.MdiParent = this;
            entreprise.Show();
        }

        private void ToolStripMenuItemListEnt_Click(object sender, EventArgs e)
        {
            ListingEntreprise listeEntreprise = new ListingEntreprise();
            listeEntreprise.MdiParent = this;
            listeEntreprise.Show();
        }

        private void ToolStripMenuItemNewEtu_Click(object sender, EventArgs e)
        {
            FormEtudiant etudiant = new FormEtudiant();
            etudiant.MdiParent = this;
            etudiant.Show();
        }

        private void ToolStripMenuItemListEtu_Click(object sender, EventArgs e)
        {
            ListingEtudiant listeEtudiant = new ListingEtudiant();
            listeEtudiant.MdiParent = this;
            listeEtudiant.Show();
        }

        private void ToolStripMenuItemNewJob_Click(object sender, EventArgs e)
        {
            Job job = new Job();
            job.MdiParent = this;
            job.Show();
        }

        private void ToolStripMenuItemShowJob_Click(object sender, EventArgs e)
        {
            ListingJobs listeJobs = new ListingJobs();
            listeJobs.MdiParent = this;
            listeJobs.Show();
        }

        private void fermerConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
