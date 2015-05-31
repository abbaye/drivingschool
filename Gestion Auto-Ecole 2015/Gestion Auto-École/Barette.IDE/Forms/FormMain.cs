using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private OffDateCollection OffDateList = new OffDateCollection();

        /// <summary>
        /// Liste de groupe d'élèves
        /// </summary>
        private List<StudentGroup> StudentGroupList = new List<StudentGroup>();

        /// <summary>
        /// Liste d'employe
        /// </summary>
        public EmployeCollection EmployeList = new EmployeCollection();

        /// <summary>
        /// Liste de postit qui serviront a prendre des notes pour les horaires.
        /// </summary>
        private PostItCollection NotesHoraire = new PostItCollection();

        /// <summary>
        /// Information sur l'ecole de conduite
        /// </summary>
        private SchoolInfo _InfoSchool = new SchoolInfo();

        /// <summary>
        /// Configuration de l'application
        /// </summary>
        private Config _AppConfig = new Config();

        private System.Windows.Forms.ImageList OutlookBarImageList;
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
        private ToolStripMenuItem tsmnuViewCoursFinish;
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
        private System.ComponentModel.IContainer components;

        public FormMain()
        {
            //
            // Requis pour la prise en charge du Concepteur Windows Forms
            //
            InitializeComponent();

            MakeStaticBorder();
            InitializeBandGestion();

            OpenAll();

            Directory.CreateDirectory("Data");

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            OutlookBarImageList = new System.Windows.Forms.ImageList(components);
            PostItAlertTimer = new System.Windows.Forms.Timer(components);
            folderDialogBackup = new System.Windows.Forms.FolderBrowserDialog();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuAddEmployer = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            tsmnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuEnregistrer = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuEnregistrerSous = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            tsmnuImportExport = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuExport = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuImport = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            tsmnuImportBackup = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            tsmnuItem = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuView = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuViewModuleClient = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuViewCoursFinish = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuViewTypeCours = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            tsmnuViewModuleBar = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuModule = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuModuleClient = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuModuleEmployer = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuModuleFinance = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuModuleHoraire = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuModuleGroupe = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            tsmnuModuleSuivie = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuModuleStatistiques = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuModuleNotes = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            tsmnuModuleFind = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuTools = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuToolCodes = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuOffDate = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuSchoolInfo = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            tsmnuAutoCompletedCustomer = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            tsmnuBackup = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            tsmnuToolsDialog = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            tsmnuAboutDialog = new System.Windows.Forms.ToolStripMenuItem();
            toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            tabGroup = new Crownwood.Magic.Controls.TabbedGroups();
            splitter1 = new System.Windows.Forms.Splitter();
            outLookBar = new UtilityLibrary.WinControls.OutlookBar();
            outBandGestion = new UtilityLibrary.WinControls.OutlookBarBand();
            openFileDialogImport = new System.Windows.Forms.OpenFileDialog();
            toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            listeDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            automobileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            motoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cyclomoteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(tabGroup)).BeginInit();
            SuspendLayout();
            // 
            // OutlookBarImageList
            // 
            OutlookBarImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("OutlookBarImageList.ImageStream")));
            OutlookBarImageList.TransparentColor = System.Drawing.Color.Transparent;
            OutlookBarImageList.Images.SetKeyName(0, "user-group-icon.png");
            OutlookBarImageList.Images.SetKeyName(1, "search-icon.png");
            OutlookBarImageList.Images.SetKeyName(2, "Save-icon.png");
            OutlookBarImageList.Images.SetKeyName(3, "");
            OutlookBarImageList.Images.SetKeyName(4, "calendar-date-icon.png");
            OutlookBarImageList.Images.SetKeyName(5, "coins-icon.png");
            OutlookBarImageList.Images.SetKeyName(6, "Client-icon");
            OutlookBarImageList.Images.SetKeyName(7, "Notes2.png");
            OutlookBarImageList.Images.SetKeyName(8, "app-attention-icon.png");
            OutlookBarImageList.Images.SetKeyName(9, "book");
            OutlookBarImageList.Images.SetKeyName(10, "Group-Folder-icon.png");
            OutlookBarImageList.Images.SetKeyName(11, "statistics-icon.png");
            // 
            // PostItAlertTimer
            // 
            PostItAlertTimer.Enabled = true;
            PostItAlertTimer.Interval = 800;
            PostItAlertTimer.Tick += new System.EventHandler(PostItAlertTimer_Tick);
            // 
            // folderDialogBackup
            // 
            folderDialogBackup.Description = "Sélectionnez le répertoire pour votre copie de sauvegarde.";
            folderDialogBackup.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripMenuItem1,
            tsmnuView,
            tsmnuModule,
            tsmnuTools,
            toolStripMenuItem13});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1016, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            tsmnuAdd,
            toolStripSeparator9,
            tsmnuOpen,
            tsmnuEnregistrer,
            tsmnuEnregistrerSous,
            toolStripSeparator1,
            tsmnuImportExport,
            toolStripSeparator8,
            tsmnuItem});
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            toolStripMenuItem1.Text = "Fichier";
            // 
            // tsmnuAdd
            // 
            tsmnuAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            tsmnuAddCustomer,
            tsmnuAddEmployer});
            tsmnuAdd.Name = "tsmnuAdd";
            tsmnuAdd.Size = new System.Drawing.Size(186, 22);
            tsmnuAdd.Text = "Ajouter";
            // 
            // tsmnuAddCustomer
            // 
            tsmnuAddCustomer.Name = "tsmnuAddCustomer";
            tsmnuAddCustomer.Size = new System.Drawing.Size(133, 22);
            tsmnuAddCustomer.Text = "Client...";
            tsmnuAddCustomer.Click += new System.EventHandler(tsmnuAddCustomer_Click);
            // 
            // tsmnuAddEmployer
            // 
            tsmnuAddEmployer.Enabled = false;
            tsmnuAddEmployer.Name = "tsmnuAddEmployer";
            tsmnuAddEmployer.Size = new System.Drawing.Size(133, 22);
            tsmnuAddEmployer.Text = "Employer...";
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new System.Drawing.Size(183, 6);
            // 
            // tsmnuOpen
            // 
            tsmnuOpen.Name = "tsmnuOpen";
            tsmnuOpen.Size = new System.Drawing.Size(186, 22);
            tsmnuOpen.Text = "Ouvrir";
            tsmnuOpen.Click += new System.EventHandler(tsmnuOpen_Click);
            // 
            // tsmnuEnregistrer
            // 
            tsmnuEnregistrer.Image = global::Barette.IDE.Properties.Resources.Save_icon;
            tsmnuEnregistrer.Name = "tsmnuEnregistrer";
            tsmnuEnregistrer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            tsmnuEnregistrer.Size = new System.Drawing.Size(186, 22);
            tsmnuEnregistrer.Text = "Enregistrer";
            tsmnuEnregistrer.Click += new System.EventHandler(tsmnuEnregistrer_Click);
            // 
            // tsmnuEnregistrerSous
            // 
            tsmnuEnregistrerSous.Enabled = false;
            tsmnuEnregistrerSous.Name = "tsmnuEnregistrerSous";
            tsmnuEnregistrerSous.Size = new System.Drawing.Size(186, 22);
            tsmnuEnregistrerSous.Text = "Enregistrer sous...";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // tsmnuImportExport
            // 
            tsmnuImportExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            tsmnuExport,
            tsmnuImport,
            toolStripSeparator10,
            tsmnuImportBackup});
            tsmnuImportExport.Name = "tsmnuImportExport";
            tsmnuImportExport.Size = new System.Drawing.Size(186, 22);
            tsmnuImportExport.Text = "Importer / Exporter ...";
            // 
            // tsmnuExport
            // 
            tsmnuExport.Enabled = false;
            tsmnuExport.Image = global::Barette.IDE.Properties.Resources.export_icon;
            tsmnuExport.Name = "tsmnuExport";
            tsmnuExport.Size = new System.Drawing.Size(290, 22);
            tsmnuExport.Text = "Exporter des clients vers un fichier...";
            tsmnuExport.Click += new System.EventHandler(tsmnuExport_Click);
            // 
            // tsmnuImport
            // 
            tsmnuImport.Enabled = false;
            tsmnuImport.Image = global::Barette.IDE.Properties.Resources.import_icon;
            tsmnuImport.Name = "tsmnuImport";
            tsmnuImport.Size = new System.Drawing.Size(290, 22);
            tsmnuImport.Text = "Importer des clients à partir d\'un fichier...";
            tsmnuImport.Click += new System.EventHandler(tsmnuImport_Click);
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new System.Drawing.Size(287, 6);
            // 
            // tsmnuImportBackup
            // 
            tsmnuImportBackup.Image = global::Barette.IDE.Properties.Resources.import_icon;
            tsmnuImportBackup.Name = "tsmnuImportBackup";
            tsmnuImportBackup.Size = new System.Drawing.Size(290, 22);
            tsmnuImportBackup.Text = "Importer un fichier de sauvegarde...";
            tsmnuImportBackup.Click += new System.EventHandler(tsmnuImportBackup_Click);
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new System.Drawing.Size(183, 6);
            // 
            // tsmnuItem
            // 
            tsmnuItem.Image = global::Barette.IDE.Properties.Resources.Log_Out_icon;
            tsmnuItem.Name = "tsmnuItem";
            tsmnuItem.Size = new System.Drawing.Size(186, 22);
            tsmnuItem.Text = "Quitter";
            tsmnuItem.Click += new System.EventHandler(tsmnuItem_Click);
            // 
            // tsmnuView
            // 
            tsmnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            tsmnuViewModuleClient,
            toolStripSeparator6,
            tsmnuViewModuleBar,
            toolStripSeparator12,
            listeDesClientsToolStripMenuItem});
            tsmnuView.Name = "tsmnuView";
            tsmnuView.Size = new System.Drawing.Size(70, 20);
            tsmnuView.Text = "Affichage";
            // 
            // tsmnuViewModuleClient
            // 
            tsmnuViewModuleClient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            tsmnuViewCoursFinish,
            tsmnuViewTypeCours});
            tsmnuViewModuleClient.Name = "tsmnuViewModuleClient";
            tsmnuViewModuleClient.Size = new System.Drawing.Size(228, 22);
            tsmnuViewModuleClient.Text = "Gestion des clients";
            // 
            // tsmnuViewCoursFinish
            // 
            tsmnuViewCoursFinish.Name = "tsmnuViewCoursFinish";
            tsmnuViewCoursFinish.Size = new System.Drawing.Size(315, 22);
            tsmnuViewCoursFinish.Text = "Afficher les clients qui ont terminé leurs cours";
            tsmnuViewCoursFinish.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            tsmnuViewCoursFinish.Click += new System.EventHandler(tsmnuViewCoursFinish_Click);
            // 
            // tsmnuViewTypeCours
            // 
            tsmnuViewTypeCours.Name = "tsmnuViewTypeCours";
            tsmnuViewTypeCours.Size = new System.Drawing.Size(315, 22);
            tsmnuViewTypeCours.Text = "Afficher par type de cours";
            tsmnuViewTypeCours.Click += new System.EventHandler(tsmnuViewTypeCours_Click);
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(225, 6);
            // 
            // tsmnuViewModuleBar
            // 
            tsmnuViewModuleBar.Checked = true;
            tsmnuViewModuleBar.CheckState = System.Windows.Forms.CheckState.Checked;
            tsmnuViewModuleBar.Name = "tsmnuViewModuleBar";
            tsmnuViewModuleBar.Size = new System.Drawing.Size(228, 22);
            tsmnuViewModuleBar.Text = "Afficher la barre des modules";
            tsmnuViewModuleBar.Click += new System.EventHandler(tsmnuViewModuleBar_Click);
            // 
            // tsmnuModule
            // 
            tsmnuModule.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            tsmnuModuleClient,
            tsmnuModuleEmployer,
            tsmnuModuleFinance,
            tsmnuModuleHoraire,
            tsmnuModuleGroupe,
            toolStripSeparator2,
            toolStripMenuItem12,
            toolStripSeparator4,
            tsmnuModuleSuivie,
            tsmnuModuleStatistiques,
            tsmnuModuleNotes,
            toolStripSeparator3,
            tsmnuModuleFind});
            tsmnuModule.Name = "tsmnuModule";
            tsmnuModule.Size = new System.Drawing.Size(65, 20);
            tsmnuModule.Text = "Modules";
            // 
            // tsmnuModuleClient
            // 
            tsmnuModuleClient.Image = global::Barette.IDE.Properties.Resources.user_group_icon;
            tsmnuModuleClient.Name = "tsmnuModuleClient";
            tsmnuModuleClient.Size = new System.Drawing.Size(227, 22);
            tsmnuModuleClient.Text = "Gestion des clients";
            tsmnuModuleClient.Click += new System.EventHandler(tsmnuModuleClient_Click);
            // 
            // tsmnuModuleEmployer
            // 
            tsmnuModuleEmployer.Image = global::Barette.IDE.Properties.Resources.Client_icon;
            tsmnuModuleEmployer.Name = "tsmnuModuleEmployer";
            tsmnuModuleEmployer.Size = new System.Drawing.Size(227, 22);
            tsmnuModuleEmployer.Text = "Gestion des employés";
            tsmnuModuleEmployer.Click += new System.EventHandler(tsmnuModuleEmployer_Click);
            // 
            // tsmnuModuleFinance
            // 
            tsmnuModuleFinance.Image = global::Barette.IDE.Properties.Resources.coins_icon;
            tsmnuModuleFinance.Name = "tsmnuModuleFinance";
            tsmnuModuleFinance.Size = new System.Drawing.Size(227, 22);
            tsmnuModuleFinance.Text = "Gestion des finances";
            tsmnuModuleFinance.Click += new System.EventHandler(tsmnuModuleFinance_Click);
            // 
            // tsmnuModuleHoraire
            // 
            tsmnuModuleHoraire.Image = global::Barette.IDE.Properties.Resources.calendar_date_icon;
            tsmnuModuleHoraire.Name = "tsmnuModuleHoraire";
            tsmnuModuleHoraire.Size = new System.Drawing.Size(227, 22);
            tsmnuModuleHoraire.Text = "Gestion des horaires";
            tsmnuModuleHoraire.Click += new System.EventHandler(tsmnuModuleHoraire_Click);
            // 
            // tsmnuModuleGroupe
            // 
            tsmnuModuleGroupe.Image = global::Barette.IDE.Properties.Resources.Group_Folder_icon;
            tsmnuModuleGroupe.Name = "tsmnuModuleGroupe";
            tsmnuModuleGroupe.Size = new System.Drawing.Size(227, 22);
            tsmnuModuleGroupe.Text = "Gestion des groupes d\'élèves";
            tsmnuModuleGroupe.Click += new System.EventHandler(tsmnuModuleGroupe_Click);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(224, 6);
            // 
            // toolStripMenuItem12
            // 
            toolStripMenuItem12.Image = global::Barette.IDE.Properties.Resources.app_attention_icon;
            toolStripMenuItem12.Name = "toolStripMenuItem12";
            toolStripMenuItem12.Size = new System.Drawing.Size(227, 22);
            toolStripMenuItem12.Text = "Ligue de sécurité du Québec";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(224, 6);
            // 
            // tsmnuModuleSuivie
            // 
            tsmnuModuleSuivie.Image = global::Barette.IDE.Properties.Resources.book_icon;
            tsmnuModuleSuivie.Name = "tsmnuModuleSuivie";
            tsmnuModuleSuivie.Size = new System.Drawing.Size(227, 22);
            tsmnuModuleSuivie.Text = "Suivie des cours automobiles";
            tsmnuModuleSuivie.Click += new System.EventHandler(tsmnuModuleSuivie_Click);
            // 
            // tsmnuModuleStatistiques
            // 
            tsmnuModuleStatistiques.Image = global::Barette.IDE.Properties.Resources.statistics_icon;
            tsmnuModuleStatistiques.Name = "tsmnuModuleStatistiques";
            tsmnuModuleStatistiques.Size = new System.Drawing.Size(227, 22);
            tsmnuModuleStatistiques.Text = "Statistiques";
            tsmnuModuleStatistiques.Click += new System.EventHandler(tsmnuModuleStatistiques_Click);
            // 
            // tsmnuModuleNotes
            // 
            tsmnuModuleNotes.Image = global::Barette.IDE.Properties.Resources.FauxS_32_32;
            tsmnuModuleNotes.Name = "tsmnuModuleNotes";
            tsmnuModuleNotes.Size = new System.Drawing.Size(227, 22);
            tsmnuModuleNotes.Text = "Notes";
            tsmnuModuleNotes.Click += new System.EventHandler(tsmnuModuleNotes_Click);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(224, 6);
            // 
            // tsmnuModuleFind
            // 
            tsmnuModuleFind.Image = global::Barette.IDE.Properties.Resources.search_icon;
            tsmnuModuleFind.Name = "tsmnuModuleFind";
            tsmnuModuleFind.Size = new System.Drawing.Size(227, 22);
            tsmnuModuleFind.Text = "Recherche";
            tsmnuModuleFind.Click += new System.EventHandler(tsmnuModuleFind_Click);
            // 
            // tsmnuTools
            // 
            tsmnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            tsmnuToolCodes,
            tsmnuOffDate,
            tsmnuSchoolInfo,
            toolStripSeparator11,
            tsmnuAutoCompletedCustomer,
            toolStripSeparator5,
            tsmnuBackup,
            toolStripSeparator7,
            tsmnuToolsDialog});
            tsmnuTools.Name = "tsmnuTools";
            tsmnuTools.Size = new System.Drawing.Size(50, 20);
            tsmnuTools.Text = "Outils";
            // 
            // tsmnuToolCodes
            // 
            tsmnuToolCodes.Name = "tsmnuToolCodes";
            tsmnuToolCodes.Size = new System.Drawing.Size(273, 22);
            tsmnuToolCodes.Text = "Liste de codes de séances...";
            tsmnuToolCodes.Click += new System.EventHandler(tsmnuToolCodes_Click);
            // 
            // tsmnuOffDate
            // 
            tsmnuOffDate.Name = "tsmnuOffDate";
            tsmnuOffDate.Size = new System.Drawing.Size(273, 22);
            tsmnuOffDate.Text = "Jour fériés...";
            tsmnuOffDate.Click += new System.EventHandler(tsmnuOffDate_Click);
            // 
            // tsmnuSchoolInfo
            // 
            tsmnuSchoolInfo.Name = "tsmnuSchoolInfo";
            tsmnuSchoolInfo.Size = new System.Drawing.Size(273, 22);
            tsmnuSchoolInfo.Text = "Informations sur l\'école de conduite...";
            tsmnuSchoolInfo.Click += new System.EventHandler(tsmnuSchoolInfo_Click);
            // 
            // toolStripSeparator11
            // 
            toolStripSeparator11.Name = "toolStripSeparator11";
            toolStripSeparator11.Size = new System.Drawing.Size(270, 6);
            // 
            // tsmnuAutoCompletedCustomer
            // 
            tsmnuAutoCompletedCustomer.Name = "tsmnuAutoCompletedCustomer";
            tsmnuAutoCompletedCustomer.Size = new System.Drawing.Size(273, 22);
            tsmnuAutoCompletedCustomer.Text = "Terminé tous les cours expiré";
            tsmnuAutoCompletedCustomer.Click += new System.EventHandler(tsmnuAutoCompletedCustomer_Click);
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(270, 6);
            // 
            // tsmnuBackup
            // 
            tsmnuBackup.Image = global::Barette.IDE.Properties.Resources.Archive_icon;
            tsmnuBackup.Name = "tsmnuBackup";
            tsmnuBackup.Size = new System.Drawing.Size(273, 22);
            tsmnuBackup.Text = "Faire une copie de sauvegarde...";
            tsmnuBackup.Click += new System.EventHandler(tsmnuBackup_Click);
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new System.Drawing.Size(270, 6);
            // 
            // tsmnuToolsDialog
            // 
            tsmnuToolsDialog.Enabled = false;
            tsmnuToolsDialog.Name = "tsmnuToolsDialog";
            tsmnuToolsDialog.Size = new System.Drawing.Size(273, 22);
            tsmnuToolsDialog.Text = "Options ...";
            // 
            // toolStripMenuItem13
            // 
            toolStripMenuItem13.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            tsmnuAboutDialog});
            toolStripMenuItem13.Name = "toolStripMenuItem13";
            toolStripMenuItem13.Size = new System.Drawing.Size(24, 20);
            toolStripMenuItem13.Text = "&?";
            // 
            // tsmnuAboutDialog
            // 
            tsmnuAboutDialog.Enabled = false;
            tsmnuAboutDialog.Name = "tsmnuAboutDialog";
            tsmnuAboutDialog.Size = new System.Drawing.Size(150, 22);
            tsmnuAboutDialog.Text = "A propos de ...";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(tabGroup);
            toolStripContainer1.ContentPanel.Controls.Add(splitter1);
            toolStripContainer1.ContentPanel.Controls.Add(outLookBar);
            toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1016, 622);
            toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new System.Drawing.Size(1016, 647);
            toolStripContainer1.TabIndex = 7;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // tabGroup
            // 
            tabGroup.AllowDrop = true;
            tabGroup.AtLeastOneLeaf = true;
            tabGroup.CloseMenuText = "&Fermé";
            tabGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            tabGroup.LayoutLock = true;
            tabGroup.Location = new System.Drawing.Point(178, 0);
            tabGroup.Name = "tabGroup";
            tabGroup.ProminentLeaf = null;
            tabGroup.ResizeBarColor = System.Drawing.SystemColors.Control;
            tabGroup.Size = new System.Drawing.Size(838, 622);
            tabGroup.TabIndex = 7;
            // 
            // splitter1
            // 
            splitter1.Location = new System.Drawing.Point(175, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new System.Drawing.Size(3, 622);
            splitter1.TabIndex = 6;
            splitter1.TabStop = false;
            splitter1.DoubleClick += new System.EventHandler(splitter1_DoubleClick);
            // 
            // outLookBar
            // 
            outLookBar.AnimationSpeed = 20;
            outLookBar.BackgroundBitmap = null;
            outLookBar.Bands.Add(outBandGestion);
            outLookBar.BorderType = UtilityLibrary.WinControls.BorderType.None;
            outLookBar.Dock = System.Windows.Forms.DockStyle.Left;
            outLookBar.FlatArrowButtons = false;
            outLookBar.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            outLookBar.LeftTopColor = System.Drawing.Color.Empty;
            outLookBar.Location = new System.Drawing.Point(0, 0);
            outLookBar.Name = "outLookBar";
            outLookBar.RightBottomColor = System.Drawing.Color.Empty;
            outLookBar.Size = new System.Drawing.Size(175, 622);
            outLookBar.TabIndex = 5;
            outLookBar.ItemClicked += new UtilityLibrary.WinControls.OutlookBarItemClickedHandler(outLookBar_ItemClicked);
            // 
            // outBandGestion
            // 
            outBandGestion.Background = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(233)))));
            outBandGestion.IconView = UtilityLibrary.WinControls.IconView.Large;
            outBandGestion.LargeImageList = OutlookBarImageList;
            outBandGestion.Location = new System.Drawing.Point(0, 0);
            outBandGestion.Name = "outBandGestion";
            outBandGestion.Size = new System.Drawing.Size(0, 0);
            outBandGestion.SmallImageList = null;
            outBandGestion.TabIndex = 0;
            outBandGestion.Text = "Modules";
            outBandGestion.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // openFileDialogImport
            // 
            openFileDialogImport.Filter = "Fichier de sauvegarde Gestion Auto École|*.gaec";
            openFileDialogImport.Title = "Ouvrir un fichier de sauvegarde";
            // 
            // toolStripSeparator12
            // 
            toolStripSeparator12.Name = "toolStripSeparator12";
            toolStripSeparator12.Size = new System.Drawing.Size(225, 6);
            // 
            // listeDesClientsToolStripMenuItem
            // 
            listeDesClientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            automobileToolStripMenuItem,
            motoToolStripMenuItem,
            cyclomoteurToolStripMenuItem});
            listeDesClientsToolStripMenuItem.Name = "listeDesClientsToolStripMenuItem";
            listeDesClientsToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            listeDesClientsToolStripMenuItem.Text = "Liste des clients";
            // 
            // automobileToolStripMenuItem
            // 
            automobileToolStripMenuItem.Checked = true;
            automobileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            automobileToolStripMenuItem.Name = "automobileToolStripMenuItem";
            automobileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            automobileToolStripMenuItem.Text = "Automobile";
            automobileToolStripMenuItem.Click += new System.EventHandler(automobileToolStripMenuItem_Click);
            // 
            // motoToolStripMenuItem
            // 
            motoToolStripMenuItem.Checked = true;
            motoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            motoToolStripMenuItem.Name = "motoToolStripMenuItem";
            motoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            motoToolStripMenuItem.Text = "Moto";
            motoToolStripMenuItem.Click += new System.EventHandler(motoToolStripMenuItem_Click);
            // 
            // cyclomoteurToolStripMenuItem
            // 
            cyclomoteurToolStripMenuItem.Checked = true;
            cyclomoteurToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            cyclomoteurToolStripMenuItem.Name = "cyclomoteurToolStripMenuItem";
            cyclomoteurToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            cyclomoteurToolStripMenuItem.Text = "Cyclomoteur";
            cyclomoteurToolStripMenuItem.Click += new System.EventHandler(cyclomoteurToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            ClientSize = new System.Drawing.Size(1016, 671);
            Controls.Add(toolStripContainer1);
            Controls.Add(menuStrip1);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Gestion Auto École 2010";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Closing += new System.ComponentModel.CancelEventHandler(FormMain_Closing);
            FormClosed += new System.Windows.Forms.FormClosedEventHandler(FormMain_FormClosed);
            Load += new System.EventHandler(FormMain_Load);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(tabGroup)).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
            outBandGestion.Items.Add(outBarEmploye);
            outBandGestion.Items.Add(outBarFinance);
            outBandGestion.Items.Add(outBarHoraire);
            outBandGestion.Items.Add(outBarLigueSecur);
            outBandGestion.Items.Add(outBarSuivie);
            outBandGestion.Items.Add(outBarStats);
            outBandGestion.Items.Add(outBarPostIt);
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

        private void outLookBar_ItemClicked(UtilityLibrary.WinControls.OutlookBarBand band, UtilityLibrary.WinControls.OutlookBarItem item)
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
                    new Crownwood.Magic.Controls.TabPage("Suivie des cours Automobile", _formSuivieCours);

                tp1.Tag = "SUIVIE";
                tp1.ImageList = OutlookBarImageList;
                tp1.ImageIndex = 9;
                tp1.Selected = true;

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
                    new Crownwood.Magic.Controls.TabPage("Gestion des Clients", _formClients);

                tp1.Tag = "CLIENT_LIST";
                tp1.ImageList = OutlookBarImageList;
                tp1.ImageIndex = 0;
                tp1.Selected = true;

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
                    new Crownwood.Magic.Controls.TabPage("Ligue de Securité", _formLigueSecuriter);

                tp1.Tag = "RAPPORTSECUR";
                tp1.ImageList = OutlookBarImageList;
                tp1.ImageIndex = 8;
                tp1.Selected = true;

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
                    new Crownwood.Magic.Controls.TabPage("Recherche de client", _formFindClient);

                tp1.Tag = "FIND_CLIENT";
                tp1.ImageList = OutlookBarImageList;
                tp1.ImageIndex = 1;
                tp1.Selected = true;

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
                    new Crownwood.Magic.Controls.TabPage("Finances", _formFinance);

                tp1.Tag = "FINANCE";
                tp1.ImageList = OutlookBarImageList;
                tp1.ImageIndex = 5;
                tp1.Selected = true;

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
                    new Crownwood.Magic.Controls.TabPage("Gestion des Employés", _formEmploye);

                tp1.Tag = "EMPLOYE";
                tp1.ImageList = OutlookBarImageList;
                tp1.ImageIndex = 6;
                tp1.Selected = true;

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
                    new Crownwood.Magic.Controls.TabPage("Statistiques", _formStatistique);

                tp1.Tag = "STATS";
                tp1.ImageList = OutlookBarImageList;
                tp1.ImageIndex = 11;
                tp1.Selected = true;

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
                    new Crownwood.Magic.Controls.TabPage("Notes", _formPostIt);

                tp1.Tag = "POSTIT";
                tp1.ImageList = OutlookBarImageList;
                tp1.ImageIndex = 7;
                tp1.Selected = true;

                // ajouter la page au groupe
                tgl.TabPages.Add(tp1);
            }
        }

        #region Save/Load Client

        /// <summary>
        /// Enregistrement des clients
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="CustomerList"></param>
        private void SaveClient(string FileName, CustomerCollection CustomerList)
        {
            XDocument doc = new XDocument(new XElement("EcoleConduiteBarrette",
                new XAttribute("Version", "2.1"),
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
                            if (client.DateInscription <= new DateTime(2015, 05, 31))
                                client.ProgramMoto = ProgramMoto.ProgramNormal;
                            else
                                client.ProgramMoto = ProgramMoto.Program2015;
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

            SaveClient(@"Data\client.xml", ClientList);
            SavePostIt(@"Data\postit.xml", PostItList);
            SavePostIt(@"Data\HorraireNotes.xml", NotesHoraire);
            SaveOffDate(@"Data\OffDate.xml");
            SaveEmploye();
            SaveInfoSchool(@"Data\SchoolInfo.xml");
            SaveStudentGroup();
            SaveConfig(@"Data\config.xml");

            Cursor = Cursors.Default;
        }

        /// <summary>
        /// Enregistre les employés
        /// </summary>
        private void SaveEmploye()
        {
            try
            {
                XmlTextWriter myWriter = new XmlTextWriter(@"Data\employe.xml", Encoding.Unicode);
                myWriter.Formatting = Formatting.Indented;

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
                XmlTextWriter myWriter = new XmlTextWriter(@"Data\StudentGroup.xml", Encoding.Unicode);
                myWriter.Formatting = Formatting.Indented;

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

                    emp.AdultACharge = Convert.ToInt16(node.Attributes["AdultACharge"].Value);
                    emp.EnfantACharge = Convert.ToInt16(node.Attributes["EnfantACharge"].Value);

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
                    group = new StudentGroup();

                    group.GroupeNumber = Convert.ToInt32(node.Attributes["GroupeNumber"].Value);
                    group.Name = node.Attributes["Name"].Value;

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
                    new Crownwood.Magic.Controls.TabPage("Horaire", _formHoraire);

                tp1.Tag = "HORAIRE";
                tp1.ImageList = OutlookBarImageList;
                tp1.ImageIndex = 4;
                tp1.Selected = true;

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
                    new Crownwood.Magic.Controls.TabPage("Gestion des groupes d'élèves", _formGestionGroupe);

                tp1.Tag = "GROUPEELEVE";
                tp1.ImageList = OutlookBarImageList;
                tp1.ImageIndex = 10;
                tp1.Selected = true;

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

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            CreationListClient();
        }


        private void menuItem7_Click(object sender, System.EventArgs e)
        {
            CreationFindClient();
        }

        private void splitter1_DoubleClick(object sender, System.EventArgs e)
        {
            outLookBar.Width = 112;
            splitter1.Left = 112;
        }

        /// <summary>
        /// Demande l'enregistrement de l'horraire avant sa fermeture
        /// </summary>		
        private void tabGroup_PageCloseRequest(Crownwood.Magic.Controls.TabbedGroups tg, Crownwood.Magic.Controls.TGCloseRequestEventArgs e)
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
            new Barette.Library.Forms.FormSeanceCode(AppConfig).ShowDialog(this);
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
