using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Barette.Library.Client;
using Barette.Library.UserControls.Client;
using Barette.Library.Collections;

namespace Barette.Library.UserControls.Client {
	/// <summary>
	/// Description résumée de FormSeanceMoto.
	/// </summary>
	public class FormSeanceMoto : System.Windows.Forms.Form {
		/// <summary>
		/// client referer
		/// </summary>
		private Customer _client;
		private ClientControl _ctrlClient;

		private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
		private Barette.Library.UserControls.SeancePicker seancePicker4;
		private Barette.Library.UserControls.SeancePicker seancePicker3;
		private Barette.Library.UserControls.SeancePicker seancePicker2;
		private Label label4;
		private Barette.Library.UserControls.SeancePicker seancePicker1;
		private Label label3;
		private Label label2;
		private Label label1;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Barette.Library.UserControls.SeancePicker seancePicker6;
		private Barette.Library.UserControls.SeancePicker seancePicker5;
		private Label label9;
		private Label label10;
		private Button cmdPrintRoute;
		private Button cmdPrintHorsRoute;
		private ImageList imageList1;
        private IContainer components;
        private Button cmdAnnuler;
        private Button cmdOK;
        private SeancePicker seancePicker9;
        private SeancePicker seancePicker8;
        private SeancePicker seancePicker7;

		private EmployeCollection _ListEmploye;

