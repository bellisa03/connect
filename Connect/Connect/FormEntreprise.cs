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
        

        public FormEntreprise()
        {
            InitializeComponent();
            
            PopulateAndBind(id);    
        }

        public FormEntreprise(Connectds.entrepriseRow entrepriseRow)
        {
            InitializeComponent();
            this.id = entrepriseRow.entreprise_id;
            PopulateAndBind(id);

        }

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

            if (id != -1)
            {
                entrepriseRow = EntrepriseManager.GetEntreprise(id);

                switch (entrepriseRow.taille_entreprise)
                {
                    case "TPE":
                        comboBoxTailleEnt.Text = "très petite entreprise";
                        break;
                    case "PE":
                        comboBoxTailleEnt.Text = "petite entreprise";
                        break;
                    case "GE":
                        comboBoxTailleEnt.Text = "grande entreprise";
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

            }
            else
            {
                Connectds.entrepriseDataTable dt = new Connectds.entrepriseDataTable();
                entrepriseRow = dt.NewentrepriseRow();
                entrepriseRow.statut_entreprise = (int)Enums.Statut.Actif;
                entrepriseRow.type_entreprise = "TPE";
                entrepriseRow.descriptif_entreprise = string.Empty;
                entrepriseRow.date_creation_entreprise = DateTime.Now;
             }

            textBoxNomEnt.DataBindings.Add("Text", entrepriseRow, "nom_entreprise");
                textBoxAdresseEnt.DataBindings.Add("Text", entrepriseRow, "adresse_entreprise");
                textBoxContactEnt.DataBindings.Add("Text", entrepriseRow, "contact_entreprise");
                textBoxTelEnt.DataBindings.Add("Text", entrepriseRow, "telephone_entreprise");
                textBoxSecteurEnt.DataBindings.Add("Text", entrepriseRow, "secteur_entreprise");
                textBoxTypeEnt.DataBindings.Add("Text", entrepriseRow, "type_entreprise");
                textBoxDescripEnt.DataBindings.Add("Text", entrepriseRow, "descriptif_entreprise");


            //datePickerCreationEnt.MinDate = DateTime.Now.AddYears(-10);
            datePickerCreationEnt.MaxDate = DateTime.Now.AddDays(1);
            datePickerCreationEnt.DataBindings.Add("Value", entrepriseRow, "date_creation_entreprise");

        }

        private void buttonAnnulerEnt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonValiderEnt_Click(object sender, EventArgs e)
       {
            //DataRow entrepriseDR = ds.Tables["entreprise"].NewRow();

            //entrepriseDR["nom_entreprise"] = textBoxNomEnt.Text;
            //entrepriseDR["adresse_entreprise"] = textBoxAdresseEnt.Text;
            //entrepriseDR["contact_entreprise"] = textBoxContactEnt.Text;
            //entrepriseDR["telephone_entreprise"] = textBoxTelEnt.Text;
            //entrepriseDR["secteur_entreprise"] = textBoxSecteurEnt.Text;
            //entrepriseDR["type_entreprise"] = textBoxTypeEnt.Text;
            //entrepriseDR["descriptif_entreprise"] = textBoxDescripEnt.Text;
            //entrepriseDR["taille_entreprise"] = comboBoxTailleEnt.ValueMember;
            //entrepriseDR["statut_entreprise"] = EntrepriseManager.GetStatus(comboBoxStatutEnt.Text);
            //entrepriseDR["date_creation_entreprise"] = datePickerCreationEnt.Value;

            //ds.Tables["entreprise"].Rows.Add(entrepriseDR);

            EntrepriseManager.SaveEntreprise(entrepriseRow);

            this.Close();

        }
    }
}
