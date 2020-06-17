using System;
using System.Linq;

using Barette.Library.Collections;
using System.Collections.Generic;

namespace Barette.Library.Client
{
    /// <summary>
    /// Description résumée de Class1.
    /// </summary>
    public class Customer : IComparable
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        public Customer()
        {
            Seances = new SeanceCollection();
            Paiment = new PaimentCollection();
            SeancesTheorique = new SeanceCollection();

            Email = "";
            AttestationNumber1 = "";
            AttestationNumber2 = "";
            BVA = false;
            BVADate = DateTime.Now;
            City = "";
            IsSpyder = false;
            ClientNull = false;
            CodePostal = "";
            ContratNumber = "";
            DateAttestation1 = DateTime.Now;
            DateAttestation2 = DateTime.Now;
            DateDebutCours = DateTime.Now;
            DateExpiration = DateTime.Now;
            DateNaissance = DateTime.Now;
            DateTemporaire = DateTime.Now;
            DisponibilityAM = false;
            DisponibilityPM = false;
            DisponibilityDimanche = false;
            DisponibilitySamedi = false;
            DisponibilitySoirer = false;
            FirstName = "";
            HaveTemporaire = false;
            DateInscription = DateTime.Now;
            LastRecuNumber = "";
            LocationAutomobile = false;
            LocationMoto = false;
            MontantCours = "";
            Name = "";
            No6R = "";
            NumeroPermis = "";
            Notes = "";
            NumeroGroupe = 0;
            Phone = "";
            PhoneBureau = "";
            TypeClient = ProfileType.Nothing;
            Solde = "";
            StreetApp = "";
            StreetName = "";
            StreetNumber = "";
            TauxHorairePratique = "";
            TauxHoraireTheorique = "";
            TypeVehicule = VehiculeType.Nothing;
        }

        #region Property
        public PaimentCollection Paiment { get; set; } = null;

        public SeanceCollection Seances { get; set; } = null;

        public SeanceCollection SeancesTheorique { get; set; } = null;

        public string Name { get; set; }

        public int NumeroGroupe { get; set; }

        public string TauxHorairePratique { get; set; } = "";

        public string TauxHoraireTheorique { get; set; } = "";

        public string MontantCours { get; set; } = "";

        public string FirstName { get; set; }

        public string StreetName { get; set; }

        public string Notes { get; set; }

        public string StreetApp { get; set; }

        public string Email { get; set; }

        public string StreetNumber { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        public ProgramMoto ProgramMoto { get; set; } = ProgramMoto.Nothing;

        public string CodePostal { get; set; }

        public string PhoneBureau { get; set; }

        public string NumeroPermis { get; set; }

        public bool ClientNull { get; set; }


        public bool HaveTemporaire { get; set; }

        public DateTime DateTemporaire { get; set; }

        public DateTime DateExpiration { get; set; }

        public DateTime DateAttestation1 { get; set; } = DateTime.Now;

        public DateTime DateAttestation2 { get; set; } = DateTime.Now;

        public DateTime DateDebutCours { get; set; }

        public VehiculeType TypeVehicule { get; set; } = VehiculeType.Automatique;

        public bool IsSpyder { get; set; } = false;

        public string No6R { get; set; }

        public string ContratNumber { get; set; }

        public string AttestationNumber1 { get; set; }

        public string AttestationNumber2 { get; set; }

        public DateTime DateInscription { get; set; }

        public DateTime BVADate { get; set; }

        public DateTime DateNaissance { get; set; }

        public bool BVA { get; set; } = false;

        public bool DisponibilityAM { get; set; } = false;

        public bool DisponibilityPM { get; set; } = false;

        public bool DisponibilitySoirer { get; set; } = false;

        public bool DisponibilityDimanche { get; set; } = false;

        /// <summary>
        /// Set or Get si le client est toujours disponibles
        /// </summary>
        public bool DisponibilityAlway
        {
            get
            {
                return DisponibilityAM && DisponibilityPM && DisponibilitySoirer && DisponibilitySamedi && DisponibilityDimanche;
            }
            set
            {
                DisponibilityAM = DisponibilityPM = DisponibilitySoirer = DisponibilitySamedi = DisponibilityDimanche = value;
            }
        }

        public bool DisponibilitySamedi { get; set; } = false;

        public ProfileType TypeClient { get; set; } = ProfileType.Actif;

        public string Solde { get; set; } = "";

        public string LastRecuNumber { get; set; } = "";

        public string MontantLocation { get; set; }

        public bool LocationMoto { get; set; } = false;

        public bool LocationAutomobile { get; set; } = false;

        #endregion

        #region Methodes
        /// <summary>
        /// Obtien la seance demandé par le parametre seance number
        /// </summary>
        /// <param name="SeanceNumber">Numéro de seance</param>
        /// <returns>Retourne la seance demandé. Si la valeur est null, c'est qu'il n'a pas trouvé de seance correspondante</returns>
        public Seance GetSeance(int SeanceNumber)
        {
            for (int i = 0; i < Seances.Count; i++)
                if (Seances[i].SceanceNumber == SeanceNumber)
                    return Seances[i];

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
                if (SeancesTheorique[i].SceanceNumber == SeanceNumber)
                    return SeancesTheorique[i];

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

            return seance ?? new Seance();
        }

        /// <summary>
        /// Obtien la seance demandé par le parametre seance number
        /// </summary>
        /// <param name="SeanceNumber">Numéro de seance</param>
        /// <returns>Retourne la seance demandé. Si la valeur est null, c'est qu'il n'a pas trouvé de seance correspondante</returns>
        public Seance GetSeanceTheoriqueOrDefault(int SeanceNumber)
        {
            Seance seance = GetSeanceTheorique(SeanceNumber);

            return seance ?? new Seance();
        }

        /// <summary>
        /// Obtient le solde du client
        /// Dans la prochaine version de cette fonction : Le calcule sera fait a partir de la liste de paiment.
        /// </summary>
        public double GetSolde()
        {
            try
            {
                return Convert.ToDouble(Solde.Replace(" $", ""));
            }
            catch
            {
                return -1;
            }
        }

        /// <summary>
        /// Obtenir le solde a la date précisé
        /// </summary>
        public decimal GetSolde(DateTime DateSoldeMax)
        {
            try
            {
                double solde = 0L; //solde a 0

                //Caculer le solde a la date demandé
                for (int i = 0; i < Paiment.Count; i++)
                {
                    if (Paiment[i].DatePaiment.Date <= DateSoldeMax.Date)
                    {
                        solde += Paiment[i].Value;
                    }
                }

                return Convert.ToDecimal(Convert.ToDouble(MontantCours.Replace(" $", "")) - solde);
            }
            catch
            {
                return -1;
            }
        }

        public string GetShortVehiculeType()
        {
            switch (TypeVehicule)
            {
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
        public string GetFullName(bool reverse) =>
            reverse ? FirstName + " " + Name : Name + " " + FirstName;

        /// <summary>
        /// Donne le type de client
        /// </summary>
        public StudentGroup.GroupType GetCustomerType()
        {
            switch (TypeVehicule)
            {
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

        public int CompareTo(object obj)
        {
            Customer otherCustomer = obj as Customer;
            if (otherCustomer != null)
                return ContratNumber.CompareTo(otherCustomer.ContratNumber);
            else
                throw new ArgumentException("Object is not a Temperature");
        }

        public Seance GetLastMoto2015Seance()
        {
            if (TypeVehicule == VehiculeType.Moto)
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

            switch (type)
            {
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
