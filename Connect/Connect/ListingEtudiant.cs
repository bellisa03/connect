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
    public partial class ListingEtudiant : Form
    {
        public ListingEtudiant()
        {
            InitializeComponent();
        }

        private void ListingEtudiant_Load(object sender, EventArgs e)
        {
            PopulateAndBind();    
        }

        private void PopulateAndBind()
        {
            this.etudiantTableAdapter.Fill(this.connectds.etudiant);
        }

        private void buttonListEtudiantAfficher_Click(object sender, EventArgs e)
        {
            int value;
            Connectds.etudiantRow etudiantSelectionne;
            Int32.TryParse(comboBoxListEtudiant.SelectedValue.ToString(), out value);
            etudiantSelectionne = EtudiantManager.GetEtudiant(value);
            //if (value != -1)
            //{
            //    FormEtudiant formEtudiant = new FormEtudiant(etudiantSelectionne);
            //    formEtudiant.MdiParent = this.MdiParent;
            //    formEtudiant.Show();
            //    this.Close();
            //}
        }

        private void buttonDeleteEtudiant_Click(object sender, EventArgs e)
        {
            int value;
            Int32.TryParse(comboBoxListEtudiant.SelectedValue.ToString(), out value);
            var Result = MessageBox.Show("Etes-vous sûr de vouloir supprimer l'étudiant n°" + value.ToString() + "?", "Veuillez confirmer:", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Result == DialogResult.OK)
            {
                EtudiantManager.DeleteEtudiant(value);
                PopulateAndBind();
            }
        }

        private void buttonListEtudiantFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
