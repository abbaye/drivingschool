using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Barette.IDE.Forms.Calendar;
using Barette.IDE.Forms.Finance;
using Barette.IDE.Forms.GestionGroup;
using Barette.IDE.Forms.InfoEcole;
using Barette.IDE.Forms.LigueSecuriter;
using Barette.IDE.Forms.Notes;
using Barette.Library;
using Barette.Library.Backup;
using Barette.Library.Client;
using Barette.Library.Collections;
using Barette.Library.Employer;
using Barette.Library.Forms;
using Barette.Library.Win32;
using Crownwood.Magic.Controls;
using UtilityLibrary.WinControls;

namespace Barette.IDE.Forms
{
    /// <summary>
    /// Description résumée de Form1.
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// instance de la fenetre client
        /// </summary>
        private FormClients _formClients = null;

        /// <summary>
        /// instance de la fenetre de recherche
        /// </summary>
        private FormFindClient _formFindClient = null;

        /// <summary>
        /// instance de la fenetre Suivie des cours
        /// </summary>
        private FormSuivieCours _formSuivieCours = null;

        /// <summary>
        /// instance de la fenetre Suivie des cours de Moto
        /// </summary>
        private FormSuivieCoursMoto2015 _formSuivieCoursMoto = null;

        /// <summary>
        /// instance de la fenetre de finance
        /// </summary>
        private FormFinance _formFinance = null;

        /// <summary>
        /// instance de la fenetre horraire
        /// </summary>
        private FormHoraire _formHoraire = null;

        /// <summary>
        /// instance de la fenetre de Employe
        /// </summary>
        private FormEmploye _formEmploye = null;


        /// <summary>
        /// instance de la fenetre de Statistique
        /// </summary>
        private FormStatistiques _formStatistique = null;

        /// <summary>
        /// instance de la fenetre des Notes
        /// </summary>
        private FormPostIt _formPostIt = null;

        /// <summary>
        /// Instance de la fenetre de gestion des groupes d'élèves
        /// </summary>
        private FormGestionGroupe _formGestionGroupe = null;

        /// <summary>
        /// instance de la fenetre des Notes
        /// </summary>
        private FormLigueSecuriter _formLigueSecuriter = null;

        /// <summary>
        /// Liste de tous les client
        /// </summary>		
        public CustomerCollection ClientList = new CustomerCollection();

        /// <summary>
        /// Liste de tous les notes
        /// </summary>
        public PostItCollection PostItList = new PostItCollection();

        /// <summary>
        /// Liste de jour férié
        /// </summary>
        private readonly OffDateCollection OffDateList = new OffDateCollection();

        /// <summary>
        /// Liste de groupe d'élèves
        /// </summary>
        private readonly List<StudentGroup> StudentGroupList = new List<StudentGroup>();

        /// <summary>
        /// Liste d'employe
        /// </summary>
        public EmployeCollection EmployeList = new EmployeCollection();

        /// <summary>
        /// Liste de postit qui serviront a prendre des notes pour les horaires.
        /// </summary>
        private readonly PostItCollection NotesHoraire = new PostItCollection();

        /// <summary>
        /// Information sur l'ecole de conduite
        /// </summary>
        private SchoolInfo _InfoSchool = new SchoolInfo();

        /// <summary>
        /// Configuration de l'application
        /// </summary>
        private Config _AppConfig = new Config();

        private ImageList OutlookBarImageList;
        private Timer PostItAlertTimer;
        private OutlookBarBand outBandGestion;
        private FolderBrowserDialog folderDialogBackup;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem tsmnuOpen;
        private ToolStripMenuItem tsmnuEnregistrer;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmnuItem;
        private ToolStripMenuItem tsmnuModule;
        private ToolStripMenuItem tsmnuModuleClient;
        private ToolStripMenuItem tsmnuModuleFinance;
        private ToolStripMenuItem tsmnuModuleEmployer;
        private ToolStripMenuItem tsmnuModuleHoraire;
        private ToolStripMenuItem tsmnuModuleGroupe;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItem12;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem tsmnuModuleSuivie;
        private ToolStripMenuItem tsmnuModuleStatistiques;
        private ToolStripMenuItem tsmnuModuleNotes;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem tsmnuModuleFind;
        private ToolStripMenuItem tsmnuTools;
        private ToolStripMenuItem toolStripMenuItem13;
        private ToolStripMenuItem tsmnuAboutDialog;
        private ToolStripMenuItem tsmnuToolCodes;
        private ToolStripMenuItem tsmnuOffDate;
        private ToolStripMenuItem tsmnuSchoolInfo;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem tsmnuBackup;
        private ToolStripMenuItem tsmnuView;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem tsmnuViewModuleClient;
        private ToolStripMenuItem tsmnuViewTypeCours;
        private ToolStripMenuItem tsmnuViewModuleBar;
        private ToolStripContainer toolStripContainer1;
        private TabbedGroups tabGroup;
        private Splitter splitter1;
        private OutlookBar outLookBar;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem tsmnuToolsDialog;
        private ToolStripMenuItem tsmnuEnregistrerSous;
        private ToolStripMenuItem tsmnuImportExport;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem tsmnuAdd;
        private ToolStripMenuItem tsmnuAddCustomer;
        private ToolStripMenuItem tsmnuAddEmployer;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem tsmnuExport;
        private ToolStripMenuItem tsmnuImport;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem tsmnuImportBackup;
        private OpenFileDialog openFileDialogImport;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripMenuItem tsmnuAutoCompletedCustomer;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripMenuItem listeDesClientsToolStripMenuItem;
        private ToolStripMenuItem automobileToolStripMenuItem;
        private ToolStripMenuItem motoToolStripMenuItem;
        private ToolStripMenuItem cyclomoteurToolStripMenuItem;
        private ToolStripMenuItem tsmnuViewCoursFinish;
        private ToolStripSeparator toolStripSeparator13;
        private System.ComponentModel.IContainer components;

        public FormMain()
        {
            //
            // Requis pour la prise en charge du Concepteur Windows Forms
            //
            InitializeComponent();

            MakeStaticBorder();
            InitializeBandGestion();

            Directory.CreateDirectory("Data");

            OpenAll();            

            //Check si les information de l'école existe
            if (File.Exists(@"Data\SchoolInfo.xml") == false)
            {
                Show();
                new FormInfoEcole(_InfoSchool, true, _AppConfig).ShowDialog(this);
            }

#if DEBUG
            test();
#endif
        }

