using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using Barette.Library.Employer;

namespace Barette.Library.UserControls {
	public partial class EmployeControl : UserControl {
		private Employe _Employe = new Employe();

		public EmployeControl() {
			InitializeComponent();
		}

		private void cmdNow_Click(object sender, EventArgs e)
		{
		
		}

		private void txtFirstName_TextChanged(object sender, EventArgs e)
		{

		}

		#region Methodes
		/// <summary>
		/// Fabrication d'un employe à partir des données du control
		/// </summary>
		private void MakeEmploye() {
			//Creation de l'objet
			this._Employe = new Employe();

			//Information générale
			this._Employe.NumeroEmploye = this.txtNumeroEmploye.Text;
			this._Employe.Nom = this.txtName.Text;
			this._Employe.Prenom = this.txtFirstName.Text;
			this._Employe.NAS = this.mtNAS.Text;
			this._Employe.TauxHorraire = this.ctbSalaire.Text;
			this._Employe.Telephone = this.txtPhoneNumber.Text;
			this._Employe.TelephoneAutre = this.txtPhoneOther.Text;
			this._Employe.Titre = this.cbTitre.Text;
			
			//Debut de la création de l'employé
			this._Employe.AdultACharge = Convert.ToInt16(this.ntbAdultACharge.Text);
			this._Employe.EnfantACharge = Convert.ToInt16(this.ntbEnfantACharge.Text);

			//Adresse
			this._Employe.City = this.cbCity.Text;
			this._Employe.CodePostal = this.txtCodePostal.Text;
			this._Employe.StreetApp = this.txtAdressApp.Text;
			this._Employe.StreetName = this.txtAdressStreet.Text;
			this._Employe.StreetNumber = this.txtAdressNumber.Text;

			//Date
			this._Employe.DateDernierJourTravailler = this.dtpLastDay.Value;
			this._Employe.DateEmbauche = this.dtpFirstDay.Value;
			this._Employe.DateNaissance = this.dtbDateNaissance.Value;

			this._Employe.NatureEmploie = this.cbNatureEmploie.Text;
			this._Employe.Notes = this.teNotes.RTFCode;

			//Situation familiale
			if (this.cbSituationFamiliale.Text == "Célibataire")
				this._Employe.SituationFamiliale = FamilyStatus.Celibataire;
			else if (this.cbSituationFamiliale.Text == "Divorcé(e)")
				this._Employe.SituationFamiliale = FamilyStatus.Divorce;
			else if (this.cbSituationFamiliale.Text == "Marié(e)")
				this._Employe.SituationFamiliale = FamilyStatus.Marie;
			else if (this.cbSituationFamiliale.Text == "Union Libre")
				this._Employe.SituationFamiliale = FamilyStatus.UnionLibre;
			else if (this.cbSituationFamiliale.Text == "Veuf(ve)")
				this._Employe.SituationFamiliale = FamilyStatus.Veuf;

			//Type d'employe
			if (cbTypeContractuel.Checked)
				this._Employe.TypeEmployer = TypeEmploye.Contractuel;
			else if (cbTypeDirigeant.Checked)
				this._Employe.TypeEmployer = TypeEmploye.Dirigeant;
			else if (cbTypeTauxHorraire.Checked)
				this._Employe.TypeEmployer = TypeEmploye.TauxHorraire;
		}

