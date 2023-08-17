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
    public class FormSeanceTheorique : Form
    {		
		/// <summary>
		/// client referer
		/// </summary>
        private readonly Customer _client;
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

		private readonly EmployeCollection _ListEmploye;
        private readonly ClientControl _ctrlClient;

        public FormSeanceTheorique(Customer client, ClientControl ctrl, EmployeCollection ListEmploye) {
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

            _client = client;
            _ctrlClient = ctrl;
            _ListEmploye = ListEmploye;

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
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormSeanceTheorique));
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            cmdAnnuler = new Button();
            cmdOK = new Button();
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
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            ((ISupportInitialize)pictureBox4).BeginInit();
            ((ISupportInitialize)pictureBox5).BeginInit();
            ((ISupportInitialize)pictureBox6).BeginInit();
            ((ISupportInitialize)pictureBox7).BeginInit();
            ((ISupportInitialize)pictureBox8).BeginInit();
            ((ISupportInitialize)pictureBox9).BeginInit();
            ((ISupportInitialize)pictureBox10).BeginInit();
            ((ISupportInitialize)pictureBox11).BeginInit();
            ((ISupportInitialize)pictureBox12).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(35, 35);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = global::Barette.Library.Properties.Resources.new_2;
            pictureBox2.Location = new System.Drawing.Point(12, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(35, 35);
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = global::Barette.Library.Properties.Resources.new_3;
            pictureBox3.Location = new System.Drawing.Point(12, 94);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(35, 35);
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = global::Barette.Library.Properties.Resources.new_4;
            pictureBox4.Location = new System.Drawing.Point(12, 135);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(35, 35);
            pictureBox4.TabIndex = 34;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = global::Barette.Library.Properties.Resources.new_5;
            pictureBox5.Location = new System.Drawing.Point(12, 176);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(35, 35);
            pictureBox5.TabIndex = 35;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = global::Barette.Library.Properties.Resources.new_6;
            pictureBox6.Location = new System.Drawing.Point(12, 217);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new System.Drawing.Size(35, 35);
            pictureBox6.TabIndex = 36;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = global::Barette.Library.Properties.Resources.new_7;
            pictureBox7.Location = new System.Drawing.Point(12, 258);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new System.Drawing.Size(35, 35);
            pictureBox7.TabIndex = 37;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = global::Barette.Library.Properties.Resources.new_8;
            pictureBox8.Location = new System.Drawing.Point(12, 299);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new System.Drawing.Size(35, 35);
            pictureBox8.TabIndex = 38;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = global::Barette.Library.Properties.Resources.new_9;
            pictureBox9.Location = new System.Drawing.Point(12, 340);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new System.Drawing.Size(35, 35);
            pictureBox9.TabIndex = 39;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = global::Barette.Library.Properties.Resources.new_10;
            pictureBox10.Location = new System.Drawing.Point(12, 381);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new System.Drawing.Size(35, 35);
            pictureBox10.TabIndex = 40;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = global::Barette.Library.Properties.Resources.new_11;
            pictureBox11.Location = new System.Drawing.Point(12, 422);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new System.Drawing.Size(35, 35);
            pictureBox11.TabIndex = 41;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = global::Barette.Library.Properties.Resources.new_12;
            pictureBox12.Location = new System.Drawing.Point(12, 463);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new System.Drawing.Size(35, 35);
            pictureBox12.TabIndex = 42;
            pictureBox12.TabStop = false;
            // 
            // cmdAnnuler
            // 
            cmdAnnuler.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            cmdAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cmdAnnuler.Image = global::Barette.Library.Properties.Resources.Cancel_2_icon;
            cmdAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cmdAnnuler.Location = new System.Drawing.Point(296, 502);
            cmdAnnuler.Name = "cmdAnnuler";
            cmdAnnuler.Size = new System.Drawing.Size(85, 45);
            cmdAnnuler.TabIndex = 44;
            cmdAnnuler.Text = "Annuler";
            cmdAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cmdAnnuler.Click += new EventHandler(button2_Click);
            // 
            // cmdOK
            // 
            cmdOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            cmdOK.Image = global::Barette.Library.Properties.Resources.accept_icon;
            cmdOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cmdOK.Location = new System.Drawing.Point(195, 502);
            cmdOK.Name = "cmdOK";
            cmdOK.Size = new System.Drawing.Size(95, 45);
            cmdOK.TabIndex = 43;
            cmdOK.Text = "Appliquer";
            cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cmdOK.Click += new EventHandler(cmdOK_Click);
            // 
            // seancePicker12
            // 
            seancePicker12.Absence = false;
            seancePicker12.Checked = false;
            seancePicker12.Code = "";
            seancePicker12.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 666);
            seancePicker12.DateModifiedChecked = false;
            seancePicker12.Employer = "";
            seancePicker12.Location = new System.Drawing.Point(53, 468);
            seancePicker12.Margin = new Padding(3, 1, 3, 3);
            seancePicker12.Name = "seancePicker12";
            seancePicker12.NumeroSeance = 12;
            seance1.Absence = false;
            seance1.Active = false;
            seance1.Code = "";
            seance1.DateHeure = new DateTime(2010, 3, 13, 8, 39, 43, 697);
            seance1.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 666);
            seance1.DateModifiedChecked = false;
            seance1.Employer = "";
            seance1.Montant = "";
            seance1.SceanceNumber = 12;
            seancePicker12.Seance = seance1;
            seancePicker12.SeanceDateTime = new DateTime(2010, 3, 13, 8, 39, 43, 697);
            seancePicker12.Size = new System.Drawing.Size(269, 25);
            seancePicker12.TabIndex = 29;
            // 
            // seancePicker11
            // 
            seancePicker11.Absence = false;
            seancePicker11.Checked = false;
            seancePicker11.Code = "";
            seancePicker11.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 666);
            seancePicker11.DateModifiedChecked = false;
            seancePicker11.Employer = "";
            seancePicker11.Location = new System.Drawing.Point(53, 427);
            seancePicker11.Margin = new Padding(3, 1, 3, 3);
            seancePicker11.Name = "seancePicker11";
            seancePicker11.NumeroSeance = 11;
            seance2.Absence = false;
            seance2.Active = false;
            seance2.Code = "";
            seance2.DateHeure = new DateTime(2010, 3, 13, 8, 39, 43, 697);
            seance2.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 666);
            seance2.DateModifiedChecked = false;
            seance2.Employer = "";
            seance2.Montant = "";
            seance2.SceanceNumber = 11;
            seancePicker11.Seance = seance2;
            seancePicker11.SeanceDateTime = new DateTime(2010, 3, 13, 8, 39, 43, 697);
            seancePicker11.Size = new System.Drawing.Size(269, 25);
            seancePicker11.TabIndex = 28;
            // 
            // seancePicker10
            // 
            seancePicker10.Absence = false;
            seancePicker10.Checked = false;
            seancePicker10.Code = "";
            seancePicker10.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 681);
            seancePicker10.DateModifiedChecked = false;
            seancePicker10.Employer = "";
            seancePicker10.Location = new System.Drawing.Point(53, 386);
            seancePicker10.Margin = new Padding(3, 1, 3, 3);
            seancePicker10.Name = "seancePicker10";
            seancePicker10.NumeroSeance = 10;
            seance3.Absence = false;
            seance3.Active = false;
            seance3.Code = "";
            seance3.DateHeure = new DateTime(2010, 3, 13, 8, 39, 43, 713);
            seance3.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 681);
            seance3.DateModifiedChecked = false;
            seance3.Employer = "";
            seance3.Montant = "";
            seance3.SceanceNumber = 10;
            seancePicker10.Seance = seance3;
            seancePicker10.SeanceDateTime = new DateTime(2010, 3, 13, 8, 39, 43, 713);
            seancePicker10.Size = new System.Drawing.Size(269, 25);
            seancePicker10.TabIndex = 27;
            // 
            // seancePicker9
            // 
            seancePicker9.Absence = false;
            seancePicker9.Checked = false;
            seancePicker9.Code = "";
            seancePicker9.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 681);
            seancePicker9.DateModifiedChecked = false;
            seancePicker9.Employer = "";
            seancePicker9.Location = new System.Drawing.Point(53, 345);
            seancePicker9.Margin = new Padding(3, 1, 3, 2);
            seancePicker9.Name = "seancePicker9";
            seancePicker9.NumeroSeance = 9;
            seance4.Absence = false;
            seance4.Active = false;
            seance4.Code = "";
            seance4.DateHeure = new DateTime(2010, 3, 13, 8, 39, 43, 713);
            seance4.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 681);
            seance4.DateModifiedChecked = false;
            seance4.Employer = "";
            seance4.Montant = "";
            seance4.SceanceNumber = 9;
            seancePicker9.Seance = seance4;
            seancePicker9.SeanceDateTime = new DateTime(2010, 3, 13, 8, 39, 43, 713);
            seancePicker9.Size = new System.Drawing.Size(269, 25);
            seancePicker9.TabIndex = 26;
            // 
            // seancePicker8
            // 
            seancePicker8.Absence = false;
            seancePicker8.Checked = false;
            seancePicker8.Code = "";
            seancePicker8.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 681);
            seancePicker8.DateModifiedChecked = false;
            seancePicker8.Employer = "";
            seancePicker8.Location = new System.Drawing.Point(53, 304);
            seancePicker8.Margin = new Padding(3, 1, 3, 2);
            seancePicker8.Name = "seancePicker8";
            seancePicker8.NumeroSeance = 8;
            seance5.Absence = false;
            seance5.Active = false;
            seance5.Code = "";
            seance5.DateHeure = new DateTime(2010, 3, 13, 8, 39, 43, 713);
            seance5.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 681);
            seance5.DateModifiedChecked = false;
            seance5.Employer = "";
            seance5.Montant = "";
            seance5.SceanceNumber = 8;
            seancePicker8.Seance = seance5;
            seancePicker8.SeanceDateTime = new DateTime(2010, 3, 13, 8, 39, 43, 713);
            seancePicker8.Size = new System.Drawing.Size(269, 25);
            seancePicker8.TabIndex = 25;
            // 
            // seancePicker7
            // 
            seancePicker7.Absence = false;
            seancePicker7.Checked = false;
            seancePicker7.Code = "";
            seancePicker7.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 681);
            seancePicker7.DateModifiedChecked = false;
            seancePicker7.Employer = "";
            seancePicker7.Location = new System.Drawing.Point(53, 263);
            seancePicker7.Margin = new Padding(3, 1, 3, 2);
            seancePicker7.Name = "seancePicker7";
            seancePicker7.NumeroSeance = 7;
            seance6.Absence = false;
            seance6.Active = false;
            seance6.Code = "";
            seance6.DateHeure = new DateTime(2010, 3, 13, 8, 39, 43, 713);
            seance6.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 681);
            seance6.DateModifiedChecked = false;
            seance6.Employer = "";
            seance6.Montant = "";
            seance6.SceanceNumber = 7;
            seancePicker7.Seance = seance6;
            seancePicker7.SeanceDateTime = new DateTime(2010, 3, 13, 8, 39, 43, 713);
            seancePicker7.Size = new System.Drawing.Size(269, 25);
            seancePicker7.TabIndex = 24;
            // 
            // seancePicker6
            // 
            seancePicker6.Absence = false;
            seancePicker6.Checked = false;
            seancePicker6.Code = "";
            seancePicker6.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 681);
            seancePicker6.DateModifiedChecked = false;
            seancePicker6.Employer = "";
            seancePicker6.Location = new System.Drawing.Point(53, 222);
            seancePicker6.Margin = new Padding(3, 1, 3, 2);
            seancePicker6.Name = "seancePicker6";
            seancePicker6.NumeroSeance = 6;
            seance7.Absence = false;
            seance7.Active = false;
            seance7.Code = "";
            seance7.DateHeure = new DateTime(2010, 3, 13, 8, 39, 43, 728);
            seance7.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 681);
            seance7.DateModifiedChecked = false;
            seance7.Employer = "";
            seance7.Montant = "";
            seance7.SceanceNumber = 6;
            seancePicker6.Seance = seance7;
            seancePicker6.SeanceDateTime = new DateTime(2010, 3, 13, 8, 39, 43, 728);
            seancePicker6.Size = new System.Drawing.Size(269, 25);
            seancePicker6.TabIndex = 23;
            // 
            // seancePicker5
            // 
            seancePicker5.Absence = false;
            seancePicker5.Checked = false;
            seancePicker5.Code = "";
            seancePicker5.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 681);
            seancePicker5.DateModifiedChecked = false;
            seancePicker5.Employer = "";
            seancePicker5.Location = new System.Drawing.Point(53, 181);
            seancePicker5.Margin = new Padding(3, 3, 3, 2);
            seancePicker5.Name = "seancePicker5";
            seancePicker5.NumeroSeance = 5;
            seance8.Absence = false;
            seance8.Active = false;
            seance8.Code = "";
            seance8.DateHeure = new DateTime(2010, 3, 13, 8, 39, 43, 728);
            seance8.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 681);
            seance8.DateModifiedChecked = false;
            seance8.Employer = "";
            seance8.Montant = "";
            seance8.SceanceNumber = 5;
            seancePicker5.Seance = seance8;
            seancePicker5.SeanceDateTime = new DateTime(2010, 3, 13, 8, 39, 43, 728);
            seancePicker5.Size = new System.Drawing.Size(269, 25);
            seancePicker5.TabIndex = 22;
            // 
            // seancePicker4
            // 
            seancePicker4.Absence = false;
            seancePicker4.Checked = false;
            seancePicker4.Code = "";
            seancePicker4.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 681);
            seancePicker4.DateModifiedChecked = false;
            seancePicker4.Employer = "";
            seancePicker4.Location = new System.Drawing.Point(53, 140);
            seancePicker4.Margin = new Padding(3, 3, 3, 2);
            seancePicker4.Name = "seancePicker4";
            seancePicker4.NumeroSeance = 4;
            seance9.Absence = false;
            seance9.Active = false;
            seance9.Code = "";
            seance9.DateHeure = new DateTime(2010, 3, 13, 8, 39, 43, 728);
            seance9.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 681);
            seance9.DateModifiedChecked = false;
            seance9.Employer = "";
            seance9.Montant = "";
            seance9.SceanceNumber = 4;
            seancePicker4.Seance = seance9;
            seancePicker4.SeanceDateTime = new DateTime(2010, 3, 13, 8, 39, 43, 728);
            seancePicker4.Size = new System.Drawing.Size(269, 25);
            seancePicker4.TabIndex = 21;
            // 
            // seancePicker3
            // 
            seancePicker3.Absence = false;
            seancePicker3.Checked = false;
            seancePicker3.Code = "";
            seancePicker3.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 681);
            seancePicker3.DateModifiedChecked = false;
            seancePicker3.Employer = "";
            seancePicker3.Location = new System.Drawing.Point(53, 99);
            seancePicker3.Margin = new Padding(3, 3, 3, 2);
            seancePicker3.Name = "seancePicker3";
            seancePicker3.NumeroSeance = 3;
            seance10.Absence = false;
            seance10.Active = false;
            seance10.Code = "";
            seance10.DateHeure = new DateTime(2010, 3, 13, 8, 39, 43, 728);
            seance10.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 681);
            seance10.DateModifiedChecked = false;
            seance10.Employer = "";
            seance10.Montant = "";
            seance10.SceanceNumber = 3;
            seancePicker3.Seance = seance10;
            seancePicker3.SeanceDateTime = new DateTime(2010, 3, 13, 8, 39, 43, 728);
            seancePicker3.Size = new System.Drawing.Size(269, 25);
            seancePicker3.TabIndex = 20;
            // 
            // seancePicker2
            // 
            seancePicker2.Absence = false;
            seancePicker2.Checked = false;
            seancePicker2.Code = "";
            seancePicker2.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 681);
            seancePicker2.DateModifiedChecked = false;
            seancePicker2.Employer = "";
            seancePicker2.Location = new System.Drawing.Point(53, 58);
            seancePicker2.Name = "seancePicker2";
            seancePicker2.NumeroSeance = 2;
            seance11.Absence = false;
            seance11.Active = false;
            seance11.Code = "";
            seance11.DateHeure = new DateTime(2010, 3, 13, 8, 39, 43, 744);
            seance11.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 681);
            seance11.DateModifiedChecked = false;
            seance11.Employer = "";
            seance11.Montant = "";
            seance11.SceanceNumber = 2;
            seancePicker2.Seance = seance11;
            seancePicker2.SeanceDateTime = new DateTime(2010, 3, 13, 8, 39, 43, 744);
            seancePicker2.Size = new System.Drawing.Size(269, 25);
            seancePicker2.TabIndex = 19;
            // 
            // seancePicker1
            // 
            seancePicker1.Absence = false;
            seancePicker1.Checked = false;
            seancePicker1.Code = "";
            seancePicker1.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 681);
            seancePicker1.DateModifiedChecked = false;
            seancePicker1.Employer = "";
            seancePicker1.Location = new System.Drawing.Point(53, 17);
            seancePicker1.Name = "seancePicker1";
            seancePicker1.NumeroSeance = 1;
            seance12.Absence = false;
            seance12.Active = false;
            seance12.Code = "";
            seance12.DateHeure = new DateTime(2010, 3, 13, 8, 39, 43, 744);
            seance12.DateModified = new DateTime(2010, 3, 13, 8, 39, 43, 681);
            seance12.DateModifiedChecked = false;
            seance12.Employer = "";
            seance12.Montant = "";
            seance12.SceanceNumber = 1;
            seancePicker1.Seance = seance12;
            seancePicker1.SeanceDateTime = new DateTime(2010, 3, 13, 8, 39, 43, 744);
            seancePicker1.Size = new System.Drawing.Size(269, 25);
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
            cmdPrint.Location = new System.Drawing.Point(330, 17);
            cmdPrint.Name = "cmdPrint";
            cmdPrint.Size = new System.Drawing.Size(51, 46);
            cmdPrint.TabIndex = 45;
            cmdPrint.Click += new EventHandler(cmdPrint_Click);
            // 
            // FormSeanceTheorique
            // 
            ClientSize = new System.Drawing.Size(396, 559);
            ControlBox = false;
            Controls.Add(cmdPrint);
            Controls.Add(cmdAnnuler);
            Controls.Add(cmdOK);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
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
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSeanceTheorique";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Séance de cours théorique : Automobile";
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ((ISupportInitialize)pictureBox4).EndInit();
            ((ISupportInitialize)pictureBox5).EndInit();
            ((ISupportInitialize)pictureBox6).EndInit();
            ((ISupportInitialize)pictureBox7).EndInit();
            ((ISupportInitialize)pictureBox8).EndInit();
            ((ISupportInitialize)pictureBox9).EndInit();
            ((ISupportInitialize)pictureBox10).EndInit();
            ((ISupportInitialize)pictureBox11).EndInit();
            ((ISupportInitialize)pictureBox12).EndInit();
            ResumeLayout(false);

		}
        #endregion

        private void button2_Click(object sender, EventArgs e) => Close();

        /// <summary>
        /// enregistrement des Seance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdOK_Click(object sender, EventArgs e) 
		{
            //Suppression des seance en cours
            _client.SeancesTheorique.Clear();
			
            if (seancePicker1.Checked == true) _client.SeancesTheorique.Add(seancePicker1.Seance);
            if (seancePicker2.Checked == true) _client.SeancesTheorique.Add(seancePicker2.Seance);
            if (seancePicker3.Checked == true) _client.SeancesTheorique.Add(seancePicker3.Seance);
            if (seancePicker4.Checked == true) _client.SeancesTheorique.Add(seancePicker4.Seance);
            if (seancePicker5.Checked == true) _client.SeancesTheorique.Add(seancePicker5.Seance);
            if (seancePicker6.Checked == true) _client.SeancesTheorique.Add(seancePicker6.Seance);
            if (seancePicker7.Checked == true) _client.SeancesTheorique.Add(seancePicker7.Seance);
            if (seancePicker8.Checked == true) _client.SeancesTheorique.Add(seancePicker8.Seance);
            if (seancePicker9.Checked == true) _client.SeancesTheorique.Add(seancePicker9.Seance);
            if (seancePicker10.Checked == true) _client.SeancesTheorique.Add(seancePicker10.Seance);
            if (seancePicker11.Checked == true) _client.SeancesTheorique.Add(seancePicker11.Seance);
            if (seancePicker12.Checked == true) _client.SeancesTheorique.Add(seancePicker12.Seance);

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
					seancePicker11.ListEmploye = seancePicker12.ListEmploye = _ListEmploye;

            for (int i = 0; i < _client.SeancesTheorique.Count; i++) {
                switch (_client.SeancesTheorique[i].SceanceNumber) {
                    case 1:
                        seancePicker1.Seance = _client.SeancesTheorique[i];
                        break;
                    case 2:
                        seancePicker2.Seance = _client.SeancesTheorique[i];
                        break;
                    case 3:
                        seancePicker3.Seance = _client.SeancesTheorique[i];
                        break;
                    case 4:
                        seancePicker4.Seance = _client.SeancesTheorique[i];
                        break;
                    case 5:
                        seancePicker5.Seance = _client.SeancesTheorique[i];
                        break;
                    case 6:
                        seancePicker6.Seance = _client.SeancesTheorique[i];
                        break;
                    case 7:
                        seancePicker7.Seance = _client.SeancesTheorique[i];
                        break;
                    case 8:
                        seancePicker8.Seance = _client.SeancesTheorique[i];
                        break;
                    case 9:
                        seancePicker9.Seance = _client.SeancesTheorique[i];
                        break;
                    case 10:
                        seancePicker10.Seance = _client.SeancesTheorique[i];
                        break;
                    case 11:
                        seancePicker11.Seance = _client.SeancesTheorique[i];
                        break;
                    case 12:
                        seancePicker12.Seance = _client.SeancesTheorique[i];
                        break;
                }
            }
		}

        private void cmdPrint_Click(object sender, EventArgs e) {
            AddSeanceTemp();

            _ctrlClient.Client = _client;
            _ctrlClient.PrintDoc(true, true, true, PrintDocumentType.InfoClientTheorique);
        }

        private void AddSeanceTemp() {
            _ctrlClient.Client.SeancesTheorique.Clear();

            _ctrlClient.Client.SeancesTheorique.Add(seancePicker1.Seance);
            _ctrlClient.Client.SeancesTheorique.Add(seancePicker2.Seance);
            _ctrlClient.Client.SeancesTheorique.Add(seancePicker3.Seance);
            _ctrlClient.Client.SeancesTheorique.Add(seancePicker4.Seance);
            _ctrlClient.Client.SeancesTheorique.Add(seancePicker5.Seance);
            _ctrlClient.Client.SeancesTheorique.Add(seancePicker6.Seance);
            _ctrlClient.Client.SeancesTheorique.Add(seancePicker7.Seance);
            _ctrlClient.Client.SeancesTheorique.Add(seancePicker8.Seance);
            _ctrlClient.Client.SeancesTheorique.Add(seancePicker9.Seance);
            _ctrlClient.Client.SeancesTheorique.Add(seancePicker10.Seance);
            _ctrlClient.Client.SeancesTheorique.Add(seancePicker11.Seance);
            _ctrlClient.Client.SeancesTheorique.Add(seancePicker12.Seance);
        }
	}
}
