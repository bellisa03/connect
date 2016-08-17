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
            if (etudiantId == -1)
            {
                Connectds ds = new Connectds();
                ds = EtudiantManager.GetEtudiantDS();
                etudiantRow = ds.etudiant.Last<Connectds.etudiantRow>();
                etudiantId = etudiantRow.etudiant_id;

            }
            dataGridViewPeriode.DataSource = EtudiantManager.GetDisponibiliteList(etudiantId);
            textBoxIdEtudiant.Text = etudiantId.ToString();
            etudiantRow = EtudiantManager.GetEtudiant(etudiantId);
            textBoxNom.Text = etudiantRow.prenom_etudiant + " " + etudiantRow.nom_etudiant;
        }

        private void buttonValiderDisponibilite_Click(object sender, EventArgs e)
        {
            Connectds.periodeDataTable periodeDT = new Connectds.periodeDataTable();
            periodeRow = periodeDT.NewperiodeRow();
            periodeRow.etudiant_id = etudiantId;
            periodeRow.debut_periode = datePickerDebutPeriode.Value;
            periodeRow.fin_periode = datePickerFinPeriode.Value;

            EtudiantManager.AddPeriode(periodeRow);
            PopulateAndBind();
        }

        private void buttonUpdateDisponibilite_Click(object sender, EventArgs e)
        {
            if (dataGridViewPeriode.SelectedRows.Count == 1)
            {
                int value;
                Int32.TryParse(dataGridViewPeriode.SelectedCells[0].Value.ToString(), out value);
                var Result = MessageBox.Show("Etes-vous sûr de vouloir modifier la période n°" + value.ToString() + "?", "Veuillez confirmer:", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (Result == DialogResult.OK)
                {
                    EtudiantManager.SavePeriode(periodeRow);
                    PopulateAndBind();
                }
            }
            else
            {
                var Result = MessageBox.Show("Veuillez sélectionner une ligne", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                    PopulateAndBind();
                }
            }
        }

        private void buttonFermerDisponibilite_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewPeriode_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int value;
            if (dataGridViewPeriode.SelectedRows.Count == 1)
            {
                datePickerDebutPeriode.DataBindings.Clear();
                datePickerFinPeriode.DataBindings.Clear();
                Int32.TryParse(dataGridViewPeriode.SelectedCells[0].Value.ToString(), out value);
                periodeRow = EtudiantManager.GetPeriode(value);
                datePickerDebutPeriode.DataBindings.Add("Value", periodeRow, "debut_periode");
                datePickerFinPeriode.DataBindings.Add("Value", periodeRow, "fin_periode");
            }
        }
    }
}
