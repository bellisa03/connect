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

        public static bool GetStatus(string statut)
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

        public static string GetTaille(string taille)
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

        public static Connectds GetEntrepriseDS()
        {
            Connectds ds = new Connectds();
            using (ConnectdsTableAdapters.entrepriseTableAdapter entrepriseAdpt = new ConnectdsTableAdapters.entrepriseTableAdapter())
            {
                entrepriseAdpt.Fill(ds.entreprise);
            }
            return ds;
        }
        
        public static void SaveEntreprise(DataRow entrepriseRow)
        {
            using (ConnectdsTableAdapters.entrepriseTableAdapter entrepriseAdpt = new ConnectdsTableAdapters.entrepriseTableAdapter())
            {
                entrepriseAdpt.Update(entrepriseRow);
            }
        }

        //public static void UpdateEntreprise(Connectds.entrepriseRow entrepriseRow)
        //{
        //    //Connectds.entrepriseDataTable entrepriseDT = new Connectds.entrepriseDataTable();

        //    using (ConnectdsTableAdapters.entrepriseTableAdapter entrepriseAdpt = new ConnectdsTableAdapters.entrepriseTableAdapter())
        //    {
        //        entrepriseAdpt.Update(entrepriseRow);
        //    }
        //}

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
    }
}
