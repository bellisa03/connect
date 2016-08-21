using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Connect
{
    class EtudiantManager
    {
        public static Connectds.etudiantRow GetEtudiant(int etudiant_id)
        {
            Connectds.etudiantDataTable etudiantDT = new Connectds.etudiantDataTable();

            using (ConnectdsTableAdapters.etudiantTableAdapter etudiantAdpt = new ConnectdsTableAdapters.etudiantTableAdapter())
            {
                etudiantAdpt.Fill(etudiantDT);
            }
            Connectds.etudiantRow etudiantRow = etudiantDT.FindByetudiant_id(etudiant_id);

            return etudiantRow;
        }

        public static Connectds GetEtudiantDS()
        {
            Connectds ds = new Connectds();
            using (ConnectdsTableAdapters.etudiantTableAdapter etudiantAdpt = new ConnectdsTableAdapters.etudiantTableAdapter())
            {
                etudiantAdpt.Fill(ds.etudiant);
            }
            return ds;
        }

        public static Connectds.periodeRow GetPeriode(int periode_id)
        {
            Connectds.periodeDataTable periodeDT = new Connectds.periodeDataTable();

            using (ConnectdsTableAdapters.periodeTableAdapter periodeAdpt = new ConnectdsTableAdapters.periodeTableAdapter())
            {
                periodeAdpt.Fill(periodeDT);
            }
            Connectds.periodeRow periodeRow = periodeDT.FindByperiode_id(periode_id);

            return periodeRow;
        }

        public static string GetSexe(string sexe)
        {
            switch (sexe)
            {
                case "Féminin":
                    return "F";

                case "Masculin":
                    return "M";

                case "Indéterminé":
                    return "X";

                default:
                    return "";
            }
        }

        public static void SaveEtudiant(DataRow etudiantRow)
        {
            using (ConnectdsTableAdapters.etudiantTableAdapter etudiantAdpt = new ConnectdsTableAdapters.etudiantTableAdapter())
            {
                etudiantAdpt.Update(etudiantRow);
            }
        }
        
        public static void AddEtudiant(Connectds.etudiantRow etudiantRow)
        {
            using (ConnectdsTableAdapters.etudiantTableAdapter etudiantAdpt = new ConnectdsTableAdapters.etudiantTableAdapter())
            {
                etudiantAdpt.Insert(etudiantRow.nom_etudiant, etudiantRow.prenom_etudiant, etudiantRow.date_naissance_etudiant, etudiantRow.sexe_etudiant, etudiantRow.adresse_etudiant, etudiantRow.telephone_etudiant, etudiantRow.email_etudiant, etudiantRow.langues_etudiant,
                    etudiantRow.type_etudes_etudiant, etudiantRow.annee_scolaire_etudiant, etudiantRow.ecole_etudiant, etudiantRow.permis_voiture_etudiant, etudiantRow.hobbies_etudiant, etudiantRow.experience_etudiant,etudiantRow.domaine_recherche_etudiant,
                    etudiantRow.remarque_etudiant,etudiantRow.statut_etudiant,etudiantRow.date_creation_etudiant);
            }
        }
        public static void DeleteEtudiant(int etudiant_id)
        {
            Connectds.etudiantDataTable etudiantDT = new Connectds.etudiantDataTable();

            using (ConnectdsTableAdapters.etudiantTableAdapter etudiantAdpt = new ConnectdsTableAdapters.etudiantTableAdapter())
            {
                etudiantAdpt.Fill(etudiantDT);
                Connectds.etudiantRow etudiantRow = etudiantDT.FindByetudiant_id(etudiant_id);
                etudiantRow.Delete();

                etudiantAdpt.Update(etudiantDT);

            }
        }

        public static void SavePeriode(DataRow periodeRow)
        {
            using (ConnectdsTableAdapters.periodeTableAdapter periodeAdpt = new ConnectdsTableAdapters.periodeTableAdapter())
            {
                periodeAdpt.Update(periodeRow);
            }
        }

        public static void AddPeriode(Connectds.periodeRow periodeRow)
        {
            using (ConnectdsTableAdapters.periodeTableAdapter periodeAdpt = new ConnectdsTableAdapters.periodeTableAdapter())
            {
                periodeAdpt.Insert(periodeRow.debut_periode, periodeRow.fin_periode, periodeRow.etudiant_id);
            }
        }

        public static void DeletePeriode(int periode_id)
        {
            Connectds.periodeDataTable periodeDT = new Connectds.periodeDataTable();

            using (ConnectdsTableAdapters.periodeTableAdapter periodeAdpt = new ConnectdsTableAdapters.periodeTableAdapter())
            {
                periodeAdpt.Fill(periodeDT);
                Connectds.periodeRow periodeRow = periodeDT.FindByperiode_id(periode_id);
                periodeRow.Delete();

                periodeAdpt.Update(periodeDT);
            }
        }

        /// <summary>
        /// Retourne la liste des périodes disponibles pour un étudiant donné
        /// </summary>
        /// <param name="etudiant_id"></param>
        /// <returns></returns>
        public static List<Connectds.periodeRow> GetDisponibiliteList(int etudiant_id)
        {
            Connectds.periodeDataTable periodeDT = new Connectds.periodeDataTable();

            using (ConnectdsTableAdapters.periodeTableAdapter periodeAdpt = new ConnectdsTableAdapters.periodeTableAdapter())
            {
                periodeAdpt.Fill(periodeDT);
            }
            List<Connectds.periodeRow> periodeList = periodeDT.Where(p => p.etudiant_id == etudiant_id).ToList();

            return periodeList;
        }

        /// <summary>
        /// Retourne la liste des étudiants disponibles en fonction des dates d'un job
        /// </summary>
        /// <param name="debut"></param>
        /// <param name="fin"></param>
        /// <returns></returns>
        public static List<Connectds.etudiantRow> GetDisponibiliteList(DateTime debut, DateTime fin)
        {
            Connectds ds = new Connectds();

            using (ConnectdsTableAdapters.etudiantTableAdapter etudiantAdpt = new ConnectdsTableAdapters.etudiantTableAdapter())
            {
                etudiantAdpt.Fill(ds.etudiant);
            }
            using (ConnectdsTableAdapters.periodeTableAdapter periodeAdpt = new ConnectdsTableAdapters.periodeTableAdapter())
            {
                periodeAdpt.Fill(ds.periode);
            }
            List<Connectds.periodeRow> periodeList = ds.periode.Where(p => p.debut_periode <= debut && p.fin_periode >= fin).ToList();
            List<Connectds.etudiantRow> etudiantList = ds.etudiant.ToList();
            List<Connectds.etudiantRow> rechercheEtudiantList = new List<Connectds.etudiantRow>();

            foreach (var periode in periodeList)
            {
                foreach (var etudiant in etudiantList)
                {
                    if (periode.etudiant_id == etudiant.etudiant_id)
                    {
                        rechercheEtudiantList.Add(etudiant);
                    }
                }
            }
            //List<Connectds.etudiantRow> etudiantList = from e in ds.etudiant
            //                                           join p in ds.periode on e.etudiant_id equals p.etudiant_id
            //                                           where (p.debut_periode <= debut) && (p.fin_periode >= fin).ToList();
            //select new { e.etudiant_id, e.nom_etudiant, e.prenom_etudiant, e.telephone_etudiant, e.langues_etudiant, e.domaine_recherche_etudiant, e.permis_voiture_etudiant }.ToList();

            return rechercheEtudiantList;
        }


    }
}
