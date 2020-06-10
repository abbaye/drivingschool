using System;
using System.Windows.Forms;

using Barette.IDE.Forms;

namespace Barette.IDE
{
    /// <summary>
    /// Description résumée de MainEntry.
    /// </summary>
    public sealed class MainEntry {
#if DEBUG
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main() {
            //Lancement de l'application
            Application.EnableVisualStyles();
            Application.Run(new FormMain());

        }
#else
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main() {
            //Obtient le processus en cours de l'application
            Process Proc_EnCours = Process.GetCurrentProcess();
            //Collection des processus actuellement lancés
            Process[] Les_Proc = Process.GetProcesses();

            bool OnlyOne = true;
            //Pour chaque processus lancé
            foreach (Process Processus in Les_Proc)
                if (Proc_EnCours.Id != Processus.Id)
                    if (Proc_EnCours.ProcessName == Processus.ProcessName)
                        OnlyOne = false;

            if (OnlyOne == true) {
                //Creation des repertoires de donnees
                if (!Directory.Exists("Data"))
                    Directory.CreateDirectory("Data");

                //Lancement de l'application
                Application.EnableVisualStyles();
                Application.Run(new FormMain());
            }
        }
#endif
    }
}

