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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClients));
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Véhicule : Manuel", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Véhicule : Cyclomoteur", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Véhicule : Automatique", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("Véhicule : Motocyclette", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("Cours Terminé", System.Windows.Forms.HorizontalAlignment.Left);
            Barette.Library.Client.Customer customer2 = new Barette.Library.Client.Customer();
            ImageListSmall = new System.Windows.Forms.ImageList(components);
            toolBar1 = new System.Windows.Forms.ToolBar();
            tbbAddClient = new System.Windows.Forms.ToolBarButton();
            tbbDeleteClient = new System.Windows.Forms.ToolBarButton();
            tbbSeparator3 = new System.Windows.Forms.ToolBarButton();
            tbbFindCustomer = new System.Windows.Forms.ToolBarButton();
            tbbPrint = new System.Windows.Forms.ToolBarButton();
            cmPrintChoice = new System.Windows.Forms.ContextMenu();
            mnuClientInfo = new System.Windows.Forms.MenuItem();
            menuItem4 = new System.Windows.Forms.MenuItem();
            mnuClientContrat = new System.Windows.Forms.MenuItem();
            tbbSeparator = new System.Windows.Forms.ToolBarButton();
            tbbRefresh = new System.Windows.Forms.ToolBarButton();
            tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            tbbCheckDoublons = new System.Windows.Forms.ToolBarButton();
            imageList1 = new System.Windows.Forms.ImageList(components);
            timer1 = new System.Windows.Forms.Timer(components);
            AutoUpdateTimer = new System.Windows.Forms.Timer(components);
            label1 = new System.Windows.Forms.Label();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            lvClient = new Barette.Library.Listview.ListViewEx();
            colhClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colhClientNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colhClientNoGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lstNumeroClient = new Barette.Library.UserControls.ACComboBox();
            clientControl1 = new Barette.Library.UserControls.Client.ClientControl();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            cmStripClientList = new System.Windows.Forms.ContextMenuStrip(components);
            rafraichirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            informationSurLeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            contratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            supprimerLeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mnuClientPaimentList = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            cmStripClientList.SuspendLayout();
            SuspendLayout();
            // 
            // ImageListSmall
            // 
            ImageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListSmall.ImageStream")));
            ImageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            ImageListSmall.Images.SetKeyName(0, "Moto");
            ImageListSmall.Images.SetKeyName(1, "auto.ico");
            ImageListSmall.Images.SetKeyName(2, "Camion.ico");
            // 
            // toolBar1
            // 
            toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            tbbAddClient,
            tbbDeleteClient,
            tbbSeparator3,
            tbbFindCustomer,
            tbbPrint,
            tbbSeparator,
            tbbRefresh,
            tbbSeparator2,
            tbbCheckDoublons});
            toolBar1.Divider = false;
            toolBar1.DropDownArrows = true;
            toolBar1.ImageList = imageList1;
            toolBar1.Location = new System.Drawing.Point(0, 0);
            toolBar1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            toolBar1.Name = "toolBar1";
            toolBar1.ShowToolTips = true;
            toolBar1.Size = new System.Drawing.Size(326, 50);
            toolBar1.TabIndex = 9;
            toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(toolBar1_ButtonClick);
            // 
            // tbbAddClient
            // 
            tbbAddClient.ImageIndex = 0;
            tbbAddClient.Name = "tbbAddClient";
            tbbAddClient.Tag = "ADD";
            tbbAddClient.ToolTipText = "Ajouter un client";
            // 
            // tbbDeleteClient
            // 
            tbbDeleteClient.ImageIndex = 1;
            tbbDeleteClient.Name = "tbbDeleteClient";
            tbbDeleteClient.Tag = "DELETE";
            tbbDeleteClient.ToolTipText = "Effacer le client sélectionné";
            // 
            // tbbSeparator3
            // 
            tbbSeparator3.Name = "tbbSeparator3";
            tbbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbFindCustomer
            // 
            tbbFindCustomer.ImageKey = "Symbols-Find-icon.png";
            tbbFindCustomer.Name = "tbbFindCustomer";
            tbbFindCustomer.Tag = "FIND";
            tbbFindCustomer.ToolTipText = "Rechercher un client dans la liste";
            // 
            // tbbPrint
            // 
            tbbPrint.DropDownMenu = cmPrintChoice;
            tbbPrint.ImageIndex = 3;
            tbbPrint.Name = "tbbPrint";
            tbbPrint.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
            tbbPrint.Tag = "PRINT";
            tbbPrint.ToolTipText = "Imprimer";
            // 
            // cmPrintChoice
            // 
            cmPrintChoice.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            mnuClientInfo,
            mnuClientPaimentList,
            menuItem4,
            mnuClientContrat});
            // 
            // mnuClientInfo
            // 
            mnuClientInfo.DefaultItem = true;
            mnuClientInfo.Index = 0;
            mnuClientInfo.Text = "Information sur le client";
            mnuClientInfo.Click += new System.EventHandler(mnuClientInfo_Click);
            // 
            // menuItem4
            // 
            menuItem4.Index = 2;
            menuItem4.Text = "-";
            // 
            // mnuClientContrat
            // 
            mnuClientContrat.Index = 3;
            mnuClientContrat.Text = "Contrat du client";
            mnuClientContrat.Click += new System.EventHandler(mnuClientContrat_Click);
            // 
            // tbbSeparator
            // 
            tbbSeparator.Name = "tbbSeparator";
            tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbRefresh
            // 
            tbbRefresh.ImageIndex = 4;
            tbbRefresh.Name = "tbbRefresh";
            tbbRefresh.Tag = "REFRESH";
            tbbRefresh.ToolTipText = "Rafraîchir la liste de clients";
            // 
            // tbbSeparator2
            // 
            tbbSeparator2.Name = "tbbSeparator2";
            tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbCheckDoublons
            // 
            tbbCheckDoublons.ImageIndex = 2;
            tbbCheckDoublons.Name = "tbbCheckDoublons";
            tbbCheckDoublons.Tag = "CHECKDOUBLONS";
            tbbCheckDoublons.ToolTipText = "Recherche les doublons dans les numéros de clients. ";
            // 
            // imageList1
            // 
            imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "add-icon.png");
            imageList1.Images.SetKeyName(1, "delete-icon.png");
            imageList1.Images.SetKeyName(2, "");
            imageList1.Images.SetKeyName(3, "");
            imageList1.Images.SetKeyName(4, "");
            imageList1.Images.SetKeyName(5, "search-icon.png");
            imageList1.Images.SetKeyName(6, "Symbols-Find-icon.png");
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 200;
            timer1.Tick += new System.EventHandler(timer1_Tick);
            // 
            // AutoUpdateTimer
            // 
            AutoUpdateTimer.Enabled = true;
            AutoUpdateTimer.Interval = 250;
            AutoUpdateTimer.Tick += new System.EventHandler(AutoUpdateTimer_Tick);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 54);
            label1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(114, 13);
            label1.TabIndex = 12;
            label1.Text = "Recherche No. client :";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lvClient);
            splitContainer1.Panel1.Controls.Add(lstNumeroClient);
            splitContainer1.Panel1.Controls.Add(toolBar1);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Resize += new System.EventHandler(splitContainer1_Panel1_Resize);
            splitContainer1.Panel1MinSize = 326;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(clientControl1);
            splitContainer1.Size = new System.Drawing.Size(1027, 625);
            splitContainer1.SplitterDistance = 326;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 15;
            splitContainer1.DoubleClick += new System.EventHandler(splitContainer1_DoubleClick);
            // 
            // lvClient
            // 
            lvClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            lvClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            colhClientName,
            colhClientNumber,
            colhClientNoGroup});
            lvClient.FullRowSelect = true;
            listViewGroup6.Header = "Véhicule : Manuel";
            listViewGroup6.Name = "Manuel";
            listViewGroup7.Header = "Véhicule : Cyclomoteur";
            listViewGroup7.Name = "Camion";
            listViewGroup8.Header = "Véhicule : Automatique";
            listViewGroup8.Name = "Automatique";
            listViewGroup9.Header = "Véhicule : Motocyclette";
            listViewGroup9.Name = "Moto";
            listViewGroup10.Header = "Cours Terminé";
            listViewGroup10.Name = "CoursTermine";
            lvClient.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup6,
            listViewGroup7,
            listViewGroup8,
            listViewGroup9,
            listViewGroup10});
            lvClient.HideSelection = false;
            lvClient.Location = new System.Drawing.Point(4, 76);
            lvClient.MultiSelect = false;
            lvClient.Name = "lvClient";
            lvClient.ShowItemToolTips = true;
            lvClient.Size = new System.Drawing.Size(310, 537);
            lvClient.SmallImageList = ImageListSmall;
            lvClient.TabIndex = 0;
            lvClient.UseCompatibleStateImageBehavior = false;
            lvClient.View = System.Windows.Forms.View.Details;
            lvClient.SelectedIndexChanged += new System.EventHandler(lvClient_SelectedIndexChanged);
            lvClient.KeyDown += new System.Windows.Forms.KeyEventHandler(lvClient_KeyDown);
            lvClient.MouseUp += new System.Windows.Forms.MouseEventHandler(lvClient_MouseUp);
            // 
            // colhClientName
            // 
            colhClientName.DisplayIndex = 1;
            colhClientName.Text = "Nom";
            colhClientName.Width = 155;
            // 
            // colhClientNumber
            // 
            colhClientNumber.DisplayIndex = 0;
            colhClientNumber.Text = "#Contrat";
            colhClientNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            colhClientNumber.Width = 61;
            // 
            // colhClientNoGroup
            // 
            colhClientNoGroup.Text = "Nº Groupe";
            // 
            // lstNumeroClient
            // 
            lstNumeroClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            lstNumeroClient.FormattingEnabled = true;
            lstNumeroClient.Location = new System.Drawing.Point(123, 51);
            lstNumeroClient.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            lstNumeroClient.Name = "lstNumeroClient";
            lstNumeroClient.Size = new System.Drawing.Size(192, 21);
            lstNumeroClient.Sorted = true;
            lstNumeroClient.TabIndex = 13;
            lstNumeroClient.SelectedIndexChanged += new System.EventHandler(lstNumeroClient_SelectedIndexChanged);
            lstNumeroClient.KeyDown += new System.Windows.Forms.KeyEventHandler(lstNumeroClient_KeyDown);
            // 
            // clientControl1
            // 
            clientControl1.AutoUpdate = true;
            clientControl1.BackColor = System.Drawing.SystemColors.Control;
            customer2.AttestationNumber1 = "";
            customer2.AttestationNumber2 = "";
            customer2.BVA = false;
            customer2.BVADate = new System.DateTime(2010, 3, 12, 8, 33, 17, 367);
            customer2.City = "";
            customer2.ClientNull = false;
            customer2.CodePostal = "   -";
            customer2.ContratNumber = "0";
            customer2.DateAttestation1 = new System.DateTime(2010, 6, 23, 11, 10, 33, 591);
            customer2.DateAttestation2 = new System.DateTime(2010, 6, 23, 11, 10, 33, 591);
            customer2.DateDebutCours = new System.DateTime(2010, 3, 12, 8, 33, 17, 570);
            customer2.DateExpiration = new System.DateTime(2010, 3, 12, 8, 33, 17, 570);
            customer2.DateInscription = new System.DateTime(2010, 3, 12, 8, 33, 17, 367);
            customer2.DateNaissance = new System.DateTime(2010, 3, 12, 8, 33, 17, 570);
            customer2.DateTemporaire = new System.DateTime(2010, 3, 12, 8, 33, 17, 367);
            customer2.DisponibilityAlway = false;
            customer2.DisponibilityAM = false;
            customer2.DisponibilityDimanche = false;
            customer2.DisponibilityPM = false;
            customer2.DisponibilitySamedi = false;
            customer2.DisponibilitySoirer = false;
            customer2.Email = "";
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
            customer2.StreetNumber = "0";
            customer2.TauxHorairePratique = "";
            customer2.TauxHoraireTheorique = "";
            customer2.TypeClient = Barette.Library.Client.ProfileType.Actif;
            customer2.TypeVehicule = Barette.Library.Client.VehiculeType.Automatique;
            clientControl1.Client = customer2;
            clientControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            clientControl1.Location = new System.Drawing.Point(0, 0);
            clientControl1.Name = "clientControl1";
            clientControl1.School = null;
            clientControl1.Size = new System.Drawing.Size(695, 625);
            clientControl1.TabIndex = 10;
            // 
            // cmStripClientList
            // 
            cmStripClientList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            rafraichirToolStripMenuItem,
            toolStripSeparator2,
            imprimerToolStripMenuItem,
            toolStripSeparator3,
            supprimerLeClientToolStripMenuItem});
            cmStripClientList.Name = "cmStripClientList";
            cmStripClientList.Size = new System.Drawing.Size(174, 82);
            // 
            // rafraichirToolStripMenuItem
            // 
            rafraichirToolStripMenuItem.Name = "rafraichirToolStripMenuItem";
            rafraichirToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            rafraichirToolStripMenuItem.Text = "Rafraichir";
            rafraichirToolStripMenuItem.Click += new System.EventHandler(menuRefresh_Click);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // imprimerToolStripMenuItem
            // 
            imprimerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            informationSurLeClientToolStripMenuItem,
            toolStripSeparator1,
            contratToolStripMenuItem});
            imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            imprimerToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            imprimerToolStripMenuItem.Text = "Imprimer";
            // 
            // informationSurLeClientToolStripMenuItem
            // 
            informationSurLeClientToolStripMenuItem.Name = "informationSurLeClientToolStripMenuItem";
            informationSurLeClientToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            informationSurLeClientToolStripMenuItem.Text = "Information sur le client";
            informationSurLeClientToolStripMenuItem.Click += new System.EventHandler(menuPrint_Click);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // contratToolStripMenuItem
            // 
            contratToolStripMenuItem.Name = "contratToolStripMenuItem";
            contratToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            contratToolStripMenuItem.Text = "Contrat du client";
            contratToolStripMenuItem.Click += new System.EventHandler(menuPrintContrat_Click);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(170, 6);
            // 
            // supprimerLeClientToolStripMenuItem
            // 
            supprimerLeClientToolStripMenuItem.Name = "supprimerLeClientToolStripMenuItem";
            supprimerLeClientToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            supprimerLeClientToolStripMenuItem.Text = "Supprimer le client";
            supprimerLeClientToolStripMenuItem.Click += new System.EventHandler(menuDeleteClient_Click);
            // 
            // mnuClientPaimentList
            // 
            mnuClientPaimentList.Index = 1;
            mnuClientPaimentList.Text = "Liste des paiments";
            mnuClientPaimentList.Click += new System.EventHandler(mnuClientPaimentList_Click);
            // 
            // FormClients
            // 
            ClientSize = new System.Drawing.Size(1027, 625);
            Controls.Add(splitContainer1);
            Name = "FormClients";
            Load += new System.EventHandler(FormClients_Load);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).EndInit();
            splitContainer1.ResumeLayout(false);
            cmStripClientList.ResumeLayout(false);
            ResumeLayout(false);

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
    }
}
