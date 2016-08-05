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

        private void fermerConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItemNewEnt_Click(object sender, EventArgs e)
        {
            FormEntreprise Entreprise = new FormEntreprise();
            Entreprise.MdiParent = this;
            Entreprise.Show();
        }

        private void ToolStripMenuItemListEnt_Click(object sender, EventArgs e)
        {
            ListingEntreprise listeEntreprise = new ListingEntreprise();
            listeEntreprise.MdiParent = this;
            listeEntreprise.Show();
        }

        private void ToolStripMenuItemListEtu_Click(object sender, EventArgs e)
        {
            ListingEtudiant listeEtudiant = new ListingEtudiant();
            listeEtudiant.MdiParent = this;
            listeEtudiant.Show();
        }

        private void ToolStripMenuItemNewEtu2_Click(object sender, EventArgs e)
        {
            FormEtudiant Etudiant = new FormEtudiant();
            Etudiant.MdiParent = this;
            Etudiant.Show();
        }
    }
}
