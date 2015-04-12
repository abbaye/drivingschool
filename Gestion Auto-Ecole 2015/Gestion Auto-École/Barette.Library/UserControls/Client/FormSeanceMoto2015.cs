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
    public class FormSeanceMoto2015 : System.Windows.Forms.Form
    {
		/// <summary>
		/// client referer
		/// </summary>
		private Customer _client;
		private ClientControl _ctrlClient;

        private System.Windows.Forms.GroupBox groupBox1;
		private Barette.Library.UserControls.SeancePicker seancePicker4;
		private Barette.Library.UserControls.SeancePicker seancePicker3;
        private Barette.Library.UserControls.SeancePicker seancePicker2;
        private Barette.Library.UserControls.SeancePicker seancePicker1;
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

		private EmployeCollection _ListEmploye;

		public FormSeanceMoto2015(Customer client, ClientControl ctrl, EmployeCollection ListEmploye) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeanceMoto2015));
            Barette.Library.Client.Seance seance7 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance6 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance8 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance9 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance11 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance10 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance1 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance2 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance3 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance4 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance5 = new Barette.Library.Client.Seance();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmdPrintHorsRoute = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.seancePicker11 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker10 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker7 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker9 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker6 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker8 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker1 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker2 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker4 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker3 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker5 = new Barette.Library.UserControls.SeancePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.seancePicker1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 97);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FORMATION THÉORIQUE - Préparation à la conduite en circuit fermé ( 3 heures  )";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(606, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 52;
            this.label1.Text = "Montant";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 22);
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
            this.label3.Location = new System.Drawing.Point(496, 22);
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
            this.label2.Location = new System.Drawing.Point(423, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 49;
            this.label2.Text = "Code";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(102, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 23);
            this.label9.TabIndex = 48;
            this.label9.Text = "Date et heure (début)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdPrintHorsRoute
            // 
            this.cmdPrintHorsRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPrintHorsRoute.ImageIndex = 0;
            this.cmdPrintHorsRoute.ImageList = this.imageList1;
            this.cmdPrintHorsRoute.Location = new System.Drawing.Point(529, 631);
            this.cmdPrintHorsRoute.Name = "cmdPrintHorsRoute";
            this.cmdPrintHorsRoute.Size = new System.Drawing.Size(51, 45);
            this.cmdPrintHorsRoute.TabIndex = 40;
            this.cmdPrintHorsRoute.Click += new System.EventHandler(this.cmdPrintHorsRoute_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAnnuler.Image = global::Barette.Library.Properties.Resources.Cancel_2_icon;
            this.cmdAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAnnuler.Location = new System.Drawing.Point(687, 631);
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
            this.cmdOK.Location = new System.Drawing.Point(586, 631);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(95, 45);
            this.cmdOK.TabIndex = 29;
            this.cmdOK.Text = "Appliquer";
            this.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(102, 19);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 23);
            this.label10.TabIndex = 48;
            this.label10.Text = "Date et heure (début)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(423, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 23);
            this.label8.TabIndex = 49;
            this.label8.Text = "Code";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(496, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 23);
            this.label7.TabIndex = 50;
            this.label7.Text = "Employé";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(289, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 23);
            this.label6.TabIndex = 51;
            this.label6.Text = "Heures (fin)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(606, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 52;
            this.label5.Text = "Montant";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.seancePicker2);
            this.groupBox2.Controls.Add(this.seancePicker4);
            this.groupBox2.Controls.Add(this.seancePicker3);
            this.groupBox2.Controls.Add(this.seancePicker5);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(12, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 167);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FORMATION PRATIQUE EN CIRCUIT FERMÉ - ( 16 heures )";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.seancePicker10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.seancePicker11);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.seancePicker7);
            this.groupBox3.Controls.Add(this.seancePicker9);
            this.groupBox3.Controls.Add(this.seancePicker8);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(12, 391);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(754, 200);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FORMATION PRATIQUE SUR ROUTE - ( 10 heures )";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(606, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 23);
            this.label11.TabIndex = 52;
            this.label11.Text = "Montant";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(289, 19);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 23);
            this.label12.TabIndex = 51;
            this.label12.Text = "Heures (fin)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(496, 19);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 23);
            this.label13.TabIndex = 50;
            this.label13.Text = "Employé";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(423, 19);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 23);
            this.label14.TabIndex = 49;
            this.label14.Text = "Code";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(102, 19);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(200, 23);
            this.label15.TabIndex = 48;
            this.label15.Text = "Date et heure (début)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.seancePicker6);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Location = new System.Drawing.Point(10, 288);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(754, 97);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "FORMATION THÉORIQUE - Préparation à la conduite sur route ( 3 heures  )";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(606, 23);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 23);
            this.label16.TabIndex = 52;
            this.label16.Text = "Montant";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(289, 22);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 23);
            this.label17.TabIndex = 51;
            this.label17.Text = "Heures (fin)";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(496, 22);
            this.label18.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 23);
            this.label18.TabIndex = 50;
            this.label18.Text = "Employé";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(423, 22);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 23);
            this.label19.TabIndex = 49;
            this.label19.Text = "Code";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(102, 22);
            this.label20.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(200, 23);
            this.label20.TabIndex = 48;
            this.label20.Text = "Date et heure (début)";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seancePicker11
            // 
            this.seancePicker11.Absence = false;
            this.seancePicker11.Checked = false;
            this.seancePicker11.Code = "";
            this.seancePicker11.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 581);
            this.seancePicker11.DateModifiedChecked = false;
            this.seancePicker11.Employer = "";
            this.seancePicker11.Location = new System.Drawing.Point(19, 158);
            this.seancePicker11.Name = "seancePicker11";
            this.seancePicker11.NumeroSeance = 11;
            seance7.Absence = false;
            seance7.Active = false;
            seance7.Code = "";
            seance7.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance7.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 581);
            seance7.DateModifiedChecked = false;
            seance7.Employer = "";
            seance7.Montant = "";
            seance7.SceanceNumber = 11;
            this.seancePicker11.Seance = seance7;
            this.seancePicker11.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker11.Size = new System.Drawing.Size(786, 25);
            this.seancePicker11.TabIndex = 27;
            // 
            // seancePicker10
            // 
            this.seancePicker10.Absence = false;
            this.seancePicker10.Checked = false;
            this.seancePicker10.Code = "";
            this.seancePicker10.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 511);
            this.seancePicker10.DateModifiedChecked = false;
            this.seancePicker10.Employer = "";
            this.seancePicker10.Location = new System.Drawing.Point(19, 128);
            this.seancePicker10.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.seancePicker10.Name = "seancePicker10";
            this.seancePicker10.NumeroSeance = 10;
            seance6.Absence = false;
            seance6.Active = false;
            seance6.Code = "";
            seance6.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance6.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 511);
            seance6.DateModifiedChecked = false;
            seance6.Employer = "";
            seance6.Montant = "";
            seance6.SceanceNumber = 10;
            this.seancePicker10.Seance = seance6;
            this.seancePicker10.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker10.Size = new System.Drawing.Size(786, 25);
            this.seancePicker10.TabIndex = 53;
            // 
            // seancePicker7
            // 
            this.seancePicker7.Absence = false;
            this.seancePicker7.Checked = false;
            this.seancePicker7.Code = "";
            this.seancePicker7.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 511);
            this.seancePicker7.DateModifiedChecked = false;
            this.seancePicker7.Employer = "";
            this.seancePicker7.Location = new System.Drawing.Point(19, 44);
            this.seancePicker7.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.seancePicker7.Name = "seancePicker7";
            this.seancePicker7.NumeroSeance = 7;
            seance8.Absence = false;
            seance8.Active = false;
            seance8.Code = "";
            seance8.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance8.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 511);
            seance8.DateModifiedChecked = false;
            seance8.Employer = "";
            seance8.Montant = "";
            seance8.SceanceNumber = 7;
            this.seancePicker7.Seance = seance8;
            this.seancePicker7.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker7.Size = new System.Drawing.Size(786, 25);
            this.seancePicker7.TabIndex = 40;
            // 
            // seancePicker9
            // 
            this.seancePicker9.Absence = false;
            this.seancePicker9.Checked = false;
            this.seancePicker9.Code = "";
            this.seancePicker9.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 511);
            this.seancePicker9.DateModifiedChecked = false;
            this.seancePicker9.Employer = "";
            this.seancePicker9.Location = new System.Drawing.Point(19, 100);
            this.seancePicker9.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.seancePicker9.Name = "seancePicker9";
            this.seancePicker9.NumeroSeance = 9;
            seance9.Absence = false;
            seance9.Active = false;
            seance9.Code = "";
            seance9.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance9.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 511);
            seance9.DateModifiedChecked = false;
            seance9.Employer = "";
            seance9.Montant = "";
            seance9.SceanceNumber = 9;
            this.seancePicker9.Seance = seance9;
            this.seancePicker9.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker9.Size = new System.Drawing.Size(786, 25);
            this.seancePicker9.TabIndex = 42;
            // 
            // seancePicker6
            // 
            this.seancePicker6.Absence = false;
            this.seancePicker6.Checked = false;
            this.seancePicker6.Code = "";
            this.seancePicker6.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 511);
            this.seancePicker6.DateModifiedChecked = false;
            this.seancePicker6.Employer = "";
            this.seancePicker6.Location = new System.Drawing.Point(19, 46);
            this.seancePicker6.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.seancePicker6.Name = "seancePicker6";
            this.seancePicker6.NumeroSeance = 6;
            seance11.Absence = false;
            seance11.Active = false;
            seance11.Code = "";
            seance11.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance11.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 511);
            seance11.DateModifiedChecked = false;
            seance11.Employer = "";
            seance11.Montant = "";
            seance11.SceanceNumber = 6;
            this.seancePicker6.Seance = seance11;
            this.seancePicker6.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker6.Size = new System.Drawing.Size(786, 25);
            this.seancePicker6.TabIndex = 33;
            // 
            // seancePicker8
            // 
            this.seancePicker8.Absence = false;
            this.seancePicker8.Checked = false;
            this.seancePicker8.Code = "";
            this.seancePicker8.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 511);
            this.seancePicker8.DateModifiedChecked = false;
            this.seancePicker8.Employer = "";
            this.seancePicker8.Location = new System.Drawing.Point(19, 72);
            this.seancePicker8.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.seancePicker8.Name = "seancePicker8";
            this.seancePicker8.NumeroSeance = 8;
            seance10.Absence = false;
            seance10.Active = false;
            seance10.Code = "";
            seance10.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance10.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 511);
            seance10.DateModifiedChecked = false;
            seance10.Employer = "";
            seance10.Montant = "";
            seance10.SceanceNumber = 8;
            this.seancePicker8.Seance = seance10;
            this.seancePicker8.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker8.Size = new System.Drawing.Size(786, 25);
            this.seancePicker8.TabIndex = 41;
            // 
            // seancePicker1
            // 
            this.seancePicker1.Absence = false;
            this.seancePicker1.Checked = false;
            this.seancePicker1.Code = "";
            this.seancePicker1.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 581);
            this.seancePicker1.DateModifiedChecked = false;
            this.seancePicker1.Employer = "";
            this.seancePicker1.Location = new System.Drawing.Point(19, 45);
            this.seancePicker1.Name = "seancePicker1";
            this.seancePicker1.NumeroSeance = 1;
            seance1.Absence = false;
            seance1.Active = false;
            seance1.Code = "";
            seance1.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance1.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 581);
            seance1.DateModifiedChecked = false;
            seance1.Employer = "";
            seance1.Montant = "";
            seance1.SceanceNumber = 1;
            this.seancePicker1.Seance = seance1;
            this.seancePicker1.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker1.Size = new System.Drawing.Size(786, 25);
            this.seancePicker1.TabIndex = 27;
            // 
            // seancePicker2
            // 
            this.seancePicker2.Absence = false;
            this.seancePicker2.Checked = false;
            this.seancePicker2.Code = "";
            this.seancePicker2.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 571);
            this.seancePicker2.DateModifiedChecked = false;
            this.seancePicker2.Employer = "";
            this.seancePicker2.Location = new System.Drawing.Point(19, 46);
            this.seancePicker2.Name = "seancePicker2";
            this.seancePicker2.NumeroSeance = 2;
            seance2.Absence = false;
            seance2.Active = false;
            seance2.Code = "";
            seance2.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance2.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 571);
            seance2.DateModifiedChecked = false;
            seance2.Employer = "";
            seance2.Montant = "";
            seance2.SceanceNumber = 2;
            this.seancePicker2.Seance = seance2;
            this.seancePicker2.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker2.Size = new System.Drawing.Size(786, 25);
            this.seancePicker2.TabIndex = 29;
            // 
            // seancePicker4
            // 
            this.seancePicker4.Absence = false;
            this.seancePicker4.Checked = false;
            this.seancePicker4.Code = "";
            this.seancePicker4.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 541);
            this.seancePicker4.DateModifiedChecked = false;
            this.seancePicker4.Employer = "";
            this.seancePicker4.Location = new System.Drawing.Point(19, 101);
            this.seancePicker4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.seancePicker4.Name = "seancePicker4";
            this.seancePicker4.NumeroSeance = 4;
            seance3.Absence = false;
            seance3.Active = false;
            seance3.Code = "";
            seance3.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance3.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 541);
            seance3.DateModifiedChecked = false;
            seance3.Employer = "";
            seance3.Montant = "";
            seance3.SceanceNumber = 4;
            this.seancePicker4.Seance = seance3;
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
            this.seancePicker3.Location = new System.Drawing.Point(19, 74);
            this.seancePicker3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.seancePicker3.Name = "seancePicker3";
            this.seancePicker3.NumeroSeance = 3;
            seance4.Absence = false;
            seance4.Active = false;
            seance4.Code = "";
            seance4.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance4.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 551);
            seance4.DateModifiedChecked = false;
            seance4.Employer = "";
            seance4.Montant = "";
            seance4.SceanceNumber = 3;
            this.seancePicker3.Seance = seance4;
            this.seancePicker3.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker3.Size = new System.Drawing.Size(786, 25);
            this.seancePicker3.TabIndex = 30;
            // 
            // seancePicker5
            // 
            this.seancePicker5.Absence = false;
            this.seancePicker5.Checked = false;
            this.seancePicker5.Code = "";
            this.seancePicker5.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 521);
            this.seancePicker5.DateModifiedChecked = false;
            this.seancePicker5.Employer = "";
            this.seancePicker5.Location = new System.Drawing.Point(19, 129);
            this.seancePicker5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.seancePicker5.Name = "seancePicker5";
            this.seancePicker5.NumeroSeance = 5;
            seance5.Absence = false;
            seance5.Active = false;
            seance5.Code = "";
            seance5.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance5.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 521);
            seance5.DateModifiedChecked = false;
            seance5.Employer = "";
            seance5.Montant = "";
            seance5.SceanceNumber = 5;
            this.seancePicker5.Seance = seance5;
            this.seancePicker5.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker5.Size = new System.Drawing.Size(786, 25);
            this.seancePicker5.TabIndex = 32;
            // 
            // FormSeanceMoto2015
            // 
            this.ClientSize = new System.Drawing.Size(780, 686);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmdPrintHorsRoute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSeanceMoto2015";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Séance de cours pratique : Motocyclette";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void cmdCancel_Click(object sender, System.EventArgs e) {
			this.Close();
		}

		private void cmdOK_Click(object sender, System.EventArgs e) {
			//Suppression des seance en cours
			this._client.Seances.Clear();
            this._client.SeancesTheorique.Clear();

            if (seancePicker1.Checked == true) this._client.SeancesTheorique.Add(seancePicker1.Seance);
            if (seancePicker6.Checked == true) this._client.SeancesTheorique.Add(seancePicker6.Seance);

            if (seancePicker2.Checked == true) this._client.Seances.Add(seancePicker2.Seance);
            if (seancePicker3.Checked == true) this._client.Seances.Add(seancePicker3.Seance);
            if (seancePicker4.Checked == true) this._client.Seances.Add(seancePicker4.Seance);
            if (seancePicker5.Checked == true) this._client.Seances.Add(seancePicker5.Seance);            
            if (seancePicker7.Checked == true) this._client.Seances.Add(seancePicker7.Seance);
            if (seancePicker8.Checked == true) this._client.Seances.Add(seancePicker8.Seance);
            if (seancePicker9.Checked == true) this._client.Seances.Add(seancePicker9.Seance);
            if (seancePicker10.Checked == true) this._client.Seances.Add(seancePicker10.Seance);
            if (seancePicker11.Checked == true) this._client.Seances.Add(seancePicker11.Seance);

			//Fermer la boite
			this.Close();
		}

		private void InitializeSeance() {
			seancePicker1.ListEmploye = seancePicker2.ListEmploye =
				seancePicker3.ListEmploye = seancePicker4.ListEmploye =
                seancePicker5.ListEmploye = seancePicker6.ListEmploye = seancePicker7.ListEmploye =
                seancePicker8.ListEmploye = seancePicker9.ListEmploye = seancePicker10.ListEmploye = seancePicker11.ListEmploye =this._ListEmploye;

            for (int i = 0; i < this._client.SeancesTheorique.Count; i++)
            {
                switch (this._client.SeancesTheorique[i].SceanceNumber)
                {
                    case 1:
                        seancePicker1.Seance = this._client.SeancesTheorique[i];
                        break;
                    case 6:
                        seancePicker6.Seance = this._client.SeancesTheorique[i];
                        break;
                }
            }


            for (int i = 0; i < this._client.Seances.Count; i++) {
                switch (this._client.Seances[i].SceanceNumber) {
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
            this._ctrlClient.Client.SeancesTheorique.Clear();

			this._ctrlClient.Client.SeancesTheorique.Add(seancePicker1.Seance);
			this._ctrlClient.Client.SeancesTheorique.Add(seancePicker6.Seance);
			
            this._ctrlClient.Client.Seances.Add(seancePicker2.Seance);
			this._ctrlClient.Client.Seances.Add(seancePicker3.Seance);
			this._ctrlClient.Client.Seances.Add(seancePicker4.Seance);
			this._ctrlClient.Client.Seances.Add(seancePicker5.Seance);
            this._ctrlClient.Client.Seances.Add(seancePicker7.Seance);
            this._ctrlClient.Client.Seances.Add(seancePicker8.Seance);
            this._ctrlClient.Client.Seances.Add(seancePicker9.Seance);
            this._ctrlClient.Client.Seances.Add(seancePicker10.Seance);
            this._ctrlClient.Client.Seances.Add(seancePicker11.Seance);
		}

		private void cmdPrintRoute_Click(object sender, EventArgs e) {
			AddSeanceTemp();
			this._ctrlClient.Client = this._client;
			this._ctrlClient.PrintDoc(true, false, true, PrintDocumentType.InfoClient); 

		}

	}
}
