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
    public partial class FormEtudiant : Form
    {
        Connectds ds;
        Connectds.etudiantRow etudiantRow;
        int id = -1;

        /// <summary>
        /// Constructeur pour un formulaire vierge, afin de créer un nouveau profil étudiant.
        /// la valeur de la variable id pour charger ce formulaire est alors à -1.
        /// </summary>
        public FormEtudiant()
        {
            InitializeComponent();
            PopulateAndBind(id);
        }

        /// <summary>
        /// Constructeur pour afficher dans le formulaire, les détails d'un profil étudiant existant.
        /// Utilise l'id de l'étudiant comme attribut.
        /// la valeur de la variable id pour charger ce formulaire sera alors l'id de l'étudiant.
        /// </summary>
        /// <param name="entrepriseRow"></param>
        public FormEtudiant(Connectds.etudiantRow etudiantRow)
        {
            InitializeComponent();
            this.id = etudiantRow.etudiant_id;
            PopulateAndBind(id);
        }

        /// <summary>
        /// Au chargement du formulaire, on charge les données du data set dans la variable ds, par le biais de la méthode GetEtudiantDS()
        /// </summary>
        private void FormEtudiant_Load(object sender, EventArgs e)
        {
            ds = EtudiantManager.GetEtudiantDS();
        }

        private void PopulateAndBind(int id)
        {
            comboBoxSexeEtudiant.Items.Add(Enums.Sexe.Féminin.ToString());
            comboBoxSexeEtudiant.Items.Add(Enums.Sexe.Masculin.ToString());
            comboBoxSexeEtudiant.Items.Add(Enums.Sexe.Indéterminé.ToString());

            //dateTimePickerDdNEtudiant.MinDate = DateTime.Now.AddYears(-30);
            //dateTimePickerDdNEtudiant.MinDate = DateTime.Now.AddYears(-12);

            //dateTimePickerCreaProfilEtudiant.MinDate = DateTime.Now.AddYears(-5);
            //dateTimePickerCreaProfilEtudiant.MaxDate = DateTime.Now.AddDays(1);

            if (id != -1)
            {
                buttonValiderEtudiant.Text = "Modifier";
                etudiantRow = EtudiantManager.GetEtudiant(id);

                switch (etudiantRow.sexe_etudiant)
                {
                    case "F":
                        comboBoxSexeEtudiant.Text = Enums.Sexe.Féminin.ToString();
                        break;
                    case "M":
                        comboBoxSexeEtudiant.Text = Enums.Sexe.Masculin.ToString();
                        break;
                    case "X":
                        comboBoxSexeEtudiant.Text = Enums.Sexe.Indéterminé.ToString();
                        break;
                    default:
                        break;
                }
                textBoxIdEtudiant.DataBindings.Add("Text", etudiantRow, "etudiant_id");
                textBoxNomEtudiant.DataBindings.Add("Text", etudiantRow, "nom_etudiant");
                textBoxPrenomEtudiant.DataBindings.Add("Text", etudiantRow, "prenom_etudiant");
                dateTimePickerDdNEtudiant.DataBindings.Add("Value", etudiantRow, "date_naissance_etudiant");
                textBoxAdresseEtudiant.DataBindings.Add("Text", etudiantRow, "adresse_etudiant");
                textBoxTelEtudiant.DataBindings.Add("Text", etudiantRow, "telephone_etudiant");
                textBoxEmailEtudiant.DataBindings.Add("Text", etudiantRow, "email_etudiant");

                textBoxEcoleEtudiant.DataBindings.Add("Text", etudiantRow, "ecole_etudiant");
                textBoxAnneeEtudiant.DataBindings.Add("Text", etudiantRow, "annee_scolaire_etudiant");
                textBoxTypeEtudiant.DataBindings.Add("Text", etudiantRow, "type_etudes_etudiant");

                textBoxLangueEtudiant.DataBindings.Add("Text", etudiantRow, "langues_etudiant");
                textBoxExperience.DataBindings.Add("Text", etudiantRow, "experience_etudiant");
                textBoxDomaineEtudiant.DataBindings.Add("Text", etudiantRow, "domaine_recherche_etudiant");
                
                textBoxHobbiesEtudiant.DataBindings.Add("Text", etudiantRow, "hobbies_etudiant");
                textBoxRmqEtudiant.DataBindings.Add("Text", etudiantRow, "remarque_etudiant");
                dateTimePickerCreaProfilEtudiant.DataBindings.Add("Value", etudiantRow, "date_creation_etudiant");
                

                // création du binding pour le radiobutton "Oui" (permis)
                var permisBinding = new Binding("Checked", etudiantRow, "permis_voiture_etudiant");
                // Format = lecture à partir du datasource, retourne "true" s'il lit la valeur true
                permisBinding.Format += (s, args) => args.Value = ((bool)args.Value) == true;
                // Parse = écriture dans le datasource, retourne la valeur true s'il lit true, sinon il retourne false
                permisBinding.Parse += (s, args) => args.Value = (bool)args.Value ? true : false;
                // Binding:
                radioButtonPermisOuiEtudiant.DataBindings.Add(permisBinding);

                // création du binding pour le radiobutton "Non" (permis)
                var permisNonBinding = new Binding("Checked", etudiantRow, "permis_voiture_etudiant");
                // Format = lecture à partir du datasource, retourne "true" s'il lit la valeur false
                permisNonBinding.Format += (s, args) => args.Value = ((bool)args.Value) == false;
                // Parse = écriture dans le datasource, retourne la valeur false s'il lit true, sinon il retourne true
                permisNonBinding.Parse += (s, args) => args.Value = (bool)args.Value ? false : true;
                // Binding:
                radioButtonPermisNonEtudiant.DataBindings.Add(permisNonBinding);
            }
            else
            {
                Connectds.etudiantDataTable dt = new Connectds.etudiantDataTable();
                etudiantRow = dt.NewetudiantRow();
                dateTimePickerCreaProfilEtudiant.Value = DateTime.Now;
                textBoxIdEtudiant.Text = etudiantRow.etudiant_id.ToString();
            }
        }

        private void buttonValiderEtudiant_Click(object sender, EventArgs e)
        {

        }

        private void buttonValiderDispoEtudiant_Click(object sender, EventArgs e)
        {

        }

        private void Valider()
        {
            if (radioButtonPermisOuiEtudiant.Checked) etudiantRow.permis_voiture_etudiant = true;
            if (radioButtonPermisNonEtudiant.Checked) etudiantRow.permis_voiture_etudiant = false;

        }

        private void buttonAnnulerEtudiant_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
