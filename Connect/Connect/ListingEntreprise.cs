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
        }

        private void buttonListEntrepriseFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