        /// <summary>
        /// Test lancer dans la fenetre debug
        /// </summary>
        private void test()
        {
            //var NomFamille = from client in this.ClientList.Cast<Customer>()
            //                 group client by client.Name into g
            //                 select g.Key;

            //foreach (var nom in NomFamille)
            //    Debug.WriteLine(nom); 
        }

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.OutlookBarImageList = new ImageList(this.components);
            this.PostItAlertTimer = new Timer(this.components);
            this.folderDialogBackup = new FolderBrowserDialog();
            this.menuStrip1 = new MenuStrip();
            this.toolStripMenuItem1 = new ToolStripMenuItem();
            this.tsmnuAdd = new ToolStripMenuItem();
            this.tsmnuAddCustomer = new ToolStripMenuItem();
            this.tsmnuAddEmployer = new ToolStripMenuItem();
            this.toolStripSeparator9 = new ToolStripSeparator();
            this.tsmnuOpen = new ToolStripMenuItem();
            this.tsmnuEnregistrer = new ToolStripMenuItem();
            this.tsmnuEnregistrerSous = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.tsmnuImportExport = new ToolStripMenuItem();
            this.tsmnuExport = new ToolStripMenuItem();
            this.tsmnuImport = new ToolStripMenuItem();
            this.toolStripSeparator10 = new ToolStripSeparator();
            this.tsmnuImportBackup = new ToolStripMenuItem();
            this.toolStripSeparator8 = new ToolStripSeparator();
            this.tsmnuItem = new ToolStripMenuItem();
            this.tsmnuView = new ToolStripMenuItem();
            this.tsmnuViewModuleClient = new ToolStripMenuItem();
            this.tsmnuViewTypeCours = new ToolStripMenuItem();
            this.toolStripSeparator6 = new ToolStripSeparator();
            this.tsmnuViewModuleBar = new ToolStripMenuItem();
            this.toolStripSeparator12 = new ToolStripSeparator();
            this.listeDesClientsToolStripMenuItem = new ToolStripMenuItem();
            this.automobileToolStripMenuItem = new ToolStripMenuItem();
            this.motoToolStripMenuItem = new ToolStripMenuItem();
            this.cyclomoteurToolStripMenuItem = new ToolStripMenuItem();
            this.tsmnuModule = new ToolStripMenuItem();
            this.tsmnuModuleClient = new ToolStripMenuItem();
            this.tsmnuModuleEmployer = new ToolStripMenuItem();
            this.tsmnuModuleFinance = new ToolStripMenuItem();
            this.tsmnuModuleHoraire = new ToolStripMenuItem();
            this.tsmnuModuleGroupe = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.toolStripMenuItem12 = new ToolStripMenuItem();
            this.toolStripSeparator4 = new ToolStripSeparator();
            this.tsmnuModuleSuivie = new ToolStripMenuItem();
            this.tsmnuModuleStatistiques = new ToolStripMenuItem();
            this.tsmnuModuleNotes = new ToolStripMenuItem();
            this.toolStripSeparator3 = new ToolStripSeparator();
            this.tsmnuModuleFind = new ToolStripMenuItem();
            this.tsmnuTools = new ToolStripMenuItem();
            this.tsmnuToolCodes = new ToolStripMenuItem();
            this.tsmnuOffDate = new ToolStripMenuItem();
            this.tsmnuSchoolInfo = new ToolStripMenuItem();
            this.toolStripSeparator11 = new ToolStripSeparator();
            this.tsmnuAutoCompletedCustomer = new ToolStripMenuItem();
            this.toolStripSeparator5 = new ToolStripSeparator();
            this.tsmnuBackup = new ToolStripMenuItem();
            this.toolStripSeparator7 = new ToolStripSeparator();
            this.tsmnuToolsDialog = new ToolStripMenuItem();
            this.toolStripMenuItem13 = new ToolStripMenuItem();
            this.tsmnuAboutDialog = new ToolStripMenuItem();
            this.toolStripContainer1 = new ToolStripContainer();
            this.tabGroup = new TabbedGroups();
            this.splitter1 = new Splitter();
            this.outLookBar = new OutlookBar();
            this.outBandGestion = new OutlookBarBand();
            this.openFileDialogImport = new OpenFileDialog();
            this.tsmnuViewCoursFinish = new ToolStripMenuItem();
            this.toolStripSeparator13 = new ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.tabGroup).BeginInit();
            this.SuspendLayout();
            // 
            // OutlookBarImageList
            // 
            this.OutlookBarImageList.ImageStream = (ImageListStreamer)resources.GetObject("OutlookBarImageList.ImageStream");
            this.OutlookBarImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.OutlookBarImageList.Images.SetKeyName(0, "user-group-icon.png");
            this.OutlookBarImageList.Images.SetKeyName(1, "search-icon.png");
            this.OutlookBarImageList.Images.SetKeyName(2, "Save-icon.png");
            this.OutlookBarImageList.Images.SetKeyName(3, "");
            this.OutlookBarImageList.Images.SetKeyName(4, "calendar-date-icon.png");
            this.OutlookBarImageList.Images.SetKeyName(5, "coins-icon.png");
            this.OutlookBarImageList.Images.SetKeyName(6, "Client-icon");
            this.OutlookBarImageList.Images.SetKeyName(7, "Notes2.png");
            this.OutlookBarImageList.Images.SetKeyName(8, "app-attention-icon.png");
            this.OutlookBarImageList.Images.SetKeyName(9, "book");
            this.OutlookBarImageList.Images.SetKeyName(10, "Group-Folder-icon.png");
            this.OutlookBarImageList.Images.SetKeyName(11, "statistics-icon.png");
            // 
            // PostItAlertTimer
            // 
            this.PostItAlertTimer.Enabled = true;
            this.PostItAlertTimer.Interval = 800;
            this.PostItAlertTimer.Tick += new EventHandler(this.PostItAlertTimer_Tick);
            // 
            // folderDialogBackup
            // 
            this.folderDialogBackup.Description = "Sélectionnez le répertoire pour votre copie de sauvegarde.";
            this.folderDialogBackup.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tsmnuView,
            this.tsmnuModule,
            this.tsmnuTools,
            this.toolStripMenuItem13});
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(1016, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] {
            this.tsmnuAdd,
            this.toolStripSeparator9,
            this.tsmnuOpen,
            this.tsmnuEnregistrer,
            this.tsmnuEnregistrerSous,
            this.toolStripSeparator1,
            this.tsmnuImportExport,
            this.toolStripSeparator8,
            this.tsmnuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new Size(54, 20);
            this.toolStripMenuItem1.Text = "Fichier";
            // 
            // tsmnuAdd
            // 
            this.tsmnuAdd.DropDownItems.AddRange(new ToolStripItem[] {
            this.tsmnuAddCustomer,
            this.tsmnuAddEmployer});
            this.tsmnuAdd.Name = "tsmnuAdd";
            this.tsmnuAdd.Size = new Size(186, 22);
            this.tsmnuAdd.Text = "Ajouter";
            // 
            // tsmnuAddCustomer
            // 
            this.tsmnuAddCustomer.Name = "tsmnuAddCustomer";
            this.tsmnuAddCustomer.Size = new Size(133, 22);
            this.tsmnuAddCustomer.Text = "Client...";
            this.tsmnuAddCustomer.Click += new EventHandler(this.tsmnuAddCustomer_Click);
            // 
            // tsmnuAddEmployer
            // 
            this.tsmnuAddEmployer.Enabled = false;
            this.tsmnuAddEmployer.Name = "tsmnuAddEmployer";
            this.tsmnuAddEmployer.Size = new Size(133, 22);
            this.tsmnuAddEmployer.Text = "Employer...";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new Size(183, 6);
            // 
            // tsmnuOpen
            // 
            this.tsmnuOpen.Name = "tsmnuOpen";
            this.tsmnuOpen.Size = new Size(186, 22);
            this.tsmnuOpen.Text = "Ouvrir";
            this.tsmnuOpen.Click += new EventHandler(this.tsmnuOpen_Click);
            // 
            // tsmnuEnregistrer
            // 
            this.tsmnuEnregistrer.Image = global::Barette.IDE.Properties.Resources.Save_icon;
            this.tsmnuEnregistrer.Name = "tsmnuEnregistrer";
            this.tsmnuEnregistrer.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            this.tsmnuEnregistrer.Size = new Size(186, 22);
            this.tsmnuEnregistrer.Text = "Enregistrer";
            this.tsmnuEnregistrer.Click += new EventHandler(this.tsmnuEnregistrer_Click);
            // 
            // tsmnuEnregistrerSous
            // 
            this.tsmnuEnregistrerSous.Enabled = false;
            this.tsmnuEnregistrerSous.Name = "tsmnuEnregistrerSous";
            this.tsmnuEnregistrerSous.Size = new Size(186, 22);
            this.tsmnuEnregistrerSous.Text = "Enregistrer sous...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(183, 6);
            // 
            // tsmnuImportExport
            // 
            this.tsmnuImportExport.DropDownItems.AddRange(new ToolStripItem[] {
            this.tsmnuExport,
            this.tsmnuImport,
            this.toolStripSeparator10,
            this.tsmnuImportBackup});
            this.tsmnuImportExport.Name = "tsmnuImportExport";
            this.tsmnuImportExport.Size = new Size(186, 22);
            this.tsmnuImportExport.Text = "Importer / Exporter ...";
            // 
            // tsmnuExport
            // 
            this.tsmnuExport.Enabled = false;
            this.tsmnuExport.Image = global::Barette.IDE.Properties.Resources.export_icon;
            this.tsmnuExport.Name = "tsmnuExport";
            this.tsmnuExport.Size = new Size(290, 22);
            this.tsmnuExport.Text = "Exporter des clients vers un fichier...";
            this.tsmnuExport.Click += new EventHandler(this.tsmnuExport_Click);
            // 
            // tsmnuImport
            // 
            this.tsmnuImport.Enabled = false;
            this.tsmnuImport.Image = global::Barette.IDE.Properties.Resources.import_icon;
            this.tsmnuImport.Name = "tsmnuImport";
            this.tsmnuImport.Size = new Size(290, 22);
            this.tsmnuImport.Text = "Importer des clients à partir d\'un fichier...";
            this.tsmnuImport.Click += new EventHandler(this.tsmnuImport_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new Size(287, 6);
            // 
            // tsmnuImportBackup
            // 
            this.tsmnuImportBackup.Image = global::Barette.IDE.Properties.Resources.import_icon;
            this.tsmnuImportBackup.Name = "tsmnuImportBackup";
            this.tsmnuImportBackup.Size = new Size(290, 22);
            this.tsmnuImportBackup.Text = "Importer un fichier de sauvegarde...";
            this.tsmnuImportBackup.Click += new EventHandler(this.tsmnuImportBackup_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new Size(183, 6);
            // 
            // tsmnuItem
            // 
            this.tsmnuItem.Image = global::Barette.IDE.Properties.Resources.Log_Out_icon;
            this.tsmnuItem.Name = "tsmnuItem";
            this.tsmnuItem.Size = new Size(186, 22);
            this.tsmnuItem.Text = "Quitter";
            this.tsmnuItem.Click += new EventHandler(this.tsmnuItem_Click);
            // 
            // tsmnuView
            // 
            this.tsmnuView.DropDownItems.AddRange(new ToolStripItem[] {
            this.tsmnuViewModuleClient,
            this.toolStripSeparator6,
            this.tsmnuViewModuleBar,
            this.toolStripSeparator12,
            this.listeDesClientsToolStripMenuItem});
            this.tsmnuView.Name = "tsmnuView";
            this.tsmnuView.Size = new Size(70, 20);
            this.tsmnuView.Text = "Affichage";
            // 
            // tsmnuViewModuleClient
            // 
            this.tsmnuViewModuleClient.DropDownItems.AddRange(new ToolStripItem[] {
            this.tsmnuViewTypeCours});
            this.tsmnuViewModuleClient.Name = "tsmnuViewModuleClient";
            this.tsmnuViewModuleClient.Size = new Size(228, 22);
            this.tsmnuViewModuleClient.Text = "Gestion des clients";
            // 
            // tsmnuViewTypeCours
            // 
            this.tsmnuViewTypeCours.Name = "tsmnuViewTypeCours";
            this.tsmnuViewTypeCours.Size = new Size(210, 22);
            this.tsmnuViewTypeCours.Text = "Afficher par type de cours";
            this.tsmnuViewTypeCours.Click += new EventHandler(this.tsmnuViewTypeCours_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new Size(225, 6);
            // 
            // tsmnuViewModuleBar
            // 
            this.tsmnuViewModuleBar.Checked = true;
            this.tsmnuViewModuleBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmnuViewModuleBar.Name = "tsmnuViewModuleBar";
            this.tsmnuViewModuleBar.Size = new Size(228, 22);
            this.tsmnuViewModuleBar.Text = "Afficher la barre des modules";
            this.tsmnuViewModuleBar.Click += new EventHandler(this.tsmnuViewModuleBar_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new Size(225, 6);
            // 
            // listeDesClientsToolStripMenuItem
            // 
            this.listeDesClientsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.tsmnuViewCoursFinish,
            this.toolStripSeparator13,
            this.automobileToolStripMenuItem,
            this.motoToolStripMenuItem,
            this.cyclomoteurToolStripMenuItem});
            this.listeDesClientsToolStripMenuItem.Name = "listeDesClientsToolStripMenuItem";
            this.listeDesClientsToolStripMenuItem.Size = new Size(228, 22);
            this.listeDesClientsToolStripMenuItem.Text = "Liste des clients";
            // 
            // automobileToolStripMenuItem
            // 
            this.automobileToolStripMenuItem.Checked = true;
            this.automobileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.automobileToolStripMenuItem.Name = "automobileToolStripMenuItem";
            this.automobileToolStripMenuItem.Size = new Size(315, 22);
            this.automobileToolStripMenuItem.Text = "Automobile";
            this.automobileToolStripMenuItem.Click += new EventHandler(this.automobileToolStripMenuItem_Click);
            // 
            // motoToolStripMenuItem
            // 
            this.motoToolStripMenuItem.Checked = true;
            this.motoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.motoToolStripMenuItem.Name = "motoToolStripMenuItem";
            this.motoToolStripMenuItem.Size = new Size(315, 22);
            this.motoToolStripMenuItem.Text = "Moto";
            this.motoToolStripMenuItem.Click += new EventHandler(this.motoToolStripMenuItem_Click);
            // 
            // cyclomoteurToolStripMenuItem
            // 
            this.cyclomoteurToolStripMenuItem.Checked = true;
            this.cyclomoteurToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cyclomoteurToolStripMenuItem.Name = "cyclomoteurToolStripMenuItem";
            this.cyclomoteurToolStripMenuItem.Size = new Size(315, 22);
            this.cyclomoteurToolStripMenuItem.Text = "Cyclomoteur";
            this.cyclomoteurToolStripMenuItem.Click += new EventHandler(this.cyclomoteurToolStripMenuItem_Click);
            // 
            // tsmnuModule
            // 
            this.tsmnuModule.DropDownItems.AddRange(new ToolStripItem[] {
            this.tsmnuModuleClient,
            this.tsmnuModuleEmployer,
            this.tsmnuModuleFinance,
            this.tsmnuModuleHoraire,
            this.tsmnuModuleGroupe,
            this.toolStripSeparator2,
            this.toolStripMenuItem12,
            this.toolStripSeparator4,
            this.tsmnuModuleSuivie,
            this.tsmnuModuleStatistiques,
            this.tsmnuModuleNotes,
            this.toolStripSeparator3,
            this.tsmnuModuleFind});
            this.tsmnuModule.Name = "tsmnuModule";
            this.tsmnuModule.Size = new Size(65, 20);
            this.tsmnuModule.Text = "Modules";
            // 
            // tsmnuModuleClient
            // 
            this.tsmnuModuleClient.Image = global::Barette.IDE.Properties.Resources.user_group_icon;
            this.tsmnuModuleClient.Name = "tsmnuModuleClient";
            this.tsmnuModuleClient.Size = new Size(227, 22);
            this.tsmnuModuleClient.Text = "Gestion des clients";
            this.tsmnuModuleClient.Click += new EventHandler(this.tsmnuModuleClient_Click);
            // 
            // tsmnuModuleEmployer
            // 
            this.tsmnuModuleEmployer.Image = global::Barette.IDE.Properties.Resources.Client_icon;
            this.tsmnuModuleEmployer.Name = "tsmnuModuleEmployer";
            this.tsmnuModuleEmployer.Size = new Size(227, 22);
            this.tsmnuModuleEmployer.Text = "Gestion des employés";
            this.tsmnuModuleEmployer.Click += new EventHandler(this.tsmnuModuleEmployer_Click);
            // 
            // tsmnuModuleFinance
            // 
            this.tsmnuModuleFinance.Image = global::Barette.IDE.Properties.Resources.coins_icon;
            this.tsmnuModuleFinance.Name = "tsmnuModuleFinance";
            this.tsmnuModuleFinance.Size = new Size(227, 22);
            this.tsmnuModuleFinance.Text = "Gestion des finances";
            this.tsmnuModuleFinance.Click += new EventHandler(this.tsmnuModuleFinance_Click);
            // 
            // tsmnuModuleHoraire
            // 
            this.tsmnuModuleHoraire.Image = global::Barette.IDE.Properties.Resources.calendar_date_icon;
            this.tsmnuModuleHoraire.Name = "tsmnuModuleHoraire";
            this.tsmnuModuleHoraire.Size = new Size(227, 22);
            this.tsmnuModuleHoraire.Text = "Gestion des horaires";
            this.tsmnuModuleHoraire.Click += new EventHandler(this.tsmnuModuleHoraire_Click);
            // 
            // tsmnuModuleGroupe
            // 
            this.tsmnuModuleGroupe.Image = global::Barette.IDE.Properties.Resources.Group_Folder_icon;
            this.tsmnuModuleGroupe.Name = "tsmnuModuleGroupe";
            this.tsmnuModuleGroupe.Size = new Size(227, 22);
            this.tsmnuModuleGroupe.Text = "Gestion des groupes d\'élèves";
            this.tsmnuModuleGroupe.Click += new EventHandler(this.tsmnuModuleGroupe_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(224, 6);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Image = global::Barette.IDE.Properties.Resources.app_attention_icon;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new Size(227, 22);
            this.toolStripMenuItem12.Text = "Ligue de sécurité du Québec";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new Size(224, 6);
            // 
            // tsmnuModuleSuivie
            // 
            this.tsmnuModuleSuivie.Image = global::Barette.IDE.Properties.Resources.book_icon;
            this.tsmnuModuleSuivie.Name = "tsmnuModuleSuivie";
            this.tsmnuModuleSuivie.Size = new Size(227, 22);
            this.tsmnuModuleSuivie.Text = "Suivie des cours automobiles";
            this.tsmnuModuleSuivie.Click += new EventHandler(this.tsmnuModuleSuivie_Click);
            // 
            // tsmnuModuleStatistiques
            // 
            this.tsmnuModuleStatistiques.Image = global::Barette.IDE.Properties.Resources.statistics_icon;
            this.tsmnuModuleStatistiques.Name = "tsmnuModuleStatistiques";
            this.tsmnuModuleStatistiques.Size = new Size(227, 22);
            this.tsmnuModuleStatistiques.Text = "Statistiques";
            this.tsmnuModuleStatistiques.Click += new EventHandler(this.tsmnuModuleStatistiques_Click);
            // 
            // tsmnuModuleNotes
            // 
            this.tsmnuModuleNotes.Image = global::Barette.IDE.Properties.Resources.FauxS_32_32;
            this.tsmnuModuleNotes.Name = "tsmnuModuleNotes";
            this.tsmnuModuleNotes.Size = new Size(227, 22);
            this.tsmnuModuleNotes.Text = "Notes";
            this.tsmnuModuleNotes.Click += new EventHandler(this.tsmnuModuleNotes_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new Size(224, 6);
            // 
            // tsmnuModuleFind
            // 
            this.tsmnuModuleFind.Image = global::Barette.IDE.Properties.Resources.search_icon;
            this.tsmnuModuleFind.Name = "tsmnuModuleFind";
            this.tsmnuModuleFind.Size = new Size(227, 22);
            this.tsmnuModuleFind.Text = "Recherche";
            this.tsmnuModuleFind.Click += new EventHandler(this.tsmnuModuleFind_Click);
            // 
            // tsmnuTools
            // 
            this.tsmnuTools.DropDownItems.AddRange(new ToolStripItem[] {
            this.tsmnuToolCodes,
            this.tsmnuOffDate,
            this.tsmnuSchoolInfo,
            this.toolStripSeparator11,
            this.tsmnuAutoCompletedCustomer,
            this.toolStripSeparator5,
            this.tsmnuBackup,
            this.toolStripSeparator7,
            this.tsmnuToolsDialog});
            this.tsmnuTools.Name = "tsmnuTools";
            this.tsmnuTools.Size = new Size(50, 20);
            this.tsmnuTools.Text = "Outils";
            // 
            // tsmnuToolCodes
            // 
            this.tsmnuToolCodes.Name = "tsmnuToolCodes";
            this.tsmnuToolCodes.Size = new Size(273, 22);
            this.tsmnuToolCodes.Text = "Liste de codes de séances...";
            this.tsmnuToolCodes.Click += new EventHandler(this.tsmnuToolCodes_Click);
            // 
            // tsmnuOffDate
            // 
            this.tsmnuOffDate.Name = "tsmnuOffDate";
            this.tsmnuOffDate.Size = new Size(273, 22);
            this.tsmnuOffDate.Text = "Jour fériés...";
            this.tsmnuOffDate.Click += new EventHandler(this.tsmnuOffDate_Click);
            // 
            // tsmnuSchoolInfo
            // 
            this.tsmnuSchoolInfo.Name = "tsmnuSchoolInfo";
            this.tsmnuSchoolInfo.Size = new Size(273, 22);
            this.tsmnuSchoolInfo.Text = "Informations sur l\'école de conduite...";
            this.tsmnuSchoolInfo.Click += new EventHandler(this.tsmnuSchoolInfo_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new Size(270, 6);
            // 
            // tsmnuAutoCompletedCustomer
            // 
            this.tsmnuAutoCompletedCustomer.Name = "tsmnuAutoCompletedCustomer";
            this.tsmnuAutoCompletedCustomer.Size = new Size(273, 22);
            this.tsmnuAutoCompletedCustomer.Text = "Terminé tous les cours expiré";
            this.tsmnuAutoCompletedCustomer.Click += new EventHandler(this.tsmnuAutoCompletedCustomer_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new Size(270, 6);
            // 
            // tsmnuBackup
            // 
            this.tsmnuBackup.Image = global::Barette.IDE.Properties.Resources.Archive_icon;
            this.tsmnuBackup.Name = "tsmnuBackup";
            this.tsmnuBackup.Size = new Size(273, 22);
            this.tsmnuBackup.Text = "Faire une copie de sauvegarde...";
            this.tsmnuBackup.Click += new EventHandler(this.tsmnuBackup_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new Size(270, 6);
            // 
            // tsmnuToolsDialog
            // 
            this.tsmnuToolsDialog.Enabled = false;
            this.tsmnuToolsDialog.Name = "tsmnuToolsDialog";
            this.tsmnuToolsDialog.Size = new Size(273, 22);
            this.tsmnuToolsDialog.Text = "Options ...";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.DropDownItems.AddRange(new ToolStripItem[] {
            this.tsmnuAboutDialog});
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new Size(24, 20);
            this.toolStripMenuItem13.Text = "&?";
            // 
            // tsmnuAboutDialog
            // 
            this.tsmnuAboutDialog.Enabled = false;
            this.tsmnuAboutDialog.Name = "tsmnuAboutDialog";
            this.tsmnuAboutDialog.Size = new Size(150, 22);
            this.tsmnuAboutDialog.Text = "A propos de ...";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabGroup);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitter1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.outLookBar);
            this.toolStripContainer1.ContentPanel.Size = new Size(1016, 622);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new Size(1016, 647);
            this.toolStripContainer1.TabIndex = 7;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // tabGroup
            // 
            this.tabGroup.AllowDrop = true;
            this.tabGroup.AtLeastOneLeaf = true;
            this.tabGroup.CloseMenuText = "&Fermé";
            this.tabGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGroup.LayoutLock = true;
            this.tabGroup.Location = new Point(178, 0);
            this.tabGroup.Name = "tabGroup";
            this.tabGroup.ProminentLeaf = null;
            this.tabGroup.ResizeBarColor = System.Drawing.SystemColors.Control;
            this.tabGroup.Size = new Size(838, 622);
            this.tabGroup.TabIndex = 7;
            // 
            // splitter1
            // 
            this.splitter1.Location = new Point(175, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new Size(3, 622);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            this.splitter1.DoubleClick += new EventHandler(this.splitter1_DoubleClick);
            // 
            // outLookBar
            // 
            this.outLookBar.AnimationSpeed = 20;
            this.outLookBar.BackgroundBitmap = null;
            this.outLookBar.Bands.Add(this.outBandGestion);
            this.outLookBar.BorderType = UtilityLibrary.WinControls.BorderType.None;
            this.outLookBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.outLookBar.FlatArrowButtons = false;
            this.outLookBar.Font = new Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.outLookBar.LeftTopColor = System.Drawing.Color.Empty;
            this.outLookBar.Location = new Point(0, 0);
            this.outLookBar.Name = "outLookBar";
            this.outLookBar.RightBottomColor = System.Drawing.Color.Empty;
            this.outLookBar.Size = new Size(175, 622);
            this.outLookBar.TabIndex = 5;
            this.outLookBar.ItemClicked += new OutlookBarItemClickedHandler(this.outLookBar_ItemClicked);
            // 
            // outBandGestion
            // 
            this.outBandGestion.Background = System.Drawing.Color.FromArgb(239, 239, 233);
            this.outBandGestion.IconView = UtilityLibrary.WinControls.IconView.Large;
            this.outBandGestion.LargeImageList = this.OutlookBarImageList;
            this.outBandGestion.Location = new Point(0, 0);
            this.outBandGestion.Name = "outBandGestion";
            this.outBandGestion.Size = new Size(0, 0);
            this.outBandGestion.SmallImageList = null;
            this.outBandGestion.TabIndex = 0;
            this.outBandGestion.Text = "Modules";
            this.outBandGestion.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // openFileDialogImport
            // 
            this.openFileDialogImport.Filter = "Fichier de sauvegarde Gestion Auto École|*.gaec";
            this.openFileDialogImport.Title = "Ouvrir un fichier de sauvegarde";
            // 
            // tsmnuViewCoursFinish
            // 
            this.tsmnuViewCoursFinish.Name = "tsmnuViewCoursFinish";
            this.tsmnuViewCoursFinish.Size = new Size(315, 22);
            this.tsmnuViewCoursFinish.Text = "Afficher les clients qui ont terminé leurs cours";
            this.tsmnuViewCoursFinish.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsmnuViewCoursFinish.Click += new EventHandler(this.tsmnuViewCoursFinish_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new Size(312, 6);
            // 
            // FormMain
            // 
            this.ClientSize = new Size(1016, 671);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Auto École 2010";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.FormMain_Closing);
            this.FormClosed += new FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.tabGroup).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private void MakeStaticBorder()
        {
            StaticBorder.ThinBorder(outLookBar.Handle.ToInt32(), true);
        }

        /// <summary>
        /// Refresh la list des client
        /// </summary>
        public void RefreshClientList()
        {
            if (_formClients != null)
            {
                _formClients.RefreshClientList(_AppConfig);
                _formClients.RefreshFindList();
            }
        }


        /// <summary>
        /// Ferme le client qui est ouvert dans le formulaire
        /// </summary>
        public void CloseClient()
        {
            if (_formClients != null)
                _formClients.CloseClient();
        }

        /// <summary>
        /// Initialise la bar de gestion des employés
        /// </summary>
        private void InitializeBandGestion()
        {
            //Creation des objet
            OutlookBarItem outBarClient = new OutlookBarItem("Gestion des clients", 0);
            OutlookBarItem outBarFindClient = new OutlookBarItem("Recherche", 1);
            OutlookBarItem outBarSave = new OutlookBarItem("Enregistrer", 2);
            OutlookBarItem outBarSuivie = new OutlookBarItem("Suivie de cours Automobile", 9);
            OutlookBarItem outBarSuivieMoto = new OutlookBarItem("Suivie de cours Moto", 9);
            OutlookBarItem outBarHoraire = new OutlookBarItem("Horaires", 4);
            OutlookBarItem outBarFinance = new OutlookBarItem("Finances", 5);
            OutlookBarItem outBarEmploye = new OutlookBarItem("Gestion des employés", 6);
            OutlookBarItem outBarPostIt = new OutlookBarItem("Notes", 7);
            OutlookBarItem outBarLigueSecur = new OutlookBarItem("Ligue Securité", 8);
            OutlookBarItem outBarGestionGroupe = new OutlookBarItem("Gestion des groupes d'élèves", 10);
            OutlookBarItem outBarStats = new OutlookBarItem("Statistiques", 11);

            //Tag qui determine quel bouton est pesé
            outBarClient.Tag = "CLIENT";
            outBarFindClient.Tag = "FINDCLIENT";
            outBarSave.Tag = "SAVE";
            outBarSuivie.Tag = "SUIVIE";
            outBarSuivieMoto.Tag = "SUIVIEMOTO";
            outBarHoraire.Tag = "HORAIRE";
            outBarFinance.Tag = "FINANCE";
            outBarEmploye.Tag = "EMPLOYE";
            outBarPostIt.Tag = "POSTIT";
            outBarLigueSecur.Tag = "RAPPORTSECUR";
            outBarGestionGroupe.Tag = "GROUPELEVE";
            outBarStats.Tag = "STATS";

            //Configuration de la bar style outlook
            outBandGestion.Background = Color.LightGray;
            outBandGestion.TextColor = Color.Black;
            outBandGestion.Items.Add(outBarClient);
            outBandGestion.Items.Add(outBarGestionGroupe);            
            outBandGestion.Items.Add(outBarFinance);
            outBandGestion.Items.Add(outBarHoraire);
            outBandGestion.Items.Add(outBarLigueSecur);            
            outBandGestion.Items.Add(outBarSuivieMoto);
            outBandGestion.Items.Add(outBarSuivie);
            outBandGestion.Items.Add(outBarStats);
            outBandGestion.Items.Add(outBarPostIt);
            outBandGestion.Items.Add(outBarEmploye);
            outBandGestion.Items.Add(outBarFindClient);
            outBandGestion.Items.Add(outBarSave);
        }

        /// <summary>
        /// Configuration de l'application
        /// </summary>
        public Config AppConfig
        {
            get
            {
                return _AppConfig;
            }
            set
            {
                _AppConfig = value;
            }
        }

        private void outLookBar_ItemClicked(OutlookBarBand band, OutlookBarItem item)
        {
            Cursor.Current = Cursors.WaitCursor;

            switch (item.Tag.ToString())
            {
                case "CLIENT":
                    CreationListClient();
                    break;
                case "SAVE":
                    SaveAll();
                    break;
                case "HORAIRE":
                    CreationHoraire();
                    break;
                case "SUIVIE":
                    CreationSuivie();
                    break;
                case "SUIVIEMOTO":
                    CreationSuivieMoto();
                    break;
                case "FINDCLIENT":
                    CreationFindClient();
                    break;
                case "FINANCE":
                    CreationFinance();
                    break;
                case "EMPLOYE":
                    CreationEmploye();
                    break;
                case "POSTIT":
                    CreationPostIt();
                    break;
                case "RAPPORTSECUR":
                    CreationLigueSecur();
                    break;
                case "GROUPELEVE":
                    CreationGestionGroupe();
                    break;
                case "STATS":
                    CreationStats();
                    break;

            }

            Cursor.Current = Cursors.Default;
        }

        private void CreationSuivie()
        {
            // Créé un access a la premiere page page du group
            TabGroupLeaf tgl = tabGroup.RootSequence[0] as TabGroupLeaf;
            bool exist = false;

            //Verifie que l'extracteur n'est pas deja ouvert
            foreach (Crownwood.Magic.Controls.TabPage page in tgl.TabPages)
            {
                if (page.Tag.ToString() == "SUIVIE")
                {
                    exist = true;
                    page.Selected = true;
                }
            }

            //Creation de la fenetre client si il n'existe pas
            if (!exist)
            {
                _formSuivieCours = new FormSuivieCours(ClientList, this);

                // Cree la page
                Crownwood.Magic.Controls.TabPage tp1 =
                    new Crownwood.Magic.Controls.TabPage("Suivie des cours Automobile", _formSuivieCours)
                    {
                        Tag = "SUIVIE",
                        ImageList = OutlookBarImageList,
                        ImageIndex = 9,
                        Selected = true
                    };

                // ajouter la page au groupe
                tgl.TabPages.Add(tp1);
            }
        }

        private void CreationSuivieMoto()
        {
            // Créé un access a la premiere page page du group
            TabGroupLeaf tgl = tabGroup.RootSequence[0] as TabGroupLeaf;
            bool exist = false;

            //Verifie que l'extracteur n'est pas deja ouvert
            foreach (Crownwood.Magic.Controls.TabPage page in tgl.TabPages)
            {
                if (page.Tag.ToString() == "SUIVIEMOTO")
                {
                    exist = true;
                    page.Selected = true;
                }
            }

            //Creation de la fenetre client si il n'existe pas
            if (!exist)
            {
                _formSuivieCoursMoto = new FormSuivieCoursMoto2015(ClientList, this);

                // Cree la page
                Crownwood.Magic.Controls.TabPage tp1 =
                    new Crownwood.Magic.Controls.TabPage("Suivie des cours Moto", _formSuivieCoursMoto)
                    {
                        Tag = "SUIVIEMOTO",
                        ImageList = OutlookBarImageList,
                        ImageIndex = 9,
                        Selected = true
                    };

                // ajouter la page au groupe
                tgl.TabPages.Add(tp1);
            }
        }

        /// <summary>
        /// Creation de la fenetre des clients
        /// </summary>
        private void CreationListClient()
        {
            // Créé un access a la premiere page page du group
            TabGroupLeaf tgl = tabGroup.RootSequence[0] as TabGroupLeaf;
            bool exist = false;

            //Verifie que l'extracteur n'est pas deja ouvert
            foreach (Crownwood.Magic.Controls.TabPage page in tgl.TabPages)
            {
                if (page.Tag.ToString() == "CLIENT_LIST")
                {
                    exist = true;
                    page.Selected = true;
                }
            }

            //Creation de la fenetre client si il n'existe pas
            if (!exist)
            {
                _formClients = new FormClients(ClientList, EmployeList, _InfoSchool, _AppConfig);

                // Cree la page
                Crownwood.Magic.Controls.TabPage tp1 =
                    new Crownwood.Magic.Controls.TabPage("Gestion des Clients", _formClients)
                    {
                        Tag = "CLIENT_LIST",
                        ImageList = OutlookBarImageList,
                        ImageIndex = 0,
                        Selected = true
                    };

                // ajouter la page au groupe
                tgl.TabPages.Add(tp1);
            }
        }

        /// <summary>
        /// Creation de la fenetre des clients
        /// </summary>
        private void CreationLigueSecur()
        {
            // Créé un access a la premiere page page du group
            TabGroupLeaf tgl = tabGroup.RootSequence[0] as TabGroupLeaf;
            bool exist = false;

            //Verifie que l'extracteur n'est pas deja ouvert
            foreach (Crownwood.Magic.Controls.TabPage page in tgl.TabPages)
            {
                if (page.Tag.ToString() == "RAPPORTSECUR")
                {
                    exist = true;
                    page.Selected = true;
                }
            }

            //Creation de la fenetre client si il n'existe pas
            if (!exist)
            {
                _formLigueSecuriter = new FormLigueSecuriter(this);

                // Cree la page
                Crownwood.Magic.Controls.TabPage tp1 =
                    new Crownwood.Magic.Controls.TabPage("Ligue de Securité", _formLigueSecuriter)
                    {
                        Tag = "RAPPORTSECUR",
                        ImageList = OutlookBarImageList,
                        ImageIndex = 8,
                        Selected = true
                    };

                // ajouter la page au groupe
                tgl.TabPages.Add(tp1);
            }
        }

        /// <summary>
        /// Ouvre la boite des client et selectionne le client passer en argument.
        /// </summary>
        /// <param name="ClientNumber"></param>
        public void CreationListClient(string ClientNumber)
        {
            CreationListClient();
            _formClients.SelectionClient(ClientNumber);
        }

        /// <summary>
        /// Creation de la fenetre des clients
        /// </summary>
        private void CreationFindClient()
        {
            // Créé un access a la premiere page page du group
            TabGroupLeaf tgl = tabGroup.RootSequence[0] as TabGroupLeaf;
            bool exist = false;

            //Verifie que l'extracteur n'est pas deja ouvert
            foreach (Crownwood.Magic.Controls.TabPage page in tgl.TabPages)
            {
                if (page.Tag.ToString() == "FIND_CLIENT")
                {
                    exist = true;
                    page.Selected = true;
                }
            }

            //Creation de la fenetre client si il n'existe pas
            if (!exist)
            {
                _formFindClient = new FormFindClient(this, EmployeList);

                // Cree la page
                Crownwood.Magic.Controls.TabPage tp1 =
                    new Crownwood.Magic.Controls.TabPage("Recherche de client", _formFindClient)
                    {
                        Tag = "FIND_CLIENT",
                        ImageList = OutlookBarImageList,
                        ImageIndex = 1,
                        Selected = true
                    };

                // ajouter la page au groupe
                tgl.TabPages.Add(tp1);
            }
        }

        /// <summary>
        /// Creation de la fenetre des clients
        /// </summary>
        private void CreationFinance()
        {
            // Créé un access a la premiere page page du group
            TabGroupLeaf tgl = tabGroup.RootSequence[0] as TabGroupLeaf;
            bool exist = false;

            //Verifie que l'extracteur n'est pas deja ouvert
            foreach (Crownwood.Magic.Controls.TabPage page in tgl.TabPages)
            {
                if (page.Tag.ToString() == "FINANCE")
                {
                    exist = true;
                    page.Selected = true;
                }
            }

            //Creation de la fenetre client si il n'existe pas
            if (!exist)
            {
                _formFinance = new FormFinance(this);

                // Cree la page
                Crownwood.Magic.Controls.TabPage tp1 =
                    new Crownwood.Magic.Controls.TabPage("Finances", _formFinance)
                    {
                        Tag = "FINANCE",
                        ImageList = OutlookBarImageList,
                        ImageIndex = 5,
                        Selected = true
                    };

                // ajouter la page au groupe
                tgl.TabPages.Add(tp1);
            }
        }

        /// <summary>
        /// Creation de la fenetre des clients
        /// </summary>
        private void CreationEmploye()
        {
            // Créé un access a la premiere page page du group
            TabGroupLeaf tgl = tabGroup.RootSequence[0] as TabGroupLeaf;
            bool exist = false;

            //Verifie que l'extracteur n'est pas deja ouvert
            foreach (Crownwood.Magic.Controls.TabPage page in tgl.TabPages)
            {
                if (page.Tag.ToString() == "EMPLOYE")
                {
                    exist = true;
                    page.Selected = true;
                }
            }

            //Creation de la fenetre client si il n'existe pas
            if (!exist)
            {
                _formEmploye = new FormEmploye(this);

                // Cree la page
                Crownwood.Magic.Controls.TabPage tp1 =
                    new Crownwood.Magic.Controls.TabPage("Gestion des Employés", _formEmploye)
                    {
                        Tag = "EMPLOYE",
                        ImageList = OutlookBarImageList,
                        ImageIndex = 6,
                        Selected = true
                    };

                // ajouter la page au groupe
                tgl.TabPages.Add(tp1);
            }
        }

        /// <summary>
        /// Creation de la fenetre des statistique
        /// </summary>
        private void CreationStats()
        {
            // Créé un access a la premiere page page du group
            TabGroupLeaf tgl = tabGroup.RootSequence[0] as TabGroupLeaf;
            bool exist = false;

            //Verifie que l'extracteur n'est pas deja ouvert
            foreach (Crownwood.Magic.Controls.TabPage page in tgl.TabPages)
            {
                if (page.Tag.ToString() == "STATS")
                {
                    exist = true;
                    page.Selected = true;
                }
            }

            //Creation de la fenetre client si il n'existe pas
            if (!exist)
            {
                _formStatistique = new FormStatistiques(ClientList);

                // Cree la page
                Crownwood.Magic.Controls.TabPage tp1 =
                    new Crownwood.Magic.Controls.TabPage("Statistiques", _formStatistique)
                    {
                        Tag = "STATS",
                        ImageList = OutlookBarImageList,
                        ImageIndex = 11,
                        Selected = true
                    };

                // ajouter la page au groupe
                tgl.TabPages.Add(tp1);
            }
        }

        /// <summary>
        /// Creation de la fenetre des clients
        /// </summary>
        private void CreationPostIt()
        {
            // Créé un access a la premiere page page du group
            TabGroupLeaf tgl = tabGroup.RootSequence[0] as TabGroupLeaf;
            bool exist = false;

            //Verifie que l'extracteur n'est pas deja ouvert
            foreach (Crownwood.Magic.Controls.TabPage page in tgl.TabPages)
            {
                if (page.Tag.ToString() == "POSTIT")
                {
                    exist = true;
                    page.Selected = true;
                }
            }

            //Creation de la fenetre client si il n'existe pas
            if (!exist)
            {
                _formPostIt = new FormPostIt(this);

                // Cree la page
                Crownwood.Magic.Controls.TabPage tp1 =
                    new Crownwood.Magic.Controls.TabPage("Notes", _formPostIt)
                    {
                        Tag = "POSTIT",
                        ImageList = OutlookBarImageList,
                        ImageIndex = 7,
                        Selected = true
                    };

                // ajouter la page au groupe
                tgl.TabPages.Add(tp1);
            }
        }

        #region Save/Load Client

        /// <summary>
        /// Enregistrement des clients
        /// </summary>
        private void SaveClient(string FileName, CustomerCollection CustomerList)
        {
            XDocument doc = new XDocument(new XElement("EcoleConduiteBarrette",
                new XAttribute("Version", "2.2"),
                new XElement("BarretteClients", new XAttribute("Count", CustomerList.Count))));

            XElement SchoolInfoRoot = doc.Element("EcoleConduiteBarrette").Element("BarretteClients");

            foreach (Customer client in CustomerList)
            {
                //Creation des seance pratiques
                XElement SeancePratiqueList = new XElement("SeancesList");
                foreach (Seance seance in client.Seances)
                {
                    SeancePratiqueList.Add(new XElement("Seances",
                        new XAttribute("Activate", seance.Active),
                        new XAttribute("Date", seance.DateHeure.ToString()),
                        new XAttribute("SeanceNumber", seance.SceanceNumber),
                        new XAttribute("SeanceCode", seance.Code),
                        new XAttribute("Employer", seance.Employer),
                        new XAttribute("DateModified", seance.DateModified.ToString()),
                        new XAttribute("DateModifiedChecked", seance.DateModifiedChecked),
                        new XAttribute("Absence", seance.Absence),
                        new XAttribute("Montant", seance.Montant)));
                }

                //Creation des seance Theorique
                XElement SeanceTheoriqueList = new XElement("SeancesListTheorique");
                foreach (Seance seance in client.SeancesTheorique)
                {
                    SeanceTheoriqueList.Add(new XElement("Seances",
                        new XAttribute("Activate", seance.Active),
                        new XAttribute("Date", seance.DateHeure.ToString()),
                        new XAttribute("SeanceNumber", seance.SceanceNumber),
                        new XAttribute("SeanceCode", seance.Code),
                        new XAttribute("Employer", seance.Employer),
                        new XAttribute("DateModified", seance.DateModified.ToString()),
                        new XAttribute("DateModifiedChecked", seance.DateModifiedChecked),
                        new XAttribute("Absence", seance.Absence),
                        new XAttribute("Montant", seance.Montant)));
                }

                //Creation des Paiments
                XElement PaimentList = new XElement("PaimentList");
                foreach (Paiement paiment in client.Paiment)
                {
                    if (!paiment.Montant.EndsWith(" $"))
                        paiment.Montant += " $";

                    PaimentList.Add(new XElement("Paiment",
                        new XAttribute("Date", paiment.DatePaiment.ToShortDateString()), //A voir...
                        new XAttribute("Montant", paiment.Montant),
                        new XAttribute("NumeroRecu", paiment.NumeroRecu),
                        new XAttribute("Type", paiment.Type),
                        new XAttribute("PaimentAutre", paiment.PaimentAutre),
                        new XAttribute("TypePaiment", paiment.TypePaiment)));
                }

                //Creation du client
                SchoolInfoRoot.Add(new XElement("Customers",
                    new XAttribute("City", client.City),
                    new XAttribute("ContratNumber", client.ContratNumber),
                    new XAttribute("AttestationNumber", client.AttestationNumber1),
                    new XAttribute("AttestationNumber2", client.AttestationNumber2),
                    new XAttribute("DateInscription", client.DateInscription.ToShortDateString()),
                    new XAttribute("DisponibilityAM", client.DisponibilityAM),
                    new XAttribute("DisponibilityPM", client.DisponibilityPM),
                    new XAttribute("DisponibilitySoir", client.DisponibilitySoirer),
                    new XAttribute("DisponibilitySamedi", client.DisponibilitySamedi),
                    new XAttribute("DisponibilityDimanche", client.DisponibilityDimanche),
                    new XAttribute("FirstName", client.FirstName),
                    new XAttribute("Name", client.Name),
                    new XAttribute("No6R", client.No6R),
                    new XAttribute("PermisNumber", client.NumeroPermis),
                    new XAttribute("Phone", client.Phone),
                    new XAttribute("PhoneBurreau", client.PhoneBureau),
                    new XAttribute("StreetApp", client.StreetApp),
                    new XAttribute("StreetNumber", client.StreetNumber),
                    new XAttribute("StreetName", client.StreetName),
                    new XAttribute("ProfileType", client.TypeClient),
                    new XAttribute("VehiculeType", client.TypeVehicule),
                    new XAttribute("ProgramMoto", client.ProgramMoto),
                    new XAttribute("CashSolde", client.Solde),              //TODO : A supprimer ... Calculer automatiquement
                    new XAttribute("RecuNumber", client.LastRecuNumber), //TODO : A supprimer ... Calculer automatiquement
                    new XAttribute("Notes", client.Notes),
                    new XAttribute("PrixCours", client.MontantCours),
                    new XAttribute("CodePostal", client.CodePostal),
                    new XAttribute("LocationAutomobile", client.LocationAutomobile),
                    new XAttribute("LocationMoto", client.LocationMoto),
                    new XAttribute("MontantLocation", client.MontantLocation),
                    new XAttribute("BVA", client.BVA),
                    new XAttribute("BVADate", client.BVADate.ToShortDateString()),
                    new XAttribute("DateNaissance", client.DateNaissance.ToShortDateString()),
                    new XAttribute("HaveTemporaire", client.HaveTemporaire),
                    new XAttribute("DateTemporaire", client.DateTemporaire.ToShortDateString()),
                    new XAttribute("DateExpiration", client.DateExpiration.ToShortDateString()),
                    new XAttribute("DateDebutCours", client.DateDebutCours.ToShortDateString()),
                    new XAttribute("ClientNull", client.ClientNull),
                    new XAttribute("TauxHorairePratique", client.TauxHorairePratique),
                    new XAttribute("TauxHoraireTheorique", client.TauxHoraireTheorique),
                    new XAttribute("DateAttestation1", client.DateAttestation1.ToShortDateString()),
                    new XAttribute("DateAttestation2", client.DateAttestation2.ToShortDateString()),
                    new XAttribute("NumeroGroupe", client.NumeroGroupe),
                    new XAttribute("email", client.Email),
                    new XAttribute("IsSpyder", client.IsSpyder),
                    SeancePratiqueList,
                    SeanceTheoriqueList,
                    PaimentList));
            }

            try
            {
                doc.Save(FileName, SaveOptions.None);
            }
            catch
            {
                MessageBox.Show(this, "Une erreur est survenue lors de l'enregistement des Informations sur l'école de conduite", AppConfig.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        /// <summary>
        /// Chargement de la liste des clients
        /// </summary>
        private void LoadClient(string FileName, CustomerCollection CustomerList)
        {
            XDocument doc;
            CustomerList.Clear();
            Customer client = null;
            Paiement paiment = null;
            Seance seance = null;

            bool programMotoChecked = false;

            if (File.Exists(FileName))
            {
                doc = XDocument.Load(FileName);

                var clientList = from i in doc.Element("EcoleConduiteBarrette").Element("BarretteClients").Elements()
                                 select i;

                //Chargement de la liste de clients
                foreach (XElement e in clientList)
                {
                    client = new Customer();

                    //Informations sur le client
                    foreach (XAttribute at in e.Attributes())
                    {
                        switch (at.Name.ToString())
                        {
                            case "AttestationNumber":
                                client.AttestationNumber1 = at.Value;
                                break;
                            case "ContratNumber":
                                client.ContratNumber = at.Value;
                                break;
                            case "City":
                                client.City = at.Value;
                                break;
                            case "DateInscription":
                                client.DateInscription = DateTime.Parse(at.Value.ToString());
                                break;
                            case "AttestationNumber2":
                                client.AttestationNumber2 = at.Value;
                                break;
                            case "DateNaissance":
                                client.DateNaissance = DateTime.Parse(at.Value);
                                break;
                            case "DateTemporaire":
                                client.DateTemporaire = DateTime.Parse(at.Value);
                                break;
                            case "DateExpiration":
                                client.DateExpiration = DateTime.Parse(at.Value);
                                break;
                            case "DateDebutCours":
                                client.DateDebutCours = DateTime.Parse(at.Value);
                                break;
                            case "HaveTemporaire":
                                client.HaveTemporaire = Convert.ToBoolean(at.Value);
                                break;
                            case "RecuNumber":
                                client.LastRecuNumber = at.Value;
                                break;
                            case "CashSolde":
                                client.Solde = at.Value;
                                break;
                            case "PrixCours":
                                client.MontantCours = at.Value;
                                break;
                            case "Notes":
                                client.Notes = at.Value;
                                break;
                            case "CodePostal":
                                client.CodePostal = at.Value;
                                break;
                            case "MontantLocation":
                                client.MontantLocation = at.Value;
                                break;
                            case "LocationMoto":
                                client.LocationMoto = Convert.ToBoolean(at.Value);
                                break;
                            case "LocationAutomobile":
                                client.LocationAutomobile = Convert.ToBoolean(at.Value);
                                break;
                            case "BVADate":
                                client.BVADate = DateTime.Parse(at.Value);
                                break;
                            case "BVA":
                                client.BVA = Convert.ToBoolean(at.Value);
                                break;
                            case "ClientNull":
                                client.ClientNull = Convert.ToBoolean(at.Value);
                                break;
                            case "TauxHoraireTheorique":
                                client.TauxHoraireTheorique = at.Value;
                                break;
                            case "TauxHorairePratique":
                                client.TauxHorairePratique = at.Value;
                                break;
                            case "DateAttestation2":
                                client.DateAttestation2 = DateTime.Parse(at.Value);
                                break;
                            case "DateAttestation1":
                                client.DateAttestation1 = DateTime.Parse(at.Value);
                                break;
                            case "NumeroGroupe":
                                client.NumeroGroupe = Convert.ToInt32(at.Value);
                                break;
                            case "email":
                                client.Email = at.Value;
                                break;
                            case "IsSpyder":
                                client.IsSpyder = Convert.ToBoolean(at.Value);
                                break;
                            case "VehiculeType":
                                //Type de Vehicule
                                switch (at.Value)
                                {
                                    case "Automatique":
                                        client.TypeVehicule = VehiculeType.Automatique;
                                        break;
                                    case "Cyclomoteur":
                                        client.TypeVehicule = VehiculeType.Cyclomoteur;
                                        break;
                                    case "Manuel":
                                        client.TypeVehicule = VehiculeType.Manuel;
                                        break;
                                    case "Moto":
                                        client.TypeVehicule = VehiculeType.Moto;
                                        break;
                                }
                                break;
                            case "ProfileType":
                                //Type de client
                                switch (at.Value)
                                {
                                    case "Actif":
                                        client.TypeClient = ProfileType.Actif;
                                        break;
                                    case "CoursTerminer":
                                        client.TypeClient = ProfileType.CoursTerminer;
                                        break;
                                }
                                break;
                            case "ProgramMoto":
                                //Type de program de moto
                                switch (at.Value)
                                {
                                    case "ProgramNormal":
                                        client.ProgramMoto = ProgramMoto.ProgramNormal;
                                        break;
                                    case "Program2015":
                                        client.ProgramMoto = ProgramMoto.Program2015;
                                        break;
                                    case "Nothing":
                                        client.ProgramMoto = ProgramMoto.Nothing;
                                        break;
                                }

                                programMotoChecked = true;
                                break;
                            case "StreetName":
                                client.StreetName = at.Value;
                                break;
                            case "StreetNumber":
                                client.StreetNumber = at.Value;
                                break;
                            case "StreetApp":
                                client.StreetApp = at.Value;
                                break;
                            case "PhoneBurreau":
                                client.PhoneBureau = at.Value;
                                break;
                            case "Phone":
                                client.Phone = at.Value;
                                break;
                            case "PermisNumber":
                                client.NumeroPermis = at.Value;
                                break;
                            case "No6R":
                                client.No6R = at.Value;
                                break;
                            case "Name":
                                client.Name = at.Value;
                                break;
                            case "FirstName":
                                client.FirstName = at.Value;
                                break;
                            case "DisponibilityDimanche":
                                client.DisponibilityDimanche = Convert.ToBoolean(at.Value);
                                break;
                            case "DisponibilitySamedi":
                                client.DisponibilitySamedi = Convert.ToBoolean(at.Value);
                                break;
                            case "DisponibilitySoir":
                                client.DisponibilitySoirer = Convert.ToBoolean(at.Value);
                                break;
                            case "DisponibilityPM":
                                client.DisponibilityPM = Convert.ToBoolean(at.Value);
                                break;
                            case "DisponibilityAM":
                                client.DisponibilityAM = Convert.ToBoolean(at.Value);
                                break;
                        }
                    }

                    //Chargement des listes
                    foreach (XElement item in e.Elements())
                    {
                        switch (item.Name.ToString())
                        {
                            case "SeancesList":
                                var SeancePratiqueList = item.Elements("Seances");

                                foreach (XElement XSeance in SeancePratiqueList)
                                {
                                    seance = new Seance();
                                    foreach (XAttribute at in XSeance.Attributes())
                                    {
                                        switch (at.Name.ToString())
                                        {
                                            case "Activate":
                                                seance.Active = Convert.ToBoolean(at.Value);
                                                break;
                                            case "Date":
                                                seance.DateHeure = DateTime.Parse(at.Value);
                                                break;
                                            case "SeanceNumber":
                                                seance.SceanceNumber = Convert.ToInt32(at.Value);
                                                break;
                                            case "SeanceCode":
                                                seance.Code = at.Value;
                                                break;
                                            case "Employer":
                                                seance.Employer = at.Value;
                                                break;
                                            case "DateModified":
                                                seance.DateModified = DateTime.Parse(at.Value);
                                                break;
                                            case "DateModifiedChecked":
                                                seance.DateModifiedChecked = Convert.ToBoolean(at.Value);
                                                break;
                                            case "Absence":
                                                seance.Absence = Convert.ToBoolean(at.Value);
                                                break;
                                            case "Montant":
                                                seance.Montant = at.Value;
                                                break;
                                        }
                                    }
                                    client.Seances.Add(seance);
                                }
                                break;
                            case "SeancesListTheorique":
                                var Seancelist = item.Elements("Seances");

                                foreach (XElement XSeance in Seancelist)
                                {
                                    seance = new Seance();
                                    foreach (XAttribute at in XSeance.Attributes())
                                    {
                                        switch (at.Name.ToString())
                                        {
                                            case "Activate":
                                                seance.Active = Convert.ToBoolean(at.Value);
                                                break;
                                            case "Date":
                                                seance.DateHeure = DateTime.Parse(at.Value);
                                                break;
                                            case "SeanceNumber":
                                                seance.SceanceNumber = Convert.ToInt32(at.Value);
                                                break;
                                            case "SeanceCode":
                                                seance.Code = at.Value;
                                                break;
                                            case "Employer":
                                                seance.Employer = at.Value;
                                                break;
                                            case "DateModified":
                                                seance.DateModified = DateTime.Parse(at.Value);
                                                break;
                                            case "DateModifiedChecked":
                                                seance.DateModifiedChecked = Convert.ToBoolean(at.Value);
                                                break;
                                            case "Absence":
                                                seance.Absence = Convert.ToBoolean(at.Value);
                                                break;
                                            case "Montant":
                                                seance.Montant = at.Value;
                                                break;
                                        }
                                    }
                                    client.SeancesTheorique.Add(seance);
                                }
                                break;
                            case "PaimentList":

                                var Paimentlist = item.Elements("Paiment");

                                foreach (XElement Xpaiment in Paimentlist)
                                {
                                    paiment = new Paiement();
                                    foreach (XAttribute at in Xpaiment.Attributes())
                                    {
                                        switch (at.Name.ToString())
                                        {
                                            case "Montant":
                                                paiment.Montant = at.Value;
                                                break;
                                            case "Date":
                                                paiment.DatePaiment = DateTime.Parse(at.Value);
                                                break;
                                            case "NumeroRecu":
                                                paiment.NumeroRecu = Convert.ToInt32(at.Value);
                                                break;
                                            case "PaimentAutre":
                                                paiment.PaimentAutre = at.Value;
                                                break;
                                            case "TypePaiment":
                                                switch (at.Value)
                                                {
                                                    case "Nothing":
                                                        paiment.TypePaiment = TypePaiment.Nothing;
                                                        break;
                                                    case "PaimentDirect":
                                                        paiment.TypePaiment = TypePaiment.PaimentDirect;
                                                        break;
                                                    case "ArgentComptant":
                                                        paiment.TypePaiment = TypePaiment.ArgentComptant;
                                                        break;
                                                    case "VISA":
                                                        paiment.TypePaiment = TypePaiment.VISA;
                                                        break;
                                                    case "MasterCard":
                                                        paiment.TypePaiment = TypePaiment.MasterCard;
                                                        break;
                                                    case "Autre":
                                                        paiment.TypePaiment = TypePaiment.Autre;
                                                        break;
                                                    case "Cheque":
                                                        paiment.TypePaiment = TypePaiment.Cheque;
                                                        break;
                                                }
                                                break;
                                            case "Type":
                                                switch (at.Value)
                                                {
                                                    case "Nothing":
                                                        paiment.Type = PaiementType.Nothing;
                                                        break;
                                                    case "RetourLivre":
                                                        paiment.Type = PaiementType.RetourLivre;
                                                        break;
                                                    case "LocationAuto":
                                                        paiment.Type = PaiementType.LocationAuto;
                                                        break;
                                                    case "Absence":
                                                        paiment.Type = PaiementType.Absence;
                                                        break;
                                                }
                                                break;
                                        }
                                    }
                                    client.Paiment.Add(paiment);
                                }
                                break;
                        }
                    }

                    //Update program moto
                    if (!programMotoChecked)
                        if (client.TypeVehicule == VehiculeType.Moto)
                        {
                            client.ProgramMoto = client.DateInscription <= new DateTime(2015, 05, 31) ? ProgramMoto.ProgramNormal : ProgramMoto.Program2015;
                        }
                        else
                            client.ProgramMoto = ProgramMoto.Nothing;

                    CustomerList.Add(client);
                }
            }
        }

        /// <summary>
        /// Enregistre les notes
        /// </summary>
        private void SavePostIt(string FileName, PostItCollection colNotes)
        {
            XDocument doc = new XDocument(new XElement("GEAPostIt",
                new XAttribute("Version", "2.0"),
                new XElement("GestionAutoEcolePostIt", new XAttribute("Count", colNotes.Count))));

            XElement PostItRoot = doc.Element("GEAPostIt").Element("GestionAutoEcolePostIt");
            //XElement PostItRoot = doc.Element("GestionAutoEcolePostIt");

            foreach (PostIt note in colNotes)
            {
                PostItRoot.Add(new XElement("PostIt",
                    new XAttribute("Message", note.Message),
                    new XAttribute("Date", note.Date.ToString()),
                    new XAttribute("AlerteDateTime", note.AlerteDateTime.ToString()),
                    new XAttribute("Alerte", note.Alerte.ToString()),
                    new XAttribute("Employe", note.Employe)));
            }

            try
            {
                doc.Save(FileName, SaveOptions.None);
            }
            catch
            {
                MessageBox.Show(this, "Une erreur est survenue lors de l'enregistement des PostIts.", AppConfig.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        /// <summary>
        /// Enregistrement des Configurations
        /// </summary>
        private void SaveConfig(string FileName)
        {
            XDocument doc = new XDocument(new XComment("Fichier de configuration du logiciel : " + AppConfig.ApplicationName),
                    new XElement("Root", new XAttribute("Version", "0.1")));

            XElement root = doc.Element("Root");
            root.Add(new XElement("ShowGestionClient_Groupe", AppConfig.ShowGestionClient_Groupe));
            root.Add(new XElement("ShowGestionClient_GroupeAutomobile", AppConfig.ShowGestionClient_GroupeAutomobile));
            root.Add(new XElement("ShowGestionClient_GroupeCyclomoteur", AppConfig.ShowGestionClient_GroupeCyclomoteur));
            root.Add(new XElement("ShowGestionClient_GroupeMoto", AppConfig.ShowGestionClient_GroupeMoto));
            root.Add(new XElement("ShowOutlookBar", AppConfig.ShowOutlookBar));
            root.Add(new XElement("ModulebarWidth", outLookBar.Width));
            root.Add(new XElement("CustomerListWidth", _formClients.SplitterDistance));
            root.Add(new XElement("ShowGestionClient_CoursFinish", AppConfig.ShowGestionClient_CoursFinish));
            root.Add(new XElement("LastContractNumber", AppConfig.LastContractNumber));

            try
            {
                doc.Save(FileName, SaveOptions.None);
            }
            catch
            {
                MessageBox.Show(this, "Une erreur est survenue lors de l'enregistement des configurations.", AppConfig.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        /// <summary>
        /// Chargement des configurations de l'utilisateur
        /// </summary>
        private void LoadConfig(string FileName)
        {
            XDocument doc;

            _AppConfig = new Config();

            if (File.Exists(FileName))
            {
                doc = XDocument.Load(FileName);

                var config = from i in doc.Element("Root").Elements()
                             select i;

                foreach (XElement e in config)
                {
                    switch (e.Name.LocalName)
                    {
                        case "ShowGestionClient_CoursFinish":
                            try
                            {
                                _AppConfig.ShowGestionClient_CoursFinish = Convert.ToBoolean(e.Value);
                            }
                            catch
                            {
                                _AppConfig.ShowGestionClient_CoursFinish = true;
                            };
                            break;
                        case "ShowGestionClient_Groupe":
                            try
                            {
                                _AppConfig.ShowGestionClient_Groupe = Convert.ToBoolean(e.Value);
                            }
                            catch
                            {
                                _AppConfig.ShowGestionClient_Groupe = true;
                            }
                            break;
                        case "ShowGestionClient_GroupeAutomobile":
                            try
                            {
                                _AppConfig.ShowGestionClient_GroupeAutomobile = Convert.ToBoolean(e.Value);
                            }                            
                            catch {
                                _AppConfig.ShowGestionClient_GroupeAutomobile = true;
                            }
                            break;
                        case "ShowGestionClient_GroupeCyclomoteur":
                            try
                            {
                                _AppConfig.ShowGestionClient_GroupeCyclomoteur = Convert.ToBoolean(e.Value);
                            }
                            catch
                            {
                                _AppConfig.ShowGestionClient_GroupeCyclomoteur = true;
                            }
                            break;
                        case "ShowGestionClient_GroupeMoto":
                            try
                            {
                                _AppConfig.ShowGestionClient_GroupeMoto = Convert.ToBoolean(e.Value);
                            }
                            catch
                            {
                                _AppConfig.ShowGestionClient_GroupeMoto = true;
                            }
                            break;
                        case "ShowOutlookBar":
                            try
                            {
                                _AppConfig.ShowOutlookBar = Convert.ToBoolean(e.Value);
                            }
                            catch 
                            {
                                _AppConfig.ShowOutlookBar = true;
                            }
                            break;
                        case "ModulebarWidth":
                            try
                            {
                                _AppConfig.ModulebarWidth = Convert.ToInt32(e.Value);
                            }
                            catch 
                            {
                                _AppConfig.ModulebarWidth = 195;
                            }
                            break;
                        case "CustomerListWidth":
                            try
                            {
                                _AppConfig.CustomerListWidth = Convert.ToInt32(e.Value);
                            }
                            catch
                            {
                                _AppConfig.CustomerListWidth = 326;
                            }
                            break;
                        case "LastContractNumber":
                            try
                            {
                                _AppConfig.LastContractNumber = Convert.ToInt32(e.Value);
                            }
                            catch 
                            {
                                _AppConfig.LastContractNumber = 1000;
                            }
                            break;
                    }
                }
            }

            //Apply config TEMP
            tsmnuViewCoursFinish.Checked = _AppConfig.ShowGestionClient_CoursFinish;
            outLookBar.Visible = tsmnuViewModuleBar.Checked = _AppConfig.ShowOutlookBar;
            tsmnuViewTypeCours.Checked = _AppConfig.ShowGestionClient_Groupe;
            automobileToolStripMenuItem.Checked = _AppConfig.ShowGestionClient_GroupeAutomobile;
            motoToolStripMenuItem.Checked = _AppConfig.ShowGestionClient_GroupeMoto;
            cyclomoteurToolStripMenuItem.Checked = _AppConfig.ShowGestionClient_GroupeCyclomoteur;
            outLookBar.Width = _AppConfig.ModulebarWidth;
            Text = _AppConfig.ApplicationName + "  (Derek Tremblay 418-550-6494)";
        }

        /// <summary>
        /// Ouvre tous les fichiers.
        /// </summary>
        private void OpenAll()
        {
            LoadConfig(@"Data\config.xml");
            LoadPostIt(@"Data\postit.xml", PostItList);
            LoadPostIt(@"Data\HorraireNotes.xml", NotesHoraire);
            LoadOffDate(@"Data\OffDate.xml");
            LoadEmploye();
            LoadSchoolInfo(@"Data\SchoolInfo.xml", ref _InfoSchool);
            LoadClient(@"Data\client.xml", ClientList);
            LoadStudentGroup();

            if (_formClients != null)
            {
                _formClients.RefreshClientList(_AppConfig);
                _formClients.RefreshFindList();
                _formClients.SplitterDistance = _AppConfig.CustomerListWidth;
            }

            if (_formPostIt != null)
                _formPostIt.LoadList();
        }


        /// <summary>
        /// Enregistrement de tous les fichiers.
        /// </summary>
        public void SaveAll()
        {
            Cursor = Cursors.WaitCursor;

            //create folder
            Directory.CreateDirectory(@"c:\GAEC backup");

            //Backup avant
            GAEBackup.CompressFolder(Application.StartupPath + @"\data", @"c:\GAEC backup\GAE2023 " + DateTime.Now.ToShortDateString() + " - presave.gaec", TauxCompression.Maximum, true);
            //

            SaveClient(@"Data\client.xml", ClientList);
            SavePostIt(@"Data\postit.xml", PostItList);
            SavePostIt(@"Data\HorraireNotes.xml", NotesHoraire);
            SaveOffDate(@"Data\OffDate.xml");
            SaveEmploye();
            SaveInfoSchool(@"Data\SchoolInfo.xml");
            SaveStudentGroup();
            SaveConfig(@"Data\config.xml");

            //Backup après
            GAEBackup.CompressFolder(Application.StartupPath + @"\data", @"c:\GAEC backup\GAE2023 " + DateTime.Now.ToShortDateString() + ".gaec", TauxCompression.Maximum, true);
            //

            Cursor = Cursors.Default;
        }

        /// <summary>
        /// Enregistre les employés
        /// </summary>
        private void SaveEmploye()
        {
            try
            {
                XmlTextWriter myWriter = new XmlTextWriter(@"Data\employe.xml", Encoding.Unicode)
                {
                    Formatting = Formatting.Indented
                };

                //Header avec la version
                myWriter.WriteStartElement("GAEEmploye");
                myWriter.WriteAttributeString("Version", "0.5");

                //Ecriture des code 
                myWriter.WriteStartElement("Employe");
                myWriter.WriteAttributeString("Count", Convert.ToString(EmployeList.Count));
                if (EmployeList.Count > 0)
                {
                    for (int i = 0; i < EmployeList.Count; i++)
                    {
                        Employe emp = EmployeList[i];
                        myWriter.WriteStartElement("Employe");

                        //Information generale
                        myWriter.WriteAttributeString("NumeroEmploye", emp.NumeroEmploye);
                        myWriter.WriteAttributeString("Nom", emp.Nom);
                        myWriter.WriteAttributeString("Prenom", emp.Prenom);
                        myWriter.WriteAttributeString("NomAffichageRapport", emp.NomAffichageRapport);
                        myWriter.WriteAttributeString("NAS", emp.NAS);
                        myWriter.WriteAttributeString("Titre", emp.Titre);
                        myWriter.WriteAttributeString("Telephone", emp.Telephone);
                        myWriter.WriteAttributeString("TelephoneAutre", emp.TelephoneAutre);
                        myWriter.WriteAttributeString("NumeroPermis", emp.NumeroPermis);

                        //Adresse
                        myWriter.WriteAttributeString("City", emp.City);
                        myWriter.WriteAttributeString("CodePostal", emp.CodePostal);
                        myWriter.WriteAttributeString("SituationFamiliale", emp.SituationFamiliale.ToString());
                        myWriter.WriteAttributeString("StreetApp", emp.StreetApp);
                        myWriter.WriteAttributeString("StreetName", emp.StreetName);
                        myWriter.WriteAttributeString("StreetNumber", emp.StreetNumber);

                        myWriter.WriteAttributeString("DateDernierJourTravailler", emp.DateDernierJourTravailler.ToString());
                        myWriter.WriteAttributeString("DateEmbauche", emp.DateEmbauche.ToString());
                        myWriter.WriteAttributeString("DateNaissance", emp.DateNaissance.ToString());

                        myWriter.WriteAttributeString("NatureEmploie", emp.NatureEmploie);
                        myWriter.WriteAttributeString("Notes", emp.Notes);

                        myWriter.WriteAttributeString("AdultACharge", emp.AdultACharge.ToString());
                        myWriter.WriteAttributeString("EnfantACharge", emp.EnfantACharge.ToString());

                        myWriter.WriteAttributeString("TauxHorraire", emp.TauxHorraire);
                        myWriter.WriteAttributeString("TypeEmployer", emp.TypeEmployer.ToString());

                        myWriter.WriteEndElement();
                    }
                }
                myWriter.WriteEndElement();

                //Fermeture du tag
                myWriter.WriteEndElement();

                //Fermeture du fichier
                myWriter.Close();

            }
            catch
            {
            }
        }

        /// <summary>
        /// Enregistre les information sur les groupe d'etudiant
        /// </summary>
        private void SaveStudentGroup()
        {
            try
            {
                XmlTextWriter myWriter = new XmlTextWriter(@"Data\StudentGroup.xml", Encoding.Unicode)
                {
                    Formatting = Formatting.Indented
                };

                //Header avec la version
                myWriter.WriteStartElement("GAEStudentGroup");
                myWriter.WriteAttributeString("Version", "1.2");

                //Ecriture des code 
                myWriter.WriteStartElement("GAEStudentGroup");

                foreach (StudentGroup group in StudentGroupList)
                {
                    myWriter.WriteStartElement("StudentGroup");

                    myWriter.WriteAttributeString("GroupeNumber", group.GroupeNumber.ToString());
                    myWriter.WriteAttributeString("Name", group.Name);
                    myWriter.WriteAttributeString("Type", group.Type.ToString());

                    myWriter.WriteEndElement();
                }

                //Fermeture des tag                
                myWriter.WriteEndElement();
                myWriter.WriteEndElement();

                //Fermeture du fichier
                myWriter.Close();
            }
            catch
            {
            }
        }

        /// <summary>
        /// Enregistre les informations sur l'école de conduite
        /// </summary>
        private void SaveInfoSchool(string FileName)
        {
            XDocument doc = new XDocument(new XElement("GAESchoolInfo",
                new XAttribute("Version", "2.0"),
                new XElement("GAESchoolInfoBlock")));

            XElement SchoolInfoRoot = doc.Element("GAESchoolInfo").Element("GAESchoolInfoBlock");

            SchoolInfoRoot.Add(new XElement("InfoSchool",
                new XAttribute("City", _InfoSchool.City),
                new XAttribute("Fax", _InfoSchool.Fax),
                new XAttribute("Email", _InfoSchool.Email),
                new XAttribute("Responsable", _InfoSchool.Responsable),
                new XAttribute("Phone", _InfoSchool.Phone),
                new XAttribute("PostalCode", _InfoSchool.PostalCode),
                new XAttribute("RegistrationAuto", _InfoSchool.RegistrationAuto),
                new XAttribute("RegistrationMoto", _InfoSchool.RegistrationMoto),
                new XAttribute("SchoolName", _InfoSchool.SchoolName),
                new XAttribute("StreetName", _InfoSchool.StreetName),
                new XAttribute("StreetNumber", _InfoSchool.StreetNumber),
                new XAttribute("TPS", _InfoSchool.TPS),
                new XAttribute("TVQ", _InfoSchool.TVQ),
                new XAttribute("CourseCity", _InfoSchool.CourseCity),
                new XAttribute("CoursePostalCode", _InfoSchool.CoursePostalCode),
                new XAttribute("CourseStreetName", _InfoSchool.CourseStreetName),
                new XAttribute("CourseStreetNumber", _InfoSchool.CourseStreetNumber),
                new XAttribute("CourseBatisseName", _InfoSchool.CourseBatisseName),
                new XAttribute("TauxHorairePratique", _InfoSchool.TauxHorairePratique),
                new XAttribute("TauxHoraireTheorie", _InfoSchool.TauxHoraireTheorie)));

            try
            {
                doc.Save(FileName, SaveOptions.None);
            }
            catch
            {
                MessageBox.Show(this, "Une erreur est survenue lors de l'enregistement des Informations sur l'école de conduite", AppConfig.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        /// <summary>
        /// Enregistre les jours férié
        /// </summary>
        private void SaveOffDate(string FileName)
        {
            XDocument doc = new XDocument(new XElement("GAEOffDate",
                new XAttribute("Version", "2.0"),
                new XElement("GAEOffDate", new XAttribute("Count", OffDateList.Count))));

            XElement OffDateRoot = doc.Element("GAEOffDate").Element("GAEOffDate");

            foreach (OffDate offdate in OffDateList)
            {
                OffDateRoot.Add(new XElement("OffDate",
                    new XAttribute("Date", offdate.Date.ToString()),
                    new XAttribute("Description", offdate.Description)));
            }

            try
            {
                doc.Save(FileName, SaveOptions.None);
            }
            catch
            {
                MessageBox.Show(this, "Une erreur est survenue lors de l'enregistement des Jour Férié.", AppConfig.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        /// <summary>
        /// Chargement de la liste de Postit
        /// </summary>
        private void LoadPostIt(string FileName, PostItCollection colNotes)
        {
            XDocument doc;
            colNotes.Clear();
            PostIt notes = null;

            if (File.Exists(FileName))
            {
                doc = XDocument.Load(FileName);

                var Postits = from i in doc.Element("GEAPostIt").Element("GestionAutoEcolePostIt").Elements()
                              select i;

                foreach (XElement e in Postits)
                {
                    notes = new PostIt();

                    foreach (XAttribute at in e.Attributes())
                    {
                        switch (at.Name.ToString())
                        {
                            case "Message":
                                notes.Message = at.Value;
                                break;
                            case "Date":
                                notes.Date = DateTime.Parse(at.Value);
                                break;
                            case "Alerte":
                                notes.Alerte = Convert.ToBoolean(at.Value);
                                break;
                            case "AlerteDateTime":
                                notes.AlerteDateTime = DateTime.Parse(at.Value);
                                break;
                            case "Employe":
                                notes.Employe = at.Value;
                                break;
                        }
                    }

                    colNotes.Add(notes);
                }
            }
        }

        /// <summary>
        /// Chargement de la liste des employé
        /// </summary>
        private void LoadEmploye()
        {
            if (File.Exists(@"Data\employe.xml"))
            {
                EmployeList.Clear();

                //Creation du reader
                XmlDocument doc = new XmlDocument();
                XmlTextReader reader = new XmlTextReader(@"Data\employe.xml");

                //Lecture du document
                doc.Load(reader);

                //Lecture des includes : TextFile
                XmlNodeList CodeNodes = doc.ChildNodes.Item(0).ChildNodes;
                XmlNodeList AllCode = doc.ChildNodes.Item(0).ChildNodes.Item(0).ChildNodes;

                //Chargement de la liste de client
                XmlNode node = null;
                Employe emp = null;
                for (int i = 0; i < AllCode.Count; i++)
                {
                    emp = new Employe();

                    //node
                    node = AllCode[i];

                    //Information generale
                    emp.NumeroEmploye = node.Attributes["NumeroEmploye"].Value;
                    emp.Nom = node.Attributes["Nom"].Value;
                    emp.Prenom = node.Attributes["Prenom"].Value;                    
                    emp.NAS = node.Attributes["NAS"].Value;
                    emp.Titre = node.Attributes["Titre"].Value;
                    emp.Telephone = node.Attributes["Telephone"].Value;
                    emp.TelephoneAutre = node.Attributes["TelephoneAutre"].Value;

                    try
                    {
                        emp.NomAffichageRapport = node.Attributes["NomAffichageRapport"].Value;
                    }
                    catch { }

                    try
                    {
                        emp.NumeroPermis = node.Attributes["NumeroPermis"].Value;
                    }
                    catch { }

                    //Adresse
                    emp.City = node.Attributes["City"].Value;
                    emp.CodePostal = node.Attributes["CodePostal"].Value;

                    emp.StreetApp = node.Attributes["StreetApp"].Value;
                    emp.StreetName = node.Attributes["StreetName"].Value;
                    emp.StreetNumber = node.Attributes["StreetNumber"].Value;

                    emp.DateDernierJourTravailler = DateTime.Parse(node.Attributes["DateDernierJourTravailler"].Value);
                    emp.DateEmbauche = DateTime.Parse(node.Attributes["DateEmbauche"].Value);
                    emp.DateNaissance = DateTime.Parse(node.Attributes["DateNaissance"].Value);

                    emp.NatureEmploie = node.Attributes["NatureEmploie"].Value;
                    emp.Notes = node.Attributes["Notes"].Value;

                    emp.AdultACharge = Convert.ToInt32(node.Attributes["AdultACharge"].Value);
                    emp.EnfantACharge = Convert.ToInt32(node.Attributes["EnfantACharge"].Value);

                    emp.TauxHorraire = node.Attributes["TauxHorraire"].Value;

                    switch (node.Attributes["TypeEmployer"].Value)
                    {
                        case "Contractuel":
                            emp.TypeEmployer = TypeEmploye.Contractuel;
                            break;
                        case "Dirigeant":
                            emp.TypeEmployer = TypeEmploye.Dirigeant;
                            break;
                        case "TauxHorraire":
                            emp.TypeEmployer = TypeEmploye.TauxHorraire;
                            break;
                    }

                    switch (node.Attributes["SituationFamiliale"].Value)
                    {
                        case "Celibataire":
                            emp.SituationFamiliale = FamilyStatus.Celibataire;
                            break;
                        case "Divorce":
                            emp.SituationFamiliale = FamilyStatus.Divorce;
                            break;
                        case "Marie":
                            emp.SituationFamiliale = FamilyStatus.Marie;
                            break;
                        case "UnionLibre":
                            emp.SituationFamiliale = FamilyStatus.UnionLibre;
                            break;
                        case "Veuf":
                            emp.SituationFamiliale = FamilyStatus.Veuf;
                            break;
                    }

                    EmployeList.Add(emp);
                }
            }
        }

        /// <summary>
        /// Chargement de la liste des jour férié
        /// </summary>
        private void LoadOffDate(string FileName)
        {
            XDocument doc;
            OffDateList.Clear();
            OffDate Offdate = null;

            if (File.Exists(FileName))
            {
                doc = XDocument.Load(FileName);

                var OffDates = from i in doc.Element("GAEOffDate").Element("GAEOffDate").Elements()
                               select i;

                foreach (XElement e in OffDates)
                {
                    Offdate = new OffDate();

                    foreach (XAttribute at in e.Attributes())
                    {
                        switch (at.Name.ToString())
                        {
                            case "Description":
                                Offdate.Description = at.Value;
                                break;
                            case "Date":
                                Offdate.Date = DateTime.Parse(at.Value);
                                break;
                        }
                    }

                    OffDateList.Add(Offdate);
                }
            }
        }

        /// <summary>
        /// Chargement de la liste des groupe d'etudiant
        /// </summary>
        private void LoadStudentGroup()
        {
            if (File.Exists(@"Data\StudentGroup.xml"))
            {
                StudentGroupList.Clear();

                //Creation du reader
                XmlDocument doc = new XmlDocument();
                XmlTextReader reader = new XmlTextReader(@"Data\StudentGroup.xml");
                StudentGroup group = null;

                //Lecture du document
                doc.Load(reader);

                //Lecture des includes : TextFile
                XmlNodeList CodeNodes = doc.ChildNodes.Item(0).ChildNodes;
                XmlNodeList AllCode = doc.ChildNodes.Item(0).ChildNodes.Item(0).ChildNodes;

                //Chargement de la liste de client
                foreach (XmlNode node in AllCode)
                {
                    group = new StudentGroup
                    {
                        GroupeNumber = Convert.ToInt32(node.Attributes["GroupeNumber"].Value),
                        Name = node.Attributes["Name"].Value
                    };

                    switch (node.Attributes["Type"].Value)
                    {
                        case "Automobile":
                            group.Type = StudentGroup.GroupType.Automobile;
                            break;
                        case "Moto":
                            group.Type = StudentGroup.GroupType.Moto;
                            break;
                        case "Cyclomoteur":
                            group.Type = StudentGroup.GroupType.Cyclomoteur;
                            break;
                        case "Autre":
                            group.Type = StudentGroup.GroupType.Autre;
                            break;
                    }

                    StudentGroupList.Add(group);
                }
            }
            else
            {
                StudentGroupList.Clear();

                //Groupe par défault
                if (StudentGroupList.Count == 0)
                    StudentGroupList.Add(new StudentGroup("Étudiant sans groupe", 0, StudentGroup.GroupType.Autre));
            }


        }

        /// <summary>
        /// Chargement des informations sur l'ecole de conduite
        /// </summary>
        private void LoadSchoolInfo(string FileName, ref SchoolInfo infoSchool)
        {
            XDocument doc;
            infoSchool = new SchoolInfo();

            if (File.Exists(FileName))
            {
                doc = XDocument.Load(FileName);

                var SchoolInfoRoot = from i in doc.Element("GAESchoolInfo").Element("GAESchoolInfoBlock").Elements()
                                     select i;

                foreach (XElement e in SchoolInfoRoot)
                {
                    foreach (XAttribute at in e.Attributes())
                    {
                        switch (at.Name.ToString())
                        {
                            case "City":
                                infoSchool.City = at.Value;
                                break;
                            case "Email":
                                infoSchool.Email = at.Value;
                                break;
                            case "Responsable":
                                infoSchool.Responsable = at.Value;
                                break;
                            case "Fax":
                                infoSchool.Fax = at.Value;
                                break;
                            case "Phone":
                                infoSchool.Phone = at.Value;
                                break;
                            case "PostalCode":
                                infoSchool.PostalCode = at.Value;
                                break;
                            case "RegistrationAuto":
                                infoSchool.RegistrationAuto = at.Value;
                                break;
                            case "RegistrationMoto":
                                infoSchool.RegistrationMoto = at.Value;
                                break;
                            case "SchoolName":
                                infoSchool.SchoolName = at.Value;
                                break;
                            case "StreetName":
                                infoSchool.StreetName = at.Value;
                                break;
                            case "StreetNumber":
                                infoSchool.StreetNumber = Convert.ToInt32(at.Value);
                                break;
                            case "TPS":
                                infoSchool.TPS = at.Value;
                                break;
                            case "TVQ":
                                infoSchool.TVQ = at.Value;
                                break;
                            case "TauxHoraireTheorie":
                                infoSchool.TauxHoraireTheorie = at.Value;
                                break;
                            case "TauxHorairePratique":
                                infoSchool.TauxHorairePratique = at.Value;
                                break;
                            case "CourseCity":
                                infoSchool.CourseCity = at.Value;
                                break;
                            case "CoursePostalCode":
                                infoSchool.CoursePostalCode = at.Value;
                                break;
                            case "CourseStreetName":
                                infoSchool.CourseStreetName = at.Value;
                                break;
                            case "CourseStreetNumber":
                                try
                                {
                                    infoSchool.CourseStreetNumber = Convert.ToInt32(at.Value);
                                }
                                catch
                                {
                                    infoSchool.CourseStreetNumber = 0;
                                }
                                break;
                            case "CourseBatisseName":
                                infoSchool.CourseBatisseName = at.Value;
                                break;
                        }
                    }
                }
            }
        }
        #endregion

        /// <summary>
        /// Confirmer l'enregistrement avant la fermeture du fichier.
        /// </summary>		
        private void FormMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

#if !DEBUG
			DialogResult result = MessageBox.Show(this, "Voulez vous enregistrer votre travail ?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

			switch (result) {
				case DialogResult.Cancel:
					e.Cancel = true;
					break;
				case DialogResult.Yes: 
					this.SaveAll();
					break;
			}
#endif
        }

        /// <summary>
        /// Creation de la fenetre Horraire
        /// </summary>
        private void CreationHoraire()
        {
            // Créé un access a la premiere page page du group
            TabGroupLeaf tgl = tabGroup.RootSequence[0] as TabGroupLeaf;
            bool exist = false;

            //Verifie que l'horraire n'est pas deja ouvert
            foreach (Crownwood.Magic.Controls.TabPage page in tgl.TabPages)
            {
                if (page.Tag.ToString() == "HORAIRE")
                {
                    exist = true;
                    page.Selected = true;
                }
            }

            //Creation de la fenetre client si il n'existe pas
            if (!exist)
            {
                _formHoraire = new FormHoraire(ClientList, OffDateList, EmployeList, this, NotesHoraire);

                // Cree la page
                Crownwood.Magic.Controls.TabPage tp1 =
                    new Crownwood.Magic.Controls.TabPage("Horaire", _formHoraire)
                    {
                        Tag = "HORAIRE",
                        ImageList = OutlookBarImageList,
                        ImageIndex = 4,
                        Selected = true
                    };

                // ajouter la page au groupe
                tgl.TabPages.Add(tp1);
            }
        }

        /// <summary>
        /// Creation de la fenetre de Gestion des groupes d'élève
        /// </summary>
        private void CreationGestionGroupe()
        {
            // Créé un access a la premiere page page du group
            TabGroupLeaf tgl = tabGroup.RootSequence[0] as TabGroupLeaf;
            bool exist = false;

            //Verifie que l'horraire n'est pas deja ouvert
            foreach (Crownwood.Magic.Controls.TabPage page in tgl.TabPages)
            {
                if (page.Tag.ToString() == "GROUPEELEVE")
                {
                    exist = true;
                    page.Selected = true;
                }
            }

            //Creation de la fenetre client si il n'existe pas
            if (!exist)
            {
                _formGestionGroupe = new FormGestionGroupe(StudentGroupList, ClientList, this, EmployeList);

                // Cree la page
                Crownwood.Magic.Controls.TabPage tp1 =
                    new Crownwood.Magic.Controls.TabPage("Gestion des groupes d'élèves", _formGestionGroupe)
                    {
                        Tag = "GROUPEELEVE",
                        ImageList = OutlookBarImageList,
                        ImageIndex = 10,
                        Selected = true
                    };

                // ajouter la page au groupe
                tgl.TabPages.Add(tp1);
            }
        }

        /// <summary>
        /// Vérifie que la fenetre Horraire est ouverte
        /// </summary>
        public bool isOpenSchedule()
        {
            // Créé un access a la premiere page page du group
            TabGroupLeaf tgl = tabGroup.RootSequence[0] as TabGroupLeaf;

            foreach (Crownwood.Magic.Controls.TabPage page in tgl.TabPages)
            {
                if (page.Tag.ToString() == "HORAIRE")
                    return true;
            }

            return false;
        }

        public void UpdateClientSchedule()
        {
            //this._formHorraire.UpdateClientList(ClientList);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CreationListClient();
        }


        private void menuItem7_Click(object sender, EventArgs e)
        {
            CreationFindClient();
        }

        private void splitter1_DoubleClick(object sender, EventArgs e)
        {
            outLookBar.Width = 112;
            splitter1.Left = 112;
        }

        /// <summary>
        /// Demande l'enregistrement de l'horraire avant sa fermeture
        /// </summary>		
        private void tabGroup_PageCloseRequest(TabbedGroups tg, TGCloseRequestEventArgs e)
        {
            /*if (e.TabPage.Tag.ToString() == "HORRAIRE"){
                DialogResult result = MessageBox.Show(this, "Voulez vous enregistrer votre horraire ?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (result) {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    case DialogResult.Yes: 
                        //Enregistrement de l'horraire
                        this._formHorraire.horaireControl1.SaveToXML(@"Data\schedule.xml");
                        break;
                }
            }
            */

        }

        private void PostItAlertTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < PostItList.Count; i++)
            {
                if (PostItList[i].Alerte == true)
                {
                    if (PostItList[i].AlerteDateTime.ToString() == DateTime.Now.ToString())
                    {
                        ShowAlert(PostItList[i]);
                        break;
                    }
                }
            }
        }

        private void ShowAlert(PostIt notes)
        {
            AlertForm alert = new AlertForm(notes);
            alert.ShowDialog(this);

            if (_formPostIt != null)
                _formPostIt.LoadList();
        }

        /// <summary>
        /// Recoie la liste de client (Read-Only))
        /// </summary>
        public CustomerCollection GetClientsList
        {
            get
            {
                return ClientList;
            }
        }


        private void tsmnuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmnuEnregistrer_Click(object sender, EventArgs e)
        {
            SaveAll();
        }

        private void tsmnuOpen_Click(object sender, EventArgs e)
        {
            OpenAll();
        }

        private void tsmnuModuleClient_Click(object sender, EventArgs e)
        {
            CreationListClient();
        }

        private void tsmnuModuleEmployer_Click(object sender, EventArgs e)
        {
            CreationEmploye();
        }

        private void tsmnuModuleFinance_Click(object sender, EventArgs e)
        {
            CreationFinance();
        }

        private void tsmnuModuleHoraire_Click(object sender, EventArgs e)
        {
            CreationHoraire();
        }

        private void tsmnuModuleGroupe_Click(object sender, EventArgs e)
        {
            CreationGestionGroupe();
        }

        private void tsmnuModuleSuivie_Click(object sender, EventArgs e)
        {
            CreationSuivie();
        }

        private void tsmnuModuleStatistiques_Click(object sender, EventArgs e)
        {
            CreationStats();
        }

        private void tsmnuModuleNotes_Click(object sender, EventArgs e)
        {
            CreationPostIt();
        }

        private void tsmnuModuleFind_Click(object sender, EventArgs e)
        {
            CreationFindClient();
        }

        private void tsmnuToolCodes_Click(object sender, EventArgs e)
        {
            new FormSeanceCode(AppConfig).ShowDialog(this);
        }

        private void tsmnuOffDate_Click(object sender, EventArgs e)
        {
            new FormJourFerier(OffDateList, AppConfig).ShowDialog(this);
        }

        private void tsmnuSchoolInfo_Click(object sender, EventArgs e)
        {
            new FormInfoEcole(_InfoSchool, false, AppConfig).ShowDialog(this);
        }

        private void tsmnuBackup_Click(object sender, EventArgs e)
        {
            if (folderDialogBackup.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    GAEBackup.CompressFolder(Application.StartupPath + @"\data", folderDialogBackup.SelectedPath + @"\GAE2010 " + DateTime.Now.ToShortDateString() + ".gaec", TauxCompression.Maximum, true);
                    Cursor.Current = Cursors.Default;

                    MessageBox.Show(this, "La copie de sauvegarde c'est effectué avec succès !", AppConfig.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show(this, "Une erreur est survenue la de la mise en place de votre copie de sauvegarde. \n\n Veuillez réessayer de nouveau. Si cette erreur persiste. Veuillez communiquez avec le concepteur de votre logiciel.", AppConfig.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmnuViewModuleBar_Click(object sender, EventArgs e)
        {
            tsmnuViewModuleBar.Checked = !tsmnuViewModuleBar.Checked;
            _AppConfig.ShowOutlookBar = tsmnuViewModuleBar.Checked;

            outLookBar.Visible = tsmnuViewModuleBar.Checked;

        }

        private void tsmnuViewCoursFinish_Click(object sender, EventArgs e)
        {
            tsmnuViewCoursFinish.Checked = !tsmnuViewCoursFinish.Checked;

            _AppConfig.ShowGestionClient_CoursFinish = tsmnuViewCoursFinish.Checked;

            if (_formClients != null)
                _formClients.RefreshClientList(_AppConfig);

        }

        private void tsmnuViewTypeCours_Click(object sender, EventArgs e)
        {
            tsmnuViewTypeCours.Checked = !tsmnuViewTypeCours.Checked;

            _AppConfig.ShowGestionClient_Groupe = tsmnuViewTypeCours.Checked;

            if (_formClients != null)
                _formClients.ShowGroupInList = _AppConfig.ShowGestionClient_Groupe;

        }

        private void tsmnuExport_Click(object sender, EventArgs e)
        {
            new FormExport(ClientList, AppConfig).ShowDialog(this);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void tsmnuAddCustomer_Click(object sender, EventArgs e)
        {
            new FormAjoutClient(_formClients, _InfoSchool, _AppConfig).ShowDialog(this);
        }

        private void tsmnuImport_Click(object sender, EventArgs e)
        {

        }

        private void tsmnuImportBackup_Click(object sender, EventArgs e)
        {
            openFileDialogImport.ShowDialog(this);
            string filename = openFileDialogImport.FileName;

            if (File.Exists(filename))
            {
                Cursor = Cursors.WaitCursor;

                if (MessageBox.Show(this, "Votre configuration actuelle sera remplacée par celle du fichier de sauvegarde sélectionné. Si vous continué, il ne sera pas possible de faire marche arrière. Voulez-vous vraiment continué ?", AppConfig.ApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    if (GAEBackup.UnCompressFile(filename, Application.StartupPath + @"\Data", true))
                        OpenAll();

                Cursor = Cursors.Default;
            }
        }

        private void tsmnuAutoCompletedCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Cette opération terminera automatiquement tous les clients dont leurs contrat est expiré. Voulez-vous vraiment continué ?", AppConfig.ApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (Customer client in ClientList)
                    {
                        if (DateTime.Now > client.DateExpiration)
                            client.TypeClient = ProfileType.CoursTerminer;
                    }

                    if (_formClients != null)
                    {
                        _formClients.RefreshClientList(AppConfig);
                        _formClients.RefreshFindList();
                    }
                }
            }
            catch { }
        }

        private void automobileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            automobileToolStripMenuItem.Checked = !automobileToolStripMenuItem.Checked;
            _AppConfig.ShowGestionClient_GroupeAutomobile = automobileToolStripMenuItem.Checked;

            if (_formClients != null)
            {
                _formClients.RefreshClientList(_AppConfig);
                _formClients.RefreshFindList();
            }
        }

        private void motoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            motoToolStripMenuItem.Checked = !motoToolStripMenuItem.Checked;
            _AppConfig.ShowGestionClient_GroupeMoto = motoToolStripMenuItem.Checked;

            if (_formClients != null)
            {
                _formClients.RefreshClientList(_AppConfig);
                _formClients.RefreshFindList();
            }
        }

        private void cyclomoteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cyclomoteurToolStripMenuItem.Checked = !cyclomoteurToolStripMenuItem.Checked;
            _AppConfig.ShowGestionClient_GroupeCyclomoteur = cyclomoteurToolStripMenuItem.Checked;

            if (_formClients != null)
            {
                _formClients.RefreshClientList(_AppConfig);
                _formClients.RefreshFindList();
            }
        } 
    }
}
