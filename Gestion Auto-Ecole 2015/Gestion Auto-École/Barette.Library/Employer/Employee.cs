using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barette.Library.Employee {
    /// <summary>
    /// Type d'horaire
    /// </summary>
    public enum TypeEmployee {
        Nothing,
        PartTime,
        FullTime
    }

    /// <summary>
    /// Situation Familiale de l'employe
    /// </summary>
    public enum FamilyStatus {
        Unmarried, //Non marié
        Divorced, //Divorcé
        Married, // Marié
        CommonLaw, //Union Livre
        Widower, //Veuf
    }

    /// <summary>
    /// Class servant a la gestion d'employee de l'entreprise
    /// </summary>
    public class Employee {
        /// <summary>
        /// Contructeur de la class employee
        /// </summary>
        public Employee(){

        }

        /// <summary>
        /// Numero de l'employee
        /// </summary>
        public int NumberID {
            get;
            set;
        }

        /// <summary>
        /// Nom de l'employee
        /// </summary>
        public string Name {
            get;
            set;
        }

        /// <summary>
        /// Prenom employee
        /// </summary>
        public string FirstName {
            get;
            set;
        }

        /// <summary>
        /// Titre dans l'entreprise
        /// </summary>
        public string Title {
            get;
            set;
        }

        /// <summary>
        /// Téléphone de la maison
        /// </summary>
        public string Phone {
            get;
            set;
        }

        /// <summary>
        /// Autre numéro Téléphone
        /// </summary>
        public string Phone2 {
            get;
            set;
        }
                
        /// <summary>
        /// Notes consernant l'employé
        /// </summary>
        public string Notes {
            get;
            set;
        }

        /// <summary>
        /// Adress
        /// </summary>
        public Adress Adresse {
            get;
            set;
        }   

        /// <summary>
        /// Taux de horaire.
        /// </summary>
        public decimal HourlyRate {
            get;
            set;
        }

        /// <summary>
        /// Quel type de salaire.
        /// </summary>
        public TypeEmployee TypeEmployer {
            get;
            set;
        }

        /// <summary>
        /// Nature de l'emploie
        /// </summary>
        public string JobTitle {
            get;
            set;
        }

        /// <summary>
        /// Premier jour de travail
        /// </summary>
        public DateTime FirstWorkingDay {
            get;
            set;
        }
        
        /// <summary>
        /// Dernier jour de travail
        /// </summary>
        public DateTime LastWorkingDay {
            get;
            set;
        }
        
        /// <summary>
        /// Nombre d'enfant à charge
        /// </summary>
        public int DependentChild {
            get;
            set;
        }

        /// <summary>
        /// Nombre d'adult à charge
        /// </summary>
        public int DependentAdult {
            get;
            set;
        }

        /// <summary>
        /// Situation familiale
        /// </summary>
        public FamilyStatus FamilyStatus {
            get;
            set;
        }

        /// <summary>
        /// Numéro d'assurance sociale
        /// </summary>
        public string NAS {
            get;
            set;
        }

        /// <summary>
        /// Date de Naissance;
        /// </summary>
        public DateTime BirthDate {
            get;
            set;
        }
    }


}