		public FormSeanceMoto(Customer client, ClientControl ctrl, EmployeCollection ListEmploye) {
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			this._client = client;
			this._ctrlClient = ctrl;
			this._ListEmploye = ListEmploye; 

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeanceMoto));
            Barette.Library.Client.Seance seance1 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance2 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance3 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance4 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance5 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance6 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance7 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance8 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance9 = new Barette.Library.Client.Seance();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdPrintHorsRoute = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdPrintRoute = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.seancePicker4 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker3 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker2 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker1 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker9 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker8 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker7 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker6 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker5 = new Barette.Library.UserControls.SeancePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdPrintHorsRoute);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.seancePicker4);
            this.groupBox1.Controls.Add(this.seancePicker3);
            this.groupBox1.Controls.Add(this.seancePicker2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.seancePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 154);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hors route";
            // 
            // cmdPrintHorsRoute
            // 
            this.cmdPrintHorsRoute.ImageIndex = 0;
            this.cmdPrintHorsRoute.ImageList = this.imageList1;
            this.cmdPrintHorsRoute.Location = new System.Drawing.Point(815, 19);
            this.cmdPrintHorsRoute.Name = "cmdPrintHorsRoute";
            this.cmdPrintHorsRoute.Size = new System.Drawing.Size(51, 46);
            this.cmdPrintHorsRoute.TabIndex = 40;
            this.cmdPrintHorsRoute.Click += new System.EventHandler(this.cmdPrintHorsRoute_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(683, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Montant";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(538, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Modification";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Employé";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Code";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Date et heure";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.seancePicker9);
            this.groupBox2.Controls.Add(this.seancePicker8);
            this.groupBox2.Controls.Add(this.seancePicker7);
            this.groupBox2.Controls.Add(this.cmdPrintRoute);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.seancePicker6);
            this.groupBox2.Controls.Add(this.seancePicker5);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(10, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(875, 190);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Route";
            // 
            // cmdPrintRoute
            // 
            this.cmdPrintRoute.ImageIndex = 0;
            this.cmdPrintRoute.ImageList = this.imageList1;
            this.cmdPrintRoute.Location = new System.Drawing.Point(815, 19);
            this.cmdPrintRoute.Name = "cmdPrintRoute";
            this.cmdPrintRoute.Size = new System.Drawing.Size(51, 46);
            this.cmdPrintRoute.TabIndex = 39;
            this.cmdPrintRoute.Click += new System.EventHandler(this.cmdPrintRoute_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(683, 19);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Montant";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(538, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Modification";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(385, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Employé";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(305, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Code";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(155, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Date et heure";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAnnuler.Image = global::Barette.Library.Properties.Resources.Cancel_2_icon;
            this.cmdAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAnnuler.Location = new System.Drawing.Point(800, 384);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.Size = new System.Drawing.Size(85, 45);
            this.cmdAnnuler.TabIndex = 30;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Image = global::Barette.Library.Properties.Resources.accept_icon;
            this.cmdOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdOK.Location = new System.Drawing.Point(699, 384);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(95, 45);
            this.cmdOK.TabIndex = 29;
            this.cmdOK.Text = "Appliquer";
            this.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // seancePicker4
            // 
            this.seancePicker4.Absence = false;
            this.seancePicker4.Checked = false;
            this.seancePicker4.Code = "";
            this.seancePicker4.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 541);
            this.seancePicker4.DateModifiedChecked = false;
            this.seancePicker4.Employer = "";
            this.seancePicker4.Location = new System.Drawing.Point(19, 123);
            this.seancePicker4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.seancePicker4.Name = "seancePicker4";
            this.seancePicker4.NumeroSeance = 4;
            seance1.Absence = false;
            seance1.Active = false;
            seance1.Code = "";
            seance1.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance1.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 541);
            seance1.DateModifiedChecked = false;
            seance1.Employer = "";
            seance1.Montant = "";
            seance1.SceanceNumber = 4;
            this.seancePicker4.Seance = seance1;
            this.seancePicker4.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker4.Size = new System.Drawing.Size(786, 25);
            this.seancePicker4.TabIndex = 31;
            // 
            // seancePicker3
            // 
            this.seancePicker3.Absence = false;
            this.seancePicker3.Checked = false;
            this.seancePicker3.Code = "";
            this.seancePicker3.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 551);
            this.seancePicker3.DateModifiedChecked = false;
            this.seancePicker3.Employer = "";
            this.seancePicker3.Location = new System.Drawing.Point(19, 96);
            this.seancePicker3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.seancePicker3.Name = "seancePicker3";
            this.seancePicker3.NumeroSeance = 3;
            seance2.Absence = false;
            seance2.Active = false;
            seance2.Code = "";
            seance2.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance2.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 551);
            seance2.DateModifiedChecked = false;
            seance2.Employer = "";
            seance2.Montant = "";
            seance2.SceanceNumber = 3;
            this.seancePicker3.Seance = seance2;
            this.seancePicker3.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker3.Size = new System.Drawing.Size(786, 25);
            this.seancePicker3.TabIndex = 30;
            // 
            // seancePicker2
            // 
            this.seancePicker2.Absence = false;
            this.seancePicker2.Checked = false;
            this.seancePicker2.Code = "";
            this.seancePicker2.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 571);
            this.seancePicker2.DateModifiedChecked = false;
            this.seancePicker2.Employer = "";
            this.seancePicker2.Location = new System.Drawing.Point(19, 68);
            this.seancePicker2.Name = "seancePicker2";
            this.seancePicker2.NumeroSeance = 2;
            seance3.Absence = false;
            seance3.Active = false;
            seance3.Code = "";
            seance3.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance3.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 571);
            seance3.DateModifiedChecked = false;
            seance3.Employer = "";
            seance3.Montant = "";
            seance3.SceanceNumber = 2;
            this.seancePicker2.Seance = seance3;
            this.seancePicker2.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker2.Size = new System.Drawing.Size(786, 25);
            this.seancePicker2.TabIndex = 29;
            // 
            // seancePicker1
            // 
            this.seancePicker1.Absence = false;
            this.seancePicker1.Checked = false;
            this.seancePicker1.Code = "";
            this.seancePicker1.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 581);
            this.seancePicker1.DateModifiedChecked = false;
            this.seancePicker1.Employer = "";
            this.seancePicker1.Location = new System.Drawing.Point(19, 40);
            this.seancePicker1.Name = "seancePicker1";
            this.seancePicker1.NumeroSeance = 1;
            seance4.Absence = false;
            seance4.Active = false;
            seance4.Code = "";
            seance4.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance4.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 581);
            seance4.DateModifiedChecked = false;
            seance4.Employer = "";
            seance4.Montant = "";
            seance4.SceanceNumber = 1;
            this.seancePicker1.Seance = seance4;
            this.seancePicker1.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker1.Size = new System.Drawing.Size(786, 25);
            this.seancePicker1.TabIndex = 27;
            // 
            // seancePicker9
            // 
            this.seancePicker9.Absence = false;
            this.seancePicker9.Checked = false;
            this.seancePicker9.Code = "";
            this.seancePicker9.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 511);
            this.seancePicker9.DateModifiedChecked = false;
            this.seancePicker9.Employer = "";
            this.seancePicker9.Location = new System.Drawing.Point(19, 150);
            this.seancePicker9.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.seancePicker9.Name = "seancePicker9";
            this.seancePicker9.NumeroSeance = 5;
            seance5.Absence = false;
            seance5.Active = false;
            seance5.Code = "";
            seance5.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance5.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 511);
            seance5.DateModifiedChecked = false;
            seance5.Employer = "";
            seance5.Montant = "";
            seance5.SceanceNumber = 5;
            this.seancePicker9.Seance = seance5;
            this.seancePicker9.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker9.Size = new System.Drawing.Size(786, 25);
            this.seancePicker9.TabIndex = 42;
            // 
            // seancePicker8
            // 
            this.seancePicker8.Absence = false;
            this.seancePicker8.Checked = false;
            this.seancePicker8.Code = "";
            this.seancePicker8.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 511);
            this.seancePicker8.DateModifiedChecked = false;
            this.seancePicker8.Employer = "";
            this.seancePicker8.Location = new System.Drawing.Point(19, 122);
            this.seancePicker8.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.seancePicker8.Name = "seancePicker8";
            this.seancePicker8.NumeroSeance = 4;
            seance6.Absence = false;
            seance6.Active = false;
            seance6.Code = "";
            seance6.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance6.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 511);
            seance6.DateModifiedChecked = false;
            seance6.Employer = "";
            seance6.Montant = "";
            seance6.SceanceNumber = 4;
            this.seancePicker8.Seance = seance6;
            this.seancePicker8.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker8.Size = new System.Drawing.Size(786, 25);
            this.seancePicker8.TabIndex = 41;
            // 
            // seancePicker7
            // 
            this.seancePicker7.Absence = false;
            this.seancePicker7.Checked = false;
            this.seancePicker7.Code = "";
            this.seancePicker7.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 511);
            this.seancePicker7.DateModifiedChecked = false;
            this.seancePicker7.Employer = "";
            this.seancePicker7.Location = new System.Drawing.Point(19, 94);
            this.seancePicker7.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.seancePicker7.Name = "seancePicker7";
            this.seancePicker7.NumeroSeance = 3;
            seance7.Absence = false;
            seance7.Active = false;
            seance7.Code = "";
            seance7.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance7.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 511);
            seance7.DateModifiedChecked = false;
            seance7.Employer = "";
            seance7.Montant = "";
            seance7.SceanceNumber = 3;
            this.seancePicker7.Seance = seance7;
            this.seancePicker7.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker7.Size = new System.Drawing.Size(786, 25);
            this.seancePicker7.TabIndex = 40;
            // 
            // seancePicker6
            // 
            this.seancePicker6.Absence = false;
            this.seancePicker6.Checked = false;
            this.seancePicker6.Code = "";
            this.seancePicker6.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 511);
            this.seancePicker6.DateModifiedChecked = false;
            this.seancePicker6.Employer = "";
            this.seancePicker6.Location = new System.Drawing.Point(19, 66);
            this.seancePicker6.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.seancePicker6.Name = "seancePicker6";
            this.seancePicker6.NumeroSeance = 2;
            seance8.Absence = false;
            seance8.Active = false;
            seance8.Code = "";
            seance8.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance8.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 511);
            seance8.DateModifiedChecked = false;
            seance8.Employer = "";
            seance8.Montant = "";
            seance8.SceanceNumber = 2;
            this.seancePicker6.Seance = seance8;
            this.seancePicker6.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker6.Size = new System.Drawing.Size(786, 25);
            this.seancePicker6.TabIndex = 33;
            // 
            // seancePicker5
            // 
            this.seancePicker5.Absence = false;
            this.seancePicker5.Checked = false;
            this.seancePicker5.Code = "";
            this.seancePicker5.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 521);
            this.seancePicker5.DateModifiedChecked = false;
            this.seancePicker5.Employer = "";
            this.seancePicker5.Location = new System.Drawing.Point(19, 39);
            this.seancePicker5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.seancePicker5.Name = "seancePicker5";
            this.seancePicker5.NumeroSeance = 1;
            seance9.Absence = false;
            seance9.Active = false;
            seance9.Code = "";
            seance9.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance9.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 521);
            seance9.DateModifiedChecked = false;
            seance9.Employer = "";
            seance9.Montant = "";
            seance9.SceanceNumber = 1;
            this.seancePicker5.Seance = seance9;
            this.seancePicker5.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker5.Size = new System.Drawing.Size(786, 25);
            this.seancePicker5.TabIndex = 32;
            // 
            // FormSeanceMoto
            // 
            this.ClientSize = new System.Drawing.Size(893, 439);
            this.ControlBox = false;
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSeanceMoto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Séance de cours pratique : Motocyclette";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void cmdCancel_Click(object sender, System.EventArgs e) {
			this.Close();
		}

		private void cmdOK_Click(object sender, System.EventArgs e) {
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

			//Fermer la boite
			this.Close();
		}

		private void InitializeSeance() {
			seancePicker1.ListEmploye = seancePicker2.ListEmploye =
				seancePicker3.ListEmploye = seancePicker4.ListEmploye =
                seancePicker5.ListEmploye = seancePicker6.ListEmploye = seancePicker7.ListEmploye = 
                seancePicker8.ListEmploye = seancePicker9.ListEmploye = this._ListEmploye;

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

                }
            }
		}

		private void cmdPrintHorsRoute_Click(object sender, EventArgs e) {
			AddSeanceTemp();
			
			this._ctrlClient.Client = this._client;
			this._ctrlClient.PrintDoc(true, true, false, PrintDocumentType.InfoClient); 
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
		}

		private void cmdPrintRoute_Click(object sender, EventArgs e) {
			AddSeanceTemp();
			this._ctrlClient.Client = this._client;
			this._ctrlClient.PrintDoc(true, false, true, PrintDocumentType.InfoClient); 
		}

	}
}
