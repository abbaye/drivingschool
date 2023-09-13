namespace Barette.IDE.Forms.GestionGroup {
    partial class FormGestionGroupe {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionGroupe));
            Barette.Library.Client.Customer customer2 = new Barette.Library.Client.Customer();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbStudentsList = new System.Windows.Forms.ToolBar();
            this.tbbRefresh = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator4 = new System.Windows.Forms.ToolBarButton();
            this.tbbShowClient = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbAddStudentInGroup = new System.Windows.Forms.ToolBarButton();
            this.tbbDeleteStudentFromGroup = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator3 = new System.Windows.Forms.ToolBarButton();
            this.tbbPrintAll = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.tbbModifieSeancePratique = new System.Windows.Forms.ToolBarButton();
            this.tbbModifieSeanceTheorique = new System.Windows.Forms.ToolBarButton();
            this.ListGroup = new System.Windows.Forms.ListView();
            this.colHeaderGroupeList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderGroupName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderNombreEleve = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadTypeGroupe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbStudentGroup = new System.Windows.Forms.ToolBar();
            this.tbbRefresh2 = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbAddGroupe = new System.Windows.Forms.ToolBarButton();
            this.tbbDeleteGroupe = new System.Windows.Forms.ToolBarButton();
            this.tbbEdit = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.tbbPrint = new System.Windows.Forms.ToolBarButton();
            this.ImageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.timerActivateButton = new System.Windows.Forms.Timer(this.components);
            this.PrintRelever = new System.Drawing.Printing.PrintDocument();
            this.clientControl1 = new Barette.Library.UserControls.Client.ClientControl();
            this.listFindResult = new Barette.Library.Listview.ListViewEx();
            this.colheadContratNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadNumeroPermis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadPhone2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbbPrintTheorie = new System.Windows.Forms.ToolBarButton();
            this.SuspendLayout();
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
            this.imageList1.Images.SetKeyName(5, "new-page-icon.png");
            this.imageList1.Images.SetKeyName(6, "book-icon.png");
            this.imageList1.Images.SetKeyName(7, "drive 2.ico");
            this.imageList1.Images.SetKeyName(8, "user-group-icon.png");
            this.imageList1.Images.SetKeyName(9, "Edit-icon.png");
            // 
            // tbStudentsList
            // 
            this.tbStudentsList.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbStudentsList.AutoSize = false;
            this.tbStudentsList.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbRefresh,
            this.tbbSeparator4,
            this.tbbShowClient,
            this.tbbSeparator,
            this.tbbAddStudentInGroup,
            this.tbbDeleteStudentFromGroup,
            this.toolBarButton2,
            this.tbbPrintTheorie,
            this.tbbPrintAll,
            this.tbbSeparator3,
            this.tbbModifieSeanceTheorique,
            this.tbbModifieSeancePratique});
            this.tbStudentsList.Divider = false;
            this.tbStudentsList.Dock = System.Windows.Forms.DockStyle.None;
            this.tbStudentsList.DropDownArrows = true;
            this.tbStudentsList.ImageList = this.imageList1;
            this.tbStudentsList.Location = new System.Drawing.Point(372, 57);
            this.tbStudentsList.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tbStudentsList.Name = "tbStudentsList";
            this.tbStudentsList.ShowToolTips = true;
            this.tbStudentsList.Size = new System.Drawing.Size(788, 42);
            this.tbStudentsList.TabIndex = 10;
            this.tbStudentsList.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.tbStudentsList.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbStudentsList_ButtonClick);
            // 
            // tbbRefresh
            // 
            this.tbbRefresh.ImageIndex = 4;
            this.tbbRefresh.Name = "tbbRefresh";
            this.tbbRefresh.Tag = "REFRESH";
            this.tbbRefresh.ToolTipText = "Rafraîchir la liste de clients";
            // 
            // tbbSeparator4
            // 
            this.tbbSeparator4.Name = "tbbSeparator4";
            this.tbbSeparator4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbShowClient
            // 
            this.tbbShowClient.ImageKey = "user-group-icon.png";
            this.tbbShowClient.Name = "tbbShowClient";
            this.tbbShowClient.Tag = "SHOWCLIENT";
            // 
            // tbbSeparator
            // 
            this.tbbSeparator.Name = "tbbSeparator";
            this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbAddStudentInGroup
            // 
            this.tbbAddStudentInGroup.ImageIndex = 0;
            this.tbbAddStudentInGroup.Name = "tbbAddStudentInGroup";
            this.tbbAddStudentInGroup.Tag = "ADD";
            this.tbbAddStudentInGroup.ToolTipText = "Ajouter un client";
            // 
            // tbbDeleteStudentFromGroup
            // 
            this.tbbDeleteStudentFromGroup.ImageIndex = 1;
            this.tbbDeleteStudentFromGroup.Name = "tbbDeleteStudentFromGroup";
            this.tbbDeleteStudentFromGroup.Tag = "DELETE";
            this.tbbDeleteStudentFromGroup.ToolTipText = "Effacer un client";
            // 
            // tbbSeparator3
            // 
            this.tbbSeparator3.Name = "tbbSeparator3";
            this.tbbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbPrintAll
            // 
            this.tbbPrintAll.ImageIndex = 3;
            this.tbbPrintAll.Name = "tbbPrintAll";
            this.tbbPrintAll.Tag = "PRINTALL";
            this.tbbPrintAll.ToolTipText = "Imprimer scéances Pratique";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbModifieSeancePratique
            // 
            this.tbbModifieSeancePratique.ImageKey = "book-icon.png";
            this.tbbModifieSeancePratique.Name = "tbbModifieSeancePratique";
            this.tbbModifieSeancePratique.Tag = "SEANCEPRATIQUE";
            this.tbbModifieSeancePratique.Text = "Séance pratique (groupe)";
            // 
            // tbbModifieSeanceTheorique
            // 
            this.tbbModifieSeanceTheorique.ImageKey = "drive 2.ico";
            this.tbbModifieSeanceTheorique.Name = "tbbModifieSeanceTheorique";
            this.tbbModifieSeanceTheorique.Tag = "SEANCETHEORIQUE";
            this.tbbModifieSeanceTheorique.Text = "Séance théorique (groupe)";
            // 
            // ListGroup
            // 
            this.ListGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListGroup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeaderGroupeList,
            this.colHeaderGroupName,
            this.colHeaderNombreEleve,
            this.colHeadTypeGroupe});
            this.ListGroup.FullRowSelect = true;
            this.ListGroup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListGroup.HideSelection = false;
            this.ListGroup.Location = new System.Drawing.Point(12, 57);
            this.ListGroup.MultiSelect = false;
            this.ListGroup.Name = "ListGroup";
            this.ListGroup.Size = new System.Drawing.Size(354, 539);
            this.ListGroup.TabIndex = 11;
            this.ListGroup.UseCompatibleStateImageBehavior = false;
            this.ListGroup.View = System.Windows.Forms.View.Details;
            this.ListGroup.SelectedIndexChanged += new System.EventHandler(this.ListGroup_SelectedIndexChanged);
            // 
            // colHeaderGroupeList
            // 
            this.colHeaderGroupeList.Text = "Nº Groupe";
            this.colHeaderGroupeList.Width = 69;
            // 
            // colHeaderGroupName
            // 
            this.colHeaderGroupName.Text = "Nom";
            this.colHeaderGroupName.Width = 139;
            // 
            // colHeaderNombreEleve
            // 
            this.colHeaderNombreEleve.Text = "Nb. Élèves";
            this.colHeaderNombreEleve.Width = 70;
            // 
            // colHeadTypeGroupe
            // 
            this.colHeadTypeGroupe.Text = "Type";
            // 
            // tbStudentGroup
            // 
            this.tbStudentGroup.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbStudentGroup.AutoSize = false;
            this.tbStudentGroup.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbRefresh2,
            this.tbbSeparator2,
            this.tbbAddGroupe,
            this.tbbDeleteGroupe,
            this.tbbEdit,
            this.toolBarButton1,
            this.tbbPrint});
            this.tbStudentGroup.Divider = false;
            this.tbStudentGroup.Dock = System.Windows.Forms.DockStyle.None;
            this.tbStudentGroup.DropDownArrows = true;
            this.tbStudentGroup.ImageList = this.imageList1;
            this.tbStudentGroup.Location = new System.Drawing.Point(12, 12);
            this.tbStudentGroup.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tbStudentGroup.Name = "tbStudentGroup";
            this.tbStudentGroup.ShowToolTips = true;
            this.tbStudentGroup.Size = new System.Drawing.Size(320, 42);
            this.tbStudentGroup.TabIndex = 12;
            this.tbStudentGroup.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.tbStudentGroup.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbStudentGroup_ButtonClick);
            // 
            // tbbRefresh2
            // 
            this.tbbRefresh2.ImageIndex = 4;
            this.tbbRefresh2.Name = "tbbRefresh2";
            this.tbbRefresh2.Tag = "REFRESH";
            this.tbbRefresh2.ToolTipText = "Rafraîchir la liste de groupe";
            // 
            // tbbSeparator2
            // 
            this.tbbSeparator2.Name = "tbbSeparator2";
            this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbAddGroupe
            // 
            this.tbbAddGroupe.ImageIndex = 0;
            this.tbbAddGroupe.Name = "tbbAddGroupe";
            this.tbbAddGroupe.Tag = "ADDGROUP";
            this.tbbAddGroupe.ToolTipText = "Ajouter un nouveau groupe";
            // 
            // tbbDeleteGroupe
            // 
            this.tbbDeleteGroupe.Enabled = false;
            this.tbbDeleteGroupe.ImageIndex = 1;
            this.tbbDeleteGroupe.Name = "tbbDeleteGroupe";
            this.tbbDeleteGroupe.Tag = "DELETEGROUP";
            this.tbbDeleteGroupe.ToolTipText = "Effacer un client";
            // 
            // tbbEdit
            // 
            this.tbbEdit.ImageKey = "Edit-icon.png";
            this.tbbEdit.Name = "tbbEdit";
            this.tbbEdit.Tag = "EDIT";
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbPrint
            // 
            this.tbbPrint.ImageIndex = 3;
            this.tbbPrint.Name = "tbbPrint";
            this.tbbPrint.Tag = "PRINT";
            this.tbbPrint.Text = "Rapport";
            // 
            // ImageListSmall
            // 
            this.ImageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListSmall.ImageStream")));
            this.ImageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListSmall.Images.SetKeyName(0, "Moto");
            this.ImageListSmall.Images.SetKeyName(1, "Auto");
            this.ImageListSmall.Images.SetKeyName(2, "Camion");
            // 
            // timerActivateButton
            // 
            this.timerActivateButton.Enabled = true;
            this.timerActivateButton.Interval = 250;
            this.timerActivateButton.Tick += new System.EventHandler(this.timerActivateButton_Tick);
            // 
            // PrintRelever
            // 
            this.PrintRelever.DocumentName = "Rapport Ligue Sécurité";
            this.PrintRelever.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintRelever_PrintPage);
            // 
            // clientControl1
            // 
            this.clientControl1.AutoUpdate = true;
            this.clientControl1.BackColor = System.Drawing.SystemColors.Control;
            customer2.AttestationNumber1 = "0";
            customer2.AttestationNumber2 = "0";
            customer2.BVA = false;
            customer2.BVADate = new System.DateTime(2023, 8, 30, 22, 41, 6, 44);
            customer2.City = "";
            customer2.ClientNull = false;
            customer2.CodePostal = "   -";
            customer2.ContratNumber = "0";
            customer2.DateAttestation1 = new System.DateTime(2015, 4, 11, 0, 0, 0, 0);
            customer2.DateAttestation2 = new System.DateTime(2015, 4, 11, 0, 0, 0, 0);
            customer2.DateDebutCours = new System.DateTime(2015, 4, 11, 0, 0, 0, 0);
            customer2.DateExpiration = new System.DateTime(2015, 4, 11, 0, 0, 0, 0);
            customer2.DateInscription = new System.DateTime(2015, 4, 11, 0, 0, 0, 0);
            customer2.DateNaissance = new System.DateTime(2023, 8, 30, 22, 41, 6, 182);
            customer2.DateTemporaire = new System.DateTime(2023, 8, 30, 22, 41, 6, 41);
            customer2.DisponibilityAlway = false;
            customer2.DisponibilityAM = false;
            customer2.DisponibilityDimanche = false;
            customer2.DisponibilityPM = false;
            customer2.DisponibilitySamedi = false;
            customer2.DisponibilitySoirer = false;
            customer2.Email = "";
            customer2.FirstName = "";
            customer2.HaveTemporaire = false;
            customer2.IsSpyder = false;
            customer2.LastRecuNumber = "0";
            customer2.LocationAutomobile = false;
            customer2.LocationMoto = false;
            customer2.MontantCours = "";
            customer2.MontantLocation = "0 $";
            customer2.Name = "";
            customer2.No6R = "";
            customer2.Notes = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang3084{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Microsoft Sans Serif;}}\r\n{\\*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\par" +
    "d\\f0\\fs17\\par\r\n}\r\n";
            customer2.NumeroGroupe = 0;
            customer2.NumeroPermis = "";
            customer2.Phone = "(   )   -";
            customer2.PhoneBureau = "(   )   -";
            customer2.ProgramMoto = Barette.Library.Client.ProgramMoto.Nothing;
            customer2.Solde = "0 $";
            customer2.StreetApp = "";
            customer2.StreetName = "";
            customer2.StreetNumber = "0";
            customer2.TauxHorairePratique = "0 $";
            customer2.TauxHoraireTheorique = "0 $";
            customer2.TypeClient = Barette.Library.Client.ProfileType.Actif;
            customer2.TypeVehicule = Barette.Library.Client.VehiculeType.Automatique;
            this.clientControl1.Client = customer2;
            this.clientControl1.Location = new System.Drawing.Point(1046, 32);
            this.clientControl1.Name = "clientControl1";
            this.clientControl1.School = null;
            this.clientControl1.Size = new System.Drawing.Size(133, 116);
            this.clientControl1.TabIndex = 13;
            this.clientControl1.Visible = false;
            // 
            // listFindResult
            // 
            this.listFindResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFindResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colheadContratNumber,
            this.colheadDate,
            this.colheadName,
            this.colHeadNumeroPermis,
            this.colHeadPhone,
            this.colHeadPhone2});
            this.listFindResult.FullRowSelect = true;
            this.listFindResult.HideSelection = false;
            this.listFindResult.Location = new System.Drawing.Point(372, 102);
            this.listFindResult.MultiSelect = false;
            this.listFindResult.Name = "listFindResult";
            this.listFindResult.Size = new System.Drawing.Size(848, 494);
            this.listFindResult.SmallImageList = this.ImageListSmall;
            this.listFindResult.TabIndex = 2;
            this.listFindResult.UseCompatibleStateImageBehavior = false;
            this.listFindResult.View = System.Windows.Forms.View.Details;
            // 
            // colheadContratNumber
            // 
            this.colheadContratNumber.Text = "No. Contrat";
            this.colheadContratNumber.Width = 66;
            // 
            // colheadDate
            // 
            this.colheadDate.Text = "Date inscription";
            this.colheadDate.Width = 91;
            // 
            // colheadName
            // 
            this.colheadName.Text = "Nom du client";
            this.colheadName.Width = 175;
            // 
            // colHeadNumeroPermis
            // 
            this.colHeadNumeroPermis.Text = "No. Permis";
            this.colHeadNumeroPermis.Width = 165;
            // 
            // colHeadPhone
            // 
            this.colHeadPhone.Text = "Téléphone";
            this.colHeadPhone.Width = 91;
            // 
            // colHeadPhone2
            // 
            this.colHeadPhone2.Text = "Téléphone Autre";
            this.colHeadPhone2.Width = 101;
            // 
            // tbbPrintTheorie
            // 
            this.tbbPrintTheorie.ImageIndex = 3;
            this.tbbPrintTheorie.Name = "tbbPrintTheorie";
            this.tbbPrintTheorie.Tag = "PRINTTHEORIE";
            this.tbbPrintTheorie.ToolTipText = "Imprimer scéances théorique";
            // 
            // FormGestionGroupe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1232, 608);
            this.Controls.Add(this.clientControl1);
            this.Controls.Add(this.tbStudentGroup);
            this.Controls.Add(this.ListGroup);
            this.Controls.Add(this.tbStudentsList);
            this.Controls.Add(this.listFindResult);
            this.Name = "FormGestionGroupe";
            this.Text = "FormGestionGroupe";
            this.ResumeLayout(false);

        }

        #endregion

        private Library.Listview.ListViewEx listFindResult;
        private System.Windows.Forms.ColumnHeader colheadContratNumber;
        private System.Windows.Forms.ColumnHeader colheadDate;
        private System.Windows.Forms.ColumnHeader colheadName;
        private System.Windows.Forms.ColumnHeader colHeadNumeroPermis;
        private System.Windows.Forms.ColumnHeader colHeadPhone;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolBar tbStudentsList;
        private System.Windows.Forms.ToolBarButton tbbAddStudentInGroup;
        private System.Windows.Forms.ToolBarButton tbbDeleteStudentFromGroup;
        private System.Windows.Forms.ToolBarButton tbbSeparator;
        private System.Windows.Forms.ToolBarButton tbbRefresh;
        private System.Windows.Forms.ListView ListGroup;
        private System.Windows.Forms.ColumnHeader colHeaderGroupeList;
        private System.Windows.Forms.ToolBar tbStudentGroup;
        //private System.Windows.Forms.ToolBarButton tbbAddGroup;
        private System.Windows.Forms.ToolBarButton tbbDeleteGroupe;
        private System.Windows.Forms.ToolBarButton tbbSeparator2;
        private System.Windows.Forms.ToolBarButton tbbRefresh2;
        private System.Windows.Forms.ColumnHeader colHeaderGroupName;
        private System.Windows.Forms.ToolBarButton tbbAddGroupe;
        private System.Windows.Forms.ImageList ImageListSmall;
        private System.Windows.Forms.ColumnHeader colHeaderNombreEleve;
        private System.Windows.Forms.Timer timerActivateButton;
        private System.Windows.Forms.ColumnHeader colHeadPhone2;
        private System.Windows.Forms.ToolBarButton tbbSeparator3;
        private System.Windows.Forms.ToolBarButton tbbModifieSeancePratique;
        private System.Windows.Forms.ToolBarButton tbbModifieSeanceTheorique;
        private System.Windows.Forms.ColumnHeader colHeadTypeGroupe;
        private System.Windows.Forms.ToolBarButton tbbSeparator4;
        private System.Windows.Forms.ToolBarButton tbbShowClient;
        private System.Windows.Forms.ToolBarButton tbbPrint;
        private System.Windows.Forms.ToolBarButton toolBarButton1;
        private System.Drawing.Printing.PrintDocument PrintRelever;
        private System.Windows.Forms.ToolBarButton tbbEdit;
        private System.Windows.Forms.ToolBarButton tbbPrintAll;
        private System.Windows.Forms.ToolBarButton tbbSeparator5;
        private System.Windows.Forms.ToolBarButton toolBarButton2;
        private Library.UserControls.Client.ClientControl clientControl1;
        private System.Windows.Forms.ToolBarButton tbbPrintTheorie;
    }
}