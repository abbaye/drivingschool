#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;

#endregion

namespace Barette.Library {
	/// <summary>
	/// Configuration du Logiciel
	/// </summary>
	public class Config {
        /// <summary>
        /// Nom de l'Application
        /// </summary>
        private const string _ApplicationName = "Gestion Auto École 2010";
        
		public Config() {
            //Valeur par défault
            ModulebarWidth = 195;
            ShowOutlookBar = true;
            ShowGestionClient_Groupe = true;
            ShowGestionClient_CoursFinish = true;
            CustomerListWidth = 326;
            LastContractNumber = 1000;
		}

        /// <summary>
        /// Nom de l'application
        /// </summary>
        public string ApplicationName {
            get { return _ApplicationName; }
        }

        /// <summary>
        /// Afficher la bar latérale
        /// </summary>
        public bool ShowOutlookBar {
            get;
            set;
        }

        /// <summary>
        /// Afficher les groupes dans la gestion des clients
        /// </summary>
        public bool ShowGestionClient_Groupe {
            get;
            set;
        }

        /// <summary>
        /// Afficher les clients qui ont terminé leurs cours
        /// </summary>
        public bool ShowGestionClient_CoursFinish {
            get;
            set;
        }

        /// <summary>
        /// Largeur de la Barre outils
        /// </summary>
        public int ModulebarWidth {
            get;
            set;
        }

        /// <summary>
        /// Largeur de la liste des clients dans FormClient
        /// </summary>
        public int CustomerListWidth {
            get;
            set;
        }

        /// <summary>
        /// Dernier Numero de contrat
        /// </summary>
        public int LastContractNumber {
            get;
            set;
        }
	}
}
