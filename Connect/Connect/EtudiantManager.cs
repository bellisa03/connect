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

        public static void SaveEtudiant(DataRow entrepriseRow)
        {
            using (ConnectdsTableAdapters.etudiantTableAdapter etudiantAdpt = new ConnectdsTableAdapters.etudiantTableAdapter())
            {
                etudiantAdpt.Update(entrepriseRow);
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
    }
}
