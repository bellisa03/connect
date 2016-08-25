using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Connect
{
    class EntrepriseManager
    {
        /// <summary>
        /// Remplit un dataset de toutes les tables de la Base de données
        /// </summary>
        /// <returns></returns>
        public static Connectds GetDS()
        {
            Connectds ds = new Connectds();

            using(ConnectdsTableAdapters.entrepriseTableAdapter entrepriseAdpt = new ConnectdsTableAdapters.entrepriseTableAdapter())
            {
                entrepriseAdpt.Fill(ds.entreprise);
            }
            using(ConnectdsTableAdapters.etudiantTableAdapter etudiantAdpt = new ConnectdsTableAdapters.etudiantTableAdapter())
            {
                etudiantAdpt.Fill(ds.etudiant);
            }
            using(ConnectdsTableAdapters.jobTableAdapter jobAdpt = new ConnectdsTableAdapters.jobTableAdapter())
            {
                jobAdpt.Fill(ds.job);
            }
            using(ConnectdsTableAdapters.periodeTableAdapter periodeAdpt = new ConnectdsTableAdapters.periodeTableAdapter())
            {
                periodeAdpt.Fill(ds.periode);
            }

            return ds;
        }

        public static Connectds.entrepriseRow GetEntreprise(int entreprise_id)
        {
            Connectds.entrepriseDataTable entrepriseDT = new Connectds.entrepriseDataTable();
            
            using (ConnectdsTableAdapters.entrepriseTableAdapter entrepriseAdpt = new ConnectdsTableAdapters.entrepriseTableAdapter())
            {
                entrepriseAdpt.Fill(entrepriseDT);
            }
            Connectds.entrepriseRow entrepriseRow = entrepriseDT.FindByentreprise_id(entreprise_id);

            return entrepriseRow;
        }

        
        
        public static Connectds.entrepriseDataTable GetEntrepriseDT()
        {
            Connectds.entrepriseDataTable dt = new Connectds.entrepriseDataTable();
            using (ConnectdsTableAdapters.entrepriseTableAdapter entrepriseAdpt = new ConnectdsTableAdapters.entrepriseTableAdapter())
            {
                entrepriseAdpt.Fill(dt);
            }
            return dt;
        }

        public static void SaveEntreprise(DataRow entrepriseRow)
        {
            using (ConnectdsTableAdapters.entrepriseTableAdapter entrepriseAdpt = new ConnectdsTableAdapters.entrepriseTableAdapter())
            {
                entrepriseAdpt.Update(entrepriseRow);
            }
        }

        public static void AddEntreprise(Connectds.entrepriseRow entrepriseRow)
        {
            using (ConnectdsTableAdapters.entrepriseTableAdapter entrepriseAdpt = new ConnectdsTableAdapters.entrepriseTableAdapter())
            {
                entrepriseAdpt.Insert(entrepriseRow.nom_entreprise, entrepriseRow.adresse_entreprise, entrepriseRow.contact_entreprise, entrepriseRow.telephone_entreprise, entrepriseRow.secteur_entreprise, entrepriseRow.type_entreprise, entrepriseRow.taille_entreprise, entrepriseRow.descriptif_entreprise, entrepriseRow.statut_entreprise, entrepriseRow.date_creation_entreprise);
            }
        }

        public static void DeleteEntreprise(int entreprise_id)
        {
            Connectds.entrepriseDataTable entrepriseDT = new Connectds.entrepriseDataTable();

            using (ConnectdsTableAdapters.entrepriseTableAdapter entrepriseAdpt = new ConnectdsTableAdapters.entrepriseTableAdapter())
            {
                entrepriseAdpt.Fill(entrepriseDT);
                Connectds.entrepriseRow entrepriseRow = entrepriseDT.FindByentreprise_id(entreprise_id);
                entrepriseRow.Delete();

                entrepriseAdpt.Update(entrepriseDT);
            }
        }

        public static Connectds.jobRow GetJob(int job_id)
        {
            Connectds.jobDataTable jobDT = new Connectds.jobDataTable();

            using (ConnectdsTableAdapters.jobTableAdapter jobAdpt = new ConnectdsTableAdapters.jobTableAdapter())
            {
                jobAdpt.Fill(jobDT);
            }
            Connectds.jobRow jobRow = jobDT.FindByjob_id(job_id);

            return jobRow;
        }

        public static Connectds.jobDataTable GetJobDT()
        {
            Connectds.jobDataTable dt = new Connectds.jobDataTable();
            using (ConnectdsTableAdapters.jobTableAdapter jobAdpt = new ConnectdsTableAdapters.jobTableAdapter())
            {
                jobAdpt.Fill(dt);
            }
            return dt;
        }

        public static void SaveJob(DataRow jobRow)
        {
            using (ConnectdsTableAdapters.jobTableAdapter jobAdpt = new ConnectdsTableAdapters.jobTableAdapter())
            {
                jobAdpt.Update(jobRow);
            }
        }

        public static void AddJob(Connectds.jobRow jobRow)
        {
            using (ConnectdsTableAdapters.jobTableAdapter jobAdpt = new ConnectdsTableAdapters.jobTableAdapter())
            {
                jobAdpt.Insert(jobRow.titre_job, jobRow.descriptif_job, jobRow.profil_job, jobRow.date_debut_job, jobRow.date_fin_job, jobRow.horaire_job, jobRow.remuneration_job,
                    jobRow.permis_voiture_job, jobRow.remarque_job, jobRow.statut_job,jobRow.date_publication_job,jobRow.entreprise_id,jobRow.etudiant_id);
            }
        }

        public static void DeleteJob(int job_id)
        {
            Connectds.jobDataTable jobDT = new Connectds.jobDataTable();

            using (ConnectdsTableAdapters.jobTableAdapter jobAdpt = new ConnectdsTableAdapters.jobTableAdapter())
            {
                jobAdpt.Fill(jobDT);
                Connectds.jobRow jobRow = jobDT.FindByjob_id(job_id);
                jobRow.Delete();

                jobAdpt.Update(jobDT);
            }
        }
        public static bool GetStatusEnt(string statut)
        {
            switch (statut)
            {
                case "Actif":
                    return true;

                case "Désactivé":
                    return false;

                default:
                    return true;
            }
        }

        public static bool GetStatusJob(string statut)
        {
            switch (statut)
            {
                case "Disponible":
                    return true;

                case "Attribué":
                    return false;

                default:
                    return true;
            }
        }

        public static string GetTailleEnt(string taille)
        {
            string codeTaille;
            switch (taille)
            {
                case "Très Petite Entreprise":
                    codeTaille = "TPE";
                    break;

                case "Petite Entreprise":
                    codeTaille = "PE";
                    break;

                case "Grande Entreprise":
                    codeTaille = "GE";
                    break;

                default:
                    codeTaille = "";
                    break;
            }
            return codeTaille;
        }
    }
}
