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
	public class FormSeanceTheorique : System.Windows.Forms.Form {		
		/// <summary>
		/// client referer
		/// </summary>
        private Customer _client;
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private Button cmdAnnuler;
        private Button cmdOK;
        private ImageList imageList1;
        private Button cmdPrint;

		private EmployeCollection _ListEmploye;
        private ClientControl _ctrlClient;

        public FormSeanceTheorique(Customer client, ClientControl ctrl, EmployeCollection ListEmploye) {
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			this._client = client;
            this._ctrlClient = ctrl;
			this._ListEmploye = ListEmploye;

			InitializeSeance();
			
            ////teste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeanceTheorique));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Barette.Library.Properties.Resources.new_2;
            this.pictureBox2.Location = new System.Drawing.Point(12, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Barette.Library.Properties.Resources.new_3;
            this.pictureBox3.Location = new System.Drawing.Point(12, 94);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Barette.Library.Properties.Resources.new_4;
            this.pictureBox4.Location = new System.Drawing.Point(12, 135);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Barette.Library.Properties.Resources.new_5;
            this.pictureBox5.Location = new System.Drawing.Point(12, 176);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 35);
            this.pictureBox5.TabIndex = 35;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Barette.Library.Properties.Resources.new_6;
            this.pictureBox6.Location = new System.Drawing.Point(12, 217);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 35);
            this.pictureBox6.TabIndex = 36;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Barette.Library.Properties.Resources.new_7;
            this.pictureBox7.Location = new System.Drawing.Point(12, 258);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(35, 35);
            this.pictureBox7.TabIndex = 37;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Barette.Library.Properties.Resources.new_8;
            this.pictureBox8.Location = new System.Drawing.Point(12, 299);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(35, 35);
            this.pictureBox8.TabIndex = 38;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Barette.Library.Properties.Resources.new_9;
            this.pictureBox9.Location = new System.Drawing.Point(12, 340);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(35, 35);
            this.pictureBox9.TabIndex = 39;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Barette.Library.Properties.Resources.new_10;
            this.pictureBox10.Location = new System.Drawing.Point(12, 381);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(35, 35);
            this.pictureBox10.TabIndex = 40;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Barette.Library.Properties.Resources.new_11;
            this.pictureBox11.Location = new System.Drawing.Point(12, 422);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(35, 35);
            this.pictureBox11.TabIndex = 41;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::Barette.Library.Properties.Resources.new_12;
            this.pictureBox12.Location = new System.Drawing.Point(12, 463);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(35, 35);
            this.pictureBox12.TabIndex = 42;
            this.pictureBox12.TabStop = false;
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAnnuler.Image = global::Barette.Library.Properties.Resources.Cancel_2_icon;
            this.cmdAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAnnuler.Location = new System.Drawing.Point(296, 502);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.Size = new System.Drawing.Size(85, 45);
            this.cmdAnnuler.TabIndex = 44;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAnnuler.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Image = global::Barette.Library.Properties.Resources.accept_icon;
            this.cmdOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdOK.Location = new System.Drawing.Point(195, 502);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(95, 45);
            this.cmdOK.TabIndex = 43;
            this.cmdOK.Text = "Appliquer";
            this.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // seancePicker12
            // 
            this.seancePicker12.Absence = false;
            this.seancePicker12.Checked = false;
            this.seancePicker12.Code = "";
            this.seancePicker12.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 666);
            this.seancePicker12.DateModifiedChecked = false;
            this.seancePicker12.Employer = "";
            this.seancePicker12.Location = new System.Drawing.Point(53, 468);
            this.seancePicker12.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.seancePicker12.Name = "seancePicker12";
            this.seancePicker12.NumeroSeance = 12;
            seance1.Absence = false;
            seance1.Active = false;
            seance1.Code = "";
            seance1.DateHeure = new System.DateTime(2010, 3, 13, 8, 39, 43, 697);
            seance1.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 666);
            seance1.DateModifiedChecked = false;
            seance1.Employer = "";
            seance1.Montant = "";
            seance1.SceanceNumber = 12;
            this.seancePicker12.Seance = seance1;
            this.seancePicker12.SeanceDateTime = new System.DateTime(2010, 3, 13, 8, 39, 43, 697);
            this.seancePicker12.Size = new System.Drawing.Size(269, 25);
            this.seancePicker12.TabIndex = 29;
            // 
            // seancePicker11
            // 
            this.seancePicker11.Absence = false;
            this.seancePicker11.Checked = false;
            this.seancePicker11.Code = "";
            this.seancePicker11.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 666);
            this.seancePicker11.DateModifiedChecked = false;
            this.seancePicker11.Employer = "";
            this.seancePicker11.Location = new System.Drawing.Point(53, 427);
            this.seancePicker11.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.seancePicker11.Name = "seancePicker11";
            this.seancePicker11.NumeroSeance = 11;
            seance2.Absence = false;
            seance2.Active = false;
            seance2.Code = "";
            seance2.DateHeure = new System.DateTime(2010, 3, 13, 8, 39, 43, 697);
            seance2.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 666);
            seance2.DateModifiedChecked = false;
            seance2.Employer = "";
            seance2.Montant = "";
            seance2.SceanceNumber = 11;
            this.seancePicker11.Seance = seance2;
            this.seancePicker11.SeanceDateTime = new System.DateTime(2010, 3, 13, 8, 39, 43, 697);
            this.seancePicker11.Size = new System.Drawing.Size(269, 25);
            this.seancePicker11.TabIndex = 28;
            // 
            // seancePicker10
            // 
            this.seancePicker10.Absence = false;
            this.seancePicker10.Checked = false;
            this.seancePicker10.Code = "";
            this.seancePicker10.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 681);
            this.seancePicker10.DateModifiedChecked = false;
            this.seancePicker10.Employer = "";
            this.seancePicker10.Location = new System.Drawing.Point(53, 386);
            this.seancePicker10.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.seancePicker10.Name = "seancePicker10";
            this.seancePicker10.NumeroSeance = 10;
            seance3.Absence = false;
            seance3.Active = false;
            seance3.Code = "";
            seance3.DateHeure = new System.DateTime(2010, 3, 13, 8, 39, 43, 713);
            seance3.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 681);
            seance3.DateModifiedChecked = false;
            seance3.Employer = "";
            seance3.Montant = "";
            seance3.SceanceNumber = 10;
            this.seancePicker10.Seance = seance3;
            this.seancePicker10.SeanceDateTime = new System.DateTime(2010, 3, 13, 8, 39, 43, 713);
            this.seancePicker10.Size = new System.Drawing.Size(269, 25);
            this.seancePicker10.TabIndex = 27;
            // 
            // seancePicker9
            // 
            this.seancePicker9.Absence = false;
            this.seancePicker9.Checked = false;
            this.seancePicker9.Code = "";
            this.seancePicker9.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 681);
            this.seancePicker9.DateModifiedChecked = false;
            this.seancePicker9.Employer = "";
            this.seancePicker9.Location = new System.Drawing.Point(53, 345);
            this.seancePicker9.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.seancePicker9.Name = "seancePicker9";
            this.seancePicker9.NumeroSeance = 9;
            seance4.Absence = false;
            seance4.Active = false;
            seance4.Code = "";
            seance4.DateHeure = new System.DateTime(2010, 3, 13, 8, 39, 43, 713);
            seance4.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 681);
            seance4.DateModifiedChecked = false;
            seance4.Employer = "";
            seance4.Montant = "";
            seance4.SceanceNumber = 9;
            this.seancePicker9.Seance = seance4;
            this.seancePicker9.SeanceDateTime = new System.DateTime(2010, 3, 13, 8, 39, 43, 713);
            this.seancePicker9.Size = new System.Drawing.Size(269, 25);
            this.seancePicker9.TabIndex = 26;
            // 
            // seancePicker8
            // 
            this.seancePicker8.Absence = false;
            this.seancePicker8.Checked = false;
            this.seancePicker8.Code = "";
            this.seancePicker8.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 681);
            this.seancePicker8.DateModifiedChecked = false;
            this.seancePicker8.Employer = "";
            this.seancePicker8.Location = new System.Drawing.Point(53, 304);
            this.seancePicker8.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.seancePicker8.Name = "seancePicker8";
            this.seancePicker8.NumeroSeance = 8;
            seance5.Absence = false;
            seance5.Active = false;
            seance5.Code = "";
            seance5.DateHeure = new System.DateTime(2010, 3, 13, 8, 39, 43, 713);
            seance5.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 681);
            seance5.DateModifiedChecked = false;
            seance5.Employer = "";
            seance5.Montant = "";
            seance5.SceanceNumber = 8;
            this.seancePicker8.Seance = seance5;
            this.seancePicker8.SeanceDateTime = new System.DateTime(2010, 3, 13, 8, 39, 43, 713);
            this.seancePicker8.Size = new System.Drawing.Size(269, 25);
            this.seancePicker8.TabIndex = 25;
            // 
            // seancePicker7
            // 
            this.seancePicker7.Absence = false;
            this.seancePicker7.Checked = false;
            this.seancePicker7.Code = "";
            this.seancePicker7.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 681);
            this.seancePicker7.DateModifiedChecked = false;
            this.seancePicker7.Employer = "";
            this.seancePicker7.Location = new System.Drawing.Point(53, 263);
            this.seancePicker7.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.seancePicker7.Name = "seancePicker7";
            this.seancePicker7.NumeroSeance = 7;
            seance6.Absence = false;
            seance6.Active = false;
            seance6.Code = "";
            seance6.DateHeure = new System.DateTime(2010, 3, 13, 8, 39, 43, 713);
            seance6.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 681);
            seance6.DateModifiedChecked = false;
            seance6.Employer = "";
            seance6.Montant = "";
            seance6.SceanceNumber = 7;
            this.seancePicker7.Seance = seance6;
            this.seancePicker7.SeanceDateTime = new System.DateTime(2010, 3, 13, 8, 39, 43, 713);
            this.seancePicker7.Size = new System.Drawing.Size(269, 25);
            this.seancePicker7.TabIndex = 24;
            // 
            // seancePicker6
            // 
            this.seancePicker6.Absence = false;
            this.seancePicker6.Checked = false;
            this.seancePicker6.Code = "";
            this.seancePicker6.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 681);
            this.seancePicker6.DateModifiedChecked = false;
            this.seancePicker6.Employer = "";
            this.seancePicker6.Location = new System.Drawing.Point(53, 222);
            this.seancePicker6.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.seancePicker6.Name = "seancePicker6";
            this.seancePicker6.NumeroSeance = 6;
            seance7.Absence = false;
            seance7.Active = false;
            seance7.Code = "";
            seance7.DateHeure = new System.DateTime(2010, 3, 13, 8, 39, 43, 728);
            seance7.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 681);
            seance7.DateModifiedChecked = false;
            seance7.Employer = "";
            seance7.Montant = "";
            seance7.SceanceNumber = 6;
            this.seancePicker6.Seance = seance7;
            this.seancePicker6.SeanceDateTime = new System.DateTime(2010, 3, 13, 8, 39, 43, 728);
            this.seancePicker6.Size = new System.Drawing.Size(269, 25);
            this.seancePicker6.TabIndex = 23;
            // 
            // seancePicker5
            // 
            this.seancePicker5.Absence = false;
            this.seancePicker5.Checked = false;
            this.seancePicker5.Code = "";
            this.seancePicker5.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 681);
            this.seancePicker5.DateModifiedChecked = false;
            this.seancePicker5.Employer = "";
            this.seancePicker5.Location = new System.Drawing.Point(53, 181);
            this.seancePicker5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.seancePicker5.Name = "seancePicker5";
            this.seancePicker5.NumeroSeance = 5;
            seance8.Absence = false;
            seance8.Active = false;
            seance8.Code = "";
            seance8.DateHeure = new System.DateTime(2010, 3, 13, 8, 39, 43, 728);
            seance8.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 681);
            seance8.DateModifiedChecked = false;
            seance8.Employer = "";
            seance8.Montant = "";
            seance8.SceanceNumber = 5;
            this.seancePicker5.Seance = seance8;
            this.seancePicker5.SeanceDateTime = new System.DateTime(2010, 3, 13, 8, 39, 43, 728);
            this.seancePicker5.Size = new System.Drawing.Size(269, 25);
            this.seancePicker5.TabIndex = 22;
            // 
            // seancePicker4
            // 
            this.seancePicker4.Absence = false;
            this.seancePicker4.Checked = false;
            this.seancePicker4.Code = "";
            this.seancePicker4.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 681);
            this.seancePicker4.DateModifiedChecked = false;
            this.seancePicker4.Employer = "";
            this.seancePicker4.Location = new System.Drawing.Point(53, 140);
            this.seancePicker4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.seancePicker4.Name = "seancePicker4";
            this.seancePicker4.NumeroSeance = 4;
            seance9.Absence = false;
            seance9.Active = false;
            seance9.Code = "";
            seance9.DateHeure = new System.DateTime(2010, 3, 13, 8, 39, 43, 728);
            seance9.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 681);
            seance9.DateModifiedChecked = false;
            seance9.Employer = "";
            seance9.Montant = "";
            seance9.SceanceNumber = 4;
            this.seancePicker4.Seance = seance9;
            this.seancePicker4.SeanceDateTime = new System.DateTime(2010, 3, 13, 8, 39, 43, 728);
            this.seancePicker4.Size = new System.Drawing.Size(269, 25);
            this.seancePicker4.TabIndex = 21;
            // 
            // seancePicker3
            // 
            this.seancePicker3.Absence = false;
            this.seancePicker3.Checked = false;
            this.seancePicker3.Code = "";
            this.seancePicker3.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 681);
            this.seancePicker3.DateModifiedChecked = false;
            this.seancePicker3.Employer = "";
            this.seancePicker3.Location = new System.Drawing.Point(53, 99);
            this.seancePicker3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.seancePicker3.Name = "seancePicker3";
            this.seancePicker3.NumeroSeance = 3;
            seance10.Absence = false;
            seance10.Active = false;
            seance10.Code = "";
            seance10.DateHeure = new System.DateTime(2010, 3, 13, 8, 39, 43, 728);
            seance10.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 681);
            seance10.DateModifiedChecked = false;
            seance10.Employer = "";
            seance10.Montant = "";
            seance10.SceanceNumber = 3;
            this.seancePicker3.Seance = seance10;
            this.seancePicker3.SeanceDateTime = new System.DateTime(2010, 3, 13, 8, 39, 43, 728);
            this.seancePicker3.Size = new System.Drawing.Size(269, 25);
            this.seancePicker3.TabIndex = 20;
            // 
            // seancePicker2
            // 
            this.seancePicker2.Absence = false;
            this.seancePicker2.Checked = false;
            this.seancePicker2.Code = "";
            this.seancePicker2.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 681);
            this.seancePicker2.DateModifiedChecked = false;
            this.seancePicker2.Employer = "";
            this.seancePicker2.Location = new System.Drawing.Point(53, 58);
            this.seancePicker2.Name = "seancePicker2";
            this.seancePicker2.NumeroSeance = 2;
            seance11.Absence = false;
            seance11.Active = false;
            seance11.Code = "";
            seance11.DateHeure = new System.DateTime(2010, 3, 13, 8, 39, 43, 744);
            seance11.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 681);
            seance11.DateModifiedChecked = false;
            seance11.Employer = "";
            seance11.Montant = "";
            seance11.SceanceNumber = 2;
            this.seancePicker2.Seance = seance11;
            this.seancePicker2.SeanceDateTime = new System.DateTime(2010, 3, 13, 8, 39, 43, 744);
            this.seancePicker2.Size = new System.Drawing.Size(269, 25);
            this.seancePicker2.TabIndex = 19;
            // 
            // seancePicker1
            // 
            this.seancePicker1.Absence = false;
            this.seancePicker1.Checked = false;
            this.seancePicker1.Code = "";
            this.seancePicker1.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 681);
            this.seancePicker1.DateModifiedChecked = false;
            this.seancePicker1.Employer = "";
            this.seancePicker1.Location = new System.Drawing.Point(53, 17);
            this.seancePicker1.Name = "seancePicker1";
            this.seancePicker1.NumeroSeance = 1;
            seance12.Absence = false;
            seance12.Active = false;
            seance12.Code = "";
            seance12.DateHeure = new System.DateTime(2010, 3, 13, 8, 39, 43, 744);
            seance12.DateModified = new System.DateTime(2010, 3, 13, 8, 39, 43, 681);
            seance12.DateModifiedChecked = false;
            seance12.Employer = "";
            seance12.Montant = "";
            seance12.SceanceNumber = 1;
            this.seancePicker1.Seance = seance12;
            this.seancePicker1.SeanceDateTime = new System.DateTime(2010, 3, 13, 8, 39, 43, 744);
            this.seancePicker1.Size = new System.Drawing.Size(269, 25);
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
            this.cmdPrint.Location = new System.Drawing.Point(330, 17);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(51, 46);
            this.cmdPrint.TabIndex = 45;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // FormSeanceTheorique
            // 
            this.ClientSize = new System.Drawing.Size(396, 559);
            this.ControlBox = false;
            this.Controls.Add(this.cmdPrint);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSeanceTheorique";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Séance de cours théorique : Automobile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
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
			this._client.SeancesTheorique.Clear();
			
            if (seancePicker1.Checked == true) this._client.SeancesTheorique.Add(seancePicker1.Seance);
            if (seancePicker2.Checked == true) this._client.SeancesTheorique.Add(seancePicker2.Seance);
            if (seancePicker3.Checked == true) this._client.SeancesTheorique.Add(seancePicker3.Seance);
            if (seancePicker4.Checked == true) this._client.SeancesTheorique.Add(seancePicker4.Seance);
            if (seancePicker5.Checked == true) this._client.SeancesTheorique.Add(seancePicker5.Seance);
            if (seancePicker6.Checked == true) this._client.SeancesTheorique.Add(seancePicker6.Seance);
            if (seancePicker7.Checked == true) this._client.SeancesTheorique.Add(seancePicker7.Seance);
            if (seancePicker8.Checked == true) this._client.SeancesTheorique.Add(seancePicker8.Seance);
            if (seancePicker9.Checked == true) this._client.SeancesTheorique.Add(seancePicker9.Seance);
            if (seancePicker10.Checked == true) this._client.SeancesTheorique.Add(seancePicker10.Seance);
            if (seancePicker11.Checked == true) this._client.SeancesTheorique.Add(seancePicker11.Seance);
            if (seancePicker12.Checked == true) this._client.SeancesTheorique.Add(seancePicker12.Seance);

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
					seancePicker11.ListEmploye = seancePicker12.ListEmploye = this._ListEmploye;

            for (int i = 0; i < this._client.SeancesTheorique.Count; i++) {
                switch (this._client.SeancesTheorique[i].SceanceNumber) {
                    case 1:
                        seancePicker1.Seance = this._client.SeancesTheorique[i];
                        break;
                    case 2:
                        seancePicker2.Seance = this._client.SeancesTheorique[i];
                        break;
                    case 3:
                        seancePicker3.Seance = this._client.SeancesTheorique[i];
                        break;
                    case 4:
                        seancePicker4.Seance = this._client.SeancesTheorique[i];
                        break;
                    case 5:
                        seancePicker5.Seance = this._client.SeancesTheorique[i];
                        break;
                    case 6:
                        seancePicker6.Seance = this._client.SeancesTheorique[i];
                        break;
                    case 7:
                        seancePicker7.Seance = this._client.SeancesTheorique[i];
                        break;
                    case 8:
                        seancePicker8.Seance = this._client.SeancesTheorique[i];
                        break;
                    case 9:
                        seancePicker9.Seance = this._client.SeancesTheorique[i];
                        break;
                    case 10:
                        seancePicker10.Seance = this._client.SeancesTheorique[i];
                        break;
                    case 11:
                        seancePicker11.Seance = this._client.SeancesTheorique[i];
                        break;
                    case 12:
                        seancePicker12.Seance = this._client.SeancesTheorique[i];
                        break;
                }
            }
		}

        private void cmdPrint_Click(object sender, EventArgs e) {
            AddSeanceTemp();

            this._ctrlClient.Client = this._client;
            this._ctrlClient.PrintDoc(true, true, true, PrintDocumentType.InfoClientTheorique);
        }

        private void AddSeanceTemp() {
            this._ctrlClient.Client.SeancesTheorique.Clear();

            this._ctrlClient.Client.SeancesTheorique.Add(seancePicker1.Seance);
            this._ctrlClient.Client.SeancesTheorique.Add(seancePicker2.Seance);
            this._ctrlClient.Client.SeancesTheorique.Add(seancePicker3.Seance);
            this._ctrlClient.Client.SeancesTheorique.Add(seancePicker4.Seance);
            this._ctrlClient.Client.SeancesTheorique.Add(seancePicker5.Seance);
            this._ctrlClient.Client.SeancesTheorique.Add(seancePicker6.Seance);
            this._ctrlClient.Client.SeancesTheorique.Add(seancePicker7.Seance);
            this._ctrlClient.Client.SeancesTheorique.Add(seancePicker8.Seance);
            this._ctrlClient.Client.SeancesTheorique.Add(seancePicker9.Seance);
            this._ctrlClient.Client.SeancesTheorique.Add(seancePicker10.Seance);
            this._ctrlClient.Client.SeancesTheorique.Add(seancePicker11.Seance);
            this._ctrlClient.Client.SeancesTheorique.Add(seancePicker12.Seance);
        }
	}
}
