using System;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;

using Barette.Library.Collections;
using System.Collections.Generic;

namespace Barette.Library.Client {
	/// <summary>
	/// Description résumée de Class1.
	/// </summary>
	public class Customer : IComparable {
		SeanceCollection _Seance = null;
        SeanceCollection _SeanceTheorique = null;
		PaimentCollection _Paiment = null;

		/// <summary>
		/// Information General
		/// </summary>
		private string _ContratNumber;
		private string _AttestationNumber1;
        private string _AttestationNumber2;
        private DateTime _DateAttestation1 = DateTime.Now;
        private DateTime _DateAttestation2 = DateTime.Now; 
		private DateTime _InscriptionDate;
		private bool _ClientNull;
        private DateTime _dateExpiration;
        private DateTime _dateDebutCours;

		/// <summary>
		/// Information sur le client
		/// </summary>
		private string _Name;
		private string _FirstName;
		private string _StreetName;
		private string _StreetApp;
		private string _StreetNumber;
		private string _City;
		private string _Phone;
		private string _PhoneBureau;
		private string _Notes;
		private string _CodePostal;
        private DateTime _dateNaissance;
        private int _NumeroGroupe;
        private string _email;
		
		/// <summary>
		/// Disponibilité
		/// </summary>
		private bool _DisponibilityAM = false;
		private bool _DisponibilityPM = false;
		private bool _DisponibilitySoirer = false;
		private bool _DisponibilitySamedi = false;
		private bool _DisponibilityDimanche = false;

		/// <summary>
		/// Information sur le solde
		/// </summary>
		private string _Solde = "";
		private string _LastRecuNumber = "";
		private string _MontantCours = "";

		/// <summary>
		/// Location de vehicule
		/// </summary>
		private bool _LocationMoto = false;
		private bool _LocationAutomobile = false;
		private string _MontantLocation;
		private bool _BVA = false;
		private DateTime _BVADate;

		/// <summary>
		/// Information sur l'ecole de conduite
		/// </summary>
		private string _NoPermis;
		private DateTime _DateTemporaire;
		private bool _HaveTemporaire;

        /// <summary>
        /// Taux horaire
        /// </summary>
        private string _TauxhorairePratique = "";
        private string _TauxHoraireTheorique = "";
        
		/// <summary>
		/// Type de vehicule
		/// </summary>
		private VehiculeType _VehiculeType = VehiculeType.Automatique;
		private string _No6r;

		/// <summary>
		/// Type de profile
		/// </summary>
		private ProfileType _ProfileType = ProfileType.Actif;

        /// <summary>
        /// Program de moto utilisé par le client
        /// </summary>
        private ProgramMoto _ProgramMoto = ProgramMoto.Nothing;

		/// <summary>
		/// Constructeur
		/// </summary>
		public Customer() {
            _Seance = new SeanceCollection();
            _Paiment = new PaimentCollection();
            _SeanceTheorique = new SeanceCollection();

            Email = "";
            _AttestationNumber1 = "";
            _AttestationNumber2 = "";
            _BVA = false;
            _BVADate = DateTime.Now;
            _City = "";
            _ClientNull = false;
            _CodePostal = "";
            _ContratNumber = "";
            _DateAttestation1 = DateTime.Now;
            _DateAttestation2 = DateTime.Now;
            _dateDebutCours = DateTime.Now;
            _dateExpiration = DateTime.Now;
            _dateNaissance = DateTime.Now;
            _DateTemporaire = DateTime.Now;
            _DisponibilityAM = false;
            _DisponibilityPM = false;
            _DisponibilityDimanche = false;
            _DisponibilitySamedi = false;
            _DisponibilitySoirer = false;
            _FirstName = "";
            _HaveTemporaire = false;
            _InscriptionDate = DateTime.Now;
            _LastRecuNumber = "";
            _LocationAutomobile = false;
            _LocationMoto = false;
            _MontantCours = "";
            _Name = "";
            _No6r = "";
            _NoPermis = "";
            _Notes = "";
            _NumeroGroupe = 0;
            _Phone = "";
            _PhoneBureau = "";
            _ProfileType = ProfileType.Nothing;
            _Solde = "";
            _StreetApp = "";
            _StreetName = "";
            _StreetNumber = "";
            _TauxhorairePratique = "";
            _TauxHoraireTheorique = "";
            _VehiculeType =  VehiculeType.Nothing;
		}

		#region Property
		public PaimentCollection Paiment{
			get{
				return _Paiment;
			}
			set{
                _Paiment = value;
			}
		}

