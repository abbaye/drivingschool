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
                return _SchoolName;
            }
            set {
                _SchoolName = value;
            }
        }

        /// <summary>
        /// Nom de la rue
        /// </summary>
        public string StreetName {
            get {
                return _StreetName;
            }
            set {
                _StreetName = value;
            }
        }

        /// <summary>
        /// Numero de la rue
        /// </summary>
        public int StreetNumber {
            get {
                return _StreetNumber;
            }
            set {
                _StreetNumber = value;
            }
        }

        /// <summary>
        /// Nom de la ville
        /// </summary>
        public string City {
            get {
                return _City;
            }
            set {
                _City = value;
            }
        }

        /// <summary>
        /// Numero de telephone
        /// </summary>
        public string Phone {
            get {
                return _Phone;
            }
            set {
                _Phone = value;
            }
        }

        /// <summary>
        /// Numero de faxe
        /// </summary>
        public string Fax {
            get {
                return _Fax;
            }
            set {
                _Fax = value;
            }
        }

        /// <summary>
        /// Code Postal
        /// </summary>
        public string PostalCode {
            get {
                return _CodePostal;
            }
            set {
                _CodePostal = value;
            }
        }

        /// <summary>
        /// Numero de TPS
        /// </summary>
        public string TPS {
            get {
                return _TPS;
            }
            set {
                _TPS = value;
            }
        }

        /// <summary>
        /// Numero de TVQ
        /// </summary>
        public string TVQ {
            get {
                return _TVQ;
            }
            set {
                _TVQ = value;
            }
        }

        /// <summary>
        /// Numero de Registre Automobile
        /// </summary>
        public string RegistrationAuto {
            get {
                return _RegistreAuto;
            }
            set {
                _RegistreAuto = value;
            }
        }

        /// <summary>
        /// Numero de registre de Moto
        /// </summary>
        public string RegistrationMoto {
            get {
                return _RegistreMoto; 
            }
            set {
                _RegistreMoto = value;
            }
        }

        /// <summary>
        /// Taux horaire : Theorie
        /// </summary>
        public string TauxHoraireTheorie {
            get {
                return _TauxHoraireTheorie;
            }
            set {
                _TauxHoraireTheorie = value;
            }
        }

        /// <summary>
        /// Taux horaire : Theorie
        /// </summary>
        public string TauxHorairePratique {
            get {
                return _TauxHorairePratique;
            }
            set {
                _TauxHorairePratique = value;
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
