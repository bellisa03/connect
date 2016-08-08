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
    public partial class Disponibilite : Form
    {
       
        Connectds.periodeDataTable periodeDT = new Connectds.periodeDataTable();
        Connectds.periodeRow periodeRow;
        Connectds.etudiantRow etudiantRow;
        int etudiantId;

        public Disponibilite(int etudiantId)
        {
            InitializeComponent();
            this.etudiantId = etudiantId;
            PopulateAndBind();
        }

        private void PopulateAndBind()
        {
            dataGridViewPeriode.DataSource = EtudiantManager.GetDisponibiliteList(etudiantId);
            textBoxIdEtudiant.Text = etudiantId.ToString();
            etudiantRow = EtudiantManager.GetEtudiant(etudiantId);
            textBoxNom.Text = etudiantRow.prenom_etudiant + " " + etudiantRow.nom_etudiant; 

        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonValiderDisponibilite_Click(object sender, EventArgs e)
        {
            periodeRow = periodeDT.NewperiodeRow();  
            periodeRow.etudiant_id = etudiantId;
            periodeRow.debut_periode = datePickerDebutPeriode.Value;
            periodeRow.fin_periode = datePickerFinPeriode.Value;

            EtudiantManager.SavePeriode(periodeRow);
        }

        private void buttonSupprimerDisponibilite_Click(object sender, EventArgs e)
        {            
            if(dataGridViewPeriode.SelectedRows.Count == 1)
            {
                int value;
                Int32.TryParse(dataGridViewPeriode.SelectedCells[0].Value.ToString(), out value);
                var Result = MessageBox.Show("Etes-vous sûr de vouloir supprimer la période n°" + value.ToString() + "?", "Veuillez confirmer:", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (Result == DialogResult.OK)
                {
                    EtudiantManager.DeletePeriode(value);
                    dataGridViewPeriode.ClearSelection();
                    PopulateAndBind();
                }
            }
            
        }
    }
}
