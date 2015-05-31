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
            _Employe = new Employe();

            //Information générale
            _Employe.NumeroEmploye = txtNumeroEmploye.Text;
            _Employe.Nom = txtName.Text;
            //this._Employe.Prenom = this.txtFirstName.Text;
            _Employe.NomAffichageRapport = txtFirstName.Text;
            _Employe.NAS = mtNAS.Text;
            _Employe.TauxHorraire = ctbSalaire.Text;
            _Employe.Telephone = txtPhoneNumber.Text;
            _Employe.TelephoneAutre = txtPhoneOther.Text;
            _Employe.Titre = cbTitre.Text;
            _Employe.NumeroPermis = txtPermis.Text;

            //Debut de la création de l'employé
            _Employe.AdultACharge = Convert.ToInt16(ntbAdultACharge.Text);
            _Employe.EnfantACharge = Convert.ToInt16(ntbEnfantACharge.Text);

            //Adresse
            _Employe.City = cbCity.Text;
            _Employe.CodePostal = txtCodePostal.Text;
            _Employe.StreetApp = txtAdressApp.Text;
            _Employe.StreetName = txtAdressStreet.Text;
            _Employe.StreetNumber = txtAdressNumber.Text;

            //Date
            _Employe.DateDernierJourTravailler = dtpLastDay.Value;
            _Employe.DateEmbauche = dtpFirstDay.Value;
            _Employe.DateNaissance = dtbDateNaissance.Value;

            _Employe.NatureEmploie = cbNatureEmploie.Text;
            _Employe.Notes = teNotes.RTFCode;

			//Situation familiale
			if (cbSituationFamiliale.Text == "Célibataire")
                _Employe.SituationFamiliale = FamilyStatus.Celibataire;
			else if (cbSituationFamiliale.Text == "Divorcé(e)")
                _Employe.SituationFamiliale = FamilyStatus.Divorce;
			else if (cbSituationFamiliale.Text == "Marié(e)")
                _Employe.SituationFamiliale = FamilyStatus.Marie;
			else if (cbSituationFamiliale.Text == "Union Libre")
                _Employe.SituationFamiliale = FamilyStatus.UnionLibre;
			else if (cbSituationFamiliale.Text == "Veuf(ve)")
                _Employe.SituationFamiliale = FamilyStatus.Veuf;

			//Type d'employe
			if (cbTypeContractuel.Checked)
                _Employe.TypeEmployer = TypeEmploye.Contractuel;
			else if (cbTypeDirigeant.Checked)
                _Employe.TypeEmployer = TypeEmploye.Dirigeant;
			else if (cbTypeTauxHorraire.Checked)
                _Employe.TypeEmployer = TypeEmploye.TauxHorraire;
		}

		/// <summary>
		/// Fabrication du control à partir de l'objet interne employé
		/// </summary>
		private void MakeControl() {

            //Information générale
            txtNumeroEmploye.Text = _Employe.NumeroEmploye;
            txtName.Text = _Employe.Nom;
            txtFirstName.Text = _Employe.NomAffichageRapport;
            mtNAS.Text = _Employe.NAS;
            ctbSalaire.Text = _Employe.TauxHorraire;
            txtPhoneNumber.Text = _Employe.Telephone;
            txtPhoneOther.Text = _Employe.TelephoneAutre;
            cbTitre.Text = _Employe.Titre;
            txtPermis.Text = _Employe.NumeroPermis;

            //Debut de la création de l'employé
            ntbAdultACharge.Text = _Employe.AdultACharge.ToString();
            ntbEnfantACharge.Text = _Employe.EnfantACharge.ToString();

            //Adresse
            cbCity.Text = _Employe.City;
            txtCodePostal.Text = _Employe.CodePostal;
            txtAdressApp.Text = _Employe.StreetApp;
            txtAdressStreet.Text = _Employe.StreetName;
            txtAdressNumber.Text = _Employe.StreetNumber;

			//Date
			try {
                dtpLastDay.Value = _Employe.DateDernierJourTravailler;
			} catch {
                dtpLastDay.Value = DateTime.Now;
			}

			try {
                dtpFirstDay.Value = _Employe.DateEmbauche;
			} catch {
                dtpFirstDay.Value = DateTime.Now;
			}

			try {
                dtbDateNaissance.Value = _Employe.DateNaissance;
			} catch {
                dtbDateNaissance.Value = DateTime.Now;
			}

            cbNatureEmploie.Text = _Employe.NatureEmploie;
            teNotes.RTFCode = _Employe.Notes;

			//Situation familiale
			switch (_Employe.SituationFamiliale) {
				case FamilyStatus.Celibataire:
                    cbSituationFamiliale.Text = "Célibataire";
					break;
				case FamilyStatus.Divorce:
                    cbSituationFamiliale.Text = "Divorcé(e)";
					break;
				case FamilyStatus.Marie:
                    cbSituationFamiliale.Text = "Marié(e)";
					break;
				case FamilyStatus.UnionLibre:
                    cbSituationFamiliale.Text = "Union Libre";
					break;
				case FamilyStatus.Veuf:
                    cbSituationFamiliale.Text = "Veuf(ve)";
					break;
			}

			//Type d'employe
			switch (_Employe.TypeEmployer) {
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
            _Employe = new Employe();

            //Information générale
            txtNumeroEmploye.Text = "";
            txtName.Text = "";
            txtFirstName.Text = "";
            mtNAS.Text = "";
            ctbSalaire.Text = "";
            txtPhoneNumber.Text = "";
            txtPhoneOther.Text = "";
            cbTitre.Text = "";
            txtPermis.Text = "";

            //Debut de la création de l'employé
            ntbAdultACharge.Text = "0";
            ntbEnfantACharge.Text = "0";

            //Adresse
            cbCity.Text = "";
            txtCodePostal.Text = "";
            txtAdressApp.Text = "";
            txtAdressStreet.Text = "";
            txtAdressNumber.Text = "";

            //Date
            dtpLastDay.Value = DateTime.Now;
            dtpFirstDay.Value = DateTime.Now;
            dtbDateNaissance.Value = DateTime.Now;

            cbNatureEmploie.Text = "";
            cbSituationFamiliale.Text = "";
            teNotes.RTFCode = "";

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
				return _Employe; 				
			}
			set {
                _Employe = value;
				MakeControl();
			}
		}
		#endregion

		private void cbLastDay_CheckedChanged(object sender, EventArgs e) {
			dtpLastDay.Enabled = cbLastDay.Checked;
		}
	}
}
