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
            if (value != -1)
            {
                FormEtudiant formEtudiant = new FormEtudiant(etudiantSelectionne);
                formEtudiant.MdiParent = this.MdiParent;
                formEtudiant.Show();
                this.Close();
            }
        }
        /// <summary>
        /// Permet la suppression d'un profil étudiant et de ses périodes de disponibilité
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteEtudiant_Click(object sender, EventArgs e)
        {
            int value;
            Int32.TryParse(comboBoxListEtudiant.SelectedValue.ToString(), out value);
            
            var Result = MessageBox.Show("Etes-vous sûr de vouloir supprimer l'étudiant n°" + value.ToString() + "?", "Veuillez confirmer:", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Result == DialogResult.OK)
            {
                List<Connectds.periodeRow> periodeList = new List<Connectds.periodeRow>();
                periodeList = EtudiantManager.GetDisponibiliteList(value);
                if (periodeList != null)
                {
                    foreach (var periode in periodeList)
                    {
                        EtudiantManager.DeletePeriode(periode.periode_id);
                    }
                }
                EtudiantManager.DeleteEtudiant(value);
                PopulateAndBind();
            }
        }

        private void buttonDisponibilite_Click(object sender, EventArgs e)
        {
            int value;
            Int32.TryParse(comboBoxListEtudiant.SelectedValue.ToString(), out value);
            this.Close();
            Disponibilite disponibilite = new Disponibilite(value);
            disponibilite.MdiParent = HomePage.ActiveForm;
            disponibilite.Show();
        }

        private void buttonListEtudiantFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
