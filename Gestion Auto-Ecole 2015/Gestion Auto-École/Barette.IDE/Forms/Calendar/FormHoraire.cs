using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Linq;
using System.IO;

//Namespace du projet
using Barette.Library.Collections;
using Barette.Library.UserControls.Schedule;
using Barette.Library.Client;
using Barette.Library.Employer;
using Barette.Library;
using System.Collections;

namespace Barette.IDE.Forms.Calendar {
	public partial class FormHoraire : Form {
		CustomerCollection _ClientList = null;
		OffDateCollection _ColJourFerier = null;
		EmployeCollection _ColEmploye = null;
		PostItCollection _ColPostIt = null; //Collection de notes pour les Horaires
		FormMain _formMain = null;
		ScheduleControl _ScheduleControlSelected = null; //Control qui est présentement sélectionné
		ScheduleInfos _SelectedItemsInfos = null; //Information sur l'item sélectioné
        PrintMode _printMode = PrintMode.Nothing;

        //Test multi thread
        //Thread _threadBolded = null;
        
		public FormHoraire(CustomerCollection ClientList, OffDateCollection OffDateList, EmployeCollection ListEmploye, FormMain formMain, PostItCollection PostItList) {
			InitializeComponent();

            //FormMain
            _formMain = formMain;

            //Control client
            clientControl1.ListeEmploye = ListEmploye;

            //Liste de client
            _ClientList = ClientList;

            //Notes
            _ColPostIt = PostItList;

            //Liste d'employe
            _ColEmploye = ListEmploye;
			LoadListEmploye();
			if (cbEmploye.Items.Count > 0) cbEmploye.SelectedIndex = 0;

            //Date du jour
            vCalendar.SelectionStart = DateTime.Now;
            vCalendar.Date = DateTime.Now;

            //jour férié
            _ColJourFerier = OffDateList;
			UpdateBoldedDate();

			//Initialise l'horaire de la semaine
			InitialiseWeekSchedule();
			
			//Calendrier			
			vCalendar.TodayDate = DateTime.Now;
			vCalendar.SelectionRange = new Voroshkov.Calendar.DateSelectionRange(DateTime.Now, DateTime.Now);
			vCalendar.SelectionStart = vCalendar.SelectionEnd = DateTime.Now;
            vCalendar.Date = DateTime.Now;
			SetDate();
			//CreateBoldedDateFromCustomer();
		}

		private void tbFunction_ButtonClick(object sender, ToolBarButtonClickEventArgs e) {
			switch (e.Button.Tag.ToString()) {
				case "JOURFERIER":
					new FormJourFerier(_ColJourFerier, _formMain.AppConfig).ShowDialog(this);
					UpdateBoldedDate();
					SetDate();
					break;
				case "REFRESH":
					RefreshView();				
					break;
				case "SHOWCLIENT":
					if (tabControl1.SelectedTab.Tag.ToString() == "DAY")
                        _formMain.CreationListClient(listViewEx1.SelectedItems[0].SubItems[1].Text);
					else {
                        _formMain.CreationListClient(_SelectedItemsInfos.ContratNumber);
					}
					break;
				case "SHOWSEANCE":
					if (tabControl1.SelectedTab.Tag.ToString() == "DAY") {
						if (clientControl1.ShowCours() == DialogResult.OK)
							RefreshView();
					} else {
						clientControl1.Client = _ClientList.GetClient(_SelectedItemsInfos.ContratNumber);
						if (clientControl1.ShowCours() == DialogResult.OK)
							RefreshView();
					}
					break;
				case "PRINT":
                    PrintNormal();
					break;
				case "DELETENOTES":
					DeleteAllNotes();
					break;
			}
		}

        private void PrintNormal()
        {
            if (tabControl1.SelectedTab.Tag.ToString() == "DAY")
                PrintHoraire();
            else
                PrintHoraireWeek();
        }

