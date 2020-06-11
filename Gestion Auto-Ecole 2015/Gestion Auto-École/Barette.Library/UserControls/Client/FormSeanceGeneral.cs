using System;
using System.ComponentModel;
using System.Windows.Forms;
using Barette.Library.Client;
using Barette.Library.Collections;

namespace Barette.Library.UserControls.Client
{
    /// <summary>
    /// Description résumée de FormSeanceGeneral.
    /// </summary>
    public class FormSeanceGeneral : Form
    {		
		/// <summary>
		/// client referer
		/// </summary>
		private readonly Customer _client;

        /// <summary>
        /// Control Client interne
        /// </summary>
        private readonly ClientControl _ctrlClient;

		private Button cmdOK;
        private Button cmdAnnuler;
        private IContainer components;
		private SeancePicker seancePicker12;
		private SeancePicker seancePicker11;
		private SeancePicker seancePicker10;
		private SeancePicker seancePicker9;
		private SeancePicker seancePicker8;
		private SeancePicker seancePicker7;
		private SeancePicker seancePicker6;
		private SeancePicker seancePicker5;
		private SeancePicker seancePicker4;
		private SeancePicker seancePicker3;
		private SeancePicker seancePicker2;
		private SeancePicker seancePicker1;
        private SeancePicker seancePicker13;
        private SeancePicker seancePicker14;
        private SeancePicker seancePicker15;
        private ImageList imageList1;
        private Button cmdPrint;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;

		private readonly EmployeCollection _ListEmploye;