		/// <summary>
		/// Fabrication du control à partir de l'objet interne employé
		/// </summary>
		private void MakeControl() {

			//Information générale
			this.txtNumeroEmploye.Text = this._Employe.NumeroEmploye;
			this.txtName.Text = this._Employe.Nom;
			this.txtFirstName.Text = this._Employe.Prenom;
			this.mtNAS.Text = this._Employe.NAS;
			this.ctbSalaire.Text = this._Employe.TauxHorraire;
			this.txtPhoneNumber.Text = this._Employe.Telephone;
			this.txtPhoneOther.Text = this._Employe.TelephoneAutre;
			this.cbTitre.Text = this._Employe.Titre;

			//Debut de la création de l'employé
			this.ntbAdultACharge.Text = this._Employe.AdultACharge.ToString();
			this.ntbEnfantACharge.Text = this._Employe.EnfantACharge.ToString();

			//Adresse
			this.cbCity.Text = this._Employe.City;
			this.txtCodePostal.Text = this._Employe.CodePostal;
			this.txtAdressApp.Text = this._Employe.StreetApp;
			this.txtAdressStreet.Text = this._Employe.StreetName;
			this.txtAdressNumber.Text = this._Employe.StreetNumber;

			//Date
			try {
				this.dtpLastDay.Value = this._Employe.DateDernierJourTravailler;
			} catch {
				this.dtpLastDay.Value = DateTime.Now;
			}

			try {
				this.dtpFirstDay.Value = this._Employe.DateEmbauche;
			} catch {
				this.dtpFirstDay.Value = DateTime.Now;
			}

			try {
				this.dtbDateNaissance.Value = this._Employe.DateNaissance;
			} catch {
				this.dtbDateNaissance.Value = DateTime.Now;
			}

			this.cbNatureEmploie.Text = this._Employe.NatureEmploie;
			this.teNotes.RTFCode = this._Employe.Notes;

			//Situation familiale
			switch (this._Employe.SituationFamiliale) {
				case FamilyStatus.Celibataire:
					this.cbSituationFamiliale.Text = "Célibataire";
					break;
				case FamilyStatus.Divorce:
					this.cbSituationFamiliale.Text = "Divorcé(e)";
					break;
				case FamilyStatus.Marie:
					this.cbSituationFamiliale.Text = "Marié(e)";
					break;
				case FamilyStatus.UnionLibre:
					this.cbSituationFamiliale.Text = "Union Libre";
					break;
				case FamilyStatus.Veuf:
					this.cbSituationFamiliale.Text = "Veuf(ve)";
					break;
			}

			//Type d'employe
			switch (this._Employe.TypeEmployer) {
				case TypeEmploye.Contractuel:
					cbTypeContractuel.Checked = true;
					break;
				case TypeEmploye.Dirigeant:
					cbTypeDirigeant.Checked = true;
					break;
				case TypeEmploye.TauxHorraire:
					cbTypeTauxHorraire.Checked = true;
					break;
			}			
		}

		/// <summary>
		/// Ferme l'employe, efface tous les données dans les controls
		/// </summary>
		public void CloseEmploye() {
			//reset l<objet a 
			this._Employe = new Employe();

			//Information générale
			this.txtNumeroEmploye.Text = "";
			this.txtName.Text = "";
			this.txtFirstName.Text = "";
			this.mtNAS.Text = "";
			this.ctbSalaire.Text = "";
			this.txtPhoneNumber.Text = "";
			this.txtPhoneOther.Text = "";
			this.cbTitre.Text = "";

			//Debut de la création de l'employé
			this.ntbAdultACharge.Text = "0";
			this.ntbEnfantACharge.Text = "0";

			//Adresse
			this.cbCity.Text = "";
			this.txtCodePostal.Text = "";
			this.txtAdressApp.Text = "";
			this.txtAdressStreet.Text = "";
			this.txtAdressNumber.Text = "";

			//Date
			this.dtpLastDay.Value = DateTime.Now;
			this.dtpFirstDay.Value = DateTime.Now;
			this.dtbDateNaissance.Value = DateTime.Now;

			this.cbNatureEmploie.Text = "";
			this.cbSituationFamiliale.Text = "";
			this.teNotes.RTFCode = "";

			//Type d'employe
			cbTypeContractuel.Checked =	
				cbTypeDirigeant.Checked = 
				cbTypeTauxHorraire.Checked = false;

		}
		#endregion

		#region Propriétés
		/// <summary>
		/// Sert à prendre et a laisser un objet client dans le control.
		/// </summary>
		public Employe Employer {
			get {
				MakeEmploye();
				return this._Employe; 				
			}
			set {
				this._Employe = value;
				MakeControl();
			}
		}
		#endregion

		private void cbLastDay_CheckedChanged(object sender, EventArgs e) {
			dtpLastDay.Enabled = cbLastDay.Checked;
		}
	}
}
