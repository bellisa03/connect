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
        Connectds ds;
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

        /// <summary>
        /// Au chargement du formulaire, on charge les données du data set dans la variable ds, par le biais de la méthode GetEntrepriseDS()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEntreprise_Load(object sender, EventArgs e)
        {
            ds = EntrepriseManager.GetEntrepriseDS();

        }

        private void PopulateAndBind(int id)
        {
            comboBoxStatutEnt.Items.Add(Enums.Statut.Actif.ToString());
            comboBoxStatutEnt.Items.Add(Enums.Statut.Désactivé.ToString());
            comboBoxStatutEnt.Items.Add(Enums.Statut.Supprimé.ToString());

            comboBoxTailleEnt.Items.Add("Très Petite Entreprise");
            comboBoxTailleEnt.Items.Add("Petite Entreprise");
            comboBoxTailleEnt.Items.Add("Grande Entreprise");

            datePickerCreationEnt.MinDate = DateTime.Now.AddYears(-10);
            datePickerCreationEnt.MaxDate = DateTime.Now.AddDays(1);


            if (id != -1)
            {
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
                    case 1:
                        comboBoxStatutEnt.Text = Enums.Statut.Actif.ToString();
                        break;
                    case 2:
                        comboBoxStatutEnt.Text = Enums.Statut.Désactivé.ToString();
                        break;
                    case 3:
                        comboBoxStatutEnt.Text = Enums.Statut.Supprimé.ToString();
                        break;
                    default:
                        break;
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
            else
            {
                Connectds.entrepriseDataTable dt = new Connectds.entrepriseDataTable();
                entrepriseRow = dt.NewentrepriseRow();
                //entrepriseRow.date_creation_entreprise = new DateTime (DateTime.Now);
                
             }
        }

        private void buttonAnnulerEnt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonValiderEnt_Click(object sender, EventArgs e)
       {
            entrepriseRow.nom_entreprise = textBoxNomEnt.Text;
            entrepriseRow.adresse_entreprise = textBoxAdresseEnt.Text;
            entrepriseRow.contact_entreprise = textBoxContactEnt.Text;
            entrepriseRow.telephone_entreprise = textBoxTelEnt.Text;
            entrepriseRow.secteur_entreprise = textBoxSecteurEnt.Text;
            entrepriseRow.statut_entreprise = EntrepriseManager.GetStatus(comboBoxStatutEnt.Text);
            entrepriseRow.taille_entreprise = EntrepriseManager.GetTaille(comboBoxTailleEnt.Text);
            entrepriseRow.descriptif_entreprise = textBoxDescripEnt.Text;
            entrepriseRow.date_creation_entreprise = datePickerCreationEnt.Value;

            EntrepriseManager.SaveEntreprise(entrepriseRow);

            this.Close();

        }
    }
}
