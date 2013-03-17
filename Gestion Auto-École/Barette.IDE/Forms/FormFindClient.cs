using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Barette.Library.Client;
using Barette.Library.Collections;
using Barette.Library.Listview;
using Barette.Library.Win32;


namespace Barette.IDE.Forms {
	/// <summary>
	/// Description résumée de FormFindClient.
	/// </summary>
	public class FormFindClient : System.Windows.Forms.Form {
		/// <summary>
		/// acces a la Fenetre principal
		/// </summary>		
		private FormMain _FormMain = null;

		/// <summary>
		/// Donne acess a la liste des employe
		/// </summary>
		private EmployeCollection _ListEmploye = null;

		private System.Windows.Forms.ListView listFindResult;
		private System.Windows.Forms.CheckBox chkDisponibilityPM;
		private System.Windows.Forms.CheckBox chkDisponibilityAM;
		private System.Windows.Forms.ColumnHeader colheadName;
		private System.Windows.Forms.ColumnHeader colheadContratNumber;
		private System.Windows.Forms.ColumnHeader colheadDate;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton toolBarButton5;		
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ColumnHeader colHeadPhone;
		private System.Windows.Forms.ColumnHeader colHeadTypeVehicule;
		private System.Windows.Forms.ColumnHeader colHeadSolde;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton tbbShowClient;
        private System.Windows.Forms.ToolBarButton tbbSeparator1;
		private ColumnHeader colHeadDernierPaiment;
		private ToolBarButton tbbPrintFindList;
		private System.Drawing.Printing.PrintDocument PrintRelever;
		private ImageList ImageListSmall;
		private ToolBarButton tbbRefresh;
		private ToolBarButton toolBarButton1;
		private Barette.Library.UserControls.Client.ClientControl clientControl1;
		private ToolBarButton tbbShowPaiment;
        private Label lblTotalFind;
        private TabPage tpMoto;
        private Label label6;
        private Label label5;
        private DateTimePicker dtpDateDebutMoto;
        private DateTimePicker dtpDateFinMoto;
        private Label label4;
        private PictureBox pictureBox3;
        private TabPage tpDate;
        private ComboBox cbChoice;
        private MonthCalendar monthCalendar2;
        private TabPage tpClientType;
        private RadioButton rbTypeClientFinish;
        private RadioButton rbTypeClientActif;
        private TabPage tpDispo;
        private RadioButton rbAlway;
        private RadioButton rbDimanche;
        private RadioButton rbSamedi;
        private RadioButton rbSoir;
        private RadioButton rbApresMidi;
        private RadioButton rbMatin;
        private TabPage tpVehicule;
        private RadioButton rbVehiculCyclomoteur;
        private RadioButton rbVehiculMoto;
        private RadioButton rbVehiculAutomatique;
        private RadioButton rbVehiculManuel;
        private TabPage tpClientInfo;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtFirstName;
        private TextBox txtClientName;
        private RadioButton rbFirstName;
        private RadioButton rbName;
        private TabControl tabControl1;
		private System.ComponentModel.IContainer components;

