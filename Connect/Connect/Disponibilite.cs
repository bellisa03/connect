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
            //Si l'étudiant est nouvellement créé, cette condition permet de récupérer son id.
            //Sinon, l'id passée en paramètre avec le constructeur est à -1
            if (etudiantId == -1)
            {
                Connectds.etudiantDataTable dt = new Connectds.etudiantDataTable();
                dt = EtudiantManager.GetEtudiantDT();
                etudiantRow = dt.Last<Connectds.etudiantRow>();
                etudiantId = etudiantRow.etudiant_id;

            }
            dataGridViewPeriode.DataSource = EtudiantManager.GetPeriodeList(etudiantId);
            textBoxIdEtudiant.Text = etudiantId.ToString();
            etudiantRow = EtudiantManager.GetEtudiant(etudiantId);
            textBoxNom.Text = etudiantRow.prenom_etudiant + " " + etudiantRow.nom_etudiant;
        }

        /// <summary>
        /// Rafraichit le binding entre le dataGridViewPeriode et les date pickers, ce qui permet d'utiliser ces derniers pour modifier une période
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void buttonValiderDisponibilite_Click(object sender, EventArgs e)
        {
            Connectds.periodeDataTable periodeDT = new Connectds.periodeDataTable();
            periodeRow = periodeDT.NewperiodeRow();
            periodeRow.etudiant_id = etudiantId;
            periodeRow.debut_periode = datePickerDebutPeriode.Value;
            periodeRow.fin_periode = datePickerFinPeriode.Value;

            if(periodeRow.debut_periode <= periodeRow.fin_periode)
            {
                EtudiantManager.AddPeriode(periodeRow);
                PopulateAndBind();
            }
            else
            {
                MessageBox.Show("La date de début de période doit se situer avant la date de fin de période", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonUpdateDisponibilite_Click(object sender, EventArgs e)
        {
            if (periodeRow!= null)
            {
                if (periodeRow.debut_periode <= periodeRow.fin_periode)
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
                    MessageBox.Show("La date de début de période doit se situer avant la date de fin de période", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    dataGridViewPeriode.Refresh();
                    PopulateAndBind();
                }
            }
        }

        private void buttonFermerDisponibilite_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
