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
        Connectds.entrepriseRow entrepriseRow;
        int id = -1;
        int entrepriseID =-1;

        /// <summary>
        /// Constructeur pour un job vierge
        /// </summary>
        public Job()
        {
            entrepriseID = -1;
            InitializeComponent();
            PopulateAndBind(id);
        }
        /// <summary>
        /// Constructeur qui permet d'afficher les détails d'un job passé en paramètre
        /// </summary>
        /// <param name="jobRow"></param>
        public Job(Connectds.jobRow jobRow)
        {
            InitializeComponent();
            this.id = jobRow.job_id;
            PopulateAndBind(id);
        }
        /// <summary>
        /// Constructeur pour un job vierge qui prend en paramètre l'id de l'entreprise pour pouvoir afficher celle-ci directement dans le comboBox
        /// </summary>
        /// <param name="entrepriseID"></param>
        public Job(int entrepriseID)
        {
            InitializeComponent();
            this.entrepriseID = entrepriseID;
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
                if (entrepriseID != -1)
                    comboBoxEntreprise.SelectedValue = entrepriseID;

                Connectds.jobDataTable jobDT = new Connectds.jobDataTable();
                jobRow = (Connectds.jobRow)jobDT.NewjobRow();
                //Tentative de contourner les contraintes de FK not null du DataSet:
                //jobRow.Setetudiant_idNull();
                jobRow.etudiant_id = 1;
                comboBoxEntreprise.DropDownStyle = ComboBoxStyle.DropDownList;
                jobRow.titre_job = string.Empty;
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
            //jobRow.Setetudiant_idNull();
            jobRow.etudiant_id = 1;
        }

        private void buttonValiderJob_Click(object sender, EventArgs e)
        {
            if (jobRow.titre_job != string.Empty)
            {
                Valider();
                refreshDataGrid();
            }
            else
                MessageBox.Show("Veuillez remplir l'intitulé du job", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Valider()
        {
            if (jobRow.date_debut_job <= jobRow.date_fin_job)
            {
                if (textBoxEtudiantJob.Text != string.Empty)
                {
                    jobRow.statut_job = true; //attribué
                    jobRow.etudiant_id = etudiantRow.etudiant_id;
                }

                else
                    jobRow.statut_job = false;

                if (id == -1)
                {
                    int idEntreprise;
                    Int32.TryParse(comboBoxEntreprise.SelectedValue.ToString(), out idEntreprise);
                    entrepriseRow = EntrepriseManager.GetEntreprise(idEntreprise);
                    if (entrepriseRow.statut_entreprise) //si l'entreprise est active, on peut ajouter un nouveau job
                    {
                        jobRow.entreprise_id = idEntreprise;
                        EntrepriseManager.AddJob(jobRow);
                    }
                    else
                        MessageBox.Show("Le statut de l'entreprise n°" + entrepriseRow.entreprise_id + " est inactif. Vous ne pouvez pas lui créer de nouveaux jobs",
                            "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    EntrepriseManager.SaveJob(jobRow);
            }
            else
                MessageBox.Show("La date de début doit se situer avant la date de fin", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void buttonRechercheEtudiant_Click(object sender, EventArgs e)
        {
            if (jobRow.titre_job != string.Empty)
            {
                Valider();
                RechercheEtudiant recherche = new RechercheEtudiant(jobRow);
                recherche.MdiParent = HomePage.ActiveForm;
                recherche.Show();
                this.Close();
            }
            else
                MessageBox.Show("Veuillez remplir l'intitulé du job avant de consulter la liste d'étudiants", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonFermerJob_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
