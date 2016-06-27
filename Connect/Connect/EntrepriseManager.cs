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

        public static int GetStatus(string statut)
        {
            switch (statut)
            {
                case "Actif":
                    return 1;
                    
                case "Désactivé":
                    return 2;
                    
                case "Supprimé":
                    return 3;
                    
                default:
                    return -1;
            }
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
            //Connectds.entrepriseDataTable entrepriseDT = new Connectds.entrepriseDataTable();

            using (ConnectdsTableAdapters.entrepriseTableAdapter entrepriseAdpt = new ConnectdsTableAdapters.entrepriseTableAdapter())
            {
                entrepriseAdpt.Update(entrepriseRow);
            }
        }

        public static void UpdateEntreprise(Connectds.entrepriseRow entrepriseRow)
        {
            Connectds.entrepriseDataTable entrepriseDT = new Connectds.entrepriseDataTable();

            using (ConnectdsTableAdapters.entrepriseTableAdapter entrepriseAdpt = new ConnectdsTableAdapters.entrepriseTableAdapter())
            {
                entrepriseAdpt.Update(entrepriseDT);
            }
        }
    }
}
