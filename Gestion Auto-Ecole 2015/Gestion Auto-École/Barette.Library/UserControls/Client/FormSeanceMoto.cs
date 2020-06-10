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
    public class FormSeanceMoto : Form
    {
		/// <summary>
		/// client referer
		/// </summary>
		private readonly Customer _client;
		private readonly ClientControl _ctrlClient;

		private GroupBox groupBox1;
        private GroupBox groupBox2;
		private SeancePicker seancePicker4;
		private SeancePicker seancePicker3;
        private SeancePicker seancePicker2;
        private SeancePicker seancePicker1;
		private SeancePicker seancePicker6;
        private SeancePicker seancePicker5;
		private Button cmdPrintRoute;
		private Button cmdPrintHorsRoute;
		private ImageList imageList1;
        private IContainer components;
        private Button cmdAnnuler;
        private Button cmdOK;
        private SeancePicker seancePicker9;
        private SeancePicker seancePicker8;
        private SeancePicker seancePicker7;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;

		private readonly EmployeCollection _ListEmploye;

		public FormSeanceMoto(Customer client, ClientControl ctrl, EmployeCollection ListEmploye) {
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormSeanceMoto));
            Seance seance1 = new Seance();
            Seance seance2 = new Seance();
            Seance seance3 = new Seance();
            Seance seance4 = new Seance();
            Seance seance5 = new Seance();
            Seance seance6 = new Seance();
            Seance seance7 = new Seance();
            Seance seance8 = new Seance();
            Seance seance9 = new Seance();
            groupBox1 = new GroupBox();
            imageList1 = new ImageList(components);
            groupBox2 = new GroupBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            seancePicker4 = new SeancePicker();
            seancePicker3 = new SeancePicker();
            seancePicker2 = new SeancePicker();
            seancePicker1 = new SeancePicker();
            seancePicker9 = new SeancePicker();
            seancePicker8 = new SeancePicker();
            seancePicker7 = new SeancePicker();
            seancePicker6 = new SeancePicker();
            seancePicker5 = new SeancePicker();
            cmdAnnuler = new Button();
            cmdOK = new Button();
            cmdPrintHorsRoute = new Button();
            cmdPrintRoute = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cmdPrintHorsRoute);
            groupBox1.Controls.Add(seancePicker4);
            groupBox1.Controls.Add(seancePicker3);
            groupBox1.Controls.Add(seancePicker2);
            groupBox1.Controls.Add(seancePicker1);
            groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            groupBox1.Location = new System.Drawing.Point(10, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(875, 154);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hors route";
            // 
            // imageList1
            // 
            imageList1.ImageStream = ((ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(seancePicker9);
            groupBox2.Controls.Add(seancePicker8);
            groupBox2.Controls.Add(seancePicker7);
            groupBox2.Controls.Add(cmdPrintRoute);
            groupBox2.Controls.Add(seancePicker6);
            groupBox2.Controls.Add(seancePicker5);
            groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            groupBox2.Location = new System.Drawing.Point(10, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(875, 190);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Route";
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(606, 18);
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
            label4.Location = new System.Drawing.Point(289, 17);
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
            label3.Location = new System.Drawing.Point(496, 17);
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
            label2.Location = new System.Drawing.Point(423, 17);
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
            label9.Location = new System.Drawing.Point(102, 17);
            label9.Margin = new Padding(3, 3, 3, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(200, 23);
            label9.TabIndex = 48;
            label9.Text = "Date et heure (début)";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(606, 14);
            label5.Margin = new Padding(3, 3, 3, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(59, 23);
            label5.TabIndex = 52;
            label5.Text = "Montant";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(289, 13);
            label6.Margin = new Padding(3, 3, 3, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(128, 23);
            label6.TabIndex = 51;
            label6.Text = "Heures (fin)";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(496, 13);
            label7.Margin = new Padding(3, 3, 3, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(97, 23);
            label7.TabIndex = 50;
            label7.Text = "Employé";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(423, 13);
            label8.Margin = new Padding(3, 3, 3, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(57, 23);
            label8.TabIndex = 49;
            label8.Text = "Code";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(102, 13);
            label10.Margin = new Padding(3, 3, 3, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(200, 23);
            label10.TabIndex = 48;
            label10.Text = "Date et heure (début)";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seancePicker4
            // 
            seancePicker4.Absence = false;
            seancePicker4.Checked = false;
            seancePicker4.Code = "";
            seancePicker4.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 541);
            seancePicker4.DateModifiedChecked = false;
            seancePicker4.Employer = "";
            seancePicker4.Location = new System.Drawing.Point(19, 123);
            seancePicker4.Margin = new Padding(3, 3, 3, 2);
            seancePicker4.Name = "seancePicker4";
            seancePicker4.NumeroSeance = 4;
            seance1.Absence = false;
            seance1.Active = false;
            seance1.Code = "";
            seance1.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance1.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 541);
            seance1.DateModifiedChecked = false;
            seance1.Employer = "";
            seance1.Montant = "";
            seance1.SceanceNumber = 4;
            seancePicker4.Seance = seance1;
            seancePicker4.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker4.Size = new System.Drawing.Size(786, 25);
            seancePicker4.TabIndex = 31;
            // 
            // seancePicker3
            // 
            seancePicker3.Absence = false;
            seancePicker3.Checked = false;
            seancePicker3.Code = "";
            seancePicker3.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 551);
            seancePicker3.DateModifiedChecked = false;
            seancePicker3.Employer = "";
            seancePicker3.Location = new System.Drawing.Point(19, 96);
            seancePicker3.Margin = new Padding(3, 3, 3, 2);
            seancePicker3.Name = "seancePicker3";
            seancePicker3.NumeroSeance = 3;
            seance2.Absence = false;
            seance2.Active = false;
            seance2.Code = "";
            seance2.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance2.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 551);
            seance2.DateModifiedChecked = false;
            seance2.Employer = "";
            seance2.Montant = "";
            seance2.SceanceNumber = 3;
            seancePicker3.Seance = seance2;
            seancePicker3.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker3.Size = new System.Drawing.Size(786, 25);
            seancePicker3.TabIndex = 30;
            // 
            // seancePicker2
            // 
            seancePicker2.Absence = false;
            seancePicker2.Checked = false;
            seancePicker2.Code = "";
            seancePicker2.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 571);
            seancePicker2.DateModifiedChecked = false;
            seancePicker2.Employer = "";
            seancePicker2.Location = new System.Drawing.Point(19, 68);
            seancePicker2.Name = "seancePicker2";
            seancePicker2.NumeroSeance = 2;
            seance3.Absence = false;
            seance3.Active = false;
            seance3.Code = "";
            seance3.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance3.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 571);
            seance3.DateModifiedChecked = false;
            seance3.Employer = "";
            seance3.Montant = "";
            seance3.SceanceNumber = 2;
            seancePicker2.Seance = seance3;
            seancePicker2.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker2.Size = new System.Drawing.Size(786, 25);
            seancePicker2.TabIndex = 29;
            // 
            // seancePicker1
            // 
            seancePicker1.Absence = false;
            seancePicker1.Checked = false;
            seancePicker1.Code = "";
            seancePicker1.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 581);
            seancePicker1.DateModifiedChecked = false;
            seancePicker1.Employer = "";
            seancePicker1.Location = new System.Drawing.Point(19, 40);
            seancePicker1.Name = "seancePicker1";
            seancePicker1.NumeroSeance = 1;
            seance4.Absence = false;
            seance4.Active = false;
            seance4.Code = "";
            seance4.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance4.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 581);
            seance4.DateModifiedChecked = false;
            seance4.Employer = "";
            seance4.Montant = "";
            seance4.SceanceNumber = 1;
            seancePicker1.Seance = seance4;
            seancePicker1.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker1.Size = new System.Drawing.Size(786, 25);
            seancePicker1.TabIndex = 27;
            // 
            // seancePicker9
            // 
            seancePicker9.Absence = false;
            seancePicker9.Checked = false;
            seancePicker9.Code = "";
            seancePicker9.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 511);
            seancePicker9.DateModifiedChecked = false;
            seancePicker9.Employer = "";
            seancePicker9.Location = new System.Drawing.Point(19, 150);
            seancePicker9.Margin = new Padding(3, 1, 3, 2);
            seancePicker9.Name = "seancePicker9";
            seancePicker9.NumeroSeance = 9;
            seance5.Absence = false;
            seance5.Active = false;
            seance5.Code = "";
            seance5.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance5.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 511);
            seance5.DateModifiedChecked = false;
            seance5.Employer = "";
            seance5.Montant = "";
            seance5.SceanceNumber = 9;
            seancePicker9.Seance = seance5;
            seancePicker9.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker9.Size = new System.Drawing.Size(786, 25);
            seancePicker9.TabIndex = 42;
            // 
            // seancePicker8
            // 
            seancePicker8.Absence = false;
            seancePicker8.Checked = false;
            seancePicker8.Code = "";
            seancePicker8.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 511);
            seancePicker8.DateModifiedChecked = false;
            seancePicker8.Employer = "";
            seancePicker8.Location = new System.Drawing.Point(19, 122);
            seancePicker8.Margin = new Padding(3, 1, 3, 2);
            seancePicker8.Name = "seancePicker8";
            seancePicker8.NumeroSeance = 8;
            seance6.Absence = false;
            seance6.Active = false;
            seance6.Code = "";
            seance6.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance6.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 511);
            seance6.DateModifiedChecked = false;
            seance6.Employer = "";
            seance6.Montant = "";
            seance6.SceanceNumber = 8;
            seancePicker8.Seance = seance6;
            seancePicker8.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker8.Size = new System.Drawing.Size(786, 25);
            seancePicker8.TabIndex = 41;
            // 
            // seancePicker7
            // 
            seancePicker7.Absence = false;
            seancePicker7.Checked = false;
            seancePicker7.Code = "";
            seancePicker7.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 511);
            seancePicker7.DateModifiedChecked = false;
            seancePicker7.Employer = "";
            seancePicker7.Location = new System.Drawing.Point(19, 94);
            seancePicker7.Margin = new Padding(3, 1, 3, 2);
            seancePicker7.Name = "seancePicker7";
            seancePicker7.NumeroSeance = 7;
            seance7.Absence = false;
            seance7.Active = false;
            seance7.Code = "";
            seance7.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance7.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 511);
            seance7.DateModifiedChecked = false;
            seance7.Employer = "";
            seance7.Montant = "";
            seance7.SceanceNumber = 7;
            seancePicker7.Seance = seance7;
            seancePicker7.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker7.Size = new System.Drawing.Size(786, 25);
            seancePicker7.TabIndex = 40;
            // 
            // seancePicker6
            // 
            seancePicker6.Absence = false;
            seancePicker6.Checked = false;
            seancePicker6.Code = "";
            seancePicker6.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 511);
            seancePicker6.DateModifiedChecked = false;
            seancePicker6.Employer = "";
            seancePicker6.Location = new System.Drawing.Point(19, 66);
            seancePicker6.Margin = new Padding(3, 1, 3, 2);
            seancePicker6.Name = "seancePicker6";
            seancePicker6.NumeroSeance = 6;
            seance8.Absence = false;
            seance8.Active = false;
            seance8.Code = "";
            seance8.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance8.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 511);
            seance8.DateModifiedChecked = false;
            seance8.Employer = "";
            seance8.Montant = "";
            seance8.SceanceNumber = 6;
            seancePicker6.Seance = seance8;
            seancePicker6.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker6.Size = new System.Drawing.Size(786, 25);
            seancePicker6.TabIndex = 33;
            // 
            // seancePicker5
            // 
            seancePicker5.Absence = false;
            seancePicker5.Checked = false;
            seancePicker5.Code = "";
            seancePicker5.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 521);
            seancePicker5.DateModifiedChecked = false;
            seancePicker5.Employer = "";
            seancePicker5.Location = new System.Drawing.Point(19, 39);
            seancePicker5.Margin = new Padding(3, 3, 3, 2);
            seancePicker5.Name = "seancePicker5";
            seancePicker5.NumeroSeance = 5;
            seance9.Absence = false;
            seance9.Active = false;
            seance9.Code = "";
            seance9.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance9.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 521);
            seance9.DateModifiedChecked = false;
            seance9.Employer = "";
            seance9.Montant = "";
            seance9.SceanceNumber = 5;
            seancePicker5.Seance = seance9;
            seancePicker5.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker5.Size = new System.Drawing.Size(786, 25);
            seancePicker5.TabIndex = 32;
            // 
            // cmdAnnuler
            // 
            cmdAnnuler.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            cmdAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cmdAnnuler.Image = global::Barette.Library.Properties.Resources.Cancel_2_icon;
            cmdAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cmdAnnuler.Location = new System.Drawing.Point(800, 384);
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
            cmdOK.Location = new System.Drawing.Point(699, 384);
            cmdOK.Name = "cmdOK";
            cmdOK.Size = new System.Drawing.Size(95, 45);
            cmdOK.TabIndex = 29;
            cmdOK.Text = "Appliquer";
            cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cmdOK.Click += new EventHandler(cmdOK_Click);
            // 
            // cmdPrintHorsRoute
            // 
            cmdPrintHorsRoute.ImageIndex = 0;
            cmdPrintHorsRoute.ImageList = imageList1;
            cmdPrintHorsRoute.Location = new System.Drawing.Point(815, 19);
            cmdPrintHorsRoute.Name = "cmdPrintHorsRoute";
            cmdPrintHorsRoute.Size = new System.Drawing.Size(51, 46);
            cmdPrintHorsRoute.TabIndex = 40;
            cmdPrintHorsRoute.Click += new EventHandler(cmdPrintHorsRoute_Click);
            // 
            // cmdPrintRoute
            // 
            cmdPrintRoute.ImageIndex = 0;
            cmdPrintRoute.ImageList = imageList1;
            cmdPrintRoute.Location = new System.Drawing.Point(815, 19);
            cmdPrintRoute.Name = "cmdPrintRoute";
            cmdPrintRoute.Size = new System.Drawing.Size(51, 46);
            cmdPrintRoute.TabIndex = 39;
            cmdPrintRoute.Click += new EventHandler(cmdPrintRoute_Click);
            // 
            // FormSeanceMoto
            // 
            ClientSize = new System.Drawing.Size(893, 439);
            ControlBox = false;
            Controls.Add(cmdAnnuler);
            Controls.Add(cmdOK);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "FormSeanceMoto";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Séance de cours pratique : Motocyclette";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void cmdCancel_Click(object sender, EventArgs e) {
            Close();
		}

		private void cmdOK_Click(object sender, EventArgs e) {
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

            //Fermer la boite
            Close();
		}

		private void InitializeSeance() {
			seancePicker1.ListEmploye = seancePicker2.ListEmploye =
				seancePicker3.ListEmploye = seancePicker4.ListEmploye =
                seancePicker5.ListEmploye = seancePicker6.ListEmploye = seancePicker7.ListEmploye = 
                seancePicker8.ListEmploye = seancePicker9.ListEmploye = _ListEmploye;

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

                }
            }
		}

		private void cmdPrintHorsRoute_Click(object sender, EventArgs e) {
			AddSeanceTemp();

            _ctrlClient.Client = _client;
            _ctrlClient.PrintDoc(true, true, false, PrintDocumentType.InfoClient); 
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
		}

		private void cmdPrintRoute_Click(object sender, EventArgs e) {
			AddSeanceTemp();
            _ctrlClient.Client = _client;
            _ctrlClient.PrintDoc(true, false, true, PrintDocumentType.InfoClient); 
		}

	}
}
