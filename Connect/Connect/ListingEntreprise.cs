﻿using System;
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
        Connectds.entrepriseRow entrepriseSelectionnee;

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
            Int32.TryParse(comboBoxListEntreprise.SelectedValue.ToString(), out value);
            entrepriseSelectionnee = EntrepriseManager.GetEntreprise(value);
            if (value != -1)
            {
                FormEntreprise formEntreprise = new FormEntreprise(entrepriseSelectionnee);
                formEntreprise.MdiParent = this.MdiParent;
                formEntreprise.Show();
                this.Close();
            }
        }

        private void PopulateAndBind()
        {
            //Connectds ds = new Connectds();

            //ds = EntrepriseManager.GetEntrepriseDS();
            Connectds.entrepriseDataTable entrepriseDT = new Connectds.entrepriseDataTable();
            entrepriseDT = EntrepriseManager.GetEntrepriseDT();

            comboBoxListEntreprise.DataSource = entrepriseDT;
            comboBoxListEntreprise.ValueMember = "entreprise_id";
            comboBoxListEntreprise.DisplayMember = "nom_entreprise";

            dataGridViewListEntreprise.DataSource = entrepriseDT;
            dataGridViewListEntreprise.ReadOnly = true;
            dataGridViewListEntreprise.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewListEntreprise.Columns[8].Visible = false; //descriptif de l'entreprise caché -> trop verbeux pour un DataGridView
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

        private void buttonDeleteEnt_Click(object sender, EventArgs e)
        {
            int value;
            Int32.TryParse(comboBoxListEntreprise.SelectedValue.ToString(), out value);
            var Result = MessageBox.Show("Etes-vous sûr de vouloir supprimer l'entreprise n°" + value.ToString() + "?", "Veuillez confirmer:", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Result == DialogResult.OK)
            {
                // la variable checkJob va permettre de conserver l'information booléenne quant aux attributions de job de l'étudiant en dehors de la boucle foreach
                bool checkJob = false;
                Connectds.jobDataTable jobDT = EntrepriseManager.GetJobDT();
                foreach (Connectds.jobRow jobRow in jobDT)
                {
                    if (value == jobRow.entreprise_id)
                    {
                        var Result2 = MessageBox.Show("L'entreprise n°" + value.ToString() + " a déjà publié des annonces. Vous ne pouvez la supprimer. Souhaitez-vous rendre son profil inactif?", "Veuillez préciser:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (Result2 == DialogResult.Yes)
                        {
                            entrepriseSelectionnee = EntrepriseManager.GetEntreprise(value);
                            entrepriseSelectionnee.statut_entreprise = false; // le statut devient inactif
                            EntrepriseManager.SaveEntreprise(entrepriseSelectionnee);
                        }
                        checkJob = true;
                        break;
                    }
                }
                if (!checkJob)
                {
                    EntrepriseManager.DeleteEntreprise(value);
                }
                PopulateAndBind();
            }
        }

        private void buttonListEntrepriseFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