		public SeanceCollection Seances{
			get{
				return _Seance;
			}
			set{
                _Seance = value;
			}
		}
        
        public SeanceCollection SeancesTheorique {
            get {
                return _SeanceTheorique;
            }
            set {
                _SeanceTheorique = value;
            }
        }

		public string Name{
			get{
                return _Name;
			}
			set{
                _Name = value;
			}
		}

        public int NumeroGroupe {
            get {
                return _NumeroGroupe;
            }
            set {
                _NumeroGroupe = value;
            }
        }

		public string TauxHorairePratique{
			get{
                return _TauxhorairePratique;
			}
			set{
                _TauxhorairePratique = value;
			}
		}

		public string TauxHoraireTheorique{
			get{
                return _TauxHoraireTheorique;
			}
			set{
                _TauxHoraireTheorique = value;
			}
		}

		public string MontantCours{
			get{
                return _MontantCours;
			}
			set{
                _MontantCours = value;
			}
		}

		public string FirstName{
			get{
				return _FirstName;
			}
			set{
                _FirstName = value;
			}
		}

		public string StreetName{
			get{
				return _StreetName;
			}
			set{
                _StreetName = value;
			}
		}

		public string Notes{
			get{
				return _Notes;
			}
			set{
                _Notes = value;
			}
		}

		public string StreetApp{
			get{
				return _StreetApp;
			}
			set{
                _StreetApp = value;
			}
		}

        public string Email {
            get {
                return _email;
            }
            set {
                _email = value;
            }
        }

		public string StreetNumber{
			get{
				return _StreetNumber;
			}
			set{
                _StreetNumber = value;
			}
		}

		public string City{
			get{
				return _City;
			}
			set{
                _City = value;
			}
		}

		public string Phone{
			get{
				return _Phone;
			}
			set{
                _Phone = value;
			}
		}

        public ProgramMoto ProgramMoto
        {
			get{
                return _ProgramMoto;
			}
			set{
                _ProgramMoto = value;
			}
		}

		public string CodePostal{
			get{
				return _CodePostal;
			}
			set{
                _CodePostal = value;
			}
		}

		public string PhoneBureau{
			get{
				return _PhoneBureau;
			}
			set{
                _PhoneBureau = value;
			}
		}

		public string NumeroPermis{
			get{
				return _NoPermis;
			}
			set{
                _NoPermis = value;
			}
		}

		public bool ClientNull {
			get {
				return _ClientNull;
			}
			set {
                _ClientNull = value;
			}
		}


		public bool HaveTemporaire{
			get{
				return _HaveTemporaire;
			}
			set{
                _HaveTemporaire = value;
			}
		}

		public DateTime DateTemporaire{
			get{
				return _DateTemporaire;
			}
			set{
                _DateTemporaire = value;
			}
		}

        public DateTime DateExpiration {
            get {
                return _dateExpiration;
            }
            set {
                _dateExpiration = value;
            }
        }

        public DateTime DateAttestation1 {
            get {
                return _DateAttestation1;
            }
            set {
                _DateAttestation1 = value;
            }
        }

        public DateTime DateAttestation2 {
            get {
                return _DateAttestation2;
            }
            set {
                _DateAttestation2 = value;
            }
        }

        public DateTime DateDebutCours
        {
            get
            {
                return _dateDebutCours;
            }
            set
            {
                _dateDebutCours = value;
            }
        }
		
		public VehiculeType TypeVehicule{
			get{
				return _VehiculeType;
			}
			set{
                _VehiculeType = value;
			}
		}

		public string No6R{
			get{
				return _No6r;
			}
			set{
                _No6r = value;
			}
		}

		public string ContratNumber{
			get{
				return _ContratNumber;
			}
			set{
                _ContratNumber = value;
			}
		}

		public string AttestationNumber1 {
			get{
				return _AttestationNumber1;
			}
			set{
                _AttestationNumber1 = value;
			}
		}

        public string AttestationNumber2
        {
            get
            {
                return _AttestationNumber2;
            }
            set
            {
                _AttestationNumber2 = value;
            }
        }

		public DateTime DateInscription{
			get{
				return _InscriptionDate;
			}
			set{
                _InscriptionDate = value;
			}
		}

		public DateTime BVADate{
			get{
				return _BVADate;
			}
			set{
                _BVADate = value;
			}
		}

        public DateTime DateNaissance
        {
            get
            {
                return _dateNaissance;
            }
            set
            {
                _dateNaissance = value;
            }
        }

		public bool BVA{
			get{
				return _BVA;
			}
			set{
                _BVA = value;
			}
		}

