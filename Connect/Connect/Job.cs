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
    public partial class Job : Form
    {
        Connectds ds = new Connectds();
        Connectds.jobRow jobRow;
        Connectds.etudiantRow etudiantRow;
        int id = -1;

        public Job()
        {
            InitializeComponent();
            PopulateAndBind(id);
        }

        public Job(Connectds.jobRow jobRow)
        {
            InitializeComponent();
            this.id = jobRow.job_id;
            PopulateAndBind(id);

        }

        private void PopulateAndBind(int jobID)
        {

            ds = EntrepriseManager.GetDS();
            comboBoxEntreprise.DataSource = ds;
            comboBoxEntreprise.ValueMember = "entreprise.entreprise_id";
            comboBoxEntreprise.DisplayMember = "entreprise.nom_entreprise";

            if (id != -1)
            {
                jobRow = EntrepriseManager.GetJob(id);
                comboBoxEntreprise.SelectedValue = jobRow.entreprise_id;
                comboBoxEntreprise.Enabled = false;

                if (!jobRow.Isetudiant_idNull())
                {
                    etudiantRow = EtudiantManager.GetEtudiant(jobRow.etudiant_id);
                    textBoxEtudiantJob.Text = etudiantRow.etudiant_id + " - " + etudiantRow.nom_etudiant + " " + etudiantRow.prenom_etudiant;
                }
                
                textBoxJobID.Text = jobID.ToString();
                buttonValiderJob.Text = "Modifier";

            }
            else
            {
                Connectds.jobDataTable jobDT = new Connectds.jobDataTable();
                jobRow = jobDT.NewjobRow();
                             
                comboBoxEntreprise.DropDownStyle = ComboBoxStyle.DropDownList;

                jobRow.descriptif_job = string.Empty;
                jobRow.profil_job = string.Empty;
                jobRow.date_debut_job = DateTime.Now;
                jobRow.date_fin_job = DateTime.Now;
                jobRow.horaire_job = string.Empty;
                jobRow.remuneration_job = 0;
                jobRow.permis_voiture_job = false;
                jobRow.remarque_job = string.Empty;
                jobRow.date_publication_job = DateTime.Now;
                jobRow.statut_job = false;
                jobRow.etudiant_id = 1; // A MODIFIER!!!
                labelJob.Visible = false;
                textBoxJobID.Visible = false;

            }
            textBoxIntituleJob.DataBindings.Add("Text", jobRow, "titre_job");
            textBoxDescriptif.DataBindings.Add("Text", jobRow, "descriptif_job");
            textBoxProfilJob.DataBindings.Add("Text", jobRow, "profil_job");
            datePickerDebutJob.DataBindings.Add("Value", jobRow, "date_debut_job");
            datePickerFinJob.DataBindings.Add("Value", jobRow, "date_fin_job");
            textBoxHoraireJob.DataBindings.Add("Text", jobRow, "horaire_job");
            numericUpDownSalaireJob.DataBindings.Add("Value", jobRow, "remuneration_job");
            textBoxRmqJob.DataBindings.Add("Text", jobRow, "remarque_job");
            datePickerPublicationJob.DataBindings.Add("Value", jobRow, "date_publication_job");
            
            // création du binding pour le radiobutton "Oui" (permis)
            var permisJobBinding = new Binding("Checked", jobRow, "permis_voiture_job");
            // Format = lecture à partir du datasource, retourne "true" s'il lit la valeur true
            permisJobBinding.Format += (s, args) => args.Value = ((bool)args.Value) == true;
            // Parse = écriture dans le datasource, retourne la valeur true s'il lit true, sinon il retourne false
            permisJobBinding.Parse += (s, args) => args.Value = (bool)args.Value ? true : false;
            // Binding:
            radioButtonPermisOuiJob.DataBindings.Add(permisJobBinding);

            // création du binding pour le radiobutton "Non" (permis)
            var permisJobNonBinding = new Binding("Checked", jobRow, "permis_voiture_job");
            // Format = lecture à partir du datasource, retourne "true" s'il lit la valeur false
            permisJobNonBinding.Format += (s, args) => args.Value = ((bool)args.Value) == false;
            // Parse = écriture dans le datasource, retourne la valeur false s'il lit true, sinon il retourne true
            permisJobNonBinding.Parse += (s, args) => args.Value = (bool)args.Value ? false : true;
            // Binding:
            radioButtonPermisNonJob.DataBindings.Add(permisJobNonBinding);


        }

        private void buttonEffacerSelectionEtudiant_Click(object sender, EventArgs e)
        {
            textBoxEtudiantJob.Text = string.Empty;
            jobRow.statut_job = false;
            jobRow.Setetudiant_idNull();
        }

        private void buttonValiderJob_Click(object sender, EventArgs e)
        {

            if (textBoxEtudiantJob.Text != string.Empty)
            {
                jobRow.statut_job = true; //attribué
                jobRow.etudiant_id = etudiantRow.etudiant_id;
            }

            else
            {
                jobRow.Setetudiant_idNull();
                jobRow.statut_job = false;
            }
            Valider();
            refreshDataGrid();
        }

        private void Valider()
        {
            if (id == -1)
            {
                int idEntreprise;
                Int32.TryParse(comboBoxEntreprise.SelectedValue.ToString(), out idEntreprise);
                jobRow.entreprise_id = idEntreprise;
                EntrepriseManager.AddJob(jobRow);
            }
            else
            {
                EntrepriseManager.SaveJob(jobRow);
            }
        }

        /// <summary>
        /// la méthode refreshDataGrid permet de retourner sur le listing des jobs après une modification/ajout/suppression d'une entreprise,
        /// Afin d'avoir la liste du DataGridView mise à jour
        /// </summary>
        private void refreshDataGrid()
        {
            this.Close();
            ListingJobs listeJobs = new ListingJobs();
            listeJobs.MdiParent = HomePage.ActiveForm;
            listeJobs.Show();
        }


        private void buttonDeleteJob_Click(object sender, EventArgs e)
        {
            var Result = MessageBox.Show("Etes-vous sûr de vouloir supprimer le job n°" + jobRow.job_id + "?", "Veuillez confirmer:", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Result == DialogResult.OK)
            {
                EntrepriseManager.DeleteJob(jobRow.job_id);
                refreshDataGrid();
            }
        }

        private void buttonAnnulerJob_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRechercheEtudiant_Click(object sender, EventArgs e)
        {
            Valider();
            RechercheEtudiant recherche = new RechercheEtudiant(jobRow);
            recherche.MdiParent = HomePage.ActiveForm;
            recherche.Show();
            this.Close();
        }
    }
}
