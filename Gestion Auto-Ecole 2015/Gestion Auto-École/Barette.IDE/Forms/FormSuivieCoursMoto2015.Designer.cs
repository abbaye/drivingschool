namespace Barette.IDE.Forms
{
    partial class FormSuivieCoursMoto2015
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuivieCoursMoto2015));
            Barette.Library.Client.Customer customer3 = new Barette.Library.Client.Customer();
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            customer3.AttestationNumber1 = "";
            customer3.AttestationNumber2 = "";
            customer3.BVA = false;
            customer3.BVADate = new System.DateTime(2005, 2, 20, 18, 50, 33, 675);
            customer3.City = "";
            customer3.ClientNull = false;
            customer3.CodePostal = "   -";
            customer3.ContratNumber = "0";
            customer3.DateAttestation1 = new System.DateTime(2010, 6, 29, 19, 44, 39, 949);
            customer3.DateAttestation2 = new System.DateTime(2010, 6, 29, 19, 44, 39, 949);
            customer3.DateDebutCours = new System.DateTime(2010, 3, 10, 16, 11, 1, 688);
            customer3.DateExpiration = new System.DateTime(2010, 3, 10, 16, 11, 1, 688);
            customer3.DateInscription = new System.DateTime(2003, 8, 26, 0, 0, 0, 0);
            customer3.DateNaissance = new System.DateTime(2010, 3, 10, 16, 11, 1, 688);
            customer3.DateTemporaire = new System.DateTime(2005, 2, 20, 18, 50, 33, 675);
            customer3.DisponibilityAlway = false;
            customer3.DisponibilityAM = false;
            customer3.DisponibilityDimanche = false;
            customer3.DisponibilityPM = false;
            customer3.DisponibilitySamedi = false;
            customer3.DisponibilitySoirer = false;
            customer3.Email = "";
            customer3.FirstName = "";
            customer3.HaveTemporaire = false;
            customer3.LastRecuNumber = "";
            customer3.LocationAutomobile = false;
            customer3.LocationMoto = false;
            customer3.MontantCours = "";
            customer3.MontantLocation = "0 $";
            customer3.Name = "";
            customer3.No6R = "";
            customer3.Notes = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3084{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
    "ans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            customer3.NumeroGroupe = 0;
            customer3.NumeroPermis = "";
            customer3.Phone = "(   )   -";
            customer3.PhoneBureau = "(   )   -";
            customer3.ProgramMoto = Barette.Library.Client.ProgramMoto.Nothing;
            customer3.Solde = "0 $";
            customer3.StreetApp = "";
            customer3.StreetName = "";
            customer3.StreetNumber = "";
            customer3.TauxHorairePratique = "";
            customer3.TauxHoraireTheorique = "";
            customer3.TypeClient = Barette.Library.Client.ProfileType.Actif;
            customer3.TypeVehicule = Barette.Library.Client.VehiculeType.Automatique;
            this.clientControl1.Client = customer3;
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
            this.colHead9});
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tous",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox1.Location = new System.Drawing.Point(907, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 21);
            this.comboBox1.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(716, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Rechercher par numéro de cours";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Barette.IDE.Properties.Resources.search_icon;
            this.pictureBox1.Location = new System.Drawing.Point(1003, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // FormSuivieCoursMoto2015
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1040, 697);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.clientControl1);
            this.Controls.Add(this.ListCours);
            this.Controls.Add(this.tbMain);
            this.Name = "FormSuivieCoursMoto2015";
            this.Text = "Suivie des cours";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolBar tbMain;
        private System.Windows.Forms.ToolBarButton tbbRefresh;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timerResize;
        private Barette.Library.UserControls.Client.ClientControl clientControl1;
        private System.Windows.Forms.ToolBarButton tbbShowClient;
        private System.Windows.Forms.ToolBarButton tbbShowSeanceTheorique;
        private System.Windows.Forms.Timer timerEnabled;
        private System.Windows.Forms.ColumnHeader colHeadTelephoneAutre;
        private System.Windows.Forms.ToolBarButton tbbSeparator2;
        private System.Windows.Forms.ToolBarButton tbbActivateModePratique;
        private System.Windows.Forms.ToolBarButton tbbSeparator;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}