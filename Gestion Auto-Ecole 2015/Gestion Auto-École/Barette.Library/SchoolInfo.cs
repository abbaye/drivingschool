using System;
using System.Collections.Generic;
using System.Text;

namespace Barette.Library
{
    /// <summary>
    /// Cette classe représente des informations l'école de conduite
    /// </summary>
    public class SchoolInfo
    {
        //Info de base
        private string _SchoolName = "";
        private string _StreetName = "";
        private int _StreetNumber = 0;
        private string _City = "";
        private string _Phone = "";
        private string _Fax = "";
        private string _CodePostal = "";
        
        //Autre Info
        private string _TPS = "";
        private string _TVQ = "";
        private string _RegistreAuto = "";
        private string _RegistreMoto = "";

        //Taux Horraire (Par défaut)
        private string _TauxHoraireTheorie = "";
        private string _TauxHorairePratique = "";

        #region Property : SchoolInfo
        /// <summary>
        /// Nom de l'école
        /// </summary>
        public string SchoolName {
            get {
                return this._SchoolName;
            }
            set {
                this._SchoolName = value;
            }
        }

        /// <summary>
        /// Nom de la rue
        /// </summary>
        public string StreetName {
            get {
                return this._StreetName;
            }
            set {
                this._StreetName = value;
            }
        }

        /// <summary>
        /// Numero de la rue
        /// </summary>
        public int StreetNumber {
            get {
                return this._StreetNumber ;
            }
            set {
                this._StreetNumber = value;
            }
        }

        /// <summary>
        /// Nom de la ville
        /// </summary>
        public string City {
            get {
                return this._City;
            }
            set {
                this._City = value;
            }
        }

        /// <summary>
        /// Numero de telephone
        /// </summary>
        public string Phone {
            get {
                return this._Phone;
            }
            set {
                this._Phone = value;
            }
        }

        /// <summary>
        /// Numero de faxe
        /// </summary>
        public string Fax {
            get {
                return this._Fax;
            }
            set {
                this._Fax = value;
            }
        }

        /// <summary>
        /// Code Postal
        /// </summary>
        public string PostalCode {
            get {
                return this._CodePostal;
            }
            set {
                this._CodePostal = value;
            }
        }

        /// <summary>
        /// Numero de TPS
        /// </summary>
        public string TPS {
            get {
                return this._TPS;
            }
            set {
                this._TPS = value;
            }
        }

        /// <summary>
        /// Numero de TVQ
        /// </summary>
        public string TVQ {
            get {
                return this._TVQ;
            }
            set {
                this._TVQ = value;
            }
        }

        /// <summary>
        /// Numero de Registre Automobile
        /// </summary>
        public string RegistrationAuto {
            get {
                return this._RegistreAuto;
            }
            set {
                this._RegistreAuto = value;
            }
        }

        /// <summary>
        /// Numero de registre de Moto
        /// </summary>
        public string RegistrationMoto {
            get {
                return this._RegistreMoto; 
            }
            set {
                this._RegistreMoto = value;
            }
        }

        /// <summary>
        /// Taux horaire : Theorie
        /// </summary>
        public string TauxHoraireTheorie {
            get {
                return this._TauxHoraireTheorie;
            }
            set {
                this._TauxHoraireTheorie = value;
            }
        }

        /// <summary>
        /// Taux horaire : Theorie
        /// </summary>
        public string TauxHorairePratique {
            get {
                return this._TauxHorairePratique;
            }
            set {
                this._TauxHorairePratique = value;
            }
        }
        #endregion

        #region Property : Lieu du cours
        /// <summary>
        /// Nom de l'établissement ou se donne le cours
        /// </summary>
        public string CourseBatisseName {
            get;
            set;
        }

        /// <summary>
        /// Nom de la rue
        /// </summary>
        public string CourseStreetName {
            get;
            set;
        }

        /// <summary>
        /// Numero de la rue
        /// </summary>
        public int CourseStreetNumber {
            get;
            set;
        }

        /// <summary>
        /// Nom de la ville
        /// </summary>
        public string CourseCity {
            get;
            set;
        }

        /// <summary>
        /// Code Postal
        /// </summary>
        public string CoursePostalCode {
            get;
            set;
        }
        #endregion

    }
}
