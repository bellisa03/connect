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
    public partial class ListingJobs : Form
    {
        Connectds ds = new Connectds();
        

        public ListingJobs()
        {
            InitializeComponent();
            PopulateAndBind();
        }

        private void PopulateAndBind()
        {
            ds = EntrepriseManager.GetDS();
            labelEntrepriseListingJob.Visible = false;
            comboBoxEntrepriseListingJob.Visible = false;
            buttonSelectEntrepriseJob.Text = "Sélectionner Entreprise";

            dataGridViewListingJob.DataSource = ds;
            dataGridViewListingJob.DataMember = "job";
            dataGridViewListingJob.Columns[2].Visible = false;
            dataGridViewListingJob.Columns[3].Visible = false;
            dataGridViewListingJob.Columns[6].Visible = false;
            dataGridViewListingJob.Columns[7].Visible = false;
            dataGridViewListingJob.Columns[9].Visible = false;
            dataGridViewListingJob.Columns[11].Visible = false;
            dataGridViewListingJob.Columns[12].Visible = false;
            dataGridViewListingJob.Columns[0].HeaderText = "ID Job";
            dataGridViewListingJob.Columns[1].HeaderText = "Intitulé";
            dataGridViewListingJob.Columns[15].HeaderText = "Entreprise";
            dataGridViewListingJob.Columns[15].DisplayIndex = 2;
            dataGridViewListingJob.Columns[4].HeaderText = "Début";
            dataGridViewListingJob.Columns[5].HeaderText = "Fin";
            dataGridViewListingJob.Columns[8].HeaderText = "Permis voiture";
            dataGridViewListingJob.Columns[13].HeaderText = "ID Etudiant";
            dataGridViewListingJob.Columns[13].DisplayIndex = 11;
            dataGridViewListingJob.Columns[14].HeaderText = "Etudiant";
            dataGridViewListingJob.Columns[14].DisplayIndex = 12;
            dataGridViewListingJob.Columns[10].HeaderText = "Attribué";

        }

        
        private void buttonSelectEntrepriseJob_Click(object sender, EventArgs e)
        {
            if(buttonSelectEntrepriseJob.Text == "Sélectionner Entreprise")
            {
                labelEntrepriseListingJob.Visible = true;
                comboBoxEntrepriseListingJob.Visible = true;
                comboBoxEntrepriseListingJob.DataSource = ds;
                comboBoxEntrepriseListingJob.DisplayMember = "entreprise.nom_entreprise";
                comboBoxEntrepriseListingJob.ValueMember = "entreprise.entreprise_id";

                dataGridViewListingJob.DataSource = ds;
                dataGridViewListingJob.DataMember = "entreprise.FK_job_entreprise";

                buttonSelectEntrepriseJob.Text = "Voir tous les Jobs";
            }
            else
            {
                PopulateAndBind();
            }
            
        }

        private void buttonAfficherJob_Click(object sender, EventArgs e)
        {
            if (dataGridViewListingJob.SelectedRows.Count == 1)
            {
                int value;
                Int32.TryParse(dataGridViewListingJob.SelectedCells[0].Value.ToString(), out value);
                Connectds.jobRow jobSelectionne;
                jobSelectionne = EntrepriseManager.GetJob(value);
                Job jobDetail = new Job(jobSelectionne);
                jobDetail.MdiParent = HomePage.ActiveForm;
                jobDetail.Show();
                this.Close();
            }
        }

        private void buttonAjouterJob_Click(object sender, EventArgs e)
        {
            Job job = new Job();
            job.MdiParent = HomePage.ActiveForm;
            job.Show();
            this.Close();
        }

        private void buttonDeleteJob_Click(object sender, EventArgs e)
        {
            if (dataGridViewListingJob.SelectedRows.Count == 1)
            {
                int value;
                Int32.TryParse(dataGridViewListingJob.SelectedCells[0].Value.ToString(), out value);
                var Result = MessageBox.Show("Etes-vous sûr de vouloir supprimer le job n°" + value.ToString() + "?", "Veuillez confirmer:", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (Result == DialogResult.OK)
                {
                    EntrepriseManager.DeleteJob(value);
                    PopulateAndBind();
                }
            }
        }

        private void buttonFermerJob_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
