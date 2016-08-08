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


        public static List<Connectds.periodeRow> GetDisponibiliteList(int etudiant_id)
        {
            Connectds.periodeDataTable periodeDT = new Connectds.periodeDataTable();

            using(ConnectdsTableAdapters.periodeTableAdapter periodeAdpt = new ConnectdsTableAdapters.periodeTableAdapter())
            {
                periodeAdpt.Fill(periodeDT);
            }
            List<Connectds.periodeRow> periodeList = periodeDT.Where(p => p.etudiant_id == etudiant_id).ToList();

            return periodeList;
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

        public static Connectds GetEtudiantDS()
        {
            Connectds ds = new Connectds();
            using (ConnectdsTableAdapters.etudiantTableAdapter etudiantAdpt = new ConnectdsTableAdapters.etudiantTableAdapter())
            {
                etudiantAdpt.Fill(ds.etudiant);
            }
            return ds;
        }

        public static Connectds GetPeriodeDS()
        {
            Connectds ds = new Connectds();
            using (ConnectdsTableAdapters.periodeTableAdapter periodeAdpt = new ConnectdsTableAdapters.periodeTableAdapter())
            {
                periodeAdpt.Fill(ds.periode);
            }
            return ds;
        }

        public static void SaveEtudiant(DataRow etudiantRow)
        {
            using (ConnectdsTableAdapters.etudiantTableAdapter etudiantAdpt = new ConnectdsTableAdapters.etudiantTableAdapter())
            {
                etudiantAdpt.Update(etudiantRow);
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

    }
}
