using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Barette.Library.UserControls;
using Barette.Library.Client;
using Barette.Library.Collections;

namespace Barette.Library.UserControls.Client {
	/// <summary>
	/// Description résumée de FormSeanceGeneral.
	/// </summary>
	public class FormSeanceGeneral : System.Windows.Forms.Form {		
		/// <summary>
		/// client referer
		/// </summary>
		private Customer _client;

        /// <summary>
        /// Control Client interne
        /// </summary>
        private ClientControl _ctrlClient;

		private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdAnnuler;
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

		private EmployeCollection _ListEmploye;

		public FormSeanceGeneral(Customer client, ClientControl ctrl, EmployeCollection ListEmploye) {
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			this._client = client;
            this._ctrlClient = ctrl;
			this._ListEmploye = ListEmploye;

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
            this.components = new System.ComponentModel.Container();
            Barette.Library.Client.Seance seance1 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance2 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance3 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance4 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance5 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance6 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance7 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance8 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance9 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance10 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance11 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance12 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance13 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance14 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance15 = new Barette.Library.Client.Seance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeanceGeneral));
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.seancePicker15 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker14 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker13 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker12 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker11 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker10 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker9 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker8 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker7 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker6 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker5 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker4 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker3 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker2 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker1 = new Barette.Library.UserControls.SeancePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmdPrint = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Image = global::Barette.Library.Properties.Resources.accept_icon;
            this.cmdOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdOK.Location = new System.Drawing.Point(670, 457);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(95, 45);
            this.cmdOK.TabIndex = 12;
            this.cmdOK.Text = "Appliquer";
            this.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAnnuler.Image = global::Barette.Library.Properties.Resources.Cancel_2_icon;
            this.cmdAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAnnuler.Location = new System.Drawing.Point(771, 457);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.Size = new System.Drawing.Size(85, 45);
            this.cmdAnnuler.TabIndex = 13;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAnnuler.Click += new System.EventHandler(this.button2_Click);
            // 
            // seancePicker15
            // 
            this.seancePicker15.Absence = false;
            this.seancePicker15.Checked = false;
            this.seancePicker15.Code = "";
            this.seancePicker15.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 390);
            this.seancePicker15.DateModifiedChecked = false;
            this.seancePicker15.Employer = "";
            this.seancePicker15.Location = new System.Drawing.Point(8, 422);
            this.seancePicker15.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.seancePicker15.Name = "seancePicker15";
            this.seancePicker15.NumeroSeance = 15;
            seance1.Absence = false;
            seance1.Active = false;
            seance1.Code = "";
            seance1.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance1.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 390);
            seance1.DateModifiedChecked = false;
            seance1.Employer = "";
            seance1.Montant = "";
            seance1.SceanceNumber = 15;
            this.seancePicker15.Seance = seance1;
            this.seancePicker15.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker15.Size = new System.Drawing.Size(790, 25);
            this.seancePicker15.TabIndex = 33;
            // 
            // seancePicker14
            // 
            this.seancePicker14.Absence = false;
            this.seancePicker14.Checked = false;
            this.seancePicker14.Code = "";
            this.seancePicker14.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 390);
            this.seancePicker14.DateModifiedChecked = false;
            this.seancePicker14.Employer = "";
            this.seancePicker14.Location = new System.Drawing.Point(8, 393);
            this.seancePicker14.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.seancePicker14.Name = "seancePicker14";
            this.seancePicker14.NumeroSeance = 14;
            seance2.Absence = false;
            seance2.Active = false;
            seance2.Code = "";
            seance2.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance2.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 390);
            seance2.DateModifiedChecked = false;
            seance2.Employer = "";
            seance2.Montant = "";
            seance2.SceanceNumber = 14;
            this.seancePicker14.Seance = seance2;
            this.seancePicker14.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker14.Size = new System.Drawing.Size(790, 25);
            this.seancePicker14.TabIndex = 32;
            // 
            // seancePicker13
            // 
            this.seancePicker13.Absence = false;
            this.seancePicker13.Checked = false;
            this.seancePicker13.Code = "";
            this.seancePicker13.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 390);
            this.seancePicker13.DateModifiedChecked = false;
            this.seancePicker13.Employer = "";
            this.seancePicker13.Location = new System.Drawing.Point(8, 364);
            this.seancePicker13.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.seancePicker13.Name = "seancePicker13";
            this.seancePicker13.NumeroSeance = 13;
            seance3.Absence = false;
            seance3.Active = false;
            seance3.Code = "";
            seance3.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance3.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 390);
            seance3.DateModifiedChecked = false;
            seance3.Employer = "";
            seance3.Montant = "";
            seance3.SceanceNumber = 13;
            this.seancePicker13.Seance = seance3;
            this.seancePicker13.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker13.Size = new System.Drawing.Size(790, 25);
            this.seancePicker13.TabIndex = 31;
            // 
            // seancePicker12
            // 
            this.seancePicker12.Absence = false;
            this.seancePicker12.Checked = false;
            this.seancePicker12.Code = "";
            this.seancePicker12.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 390);
            this.seancePicker12.DateModifiedChecked = false;
            this.seancePicker12.Employer = "";
            this.seancePicker12.Location = new System.Drawing.Point(8, 335);
            this.seancePicker12.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.seancePicker12.Name = "seancePicker12";
            this.seancePicker12.NumeroSeance = 12;
            seance4.Absence = false;
            seance4.Active = false;
            seance4.Code = "";
            seance4.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance4.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 390);
            seance4.DateModifiedChecked = false;
            seance4.Employer = "";
            seance4.Montant = "";
            seance4.SceanceNumber = 12;
            this.seancePicker12.Seance = seance4;
            this.seancePicker12.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker12.Size = new System.Drawing.Size(790, 25);
            this.seancePicker12.TabIndex = 29;
            // 
            // seancePicker11
            // 
            this.seancePicker11.Absence = false;
            this.seancePicker11.Checked = false;
            this.seancePicker11.Code = "";
            this.seancePicker11.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 431);
            this.seancePicker11.DateModifiedChecked = false;
            this.seancePicker11.Employer = "";
            this.seancePicker11.Location = new System.Drawing.Point(8, 307);
            this.seancePicker11.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.seancePicker11.Name = "seancePicker11";
            this.seancePicker11.NumeroSeance = 11;
            seance5.Absence = false;
            seance5.Active = false;
            seance5.Code = "";
            seance5.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance5.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 431);
            seance5.DateModifiedChecked = false;
            seance5.Employer = "";
            seance5.Montant = "";
            seance5.SceanceNumber = 11;
            this.seancePicker11.Seance = seance5;
            this.seancePicker11.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker11.Size = new System.Drawing.Size(790, 25);
            this.seancePicker11.TabIndex = 28;
            // 
            // seancePicker10
            // 
            this.seancePicker10.Absence = false;
            this.seancePicker10.Checked = false;
            this.seancePicker10.Code = "";
            this.seancePicker10.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 451);
            this.seancePicker10.DateModifiedChecked = false;
            this.seancePicker10.Employer = "";
            this.seancePicker10.Location = new System.Drawing.Point(8, 279);
            this.seancePicker10.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.seancePicker10.Name = "seancePicker10";
            this.seancePicker10.NumeroSeance = 10;
            seance6.Absence = false;
            seance6.Active = false;
            seance6.Code = "";
            seance6.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance6.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 451);
            seance6.DateModifiedChecked = false;
            seance6.Employer = "";
            seance6.Montant = "";
            seance6.SceanceNumber = 10;
            this.seancePicker10.Seance = seance6;
            this.seancePicker10.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker10.Size = new System.Drawing.Size(790, 25);
            this.seancePicker10.TabIndex = 27;
            // 
            // seancePicker9
            // 
            this.seancePicker9.Absence = false;
            this.seancePicker9.Checked = false;
            this.seancePicker9.Code = "";
            this.seancePicker9.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 461);
            this.seancePicker9.DateModifiedChecked = false;
            this.seancePicker9.Employer = "";
            this.seancePicker9.Location = new System.Drawing.Point(8, 250);
            this.seancePicker9.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.seancePicker9.Name = "seancePicker9";
            this.seancePicker9.NumeroSeance = 9;
            seance7.Absence = false;
            seance7.Active = false;
            seance7.Code = "";
            seance7.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance7.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 461);
            seance7.DateModifiedChecked = false;
            seance7.Employer = "";
            seance7.Montant = "";
            seance7.SceanceNumber = 9;
            this.seancePicker9.Seance = seance7;
            this.seancePicker9.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker9.Size = new System.Drawing.Size(790, 25);
            this.seancePicker9.TabIndex = 26;
            // 
            // seancePicker8
            // 
            this.seancePicker8.Absence = false;
            this.seancePicker8.Checked = false;
            this.seancePicker8.Code = "";
            this.seancePicker8.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 481);
            this.seancePicker8.DateModifiedChecked = false;
            this.seancePicker8.Employer = "";
            this.seancePicker8.Location = new System.Drawing.Point(8, 223);
            this.seancePicker8.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.seancePicker8.Name = "seancePicker8";
            this.seancePicker8.NumeroSeance = 8;
            seance8.Absence = false;
            seance8.Active = false;
            seance8.Code = "";
            seance8.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance8.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 481);
            seance8.DateModifiedChecked = false;
            seance8.Employer = "";
            seance8.Montant = "";
            seance8.SceanceNumber = 8;
            this.seancePicker8.Seance = seance8;
            this.seancePicker8.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker8.Size = new System.Drawing.Size(790, 25);
            this.seancePicker8.TabIndex = 25;
            // 
            // seancePicker7
            // 
            this.seancePicker7.Absence = false;
            this.seancePicker7.Checked = false;
            this.seancePicker7.Code = "";
            this.seancePicker7.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 491);
            this.seancePicker7.DateModifiedChecked = false;
            this.seancePicker7.Employer = "";
            this.seancePicker7.Location = new System.Drawing.Point(8, 196);
            this.seancePicker7.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.seancePicker7.Name = "seancePicker7";
            this.seancePicker7.NumeroSeance = 7;
            seance9.Absence = false;
            seance9.Active = false;
            seance9.Code = "";
            seance9.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance9.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 491);
            seance9.DateModifiedChecked = false;
            seance9.Employer = "";
            seance9.Montant = "";
            seance9.SceanceNumber = 7;
            this.seancePicker7.Seance = seance9;
            this.seancePicker7.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker7.Size = new System.Drawing.Size(790, 25);
            this.seancePicker7.TabIndex = 24;
            // 
            // seancePicker6
            // 
            this.seancePicker6.Absence = false;
            this.seancePicker6.Checked = false;
            this.seancePicker6.Code = "";
            this.seancePicker6.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 511);
            this.seancePicker6.DateModifiedChecked = false;
            this.seancePicker6.Employer = "";
            this.seancePicker6.Location = new System.Drawing.Point(8, 169);
            this.seancePicker6.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.seancePicker6.Name = "seancePicker6";
            this.seancePicker6.NumeroSeance = 6;
            seance10.Absence = false;
            seance10.Active = false;
            seance10.Code = "";
            seance10.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance10.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 511);
            seance10.DateModifiedChecked = false;
            seance10.Employer = "";
            seance10.Montant = "";
            seance10.SceanceNumber = 6;
            this.seancePicker6.Seance = seance10;
            this.seancePicker6.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker6.Size = new System.Drawing.Size(790, 25);
            this.seancePicker6.TabIndex = 23;
            // 
            // seancePicker5
            // 
            this.seancePicker5.Absence = false;
            this.seancePicker5.Checked = false;
            this.seancePicker5.Code = "";
            this.seancePicker5.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 521);
            this.seancePicker5.DateModifiedChecked = false;
            this.seancePicker5.Employer = "";
            this.seancePicker5.Location = new System.Drawing.Point(8, 142);
            this.seancePicker5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.seancePicker5.Name = "seancePicker5";
            this.seancePicker5.NumeroSeance = 5;
            seance11.Absence = false;
            seance11.Active = false;
            seance11.Code = "";
            seance11.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance11.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 521);
            seance11.DateModifiedChecked = false;
            seance11.Employer = "";
            seance11.Montant = "";
            seance11.SceanceNumber = 5;
            this.seancePicker5.Seance = seance11;
            this.seancePicker5.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker5.Size = new System.Drawing.Size(790, 25);
            this.seancePicker5.TabIndex = 22;
            // 
            // seancePicker4
            // 
            this.seancePicker4.Absence = false;
            this.seancePicker4.Checked = false;
            this.seancePicker4.Code = "";
            this.seancePicker4.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 541);
            this.seancePicker4.DateModifiedChecked = false;
            this.seancePicker4.Employer = "";
            this.seancePicker4.Location = new System.Drawing.Point(8, 115);
            this.seancePicker4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.seancePicker4.Name = "seancePicker4";
            this.seancePicker4.NumeroSeance = 4;
            seance12.Absence = false;
            seance12.Active = false;
            seance12.Code = "";
            seance12.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance12.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 541);
            seance12.DateModifiedChecked = false;
            seance12.Employer = "";
            seance12.Montant = "";
            seance12.SceanceNumber = 4;
            this.seancePicker4.Seance = seance12;
            this.seancePicker4.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker4.Size = new System.Drawing.Size(790, 25);
            this.seancePicker4.TabIndex = 21;
            // 
            // seancePicker3
            // 
            this.seancePicker3.Absence = false;
            this.seancePicker3.Checked = false;
            this.seancePicker3.Code = "";
            this.seancePicker3.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 551);
            this.seancePicker3.DateModifiedChecked = false;
            this.seancePicker3.Employer = "";
            this.seancePicker3.Location = new System.Drawing.Point(8, 88);
            this.seancePicker3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.seancePicker3.Name = "seancePicker3";
            this.seancePicker3.NumeroSeance = 3;
            seance13.Absence = false;
            seance13.Active = false;
            seance13.Code = "";
            seance13.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance13.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 551);
            seance13.DateModifiedChecked = false;
            seance13.Employer = "";
            seance13.Montant = "";
            seance13.SceanceNumber = 3;
            this.seancePicker3.Seance = seance13;
            this.seancePicker3.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker3.Size = new System.Drawing.Size(790, 25);
            this.seancePicker3.TabIndex = 20;
            // 
            // seancePicker2
            // 
            this.seancePicker2.Absence = false;
            this.seancePicker2.Checked = false;
            this.seancePicker2.Code = "";
            this.seancePicker2.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 571);
            this.seancePicker2.DateModifiedChecked = false;
            this.seancePicker2.Employer = "";
            this.seancePicker2.Location = new System.Drawing.Point(8, 60);
            this.seancePicker2.Name = "seancePicker2";
            this.seancePicker2.NumeroSeance = 2;
            seance14.Absence = false;
            seance14.Active = false;
            seance14.Code = "";
            seance14.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance14.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 571);
            seance14.DateModifiedChecked = false;
            seance14.Employer = "";
            seance14.Montant = "";
            seance14.SceanceNumber = 2;
            this.seancePicker2.Seance = seance14;
            this.seancePicker2.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker2.Size = new System.Drawing.Size(790, 25);
            this.seancePicker2.TabIndex = 19;
            // 
            // seancePicker1
            // 
            this.seancePicker1.Absence = false;
            this.seancePicker1.Checked = false;
            this.seancePicker1.Code = "";
            this.seancePicker1.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 581);
            this.seancePicker1.DateModifiedChecked = false;
            this.seancePicker1.Employer = "";
            this.seancePicker1.Location = new System.Drawing.Point(8, 32);
            this.seancePicker1.Name = "seancePicker1";
            this.seancePicker1.NumeroSeance = 1;
            seance15.Absence = false;
            seance15.Active = false;
            seance15.Code = "";
            seance15.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance15.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 581);
            seance15.DateModifiedChecked = false;
            seance15.Employer = "";
            seance15.Montant = "";
            seance15.SceanceNumber = 1;
            this.seancePicker1.Seance = seance15;
            this.seancePicker1.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker1.Size = new System.Drawing.Size(790, 25);
            this.seancePicker1.TabIndex = 17;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // cmdPrint
            // 
            this.cmdPrint.ImageIndex = 0;
            this.cmdPrint.ImageList = this.imageList1;
            this.cmdPrint.Location = new System.Drawing.Point(805, 32);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(51, 46);
            this.cmdPrint.TabIndex = 41;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(594, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 52;
            this.label5.Text = "Montant";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 51;
            this.label4.Text = "Heures (fin)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 50;
            this.label3.Text = "Employé";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 49;
            this.label2.Text = "Code";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 48;
            this.label1.Text = "Date et heure (début)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSeanceGeneral
            // 
            this.ClientSize = new System.Drawing.Size(863, 511);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdPrint);
            this.Controls.Add(this.seancePicker15);
            this.Controls.Add(this.seancePicker14);
            this.Controls.Add(this.seancePicker13);
            this.Controls.Add(this.seancePicker12);
            this.Controls.Add(this.seancePicker11);
            this.Controls.Add(this.seancePicker10);
            this.Controls.Add(this.seancePicker9);
            this.Controls.Add(this.seancePicker8);
            this.Controls.Add(this.seancePicker7);
            this.Controls.Add(this.seancePicker6);
            this.Controls.Add(this.seancePicker5);
            this.Controls.Add(this.seancePicker4);
            this.Controls.Add(this.seancePicker3);
            this.Controls.Add(this.seancePicker2);
            this.Controls.Add(this.seancePicker1);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSeanceGeneral";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Séance de cours pratique : Automobile";
            this.ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e) {
			this.Close();
		}

		/// <summary>
		/// enregistrement des Seance
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cmdOK_Click(object sender, System.EventArgs e) 
		{
			//Suppression des seance en cours
			this._client.Seances.Clear();
			
            if (seancePicker1.Checked == true) this._client.Seances.Add(seancePicker1.Seance);
            if (seancePicker2.Checked == true) this._client.Seances.Add(seancePicker2.Seance);
            if (seancePicker3.Checked == true) this._client.Seances.Add(seancePicker3.Seance);
            if (seancePicker4.Checked == true) this._client.Seances.Add(seancePicker4.Seance);
            if (seancePicker5.Checked == true) this._client.Seances.Add(seancePicker5.Seance);
            if (seancePicker6.Checked == true) this._client.Seances.Add(seancePicker6.Seance);
            if (seancePicker7.Checked == true) this._client.Seances.Add(seancePicker7.Seance);
            if (seancePicker8.Checked == true) this._client.Seances.Add(seancePicker8.Seance);
            if (seancePicker9.Checked == true) this._client.Seances.Add(seancePicker9.Seance);
            if (seancePicker10.Checked == true) this._client.Seances.Add(seancePicker10.Seance);
            if (seancePicker11.Checked == true) this._client.Seances.Add(seancePicker11.Seance);
            if (seancePicker12.Checked == true) this._client.Seances.Add(seancePicker12.Seance);
            if (seancePicker13.Checked == true) this._client.Seances.Add(seancePicker13.Seance);
            if (seancePicker14.Checked == true) this._client.Seances.Add(seancePicker14.Seance);
            if (seancePicker15.Checked == true) this._client.Seances.Add(seancePicker15.Seance);

			//Fermer la boite
			this.Close();
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
                    seancePicker15.ListEmploye = this._ListEmploye;

            for (int i = 0; i < this._client.Seances.Count; i++) {
                switch (this._client.Seances[i].SceanceNumber) {
                    case 1:
                        seancePicker1.Seance = this._client.Seances[i];
                        break;
                    case 2:
                        seancePicker2.Seance = this._client.Seances[i];
                        break;
                    case 3:
                        seancePicker3.Seance = this._client.Seances[i];
                        break;
                    case 4:
                        seancePicker4.Seance = this._client.Seances[i];
                        break;
                    case 5:
                        seancePicker5.Seance = this._client.Seances[i];
                        break;
                    case 6:
                        seancePicker6.Seance = this._client.Seances[i];
                        break;
                    case 7:
                        seancePicker7.Seance = this._client.Seances[i];
                        break;
                    case 8:
                        seancePicker8.Seance = this._client.Seances[i];
                        break;
                    case 9:
                        seancePicker9.Seance = this._client.Seances[i];
                        break;
                    case 10:
                        seancePicker10.Seance = this._client.Seances[i];
                        break;
                    case 11:
                        seancePicker11.Seance = this._client.Seances[i];
                        break;
                    case 12:
                        seancePicker12.Seance = this._client.Seances[i];
                        break;
                    case 13:
                        seancePicker13.Seance = this._client.Seances[i];
                        break;
                    case 14:
                        seancePicker14.Seance = this._client.Seances[i];
                        break;
                    case 15:
                        seancePicker15.Seance = this._client.Seances[i];
                        break;
                }
            }

        }

        private void cmdPrint_Click(object sender, EventArgs e) {
            AddSeanceTemp();

            this._ctrlClient.Client = this._client;
            this._ctrlClient.PrintDoc(true, true, true, PrintDocumentType.InfoClient); 
        }

        private void AddSeanceTemp() {
            this._ctrlClient.Client.Seances.Clear();

            this._ctrlClient.Client.Seances.Add(seancePicker1.Seance);
            this._ctrlClient.Client.Seances.Add(seancePicker2.Seance);
            this._ctrlClient.Client.Seances.Add(seancePicker3.Seance);
            this._ctrlClient.Client.Seances.Add(seancePicker4.Seance);
            this._ctrlClient.Client.Seances.Add(seancePicker5.Seance);
            this._ctrlClient.Client.Seances.Add(seancePicker6.Seance);
            this._ctrlClient.Client.Seances.Add(seancePicker7.Seance);
            this._ctrlClient.Client.Seances.Add(seancePicker8.Seance);
            this._ctrlClient.Client.Seances.Add(seancePicker9.Seance);
            this._ctrlClient.Client.Seances.Add(seancePicker10.Seance);
            this._ctrlClient.Client.Seances.Add(seancePicker11.Seance);
            this._ctrlClient.Client.Seances.Add(seancePicker12.Seance);
            this._ctrlClient.Client.Seances.Add(seancePicker13.Seance);
            this._ctrlClient.Client.Seances.Add(seancePicker14.Seance);
            this._ctrlClient.Client.Seances.Add(seancePicker15.Seance);
        }
	}
}
