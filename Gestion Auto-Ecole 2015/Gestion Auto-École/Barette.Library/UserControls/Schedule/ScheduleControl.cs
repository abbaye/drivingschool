using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using Barette.Library.Client;
using Barette.Library.Collections;

namespace Barette.Library.UserControls.Schedule {
	public partial class ScheduleControl : UserControl {
		private CustomerCollection _ClientList = null;
		private EmployeCollection _EmployeList = null;
		private DateTime _Date = DateTime.Now;
		private string _EmployeName = "";
		private DateTime[] _AnnualDates; 
		
		/// <summary>
		/// liste de cours de la journée
		/// </summary>
		private SeanceCollection _CoursList = null;

		/// <summary>
		/// Cette événement apparait quand du text a été changé dans les notes avec le clavier
		/// </summary>
		public event EventHandler NotesChanged;

		/// <summary>
		/// Cette évenement survient quand un item est selectionné dans la liste
		/// </summary>
		public event EventHandler ItemSelected;

		/// <summary>
		/// DoubleClick sur la liste
		/// </summary>
		public event MouseEventHandler MouseItemDoubleClick;
	
		public ScheduleControl() {
			InitializeComponent();
		}

		public Seance SelectedSeance{
			get {
				return new Seance();
			}
		}

		/// <summary>
		/// Date à afficher
		/// </summary>
		public DateTime Date {
			get {
				return this._Date;
			}
			set {
				this._Date = value;
				UpdateView();
			}
		}

		public CustomerCollection ClientList {			
			set {
				this._ClientList = value;
			}
		}

		public EmployeCollection EmployeList {
			set {
				this._EmployeList = value;
			}
		}

		/// <summary>
		/// Date avec des commentaires
		/// </summary>
		public DateTime[] AnnualDate {
			set {
				this._AnnualDates = value; 
			}
		}

		public string EmployeName {
			set {
				this._EmployeName = value;
				UpdateView();
			}
		}

		public string Notes {
			get {
				return txtNotes.Text; 
			}
			set {
				txtNotes.Text = value;
			}
		}

		public void UpdateView() {
			// Met a jour la date
			lblDate.Text = DateTimeFunc.DayOfWeekFRLong(this._Date.DayOfWeek) + " " + this._Date.Date.ToLongDateString();

			//Load la liste de cours
			LoadCoursList();

			//Inscrit le total de cours de la journées
			lblTotalCours.Text = this._CoursList.Count + " Cours";
		}

		//Chargement de la liste de cours
		private void LoadCoursList() {
			Seance cours;

			listViewEx1.Items.Clear();

			//Notes
			//txtNotes.Text = "";
			//txtNotes.Text = GetNotes(vCalendar.SelectionStart.Date);

			//Vide la liste de cours
			this._CoursList = new SeanceCollection();
			this._CoursList.Clear();

			//Boucle dans tous les clients
			if (this._ClientList != null)
                for (int i = 0; i < this._ClientList.Count; i++)
                    {
                    if (this._ClientList[i].TypeClient != ProfileType.CoursTerminer)
                        for (int j = 0; j < this._ClientList[i].Seances.Count; j++)
                            {
                            cours = this._ClientList[i].Seances[j];

                            //Voila nous avons trouvé une séance qui est de cette employé
                            if (cours.Employer != "")
                                if ((cours.Employer == this._EmployeName) &&
                                    (cours.DateHeure.Date == this._Date.Date) &&
                                    (cours.Active == true))
                                    {
                                    cours.Client = this._ClientList[i];
                                    _CoursList.Add(cours);
                                    //AddCoursToList(this._ClientList[i], cours);
                                    }
                            }
                    }

			//Placer les cours dans la liste
			PlaceCours();
		}

		/// <summary>
		/// Ajoute un cours a la liste
		/// </summary>
		/// <param name="client"></param>
		/// <param name="cours"></param>
		private void AddCoursToList(Customer client, Seance cours) {
			ListViewItem itm = new ListViewItem();

			itm.Text = DateTimeFunc.FormatHour(cours.DateHeure);

			itm.Tag = client;
			itm.SubItems.Add(client.ContratNumber);
			itm.SubItems.Add(client.Name + " " + client.FirstName);
			itm.SubItems.Add(cours.SceanceNumber.ToString());
			itm.SubItems.Add(cours.Code);

			listViewEx1.Items.Add(itm);
		}

		/// <summary>
		/// Ajoute une entrée vide à la liste
		/// </summary>
		private void AddCoursToList(DateTime hours) {
			ListViewItem itm = new ListViewItem();

			itm.Text = DateTimeFunc.FormatHour(hours);

			//itm.Tag = client;
			itm.SubItems.Add("");
			itm.SubItems.Add("");
			itm.SubItems.Add("");
			itm.SubItems.Add("");

			listViewEx1.Items.Add(itm);
		}

