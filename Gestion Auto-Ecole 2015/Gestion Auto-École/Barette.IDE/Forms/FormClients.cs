using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;

using Barette.Library;
using Barette.Library.Win32;
using Barette.Library.Client;
using Barette.Library.Listview;
using Barette.Library.Collections;

namespace Barette.IDE.Forms {
    /// <summary>
    /// Description résumée de FormClients.
    /// </summary>
    public class FormClients : Form
    {
        private System.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer AutoUpdateTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolBarButton tbbRefresh;
        private System.Windows.Forms.ToolBarButton tbbSeparator;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolBarButton tbbCheckDoublons;
        private System.Windows.Forms.ToolBarButton tbbSeparator2;
        private ImageList ImageListSmall;
        private SplitContainer splitContainer1;
        private ListViewEx lvClient;
        private ColumnHeader colhClientName;
        private ColumnHeader colhClientNumber;
        private Barette.Library.UserControls.ACComboBox lstNumeroClient;
        public Barette.Library.UserControls.Client.ClientControl clientControl1;
        private System.ComponentModel.IContainer components;
        private ContextMenu cmPrintChoice;
        private MenuItem mnuClientInfo;
        private MenuItem menuItem4;
        private MenuItem mnuClientContrat;
        private EmployeCollection _ListEmploye;
        private ColumnHeader colhClientNoGroup;
        private ToolTip toolTip1;
        private ToolBarButton tbbSeparator3;
        private ToolBarButton tbbAddClient;
        private ToolBarButton tbbDeleteClient;
        private ToolBarButton tbbPrint;
        private ToolBarButton tbbFindCustomer;
        private ContextMenuStrip cmStripClientList;
        private ToolStripMenuItem imprimerToolStripMenuItem;
        private ToolStripMenuItem informationSurLeClientToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem contratToolStripMenuItem;
        private ToolStripMenuItem rafraichirToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem supprimerLeClientToolStripMenuItem;
        
        private SchoolInfo _InfoSchool;
        private Config _AppConfig;
        private MenuItem mnuClientPaimentList;
        private MenuItem menuItem2;
        private MenuItem mnuClientAttestation;
        private CustomerCollection _ClientList;

        public FormClients(CustomerCollection ClientList, EmployeCollection ListEmploye, SchoolInfo info, Config AppConfig) {
            //
            // Requis pour la prise en charge du Concepteur Windows Forms
            //
            InitializeComponent();

            StaticBorder.ThinBorder(lvClient.Handle.ToInt32(), true);
            _InfoSchool = info;
            _AppConfig = AppConfig;
            _ClientList = ClientList;

            //Liste d'employe
            _ListEmploye = ListEmploye;
            clientControl1.ListeEmploye = _ListEmploye;
            clientControl1.School = _InfoSchool;


            //Rafraichir la liste des clients
            RefreshClientList(_AppConfig);

            //ShowGroup
            lvClient.ShowGroups = _AppConfig.ShowGestionClient_Groupe;

            //Remplir la liste de recherche
            RefreshFindList();

        }

