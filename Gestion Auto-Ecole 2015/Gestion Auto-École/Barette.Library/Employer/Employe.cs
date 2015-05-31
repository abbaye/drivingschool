using System;

namespace Barette.Library.Employer {
	/// <summary>
	/// -Des Enumération, et de vrai propriété aurait pu être créé mais il n'était pas vraiment utile
	/// -S'il veux investire plus ($$$), ce module sera retravaillé et grandement amélioré
	/// -Aucune validation sur les donné est fait dans cette objet. encore une fois ca 
	/// déprendra de l'investisement.
	/// </summary>
	public class Employe {
		
		public string NumeroEmploye;

		public string Nom;
		public string Prenom;
        public string NomAffichageRapport;
        public string NumeroPermis;

        /// <summary>
        /// Titre dans l'entreprise
        /// </summary>
        public string Titre;

		/// <summary>
		/// Nature de l'emploie
		/// </summary>
		public string NatureEmploie;

		/// <summary>
		/// Téléphone de la maison
		/// </summary>
		public string Telephone;

		/// <summary>
		/// Autre numéro Téléphone
		/// </summary>
		public string TelephoneAutre;

		/// <summary>
		/// Notes consernant l'employé
		/// </summary>
		public string Notes;
		
		/// <summary>
		/// Salaire horraire.
		/// </summary>
		public string TauxHorraire;

		/// <summary>
		/// Quel type de salaire.
		/// </summary>
		public TypeEmploye TypeEmployer;

		public DateTime DateEmbauche;
		public DateTime DateDernierJourTravailler;

		/// <summary>
		/// Adresse
		/// </summary>
		public string StreetName;
		public string StreetApp;
		public string StreetNumber;
		public string City;
		public string CodePostal;

		public int EnfantACharge = 0;
		public int AdultACharge = 0;

		/// <summary>
		/// Situation familiale
		/// </summary>
		public FamilyStatus SituationFamiliale;
		/// <summary>
		/// Numéro d'assurance sociale
		/// </summary>
		public string NAS;
		/// <summary>
		/// Date de Naissance;
		/// </summary>
		public DateTime DateNaissance;
        
		/// <summary>
		/// Constructeur
		/// </summary>
		public Employe() {

		}
	}
}
