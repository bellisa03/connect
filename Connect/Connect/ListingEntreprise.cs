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
    public partial class ListingEntreprise : Form
    {
        public ListingEntreprise()
        {
            InitializeComponent();
            
        }

        private void ListingEntreprise_Load(object sender, EventArgs e)
        {
            PopulateAndBind();
            
        }

        private void buttonListEntrepriseAfficher_Click(object sender, EventArgs e)
        {
            int value;
            Connectds.entrepriseRow entrepriseSelectionnee;
            Int32.TryParse(comboBoxListEntreprise.SelectedValue.ToString(), out value);
            entrepriseSelectionnee = EntrepriseManager.GetEntreprise(value);
            if (value != -1)
            {
                FormEntreprise formEntreprise = new FormEntreprise(entrepriseSelectionnee);
                formEntreprise.Show();
                this.Close();
            }

        }

        private void PopulateAndBind()
        {
            Connectds ds = new Connectds();

            using (ConnectdsTableAdapters.entrepriseTableAdapter entrepriseAdpt = new ConnectdsTableAdapters.entrepriseTableAdapter())
            {
                entrepriseAdpt.Fill(ds.entreprise);
            }

            comboBoxListEntreprise.DataSource = ds;
            comboBoxListEntreprise.ValueMember = "entreprise.entreprise_id";
            comboBoxListEntreprise.DisplayMember = "entreprise.nom_entreprise";

            dataGridViewListEntreprise.DataSource = ds;
            dataGridViewListEntreprise.DataMember = "entreprise";
            dataGridViewListEntreprise.ReadOnly = true;
            dataGridViewListEntreprise.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewListEntreprise.Columns[8].Visible = false; //descriptif de l'entreprise -> trop verbeux pour un DataGridView
            dataGridViewListEntreprise.Columns[0].HeaderText = "ID";
            dataGridViewListEntreprise.Columns[1].HeaderText = "Dénomination";
            dataGridViewListEntreprise.Columns[2].HeaderText = "Adresse";
            dataGridViewListEntreprise.Columns[3].HeaderText = "Contact";
            dataGridViewListEntreprise.Columns[4].HeaderText = "Téléphone";
            dataGridViewListEntreprise.Columns[5].HeaderText = "Secteur";
            dataGridViewListEntreprise.Columns[6].HeaderText = "Type";
            dataGridViewListEntreprise.Columns[7].HeaderText = "Taille";
            dataGridViewListEntreprise.Columns[9].HeaderText = "Statut";
            dataGridViewListEntreprise.Columns[10].HeaderText = "Date de création";
            
        }

        private void buttonListEntrepriseFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDeleteEnt_Click(object sender, EventArgs e)
        {
            int value;
            Int32.TryParse(comboBoxListEntreprise.SelectedValue.ToString(), out value);
            var Result = MessageBox.Show("Etes-vous sûr de vouloir supprimer l'entreprise n°" + value.ToString() + "?", "Veuillez confirmer:", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Result == DialogResult.OK)
            {
                EntrepriseManager.DeleteEntreprise(value);
                PopulateAndBind();
            }            
        }
    }
}
