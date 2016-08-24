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
    public partial class FormEntreprise : Form
    {
        //Connectds ds;
        Connectds.entrepriseRow entrepriseRow;
        int id = -1;

        /// <summary>
        /// Constructeur pour un formulaire vierge, afin de créer une nouvelle entreprise.
        /// la valeur de la variable id pour charger ce formulaire est alors à -1.
        /// </summary>
        public FormEntreprise()
        {
            InitializeComponent();
            PopulateAndBind(id);
        }

        /// <summary>
        /// Constructeur pour afficher dans le formulaire, les détails d'une entreprise existante.
        /// Utilise l'id de l'entreprise comme attribut.
        /// la valeur de la variable id pour charger ce formulaire sera alors l'id de l'entreprise.
        /// </summary>
        /// <param name="entrepriseRow"></param>
        public FormEntreprise(Connectds.entrepriseRow entrepriseRow)
        {
            InitializeComponent();
            this.id = entrepriseRow.entreprise_id;
            PopulateAndBind(id);
        }

        private void PopulateAndBind(int id)
        {
            comboBoxStatutEnt.Items.Add(Enums.Statut.Actif.ToString());
            comboBoxStatutEnt.Items.Add(Enums.Statut.Désactivé.ToString());
            comboBoxStatutEnt.SelectedIndex = comboBoxStatutEnt.Items.IndexOf(Enums.Statut.Actif.ToString());

            comboBoxTailleEnt.Items.Add("Très Petite Entreprise");
            comboBoxTailleEnt.Items.Add("Petite Entreprise");
            comboBoxTailleEnt.Items.Add("Grande Entreprise");

            datePickerCreationEnt.MinDate = DateTime.Now.AddYears(-10);
            datePickerCreationEnt.MaxDate = DateTime.Now.AddDays(1);

            if (id != -1)
            {
                buttonValiderEnt.Text = "Modifier";

                entrepriseRow = EntrepriseManager.GetEntreprise(id);

                switch (entrepriseRow.taille_entreprise)
                {
                    case "TPE":
                        comboBoxTailleEnt.Text = "Très Petite Entreprise";
                        break;
                    case "PE":
                        comboBoxTailleEnt.Text = "Petite Entreprise";
                        break;
                    case "GE":
                        comboBoxTailleEnt.Text = "Grande Entreprise";
                        break;
                    default:
                        break;
                }
                switch (entrepriseRow.statut_entreprise)
                {
                    case true:
                        comboBoxStatutEnt.Text = Enums.Statut.Actif.ToString();
                        break;
                    case false:
                        comboBoxStatutEnt.Text = Enums.Statut.Désactivé.ToString();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Connectds.entrepriseDataTable dt = new Connectds.entrepriseDataTable();
                entrepriseRow = dt.NewentrepriseRow();

                entrepriseRow.nom_entreprise = string.Empty;
                entrepriseRow.descriptif_entreprise = string.Empty;
                entrepriseRow.type_entreprise = string.Empty;
                entrepriseRow.taille_entreprise = "PE";
                entrepriseRow.statut_entreprise = true;
                entrepriseRow.date_creation_entreprise = DateTime.Now;
                datePickerCreationEnt.Value = DateTime.Now;
            }

                textBoxNomEnt.DataBindings.Add("Text", entrepriseRow, "nom_entreprise");
                textBoxAdresseEnt.DataBindings.Add("Text", entrepriseRow, "adresse_entreprise");
                textBoxContactEnt.DataBindings.Add("Text", entrepriseRow, "contact_entreprise");
                textBoxTelEnt.DataBindings.Add("Text", entrepriseRow, "telephone_entreprise");
                textBoxSecteurEnt.DataBindings.Add("Text", entrepriseRow, "secteur_entreprise");
                textBoxTypeEnt.DataBindings.Add("Text", entrepriseRow, "type_entreprise");
                textBoxDescripEnt.DataBindings.Add("Text", entrepriseRow, "descriptif_entreprise");
                datePickerCreationEnt.DataBindings.Add("Value", entrepriseRow, "date_creation_entreprise");
        }

        /// <summary>
        /// la méthode refreshDataGrid permet de retourner sur le listing des entreprises après une modification/ajout/suppression d'une entreprise,
        /// Afin d'avoir la liste du DataGridView mise à jour
        /// </summary>
        private void refreshDataGrid()
        {
            this.Close();
            ListingEntreprise listeEntreprise = new ListingEntreprise();
            listeEntreprise.MdiParent = HomePage.ActiveForm;
            listeEntreprise.Show();
        }

        private void buttonValiderEnt_Click(object sender, EventArgs e)
        {
            if(entrepriseRow.nom_entreprise != string.Empty)
            {
                entrepriseRow.statut_entreprise = EntrepriseManager.GetStatusEnt(comboBoxStatutEnt.Text);
                entrepriseRow.taille_entreprise = EntrepriseManager.GetTailleEnt(comboBoxTailleEnt.Text);
                if (id == -1)
                    EntrepriseManager.AddEntreprise(entrepriseRow);
                else
                    EntrepriseManager.SaveEntreprise(entrepriseRow);
                refreshDataGrid();
            }
            else
                MessageBox.Show("Veuillez remplir le nom de l'entreprise", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonJobsEnt_Click(object sender, EventArgs e)
        {
            ListingJobs jobs = new ListingJobs(entrepriseRow.entreprise_id);
            jobs.MdiParent = HomePage.ActiveForm;
            jobs.Show();
        }

        private void buttonDeleteEnt_Click(object sender, EventArgs e)
        {
            var Result = MessageBox.Show("Etes-vous sûr de vouloir supprimer l'entreprise n°" + entrepriseRow.entreprise_id + "?", "Veuillez confirmer:", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Result == DialogResult.OK)
            {
                // la variable checkJob va permettre de conserver l'information booléenne quant aux attributions de job de l'étudiant en dehors de la boucle foreach
                bool checkJob = false;
                Connectds.jobDataTable jobDT = EntrepriseManager.GetJobDT();
                foreach (Connectds.jobRow jobRow in jobDT)
                {
                    if (entrepriseRow.entreprise_id == jobRow.entreprise_id)
                    {
                        var Result2 = MessageBox.Show("L'entreprise n°" + entrepriseRow.entreprise_id + " a déjà publié des annonces. Vous ne pouvez la supprimer. Vous pouvez uniquement rendre son profil inactif", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        checkJob = true;
                        break;
                    }
                }
                if (!checkJob)
                {
                    EntrepriseManager.DeleteEntreprise(entrepriseRow.entreprise_id);
                    refreshDataGrid();
                }
                           
            }
        }

        private void buttonAnnulerEnt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