		public bool DisponibilityAM{
			get{
				return _DisponibilityAM;
			}
			set{
                _DisponibilityAM = value;
			}
		}

		public bool DisponibilityPM{
			get{
				return _DisponibilityPM;
			}
			set{
                _DisponibilityPM = value;
			}
		}

		public bool DisponibilitySoirer{
			get{
				return _DisponibilitySoirer;
			}
			set{
                _DisponibilitySoirer = value;
			}
		}

		public bool DisponibilityDimanche{
			get{
				return _DisponibilityDimanche;
			}
			set{
                _DisponibilityDimanche = value;
			}
		}

        /// <summary>
        /// Set or Get si le client est toujours disponibles
        /// </summary>
        public bool DisponibilityAlway {
            get {

                if (_DisponibilityAM && _DisponibilityPM && _DisponibilitySoirer && DisponibilitySamedi && _DisponibilityDimanche)
                    return true;
                else
                    return false;               
            }
            set {
                _DisponibilityAM = _DisponibilityPM = _DisponibilitySoirer = DisponibilitySamedi = _DisponibilityDimanche = value;
            }
        }

		public bool DisponibilitySamedi{
			get{
				return _DisponibilitySamedi;
			}
			set{
                _DisponibilitySamedi = value;
			}
		}

		public ProfileType TypeClient{
			get{
				return _ProfileType;
			}
			set{
                _ProfileType = value;
			}
		}

		public string Solde{
			get{
				return _Solde;
			}
			set{
                _Solde = value;
			}
		}

		public string LastRecuNumber{
			get{
				return _LastRecuNumber;
			}
			set{
                _LastRecuNumber = value;
			}
		}

		
		public string MontantLocation{
			get{
				return _MontantLocation;
			}
			set{
                _MontantLocation = value;
			}
		}

		public bool LocationMoto{
			get{
				return _LocationMoto;
			}
			set{
                _LocationMoto = value;
			}
		}

		public bool LocationAutomobile{
			get{
				return _LocationAutomobile;
			}
			set{
                _LocationAutomobile = value;
			}
		}

		#endregion

		#region Methodes
		/// <summary>
		/// Obtien la seance demandé par le parametre seance number
		/// </summary>
		/// <param name="SeanceNumber">Numéro de seance</param>
		/// <returns>Retourne la seance demandé. Si la valeur est null, c'est qu'il n'a pas trouvé de seance correspondante</returns>
		public Seance GetSeance(int SeanceNumber) {
			for (int i = 0; i < Seances.Count; i++) {
				if (Seances[i].SceanceNumber == SeanceNumber) {
					return Seances[i];
				}
			}

			//Rien trouvé alors on retourne un null;
			return null;
		}

        /// <summary>
        /// Obtien la seance demandé par le parametre seance number
        /// </summary>
        /// <param name="SeanceNumber">Numéro de seance</param>
        /// <returns>Retourne la seance demandé. Si la valeur est null, c'est qu'il n'a pas trouvé de seance correspondante</returns>
        public Seance GetSeanceTheorique(int SeanceNumber)
        {
            for (int i = 0; i < SeancesTheorique.Count; i++)
            {
                if (SeancesTheorique[i].SceanceNumber == SeanceNumber)
                {
                    return SeancesTheorique[i];
                }
            }

            //Rien trouvé alors on retourne un null;
            return null;
        }

        /// <summary>
        /// Obtien la seance demandé par le parametre seance number
        /// </summary>
        /// <param name="SeanceNumber">Numéro de seance</param>
        /// <returns>Retourne la seance demandé. Si la valeur est null, c'est qu'il n'a pas trouvé de seance correspondante</returns>
        public Seance GetSeanceOrDefault(int SeanceNumber)
        {
            Seance seance = GetSeance(SeanceNumber);

            if (seance != null)
                return seance;
            else
                return new Seance();
        }

        /// <summary>
        /// Obtien la seance demandé par le parametre seance number
        /// </summary>
        /// <param name="SeanceNumber">Numéro de seance</param>
        /// <returns>Retourne la seance demandé. Si la valeur est null, c'est qu'il n'a pas trouvé de seance correspondante</returns>
        public Seance GetSeanceTheoriqueOrDefault(int SeanceNumber)
        {
            Seance seance = GetSeanceTheorique(SeanceNumber);

            if (seance != null)
                return seance;
            else
                return new Seance();
        }

        /// <summary>
        /// Obtient le solde du client
        /// Dans la prochaine version de cette fonction : Le calcule sera fait a partir de la liste de paiment.
        /// </summary>
        /// <returns></returns>
        public double GetSolde() {
			try {
				return Convert.ToDouble(Solde.Replace(" $", ""));
			} catch {
				return -1;
			}
		}

