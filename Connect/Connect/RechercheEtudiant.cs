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
    public partial class RechercheEtudiant : Form
    {
        Connectds.jobRow jobRow;

        public RechercheEtudiant(Connectds.jobRow jobRow)
        {
            this.jobRow = jobRow;
            InitializeComponent();
            PopulateAndBind(jobRow.date_debut_job, jobRow.date_fin_job);
        }

        private void PopulateAndBind(DateTime debut, DateTime fin)
        {
            dataGridViewRechercheEtudiant.DataSource = EtudiantManager.GetPeriodeList(debut,fin);
        }

        private void buttonSelectionRechercheEtudiant_Click(object sender, EventArgs e)
        {
            // Petit "bricolage" qui permet d'outrepasser les protections du DataSet concernant la FK etudiant_id. Utilisation de l'ID n°1 de la table étudiant 
            // comme valeur "null"
            if (jobRow.etudiant_id == 1)
            {
                Connectds.jobDataTable dt = new Connectds.jobDataTable();
                dt = EntrepriseManager.GetJobDT();
                jobRow = dt.Last<Connectds.jobRow>();
            }

            int value;
            if (dataGridViewRechercheEtudiant.SelectedRows.Count == 1)
            {
                Int32.TryParse(dataGridViewRechercheEtudiant.SelectedCells[0].Value.ToString(), out value);
                jobRow.etudiant_id = value;
                jobRow.statut_job = true;
                EntrepriseManager.SaveJob(jobRow);
                this.Close();
                Job jobDetail = new Job(jobRow);
                jobDetail.MdiParent = HomePage.ActiveForm;
                jobDetail.Show();
            }
            else
                MessageBox.Show("Veuillez sélectionner un étudiant", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonFermerRechercheEtudiant_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
