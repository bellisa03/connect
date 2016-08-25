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

        
        private void PopulateAndBind(int id)
        {
            comboBoxSexeEtudiant.Items.Add(Enums.Genre.Féminin.ToString());
            comboBoxSexeEtudiant.Items.Add(Enums.Genre.Masculin.ToString());
            comboBoxSexeEtudiant.Items.Add(Enums.Genre.Indéterminé.ToString());

            dateTimePickerDdNEtudiant.MinDate = DateTime.Now.AddYears(-31);
            dateTimePickerDdNEtudiant.MaxDate = DateTime.Now.AddYears(-12);

            dateTimePickerCreaProfilEtudiant.MinDate = DateTime.Now.AddYears(-5);
            dateTimePickerCreaProfilEtudiant.MaxDate = DateTime.Now.AddDays(1);

            if (id != -1)
            {
                etudiantRow = EtudiantManager.GetEtudiant(id);

                switch (etudiantRow.sexe_etudiant)
                {
                    case "F":
                        comboBoxSexeEtudiant.Text = Enums.Genre.Féminin.ToString();
                        break;
                    case "M":
                        comboBoxSexeEtudiant.Text = Enums.Genre.Masculin.ToString();
                        break;
                    case "X":
                        comboBoxSexeEtudiant.Text = Enums.Genre.Indéterminé.ToString();
                        break;
                    default:
                        break;
                }  
            }
            else
            {
                Connectds.etudiantDataTable etudiantDT = new Connectds.etudiantDataTable();
                etudiantRow = etudiantDT.NewetudiantRow();

                etudiantRow.nom_etudiant = string.Empty;
                etudiantRow.prenom_etudiant = string.Empty;
                etudiantRow.date_naissance_etudiant = DateTime.Now.AddYears(-20);
                dateTimePickerDdNEtudiant.Value = DateTime.Now.AddYears(-20);
                etudiantRow.adresse_etudiant = string.Empty;
                etudiantRow.telephone_etudiant = string.Empty;
                etudiantRow.email_etudiant = string.Empty;
                etudiantRow.statut_etudiant = true;

                etudiantRow.ecole_etudiant = string.Empty;
                etudiantRow.annee_scolaire_etudiant = string.Empty;
                etudiantRow.type_etudes_etudiant = string.Empty;

                etudiantRow.permis_voiture_etudiant = true;
                etudiantRow.sexe_etudiant = string.Empty;
                etudiantRow.hobbies_etudiant = string.Empty;
                etudiantRow.experience_etudiant = string.Empty;
                etudiantRow.domaine_recherche_etudiant = string.Empty;

                etudiantRow.langues_etudiant = string.Empty;
                etudiantRow.remarque_etudiant = string.Empty;
                etudiantRow.date_creation_etudiant = DateTime.Now;
                dateTimePickerCreaProfilEtudiant.Value = DateTime.Now;
                labelIdEtudiant.Visible = false;
                textBoxIdEtudiant.Visible = false;
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

            // création du binding pour le checkbox Actif
            var actifBinding = new Binding("Checked", etudiantRow, "statut_etudiant");
            // Format = lecture à partir du datasource, retourne "true" s'il lit la valeur 1
            actifBinding.Format += (s, args) => args.Value = ((bool)args.Value) == true;
            // Parse = écriture dans le datasource, retourne la valeur false s'il lit la valeur 2
            actifBinding.Parse += (s, args) => args.Value = (bool)args.Value ? true : false;
            // Binding:
            checkBoxActif.DataBindings.Add(actifBinding);
        }
        /// <summary>
        /// la méthode refreshDataGrid permet de retourner sur le listing des étudiants après une modification/ajout/suppression d'un profil étudiant,
        /// Afin d'avoir la liste du DataGridView mise à jour
        /// </summary>
        private void refreshDataGrid()
        {
            this.Close();
            ListingEtudiant listeEtudiant = new ListingEtudiant();
            listeEtudiant.MdiParent = HomePage.ActiveForm;
            listeEtudiant.Show();
        }

        private void buttonValiderEtudiant_Click(object sender, EventArgs e)
        {
            if (etudiantRow.nom_etudiant != string.Empty && etudiantRow.prenom_etudiant != string.Empty)
            {
                Valider();
                refreshDataGrid();
            }
            else
                MessageBox.Show("Veuillez remplir le nom et le prénom de l'étudiant", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonValiderDispoEtudiant_Click(object sender, EventArgs e)
        {
            if (etudiantRow.nom_etudiant != string.Empty && etudiantRow.prenom_etudiant != string.Empty)
            {
                Valider();
                Disponibilite disponibilite = new Disponibilite(id);
                disponibilite.MdiParent = HomePage.ActiveForm;
                disponibilite.Show();
            }
            else
                MessageBox.Show("Veuillez remplir le nom et le prénom de l'étudiant", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Valider()
        {
            etudiantRow.sexe_etudiant = EtudiantManager.GetGenre(comboBoxSexeEtudiant.Text);

            if (id == -1)
                EtudiantManager.AddEtudiant(etudiantRow);
            else
            {
                if (!etudiantRow.statut_etudiant)
                {
                    var Result = MessageBox.Show("Etes-vous sûr de vouloir inactiver l'étudiant n°" + etudiantRow.etudiant_id + "? S'il a communiqué des périodes de disponibilité à venir, elles vont être supprimées", 
                        "Veuillez confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (Result == DialogResult.OK)
                    {
                        List<Connectds.periodeRow> periodeList = new List<Connectds.periodeRow>();
                        periodeList = EtudiantManager.GetPeriodeList(etudiantRow.etudiant_id);
                        if (periodeList != null)
                        {
                            foreach (var periode in periodeList)
                            {
                                if (periode.debut_periode >= DateTime.Now)
                                    EtudiantManager.DeletePeriode(periode.periode_id);
                            }
                        }
                    }
                }
                EtudiantManager.SaveEtudiant(etudiantRow);
            }
                
        }

        private void buttonAnnulerEtudiant_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxActif_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxActif.Checked)
                buttonValiderDispoEtudiant.Enabled = false;                
            else
                buttonValiderDispoEtudiant.Enabled = true;
        }
    }
}
