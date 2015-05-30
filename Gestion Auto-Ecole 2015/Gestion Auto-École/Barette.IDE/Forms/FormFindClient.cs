using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO; 
using System.Diagnostics;
using System.Linq;

using Barette.Library.Win32;
using Barette.Library.Client;
using Barette.Library.Collections;
using Barette.Library.Listview;


namespace Barette.IDE.Forms {
	/// <summary>
	/// Description résumée de FormFindClient.
	/// </summary>
	public class FormFindClient : Form
    {
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

            _FormMain = main;

            //Control client
            _ListEmploye = ListEmploye;
            clientControl1.ListeEmploye = ListEmploye;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFindClient));
            Barette.Library.Client.Customer customer2 = new Barette.Library.Client.Customer();
            listFindResult = new System.Windows.Forms.ListView();
            colheadContratNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colheadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colheadDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colHeadPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colHeadTypeVehicule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colHeadSolde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colHeadDernierPaiment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ImageListSmall = new System.Windows.Forms.ImageList(components);
            chkDisponibilityPM = new System.Windows.Forms.CheckBox();
            chkDisponibilityAM = new System.Windows.Forms.CheckBox();
            imageList1 = new System.Windows.Forms.ImageList(components);
            toolBar1 = new System.Windows.Forms.ToolBar();
            tbbRefresh = new System.Windows.Forms.ToolBarButton();
            toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            tbbShowClient = new System.Windows.Forms.ToolBarButton();
            tbbShowPaiment = new System.Windows.Forms.ToolBarButton();
            toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            tbbSeparator1 = new System.Windows.Forms.ToolBarButton();
            toolBarButton5 = new System.Windows.Forms.ToolBarButton();
            tbbPrintFindList = new System.Windows.Forms.ToolBarButton();
            timer1 = new System.Windows.Forms.Timer(components);
            PrintRelever = new System.Drawing.Printing.PrintDocument();
            clientControl1 = new Barette.Library.UserControls.Client.ClientControl();
            lblTotalFind = new System.Windows.Forms.Label();
            tpMoto = new System.Windows.Forms.TabPage();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            dtpDateFinMoto = new System.Windows.Forms.DateTimePicker();
            dtpDateDebutMoto = new System.Windows.Forms.DateTimePicker();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            tpDate = new System.Windows.Forms.TabPage();
            monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            cbChoice = new System.Windows.Forms.ComboBox();
            tpClientType = new System.Windows.Forms.TabPage();
            rbTypeClientActif = new System.Windows.Forms.RadioButton();
            rbTypeClientFinish = new System.Windows.Forms.RadioButton();
            tpDispo = new System.Windows.Forms.TabPage();
            rbMatin = new System.Windows.Forms.RadioButton();
            rbApresMidi = new System.Windows.Forms.RadioButton();
            rbSoir = new System.Windows.Forms.RadioButton();
            rbSamedi = new System.Windows.Forms.RadioButton();
            rbDimanche = new System.Windows.Forms.RadioButton();
            rbAlway = new System.Windows.Forms.RadioButton();
            tpVehicule = new System.Windows.Forms.TabPage();
            rbVehiculManuel = new System.Windows.Forms.RadioButton();
            rbVehiculAutomatique = new System.Windows.Forms.RadioButton();
            rbVehiculMoto = new System.Windows.Forms.RadioButton();
            rbVehiculCyclomoteur = new System.Windows.Forms.RadioButton();
            tpClientInfo = new System.Windows.Forms.TabPage();
            rbName = new System.Windows.Forms.RadioButton();
            txtClientName = new System.Windows.Forms.TextBox();
            rbFirstName = new System.Windows.Forms.RadioButton();
            txtFirstName = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            tpMoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).BeginInit();
            tpDate.SuspendLayout();
            tpClientType.SuspendLayout();
            tpDispo.SuspendLayout();
            tpVehicule.SuspendLayout();
            tpClientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // listFindResult
            // 
            listFindResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            listFindResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            colheadContratNumber,
            colheadName,
            colheadDate,
            colHeadPhone,
            colHeadTypeVehicule,
            colHeadSolde,
            colHeadDernierPaiment});
            listFindResult.FullRowSelect = true;
            listFindResult.Location = new System.Drawing.Point(8, 306);
            listFindResult.MultiSelect = false;
            listFindResult.Name = "listFindResult";
            listFindResult.Size = new System.Drawing.Size(852, 200);
            listFindResult.SmallImageList = ImageListSmall;
            listFindResult.TabIndex = 0;
            listFindResult.UseCompatibleStateImageBehavior = false;
            listFindResult.View = System.Windows.Forms.View.Details;
            listFindResult.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(listFindResult_ColumnClick);
            listFindResult.SelectedIndexChanged += new System.EventHandler(listFindResult_SelectedIndexChanged);
            listFindResult.Click += new System.EventHandler(listFindResult_Click);
            // 
            // colheadContratNumber
            // 
            colheadContratNumber.Text = "# Contrat";
            colheadContratNumber.Width = 66;
            // 
            // colheadName
            // 
            colheadName.Text = "Nom du client";
            colheadName.Width = 183;
            // 
            // colheadDate
            // 
            colheadDate.Text = "Date d\'inscription";
            colheadDate.Width = 118;
            // 
            // colHeadPhone
            // 
            colHeadPhone.Text = "Téléphone";
            colHeadPhone.Width = 102;
            // 
            // colHeadTypeVehicule
            // 
            colHeadTypeVehicule.Text = "Type de cours";
            colHeadTypeVehicule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            colHeadTypeVehicule.Width = 99;
            // 
            // colHeadSolde
            // 
            colHeadSolde.Text = "Solde";
            colHeadSolde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            colHeadSolde.Width = 64;
            // 
            // colHeadDernierPaiment
            // 
            colHeadDernierPaiment.Text = "Dernier Paiment";
            colHeadDernierPaiment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            colHeadDernierPaiment.Width = 97;
            // 
            // ImageListSmall
            // 
            ImageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListSmall.ImageStream")));
            ImageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            ImageListSmall.Images.SetKeyName(0, "Moto");
            ImageListSmall.Images.SetKeyName(1, "Auto");
            ImageListSmall.Images.SetKeyName(2, "Camion");
            // 
            // chkDisponibilityPM
            // 
            chkDisponibilityPM.Location = new System.Drawing.Point(0, 0);
            chkDisponibilityPM.Name = "chkDisponibilityPM";
            chkDisponibilityPM.Size = new System.Drawing.Size(104, 24);
            chkDisponibilityPM.TabIndex = 0;
            // 
            // chkDisponibilityAM
            // 
            chkDisponibilityAM.Location = new System.Drawing.Point(0, 0);
            chkDisponibilityAM.Name = "chkDisponibilityAM";
            chkDisponibilityAM.Size = new System.Drawing.Size(104, 24);
            chkDisponibilityAM.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "");
            imageList1.Images.SetKeyName(1, "");
            imageList1.Images.SetKeyName(2, "");
            imageList1.Images.SetKeyName(3, "user-group-icon.png");
            imageList1.Images.SetKeyName(4, "Recyclebin_empty");
            imageList1.Images.SetKeyName(5, "coins-icon.png");
            // 
            // toolBar1
            // 
            toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            toolBar1.AutoSize = false;
            toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            tbbRefresh,
            toolBarButton1,
            tbbShowClient,
            tbbShowPaiment,
            toolBarButton2,
            tbbSeparator1,
            toolBarButton5,
            tbbPrintFindList});
            toolBar1.Divider = false;
            toolBar1.Dock = System.Windows.Forms.DockStyle.None;
            toolBar1.DropDownArrows = true;
            toolBar1.ImageList = imageList1;
            toolBar1.Location = new System.Drawing.Point(8, 12);
            toolBar1.Name = "toolBar1";
            toolBar1.ShowToolTips = true;
            toolBar1.Size = new System.Drawing.Size(478, 42);
            toolBar1.TabIndex = 13;
            toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(toolBar1_ButtonClick);
            // 
            // tbbRefresh
            // 
            tbbRefresh.ImageKey = "Recyclebin_empty";
            tbbRefresh.Name = "tbbRefresh";
            tbbRefresh.Tag = "REFRESH";
            // 
            // toolBarButton1
            // 
            toolBarButton1.Name = "toolBarButton1";
            toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbShowClient
            // 
            tbbShowClient.ImageIndex = 3;
            tbbShowClient.Name = "tbbShowClient";
            tbbShowClient.Tag = "SHOWCLIENT";
            tbbShowClient.ToolTipText = "Affiche le client";
            // 
            // tbbShowPaiment
            // 
            tbbShowPaiment.ImageIndex = 5;
            tbbShowPaiment.Name = "tbbShowPaiment";
            tbbShowPaiment.Tag = "PAIMENT";
            // 
            // toolBarButton2
            // 
            toolBarButton2.ImageIndex = 1;
            toolBarButton2.Name = "toolBarButton2";
            toolBarButton2.Tag = "OPENSEANCE";
            toolBarButton2.ToolTipText = "Affiche la boîte de séances de cours";
            // 
            // tbbSeparator1
            // 
            tbbSeparator1.Name = "tbbSeparator1";
            tbbSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButton5
            // 
            toolBarButton5.ImageIndex = 0;
            toolBarButton5.Name = "toolBarButton5";
            toolBarButton5.Tag = "PRINT";
            toolBarButton5.Text = "Infos Client";
            // 
            // tbbPrintFindList
            // 
            tbbPrintFindList.ImageIndex = 0;
            tbbPrintFindList.Name = "tbbPrintFindList";
            tbbPrintFindList.Tag = "PRINTFINDLIST";
            tbbPrintFindList.Text = "Liste de recherche";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 200;
            timer1.Tick += new System.EventHandler(timer1_Tick);
            // 
            // PrintRelever
            // 
            PrintRelever.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintRelever_PrintPage);
            // 
            // clientControl1
            // 
            clientControl1.AutoUpdate = false;
            clientControl1.BackColor = System.Drawing.SystemColors.Control;
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
            clientControl1.Client = customer2;
            clientControl1.Location = new System.Drawing.Point(657, 344);
            clientControl1.Name = "clientControl1";
            clientControl1.School = null;
            clientControl1.Size = new System.Drawing.Size(160, 160);
            clientControl1.TabIndex = 14;
            clientControl1.Visible = false;
            // 
            // lblTotalFind
            // 
            lblTotalFind.AutoSize = true;
            lblTotalFind.Location = new System.Drawing.Point(9, 285);
            lblTotalFind.Name = "lblTotalFind";
            lblTotalFind.Size = new System.Drawing.Size(197, 13);
            lblTotalFind.TabIndex = 15;
            lblTotalFind.Text = "0 Résultats trouvé dans votre recherche";
            // 
            // tpMoto
            // 
            tpMoto.Controls.Add(label6);
            tpMoto.Controls.Add(label5);
            tpMoto.Controls.Add(dtpDateDebutMoto);
            tpMoto.Controls.Add(dtpDateFinMoto);
            tpMoto.Controls.Add(label4);
            tpMoto.Controls.Add(pictureBox3);
            tpMoto.Location = new System.Drawing.Point(4, 25);
            tpMoto.Name = "tpMoto";
            tpMoto.Padding = new System.Windows.Forms.Padding(3);
            tpMoto.Size = new System.Drawing.Size(844, 193);
            tpMoto.TabIndex = 8;
            tpMoto.Tag = "MOTO";
            tpMoto.Text = "Moto";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            pictureBox3.BackColor = System.Drawing.Color.Transparent;
            pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            pictureBox3.Location = new System.Drawing.Point(548, 16);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(32, 32);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Location = new System.Drawing.Point(587, 16);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(248, 48);
            label4.TabIndex = 7;
            label4.Text = "Recherche tous les clients de moto qui ont payé leurs cours complètement. Cette r" +
                "echerche est trié par la colonne : Dernier Paiment.";
            // 
            // dtpDateFinMoto
            // 
            dtpDateFinMoto.Location = new System.Drawing.Point(297, 70);
            dtpDateFinMoto.Name = "dtpDateFinMoto";
            dtpDateFinMoto.Size = new System.Drawing.Size(138, 20);
            dtpDateFinMoto.TabIndex = 8;
            // 
            // dtpDateDebutMoto
            // 
            dtpDateDebutMoto.Location = new System.Drawing.Point(66, 70);
            dtpDateDebutMoto.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            dtpDateDebutMoto.Name = "dtpDateDebutMoto";
            dtpDateDebutMoto.Size = new System.Drawing.Size(138, 20);
            dtpDateDebutMoto.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Location = new System.Drawing.Point(66, 54);
            label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(75, 13);
            label5.TabIndex = 10;
            label5.Text = "Date de début";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Location = new System.Drawing.Point(297, 52);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(59, 13);
            label6.TabIndex = 11;
            label6.Text = "Date de fin";
            // 
            // tpDate
            // 
            tpDate.Controls.Add(cbChoice);
            tpDate.Controls.Add(monthCalendar2);
            tpDate.Location = new System.Drawing.Point(4, 25);
            tpDate.Name = "tpDate";
            tpDate.Size = new System.Drawing.Size(844, 193);
            tpDate.TabIndex = 4;
            tpDate.Tag = "INSCRIPTIONDATE";
            tpDate.Text = "Date Inscription";
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new System.Drawing.Point(244, 18);
            monthCalendar2.MaxSelectionCount = 1;
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 1;
            // 
            // cbChoice
            // 
            cbChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbChoice.FormattingEnabled = true;
            cbChoice.Items.AddRange(new object[] {
            "Égal ( = )",
            "Plus grand que ( > )",
            "Plus petit que ( < )",
            "Plus grand ou égal à ( >= )",
            "Plus petit ou égal à ( <= )"});
            cbChoice.Location = new System.Drawing.Point(12, 85);
            cbChoice.Name = "cbChoice";
            cbChoice.Size = new System.Drawing.Size(224, 21);
            cbChoice.TabIndex = 2;
            // 
            // tpClientType
            // 
            tpClientType.Controls.Add(rbTypeClientFinish);
            tpClientType.Controls.Add(rbTypeClientActif);
            tpClientType.Location = new System.Drawing.Point(4, 25);
            tpClientType.Name = "tpClientType";
            tpClientType.Size = new System.Drawing.Size(844, 193);
            tpClientType.TabIndex = 3;
            tpClientType.Tag = "CLIENTTYPE";
            tpClientType.Text = "Type de client";
            // 
            // rbTypeClientActif
            // 
            rbTypeClientActif.Checked = true;
            rbTypeClientActif.FlatStyle = System.Windows.Forms.FlatStyle.System;
            rbTypeClientActif.Location = new System.Drawing.Point(32, 40);
            rbTypeClientActif.Name = "rbTypeClientActif";
            rbTypeClientActif.Size = new System.Drawing.Size(104, 24);
            rbTypeClientActif.TabIndex = 6;
            rbTypeClientActif.TabStop = true;
            rbTypeClientActif.Text = "Actif";
            // 
            // rbTypeClientFinish
            // 
            rbTypeClientFinish.FlatStyle = System.Windows.Forms.FlatStyle.System;
            rbTypeClientFinish.Location = new System.Drawing.Point(32, 82);
            rbTypeClientFinish.Name = "rbTypeClientFinish";
            rbTypeClientFinish.Size = new System.Drawing.Size(104, 24);
            rbTypeClientFinish.TabIndex = 8;
            rbTypeClientFinish.Text = "Cours terminé";
            // 
            // tpDispo
            // 
            tpDispo.BackColor = System.Drawing.Color.Transparent;
            tpDispo.Controls.Add(rbAlway);
            tpDispo.Controls.Add(rbDimanche);
            tpDispo.Controls.Add(rbSamedi);
            tpDispo.Controls.Add(rbSoir);
            tpDispo.Controls.Add(rbApresMidi);
            tpDispo.Controls.Add(rbMatin);
            tpDispo.Location = new System.Drawing.Point(4, 25);
            tpDispo.Name = "tpDispo";
            tpDispo.Size = new System.Drawing.Size(844, 193);
            tpDispo.TabIndex = 2;
            tpDispo.Tag = "DISPO";
            tpDispo.Text = "Disponibilité";
            // 
            // rbMatin
            // 
            rbMatin.BackColor = System.Drawing.Color.Transparent;
            rbMatin.Location = new System.Drawing.Point(136, 30);
            rbMatin.Name = "rbMatin";
            rbMatin.Size = new System.Drawing.Size(104, 24);
            rbMatin.TabIndex = 11;
            rbMatin.Text = "Matin";
            rbMatin.UseVisualStyleBackColor = false;
            // 
            // rbApresMidi
            // 
            rbApresMidi.BackColor = System.Drawing.Color.Transparent;
            rbApresMidi.Location = new System.Drawing.Point(136, 54);
            rbApresMidi.Name = "rbApresMidi";
            rbApresMidi.Size = new System.Drawing.Size(104, 24);
            rbApresMidi.TabIndex = 12;
            rbApresMidi.Text = "Après Midi";
            rbApresMidi.UseVisualStyleBackColor = false;
            // 
            // rbSoir
            // 
            rbSoir.BackColor = System.Drawing.Color.Transparent;
            rbSoir.Location = new System.Drawing.Point(136, 78);
            rbSoir.Name = "rbSoir";
            rbSoir.Size = new System.Drawing.Size(104, 24);
            rbSoir.TabIndex = 13;
            rbSoir.Text = "Soirée";
            rbSoir.UseVisualStyleBackColor = false;
            // 
            // rbSamedi
            // 
            rbSamedi.BackColor = System.Drawing.Color.Transparent;
            rbSamedi.Location = new System.Drawing.Point(136, 102);
            rbSamedi.Name = "rbSamedi";
            rbSamedi.Size = new System.Drawing.Size(104, 24);
            rbSamedi.TabIndex = 14;
            rbSamedi.Text = "Samedi";
            rbSamedi.UseVisualStyleBackColor = false;
            // 
            // rbDimanche
            // 
            rbDimanche.BackColor = System.Drawing.Color.Transparent;
            rbDimanche.Location = new System.Drawing.Point(136, 126);
            rbDimanche.Name = "rbDimanche";
            rbDimanche.Size = new System.Drawing.Size(104, 24);
            rbDimanche.TabIndex = 15;
            rbDimanche.Text = "Dimanche";
            rbDimanche.UseVisualStyleBackColor = false;
            // 
            // rbAlway
            // 
            rbAlway.BackColor = System.Drawing.Color.Transparent;
            rbAlway.Checked = true;
            rbAlway.Location = new System.Drawing.Point(24, 78);
            rbAlway.Name = "rbAlway";
            rbAlway.Size = new System.Drawing.Size(104, 24);
            rbAlway.TabIndex = 16;
            rbAlway.TabStop = true;
            rbAlway.Text = "Toujours";
            rbAlway.UseVisualStyleBackColor = false;
            // 
            // tpVehicule
            // 
            tpVehicule.Controls.Add(rbVehiculCyclomoteur);
            tpVehicule.Controls.Add(rbVehiculMoto);
            tpVehicule.Controls.Add(rbVehiculAutomatique);
            tpVehicule.Controls.Add(rbVehiculManuel);
            tpVehicule.Location = new System.Drawing.Point(4, 25);
            tpVehicule.Name = "tpVehicule";
            tpVehicule.Size = new System.Drawing.Size(844, 193);
            tpVehicule.TabIndex = 5;
            tpVehicule.Tag = "VEHICULE";
            tpVehicule.Text = "Type de véhicule";
            // 
            // rbVehiculManuel
            // 
            rbVehiculManuel.Checked = true;
            rbVehiculManuel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            rbVehiculManuel.Location = new System.Drawing.Point(68, 34);
            rbVehiculManuel.Name = "rbVehiculManuel";
            rbVehiculManuel.Size = new System.Drawing.Size(88, 24);
            rbVehiculManuel.TabIndex = 22;
            rbVehiculManuel.TabStop = true;
            rbVehiculManuel.Tag = "General";
            rbVehiculManuel.Text = "Manuel";
            // 
            // rbVehiculAutomatique
            // 
            rbVehiculAutomatique.FlatStyle = System.Windows.Forms.FlatStyle.System;
            rbVehiculAutomatique.Location = new System.Drawing.Point(68, 64);
            rbVehiculAutomatique.Name = "rbVehiculAutomatique";
            rbVehiculAutomatique.Size = new System.Drawing.Size(88, 24);
            rbVehiculAutomatique.TabIndex = 24;
            rbVehiculAutomatique.Tag = "General";
            rbVehiculAutomatique.Text = "Automatique";
            // 
            // rbVehiculMoto
            // 
            rbVehiculMoto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            rbVehiculMoto.Location = new System.Drawing.Point(68, 124);
            rbVehiculMoto.Name = "rbVehiculMoto";
            rbVehiculMoto.Size = new System.Drawing.Size(120, 24);
            rbVehiculMoto.TabIndex = 25;
            rbVehiculMoto.Tag = "Moto";
            rbVehiculMoto.Text = "Motocyclette";
            // 
            // rbVehiculCyclomoteur
            // 
            rbVehiculCyclomoteur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            rbVehiculCyclomoteur.Location = new System.Drawing.Point(68, 94);
            rbVehiculCyclomoteur.Name = "rbVehiculCyclomoteur";
            rbVehiculCyclomoteur.Size = new System.Drawing.Size(106, 24);
            rbVehiculCyclomoteur.TabIndex = 23;
            rbVehiculCyclomoteur.Tag = "General";
            rbVehiculCyclomoteur.Text = "Cyclomoteur";
            // 
            // tpClientInfo
            // 
            tpClientInfo.Controls.Add(label1);
            tpClientInfo.Controls.Add(pictureBox1);
            tpClientInfo.Controls.Add(txtFirstName);
            tpClientInfo.Controls.Add(txtClientName);
            tpClientInfo.Controls.Add(rbFirstName);
            tpClientInfo.Controls.Add(rbName);
            tpClientInfo.Location = new System.Drawing.Point(4, 25);
            tpClientInfo.Name = "tpClientInfo";
            tpClientInfo.Size = new System.Drawing.Size(844, 193);
            tpClientInfo.TabIndex = 0;
            tpClientInfo.Tag = "CLIENTINFO";
            tpClientInfo.Text = "Informations client";
            // 
            // rbName
            // 
            rbName.BackColor = System.Drawing.Color.Transparent;
            rbName.Checked = true;
            rbName.Location = new System.Drawing.Point(248, 24);
            rbName.Name = "rbName";
            rbName.Size = new System.Drawing.Size(76, 24);
            rbName.TabIndex = 0;
            rbName.TabStop = true;
            rbName.Text = "Prénom";
            rbName.UseVisualStyleBackColor = false;
            // 
            // txtClientName
            // 
            txtClientName.Location = new System.Drawing.Point(88, 24);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new System.Drawing.Size(144, 20);
            txtClientName.TabIndex = 1;
            txtClientName.Enter += new System.EventHandler(txtClientName_Enter);
            // 
            // rbFirstName
            // 
            rbFirstName.BackColor = System.Drawing.Color.Transparent;
            rbFirstName.Location = new System.Drawing.Point(24, 24);
            rbFirstName.Name = "rbFirstName";
            rbFirstName.Size = new System.Drawing.Size(64, 24);
            rbFirstName.TabIndex = 2;
            rbFirstName.Text = "Nom";
            rbFirstName.UseVisualStyleBackColor = false;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new System.Drawing.Point(330, 24);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(144, 20);
            txtFirstName.TabIndex = 3;
            txtFirstName.Enter += new System.EventHandler(txtFirstName_Enter);
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(16, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(32, 32);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(56, 72);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(232, 48);
            label1.TabIndex = 5;
            label1.Text = "Si vous n’inscriver rien dans aucune des boîtes de texte le programme trouvera to" +
                "us les clients.";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            tabControl1.Controls.Add(tpClientInfo);
            tabControl1.Controls.Add(tpVehicule);
            tabControl1.Controls.Add(tpDispo);
            tabControl1.Controls.Add(tpClientType);
            tabControl1.Controls.Add(tpDate);
            tabControl1.Controls.Add(tpMoto);
            tabControl1.HotTrack = true;
            tabControl1.ItemSize = new System.Drawing.Size(97, 21);
            tabControl1.Location = new System.Drawing.Point(8, 60);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(852, 222);
            tabControl1.TabIndex = 1;
            // 
            // FormFindClient
            // 
            ClientSize = new System.Drawing.Size(868, 510);
            Controls.Add(lblTotalFind);
            Controls.Add(toolBar1);
            Controls.Add(clientControl1);
            Controls.Add(listFindResult);
            Controls.Add(tabControl1);
            Name = "FormFindClient";
            Text = "FormFindClient";
            Load += new System.EventHandler(FormFindClient_Load);
            tpMoto.ResumeLayout(false);
            tpMoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).EndInit();
            tpDate.ResumeLayout(false);
            tpClientType.ResumeLayout(false);
            tpDispo.ResumeLayout(false);
            tpVehicule.ResumeLayout(false);
            tpClientInfo.ResumeLayout(false);
            tpClientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

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
            listFindResult.ListViewItemSorter = new ListViewItemComparer(2);
			
			listFindResult.Sort();
		}

		/// <summary>
		/// Trie par date
		/// </summary>
		private void SortByDernierPaiment() {
            listFindResult.ListViewItemSorter = new ListViewItemComparer(6);

			listFindResult.Sort();
		}

		private void FindMotoZeroSolde() {
			CustomerCollection ClientList = _FormMain.ClientList;
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
            var dispoMatin = from V in _FormMain.ClientList.Cast<Customer>()
                             where V.DisponibilityAM == true
                             select V;

            var dispoMidi = from V in _FormMain.ClientList.Cast<Customer>()
                            where V.DisponibilityPM == true
                            select V;

            var dispoSoir = from V in _FormMain.ClientList.Cast<Customer>()
                            where V.DisponibilitySoirer == true
                            select V;

            var dispoSamedi = from V in _FormMain.ClientList.Cast<Customer>()
                              where V.DisponibilitySamedi == true
                              select V;

            var dispoDimanche = from V in _FormMain.ClientList.Cast<Customer>()
                                where V.DisponibilityDimanche == true
                                select V;

            var dispoAlway = from V in _FormMain.ClientList.Cast<Customer>()
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
            var Automatique = from V in _FormMain.ClientList.Cast<Customer>()
                              where V.TypeVehicule == VehiculeType.Automatique
                              select V;

            var Manuel = from V in _FormMain.ClientList.Cast<Customer>()
                         where V.TypeVehicule == VehiculeType.Manuel
                         select V;

            var Moto = from V in _FormMain.ClientList.Cast<Customer>()
                       where V.TypeVehicule == VehiculeType.Moto
                       select V;

            var Cyclomoteur = from V in _FormMain.ClientList.Cast<Customer>()
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
			CustomerCollection ClientList = _FormMain.ClientList;

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
			CustomerCollection ClientList = _FormMain.ClientList;

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
			CustomerCollection ClientList = _FormMain.ClientList;

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

				client = _FormMain.ClientList.GetClient(listFindResult.Items[_LinePrinted].Text);

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
                    _FormMain.CreationListClient(listFindResult.SelectedItems[0].Text);
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

            listFindResult.ListViewItemSorter = new ListViewItemComparer(e.Column);	
			
			listFindResult.Sort();
		}

        private void listFindResult_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                Customer client = _FormMain.ClientList.GetClient(listFindResult.SelectedItems[0].Text);

                if (client != null)
                    clientControl1.Client = _FormMain.ClientList.GetClient(listFindResult.SelectedItems[0].Text);
            }
            catch { }
        }
	}
}

