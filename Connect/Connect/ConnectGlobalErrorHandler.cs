using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Connect
{
    class ConnectGlobalErrorHandler
    {
        public void OnThreadException(object sender, ThreadExceptionEventArgs t)
        {
            try
            {
                MessageBox.Show("L'application vient de rencontrer une erreur fatale. Elle va maintenant devoir se fermer", 
                                "Connect - Erreur", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
                WriteToLogFile("Fatal error in Connect! " + t.Exception.ToString());         
            }
            finally
            {
                Application.Exit();
            }

        }

        public static void WriteToLogFile(string message)
        {

        }

    }
}