		public FormFindClient(FormMain main, EmployeCollection ListEmploye) {
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			this._FormMain = main;

			//Control client
			this._ListEmploye = ListEmploye; 
			this.clientControl1.ListeEmploye = ListEmploye;

			//StaticBorder.ThinBorder(listFindResult.Handle.ToInt32(), true);
			StaticBorder.ThinBorder(tpDate.Handle.ToInt32(), true);
			StaticBorder.ThinBorder(tpClientInfo.Handle.ToInt32(), true);
			StaticBorder.ThinBorder(tpClientType.Handle.ToInt32(), true);
			StaticBorder.ThinBorder(tpDispo.Handle.ToInt32(), true);
			StaticBorder.ThinBorder(tpVehicule.Handle.ToInt32(), true);
			StaticBorder.ThinBorder(tpMoto.Handle.ToInt32(), true);

	    	SortByDate();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFindClient));
            Barette.Library.Client.Customer customer2 = new Barette.Library.Client.Customer();
            this.listFindResult = new System.Windows.Forms.ListView();
            this.colheadContratNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadTypeVehicule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadSolde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadDernierPaiment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.chkDisponibilityPM = new System.Windows.Forms.CheckBox();
            this.chkDisponibilityAM = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.tbbRefresh = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.tbbShowClient = new System.Windows.Forms.ToolBarButton();
            this.tbbShowPaiment = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.tbbPrintFindList = new System.Windows.Forms.ToolBarButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PrintRelever = new System.Drawing.Printing.PrintDocument();
            this.clientControl1 = new Barette.Library.UserControls.Client.ClientControl();
            this.lblTotalFind = new System.Windows.Forms.Label();
            this.tpMoto = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateFinMoto = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDebutMoto = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tpDate = new System.Windows.Forms.TabPage();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.cbChoice = new System.Windows.Forms.ComboBox();
            this.tpClientType = new System.Windows.Forms.TabPage();
            this.rbTypeClientActif = new System.Windows.Forms.RadioButton();
            this.rbTypeClientFinish = new System.Windows.Forms.RadioButton();
            this.tpDispo = new System.Windows.Forms.TabPage();
            this.rbMatin = new System.Windows.Forms.RadioButton();
            this.rbApresMidi = new System.Windows.Forms.RadioButton();
            this.rbSoir = new System.Windows.Forms.RadioButton();
            this.rbSamedi = new System.Windows.Forms.RadioButton();
            this.rbDimanche = new System.Windows.Forms.RadioButton();
            this.rbAlway = new System.Windows.Forms.RadioButton();
            this.tpVehicule = new System.Windows.Forms.TabPage();
            this.rbVehiculManuel = new System.Windows.Forms.RadioButton();
            this.rbVehiculAutomatique = new System.Windows.Forms.RadioButton();
            this.rbVehiculMoto = new System.Windows.Forms.RadioButton();
            this.rbVehiculCyclomoteur = new System.Windows.Forms.RadioButton();
            this.tpClientInfo = new System.Windows.Forms.TabPage();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.rbFirstName = new System.Windows.Forms.RadioButton();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpMoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tpDate.SuspendLayout();
            this.tpClientType.SuspendLayout();
            this.tpDispo.SuspendLayout();
            this.tpVehicule.SuspendLayout();
            this.tpClientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listFindResult
            // 
            this.listFindResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listFindResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colheadContratNumber,
            this.colheadName,
            this.colheadDate,
            this.colHeadPhone,
            this.colHeadTypeVehicule,
            this.colHeadSolde,
            this.colHeadDernierPaiment});
            this.listFindResult.FullRowSelect = true;
            this.listFindResult.Location = new System.Drawing.Point(8, 306);
            this.listFindResult.MultiSelect = false;
            this.listFindResult.Name = "listFindResult";
            this.listFindResult.Size = new System.Drawing.Size(852, 200);
            this.listFindResult.SmallImageList = this.ImageListSmall;
            this.listFindResult.TabIndex = 0;
            this.listFindResult.UseCompatibleStateImageBehavior = false;
            this.listFindResult.View = System.Windows.Forms.View.Details;
            this.listFindResult.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listFindResult_ColumnClick);
            this.listFindResult.SelectedIndexChanged += new System.EventHandler(this.listFindResult_SelectedIndexChanged);
            this.listFindResult.Click += new System.EventHandler(this.listFindResult_Click);
            // 
            // colheadContratNumber
            // 
            this.colheadContratNumber.Text = "# Contrat";
            this.colheadContratNumber.Width = 66;
            // 
            // colheadName
            // 
            this.colheadName.Text = "Nom du client";
            this.colheadName.Width = 183;
            // 
            // colheadDate
            // 
            this.colheadDate.Text = "Date d\'inscription";
            this.colheadDate.Width = 118;
            // 
            // colHeadPhone
            // 
            this.colHeadPhone.Text = "Téléphone";
            this.colHeadPhone.Width = 102;
            // 
            // colHeadTypeVehicule
            // 
            this.colHeadTypeVehicule.Text = "Type de cours";
            this.colHeadTypeVehicule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHeadTypeVehicule.Width = 99;
            // 
            // colHeadSolde
            // 
            this.colHeadSolde.Text = "Solde";
            this.colHeadSolde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colHeadSolde.Width = 64;
            // 
            // colHeadDernierPaiment
            // 
            this.colHeadDernierPaiment.Text = "Dernier Paiment";
            this.colHeadDernierPaiment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHeadDernierPaiment.Width = 97;
            // 
            // ImageListSmall
            // 
            this.ImageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListSmall.ImageStream")));
            this.ImageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListSmall.Images.SetKeyName(0, "Moto");
            this.ImageListSmall.Images.SetKeyName(1, "Auto");
            this.ImageListSmall.Images.SetKeyName(2, "Camion");
            // 
            // chkDisponibilityPM
            // 
            this.chkDisponibilityPM.Location = new System.Drawing.Point(0, 0);
            this.chkDisponibilityPM.Name = "chkDisponibilityPM";
            this.chkDisponibilityPM.Size = new System.Drawing.Size(104, 24);
            this.chkDisponibilityPM.TabIndex = 0;
            // 
            // chkDisponibilityAM
            // 
            this.chkDisponibilityAM.Location = new System.Drawing.Point(0, 0);
            this.chkDisponibilityAM.Name = "chkDisponibilityAM";
            this.chkDisponibilityAM.Size = new System.Drawing.Size(104, 24);
            this.chkDisponibilityAM.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "user-group-icon.png");
            this.imageList1.Images.SetKeyName(4, "Recyclebin_empty");
            this.imageList1.Images.SetKeyName(5, "coins-icon.png");
            // 
            // toolBar1
            // 
            this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBar1.AutoSize = false;
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbRefresh,
            this.toolBarButton1,
            this.tbbShowClient,
            this.tbbShowPaiment,
            this.toolBarButton2,
            this.tbbSeparator1,
            this.toolBarButton5,
            this.tbbPrintFindList});
            this.toolBar1.Divider = false;
            this.toolBar1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Location = new System.Drawing.Point(8, 12);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(478, 42);
            this.toolBar1.TabIndex = 13;
            this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // tbbRefresh
            // 
            this.tbbRefresh.ImageKey = "Recyclebin_empty";
            this.tbbRefresh.Name = "tbbRefresh";
            this.tbbRefresh.Tag = "REFRESH";
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbShowClient
            // 
            this.tbbShowClient.ImageIndex = 3;
            this.tbbShowClient.Name = "tbbShowClient";
            this.tbbShowClient.Tag = "SHOWCLIENT";
            this.tbbShowClient.ToolTipText = "Affiche le client";
            // 
            // tbbShowPaiment
            // 
            this.tbbShowPaiment.ImageIndex = 5;
            this.tbbShowPaiment.Name = "tbbShowPaiment";
            this.tbbShowPaiment.Tag = "PAIMENT";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.ImageIndex = 1;
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.Tag = "OPENSEANCE";
            this.toolBarButton2.ToolTipText = "Affiche la boîte de séances de cours";
            // 
            // tbbSeparator1
            // 
            this.tbbSeparator1.Name = "tbbSeparator1";
            this.tbbSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.ImageIndex = 0;
            this.toolBarButton5.Name = "toolBarButton5";
            this.toolBarButton5.Tag = "PRINT";
            this.toolBarButton5.Text = "Infos Client";
            // 
            // tbbPrintFindList
            // 
            this.tbbPrintFindList.ImageIndex = 0;
            this.tbbPrintFindList.Name = "tbbPrintFindList";
            this.tbbPrintFindList.Tag = "PRINTFINDLIST";
            this.tbbPrintFindList.Text = "Liste de recherche";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PrintRelever
            // 
            this.PrintRelever.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintRelever_PrintPage);
            // 
            // clientControl1
            // 
            this.clientControl1.AutoUpdate = false;
            this.clientControl1.BackColor = System.Drawing.SystemColors.Control;
            customer2.AttestationNumber1 = "";
            customer2.AttestationNumber2 = "";
            customer2.BVA = false;
            customer2.BVADate = new System.DateTime(2005, 2, 20, 18, 50, 33, 675);
            customer2.City = "";
            customer2.ClientNull = false;
            customer2.CodePostal = "   -";
            customer2.ContratNumber = "0";
            customer2.DateAttestation1 = new System.DateTime(2010, 5, 27, 13, 11, 41, 692);
            customer2.DateAttestation2 = new System.DateTime(2010, 5, 27, 13, 11, 41, 692);
            customer2.DateDebutCours = new System.DateTime(2010, 3, 10, 16, 11, 1, 688);
            customer2.DateExpiration = new System.DateTime(2010, 3, 10, 16, 11, 1, 688);
            customer2.DateInscription = new System.DateTime(2003, 8, 26, 0, 0, 0, 0);
            customer2.DateNaissance = new System.DateTime(2010, 3, 10, 16, 11, 1, 688);
            customer2.DateTemporaire = new System.DateTime(2005, 2, 20, 18, 50, 33, 675);
            customer2.DisponibilityAlway = false;
            customer2.DisponibilityAM = false;
            customer2.DisponibilityDimanche = false;
            customer2.DisponibilityPM = false;
            customer2.DisponibilitySamedi = false;
            customer2.DisponibilitySoirer = false;
            customer2.FirstName = "";
            customer2.HaveTemporaire = false;
            customer2.LastRecuNumber = "";
            customer2.LocationAutomobile = false;
            customer2.LocationMoto = false;
            customer2.MontantCours = "";
            customer2.MontantLocation = "0 $";
            customer2.Name = "";
            customer2.No6R = "";
            customer2.Notes = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3084{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
                "ans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            customer2.NumeroGroupe = 0;
            customer2.NumeroPermis = "";
            customer2.Phone = "(   )   -";
            customer2.PhoneBureau = "(   )   -";
            customer2.Solde = "0 $";
            customer2.StreetApp = "";
            customer2.StreetName = "";
            customer2.StreetNumber = "";
            customer2.TauxHorairePratique = "";
            customer2.TauxHoraireTheorique = "";
            customer2.TypeClient = Barette.Library.Client.ProfileType.Actif;
            customer2.TypeVehicule = Barette.Library.Client.VehiculeType.Automatique;
            this.clientControl1.Client = customer2;
            this.clientControl1.Location = new System.Drawing.Point(657, 344);
            this.clientControl1.Name = "clientControl1";
            this.clientControl1.School = null;
            this.clientControl1.Size = new System.Drawing.Size(160, 160);
            this.clientControl1.TabIndex = 14;
            this.clientControl1.Visible = false;
            // 
            // lblTotalFind
            // 
            this.lblTotalFind.AutoSize = true;
            this.lblTotalFind.Location = new System.Drawing.Point(9, 285);
            this.lblTotalFind.Name = "lblTotalFind";
            this.lblTotalFind.Size = new System.Drawing.Size(197, 13);
            this.lblTotalFind.TabIndex = 15;
            this.lblTotalFind.Text = "0 Résultats trouvé dans votre recherche";
            // 
            // tpMoto
            // 
            this.tpMoto.Controls.Add(this.label6);
            this.tpMoto.Controls.Add(this.label5);
            this.tpMoto.Controls.Add(this.dtpDateDebutMoto);
            this.tpMoto.Controls.Add(this.dtpDateFinMoto);
            this.tpMoto.Controls.Add(this.label4);
            this.tpMoto.Controls.Add(this.pictureBox3);
            this.tpMoto.Location = new System.Drawing.Point(4, 25);
            this.tpMoto.Name = "tpMoto";
            this.tpMoto.Padding = new System.Windows.Forms.Padding(3);
            this.tpMoto.Size = new System.Drawing.Size(844, 193);
            this.tpMoto.TabIndex = 8;
            this.tpMoto.Tag = "MOTO";
            this.tpMoto.Text = "Moto";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(548, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(587, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "Recherche tous les clients de moto qui ont payé leurs cours complètement. Cette r" +
                "echerche est trié par la colonne : Dernier Paiment.";
            // 
            // dtpDateFinMoto
            // 
            this.dtpDateFinMoto.Location = new System.Drawing.Point(297, 70);
            this.dtpDateFinMoto.Name = "dtpDateFinMoto";
            this.dtpDateFinMoto.Size = new System.Drawing.Size(138, 20);
            this.dtpDateFinMoto.TabIndex = 8;
            // 
            // dtpDateDebutMoto
            // 
            this.dtpDateDebutMoto.Location = new System.Drawing.Point(66, 70);
            this.dtpDateDebutMoto.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.dtpDateDebutMoto.Name = "dtpDateDebutMoto";
            this.dtpDateDebutMoto.Size = new System.Drawing.Size(138, 20);
            this.dtpDateDebutMoto.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(66, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date de début";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(297, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date de fin";
            // 
            // tpDate
            // 
            this.tpDate.Controls.Add(this.cbChoice);
            this.tpDate.Controls.Add(this.monthCalendar2);
            this.tpDate.Location = new System.Drawing.Point(4, 25);
            this.tpDate.Name = "tpDate";
            this.tpDate.Size = new System.Drawing.Size(844, 193);
            this.tpDate.TabIndex = 4;
            this.tpDate.Tag = "INSCRIPTIONDATE";
            this.tpDate.Text = "Date Inscription";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(244, 18);
            this.monthCalendar2.MaxSelectionCount = 1;
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 1;
            // 
            // cbChoice
            // 
            this.cbChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChoice.FormattingEnabled = true;
            this.cbChoice.Items.AddRange(new object[] {
            "Égal ( = )",
            "Plus grand que ( > )",
            "Plus petit que ( < )",
            "Plus grand ou égal à ( >= )",
            "Plus petit ou égal à ( <= )"});
            this.cbChoice.Location = new System.Drawing.Point(12, 85);
            this.cbChoice.Name = "cbChoice";
            this.cbChoice.Size = new System.Drawing.Size(224, 21);
            this.cbChoice.TabIndex = 2;
            // 
            // tpClientType
            // 
            this.tpClientType.Controls.Add(this.rbTypeClientFinish);
            this.tpClientType.Controls.Add(this.rbTypeClientActif);
            this.tpClientType.Location = new System.Drawing.Point(4, 25);
            this.tpClientType.Name = "tpClientType";
            this.tpClientType.Size = new System.Drawing.Size(844, 193);
            this.tpClientType.TabIndex = 3;
            this.tpClientType.Tag = "CLIENTTYPE";
            this.tpClientType.Text = "Type de client";
            // 
            // rbTypeClientActif
            // 
            this.rbTypeClientActif.Checked = true;
            this.rbTypeClientActif.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbTypeClientActif.Location = new System.Drawing.Point(32, 40);
            this.rbTypeClientActif.Name = "rbTypeClientActif";
            this.rbTypeClientActif.Size = new System.Drawing.Size(104, 24);
            this.rbTypeClientActif.TabIndex = 6;
            this.rbTypeClientActif.TabStop = true;
            this.rbTypeClientActif.Text = "Actif";
            // 
            // rbTypeClientFinish
            // 
            this.rbTypeClientFinish.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbTypeClientFinish.Location = new System.Drawing.Point(32, 82);
            this.rbTypeClientFinish.Name = "rbTypeClientFinish";
            this.rbTypeClientFinish.Size = new System.Drawing.Size(104, 24);
            this.rbTypeClientFinish.TabIndex = 8;
            this.rbTypeClientFinish.Text = "Cours terminé";
            // 
            // tpDispo
            // 
            this.tpDispo.BackColor = System.Drawing.Color.Transparent;
            this.tpDispo.Controls.Add(this.rbAlway);
            this.tpDispo.Controls.Add(this.rbDimanche);
            this.tpDispo.Controls.Add(this.rbSamedi);
            this.tpDispo.Controls.Add(this.rbSoir);
            this.tpDispo.Controls.Add(this.rbApresMidi);
            this.tpDispo.Controls.Add(this.rbMatin);
            this.tpDispo.Location = new System.Drawing.Point(4, 25);
            this.tpDispo.Name = "tpDispo";
            this.tpDispo.Size = new System.Drawing.Size(844, 193);
            this.tpDispo.TabIndex = 2;
            this.tpDispo.Tag = "DISPO";
            this.tpDispo.Text = "Disponibilité";
            // 
            // rbMatin
            // 
            this.rbMatin.BackColor = System.Drawing.Color.Transparent;
            this.rbMatin.Location = new System.Drawing.Point(136, 30);
            this.rbMatin.Name = "rbMatin";
            this.rbMatin.Size = new System.Drawing.Size(104, 24);
            this.rbMatin.TabIndex = 11;
            this.rbMatin.Text = "Matin";
            this.rbMatin.UseVisualStyleBackColor = false;
            // 
            // rbApresMidi
            // 
            this.rbApresMidi.BackColor = System.Drawing.Color.Transparent;
            this.rbApresMidi.Location = new System.Drawing.Point(136, 54);
            this.rbApresMidi.Name = "rbApresMidi";
            this.rbApresMidi.Size = new System.Drawing.Size(104, 24);
            this.rbApresMidi.TabIndex = 12;
            this.rbApresMidi.Text = "Après Midi";
            this.rbApresMidi.UseVisualStyleBackColor = false;
            // 
            // rbSoir
            // 
            this.rbSoir.BackColor = System.Drawing.Color.Transparent;
            this.rbSoir.Location = new System.Drawing.Point(136, 78);
            this.rbSoir.Name = "rbSoir";
            this.rbSoir.Size = new System.Drawing.Size(104, 24);
            this.rbSoir.TabIndex = 13;
            this.rbSoir.Text = "Soirée";
            this.rbSoir.UseVisualStyleBackColor = false;
            // 
            // rbSamedi
            // 
            this.rbSamedi.BackColor = System.Drawing.Color.Transparent;
            this.rbSamedi.Location = new System.Drawing.Point(136, 102);
            this.rbSamedi.Name = "rbSamedi";
            this.rbSamedi.Size = new System.Drawing.Size(104, 24);
            this.rbSamedi.TabIndex = 14;
            this.rbSamedi.Text = "Samedi";
            this.rbSamedi.UseVisualStyleBackColor = false;
            // 
            // rbDimanche
            // 
            this.rbDimanche.BackColor = System.Drawing.Color.Transparent;
            this.rbDimanche.Location = new System.Drawing.Point(136, 126);
            this.rbDimanche.Name = "rbDimanche";
            this.rbDimanche.Size = new System.Drawing.Size(104, 24);
            this.rbDimanche.TabIndex = 15;
            this.rbDimanche.Text = "Dimanche";
            this.rbDimanche.UseVisualStyleBackColor = false;
            // 
            // rbAlway
            // 
            this.rbAlway.BackColor = System.Drawing.Color.Transparent;
            this.rbAlway.Checked = true;
            this.rbAlway.Location = new System.Drawing.Point(24, 78);
            this.rbAlway.Name = "rbAlway";
            this.rbAlway.Size = new System.Drawing.Size(104, 24);
            this.rbAlway.TabIndex = 16;
            this.rbAlway.TabStop = true;
            this.rbAlway.Text = "Toujours";
            this.rbAlway.UseVisualStyleBackColor = false;
            // 
            // tpVehicule
            // 
            this.tpVehicule.Controls.Add(this.rbVehiculCyclomoteur);
            this.tpVehicule.Controls.Add(this.rbVehiculMoto);
            this.tpVehicule.Controls.Add(this.rbVehiculAutomatique);
            this.tpVehicule.Controls.Add(this.rbVehiculManuel);
            this.tpVehicule.Location = new System.Drawing.Point(4, 25);
            this.tpVehicule.Name = "tpVehicule";
            this.tpVehicule.Size = new System.Drawing.Size(844, 193);
            this.tpVehicule.TabIndex = 5;
            this.tpVehicule.Tag = "VEHICULE";
            this.tpVehicule.Text = "Type de véhicule";
            // 
            // rbVehiculManuel
            // 
            this.rbVehiculManuel.Checked = true;
            this.rbVehiculManuel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbVehiculManuel.Location = new System.Drawing.Point(68, 34);
            this.rbVehiculManuel.Name = "rbVehiculManuel";
            this.rbVehiculManuel.Size = new System.Drawing.Size(88, 24);
            this.rbVehiculManuel.TabIndex = 22;
            this.rbVehiculManuel.TabStop = true;
            this.rbVehiculManuel.Tag = "General";
            this.rbVehiculManuel.Text = "Manuel";
            // 
            // rbVehiculAutomatique
            // 
            this.rbVehiculAutomatique.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbVehiculAutomatique.Location = new System.Drawing.Point(68, 64);
            this.rbVehiculAutomatique.Name = "rbVehiculAutomatique";
            this.rbVehiculAutomatique.Size = new System.Drawing.Size(88, 24);
            this.rbVehiculAutomatique.TabIndex = 24;
            this.rbVehiculAutomatique.Tag = "General";
            this.rbVehiculAutomatique.Text = "Automatique";
            // 
            // rbVehiculMoto
            // 
            this.rbVehiculMoto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbVehiculMoto.Location = new System.Drawing.Point(68, 124);
            this.rbVehiculMoto.Name = "rbVehiculMoto";
            this.rbVehiculMoto.Size = new System.Drawing.Size(120, 24);
            this.rbVehiculMoto.TabIndex = 25;
            this.rbVehiculMoto.Tag = "Moto";
            this.rbVehiculMoto.Text = "Motocyclette";
            // 
            // rbVehiculCyclomoteur
            // 
            this.rbVehiculCyclomoteur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbVehiculCyclomoteur.Location = new System.Drawing.Point(68, 94);
            this.rbVehiculCyclomoteur.Name = "rbVehiculCyclomoteur";
            this.rbVehiculCyclomoteur.Size = new System.Drawing.Size(106, 24);
            this.rbVehiculCyclomoteur.TabIndex = 23;
            this.rbVehiculCyclomoteur.Tag = "General";
            this.rbVehiculCyclomoteur.Text = "Cyclomoteur";
            // 
            // tpClientInfo
            // 
            this.tpClientInfo.Controls.Add(this.label1);
            this.tpClientInfo.Controls.Add(this.pictureBox1);
            this.tpClientInfo.Controls.Add(this.txtFirstName);
            this.tpClientInfo.Controls.Add(this.txtClientName);
            this.tpClientInfo.Controls.Add(this.rbFirstName);
            this.tpClientInfo.Controls.Add(this.rbName);
            this.tpClientInfo.Location = new System.Drawing.Point(4, 25);
            this.tpClientInfo.Name = "tpClientInfo";
            this.tpClientInfo.Size = new System.Drawing.Size(844, 193);
            this.tpClientInfo.TabIndex = 0;
            this.tpClientInfo.Tag = "CLIENTINFO";
            this.tpClientInfo.Text = "Informations client";
            // 
            // rbName
            // 
            this.rbName.BackColor = System.Drawing.Color.Transparent;
            this.rbName.Checked = true;
            this.rbName.Location = new System.Drawing.Point(248, 24);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(76, 24);
            this.rbName.TabIndex = 0;
            this.rbName.TabStop = true;
            this.rbName.Text = "Prénom";
            this.rbName.UseVisualStyleBackColor = false;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(88, 24);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(144, 20);
            this.txtClientName.TabIndex = 1;
            this.txtClientName.Enter += new System.EventHandler(this.txtClientName_Enter);
            // 
            // rbFirstName
            // 
            this.rbFirstName.BackColor = System.Drawing.Color.Transparent;
            this.rbFirstName.Location = new System.Drawing.Point(24, 24);
            this.rbFirstName.Name = "rbFirstName";
            this.rbFirstName.Size = new System.Drawing.Size(64, 24);
            this.rbFirstName.TabIndex = 2;
            this.rbFirstName.Text = "Nom";
            this.rbFirstName.UseVisualStyleBackColor = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(330, 24);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(144, 20);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.Enter += new System.EventHandler(this.txtFirstName_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(56, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Si vous n’inscriver rien dans aucune des boîtes de texte le programme trouvera to" +
                "us les clients.";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpClientInfo);
            this.tabControl1.Controls.Add(this.tpVehicule);
            this.tabControl1.Controls.Add(this.tpDispo);
            this.tabControl1.Controls.Add(this.tpClientType);
            this.tabControl1.Controls.Add(this.tpDate);
            this.tabControl1.Controls.Add(this.tpMoto);
            this.tabControl1.HotTrack = true;
            this.tabControl1.ItemSize = new System.Drawing.Size(97, 21);
            this.tabControl1.Location = new System.Drawing.Point(8, 60);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(852, 222);
            this.tabControl1.TabIndex = 1;
            // 
            // FormFindClient
            // 
            this.ClientSize = new System.Drawing.Size(868, 510);
            this.Controls.Add(this.lblTotalFind);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.clientControl1);
            this.Controls.Add(this.listFindResult);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormFindClient";
            this.Text = "FormFindClient";
            this.Load += new System.EventHandler(this.FormFindClient_Load);
            this.tpMoto.ResumeLayout(false);
            this.tpMoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tpDate.ResumeLayout(false);
            this.tpClientType.ResumeLayout(false);
            this.tpDispo.ResumeLayout(false);
            this.tpVehicule.ResumeLayout(false);
            this.tpClientInfo.ResumeLayout(false);
            this.tpClientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
		
		private void FindClient() {
			listFindResult.Items.Clear();

			Cursor.Current = Cursors.WaitCursor;
			SortByDate();

			switch (tabControl1.SelectedTab.Tag.ToString()) {
				case "DISPO":
					FindDispo();
					break;
				case "INSCRIPTIONDATE":
					FindDate();
					break;
				case "CLIENTINFO":
					FindClientInfo();
					break;
				case "CLIENTTYPE":
					FindTypeClient();
					break;
				case "VEHICULE":
					FindVehicule();
					break;
 				case "MOTO":
					SortByDernierPaiment();
					FindMotoZeroSolde();
					break;                    
			}

            lblTotalFind.Text = listFindResult.Items.Count + " Résultats trouvé dans votre recherche";

			Cursor.Current = Cursors.Default;
		}

		#region Methodes
		/// <summary>
		/// Trie par date
		/// </summary>
		private void SortByDate(){
			this.listFindResult.ListViewItemSorter = new ListViewItemComparer(2);
			
			listFindResult.Sort();
		}

		/// <summary>
		/// Trie par date
		/// </summary>
		private void SortByDernierPaiment() {
			this.listFindResult.ListViewItemSorter = new ListViewItemComparer(6);

			listFindResult.Sort();
		}

		private void FindMotoZeroSolde() {
			CustomerCollection ClientList = this._FormMain.ClientList;
			DateTime dernierPaiment;

			//Parcourt les éléments de la liste des clients
			for (int i = 0; i < ClientList.Count; i++) {
				//Recherche les clients avec le solde à 0 $
				if (double.Parse(ClientList[i].Solde.Replace(" $", "")) == 0 &&
					ClientList[i].TypeVehicule == VehiculeType.Moto) {
					if (ClientList[i].Paiment.Count > 0) {
						dernierPaiment = ClientList[i].Paiment[ClientList[i].Paiment.Count - 1].DatePaiment;
						if (dernierPaiment.Date > dtpDateDebutMoto.Value.Date &&
							dernierPaiment.Date < dtpDateFinMoto.Value.Date)
							AddClientToList(ClientList[i]);
					}
				}
			}
		}

        /// <summary>
        /// Recherche par disponibiliter
        /// </summary>
        private void FindDispo() {
            var dispoMatin = from V in this._FormMain.ClientList.Cast<Customer>()
                             where V.DisponibilityAM == true
                             select V;

            var dispoMidi = from V in this._FormMain.ClientList.Cast<Customer>()
                            where V.DisponibilityPM == true
                            select V;

            var dispoSoir = from V in this._FormMain.ClientList.Cast<Customer>()
                            where V.DisponibilitySoirer == true
                            select V;

            var dispoSamedi = from V in this._FormMain.ClientList.Cast<Customer>()
                              where V.DisponibilitySamedi == true
                              select V;

            var dispoDimanche = from V in this._FormMain.ClientList.Cast<Customer>()
                                where V.DisponibilityDimanche == true
                                select V;

            var dispoAlway = from V in this._FormMain.ClientList.Cast<Customer>()
                             where V.DisponibilityAlway == true
                             select V;

            //Remplir la liste
            if (rbAlway.Checked)
                foreach (Customer client in dispoAlway)
                    AddClientToList(client);

            if (rbApresMidi.Checked)
                foreach (Customer client in dispoMidi)
                    AddClientToList(client);

            if (rbDimanche.Checked)
                foreach (Customer client in dispoDimanche)
                    AddClientToList(client);

            if (rbSamedi.Checked)
                foreach (Customer client in dispoSamedi)
                    AddClientToList(client);

            if (rbMatin.Checked)
                foreach (Customer client in dispoMatin)
                    AddClientToList(client);

            if (rbSoir.Checked)
                foreach (Customer client in dispoSoir)
                    AddClientToList(client);
        }

        /// <summary>
        /// Recherche par type de vehicule
        /// </summary>
        private void FindVehicule() {
            var Automatique = from V in this._FormMain.ClientList.Cast<Customer>()
                              where V.TypeVehicule == VehiculeType.Automatique
                              select V;

            var Manuel = from V in this._FormMain.ClientList.Cast<Customer>()
                         where V.TypeVehicule == VehiculeType.Manuel
                         select V;

            var Moto = from V in this._FormMain.ClientList.Cast<Customer>()
                       where V.TypeVehicule == VehiculeType.Moto
                       select V;

            var Cyclomoteur = from V in this._FormMain.ClientList.Cast<Customer>()
                              where V.TypeVehicule == VehiculeType.Cyclomoteur
                              select V;

            
            //Ajouter a la liste de recherche
            if (rbVehiculAutomatique.Checked)
                foreach (Customer client in Automatique)
                    AddClientToList(client);

            if (rbVehiculManuel.Checked)
                foreach (Customer client in Manuel)
                    AddClientToList(client);

            if (rbVehiculMoto.Checked)
                foreach (Customer client in Moto)
                    AddClientToList(client);

            if (rbVehiculCyclomoteur.Checked)
                foreach (Customer client in Cyclomoteur)
                    AddClientToList(client);
        }


		/// <summary>
		/// Recherche par type de client
		/// </summary>
		private void FindTypeClient(){
			CustomerCollection ClientList = this._FormMain.ClientList;

			for(int i=0; i<ClientList.Count; i++){ 
                //if (rbTypeClientAbsence.Checked == true)
                //    if (ClientList[i].TypeClient  == ProfileType.Absence)
                //        AddClientToList(ClientList[i]);

				if (rbTypeClientActif.Checked == true)
					if (ClientList[i].TypeClient  == ProfileType.Actif)
						AddClientToList(ClientList[i]);

				if (rbTypeClientFinish.Checked == true)
					if (ClientList[i].TypeClient  == ProfileType.CoursTerminer)
						AddClientToList(ClientList[i]);

                //if (rbTypeClientSoldSouffrance.Checked == true)
                //    if (ClientList[i].TypeClient  == ProfileType.SoldSouffrance)
                //        AddClientToList(ClientList[i]);

                //if (rbTypeClientTheorie.Checked == true)
                //    if (ClientList[i].TypeClient  == ProfileType.Theorie)
                //        AddClientToList(ClientList[i]);
			}
		}

		/// <summary>
		/// Recherche par date inscription
		/// </summary>
		private void FindDate(){
			CustomerCollection ClientList = this._FormMain.ClientList;

			for(int i=0; i<ClientList.Count; i++){ 
				switch(cbChoice.SelectedIndex){
					case 0: // ==
						if (ClientList[i].DateInscription.Date == monthCalendar2.SelectionStart.Date)
							AddClientToList(ClientList[i]);
						break;
					case 1: // >
						if (ClientList[i].DateInscription.Date > monthCalendar2.SelectionStart.Date)
							AddClientToList(ClientList[i]);
						break;
					case 2: // <
						if (ClientList[i].DateInscription.Date < monthCalendar2.SelectionStart.Date)
							AddClientToList(ClientList[i]);
						break;
					case 3: // >=
						if (ClientList[i].DateInscription.Date >= monthCalendar2.SelectionStart.Date)
							AddClientToList(ClientList[i]);
						break;
					case 4: // <=
						if (ClientList[i].DateInscription.Date <= monthCalendar2.SelectionStart.Date)
							AddClientToList(ClientList[i]);
						break;

				}
			}
		}
        		
		/// <summary>
		/// Recherche par des information sur les clients
		/// </summary>
		private void FindClientInfo(){
			CustomerCollection ClientList = this._FormMain.ClientList;

			//Vide la liste des resultats
			listFindResult.Items.Clear();

			//Recherche
			for(int i=0; i<ClientList.Count; i++){ 
				if (rbFirstName.Checked == true){
					//Recherche la chaine dans le nom
					if (ClientList[i].Name.ToLower().IndexOf(txtClientName.Text.ToLower()) > -1)
						AddClientToList(ClientList[i]);
				}
				else{
					//Recherche la chaine dans le nom
					if (ClientList[i].FirstName.ToLower().IndexOf(txtFirstName.Text.ToLower()) > -1)
						AddClientToList(ClientList[i]);
				}
			}
		}

		/// <summary>
		/// Ajoute un client a la liste
		/// (Finir cette fonction)
		/// </summary>
		/// <param name="client"></param>
		private void AddClientToList(Customer client){
			ListViewItem itm = new ListViewItem();

			itm.Text = client.ContratNumber;
			itm.SubItems.Add(client.FirstName + " " + client.Name);
			itm.SubItems.Add(client.DateInscription.ToShortDateString());
			itm.SubItems.Add(client.Phone);
			itm.SubItems.Add(client.TypeVehicule.ToString());
			itm.SubItems.Add(client.Solde);

            //Icon
			switch (client.TypeVehicule) {
				case VehiculeType.Automatique:
					itm.ImageKey = "Auto";
					break;
				case VehiculeType.Cyclomoteur:
					itm.ImageKey = "Moto";
					break;
				case VehiculeType.Manuel:
					itm.ImageKey = "Auto";
					break;
				case VehiculeType.Moto:
					itm.ImageKey = "Moto";
					break;
			}

			if (client.Paiment.Count > 0)
				itm.SubItems.Add(client.Paiment[client.Paiment.Count - 1].DatePaiment.ToShortDateString());
			else
				itm.SubItems.Add("");

			listFindResult.Items.Add(itm);
		}

		#endregion

		#region Impression
		//Variable global privé pour l'impression sur plusieurs pages
		//c<est variable doivent etre obligatoirement global ou dans une classe statique...

		private int _TotalPage = 0;
		private int _TotalPagePrinted = 1;
		private int _TotalLine = 0;
		private int _LinesPerPage = 0;
		private int _LinePrinted = -1;
		private bool _HeaderPrinted = false;

		/// <summary>
		/// Imprimer la liste de resultats
		/// </summary>
		private void PrintFindList() {
			//assigne les variables par default
			_TotalPage = 0;
			_TotalPagePrinted = 1;
			_TotalLine = 0;
			_HeaderPrinted = false;
			_LinesPerPage = 0;
			_LinePrinted = -1;

#if DEBUG
			PrintPreviewDialog prev = new PrintPreviewDialog();
			prev.Document = PrintRelever;
			prev.ShowDialog(this);

#else
			//Lance l'impression
			PrintDialog printConfig = new PrintDialog();			
			printConfig.PrinterSettings = PrintRelever.PrinterSettings; 

			if(printConfig.ShowDialog(this) == DialogResult.OK)
				PrintRelever.Print();
#endif
		}

		private void PrintRelever_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
			float topMargin = 30;
			float leftMargin = 0;//e.MarginBounds.Left;

			//Defini le style de l'alignement
			StringFormat style = new StringFormat();
			style.Alignment = StringAlignment.Near;

			//Facrication de la font
			Font printFont = new Font("Times New Roman", 12, FontStyle.Regular);
			Font printFontBold = new Font("Times New Roman", 12, FontStyle.Bold);
			Font printFontBold16 = new Font("Times New Roman", 16, FontStyle.Bold);

			float yPos = 0f;

			#region Header
			if (_HeaderPrinted == false) {
				//Initialisation des variables dans le bloc header pour q'il ne le
				//face qu'a la premiere page
				_TotalLine = listFindResult.Items.Count;
				_LinesPerPage = Convert.ToInt16((e.MarginBounds.Height - 40) / printFont.GetHeight(e.Graphics));
				_TotalPage = Convert.ToInt16(Decimal.Round(Convert.ToDecimal(_TotalLine) / Convert.ToDecimal(_LinesPerPage), 0));
				if (_TotalPage == 0) _TotalPage = 1;

				//Date(s) d'impression : Choisi le bon type de Header a écrire
				yPos = topMargin + 5;
				e.Graphics.DrawString("Date Impresion : " + DateTime.Now.Date.ToLongDateString(), printFontBold16, Brushes.Black, leftMargin, yPos, new StringFormat());
				_HeaderPrinted = true; //Header Imprimé
			}
			#endregion

			//Entete des colones
			yPos += 50;
			e.Graphics.DrawString("Nom du client", printFontBold, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
			e.Graphics.DrawString("# Contrat", printFontBold, Brushes.Black, leftMargin + 275, yPos, new StringFormat());
			e.Graphics.DrawString("Téléphone", printFontBold, Brushes.Black, leftMargin + 375, yPos, new StringFormat());
			e.Graphics.DrawString("Date Insc.", printFontBold, Brushes.Black, leftMargin + 500, yPos, new StringFormat());
			e.Graphics.DrawString("Dern. Paiment", printFontBold, Brushes.Black, leftMargin + 625, yPos, new StringFormat());
			e.Graphics.DrawString("Solde", printFontBold, Brushes.Black, leftMargin + 750, yPos, new StringFormat());			

			//Creation de l'objet client
			Customer client = null;

			yPos += 20;
			//Impression de toute les lignes du tableau
			while (_LinePrinted < listFindResult.Items.Count - 1) {
				_LinePrinted++;

				client = this._FormMain.ClientList.GetClient(listFindResult.Items[_LinePrinted].Text);

				if (client != null) {

					//Montant des locations
					if (client.MontantLocation == "")
						client.MontantLocation = "0,00 $";

					yPos += printFont.Height;
					e.Graphics.DrawString((_LinePrinted + 1) + " - ", printFont, Brushes.Black, leftMargin + 5, yPos, new StringFormat());
					e.Graphics.DrawString(client.FirstName + " " + client.Name, printFont, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
					e.Graphics.DrawString(listFindResult.Items[_LinePrinted].Text, printFont, Brushes.Black, leftMargin + 300, yPos, new StringFormat());
					e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[3].Text, printFont, Brushes.Black, leftMargin + 375, yPos, new StringFormat());
					e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[2].Text, printFont, Brushes.Black, leftMargin + 500, yPos, new StringFormat());
					e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[6].Text, printFont, Brushes.Black, leftMargin + 625, yPos, new StringFormat());
					e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[5].Text, printFont, Brushes.Black, leftMargin + 750, yPos, new StringFormat());

					#region Creation d'une nouvelle page et numéro de page
					string PageNumber = "Page : " + _TotalPagePrinted.ToString() + "/" + _TotalPage.ToString();
					if (yPos >= e.MarginBounds.Height + 50) {
						//Numéro de page
						e.Graphics.DrawString(PageNumber,
							printFontBold,
							Brushes.Black,
							e.MarginBounds.Right - e.Graphics.MeasureString(PageNumber, printFontBold).Width,
							e.MarginBounds.Bottom,
							new StringFormat());

						_TotalPagePrinted++;
						e.HasMorePages = true; // Imprimer une nouvelle page ... sorte de boucle qui me fait mettre des maudite variable global grr lol
						return;
					} else {
						//Numéro de page
						e.Graphics.DrawString(PageNumber,
							printFontBold,
							Brushes.Black,
							e.MarginBounds.Right - e.Graphics.MeasureString(PageNumber, printFontBold).Width,
							e.MarginBounds.Bottom,
							new StringFormat());
					}
					#endregion
				}
			}


		}
		#endregion

		private void FormFindClient_Load(object sender, System.EventArgs e) {
			cbChoice.SelectedIndex = 0;
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e) {
			switch(e.Button.Tag.ToString()){
				case "PRINT":
					clientControl1.PrintDoc(Barette.Library.UserControls.Client.PrintDocumentType.InfoClient);
					break;
				case "OPENSEANCE":
					clientControl1.ShowCours();
					break;
				case "SHOWCLIENT":
					this._FormMain.CreationListClient(listFindResult.SelectedItems[0].Text);
					break;
				case "PRINTFINDLIST":
					PrintFindList();
					break;
				case "REFRESH":
					FindClient();
					break;
				case "PAIMENT":
					clientControl1.ShowPaiement();
					break;
			}
		}

		private void listFindResult_Click(object sender, System.EventArgs e) {

		}

		private void timer1_Tick(object sender, System.EventArgs e) {
			if (listFindResult.SelectedItems.Count == 0) {
				tbbShowClient.Enabled = false;
				tbbShowPaiment.Enabled = false;
				toolBarButton5.Enabled = false;
				toolBarButton2.Enabled = false;

			} else {
				tbbShowClient.Enabled = true;
				toolBarButton5.Enabled = true;
				toolBarButton2.Enabled = true;
				tbbShowPaiment.Enabled = true;
			}

			tbbPrintFindList.Enabled = (listFindResult.Items.Count > 0);
		}

		private void txtFirstName_Enter(object sender, System.EventArgs e) {
			rbName.Checked = true;
		}

		private void txtClientName_Enter(object sender, System.EventArgs e) {
			rbFirstName.Checked = true;
		}

		private void listFindResult_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e) {
			
			this.listFindResult.ListViewItemSorter = new ListViewItemComparer(e.Column);	
			
			listFindResult.Sort();
		}

        private void listFindResult_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                Customer client = this._FormMain.ClientList.GetClient(listFindResult.SelectedItems[0].Text);

                if (client != null)
                    clientControl1.Client = this._FormMain.ClientList.GetClient(listFindResult.SelectedItems[0].Text);
            }
            catch { }
        }
	}
}

