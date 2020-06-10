using System;
using System.ComponentModel;
using System.Windows.Forms;

using Barette.Library.Client;
using Barette.Library.Collections;

namespace Barette.Library.UserControls.Client
{
    /// <summary>
    /// Description résumée de FormSeanceMoto.
    /// </summary>
    public class FormSeanceMoto2015 : Form
    {
		/// <summary>
		/// client referer
		/// </summary>
		private readonly Customer _client;
		private readonly ClientControl _ctrlClient;

        private GroupBox groupBox1;
		private SeancePicker seancePicker4;
		private SeancePicker seancePicker3;
        private SeancePicker seancePicker2;
        private SeancePicker seancePicker1;
		private Button cmdPrintHorsRoute;
		private ImageList imageList1;
        private IContainer components;
        private Button cmdAnnuler;
        private Button cmdOK;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private SeancePicker seancePicker5;
        private SeancePicker seancePicker6;
        private SeancePicker seancePicker7;
        private SeancePicker seancePicker8;
        private SeancePicker seancePicker9;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private SeancePicker seancePicker10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private GroupBox groupBox4;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private SeancePicker seancePicker11;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label21;
        private readonly EmployeCollection _ListEmploye;

		public FormSeanceMoto2015(Customer client, ClientControl ctrl, EmployeCollection ListEmploye) {
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

            _client = client;
            _ctrlClient = ctrl;
            _ListEmploye = ListEmploye; 

			InitializeSeance();

            ////Position la fenetre
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormSeanceMoto2015));
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            seancePicker1 = new SeancePicker();
            cmdPrintHorsRoute = new Button();
            imageList1 = new ImageList(components);
            cmdAnnuler = new Button();
            cmdOK = new Button();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            seancePicker2 = new SeancePicker();
            seancePicker4 = new SeancePicker();
            seancePicker3 = new SeancePicker();
            seancePicker5 = new SeancePicker();
            groupBox3 = new GroupBox();
            seancePicker10 = new SeancePicker();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            seancePicker11 = new SeancePicker();
            label15 = new Label();
            seancePicker7 = new SeancePicker();
            seancePicker9 = new SeancePicker();
            seancePicker8 = new SeancePicker();
            groupBox4 = new GroupBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            seancePicker6 = new SeancePicker();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(seancePicker1);
            groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            groupBox1.Location = new System.Drawing.Point(10, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(754, 97);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "FORMATION THÉORIQUE - Préparation à la conduite en circuit fermé ( 3 heures  )";
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(606, 23);
            label1.Margin = new Padding(3, 3, 3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 23);
            label1.TabIndex = 52;
            label1.Text = "Montant";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(289, 22);
            label4.Margin = new Padding(3, 3, 3, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(128, 23);
            label4.TabIndex = 51;
            label4.Text = "Heures (fin)";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(496, 22);
            label3.Margin = new Padding(3, 3, 3, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(97, 23);
            label3.TabIndex = 50;
            label3.Text = "Employé";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(423, 22);
            label2.Margin = new Padding(3, 3, 3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 23);
            label2.TabIndex = 49;
            label2.Text = "Code";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(102, 22);
            label9.Margin = new Padding(3, 3, 3, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(200, 23);
            label9.TabIndex = 48;
            label9.Text = "Date et heure (début)";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seancePicker1
            // 
            seancePicker1.Absence = false;
            seancePicker1.AutoAddEndCoursHours = 3;
            seancePicker1.Checked = false;
            seancePicker1.Code = "";
            seancePicker1.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 581);
            seancePicker1.DateModifiedChecked = false;
            seancePicker1.Employer = "";
            seancePicker1.Location = new System.Drawing.Point(19, 45);
            seancePicker1.Name = "seancePicker1";
            seancePicker1.NumeroSeance = 1;
            seance1.Absence = false;
            seance1.Active = false;
            seance1.Code = "";
            seance1.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance1.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 581);
            seance1.DateModifiedChecked = false;
            seance1.Employer = "";
            seance1.Montant = "";
            seance1.SceanceNumber = 1;
            seancePicker1.Seance = seance1;
            seancePicker1.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker1.Size = new System.Drawing.Size(786, 25);
            seancePicker1.TabIndex = 27;
            // 
            // cmdPrintHorsRoute
            // 
            cmdPrintHorsRoute.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            cmdPrintHorsRoute.ImageIndex = 0;
            cmdPrintHorsRoute.ImageList = imageList1;
            cmdPrintHorsRoute.Location = new System.Drawing.Point(529, 631);
            cmdPrintHorsRoute.Name = "cmdPrintHorsRoute";
            cmdPrintHorsRoute.Size = new System.Drawing.Size(51, 45);
            cmdPrintHorsRoute.TabIndex = 40;
            cmdPrintHorsRoute.Click += new EventHandler(cmdPrintHorsRoute_Click);
            // 
            // imageList1
            // 
            imageList1.ImageStream = ((ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "");
            // 
            // cmdAnnuler
            // 
            cmdAnnuler.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            cmdAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cmdAnnuler.Image = global::Barette.Library.Properties.Resources.Cancel_2_icon;
            cmdAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cmdAnnuler.Location = new System.Drawing.Point(687, 631);
            cmdAnnuler.Name = "cmdAnnuler";
            cmdAnnuler.Size = new System.Drawing.Size(85, 45);
            cmdAnnuler.TabIndex = 30;
            cmdAnnuler.Text = "Annuler";
            cmdAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cmdAnnuler.Click += new EventHandler(cmdCancel_Click);
            // 
            // cmdOK
            // 
            cmdOK.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            cmdOK.Image = global::Barette.Library.Properties.Resources.accept_icon;
            cmdOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cmdOK.Location = new System.Drawing.Point(586, 631);
            cmdOK.Name = "cmdOK";
            cmdOK.Size = new System.Drawing.Size(95, 45);
            cmdOK.TabIndex = 29;
            cmdOK.Text = "Appliquer";
            cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cmdOK.Click += new EventHandler(cmdOK_Click);
            // 
            // label10
            // 
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(102, 19);
            label10.Margin = new Padding(3, 3, 3, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(200, 23);
            label10.TabIndex = 48;
            label10.Text = "Date et heure (début)";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(423, 19);
            label8.Margin = new Padding(3, 3, 3, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(57, 23);
            label8.TabIndex = 49;
            label8.Text = "Code";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(496, 19);
            label7.Margin = new Padding(3, 3, 3, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(97, 23);
            label7.TabIndex = 50;
            label7.Text = "Employé";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(289, 19);
            label6.Margin = new Padding(3, 3, 3, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(128, 23);
            label6.TabIndex = 51;
            label6.Text = "Heures (fin)";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(606, 20);
            label5.Margin = new Padding(3, 3, 3, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(59, 23);
            label5.TabIndex = 52;
            label5.Text = "Montant";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label25);
            groupBox2.Controls.Add(label24);
            groupBox2.Controls.Add(label23);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(seancePicker2);
            groupBox2.Controls.Add(seancePicker4);
            groupBox2.Controls.Add(seancePicker3);
            groupBox2.Controls.Add(seancePicker5);
            groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            groupBox2.Location = new System.Drawing.Point(12, 115);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(754, 167);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "FORMATION PRATIQUE EN CIRCUIT FERMÉ - ( 16 heures )";
            // 
            // seancePicker2
            // 
            seancePicker2.Absence = false;
            seancePicker2.AutoAddEndCoursHours = 4;
            seancePicker2.Checked = false;
            seancePicker2.Code = "";
            seancePicker2.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 571);
            seancePicker2.DateModifiedChecked = false;
            seancePicker2.Employer = "";
            seancePicker2.Location = new System.Drawing.Point(19, 46);
            seancePicker2.Name = "seancePicker2";
            seancePicker2.NumeroSeance = 2;
            seance2.Absence = false;
            seance2.Active = false;
            seance2.Code = "";
            seance2.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance2.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 571);
            seance2.DateModifiedChecked = false;
            seance2.Employer = "";
            seance2.Montant = "";
            seance2.SceanceNumber = 2;
            seancePicker2.Seance = seance2;
            seancePicker2.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker2.Size = new System.Drawing.Size(786, 25);
            seancePicker2.TabIndex = 29;
            // 
            // seancePicker4
            // 
            seancePicker4.Absence = false;
            seancePicker4.AutoAddEndCoursHours = 4;
            seancePicker4.Checked = false;
            seancePicker4.Code = "";
            seancePicker4.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 541);
            seancePicker4.DateModifiedChecked = false;
            seancePicker4.Employer = "";
            seancePicker4.Location = new System.Drawing.Point(19, 101);
            seancePicker4.Margin = new Padding(3, 3, 3, 2);
            seancePicker4.Name = "seancePicker4";
            seancePicker4.NumeroSeance = 4;
            seance3.Absence = false;
            seance3.Active = false;
            seance3.Code = "";
            seance3.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance3.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 541);
            seance3.DateModifiedChecked = false;
            seance3.Employer = "";
            seance3.Montant = "";
            seance3.SceanceNumber = 4;
            seancePicker4.Seance = seance3;
            seancePicker4.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker4.Size = new System.Drawing.Size(786, 25);
            seancePicker4.TabIndex = 31;
            // 
            // seancePicker3
            // 
            seancePicker3.Absence = false;
            seancePicker3.AutoAddEndCoursHours = 4;
            seancePicker3.Checked = false;
            seancePicker3.Code = "";
            seancePicker3.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 551);
            seancePicker3.DateModifiedChecked = false;
            seancePicker3.Employer = "";
            seancePicker3.Location = new System.Drawing.Point(19, 74);
            seancePicker3.Margin = new Padding(3, 3, 3, 2);
            seancePicker3.Name = "seancePicker3";
            seancePicker3.NumeroSeance = 3;
            seance4.Absence = false;
            seance4.Active = false;
            seance4.Code = "";
            seance4.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance4.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 551);
            seance4.DateModifiedChecked = false;
            seance4.Employer = "";
            seance4.Montant = "";
            seance4.SceanceNumber = 3;
            seancePicker3.Seance = seance4;
            seancePicker3.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker3.Size = new System.Drawing.Size(786, 25);
            seancePicker3.TabIndex = 30;
            // 
            // seancePicker5
            // 
            seancePicker5.Absence = false;
            seancePicker5.AutoAddEndCoursHours = 4;
            seancePicker5.Checked = false;
            seancePicker5.Code = "";
            seancePicker5.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 521);
            seancePicker5.DateModifiedChecked = false;
            seancePicker5.Employer = "";
            seancePicker5.Location = new System.Drawing.Point(19, 129);
            seancePicker5.Margin = new Padding(3, 3, 3, 2);
            seancePicker5.Name = "seancePicker5";
            seancePicker5.NumeroSeance = 5;
            seance5.Absence = false;
            seance5.Active = false;
            seance5.Code = "";
            seance5.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance5.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 521);
            seance5.DateModifiedChecked = false;
            seance5.Employer = "";
            seance5.Montant = "";
            seance5.SceanceNumber = 5;
            seancePicker5.Seance = seance5;
            seancePicker5.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker5.Size = new System.Drawing.Size(786, 25);
            seancePicker5.TabIndex = 32;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label30);
            groupBox3.Controls.Add(label29);
            groupBox3.Controls.Add(label28);
            groupBox3.Controls.Add(label27);
            groupBox3.Controls.Add(label26);
            groupBox3.Controls.Add(seancePicker10);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(seancePicker11);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(seancePicker7);
            groupBox3.Controls.Add(seancePicker9);
            groupBox3.Controls.Add(seancePicker8);
            groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            groupBox3.Location = new System.Drawing.Point(12, 391);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(754, 200);
            groupBox3.TabIndex = 43;
            groupBox3.TabStop = false;
            groupBox3.Text = "FORMATION PRATIQUE SUR ROUTE - ( 10 heures )";
            // 
            // seancePicker10
            // 
            seancePicker10.Absence = false;
            seancePicker10.AutoAddEndCoursHours = 2;
            seancePicker10.Checked = false;
            seancePicker10.Code = "";
            seancePicker10.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 511);
            seancePicker10.DateModifiedChecked = false;
            seancePicker10.Employer = "";
            seancePicker10.Location = new System.Drawing.Point(19, 128);
            seancePicker10.Margin = new Padding(3, 1, 3, 2);
            seancePicker10.Name = "seancePicker10";
            seancePicker10.NumeroSeance = 10;
            seance6.Absence = false;
            seance6.Active = false;
            seance6.Code = "";
            seance6.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance6.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 511);
            seance6.DateModifiedChecked = false;
            seance6.Employer = "";
            seance6.Montant = "";
            seance6.SceanceNumber = 10;
            seancePicker10.Seance = seance6;
            seancePicker10.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker10.Size = new System.Drawing.Size(786, 25);
            seancePicker10.TabIndex = 53;
            // 
            // label11
            // 
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(606, 20);
            label11.Margin = new Padding(3, 3, 3, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(59, 23);
            label11.TabIndex = 52;
            label11.Text = "Montant";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new System.Drawing.Point(289, 19);
            label12.Margin = new Padding(3, 3, 3, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(128, 23);
            label12.TabIndex = 51;
            label12.Text = "Heures (fin)";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(496, 19);
            label13.Margin = new Padding(3, 3, 3, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(97, 23);
            label13.TabIndex = 50;
            label13.Text = "Employé";
            label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new System.Drawing.Point(423, 19);
            label14.Margin = new Padding(3, 3, 3, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(57, 23);
            label14.TabIndex = 49;
            label14.Text = "Code";
            label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seancePicker11
            // 
            seancePicker11.Absence = false;
            seancePicker11.AutoAddEndCoursHours = 2;
            seancePicker11.Checked = false;
            seancePicker11.Code = "";
            seancePicker11.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 581);
            seancePicker11.DateModifiedChecked = false;
            seancePicker11.Employer = "";
            seancePicker11.Location = new System.Drawing.Point(19, 158);
            seancePicker11.Name = "seancePicker11";
            seancePicker11.NumeroSeance = 11;
            seance7.Absence = false;
            seance7.Active = false;
            seance7.Code = "";
            seance7.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance7.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 581);
            seance7.DateModifiedChecked = false;
            seance7.Employer = "";
            seance7.Montant = "";
            seance7.SceanceNumber = 11;
            seancePicker11.Seance = seance7;
            seancePicker11.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker11.Size = new System.Drawing.Size(786, 25);
            seancePicker11.TabIndex = 27;
            // 
            // label15
            // 
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new System.Drawing.Point(102, 19);
            label15.Margin = new Padding(3, 3, 3, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(200, 23);
            label15.TabIndex = 48;
            label15.Text = "Date et heure (début)";
            label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seancePicker7
            // 
            seancePicker7.Absence = false;
            seancePicker7.AutoAddEndCoursHours = 2;
            seancePicker7.Checked = false;
            seancePicker7.Code = "";
            seancePicker7.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 511);
            seancePicker7.DateModifiedChecked = false;
            seancePicker7.Employer = "";
            seancePicker7.Location = new System.Drawing.Point(19, 44);
            seancePicker7.Margin = new Padding(3, 1, 3, 2);
            seancePicker7.Name = "seancePicker7";
            seancePicker7.NumeroSeance = 7;
            seance8.Absence = false;
            seance8.Active = false;
            seance8.Code = "";
            seance8.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance8.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 511);
            seance8.DateModifiedChecked = false;
            seance8.Employer = "";
            seance8.Montant = "";
            seance8.SceanceNumber = 7;
            seancePicker7.Seance = seance8;
            seancePicker7.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker7.Size = new System.Drawing.Size(786, 25);
            seancePicker7.TabIndex = 40;
            // 
            // seancePicker9
            // 
            seancePicker9.Absence = false;
            seancePicker9.AutoAddEndCoursHours = 2;
            seancePicker9.Checked = false;
            seancePicker9.Code = "";
            seancePicker9.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 511);
            seancePicker9.DateModifiedChecked = false;
            seancePicker9.Employer = "";
            seancePicker9.Location = new System.Drawing.Point(19, 100);
            seancePicker9.Margin = new Padding(3, 1, 3, 2);
            seancePicker9.Name = "seancePicker9";
            seancePicker9.NumeroSeance = 9;
            seance9.Absence = false;
            seance9.Active = false;
            seance9.Code = "";
            seance9.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance9.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 511);
            seance9.DateModifiedChecked = false;
            seance9.Employer = "";
            seance9.Montant = "";
            seance9.SceanceNumber = 9;
            seancePicker9.Seance = seance9;
            seancePicker9.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker9.Size = new System.Drawing.Size(786, 25);
            seancePicker9.TabIndex = 42;
            // 
            // seancePicker8
            // 
            seancePicker8.Absence = false;
            seancePicker8.AutoAddEndCoursHours = 2;
            seancePicker8.Checked = false;
            seancePicker8.Code = "";
            seancePicker8.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 511);
            seancePicker8.DateModifiedChecked = false;
            seancePicker8.Employer = "";
            seancePicker8.Location = new System.Drawing.Point(19, 72);
            seancePicker8.Margin = new Padding(3, 1, 3, 2);
            seancePicker8.Name = "seancePicker8";
            seancePicker8.NumeroSeance = 8;
            seance10.Absence = false;
            seance10.Active = false;
            seance10.Code = "";
            seance10.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance10.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 511);
            seance10.DateModifiedChecked = false;
            seance10.Employer = "";
            seance10.Montant = "";
            seance10.SceanceNumber = 8;
            seancePicker8.Seance = seance10;
            seancePicker8.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker8.Size = new System.Drawing.Size(786, 25);
            seancePicker8.TabIndex = 41;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label21);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(label20);
            groupBox4.Controls.Add(seancePicker6);
            groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            groupBox4.Location = new System.Drawing.Point(10, 288);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(754, 97);
            groupBox4.TabIndex = 44;
            groupBox4.TabStop = false;
            groupBox4.Text = "FORMATION THÉORIQUE - Préparation à la conduite sur route ( 3 heures  )";
            // 
            // label16
            // 
            label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.Location = new System.Drawing.Point(606, 23);
            label16.Margin = new Padding(3, 3, 3, 0);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(59, 23);
            label16.TabIndex = 52;
            label16.Text = "Montant";
            label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.Location = new System.Drawing.Point(289, 22);
            label17.Margin = new Padding(3, 3, 3, 0);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(128, 23);
            label17.TabIndex = 51;
            label17.Text = "Heures (fin)";
            label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label18.Location = new System.Drawing.Point(496, 22);
            label18.Margin = new Padding(3, 3, 3, 0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(97, 23);
            label18.TabIndex = 50;
            label18.Text = "Employé";
            label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label19.Location = new System.Drawing.Point(423, 22);
            label19.Margin = new Padding(3, 3, 3, 0);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(57, 23);
            label19.TabIndex = 49;
            label19.Text = "Code";
            label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label20.Location = new System.Drawing.Point(102, 22);
            label20.Margin = new Padding(3, 3, 3, 0);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(200, 23);
            label20.TabIndex = 48;
            label20.Text = "Date et heure (début)";
            label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seancePicker6
            // 
            seancePicker6.Absence = false;
            seancePicker6.AutoAddEndCoursHours = 3;
            seancePicker6.Checked = false;
            seancePicker6.Code = "";
            seancePicker6.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 511);
            seancePicker6.DateModifiedChecked = false;
            seancePicker6.Employer = "";
            seancePicker6.Location = new System.Drawing.Point(19, 46);
            seancePicker6.Margin = new Padding(3, 1, 3, 2);
            seancePicker6.Name = "seancePicker6";
            seancePicker6.NumeroSeance = 6;
            seance11.Absence = false;
            seance11.Active = false;
            seance11.Code = "";
            seance11.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance11.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 511);
            seance11.DateModifiedChecked = false;
            seance11.Employer = "";
            seance11.Montant = "";
            seance11.SceanceNumber = 6;
            seancePicker6.Seance = seance11;
            seancePicker6.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker6.Size = new System.Drawing.Size(786, 25);
            seancePicker6.TabIndex = 33;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(84, 50);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(13, 13);
            label21.TabIndex = 45;
            label21.Text = "2";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(83, 78);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(13, 13);
            label22.TabIndex = 53;
            label22.Text = "2";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(83, 50);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(13, 13);
            label23.TabIndex = 54;
            label23.Text = "1";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new System.Drawing.Point(83, 105);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(13, 13);
            label24.TabIndex = 55;
            label24.Text = "3";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new System.Drawing.Point(83, 133);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(13, 13);
            label25.TabIndex = 56;
            label25.Text = "4";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new System.Drawing.Point(83, 48);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(13, 13);
            label26.TabIndex = 54;
            label26.Text = "5";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new System.Drawing.Point(83, 76);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(13, 13);
            label27.TabIndex = 55;
            label27.Text = "6";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new System.Drawing.Point(83, 104);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(13, 13);
            label28.TabIndex = 56;
            label28.Text = "7";
            // 
            // label29
            // 
            label29.Location = new System.Drawing.Point(83, 132);
            label29.Name = "label29";
            label29.Size = new System.Drawing.Size(14, 13);
            label29.TabIndex = 57;
            label29.Text = "8";
            // 
            // label30
            // 
            label30.Location = new System.Drawing.Point(83, 163);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(14, 13);
            label30.TabIndex = 58;
            label30.Text = "9";
            // 
            // FormSeanceMoto2015
            // 
            ClientSize = new System.Drawing.Size(780, 686);
            ControlBox = false;
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(cmdAnnuler);
            Controls.Add(cmdOK);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(cmdPrintHorsRoute);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "FormSeanceMoto2015";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Séance de cours pratique : Motocyclette";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);

		}
		#endregion

		private void cmdCancel_Click(object sender, EventArgs e) {
            Close();
		}

		private void cmdOK_Click(object sender, EventArgs e) {
            //Suppression des seance en cours
            _client.Seances.Clear();
            _client.SeancesTheorique.Clear();

            if (seancePicker1.Checked == true) _client.SeancesTheorique.Add(seancePicker1.Seance);
            if (seancePicker6.Checked == true) _client.SeancesTheorique.Add(seancePicker6.Seance);

            if (seancePicker2.Checked == true) _client.Seances.Add(seancePicker2.Seance);
            if (seancePicker3.Checked == true) _client.Seances.Add(seancePicker3.Seance);
            if (seancePicker4.Checked == true) _client.Seances.Add(seancePicker4.Seance);
            if (seancePicker5.Checked == true) _client.Seances.Add(seancePicker5.Seance);            
            if (seancePicker7.Checked == true) _client.Seances.Add(seancePicker7.Seance);
            if (seancePicker8.Checked == true) _client.Seances.Add(seancePicker8.Seance);
            if (seancePicker9.Checked == true) _client.Seances.Add(seancePicker9.Seance);
            if (seancePicker10.Checked == true) _client.Seances.Add(seancePicker10.Seance);
            if (seancePicker11.Checked == true) _client.Seances.Add(seancePicker11.Seance);

            //Fermer la boite
            Close();
		}

		private void InitializeSeance() {
			seancePicker1.ListEmploye = seancePicker2.ListEmploye =
				seancePicker3.ListEmploye = seancePicker4.ListEmploye =
                seancePicker5.ListEmploye = seancePicker6.ListEmploye = seancePicker7.ListEmploye =
                seancePicker8.ListEmploye = seancePicker9.ListEmploye = seancePicker10.ListEmploye = seancePicker11.ListEmploye = _ListEmploye;

            for (int i = 0; i < _client.SeancesTheorique.Count; i++)
            {
                switch (_client.SeancesTheorique[i].SceanceNumber)
                {
                    case 1:
                        seancePicker1.Seance = _client.SeancesTheorique[i];
                        break;
                    case 6:
                        seancePicker6.Seance = _client.SeancesTheorique[i];
                        break;
                }
            }


            for (int i = 0; i < _client.Seances.Count; i++) {
                switch (_client.Seances[i].SceanceNumber) {
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

                }
            }
		}

		private void cmdPrintHorsRoute_Click(object sender, EventArgs e) {
			AddSeanceTemp();

            _ctrlClient.Client = _client;
            _ctrlClient.PrintDoc(true, true, true, PrintDocumentType.Moto2015); 
		}

		private void AddSeanceTemp() {
            _ctrlClient.Client.Seances.Clear();
            _ctrlClient.Client.SeancesTheorique.Clear();

            _ctrlClient.Client.SeancesTheorique.Add(seancePicker1.Seance);
            _ctrlClient.Client.SeancesTheorique.Add(seancePicker6.Seance);

            _ctrlClient.Client.Seances.Add(seancePicker2.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker3.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker4.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker5.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker7.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker8.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker9.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker10.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker11.Seance);
		}

		private void cmdPrintRoute_Click(object sender, EventArgs e) {
			AddSeanceTemp();
            _ctrlClient.Client = _client;
            _ctrlClient.PrintDoc(true, false, true, PrintDocumentType.InfoClient); 

		}

	}
}
