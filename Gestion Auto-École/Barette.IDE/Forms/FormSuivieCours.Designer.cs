namespace Barette.IDE.Forms {
    partial class FormSuivieCours {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuivieCours));
            Barette.Library.Client.Customer customer1 = new Barette.Library.Client.Customer();
            this.tbMain = new System.Windows.Forms.ToolBar();
            this.tbbShowClient = new System.Windows.Forms.ToolBarButton();
            this.tbbShowSeanceTheorique = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbActivateModePratique = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbRefresh = new System.Windows.Forms.ToolBarButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timerResize = new System.Windows.Forms.Timer(this.components);
            this.timerEnabled = new System.Windows.Forms.Timer(this.components);
            this.clientControl1 = new Barette.Library.UserControls.Client.ClientControl();
            this.ListCours = new Barette.Library.Listview.ListViewEx();
            this.colHeadContractNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadTelephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadTelephoneAutre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHead1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHead2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHead3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHead4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHead5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHead6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHead7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHead8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHead9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHead10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHead11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHead12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHead13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHead14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHead15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tbMain
            // 
            this.tbMain.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbMain.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbShowClient,
            this.tbbShowSeanceTheorique,
            this.tbbSeparator,
            this.tbbActivateModePratique,
            this.tbbSeparator2,
            this.tbbRefresh});
            this.tbMain.Divider = false;
            this.tbMain.Dock = System.Windows.Forms.DockStyle.None;
            this.tbMain.DropDownArrows = true;
            this.tbMain.ImageList = this.imageList1;
            this.tbMain.Location = new System.Drawing.Point(12, 12);
            this.tbMain.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tbMain.Name = "tbMain";
            this.tbMain.ShowToolTips = true;
            this.tbMain.Size = new System.Drawing.Size(500, 42);
            this.tbMain.TabIndex = 57;
            this.tbMain.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.tbMain.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbMain_ButtonClick);
            // 
            // tbbShowClient
            // 
            this.tbbShowClient.ImageKey = "user-group-icon.png";
            this.tbbShowClient.Name = "tbbShowClient";
            this.tbbShowClient.Tag = "SHOWCLIENT";
            this.tbbShowClient.ToolTipText = "Affiche le client";
            // 
            // tbbShowSeanceTheorique
            // 
            this.tbbShowSeanceTheorique.ImageKey = "book-icon";
            this.tbbShowSeanceTheorique.Name = "tbbShowSeanceTheorique";
            this.tbbShowSeanceTheorique.Tag = "SHOWSEANCE";
            this.tbbShowSeanceTheorique.ToolTipText = "Afficher les cours théorique du client sélectionnée";
            // 
            // tbbSeparator
            // 
            this.tbbSeparator.Name = "tbbSeparator";
            this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbActivateModePratique
            // 
            this.tbbActivateModePratique.ImageKey = "Drive.ico";
            this.tbbActivateModePratique.Name = "tbbActivateModePratique";
            this.tbbActivateModePratique.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbActivateModePratique.Tag = "COURSPRATIQUE";
            this.tbbActivateModePratique.Text = "Cours pratique";
            // 
            // tbbSeparator2
            // 
            this.tbbSeparator2.Name = "tbbSeparator2";
            this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbRefresh
            // 
            this.tbbRefresh.ImageKey = "Refresh";
            this.tbbRefresh.Name = "tbbRefresh";
            this.tbbRefresh.Tag = "REFRESH";
            this.tbbRefresh.ToolTipText = "Rafraîchir la liste";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Refresh");
            this.imageList1.Images.SetKeyName(1, "book-icon");
            this.imageList1.Images.SetKeyName(2, "user-group-icon.png");
            this.imageList1.Images.SetKeyName(3, "Drive.ico");
            // 
            // timerResize
            // 
            this.timerResize.Enabled = true;
            this.timerResize.Tick += new System.EventHandler(this.timerResize_Tick);
            // 
            // timerEnabled
            // 
            this.timerEnabled.Enabled = true;
            this.timerEnabled.Interval = 200;
            this.timerEnabled.Tick += new System.EventHandler(this.timerEnabled_Tick);
            // 
            // clientControl1
            // 
            this.clientControl1.AutoUpdate = false;
            this.clientControl1.BackColor = System.Drawing.SystemColors.Control;
            customer1.AttestationNumber1 = "";
            customer1.AttestationNumber2 = "";
            customer1.BVA = false;
            customer1.BVADate = new System.DateTime(2005, 2, 20, 18, 50, 33, 675);
            customer1.City = "";
            customer1.ClientNull = false;
            customer1.CodePostal = "   -";
            customer1.ContratNumber = "0";
            customer1.DateAttestation1 = new System.DateTime(2010, 6, 29, 19, 44, 39, 949);
            customer1.DateAttestation2 = new System.DateTime(2010, 6, 29, 19, 44, 39, 949);
            customer1.DateDebutCours = new System.DateTime(2010, 3, 10, 16, 11, 1, 688);
            customer1.DateExpiration = new System.DateTime(2010, 3, 10, 16, 11, 1, 688);
            customer1.DateInscription = new System.DateTime(2003, 8, 26, 0, 0, 0, 0);
            customer1.DateNaissance = new System.DateTime(2010, 3, 10, 16, 11, 1, 688);
            customer1.DateTemporaire = new System.DateTime(2005, 2, 20, 18, 50, 33, 675);
            customer1.DisponibilityAM = false;
            customer1.DisponibilityDimanche = false;
            customer1.DisponibilityPM = false;
            customer1.DisponibilitySamedi = false;
            customer1.DisponibilitySoirer = false;
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
            customer1.Solde = "0 $";
            customer1.StreetApp = "";
            customer1.StreetName = "";
            customer1.StreetNumber = "";
            customer1.TauxHorairePratique = "";
            customer1.TauxHoraireTheorique = "";
            customer1.TypeClient = Barette.Library.Client.ProfileType.Actif;
            customer1.TypeVehicule = Barette.Library.Client.VehiculeType.Automatique;
            this.clientControl1.Client = customer1;
            this.clientControl1.Location = new System.Drawing.Point(529, 179);
            this.clientControl1.Name = "clientControl1";
            this.clientControl1.School = null;
            this.clientControl1.Size = new System.Drawing.Size(177, 160);
            this.clientControl1.TabIndex = 58;
            this.clientControl1.Visible = false;
            // 
            // ListCours
            // 
            this.ListCours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.ListCours.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadContractNumber,
            this.colHeadClientName,
            this.colHeadTelephone,
            this.colHeadTelephoneAutre,
            this.colHead1,
            this.colHead2,
            this.colHead3,
            this.colHead4,
            this.colHead5,
            this.colHead6,
            this.colHead7,
            this.colHead8,
            this.colHead9,
            this.colHead10,
            this.colHead11,
            this.colHead12,
            this.colHead13,
            this.colHead14,
            this.colHead15});
            this.ListCours.FullRowSelect = true;
            this.ListCours.Location = new System.Drawing.Point(12, 49);
            this.ListCours.MultiSelect = false;
            this.ListCours.Name = "ListCours";
            this.ListCours.Size = new System.Drawing.Size(1016, 636);
            this.ListCours.TabIndex = 55;
            this.ListCours.UseCompatibleStateImageBehavior = false;
            this.ListCours.View = System.Windows.Forms.View.Details;
            this.ListCours.SelectedIndexChanged += new System.EventHandler(this.ListCoursEffectuer_SelectedIndexChanged);
            this.ListCours.DoubleClick += new System.EventHandler(this.ListCours_DoubleClick);
            // 
            // colHeadContractNumber
            // 
            this.colHeadContractNumber.Text = "No. Contrat";
            this.colHeadContractNumber.Width = 68;
            // 
            // colHeadClientName
            // 
            this.colHeadClientName.Text = "Nom du client";
            this.colHeadClientName.Width = 114;
            // 
            // colHeadTelephone
            // 
            this.colHeadTelephone.Text = "Téléphone";
            this.colHeadTelephone.Width = 90;
            // 
            // colHeadTelephoneAutre
            // 
            this.colHeadTelephoneAutre.Text = "Autre Téléphone";
            this.colHeadTelephoneAutre.Width = 90;
            // 
            // colHead1
            // 
            this.colHead1.Text = "1";
            this.colHead1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHead1.Width = 40;
            // 
            // colHead2
            // 
            this.colHead2.Text = "2";
            this.colHead2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHead2.Width = 41;
            // 
            // colHead3
            // 
            this.colHead3.Text = "3";
            this.colHead3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHead3.Width = 41;
            // 
            // colHead4
            // 
            this.colHead4.Text = "4";
            this.colHead4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHead4.Width = 41;
            // 
            // colHead5
            // 
            this.colHead5.Text = "5";
            this.colHead5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHead5.Width = 41;
            // 
            // colHead6
            // 
            this.colHead6.Text = "6";
            this.colHead6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHead6.Width = 41;
            // 
            // colHead7
            // 
            this.colHead7.Text = "7";
            this.colHead7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHead7.Width = 41;
            // 
            // colHead8
            // 
            this.colHead8.Text = "8";
            this.colHead8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHead8.Width = 41;
            // 
            // colHead9
            // 
            this.colHead9.Text = "9";
            this.colHead9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHead9.Width = 41;
            // 
            // colHead10
            // 
            this.colHead10.Text = "10";
            this.colHead10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHead10.Width = 41;
            // 
            // colHead11
            // 
            this.colHead11.Text = "11";
            this.colHead11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHead11.Width = 41;
            // 
            // colHead12
            // 
            this.colHead12.Text = "12";
            this.colHead12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHead12.Width = 41;
            // 
            // colHead13
            // 
            this.colHead13.Text = "13";
            this.colHead13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHead13.Width = 41;
            // 
            // colHead14
            // 
            this.colHead14.Text = "14";
            this.colHead14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHead14.Width = 41;
            // 
            // colHead15
            // 
            this.colHead15.Text = "15";
            this.colHead15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHead15.Width = 41;
            // 
            // FormSuivieCours
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1040, 697);
            this.Controls.Add(this.clientControl1);
            this.Controls.Add(this.ListCours);
            this.Controls.Add(this.tbMain);
            this.Name = "FormSuivieCours";
            this.Text = "Suivie des cours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Barette.Library.Listview.ListViewEx ListCours;
        private System.Windows.Forms.ColumnHeader colHeadContractNumber;
        private System.Windows.Forms.ColumnHeader colHeadClientName;
        private System.Windows.Forms.ColumnHeader colHeadTelephone;
        private System.Windows.Forms.ColumnHeader colHead1;
        private System.Windows.Forms.ColumnHeader colHead2;
        private System.Windows.Forms.ColumnHeader colHead3;
        private System.Windows.Forms.ColumnHeader colHead4;
        private System.Windows.Forms.ColumnHeader colHead5;
        private System.Windows.Forms.ColumnHeader colHead6;
        private System.Windows.Forms.ColumnHeader colHead7;
        private System.Windows.Forms.ColumnHeader colHead8;
        private System.Windows.Forms.ColumnHeader colHead9;
        private System.Windows.Forms.ColumnHeader colHead10;
        private System.Windows.Forms.ColumnHeader colHead11;
        private System.Windows.Forms.ColumnHeader colHead12;
        private System.Windows.Forms.ToolBar tbMain;
        private System.Windows.Forms.ToolBarButton tbbRefresh;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timerResize;
        private Barette.Library.UserControls.Client.ClientControl clientControl1;
        private System.Windows.Forms.ToolBarButton tbbShowClient;
        private System.Windows.Forms.ToolBarButton tbbShowSeanceTheorique;
        private System.Windows.Forms.Timer timerEnabled;
        private System.Windows.Forms.ColumnHeader colHeadTelephoneAutre;
        private System.Windows.Forms.ColumnHeader colHead13;
        private System.Windows.Forms.ColumnHeader colHead14;
        private System.Windows.Forms.ColumnHeader colHead15;
        private System.Windows.Forms.ToolBarButton tbbSeparator2;
        private System.Windows.Forms.ToolBarButton tbbActivateModePratique;
        private System.Windows.Forms.ToolBarButton tbbSeparator;
    }
}