		public FormSeanceGeneral(Customer client, ClientControl ctrl, EmployeCollection ListEmploye) {
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

            _client = client;
            _ctrlClient = ctrl;
            _ListEmploye = ListEmploye;

			InitializeSeance();
			
			//teste
            //Point p = new Point();
            //p.Y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            //p.X = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            //this.Location = p;
		}

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent() {
            components = new Container();
            Seance seance1 = new Seance();
            Seance seance2 = new Seance();
            Seance seance3 = new Seance();
            Seance seance4 = new Seance();
            Seance seance5 = new Seance();
            Seance seance6 = new Seance();
            Seance seance7 = new Seance();
            Seance seance8 = new Seance();
            Seance seance9 = new Seance();
            Seance seance10 = new Seance();
            Seance seance11 = new Seance();
            Seance seance12 = new Seance();
            Seance seance13 = new Seance();
            Seance seance14 = new Seance();
            Seance seance15 = new Seance();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormSeanceGeneral));
            cmdOK = new Button();
            cmdAnnuler = new Button();
            seancePicker15 = new SeancePicker();
            seancePicker14 = new SeancePicker();
            seancePicker13 = new SeancePicker();
            seancePicker12 = new SeancePicker();
            seancePicker11 = new SeancePicker();
            seancePicker10 = new SeancePicker();
            seancePicker9 = new SeancePicker();
            seancePicker8 = new SeancePicker();
            seancePicker7 = new SeancePicker();
            seancePicker6 = new SeancePicker();
            seancePicker5 = new SeancePicker();
            seancePicker4 = new SeancePicker();
            seancePicker3 = new SeancePicker();
            seancePicker2 = new SeancePicker();
            seancePicker1 = new SeancePicker();
            imageList1 = new ImageList(components);
            cmdPrint = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmdOK
            // 
            cmdOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            cmdOK.Image = global::Barette.Library.Properties.Resources.accept_icon;
            cmdOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cmdOK.Location = new System.Drawing.Point(670, 457);
            cmdOK.Name = "cmdOK";
            cmdOK.Size = new System.Drawing.Size(95, 45);
            cmdOK.TabIndex = 12;
            cmdOK.Text = "Appliquer";
            cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cmdOK.Click += new EventHandler(cmdOK_Click);
            // 
            // cmdAnnuler
            // 
            cmdAnnuler.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            cmdAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cmdAnnuler.Image = global::Barette.Library.Properties.Resources.Cancel_2_icon;
            cmdAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cmdAnnuler.Location = new System.Drawing.Point(771, 457);
            cmdAnnuler.Name = "cmdAnnuler";
            cmdAnnuler.Size = new System.Drawing.Size(85, 45);
            cmdAnnuler.TabIndex = 13;
            cmdAnnuler.Text = "Annuler";
            cmdAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cmdAnnuler.Click += new EventHandler(button2_Click);
            // 
            // seancePicker15
            // 
            seancePicker15.Absence = false;
            seancePicker15.Checked = false;
            seancePicker15.Code = "";
            seancePicker15.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 390);
            seancePicker15.DateModifiedChecked = false;
            seancePicker15.Employer = "";
            seancePicker15.Location = new System.Drawing.Point(8, 422);
            seancePicker15.Margin = new Padding(3, 1, 3, 3);
            seancePicker15.Name = "seancePicker15";
            seancePicker15.NumeroSeance = 15;
            seance1.Absence = false;
            seance1.Active = false;
            seance1.Code = "";
            seance1.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance1.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 390);
            seance1.DateModifiedChecked = false;
            seance1.Employer = "";
            seance1.Montant = "";
            seance1.SceanceNumber = 15;
            seancePicker15.Seance = seance1;
            seancePicker15.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker15.Size = new System.Drawing.Size(790, 25);
            seancePicker15.TabIndex = 33;
            // 
            // seancePicker14
            // 
            seancePicker14.Absence = false;
            seancePicker14.Checked = false;
            seancePicker14.Code = "";
            seancePicker14.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 390);
            seancePicker14.DateModifiedChecked = false;
            seancePicker14.Employer = "";
            seancePicker14.Location = new System.Drawing.Point(8, 393);
            seancePicker14.Margin = new Padding(3, 1, 3, 3);
            seancePicker14.Name = "seancePicker14";
            seancePicker14.NumeroSeance = 14;
            seance2.Absence = false;
            seance2.Active = false;
            seance2.Code = "";
            seance2.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance2.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 390);
            seance2.DateModifiedChecked = false;
            seance2.Employer = "";
            seance2.Montant = "";
            seance2.SceanceNumber = 14;
            seancePicker14.Seance = seance2;
            seancePicker14.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker14.Size = new System.Drawing.Size(790, 25);
            seancePicker14.TabIndex = 32;
            // 
            // seancePicker13
            // 
            seancePicker13.Absence = false;
            seancePicker13.Checked = false;
            seancePicker13.Code = "";
            seancePicker13.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 390);
            seancePicker13.DateModifiedChecked = false;
            seancePicker13.Employer = "";
            seancePicker13.Location = new System.Drawing.Point(8, 364);
            seancePicker13.Margin = new Padding(3, 1, 3, 3);
            seancePicker13.Name = "seancePicker13";
            seancePicker13.NumeroSeance = 13;
            seance3.Absence = false;
            seance3.Active = false;
            seance3.Code = "";
            seance3.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance3.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 390);
            seance3.DateModifiedChecked = false;
            seance3.Employer = "";
            seance3.Montant = "";
            seance3.SceanceNumber = 13;
            seancePicker13.Seance = seance3;
            seancePicker13.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker13.Size = new System.Drawing.Size(790, 25);
            seancePicker13.TabIndex = 31;
            // 
            // seancePicker12
            // 
            seancePicker12.Absence = false;
            seancePicker12.Checked = false;
            seancePicker12.Code = "";
            seancePicker12.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 390);
            seancePicker12.DateModifiedChecked = false;
            seancePicker12.Employer = "";
            seancePicker12.Location = new System.Drawing.Point(8, 335);
            seancePicker12.Margin = new Padding(3, 1, 3, 3);
            seancePicker12.Name = "seancePicker12";
            seancePicker12.NumeroSeance = 12;
            seance4.Absence = false;
            seance4.Active = false;
            seance4.Code = "";
            seance4.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance4.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 390);
            seance4.DateModifiedChecked = false;
            seance4.Employer = "";
            seance4.Montant = "";
            seance4.SceanceNumber = 12;
            seancePicker12.Seance = seance4;
            seancePicker12.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker12.Size = new System.Drawing.Size(790, 25);
            seancePicker12.TabIndex = 29;
            // 
            // seancePicker11
            // 
            seancePicker11.Absence = false;
            seancePicker11.Checked = false;
            seancePicker11.Code = "";
            seancePicker11.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 431);
            seancePicker11.DateModifiedChecked = false;
            seancePicker11.Employer = "";
            seancePicker11.Location = new System.Drawing.Point(8, 307);
            seancePicker11.Margin = new Padding(3, 1, 3, 3);
            seancePicker11.Name = "seancePicker11";
            seancePicker11.NumeroSeance = 11;
            seance5.Absence = false;
            seance5.Active = false;
            seance5.Code = "";
            seance5.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance5.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 431);
            seance5.DateModifiedChecked = false;
            seance5.Employer = "";
            seance5.Montant = "";
            seance5.SceanceNumber = 11;
            seancePicker11.Seance = seance5;
            seancePicker11.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker11.Size = new System.Drawing.Size(790, 25);
            seancePicker11.TabIndex = 28;
            // 
            // seancePicker10
            // 
            seancePicker10.Absence = false;
            seancePicker10.Checked = false;
            seancePicker10.Code = "";
            seancePicker10.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 451);
            seancePicker10.DateModifiedChecked = false;
            seancePicker10.Employer = "";
            seancePicker10.Location = new System.Drawing.Point(8, 279);
            seancePicker10.Margin = new Padding(3, 1, 3, 3);
            seancePicker10.Name = "seancePicker10";
            seancePicker10.NumeroSeance = 10;
            seance6.Absence = false;
            seance6.Active = false;
            seance6.Code = "";
            seance6.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance6.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 451);
            seance6.DateModifiedChecked = false;
            seance6.Employer = "";
            seance6.Montant = "";
            seance6.SceanceNumber = 10;
            seancePicker10.Seance = seance6;
            seancePicker10.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker10.Size = new System.Drawing.Size(790, 25);
            seancePicker10.TabIndex = 27;
            // 
            // seancePicker9
            // 
            seancePicker9.Absence = false;
            seancePicker9.Checked = false;
            seancePicker9.Code = "";
            seancePicker9.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 461);
            seancePicker9.DateModifiedChecked = false;
            seancePicker9.Employer = "";
            seancePicker9.Location = new System.Drawing.Point(8, 250);
            seancePicker9.Margin = new Padding(3, 1, 3, 2);
            seancePicker9.Name = "seancePicker9";
            seancePicker9.NumeroSeance = 9;
            seance7.Absence = false;
            seance7.Active = false;
            seance7.Code = "";
            seance7.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance7.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 461);
            seance7.DateModifiedChecked = false;
            seance7.Employer = "";
            seance7.Montant = "";
            seance7.SceanceNumber = 9;
            seancePicker9.Seance = seance7;
            seancePicker9.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker9.Size = new System.Drawing.Size(790, 25);
            seancePicker9.TabIndex = 26;
            // 
            // seancePicker8
            // 
            seancePicker8.Absence = false;
            seancePicker8.Checked = false;
            seancePicker8.Code = "";
            seancePicker8.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 481);
            seancePicker8.DateModifiedChecked = false;
            seancePicker8.Employer = "";
            seancePicker8.Location = new System.Drawing.Point(8, 223);
            seancePicker8.Margin = new Padding(3, 1, 3, 2);
            seancePicker8.Name = "seancePicker8";
            seancePicker8.NumeroSeance = 8;
            seance8.Absence = false;
            seance8.Active = false;
            seance8.Code = "";
            seance8.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance8.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 481);
            seance8.DateModifiedChecked = false;
            seance8.Employer = "";
            seance8.Montant = "";
            seance8.SceanceNumber = 8;
            seancePicker8.Seance = seance8;
            seancePicker8.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker8.Size = new System.Drawing.Size(790, 25);
            seancePicker8.TabIndex = 25;
            // 
            // seancePicker7
            // 
            seancePicker7.Absence = false;
            seancePicker7.Checked = false;
            seancePicker7.Code = "";
            seancePicker7.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 491);
            seancePicker7.DateModifiedChecked = false;
            seancePicker7.Employer = "";
            seancePicker7.Location = new System.Drawing.Point(8, 196);
            seancePicker7.Margin = new Padding(3, 1, 3, 2);
            seancePicker7.Name = "seancePicker7";
            seancePicker7.NumeroSeance = 7;
            seance9.Absence = false;
            seance9.Active = false;
            seance9.Code = "";
            seance9.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance9.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 491);
            seance9.DateModifiedChecked = false;
            seance9.Employer = "";
            seance9.Montant = "";
            seance9.SceanceNumber = 7;
            seancePicker7.Seance = seance9;
            seancePicker7.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker7.Size = new System.Drawing.Size(790, 25);
            seancePicker7.TabIndex = 24;
            // 
            // seancePicker6
            // 
            seancePicker6.Absence = false;
            seancePicker6.Checked = false;
            seancePicker6.Code = "";
            seancePicker6.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 511);
            seancePicker6.DateModifiedChecked = false;
            seancePicker6.Employer = "";
            seancePicker6.Location = new System.Drawing.Point(8, 169);
            seancePicker6.Margin = new Padding(3, 1, 3, 2);
            seancePicker6.Name = "seancePicker6";
            seancePicker6.NumeroSeance = 6;
            seance10.Absence = false;
            seance10.Active = false;
            seance10.Code = "";
            seance10.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance10.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 511);
            seance10.DateModifiedChecked = false;
            seance10.Employer = "";
            seance10.Montant = "";
            seance10.SceanceNumber = 6;
            seancePicker6.Seance = seance10;
            seancePicker6.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker6.Size = new System.Drawing.Size(790, 25);
            seancePicker6.TabIndex = 23;
            // 
            // seancePicker5
            // 
            seancePicker5.Absence = false;
            seancePicker5.Checked = false;
            seancePicker5.Code = "";
            seancePicker5.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 521);
            seancePicker5.DateModifiedChecked = false;
            seancePicker5.Employer = "";
            seancePicker5.Location = new System.Drawing.Point(8, 142);
            seancePicker5.Margin = new Padding(3, 3, 3, 2);
            seancePicker5.Name = "seancePicker5";
            seancePicker5.NumeroSeance = 5;
            seance11.Absence = false;
            seance11.Active = false;
            seance11.Code = "";
            seance11.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance11.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 521);
            seance11.DateModifiedChecked = false;
            seance11.Employer = "";
            seance11.Montant = "";
            seance11.SceanceNumber = 5;
            seancePicker5.Seance = seance11;
            seancePicker5.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker5.Size = new System.Drawing.Size(790, 25);
            seancePicker5.TabIndex = 22;
            // 
            // seancePicker4
            // 
            seancePicker4.Absence = false;
            seancePicker4.Checked = false;
            seancePicker4.Code = "";
            seancePicker4.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 541);
            seancePicker4.DateModifiedChecked = false;
            seancePicker4.Employer = "";
            seancePicker4.Location = new System.Drawing.Point(8, 115);
            seancePicker4.Margin = new Padding(3, 3, 3, 2);
            seancePicker4.Name = "seancePicker4";
            seancePicker4.NumeroSeance = 4;
            seance12.Absence = false;
            seance12.Active = false;
            seance12.Code = "";
            seance12.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance12.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 541);
            seance12.DateModifiedChecked = false;
            seance12.Employer = "";
            seance12.Montant = "";
            seance12.SceanceNumber = 4;
            seancePicker4.Seance = seance12;
            seancePicker4.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker4.Size = new System.Drawing.Size(790, 25);
            seancePicker4.TabIndex = 21;
            // 
            // seancePicker3
            // 
            seancePicker3.Absence = false;
            seancePicker3.Checked = false;
            seancePicker3.Code = "";
            seancePicker3.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 551);
            seancePicker3.DateModifiedChecked = false;
            seancePicker3.Employer = "";
            seancePicker3.Location = new System.Drawing.Point(8, 88);
            seancePicker3.Margin = new Padding(3, 3, 3, 2);
            seancePicker3.Name = "seancePicker3";
            seancePicker3.NumeroSeance = 3;
            seance13.Absence = false;
            seance13.Active = false;
            seance13.Code = "";
            seance13.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance13.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 551);
            seance13.DateModifiedChecked = false;
            seance13.Employer = "";
            seance13.Montant = "";
            seance13.SceanceNumber = 3;
            seancePicker3.Seance = seance13;
            seancePicker3.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker3.Size = new System.Drawing.Size(790, 25);
            seancePicker3.TabIndex = 20;
            // 
            // seancePicker2
            // 
            seancePicker2.Absence = false;
            seancePicker2.Checked = false;
            seancePicker2.Code = "";
            seancePicker2.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 571);
            seancePicker2.DateModifiedChecked = false;
            seancePicker2.Employer = "";
            seancePicker2.Location = new System.Drawing.Point(8, 60);
            seancePicker2.Name = "seancePicker2";
            seancePicker2.NumeroSeance = 2;
            seance14.Absence = false;
            seance14.Active = false;
            seance14.Code = "";
            seance14.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance14.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 571);
            seance14.DateModifiedChecked = false;
            seance14.Employer = "";
            seance14.Montant = "";
            seance14.SceanceNumber = 2;
            seancePicker2.Seance = seance14;
            seancePicker2.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker2.Size = new System.Drawing.Size(790, 25);
            seancePicker2.TabIndex = 19;
            // 
            // seancePicker1
            // 
            seancePicker1.Absence = false;
            seancePicker1.Checked = false;
            seancePicker1.Code = "";
            seancePicker1.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 581);
            seancePicker1.DateModifiedChecked = false;
            seancePicker1.Employer = "";
            seancePicker1.Location = new System.Drawing.Point(8, 32);
            seancePicker1.Name = "seancePicker1";
            seancePicker1.NumeroSeance = 1;
            seance15.Absence = false;
            seance15.Active = false;
            seance15.Code = "";
            seance15.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance15.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 581);
            seance15.DateModifiedChecked = false;
            seance15.Employer = "";
            seance15.Montant = "";
            seance15.SceanceNumber = 1;
            seancePicker1.Seance = seance15;
            seancePicker1.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker1.Size = new System.Drawing.Size(790, 25);
            seancePicker1.TabIndex = 17;
            // 
            // imageList1
            // 
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "");
            // 
            // cmdPrint
            // 
            cmdPrint.ImageIndex = 0;
            cmdPrint.ImageList = imageList1;
            cmdPrint.Location = new System.Drawing.Point(805, 32);
            cmdPrint.Name = "cmdPrint";
            cmdPrint.Size = new System.Drawing.Size(51, 46);
            cmdPrint.TabIndex = 41;
            cmdPrint.Click += new EventHandler(cmdPrint_Click);
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(594, 7);
            label5.Margin = new Padding(3, 3, 3, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(59, 23);
            label5.TabIndex = 52;
            label5.Text = "Montant";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(277, 6);
            label4.Margin = new Padding(3, 3, 3, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(128, 23);
            label4.TabIndex = 51;
            label4.Text = "Heures (fin)";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(484, 6);
            label3.Margin = new Padding(3, 3, 3, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(97, 23);
            label3.TabIndex = 50;
            label3.Text = "Employé";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(411, 6);
            label2.Margin = new Padding(3, 3, 3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 23);
            label2.TabIndex = 49;
            label2.Text = "Code";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(90, 6);
            label1.Margin = new Padding(3, 3, 3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(200, 23);
            label1.TabIndex = 48;
            label1.Text = "Date et heure (début)";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSeanceGeneral
            // 
            ClientSize = new System.Drawing.Size(863, 511);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmdPrint);
            Controls.Add(seancePicker15);
            Controls.Add(seancePicker14);
            Controls.Add(seancePicker13);
            Controls.Add(seancePicker12);
            Controls.Add(seancePicker11);
            Controls.Add(seancePicker10);
            Controls.Add(seancePicker9);
            Controls.Add(seancePicker8);
            Controls.Add(seancePicker7);
            Controls.Add(seancePicker6);
            Controls.Add(seancePicker5);
            Controls.Add(seancePicker4);
            Controls.Add(seancePicker3);
            Controls.Add(seancePicker2);
            Controls.Add(seancePicker1);
            Controls.Add(cmdAnnuler);
            Controls.Add(cmdOK);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSeanceGeneral";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Séance de cours pratique : Automobile";
            ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, EventArgs e) {
            Close();
		}

		/// <summary>
		/// enregistrement des Seance
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cmdOK_Click(object sender, EventArgs e) 
		{
            //Suppression des seance en cours
            _client.Seances.Clear();
			
            if (seancePicker1.Checked == true) _client.Seances.Add(seancePicker1.Seance);
            if (seancePicker2.Checked == true) _client.Seances.Add(seancePicker2.Seance);
            if (seancePicker3.Checked == true) _client.Seances.Add(seancePicker3.Seance);
            if (seancePicker4.Checked == true) _client.Seances.Add(seancePicker4.Seance);
            if (seancePicker5.Checked == true) _client.Seances.Add(seancePicker5.Seance);
            if (seancePicker6.Checked == true) _client.Seances.Add(seancePicker6.Seance);
            if (seancePicker7.Checked == true) _client.Seances.Add(seancePicker7.Seance);
            if (seancePicker8.Checked == true) _client.Seances.Add(seancePicker8.Seance);
            if (seancePicker9.Checked == true) _client.Seances.Add(seancePicker9.Seance);
            if (seancePicker10.Checked == true) _client.Seances.Add(seancePicker10.Seance);
            if (seancePicker11.Checked == true) _client.Seances.Add(seancePicker11.Seance);
            if (seancePicker12.Checked == true) _client.Seances.Add(seancePicker12.Seance);
            if (seancePicker13.Checked == true) _client.Seances.Add(seancePicker13.Seance);
            if (seancePicker14.Checked == true) _client.Seances.Add(seancePicker14.Seance);
            if (seancePicker15.Checked == true) _client.Seances.Add(seancePicker15.Seance);

            //Fermer la boite
            Close();
		}

		private void InitializeSeance() {
            //Chargement de la liste des employés
			seancePicker1.ListEmploye = seancePicker2.ListEmploye =
					seancePicker3.ListEmploye = seancePicker4.ListEmploye =
					seancePicker5.ListEmploye = seancePicker6.ListEmploye =
					seancePicker7.ListEmploye = seancePicker8.ListEmploye =
					seancePicker9.ListEmploye = seancePicker10.ListEmploye =
					seancePicker11.ListEmploye = seancePicker12.ListEmploye =
                    seancePicker13.ListEmploye = seancePicker14.ListEmploye =
                    seancePicker15.ListEmploye = _ListEmploye;

            for (int i = 0; i < _client.Seances.Count; i++) {
                switch (_client.Seances[i].SceanceNumber) {
                    case 1:
                        seancePicker1.Seance = _client.Seances[i];
                        break;
                    case 2:
                        seancePicker2.Seance = _client.Seances[i];
                        break;
                    case 3:
                        seancePicker3.Seance = _client.Seances[i];
                        break;
                    case 4:
                        seancePicker4.Seance = _client.Seances[i];
                        break;
                    case 5:
                        seancePicker5.Seance = _client.Seances[i];
                        break;
                    case 6:
                        seancePicker6.Seance = _client.Seances[i];
                        break;
                    case 7:
                        seancePicker7.Seance = _client.Seances[i];
                        break;
                    case 8:
                        seancePicker8.Seance = _client.Seances[i];
                        break;
                    case 9:
                        seancePicker9.Seance = _client.Seances[i];
                        break;
                    case 10:
                        seancePicker10.Seance = _client.Seances[i];
                        break;
                    case 11:
                        seancePicker11.Seance = _client.Seances[i];
                        break;
                    case 12:
                        seancePicker12.Seance = _client.Seances[i];
                        break;
                    case 13:
                        seancePicker13.Seance = _client.Seances[i];
                        break;
                    case 14:
                        seancePicker14.Seance = _client.Seances[i];
                        break;
                    case 15:
                        seancePicker15.Seance = _client.Seances[i];
                        break;
                }
            }

        }

        private void cmdPrint_Click(object sender, EventArgs e) {
            AddSeanceTemp();

            _ctrlClient.Client = _client;
            _ctrlClient.PrintDoc(true, true, true, PrintDocumentType.InfoClient); 
        }

        private void AddSeanceTemp() {
            _ctrlClient.Client.Seances.Clear();

            _ctrlClient.Client.Seances.Add(seancePicker1.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker2.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker3.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker4.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker5.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker6.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker7.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker8.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker9.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker10.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker11.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker12.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker13.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker14.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker15.Seance);
        }
	}
}