		/// <summary>
		/// Supprime tous les notes de bas de page.
		/// </summary>
		private void DeleteAllNotes() {
			if (MessageBox.Show(this, "Voulez vous vraiment effacer toutes les notes de bas de page de vos horaires ?", _formMain.AppConfig.ApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                _ColPostIt.Clear();
				txtNotes.Text = "";
			}
		}

		private void RefreshView() {
            Cursor.Current = Cursors.WaitCursor;
			LoadListCours();
			SetDate();
            UpdateWeekHoraire();
            InitialiseWeekSchedule();            
            CreateBoldedDateFromCustomer();
            
            Cursor.Current = Cursors.Default;
		}

		/// <summary>
		/// Chargement de la liste d'employe
		/// </summary>
		private void LoadListEmploye() {
	        foreach (Employe employe in _ColEmploye)
                cbEmploye.Items.Add(employe.Nom + " " + employe.Prenom);
		}

		/// <summary>
		/// Chargement de la liste de cours en fonction du nom de l'employé qui à
		/// été sélectionné dans la liste
		/// </summary>
		private void LoadListCours() {
			ListViewItem itm;
			Seance cours;
			Customer client;

			listViewEx1.Items.Clear();

			//Notes
			txtNotes.Text = "";
			txtNotes.Text = GetNotes(vCalendar.SelectionStart.Date).Message;
			
			//Boucle dans tous les clients
			for (int i = 0; i < _ClientList.Count; i++) {
                //if (this._ClientList[i].TypeClient != ProfileType.CoursTerminer )
                    for (int j = 0; j < _ClientList[i].Seances.Count; j++)
                        {
                        cours = _ClientList[i].Seances[j];

                        //Voila nous avons trouvé une séance qui est de cette employé
                        if ((cours.Employer == cbEmploye.Text) &&
                            (cours.DateHeure.Date == vCalendar.SelectionStart.Date) &&
                            (cours.Active == true))
                            {
                            client = _ClientList[i];
                            itm = new ListViewItem();

                            itm.Text = DateTimeFunc.FormatHour(cours.DateHeure);

                            itm.Tag = client;
                            itm.SubItems.Add(client.ContratNumber);
                            itm.SubItems.Add(client.Name + " " + client.FirstName);
                            itm.SubItems.Add(cours.SceanceNumber.ToString());
                            itm.SubItems.Add(cours.Montant);
                            itm.SubItems.Add(cours.Code);
                            itm.SubItems.Add(client.Phone);

                            switch (client.TypeVehicule)
                                {
                                case VehiculeType.Automatique:
                                    itm.ImageKey = "Auto";
                                    itm.SubItems.Add("Auto.");
                                    break;
                                case VehiculeType.Cyclomoteur:
                                    itm.ImageKey = "Camion";
                                    itm.SubItems.Add("Camion");
                                    break;
                                case VehiculeType.Manuel:
                                    itm.ImageKey = "Auto";
                                    itm.SubItems.Add("Manuel");
                                    break;
                                case VehiculeType.Moto:
                                    itm.ImageKey = "Moto";
                                    itm.SubItems.Add("Moto");
                                    break;
                                }

                            listViewEx1.Items.Add(itm);
                            }
                        }
			}
		}

        private Dictionary<Seance, Customer> GetListCours(DateTime date, PrintMode mode)
        {
            Dictionary<Seance, Customer> coursList = new Dictionary<Seance, Customer>();


            //Boucle dans tous les clients
            foreach (Customer client in _ClientList)
                foreach(Seance cours in client.Seances)
                    if ((cours.Employer == cbEmploye.Text) && (cours.DateHeure.Date == date) && (cours.Active == true))
                    {
                        if (cours.DateHeure.Hour >= 1 && cours.DateHeure.Hour <= 12 && mode == PrintMode.AM)
                        {
                            coursList.Add(cours, client);
                            continue;
                        }

                        if (cours.DateHeure.Hour >= 13 && cours.DateHeure.Hour <= 17 && mode == PrintMode.PM)
                        {
                            coursList.Add(cours, client);
                            continue;
                        }

                        if (cours.DateHeure.Hour >= 18 && cours.DateHeure.Hour <= 23 && mode == PrintMode.Evening)
                        {
                            coursList.Add(cours, client);
                            continue; 
                        }

                        if (mode == PrintMode.Day)
                        {
                            coursList.Add(cours, client);
                            continue;
                        }
                    }

            return coursList;            
        }

		/// <summary>
		/// Cree la liste des boldedDate a partir de la liste de client.
		/// </summary>
		private void CreateBoldedDateFromCustomer() {
            vCalendar.RemoveAllBoldedDates();

            DateTime StartDate = new DateTime(vCalendar.Date.Year, vCalendar.Date.Month, 1); 

            ///////TEST
            var BoldedDate = from seance in _ClientList.GetAllSeancesPratique().Cast<Seance>()
                             where (seance.Employer == cbEmploye.Text) && 
                                    (seance.DateHeure.Date >= StartDate.Date && 
                                    (seance.DateHeure.Date <= StartDate.Date.AddDays(92).Date)) //+3 mois 
                             group seance by new { month = seance.DateHeure.Month, year = seance.DateHeure.Year, day = seance.DateHeure.Day} into d
                             select new { datetime = DateTime.Parse(string.Format("{0}/{1}/{2}", d.Key.month, d.Key.year, d.Key.day))};

            foreach(var date in BoldedDate)
                vCalendar.AddExactDate(date.datetime.Date, GetNotes(date.datetime.Date).Message);
    
            vCalendar.Refresh();
		}

		/// <summary>
		/// Affiche la date et le jour annuel s'il en n'a un.
		/// </summary>
		private void SetDate() {
			bool isOffDate = false;
			int OffDateIndex = 0;

			for (int i = 0; i < vCalendar.AnnualDates.Length; i++) {
				if ((vCalendar.AnnualDates[i].Date.Month == vCalendar.SelectionStart.Date.Month) &&
					(vCalendar.AnnualDates[i].Date.Day == vCalendar.SelectionStart.Date.Day)) {
					isOffDate = true;
					OffDateIndex = i;
					break;
				} else
					isOffDate = false;
			}

			if (isOffDate)
				lblDate.Text = vCalendar.SelectionStart.Date.ToLongDateString() + " [" +
					vCalendar.AnnualDates[OffDateIndex].Comment + "]";
			else
				lblDate.Text = vCalendar.SelectionStart.Date.ToLongDateString();
		}

		/// <summary>
		/// Obtenir l'information sur la date de congé cité si elle existe
		/// </summary>
		private string GetOffDate(DateTime date) {
			bool isOffDate = false;
			int OffDateIndex = 0;

			for (int i = 0; i < vCalendar.AnnualDates.Length; i++) {
				if ((vCalendar.AnnualDates[i].Date.Month == date.Month) &&
					(vCalendar.AnnualDates[i].Date.Day == date.Day)) {
					isOffDate = true;
					OffDateIndex = i;
					break;
				} else
					isOffDate = false;
			}

			if (isOffDate)
				return vCalendar.AnnualDates[OffDateIndex].Comment;
			else
				return "";
		}

		/// <summary>
		/// Afficher tous les jours dans le calendrié
		/// </summary>
		private void UpdateBoldedDate() {
			//Effacer le tableau de AnnuallyBoldedDates
			vCalendar.RemoveAllAnnuallyBoldedDates();

			for (int i = 0; i < _ColJourFerier.Count; i++) {
				vCalendar.AddAnnualDate(_ColJourFerier[i].Date, _ColJourFerier[i].Description);
			}

			vCalendar.UpdateBoldedDates();
		}

		private void vCalendar_SelectionChanged(object sender, EventArgs e) {
			txtNotes.Text = "";
			//SetDate();
			//LoadListCours();
			//CreateBoldedDateFromCustomer();

			//Temp
			//UpdateWeekHoraire();
			RefreshView();
		}

		private void cbEmploye_SelectedIndexChanged(object sender, EventArgs e) {
			RefreshView();
		}

		private void timerButton_Tick(object sender, EventArgs e) {
			if (tabControl1.SelectedTab.Tag.ToString() == "DAY") {
				if (listViewEx1.SelectedItems.Count > 0)
					tbbShowClient.Enabled = tbbShowSeances.Enabled = true;
				else
					tbbShowClient.Enabled = tbbShowSeances.Enabled = false;
			} else {
				if (_SelectedItemsInfos != null){
					if (_SelectedItemsInfos != null)
						tbbShowClient.Enabled = tbbShowSeances.Enabled = true;
					else
						tbbShowClient.Enabled = tbbShowSeances.Enabled = false;
				}else
					tbbShowClient.Enabled = tbbShowSeances.Enabled = false;
			}				
		}

		private void listViewEx1_SelectedIndexChanged(object sender, EventArgs e) {
			if (listViewEx1.SelectedItems.Count > 0)
				clientControl1.Client = (Customer)listViewEx1.SelectedItems[0].Tag; 
		}

		/// <summary>
		/// Verifie q'une notes est existante
		/// </summary>
		private void MakeNotes() {
			bool exist = false;
			int position = 0;
			PostIt notes = null;

			//Recherche si une notes est existante
			for (int i = 0; i < _ColPostIt.Count; i++) {
				if (_ColPostIt[i].Date == vCalendar.SelectionStart.Date && _ColPostIt[i].Employe == cbEmploye.Text) {
					exist = true;
					position = i;
					break;
				}
			}

			//Si la notes existe, modifier le message
			if (exist)
				//Si le texte n'est pas vide un modifie le message
				if (txtNotes.Text != "")

                    _ColPostIt[position].Message = txtNotes.Text;
				else //sinon on efface la notes
                    _ColPostIt.RemoveAt(position);
			else {
				//sinon on cree une nouvelle notes en cas de texte non vide
				if (txtNotes.Text != "") {
					notes = new PostIt();
					notes.Date = vCalendar.SelectionStart.Date;
					notes.Message = txtNotes.Text;
					notes.Employe = cbEmploye.Text;
                    _ColPostIt.Add(notes);
				}
			}
		}

		/// <summary>
		/// Verifie q'une notes est existante
		/// </summary>
		private void MakeNotes(DateTime date, string Notes) {
			bool exist = false;
			int position = 0;
			PostIt notes = null;

			//Recherche si une notes est existante
			for (int i = 0; i < _ColPostIt.Count; i++) {
				if (_ColPostIt[i].Date == date.Date && _ColPostIt[i].Employe == cbEmploye.Text) {
					exist = true;
					position = i;
					break;
				}
			}

			//Si la notes existe, modifier le message
			if (exist)
				//Si le texte n'est pas vide un modifie le message
				if (Notes != "")
                    _ColPostIt[position].Message = Notes;
				else //sinon on efface la notes
                    _ColPostIt.RemoveAt(position);
			else {
				//sinon on cree une nouvelle notes en cas de texte non existant
				if (Notes != "") {
					notes = new PostIt();
					notes.Date = vCalendar.SelectionStart.Date;
					notes.Message = Notes;
					notes.Employe = cbEmploye.Text;
                    _ColPostIt.Add(notes);
				}
			}
		}
		
        /// <summary>
        /// Renvoie un Objet de type PostIt.
        /// </summary>
        /// <param name="date"></param>
        /// <returns>Un postit vide est retournee si il en a aucun de valide.</returns>
		private PostIt GetNotes(DateTime date) {
            foreach (PostIt postit in _ColPostIt)
                if (postit.Date == date && postit.Employe == cbEmploye.Text)
                    return postit;  

            return new PostIt();
		}

		private void txtNotes_KeyUp(object sender, KeyEventArgs e) {
			MakeNotes();
		}

		/// <summary>
		/// Imprime la liste de paiment
		/// </summary>
		private void PrintHoraire() {
			//Lance l'impression
			PrintDialog printConfig = new PrintDialog();

			printConfig.PrinterSettings = printDocument1.PrinterSettings;

#if DEBUG
			PrintPreviewDialog prev = new PrintPreviewDialog();
			prev.Document = printDocument1;
			prev.ShowDialog(this);

#else
			if(printConfig.ShowDialog(this) == DialogResult.OK)	
					printDocument1.Print();
#endif	
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
			float topMargin = 30;
			float leftMargin = 0;
			float RightMargin = e.MarginBounds.Right;
			bool isBetween = false;
			string Hours = "";
			int indexFromList = 0;
			Seance cours = null;
			Customer client = null;
			string[] notesSplited;
			
			//Facrication de la font
			Font printFont = new Font("Times New Roman", 8, FontStyle.Regular);			
			Font printFontBold = new Font("Times New Roman", 8, FontStyle.Bold);
			Font printFont10 = new Font("Times New Roman", 10, FontStyle.Regular);
			Font printFont12 = new Font("Times New Roman", 12, FontStyle.Regular);
			Font printFontBold10 = new Font("Times New Roman", 10, FontStyle.Bold);
			Font printFontBold12 = new Font("Times New Roman", 12, FontStyle.Bold);
			Font printFontBold14 = new Font("Times New Roman", 14, FontStyle.Bold);
			Font printFontBold16 = new Font("Times New Roman", 16, FontStyle.Bold);

			float yPos = 0f;
			float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

			//en-tête
			yPos = topMargin;

            //Barette logo
            Stream strm = Type.GetType("Barette.IDE.Forms.Calendar.FormHoraire").Assembly.GetManifestResourceStream("Barette.IDE.Resources.Printlogo.png");
            Bitmap img = new Bitmap(strm);
            e.Graphics.DrawImage(img, 0, 0, 180, 100);
            e.Graphics.DrawString("Fiche horaire journalière", printFontBold16, Brushes.Black, 225, 30, new StringFormat());
            yPos += printFontBold16.Height + 0;
            e.Graphics.DrawString("Employé : " + cbEmploye.Text, printFontBold12, Brushes.Black, 225, yPos, new StringFormat());
			yPos += printFontBold16.Height;
			e.Graphics.DrawString("Date : " + DateTimeFunc.DayOfWeekFRLong(vCalendar.SelectionStart.Date.DayOfWeek) + ", " + vCalendar.SelectionStart.Date.ToLongDateString() , printFont12, Brushes.Black, 225, yPos, new StringFormat());
			
			//Header du tableau
			yPos += printFont.Height + 20;			
			e.Graphics.DrawString("Heures", printFontBold10, Brushes.Black, leftMargin + 0, yPos, new StringFormat());
			e.Graphics.DrawString("# Contrat", printFontBold10, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
			e.Graphics.DrawString("Nom du client", printFontBold10, Brushes.Black, leftMargin + 125, yPos, new StringFormat());
			e.Graphics.DrawString("Téléphone 1", printFontBold10, Brushes.Black, leftMargin + 310, yPos, new StringFormat());
            e.Graphics.DrawString("Téléphone 2", printFontBold10, Brushes.Black, leftMargin + 410, yPos, new StringFormat());
			e.Graphics.DrawString("Type", printFontBold10, Brushes.Black, leftMargin + 510, yPos, new StringFormat());
			e.Graphics.DrawString("# Séance", printFontBold10, Brushes.Black, leftMargin + 560, yPos, new StringFormat());
			e.Graphics.DrawString("Paiment", printFontBold10, Brushes.Black, leftMargin + 620, yPos, new StringFormat());
			e.Graphics.DrawString("Endroit", printFontBold10, Brushes.Black, leftMargin + 690, yPos, new StringFormat());
			e.Graphics.DrawString("Absence", printFontBold10, Brushes.Black, leftMargin + 755, yPos, new StringFormat());
						
			//Impression du tableau d'horraire
			yPos += printFont12.Height + 15;

			//Mettre l'heure de départ à 7h00 de la date selectionné sur le calendrier
			DateTime HeureDepart = new DateTime(vCalendar.SelectionStart.Year, vCalendar.SelectionStart.Month, vCalendar.SelectionStart.Day, 7, 0,0);
			DateTime HeureCourant = HeureDepart; //Heure courant dans l'iteration
			//for (int i = 0; i < 30; i++) {
			while (DateTimeFunc.FormatHour(HeureCourant) != "22h30" ){ //max 22h00
				yPos += printFont12.Height;
								
				cours = GetCoursBetweenFromList(out isBetween, out indexFromList, HeureCourant, out client);
				if (cours != null) { //Cours à imprimer					
					Hours = DateTimeFunc.FormatHour(cours.DateHeure);
					e.Graphics.DrawString(Hours, printFont10, Brushes.Black, 45 - e.Graphics.MeasureString(Hours, printFont10).Width, yPos, new StringFormat());
					e.Graphics.DrawString(client.ContratNumber, printFont10, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
					e.Graphics.DrawString(client.Name + " " + client.FirstName, printFont10, Brushes.Black, leftMargin + 125, yPos, new StringFormat());
					e.Graphics.DrawString(client.Phone, printFont10, Brushes.Black, leftMargin + 310, yPos, new StringFormat());
                    e.Graphics.DrawString(client.PhoneBureau, printFont10, Brushes.Black, leftMargin + 410, yPos, new StringFormat());
                    e.Graphics.DrawString(client.GetShortVehiculeType(), printFont10, Brushes.Black, leftMargin + 510, yPos, new StringFormat());
                    e.Graphics.DrawString(cours.SceanceNumber.ToString(), printFont10, Brushes.Black, leftMargin + 560, yPos, new StringFormat());
                    e.Graphics.DrawString(cours.Montant, printFont10, Brushes.Black, leftMargin + 620, yPos, new StringFormat());
					e.Graphics.DrawString(cours.Code, printFont10, Brushes.Black, leftMargin + 690, yPos, new StringFormat());					
				} else {
					Hours = DateTimeFunc.FormatHour(HeureCourant);
					e.Graphics.DrawString(Hours, printFont10, Brushes.Black, 45 - e.Graphics.MeasureString(Hours, printFont10).Width, yPos, new StringFormat());
				}
				
				cours = null;
				//Ajoute 30 min a l'heure courante
				HeureCourant = HeureCourant.AddMinutes(30);
			}

			//Impression des notes de la journée
			if (txtNotes.Text != "") {
				yPos += printFontBold14.Height + 35;
				e.Graphics.DrawString("Notes", printFontBold14, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

				yPos += printFont12.Height;
				notesSplited = txtNotes.Text.Split('\n');
				for (int i = 0; i < notesSplited.Length; i++) {
					yPos += printFont12.Height ;
					e.Graphics.DrawString(notesSplited[i], printFont10, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
				}
			}
		}

		/// <summary>
		/// Lance l'impression de l'horaire sur le format d'une semaine
		/// </summary>
		private void PrintHoraireWeek() {
			//Lance l'impression
			PrintDialog printConfig = new PrintDialog();

			printConfig.PrinterSettings = printDocWeek.PrinterSettings;
			
			//Recherche le type de papier "Legal" et ensuite mettre la page au format Portrait
			 for (int i = 0; i < printDocWeek.PrinterSettings.PaperSizes.Count; i++){
				 if (printDocWeek.PrinterSettings.PaperSizes[i].Kind == System.Drawing.Printing.PaperKind.Legal) {
					 printDocWeek.DefaultPageSettings.PaperSize = printDocWeek.PrinterSettings.PaperSizes[i];
				 }
			 }
			 printDocWeek.DefaultPageSettings.Landscape = true; 


			//Imprime la page
#if DEBUG
			PrintPreviewDialog prev = new PrintPreviewDialog();
			prev.Document = printDocWeek;
			prev.ShowDialog(this);

#else
			if(printConfig.ShowDialog(this) == DialogResult.OK)	
					printDocWeek.Print();
#endif	
		}

		private void printDocWeek_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
			float topMargin = 30;
			float leftMargin = 0;
			float RightMargin = e.MarginBounds.Right;

			//Facrication des objet font
			Font printFont6 = new Font("Times New Roman", 6, FontStyle.Regular);
			Font printFont = new Font("Times New Roman", 8, FontStyle.Regular);
			Font printFontBold = new Font("Times New Roman", 8, FontStyle.Bold);
			Font printFont10 = new Font("Times New Roman", 12, FontStyle.Regular);
			Font printFont12 = new Font("Times New Roman", 12, FontStyle.Regular);
			Font printFontBold12 = new Font("Times New Roman", 12, FontStyle.Bold);
			Font printFontBold10 = new Font("Times New Roman", 10, FontStyle.Bold);
			Font printFontBold14 = new Font("Times New Roman", 14, FontStyle.Bold);
			Font printFontBold16 = new Font("Times New Roman", 16, FontStyle.Bold);
			
			float yPos = 0f;
			float yPosCalandar = 0f; 
			float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

			//en-tête
			yPos = topMargin;
			e.Graphics.DrawString("Gestion Auto Ecole - Horaire : " + cbEmploye.Text, printFontBold14, Brushes.Black, leftMargin, yPos, new StringFormat());
			yPos += printFontBold16.Height;

			//Cadrage et ligne de séparation
			const int TotalDay = 7;
			int CadrageWidth = e.MarginBounds.Width + 150;
			int CacrageHeigth = e.MarginBounds.Height + 100;
			int CadrageSectionWidth = (e.MarginBounds.Width + 150) / TotalDay;
			Rectangle Cadrage = new Rectangle((int)leftMargin, (int)yPos, CadrageWidth, CacrageHeigth);
			e.Graphics.DrawRectangle(Pens.Black, Cadrage);

			//Creation des Description de chaque jours pour l'impression
			ScheduleDescriptionCollection HoraireDescriptions = new ScheduleDescriptionCollection();
			HoraireDescriptions.Add(scheduleControl1.HoraireDescription);
			HoraireDescriptions.Add(scheduleControl2.HoraireDescription);
			HoraireDescriptions.Add(scheduleControl3.HoraireDescription);
			HoraireDescriptions.Add(scheduleControl4.HoraireDescription);
			HoraireDescriptions.Add(scheduleControl5.HoraireDescription);
			HoraireDescriptions.Add(scheduleControl6.HoraireDescription);
			HoraireDescriptions.Add(scheduleControl7.HoraireDescription);

			//Imprime les ligne de séparation et le calandrier
			int LeftColumn = 0; //Position gauche de la colone courante
			for (int i = 0; i < TotalDay; i++) {
				LeftColumn = (int)leftMargin + CadrageSectionWidth * i;
				Point pTop = new Point(LeftColumn, Cadrage.Top);
				Point pDown = new Point(LeftColumn, Cadrage.Bottom);
				e.Graphics.DrawLine(Pens.Black, pTop, pDown); 

				//Cree le calandrier en parcourant la liste des horaires
				yPosCalandar = Cadrage.Top + 3;
				e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(HoraireDescriptions[i].Jour.DayOfWeek) + " " + HoraireDescriptions[i].Jour.ToLongDateString(), printFontBold12, Brushes.Black, LeftColumn + 3, yPosCalandar);
				yPosCalandar += printFontBold12.Height;
				e.Graphics.DrawString(GetOffDate(HoraireDescriptions[i].Jour), printFont10, Brushes.Black, LeftColumn + 3, yPosCalandar);
				yPosCalandar += printFont10.Height;
				string[] ClientName;
				for (int j = 0; j < HoraireDescriptions[i].HoraireJour.Count; j++) {
					ClientName = HoraireDescriptions[i].HoraireJour[j].ClientName.Split(' ');
					e.Graphics.DrawString(DateTimeFunc.FormatHour(HoraireDescriptions[i].HoraireJour[j].Heures), printFont, Brushes.Black, LeftColumn + 2, yPosCalandar);
					if (ClientName.Length > 1) {
						e.Graphics.DrawString(ClientName[ClientName.Length - 1], printFont6, Brushes.Black, LeftColumn + 38, yPosCalandar);
						e.Graphics.DrawString(HoraireDescriptions[i].HoraireJour[j].SeanceNumber, printFont6, Brushes.Black, LeftColumn + 150, yPosCalandar);
						e.Graphics.DrawString(HoraireDescriptions[i].HoraireJour[j].SeanceCode, printFont6, Brushes.Black, LeftColumn + 165, yPosCalandar);

						e.Graphics.DrawString(HoraireDescriptions[i].HoraireJour[j].PhoneNumber, printFont6, Brushes.Black, LeftColumn + 38, yPosCalandar + printFont6.Height);
						e.Graphics.DrawString("(" + HoraireDescriptions[i].HoraireJour[j].ContratNumber + ")", printFont6, Brushes.Black, LeftColumn + 150, yPosCalandar + printFont6.Height);
					}

					yPosCalandar += ((float)printFont.Height * 1.75f) ;
				}
			} 
		}

		/// <summary>
		/// Verifie si il y a un cours a imprimer dans la liste
		/// </summary>
		/// <param name="isBetween"></param>
		/// <param name="HeureCourant"></param>
		/// <param name="indexFormList"></param>
		/// <returns>Retourne la séance qui sera imprimé. Si la valeur est null, c'est que rien n'a été trouvé</returns>
		private Seance GetCoursBetweenFromList(out bool isBetween, out int indexFormList, DateTime HeureCourant, out Customer client) {
			//DateTime HeureBasse =  HeureCourant;
			DateTime HeureHaute = HeureCourant.AddMinutes(30);
			DateTime HeureItem = new DateTime();
			//Customer client = null;
						
			for (int i = 0; i < listViewEx1.Items.Count; i++) {
				HeureItem = DateTimeFunc.HoursFromString(listViewEx1.Items[i].Text);

				if (DateTimeFunc.HoursIsBetween(HeureCourant, HeureItem, HeureHaute)) {
					isBetween = true;
					indexFormList = i;

					//Obtenir le client et le numéro de seance
					client = _ClientList.GetClient(listViewEx1.Items[i].SubItems[1].Text);
					if (client != null)
						return client.GetSeance(Convert.ToInt16(listViewEx1.Items[i].SubItems[3].Text));
				}
			}

			//rien trouv/
			client = null;
			isBetween = false;
			indexFormList = -1;
			return null;
		}

		private void listViewEx1_DoubleClick(object sender, EventArgs e) {

			//Affiche la boite de cours du client
			if (listViewEx1.SelectedItems.Count > 0) {
				clientControl1.ShowCours();
				RefreshView(); 
			}
		}

		/// <summary>
		/// Mise à jour de l'horaire.
		/// </summary>
		private void UpdateWeekHoraire(){
			scheduleControl1.Date = vCalendar.SelectionStart.Date;
			scheduleControl2.Date = vCalendar.SelectionStart.Date.AddDays(1);
			scheduleControl3.Date = vCalendar.SelectionStart.Date.AddDays(2);
			scheduleControl4.Date = vCalendar.SelectionStart.Date.AddDays(3);
			scheduleControl5.Date = vCalendar.SelectionStart.Date.AddDays(4);
			scheduleControl6.Date = vCalendar.SelectionStart.Date.AddDays(5);
			scheduleControl7.Date = vCalendar.SelectionStart.Date.AddDays(6);
		}

		private void ShowCoursWeek() {
			Customer client = null;

			client = _ClientList.GetClient(_SelectedItemsInfos.ContratNumber);

			if (client != null) {
				clientControl1.Client = client;

				if (clientControl1.ShowCours() == DialogResult.OK)
					RefreshView();
			}
		}


		/// <summary>
		/// Initialise l'horaire de la semaine 
		/// </summary>
		private void InitialiseWeekSchedule() {			
			scheduleControl1.ClientList = _ClientList;
			scheduleControl1.EmployeList = _ColEmploye;
			scheduleControl1.EmployeName = cbEmploye.Text;
			scheduleControl1.Notes = GetNotes(scheduleControl1.Date).Message;

			scheduleControl2.ClientList = _ClientList;
			scheduleControl2.EmployeList = _ColEmploye;			
			scheduleControl2.EmployeName = cbEmploye.Text;
            scheduleControl2.Notes = GetNotes(scheduleControl2.Date).Message;
						
			scheduleControl3.ClientList = _ClientList;
			scheduleControl3.EmployeList = _ColEmploye;
			scheduleControl3.EmployeName = cbEmploye.Text;
            scheduleControl3.Notes = GetNotes(scheduleControl3.Date).Message;
						
			scheduleControl4.ClientList = _ClientList;
			scheduleControl4.EmployeList = _ColEmploye;
			scheduleControl4.EmployeName = cbEmploye.Text;
            scheduleControl4.Notes = GetNotes(scheduleControl4.Date).Message;
						
			scheduleControl5.ClientList = _ClientList;
			scheduleControl5.EmployeList = _ColEmploye;
			scheduleControl5.EmployeName = cbEmploye.Text;
            scheduleControl5.Notes = GetNotes(scheduleControl5.Date).Message;
						
			scheduleControl6.ClientList = _ClientList;
			scheduleControl6.EmployeList = _ColEmploye;
			scheduleControl6.EmployeName = cbEmploye.Text;
            scheduleControl6.Notes = GetNotes(scheduleControl6.Date).Message;
						
			scheduleControl7.ClientList = _ClientList;
			scheduleControl7.EmployeList = _ColEmploye;
			scheduleControl7.EmployeName = cbEmploye.Text;
            scheduleControl7.Notes = GetNotes(scheduleControl7.Date).Message;
		}

		private void scheduleControl1_NotesChanged(object sender, EventArgs e) {
			MakeNotes(scheduleControl1.Date, scheduleControl1.Notes);
		}

		private void scheduleControl2_NotesChanged(object sender, EventArgs e) {
			MakeNotes(scheduleControl2.Date, scheduleControl2.Notes);
		}

		private void scheduleControl3_NotesChanged(object sender, EventArgs e) {
			MakeNotes(scheduleControl3.Date, scheduleControl3.Notes);
		}

		private void scheduleControl4_NotesChanged(object sender, EventArgs e) {
			MakeNotes(scheduleControl4.Date, scheduleControl4.Notes);
		}

		private void scheduleControl5_NotesChanged(object sender, EventArgs e) {
			MakeNotes(scheduleControl5.Date, scheduleControl5.Notes);
		}

		private void scheduleControl6_NotesChanged(object sender, EventArgs e) {
			MakeNotes(scheduleControl6.Date, scheduleControl6.Notes);
		}

		private void scheduleControl7_NotesChanged(object sender, EventArgs e) {
			MakeNotes(scheduleControl7.Date, scheduleControl7.Notes);
		}

		private void scheduleControl1_ItemSelected(object sender, EventArgs e) {
            _ScheduleControlSelected = scheduleControl1;
            _SelectedItemsInfos = scheduleControl1.SelectedItemInfos;			
		}

		private void scheduleControl2_ItemSelected(object sender, EventArgs e) {
            _ScheduleControlSelected = scheduleControl2;
            _SelectedItemsInfos = scheduleControl2.SelectedItemInfos;
		}

		private void scheduleControl3_ItemSelected(object sender, EventArgs e) {
            _ScheduleControlSelected = scheduleControl3;
            _SelectedItemsInfos = scheduleControl3.SelectedItemInfos;
		}

		private void scheduleControl4_ItemSelected(object sender, EventArgs e) {
            _ScheduleControlSelected = scheduleControl4;
            _SelectedItemsInfos = scheduleControl4.SelectedItemInfos;
		}

		private void scheduleControl5_ItemSelected(object sender, EventArgs e) {
            _ScheduleControlSelected = scheduleControl5;
            _SelectedItemsInfos = scheduleControl5.SelectedItemInfos;
		}

		private void scheduleControl6_ItemSelected(object sender, EventArgs e) {
            _ScheduleControlSelected = scheduleControl6;
            _SelectedItemsInfos = scheduleControl6.SelectedItemInfos;
		}

		private void scheduleControl7_ItemSelected(object sender, EventArgs e) {
            _ScheduleControlSelected = scheduleControl7;
            _SelectedItemsInfos = scheduleControl7.SelectedItemInfos;
		}

		private void scheduleControl_MouseItemDoubleClick(object sender, MouseEventArgs e) {
			ShowCoursWeek();
        }

        private void vCalendar_DateChanged(object sender, EventArgs e) {
            CreateBoldedDateFromCustomer();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            PrintNormal();
        }

        private void PrintForm(PrintMode mode)
        {
            _printMode = mode;

            //Lance l'impression
            PrintDialog printConfig = new PrintDialog();

            printConfig.PrinterSettings = printDocument2.PrinterSettings;

#if DEBUG
            PrintPreviewDialog prev = new PrintPreviewDialog();
            prev.Document = printDocument2;
            prev.ShowDialog(this);

#else
			if(printConfig.ShowDialog(this) == DialogResult.OK)	
					printDocument2.Print();
#endif	

            _printMode = PrintMode.Nothing;
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float topMargin = 30;
            float leftMargin = 0;
            float RightMargin = e.MarginBounds.Right;
            string Hours = "";
            string HoursEnd = "";
            Seance cours = null;
            Customer client = null;

            Employe employe = _formMain.EmployeList.GetFromName(cbEmploye.Text);

            string[] notesSplited;

            //Facrication de la font
            Font printFont = new Font("Times New Roman", 8, FontStyle.Regular);
            Font printFontBold = new Font("Times New Roman", 8, FontStyle.Bold);
            Font printFont10 = new Font("Times New Roman", 10, FontStyle.Regular);
            Font printFont12 = new Font("Times New Roman", 12, FontStyle.Regular);
            Font printFontBold10 = new Font("Times New Roman", 10, FontStyle.Bold);
            Font printFontBold12 = new Font("Times New Roman", 12, FontStyle.Bold);
            Font printFontBold14 = new Font("Times New Roman", 14, FontStyle.Bold);
            Font printFontBold16 = new Font("Times New Roman", 16, FontStyle.Bold);

            float yPos = 0f;
            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

            //en-tête
            yPos = topMargin;

            //Barette logo
            Stream strm = Type.GetType("Barette.IDE.Forms.Calendar.FormHoraire").Assembly.GetManifestResourceStream("Barette.IDE.Resources.Printlogo.png");
            Bitmap img = new Bitmap(strm);
            e.Graphics.DrawImage(img, 0, 0, 180, 100);

            switch (_printMode)
            {
                case PrintMode.AM:
                    e.Graphics.DrawString("Fiche horaire journalière : Avant-midi", printFontBold16, Brushes.Black, 225, 30, new StringFormat());
                    break;
                case PrintMode.PM:
                    e.Graphics.DrawString("Fiche horaire journalière : Après-midi", printFontBold16, Brushes.Black, 225, 30, new StringFormat());
                    break;
                case PrintMode.Evening:
                    e.Graphics.DrawString("Fiche horaire journalière : Soirée", printFontBold16, Brushes.Black, 225, 30, new StringFormat());
                    break;
                case PrintMode.Day:
                    e.Graphics.DrawString("Fiche horaire journalière", printFontBold16, Brushes.Black, 225, 30, new StringFormat());
                    break;
            }

            yPos += printFontBold16.Height + 0;
            e.Graphics.DrawString("Employé : " + employe.Nom + " (" + employe.NomAffichageRapport + ")", printFontBold12, Brushes.Black, 225, yPos, new StringFormat());
            yPos += printFontBold16.Height;
            e.Graphics.DrawString("Date : " + DateTimeFunc.DayOfWeekFRLong(vCalendar.SelectionStart.Date.DayOfWeek) + ", " + vCalendar.SelectionStart.Date.ToLongDateString(), printFont12, Brushes.Black, 225, yPos, new StringFormat());

            //Header du tableau
            yPos += printFont.Height + 20;
            e.Graphics.DrawString("Heures", printFontBold10, Brushes.Black, leftMargin + 0, yPos, new StringFormat());
            e.Graphics.DrawString("# Contrat", printFontBold10, Brushes.Black, leftMargin + 95, yPos, new StringFormat());
            e.Graphics.DrawString("Nom du client", printFontBold10, Brushes.Black, leftMargin + 160, yPos, new StringFormat());
            e.Graphics.DrawString("Téléphone 1", printFontBold10, Brushes.Black, leftMargin + 340, yPos, new StringFormat());
            e.Graphics.DrawString("Téléphone 2", printFontBold10, Brushes.Black, leftMargin + 440, yPos, new StringFormat());
            e.Graphics.DrawString("Type", printFontBold10, Brushes.Black, leftMargin + 540, yPos, new StringFormat());
            e.Graphics.DrawString("# Séance", printFontBold10, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
            e.Graphics.DrawString("Paiment", printFontBold10, Brushes.Black, leftMargin + 650, yPos, new StringFormat());
            e.Graphics.DrawString("Endroit", printFontBold10, Brushes.Black, leftMargin + 720, yPos, new StringFormat());
            //e.Graphics.DrawString("Absence", printFontBold10, Brushes.Black, leftMargin + 755, yPos, new StringFormat());

            //Impression du tableau d'horraire
            yPos += printFont12.Height + 15;
            
            /////////////////////////////////////////////////////////////////////////////////
            var ClientCourslist = GetListCours(vCalendar.SelectionStart, _printMode);

            foreach (KeyValuePair<Seance, Customer> pair in ClientCourslist)
            {
                yPos += printFont12.Height;

                cours = pair.Key;
                client = pair.Value;

                Hours = DateTimeFunc.FormatHour(cours.DateHeure);
                HoursEnd = DateTimeFunc.FormatHour(cours.DateModified);

                if (client.TypeVehicule == VehiculeType.Moto)
                    e.Graphics.DrawString(Hours + " à " + HoursEnd, printFont10, Brushes.Black, 45 - e.Graphics.MeasureString(Hours, printFont10).Width, yPos, new StringFormat());
                else
                    e.Graphics.DrawString(Hours, printFont10, Brushes.Black, 45 - e.Graphics.MeasureString(Hours, printFont10).Width, yPos, new StringFormat());
                
                e.Graphics.DrawString(client.ContratNumber, printFont10, Brushes.Black, leftMargin + 95, yPos, new StringFormat());
                e.Graphics.DrawString(client.Name + " " + client.FirstName, printFont10, Brushes.Black, leftMargin + 160, yPos, new StringFormat());
                e.Graphics.DrawString(client.Phone, printFont10, Brushes.Black, leftMargin + 340, yPos, new StringFormat());
                e.Graphics.DrawString(client.PhoneBureau, printFont10, Brushes.Black, leftMargin + 440, yPos, new StringFormat());
                e.Graphics.DrawString(client.GetShortVehiculeType(), printFont10, Brushes.Black, leftMargin + 540, yPos, new StringFormat());
                e.Graphics.DrawString(cours.SceanceNumber.ToString(), printFont10, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
                e.Graphics.DrawString(cours.Montant, printFont10, Brushes.Black, leftMargin + 650, yPos, new StringFormat());
                e.Graphics.DrawString(cours.Code, printFont10, Brushes.Black, leftMargin + 720, yPos, new StringFormat());

            }
            /////////////////////////////////////////////////////////////////////////////////


            yPos += 50;
            e.Graphics.DrawString("____ Cours en circuit fermé", printFontBold10, Brushes.Black, leftMargin + 0, yPos, new StringFormat());
            yPos += printFont12.Height;
            e.Graphics.DrawString("____ Cours sur route", printFontBold10, Brushes.Black, leftMargin + 0, yPos, new StringFormat());

            yPos += printFont12.Height * 2;
            e.Graphics.DrawString("No. Permis  : " + employe.NumeroPermis, printFontBold10, Brushes.Black, leftMargin + 0, yPos, new StringFormat());
            yPos += printFont12.Height * 2;
            e.Graphics.DrawString("Signature    ______________________________", printFontBold10, Brushes.Black, leftMargin + 0, yPos, new StringFormat());


            //Impression des notes de la journée
            if (txtNotes.Text != "")
            {
                yPos += printFontBold14.Height + 35;
                e.Graphics.DrawString("Notes", printFontBold14, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

                yPos += printFont12.Height;
                notesSplited = txtNotes.Text.Split('\n');
                for (int i = 0; i < notesSplited.Length; i++)
                {
                    yPos += printFont12.Height;
                    e.Graphics.DrawString(notesSplited[i], printFont10, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                }
            }
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            PrintForm(PrintMode.AM);
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            PrintForm(PrintMode.PM);
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            PrintForm(PrintMode.Evening);
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            PrintForm(PrintMode.Day);
        }
    }
}