		private void PlaceCours() {
			//Mettre l'heure de départ à 7h00 de la date du ScheduleControl
			DateTime HeureDepart = new DateTime(this._Date.Year, this._Date.Month, this._Date.Day, 7, 0, 0);
			DateTime HeureCourant = HeureDepart; //Heure courant dans l'iteration
			Seance cours = null;

			listViewEx1.Items.Clear();

			while (DateTimeFunc.FormatHour(HeureCourant) != "22h30") { //max 22h00
				cours = GetCoursBetweenFromList(HeureCourant);
				if (cours != null) { //Cours à imprimer
					AddCoursToList(cours.Client, cours);
				} else {
					AddCoursToList(HeureCourant); 
					//Hours = DateTimeFunc.FormatHour(HeureCourant);
					//Add hours sans cours
				}

				cours = null;
				//Ajoute 30 min a l'heure courante
				HeureCourant = HeureCourant.AddMinutes(30);
			}
		}

		/// <summary>
		/// Verifie si il y a un cours a imprimer dans la liste
		/// </summary>
		/// <returns>Retourne la séance qui sera imprimé. Si la valeur est null, c'est que rien n'a été trouvé</returns>
		private Seance GetCoursBetweenFromList(DateTime HeureCourant) {
			//DateTime HeureBasse =  HeureCourant;
			DateTime HeureHaute = HeureCourant.AddMinutes(30);
			DateTime HeureItem = new DateTime();

			for (int i = 0; i < this._CoursList.Count; i++) {
				//HeureItem = DateTimeFunc.HoursFromString(DateTimeFunc.FormatHour(this._CoursList[i].DateHeure));
				HeureItem = this._CoursList[i].DateHeure;

				if (DateTimeFunc.HoursIsBetween(HeureCourant, HeureItem, HeureHaute)) {
					//Obtenir le client et le numéro de seance
					if (this._CoursList[i].Client != null)
						return this._CoursList[i];
				}
			}

			//rien trouv/
			return null;
		}

		private void txtNotes_KeyUp(object sender, KeyEventArgs e) {
			NotesChanged(sender, e);
		}

		/// <summary>
		/// Obtenir de l'information sur l'item sélectioné dans la list
		/// </summary>
		public ScheduleInfos SelectedItemInfos {
			get {
				if (listViewEx1.SelectedItems.Count > 0) {
					ScheduleInfos infos = new ScheduleInfos();
					Customer client = null;

					infos.Heures = DateTime.Parse(listViewEx1.SelectedItems[0].Text.Replace("h", ":"));
					infos.ClientName = listViewEx1.SelectedItems[0].SubItems[2].Text;
					infos.SeanceNumber = listViewEx1.SelectedItems[0].SubItems[3].Text;
					infos.SeanceCode = listViewEx1.SelectedItems[0].SubItems[4].Text;

					client = this._ClientList.GetClient(listViewEx1.SelectedItems[0].SubItems[1].Text);
					if (client != null) {
						infos.PhoneNumber = client.Phone;
						infos.ContratNumber = client.ContratNumber;
					}

					if (infos.ContratNumber == "")
						return null;
					else
						return infos;
				} else
					return null;

			}
		}


		public ScheduleDescription HoraireDescription {
			get {
				ScheduleInfos infos;
				ScheduleDescription Description = new ScheduleDescription();
				Description.Jour = this._Date;
				Description.NomMoniteur = this._EmployeName;
				Customer client = null;

				//Créé la description detaille de la journée
				for (int i=0; i<listViewEx1.Items.Count; i++){
					infos = new ScheduleInfos();

					infos.Heures = DateTime.Parse(listViewEx1.Items[i].Text.Replace("h", ":"));
					infos.ClientName = listViewEx1.Items[i].SubItems[2].Text;										
					infos.SeanceNumber = listViewEx1.Items[i].SubItems[3].Text;
					infos.SeanceCode = listViewEx1.Items[i].SubItems[4].Text;
										
					client = this._ClientList.GetClient(listViewEx1.Items[i].SubItems[1].Text);
					if (client != null) {
						infos.PhoneNumber = client.Phone;
						infos.ContratNumber = client.ContratNumber;
					}

					Description.HoraireJour.Add(infos);
				}

				return Description;
			}
		}

		private void listViewEx1_SelectedIndexChanged(object sender, EventArgs e) {
			try {
				ItemSelected(sender, e);
			} catch {
			}
		}

		private void listViewEx1_MouseDoubleClick(object sender, MouseEventArgs e) {
			try {
				MouseItemDoubleClick(sender, e);
			} catch {
			}
		}
	}
}