        private void UpdateConfig() {
            SplitterDistance = _AppConfig.CustomerListWidth;
        }

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClients));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Véhicule : Manuel", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Véhicule : Cyclomoteur", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Véhicule : Automatique", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Véhicule : Motocyclette", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Cours Terminé", System.Windows.Forms.HorizontalAlignment.Left);
            Barette.Library.Client.Customer customer1 = new Barette.Library.Client.Customer();
            this.ImageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.tbbAddClient = new System.Windows.Forms.ToolBarButton();
            this.tbbDeleteClient = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator3 = new System.Windows.Forms.ToolBarButton();
            this.tbbFindCustomer = new System.Windows.Forms.ToolBarButton();
            this.tbbPrint = new System.Windows.Forms.ToolBarButton();
            this.cmPrintChoice = new System.Windows.Forms.ContextMenu();
            this.mnuClientInfo = new System.Windows.Forms.MenuItem();
            this.mnuClientPaimentList = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.mnuClientContrat = new System.Windows.Forms.MenuItem();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbRefresh = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbCheckDoublons = new System.Windows.Forms.ToolBarButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AutoUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvClient = new Barette.Library.Listview.ListViewEx();
            this.colhClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhClientNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhClientNoGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstNumeroClient = new Barette.Library.UserControls.ACComboBox();
            this.clientControl1 = new Barette.Library.UserControls.Client.ClientControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmStripClientList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rafraichirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationSurLeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.supprimerLeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientAttestation = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.cmStripClientList.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageListSmall
            // 
            this.ImageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListSmall.ImageStream")));
            this.ImageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListSmall.Images.SetKeyName(0, "Moto");
            this.ImageListSmall.Images.SetKeyName(1, "auto.ico");
            this.ImageListSmall.Images.SetKeyName(2, "Camion.ico");
            // 
            // toolBar1
            // 
            this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbAddClient,
            this.tbbDeleteClient,
            this.tbbSeparator3,
            this.tbbFindCustomer,
            this.tbbPrint,
            this.tbbSeparator,
            this.tbbRefresh,
            this.tbbSeparator2,
            this.tbbCheckDoublons});
            this.toolBar1.Divider = false;
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(326, 50);
            this.toolBar1.TabIndex = 9;
            this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // tbbAddClient
            // 
            this.tbbAddClient.ImageIndex = 0;
            this.tbbAddClient.Name = "tbbAddClient";
            this.tbbAddClient.Tag = "ADD";
            this.tbbAddClient.ToolTipText = "Ajouter un client";
            // 
            // tbbDeleteClient
            // 
            this.tbbDeleteClient.ImageIndex = 1;
            this.tbbDeleteClient.Name = "tbbDeleteClient";
            this.tbbDeleteClient.Tag = "DELETE";
            this.tbbDeleteClient.ToolTipText = "Effacer le client sélectionné";
            // 
            // tbbSeparator3
            // 
            this.tbbSeparator3.Name = "tbbSeparator3";
            this.tbbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbFindCustomer
            // 
            this.tbbFindCustomer.ImageKey = "Symbols-Find-icon.png";
            this.tbbFindCustomer.Name = "tbbFindCustomer";
            this.tbbFindCustomer.Tag = "FIND";
            this.tbbFindCustomer.ToolTipText = "Rechercher un client dans la liste";
            // 
            // tbbPrint
            // 
            this.tbbPrint.DropDownMenu = this.cmPrintChoice;
            this.tbbPrint.ImageIndex = 3;
            this.tbbPrint.Name = "tbbPrint";
            this.tbbPrint.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
            this.tbbPrint.Tag = "PRINT";
            this.tbbPrint.ToolTipText = "Imprimer";
            // 
            // cmPrintChoice
            // 
            this.cmPrintChoice.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuClientInfo,
            this.mnuClientPaimentList,
            this.menuItem4,
            this.mnuClientContrat,
            this.menuItem2,
            this.mnuClientAttestation});
            // 
            // mnuClientInfo
            // 
            this.mnuClientInfo.DefaultItem = true;
            this.mnuClientInfo.Index = 0;
            this.mnuClientInfo.Text = "Information sur le client";
            this.mnuClientInfo.Click += new System.EventHandler(this.mnuClientInfo_Click);
            // 
            // mnuClientPaimentList
            // 
            this.mnuClientPaimentList.Index = 1;
            this.mnuClientPaimentList.Text = "Liste des paiments";
            this.mnuClientPaimentList.Click += new System.EventHandler(this.mnuClientPaimentList_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "-";
            // 
            // mnuClientContrat
            // 
            this.mnuClientContrat.Index = 3;
            this.mnuClientContrat.Text = "Contrat du client";
            this.mnuClientContrat.Click += new System.EventHandler(this.mnuClientContrat_Click);
            // 
            // tbbSeparator
            // 
            this.tbbSeparator.Name = "tbbSeparator";
            this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbRefresh
            // 
            this.tbbRefresh.ImageIndex = 4;
            this.tbbRefresh.Name = "tbbRefresh";
            this.tbbRefresh.Tag = "REFRESH";
            this.tbbRefresh.ToolTipText = "Rafraîchir la liste de clients";
            // 
            // tbbSeparator2
            // 
            this.tbbSeparator2.Name = "tbbSeparator2";
            this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbCheckDoublons
            // 
            this.tbbCheckDoublons.ImageIndex = 2;
            this.tbbCheckDoublons.Name = "tbbCheckDoublons";
            this.tbbCheckDoublons.Tag = "CHECKDOUBLONS";
            this.tbbCheckDoublons.ToolTipText = "Recherche les doublons dans les numéros de clients. ";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-icon.png");
            this.imageList1.Images.SetKeyName(1, "delete-icon.png");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "search-icon.png");
            this.imageList1.Images.SetKeyName(6, "Symbols-Find-icon.png");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AutoUpdateTimer
            // 
            this.AutoUpdateTimer.Enabled = true;
            this.AutoUpdateTimer.Interval = 250;
            this.AutoUpdateTimer.Tick += new System.EventHandler(this.AutoUpdateTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Recherche No. client :";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvClient);
            this.splitContainer1.Panel1.Controls.Add(this.lstNumeroClient);
            this.splitContainer1.Panel1.Controls.Add(this.toolBar1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Resize += new System.EventHandler(this.splitContainer1_Panel1_Resize);
            this.splitContainer1.Panel1MinSize = 326;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.clientControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1027, 625);
            this.splitContainer1.SplitterDistance = 326;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 15;
            this.splitContainer1.DoubleClick += new System.EventHandler(this.splitContainer1_DoubleClick);
            // 
            // lvClient
            // 
            this.lvClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colhClientName,
            this.colhClientNumber,
            this.colhClientNoGroup});
            this.lvClient.FullRowSelect = true;
            listViewGroup1.Header = "Véhicule : Manuel";
            listViewGroup1.Name = "Manuel";
            listViewGroup2.Header = "Véhicule : Cyclomoteur";
            listViewGroup2.Name = "Camion";
            listViewGroup3.Header = "Véhicule : Automatique";
            listViewGroup3.Name = "Automatique";
            listViewGroup4.Header = "Véhicule : Motocyclette";
            listViewGroup4.Name = "Moto";
            listViewGroup5.Header = "Cours Terminé";
            listViewGroup5.Name = "CoursTermine";
            this.lvClient.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
            this.lvClient.HideSelection = false;
            this.lvClient.Location = new System.Drawing.Point(4, 76);
            this.lvClient.MultiSelect = false;
            this.lvClient.Name = "lvClient";
            this.lvClient.ShowItemToolTips = true;
            this.lvClient.Size = new System.Drawing.Size(310, 537);
            this.lvClient.SmallImageList = this.ImageListSmall;
            this.lvClient.TabIndex = 0;
            this.lvClient.UseCompatibleStateImageBehavior = false;
            this.lvClient.View = System.Windows.Forms.View.Details;
            this.lvClient.SelectedIndexChanged += new System.EventHandler(this.lvClient_SelectedIndexChanged);
            this.lvClient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvClient_KeyDown);
            this.lvClient.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvClient_MouseUp);
            // 
            // colhClientName
            // 
            this.colhClientName.DisplayIndex = 1;
            this.colhClientName.Text = "Nom";
            this.colhClientName.Width = 155;
            // 
            // colhClientNumber
            // 
            this.colhClientNumber.DisplayIndex = 0;
            this.colhClientNumber.Text = "#Contrat";
            this.colhClientNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colhClientNumber.Width = 61;
            // 
            // colhClientNoGroup
            // 
            this.colhClientNoGroup.Text = "Nº Groupe";
            // 
            // lstNumeroClient
            // 
            this.lstNumeroClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstNumeroClient.FormattingEnabled = true;
            this.lstNumeroClient.Location = new System.Drawing.Point(123, 51);
            this.lstNumeroClient.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.lstNumeroClient.Name = "lstNumeroClient";
            this.lstNumeroClient.Size = new System.Drawing.Size(192, 21);
            this.lstNumeroClient.Sorted = true;
            this.lstNumeroClient.TabIndex = 13;
            this.lstNumeroClient.SelectedIndexChanged += new System.EventHandler(this.lstNumeroClient_SelectedIndexChanged);
            this.lstNumeroClient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstNumeroClient_KeyDown);
            // 
            // clientControl1
            // 
            this.clientControl1.AutoUpdate = true;
            this.clientControl1.BackColor = System.Drawing.SystemColors.Control;
            customer1.AttestationNumber1 = "";
            customer1.AttestationNumber2 = "";
            customer1.BVA = false;
            customer1.BVADate = new System.DateTime(2010, 3, 12, 8, 33, 17, 367);
            customer1.City = "";
            customer1.ClientNull = false;
            customer1.CodePostal = "   -";
            customer1.ContratNumber = "0";
            customer1.DateAttestation1 = new System.DateTime(2010, 6, 23, 11, 10, 33, 591);
            customer1.DateAttestation2 = new System.DateTime(2010, 6, 23, 11, 10, 33, 591);
            customer1.DateDebutCours = new System.DateTime(2010, 3, 12, 8, 33, 17, 570);
            customer1.DateExpiration = new System.DateTime(2010, 3, 12, 8, 33, 17, 570);
            customer1.DateInscription = new System.DateTime(2010, 3, 12, 8, 33, 17, 367);
            customer1.DateNaissance = new System.DateTime(2010, 3, 12, 8, 33, 17, 570);
            customer1.DateTemporaire = new System.DateTime(2010, 3, 12, 8, 33, 17, 367);
            customer1.DisponibilityAlway = false;
            customer1.DisponibilityAM = false;
            customer1.DisponibilityDimanche = false;
            customer1.DisponibilityPM = false;
            customer1.DisponibilitySamedi = false;
            customer1.DisponibilitySoirer = false;
            customer1.Email = "";
            customer1.FirstName = "";
            customer1.HaveTemporaire = false;
            customer1.LastRecuNumber = "";
            customer1.LocationAutomobile = false;
            customer1.LocationMoto = false;
            customer1.MontantCours = "";
            customer1.MontantLocation = "0 $";
            customer1.Name = "";
            customer1.No6R = "";
            customer1.Notes = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3084{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
    "ans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            customer1.NumeroGroupe = 0;
            customer1.NumeroPermis = "";
            customer1.Phone = "(   )   -";
            customer1.PhoneBureau = "(   )   -";
            customer1.ProgramMoto = Barette.Library.Client.ProgramMoto.Nothing;
            customer1.Solde = "0 $";
            customer1.StreetApp = "";
            customer1.StreetName = "";
            customer1.StreetNumber = "0";
            customer1.TauxHorairePratique = "";
            customer1.TauxHoraireTheorique = "";
            customer1.TypeClient = Barette.Library.Client.ProfileType.Actif;
            customer1.TypeVehicule = Barette.Library.Client.VehiculeType.Automatique;
            this.clientControl1.Client = customer1;
            this.clientControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientControl1.Location = new System.Drawing.Point(0, 0);
            this.clientControl1.Name = "clientControl1";
            this.clientControl1.School = null;
            this.clientControl1.Size = new System.Drawing.Size(695, 625);
            this.clientControl1.TabIndex = 10;
            // 
            // cmStripClientList
            // 
            this.cmStripClientList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rafraichirToolStripMenuItem,
            this.toolStripSeparator2,
            this.imprimerToolStripMenuItem,
            this.toolStripSeparator3,
            this.supprimerLeClientToolStripMenuItem});
            this.cmStripClientList.Name = "cmStripClientList";
            this.cmStripClientList.Size = new System.Drawing.Size(174, 82);
            // 
            // rafraichirToolStripMenuItem
            // 
            this.rafraichirToolStripMenuItem.Name = "rafraichirToolStripMenuItem";
            this.rafraichirToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.rafraichirToolStripMenuItem.Text = "Rafraichir";
            this.rafraichirToolStripMenuItem.Click += new System.EventHandler(this.menuRefresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationSurLeClientToolStripMenuItem,
            this.toolStripSeparator1,
            this.contratToolStripMenuItem});
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.imprimerToolStripMenuItem.Text = "Imprimer";
            // 
            // informationSurLeClientToolStripMenuItem
            // 
            this.informationSurLeClientToolStripMenuItem.Name = "informationSurLeClientToolStripMenuItem";
            this.informationSurLeClientToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.informationSurLeClientToolStripMenuItem.Text = "Information sur le client";
            this.informationSurLeClientToolStripMenuItem.Click += new System.EventHandler(this.menuPrint_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // contratToolStripMenuItem
            // 
            this.contratToolStripMenuItem.Name = "contratToolStripMenuItem";
            this.contratToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.contratToolStripMenuItem.Text = "Contrat du client";
            this.contratToolStripMenuItem.Click += new System.EventHandler(this.menuPrintContrat_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(170, 6);
            // 
            // supprimerLeClientToolStripMenuItem
            // 
            this.supprimerLeClientToolStripMenuItem.Name = "supprimerLeClientToolStripMenuItem";
            this.supprimerLeClientToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.supprimerLeClientToolStripMenuItem.Text = "Supprimer le client";
            this.supprimerLeClientToolStripMenuItem.Click += new System.EventHandler(this.menuDeleteClient_Click);
            // 
            // mnuClientAttestation
            // 
            this.mnuClientAttestation.Index = 5;
            this.mnuClientAttestation.Text = "Attestation (Moto nouveau program)";
            this.mnuClientAttestation.Click += new System.EventHandler(this.mnuClientAttestation_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 4;
            this.menuItem2.Text = "-";
            // 
            // FormClients
            // 
            this.ClientSize = new System.Drawing.Size(1027, 625);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormClients";
            this.Load += new System.EventHandler(this.FormClients_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.cmStripClientList.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// Rafraichier la liste de clients teste en version linq
        /// </summary>
        public void RefreshClientList(Config config) {
            lvClient.Items.Clear();

            Cursor.Current = Cursors.WaitCursor;

            var ListClientFull = from V in _ClientList.Cast<Customer>()
                                 orderby V.GetFullName(false) ascending
                                 select V;

            var ListClientActif = from V in _ClientList.Cast<Customer>()
                                  orderby V.GetFullName(false) ascending
                                  where V.TypeClient == ProfileType.Actif
                                  select V;

            if (config.ShowGestionClient_CoursFinish)
                foreach (Customer client in ListClientFull)
                    AddClientToList(client);
            else
                foreach (Customer client in ListClientActif)
                    AddClientToList(client);

            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Selectionne le client dans la liste de client
        /// </summary>
        /// <param name="ClientNumber">Numéro du client</param>
        public void SelectionClient(string ClientNumber) {
            foreach (ListViewItem item in lvClient.Items)
                if (item.SubItems[1].Text == ClientNumber) {
                    item.Selected = true;
                    item.Focused = true;
                    item.EnsureVisible();
                    break;
                }
        }

        /// <summary>
        /// Appliquer les modifications
        /// </summary>
        private void ApplyModification() {
            if (lvClient.SelectedItems.Count > 0)
                if (clientControl1.ValidateClient() == true) {
                    //lvClient.SelectedItems[0].Tag = clientControl1.Client;
                    foreach (Customer client in _ClientList) {
                        if (client.ContratNumber == lvClient.SelectedItems[0].SubItems[1].Text) {
                            _ClientList.Remove(client);
                            break;
                        }
                    }
                    _ClientList.Add(clientControl1.Client);

                    //Nom et numéro de client
                    //le if permet de stoper le clignotement de la sélection dans la liste de client
                    if ((clientControl1.NomPrenom != lvClient.SelectedItems[0].Text) ||
                    lvClient.SelectedItems[0].SubItems[1].Text != clientControl1.ContratNumber ||
                    lvClient.SelectedItems[0].SubItems[2].Text != clientControl1.Client.NumeroGroupe.ToString()) {

                        lvClient.SelectedItems[0].Text = clientControl1.NomCompletReverse;
                        lvClient.SelectedItems[0].SubItems[1].Text = clientControl1.ContratNumber;
                        lvClient.SelectedItems[0].SubItems[2].Text = clientControl1.Client.NumeroGroupe.ToString();
                    }

                    //Sections
                    if (clientControl1.TypeClient == ProfileType.CoursTerminer) {
                        switch (clientControl1.TypeVehicule) {
                            case VehiculeType.Automatique:
                                lvClient.SelectedItems[0].ImageIndex = 1;
                                break;
                            case VehiculeType.Moto:
                                lvClient.SelectedItems[0].ImageIndex = 0;
                                break;
                            case VehiculeType.Cyclomoteur:
                                lvClient.SelectedItems[0].ImageIndex = 0;
                                break;
                            case VehiculeType.Manuel:
                                lvClient.SelectedItems[0].ImageIndex = 1;
                                break;
                        }
                        lvClient.Groups[4].Items.Add(lvClient.SelectedItems[0]);
                    }
                    else {

                        switch (clientControl1.TypeVehicule) {
                            case VehiculeType.Automatique:
                                lvClient.SelectedItems[0].ImageIndex = 1;
                                lvClient.Groups[2].Items.Add(lvClient.SelectedItems[0]);
                                break;
                            case VehiculeType.Moto:
                                lvClient.SelectedItems[0].ImageIndex = 0;
                                lvClient.Groups[3].Items.Add(lvClient.SelectedItems[0]);
                                break;
                            case VehiculeType.Cyclomoteur:
                                lvClient.SelectedItems[0].ImageIndex = 0;
                                lvClient.Groups[1].Items.Add(lvClient.SelectedItems[0]);
                                break;
                            case VehiculeType.Manuel:
                                lvClient.SelectedItems[0].ImageIndex = 1;
                                lvClient.Groups[0].Items.Add(lvClient.SelectedItems[0]);
                                break;
                        }
                    }
                }
        }

        /// <summary>
        /// Supprime le client selectioner
        /// </summary>
        private DialogResult DeleteSelectedClient() {
            if (lvClient.SelectedItems.Count > 0)
                if (MessageBox.Show(this, "Voulez vous vraiment effacer : " + lvClient.SelectedItems[0].Text + " ?",
                    _AppConfig.ApplicationName,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes) {

                    foreach (Customer client in _ClientList)
                        if (client.ContratNumber == lvClient.SelectedItems[0].SubItems[1].Text) {
                            _ClientList.Remove(client);
                            break;
                        }

                    lvClient.Items.RemoveAt(lvClient.SelectedItems[0].Index);

                    return DialogResult.Yes;
                }

            return DialogResult.No;
        }

        private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e) {
            switch (e.Button.Tag.ToString()) {
                case "ADD":
                    FormAjoutClient frmAddClient = new FormAjoutClient(this, _InfoSchool, _AppConfig);
                    if (frmAddClient.ShowDialog() == DialogResult.OK)
                        AddToListRecherche(frmAddClient.clientControl1.Client);
                    break;
                case "DELETE":
                    if (DeleteSelectedClient() == DialogResult.Yes)
                        RefreshFindList();
                    break;
                case "PRINT":
                    //clientControl1.PrintDoc(Barette.Library.UserControls.Client.PrintDocumentType.InfoClient);
                    mnuClientInfo_Click(this, new EventArgs());
                    break;
                case "REFRESH":
                    RefreshClientList(_AppConfig);
                    RefreshFindList();
                    break;
                case "CHECKDOUBLONS":
                    if (MessageBox.Show(this, "Voullez vous trouver les numéros de contrat en double dans votre liste de clients ?", _AppConfig.ApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        FindDoublon();
                    break;
                case "FIND":
                    //TODO: TEMPS changer pour une fonction
                    new FormClientFind(_ClientList, this, _AppConfig).ShowDialog(this);
                    break;
            }
        }

        private void timer1_Tick(object sender, System.EventArgs e) {
            if (lvClient.SelectedItems.Count > 0) {
                clientControl1.Enabled = true;
                tbbDeleteClient.Enabled = true;
                tbbPrint.Enabled = true;
                
                //Menu d<impression de la liste des paiments
                if (clientControl1.Client.Paiment.Count > 0)
                    mnuClientPaimentList.Enabled = true;
                else
                    mnuClientPaimentList.Enabled = false;
            }
            else {
                clientControl1.Enabled = false;
                tbbDeleteClient.Enabled = false;
                tbbPrint.Enabled = false;
                clientControl1.CloseClient();
            }
        }

        private void lvClient_SelectedIndexChanged(object sender, System.EventArgs e) {
            if (lvClient.SelectedItems.Count > 0) {
                //Reasignation
                clientControl1.Client = _ClientList.GetClient(lvClient.SelectedItems[0].SubItems[1].Text);
                clientControl1.Enabled = true;
            }
            else
                clientControl1.Enabled = false;
        }

        /// <summary>
        /// Mise a jour automatique du client en cour d'édition
        /// </summary>		
        private void AutoUpdateTimer_Tick(object sender, System.EventArgs e) {
            if (clientControl1.AutoUpdate == true)
                ApplyModification();
        }

        /// <summary>
        /// Remplir la liste de recherche des clients
        /// </summary>
        public void RefreshFindList() {
            lstNumeroClient.Items.Clear();

            var ListClientFull = from V in _ClientList.Cast<Customer>()
                                 select V;

            var ListClientActif = from V in _ClientList.Cast<Customer>()
                                  where V.TypeClient == ProfileType.Actif
                                  select V;

            if (_AppConfig.ShowGestionClient_CoursFinish)
                foreach (Customer client in ListClientFull)
                    AddToListRecherche(client); //lstNumeroClient.Items.Add(client.ContratNumber);
            else
                foreach (Customer client in ListClientActif)
                    AddToListRecherche(client); //lstNumeroClient.Items.Add(client.ContratNumber);
        }

        /// <summary>
        /// Ferme le client en cours.
        /// </summary>
        public void CloseClient() {
            foreach (ListViewItem item in lvClient.SelectedItems)
                item.Selected = false;

            clientControl1.Enabled = false;
            clientControl1.CloseClient();
        }

        /// <summary>
        /// Remplir la liste de recherche des clients
        /// </summary>
        private void AddToListRecherche(Customer client) {

            if (!isNeedTooAdd(client))
                return;

            if (client.ContratNumber != "")
                lstNumeroClient.Items.Add(client.ContratNumber);
        }

        private void lstNumeroClient_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            if (e.KeyCode == Keys.Return) {
                if (lstNumeroClient.Text != "") {
                    SelectionClient(lstNumeroClient.Text);
                }
            }
        }

        private void lstNumeroClient_SelectedIndexChanged(object sender, System.EventArgs e) {
            if (lstNumeroClient.Text != "") {
                SelectionClient(lstNumeroClient.Text);
            }
        }

        /// <summary>
        /// Réagir aux touche du clavier dans la liste de client
        /// </summary>        
        private void lvClient_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Delete:
                    DeleteSelectedClient();
                    RefreshFindList();
                    break;
            }
        }

        private void ResizeColone() {
            colhClientName.Width = lvClient.Width - colhClientNumber.Width - colhClientNoGroup.Width - 30;
        }

        /// <summary>
        /// Recherche les numéro de client double et les met en couleur 
        /// </summary>
        private void FindDoublon() {
            Cursor.Current = Cursors.WaitCursor;
            bool HaveDoublons = false;

            //Reset le backcolor de chaque items dans la liste
            foreach (ListViewItem item in lvClient.Items)
                item.BackColor = SystemColors.Window;

            var listdoublon = from V in _ClientList.Cast<Customer>()
                              group V by V.ContratNumber into M
                              where M.Count<Customer>() > 1
                              select M;

            foreach (var client in listdoublon) {
                foreach (ListViewItem item in lvClient.Items) {
                    if (client.Key == item.SubItems[1].Text) {
                        item.BackColor = Color.Red;
                        HaveDoublons = true;
                    }
                }
            }

            Cursor.Current = Cursors.Default;

            if (HaveDoublons)
                MessageBox.Show(this, "Vous avez des doublons dans vos numéros de client. Il vous est fortement conseillé de les corrigés afin d’éviter les erreurs dans le logiciel.",
                    _AppConfig.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void menuDeleteClient_Click(object sender, System.EventArgs e) {
            DeleteSelectedClient();
            RefreshFindList();
        }

        private void menuRefresh_Click(object sender, System.EventArgs e) {
            RefreshClientList(_AppConfig);
            RefreshFindList();
        }

        private void cbClientName_CheckedChanged(object sender, System.EventArgs e) {

        }

        private void menuPrint_Click(object sender, System.EventArgs e) {
            clientControl1.PrintDoc(Barette.Library.UserControls.Client.PrintDocumentType.InfoClient);
        }

        private void menuPrintContrat_Click(object sender, System.EventArgs e) {
            clientControl1.PrintDoc(Barette.Library.UserControls.Client.PrintDocumentType.Contract);
        }

        private void splitContainer1_Panel1_Resize(object sender, EventArgs e) {
            ResizeColone();
        }

        private void splitContainer1_DoubleClick(object sender, EventArgs e) {
            splitContainer1.SplitterDistance = 500;
        }

        private void cmClientList_Popup(object sender, EventArgs e) {

        }

        private void lvClient_MouseUp(object sender, MouseEventArgs e) {
            if (lvClient.SelectedItems.Count > 0 && e.Button == MouseButtons.Right)
                cmStripClientList.Show(lvClient, new Point(e.X, e.Y));
        }

        /// <summary>
        /// Détermine si les groupe sont affichés les groupes dans la liste de client
        /// </summary>
        public bool ShowGroupInList {
            get {
                return lvClient.ShowGroups;
            }
            set {
                lvClient.ShowGroups = value;
            }
        }

        /// <summary>
        /// Ajoute un client dans la collection de client
        /// </summary>
        public void AddClient(Customer Client) {
            _ClientList.Add(Client);
        }

        internal void AddClientToList(Customer client) {
            ListViewItem itm = new ListViewItem();
            RichTextBox rich = new RichTextBox();
            
            if (!isNeedTooAdd(client))
                return;

            //if (cbClientName.Checked == true)
            //    itm.Text = client.FirstName + " " + client.Name;
            //else
            itm.Text = client.Name + " " + client.FirstName;

            //itm.ImageIndex = 0;
            //itm.Tag = client;
            itm.SubItems.Add(client.ContratNumber);
            itm.SubItems.Add(client.NumeroGroupe.ToString());

            //Type de profile
            if (client.TypeClient == ProfileType.CoursTerminer) {
                switch (client.TypeVehicule) {
                    case VehiculeType.Automatique:
                        itm.ImageIndex = 1;
                        break;
                    case VehiculeType.Moto:
                        itm.ImageIndex = 0;
                        break;
                    case VehiculeType.Cyclomoteur:
                        itm.ImageIndex = 0;
                        break;
                    case VehiculeType.Manuel:
                        itm.ImageIndex = 1;
                        break;
                }
                lvClient.Groups[4].Items.Add(itm);
            }
            else {

                switch (client.TypeVehicule) {
                    case VehiculeType.Automatique:
                        itm.ImageIndex = 1;
                        lvClient.Groups[2].Items.Add(itm);
                        break;
                    case VehiculeType.Moto:
                        itm.ImageIndex = 0;
                        lvClient.Groups[3].Items.Add(itm);
                        break;
                    case VehiculeType.Cyclomoteur:
                        itm.ImageIndex = 0;
                        lvClient.Groups[1].Items.Add(itm);
                        break;
                    case VehiculeType.Manuel:
                        itm.ImageIndex = 1;
                        lvClient.Groups[0].Items.Add(itm);
                        break;
                }
            }

            lvClient.Items.Add(itm);
        }

        private bool isNeedTooAdd(Customer client)
        {
            if (client.TypeVehicule == VehiculeType.Moto && !_AppConfig.ShowGestionClient_GroupeMoto)
                return false;

            if (client.TypeVehicule == VehiculeType.Cyclomoteur && !_AppConfig.ShowGestionClient_GroupeCyclomoteur)
                return false;

            if ((client.TypeVehicule == VehiculeType.Automatique ||
                client.TypeVehicule == VehiculeType.Manuel ||
                client.TypeVehicule == VehiculeType.Automobile) && !_AppConfig.ShowGestionClient_GroupeAutomobile)
                return false;

            return true;

        }

        private void mnuClientInfo_Click(object sender, EventArgs e) {
            clientControl1.PrintDoc(Barette.Library.UserControls.Client.PrintDocumentType.InfoClient);
        }

        private void mnuClientContrat_Click(object sender, EventArgs e) {
#if DEBUG
            clientControl1.PrintDoc(Barette.Library.UserControls.Client.PrintDocumentType.Contract);
#else
            clientControl1.PrintDoc(Barette.Library.UserControls.Client.PrintDocumentType.Contract);
            clientControl1.PrintDoc(Barette.Library.UserControls.Client.PrintDocumentType.Contract);
#endif
        }
        

        private void FormClients_Load(object sender, EventArgs e) {
            ResizeColone();

            UpdateConfig();
        }

        /// <summary>
        /// Mise a jour des configurations
        /// </summary>
        public int SplitterDistance {
            get {
                return splitContainer1.SplitterDistance;
            }
            set {
                splitContainer1.SplitterDistance = value;
            }
        }

        private void mnuClientPaimentList_Click(object sender, EventArgs e) {
            clientControl1.PrintDoc(Barette.Library.UserControls.Client.PrintDocumentType.PaimentList);
        }

        private void mnuClientAttestation_Click(object sender, EventArgs e)
        {
#if DEBUG
            clientControl1.PrintDoc(Barette.Library.UserControls.Client.PrintDocumentType.AttestationMoto2015);
#else
            clientControl1.PrintDoc(Barette.Library.UserControls.Client.PrintDocumentType.AttestationMoto2015);
            clientControl1.PrintDoc(Barette.Library.UserControls.Client.PrintDocumentType.AttestationMoto2015);
            clientControl1.PrintDoc(Barette.Library.UserControls.Client.PrintDocumentType.AttestationMoto2015);
#endif
        }
    }
}
