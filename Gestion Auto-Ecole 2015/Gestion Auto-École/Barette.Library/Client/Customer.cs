using System;
using System.Collections;

using Barette.Library.Collections;

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
			this._Seance = new SeanceCollection();
			this._Paiment = new PaimentCollection();
            this._SeanceTheorique = new SeanceCollection();

            this.Email = "";
            this._AttestationNumber1 = "";
            this._AttestationNumber2 = "";
            this._BVA = false;
            this._BVADate = DateTime.Now;
            this._City = "";
            this._ClientNull = false;
            this._CodePostal = "";
            this._ContratNumber = "";
            this._DateAttestation1 = DateTime.Now;
            this._DateAttestation2 = DateTime.Now;
            this._dateDebutCours = DateTime.Now;
            this._dateExpiration = DateTime.Now;
            this._dateNaissance = DateTime.Now;
            this._DateTemporaire = DateTime.Now;
            this._DisponibilityAM = false;
            this._DisponibilityPM = false;
            this._DisponibilityDimanche = false;
            this._DisponibilitySamedi = false;
            this._DisponibilitySoirer = false;
            this._FirstName = "";
            this._HaveTemporaire = false;
            this._InscriptionDate = DateTime.Now;
            this._LastRecuNumber = "";
            this._LocationAutomobile = false;
            this._LocationMoto = false;
            this._MontantCours = "";
            this._Name = "";
            this._No6r = "";
            this._NoPermis = "";
            this._Notes = "";
            this._NumeroGroupe = 0;
            this._Phone = "";
            this._PhoneBureau = "";
            this._ProfileType = ProfileType.Nothing;
            this._Solde = "";
            this._StreetApp = "";
            this._StreetName = "";
            this._StreetNumber = "";
            this._TauxhorairePratique = "";
            this._TauxHoraireTheorique = "";
            this._VehiculeType =  VehiculeType.Nothing;
		}

		#region Property
		public PaimentCollection Paiment{
			get{
				return this._Paiment;
			}
			set{
				this._Paiment = value;
			}
		}

		public SeanceCollection Seances{
			get{
				return this._Seance;
			}
			set{
				this._Seance = value;
			}
		}

        public SeanceCollection SeancesTheorique {
            get {
                return this._SeanceTheorique;
            }
            set {
                this._SeanceTheorique = value;
            }
        }

		public string Name{
			get{
                return this._Name;
			}
			set{
				this._Name = value;
			}
		}

        public int NumeroGroupe {
            get {
                return this._NumeroGroupe;
            }
            set {
                this._NumeroGroupe = value;
            }
        }

		public string TauxHorairePratique{
			get{
                return this._TauxhorairePratique;
			}
			set{
				this._TauxhorairePratique = value;
			}
		}

		public string TauxHoraireTheorique{
			get{
                return this._TauxHoraireTheorique;
			}
			set{
				this._TauxHoraireTheorique = value;
			}
		}

		public string MontantCours{
			get{
                return this._MontantCours;
			}
			set{
				this._MontantCours = value;
			}
		}

		public string FirstName{
			get{
				return this._FirstName;
			}
			set{
				this._FirstName = value;
			}
		}

		public string StreetName{
			get{
				return this._StreetName;
			}
			set{
				this._StreetName = value;
			}
		}

		public string Notes{
			get{
				return this._Notes;
			}
			set{
				this._Notes = value;
			}
		}

		public string StreetApp{
			get{
				return this._StreetApp;
			}
			set{
				this._StreetApp = value;
			}
		}

        public string Email {
            get {
                return this._email;
            }
            set {
                this._email = value;
            }
        }

		public string StreetNumber{
			get{
				return this._StreetNumber;
			}
			set{
				this._StreetNumber = value;
			}
		}

		public string City{
			get{
				return this._City;
			}
			set{
				this._City = value;
			}
		}

		public string Phone{
			get{
				return this._Phone;
			}
			set{
				this._Phone = value;
			}
		}

        public ProgramMoto ProgramMoto
        {
			get{
                return this._ProgramMoto;
			}
			set{
                this._ProgramMoto = value;
			}
		}

		public string CodePostal{
			get{
				return this._CodePostal;
			}
			set{
				this._CodePostal = value;
			}
		}

		public string PhoneBureau{
			get{
				return this._PhoneBureau;
			}
			set{
				this._PhoneBureau = value;
			}
		}

		public string NumeroPermis{
			get{
				return this._NoPermis;
			}
			set{
				this._NoPermis = value;
			}
		}

		public bool ClientNull {
			get {
				return this._ClientNull;
			}
			set {
				this._ClientNull = value;
			}
		}


		public bool HaveTemporaire{
			get{
				return this._HaveTemporaire;
			}
			set{
				this._HaveTemporaire = value;
			}
		}

		public DateTime DateTemporaire{
			get{
				return this._DateTemporaire;
			}
			set{
				this._DateTemporaire = value;
			}
		}

        public DateTime DateExpiration {
            get {
                return this._dateExpiration;
            }
            set {
                this._dateExpiration = value;
            }
        }

        public DateTime DateAttestation1 {
            get {
                return this._DateAttestation1;
            }
            set {
                this._DateAttestation1 = value;
            }
        }

        public DateTime DateAttestation2 {
            get {
                return this._DateAttestation2;
            }
            set {
                this._DateAttestation2 = value;
            }
        }

        public DateTime DateDebutCours
        {
            get
            {
                return this._dateDebutCours;
            }
            set
            {
                this._dateDebutCours = value;
            }
        }
		
		public VehiculeType TypeVehicule{
			get{
				return this._VehiculeType;
			}
			set{
				this._VehiculeType = value;
			}
		}

		public string No6R{
			get{
				return this._No6r;
			}
			set{
				this._No6r = value;
			}
		}

		public string ContratNumber{
			get{
				return this._ContratNumber;
			}
			set{
				this._ContratNumber = value;
			}
		}

		public string AttestationNumber1 {
			get{
				return this._AttestationNumber1;
			}
			set{
				this._AttestationNumber1 = value;
			}
		}

        public string AttestationNumber2
        {
            get
            {
                return this._AttestationNumber2;
            }
            set
            {
                this._AttestationNumber2 = value;
            }
        }

		public DateTime DateInscription{
			get{
				return this._InscriptionDate;
			}
			set{
				this._InscriptionDate = value;
			}
		}

		public DateTime BVADate{
			get{
				return this._BVADate;
			}
			set{
				this._BVADate = value;
			}
		}

        public DateTime DateNaissance
        {
            get
            {
                return this._dateNaissance;
            }
            set
            {
                this._dateNaissance = value;
            }
        }

		public bool BVA{
			get{
				return this._BVA;
			}
			set{
				this._BVA = value;
			}
		}

		public bool DisponibilityAM{
			get{
				return this._DisponibilityAM;
			}
			set{
				this._DisponibilityAM = value;
			}
		}

		public bool DisponibilityPM{
			get{
				return this._DisponibilityPM;
			}
			set{
				this._DisponibilityPM = value;
			}
		}

		public bool DisponibilitySoirer{
			get{
				return this._DisponibilitySoirer;
			}
			set{
				this._DisponibilitySoirer = value;
			}
		}

		public bool DisponibilityDimanche{
			get{
				return this._DisponibilityDimanche;
			}
			set{
				this._DisponibilityDimanche = value;
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
				return this._DisponibilitySamedi;
			}
			set{
				this._DisponibilitySamedi = value;
			}
		}

		public ProfileType TypeClient{
			get{
				return this._ProfileType;
			}
			set{
				this._ProfileType = value;
			}
		}

		public string Solde{
			get{
				return this._Solde;
			}
			set{
				this._Solde = value;
			}
		}

		public string LastRecuNumber{
			get{
				return this._LastRecuNumber;
			}
			set{
				this._LastRecuNumber = value;
			}
		}

		
		public string MontantLocation{
			get{
				return this._MontantLocation;
			}
			set{
				this._MontantLocation = value;
			}
		}

		public bool LocationMoto{
			get{
				return this._LocationMoto;
			}
			set{
				this._LocationMoto = value;
			}
		}

		public bool LocationAutomobile{
			get{
				return this._LocationAutomobile;
			}
			set{
				this._LocationAutomobile = value;
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
			for (int i = 0; i < this.Seances.Count; i++) {
				if (this.Seances[i].SceanceNumber == SeanceNumber) {
					return this.Seances[i];
				}
			}

			//Rien trouvé alors on retourne un null;
			return null;
		}

		/// <summary>
		/// Obtient le solde du client
		/// Dans la prochaine version de cette fonction : Le calcule sera fait a partir de la liste de paiment.
		/// </summary>
		/// <returns></returns>
		public double GetSolde() {
			try {
				return Convert.ToDouble(this.Solde.Replace(" $", ""));
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
				for (int i = 0; i < this.Paiment.Count; i++) {
					if (this.Paiment[i].DatePaiment.Date <= DateSoldeMax.Date) {
						solde += this.Paiment[i].Value;
					}
				}

				return Convert.ToDecimal((Convert.ToDouble(this.MontantCours.Replace(" $", "")) - solde)); 
			} catch {
				return -1;
			}
		}


		public string GetShortVehiculeType() {
			switch (this.TypeVehicule) {
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
                return this.FirstName + " " + this.Name;
            else
                return this.Name + " " + this.FirstName;
        }


        /// <summary>
        /// Donne le type de client
        /// </summary>
        public StudentGroup.GroupType GetCustomerType() {
            switch (this.TypeVehicule) {
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
                return this.ContratNumber.CompareTo(otherCustomer.ContratNumber);
            else
                throw new ArgumentException("Object is not a Temperature");
        }


		#endregion
	}
}