		/// <summary>
		/// Obtenir le solde a la date précisé
		/// </summary>
		/// <param name="DateSoldeMax"></param>
		/// <returns></returns>
		public decimal GetSolde(DateTime DateSoldeMax) {
			try {
				double solde = 0L; //solde a 0

				//Caculer le solde a la date demandé
				for (int i = 0; i < Paiment.Count; i++) {
					if (Paiment[i].DatePaiment.Date <= DateSoldeMax.Date) {
						solde += Paiment[i].Value;
					}
				}

				return Convert.ToDecimal((Convert.ToDouble(MontantCours.Replace(" $", "")) - solde)); 
			} catch {
				return -1;
			}
		}


		public string GetShortVehiculeType() {
			switch (TypeVehicule) {
				case VehiculeType.Automatique:
					return "Auto.";
				case VehiculeType.Cyclomoteur:
					return "Cam.";
				case VehiculeType.Manuel:
					return "Man.";
				case VehiculeType.Moto:
					return "Moto";
				case VehiculeType.Nothing:
					return "";
				default:
					return "";
			}
		}

        /// <summary>
        /// Retourne le nom complet
        /// </summary>
        /// <param name="reverse"></param>
        /// <returns></returns>
        public String GetFullName(bool reverse) {
            if (reverse)
                return FirstName + " " + Name;
            else
                return Name + " " + FirstName;
        }


        /// <summary>
        /// Donne le type de client
        /// </summary>
        public StudentGroup.GroupType GetCustomerType() {
            switch (TypeVehicule) {
                case VehiculeType.Automatique:
                    return StudentGroup.GroupType.Automobile;
                case VehiculeType.Automobile:
                    return StudentGroup.GroupType.Automobile;
                case VehiculeType.Cyclomoteur:
                    return StudentGroup.GroupType.Cyclomoteur;
                case VehiculeType.Manuel:
                    return StudentGroup.GroupType.Automobile;
                case VehiculeType.Moto:
                    return StudentGroup.GroupType.Moto;
                case VehiculeType.Nothing:
                    return StudentGroup.GroupType.Autre;
                default:
                    return StudentGroup.GroupType.Autre;
            }
        }

        public int CompareTo(object obj) {
            Customer otherCustomer = obj as Customer;
            if (otherCustomer != null)
                return ContratNumber.CompareTo(otherCustomer.ContratNumber);
            else
                throw new ArgumentException("Object is not a Temperature");
        }

        public Seance GetLastMoto2015Seance()
        {
            if (_VehiculeType == VehiculeType.Moto)
            {
                List<Seance> seanceList = new List<Seance>();

                foreach (Seance seance in this.Seances)
                    if (seance.Active)
                        seanceList.Add(seance);

                foreach (Seance seance in this.SeancesTheorique)
                    if (seance.Active)
                        seanceList.Add(seance);

                try
                {
                    return seanceList.OrderBy(s => s.SceanceNumber).Last();
                }
                catch { return null; }
            }

            return null;
        }

        public Seance GetLastSeanceTheorique()
        {
            List<Seance> seanceList = new List<Seance>();

            foreach (Seance seance in this.SeancesTheorique)
                if (seance.Active)
                    seanceList.Add(seance);

            try
            {
                return seanceList.OrderBy(s => s.SceanceNumber).Last();
            }
            catch { return null; }
        }

        public enum MotoSeanceType
        {
            Route,
            HorsRoute,
            All
        }

        public Seance GetLastSeancePratique(MotoSeanceType type = MotoSeanceType.All)
        {
            List<Seance> seanceList = new List<Seance>();

            switch(type){
                case MotoSeanceType.All:
                    foreach (Seance seance in this.Seances)
                        if (seance.Active)
                            seanceList.Add(seance);
                    break;
                case MotoSeanceType.HorsRoute:
                    foreach (Seance seance in this.Seances)
                        if (seance.Active && seance.SceanceNumber >= 1 && seance.SceanceNumber <= 4)
                            seanceList.Add(seance);
                    break;
                case MotoSeanceType.Route:
                    foreach (Seance seance in this.Seances)
                        if (seance.Active && seance.SceanceNumber >= 5 && seance.SceanceNumber <= 9)
                            seanceList.Add(seance);
                    break;
            }           

            try
            {
                return seanceList.OrderBy(s => s.SceanceNumber).Last();
            }
            catch { return null; }
        }

        #endregion
    }
}
