using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO; 
using System.Diagnostics;

using Barette.Library.Win32;
using Barette.Library.Client;
using Barette.Library.Collections;
using Barette.Library.Listview;
using Barette.Library.UserControls;
using Barette.Library.UserControls.Client;


namespace Barette.IDE.Forms.LigueSecuriter {
	/// <summary>
	/// Description résumée de FormFindClient.
	/// </summary>
	public class FormLigueSecuriter : System.Windows.Forms.Form {
		/// <summary>
		/// acces a la Fenetre principal
		/// </summary>		
		public FormMain _FormMain = null;
		private System.Windows.Forms.CheckBox chkDisponibilityPM;
		private System.Windows.Forms.CheckBox chkDisponibilityAM;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolBarButton tbbShowClient;
		private System.Windows.Forms.ToolBarButton tbbSeparator1;
		private System.Windows.Forms.MonthCalendar mcLigue1;
		private System.Windows.Forms.MonthCalendar mcLigue2;
		private System.Windows.Forms.Button cmdEqual;		
		private System.Drawing.Printing.PrintDocument PrintRelever;
		private System.Windows.Forms.ToolBarButton ttbRefresh;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbPrintClientInfo;
		private System.Windows.Forms.CheckBox cbAutoFind;
		private System.ComponentModel.IContainer components;
		private ToolBarButton tbbTPSTVQ;
		private ClientControl clientControl1;
		private ListViewEx listFindResult;
		private ColumnHeader colheadContratNumber;
		private ColumnHeader colheadName;
		private ColumnHeader colHeadPhone;
        private ColumnHeader colheadDate;
        private ColumnHeader colHeadAdresseComplete;
		private ColumnHeader colHeadAttestationNumber;
        private GroupBox groupBox1;
        private RadioButton cbFindAll;
        private RadioButton cbFindMoto;
        private RadioButton cbFindAuto;
        private ColumnHeader colHeadNumeroPermis;
        private ColumnHeader colHeadDateNaissance;
		private ImageList ImageListSmall;
        private RadioButton cbfindCyclomoteur;
        
        private enum TypeRapport {
            Auto,
            Moto,
            Cyclomoteur,
            All
        }

        private TypeRapport RapportType = TypeRapport.All; 

		public FormLigueSecuriter(FormMain main) {
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			this._FormMain = main;

			//StaticBorder.ThinBorder(listFindResult.Handle.ToInt32(), true);

			SortByDate();
			Find();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLigueSecuriter));
            Barette.Library.Client.Customer customer5 = new Barette.Library.Client.Customer();
            this.cmdEqual = new System.Windows.Forms.Button();
            this.mcLigue2 = new System.Windows.Forms.MonthCalendar();
            this.mcLigue1 = new System.Windows.Forms.MonthCalendar();
            this.chkDisponibilityPM = new System.Windows.Forms.CheckBox();
            this.chkDisponibilityAM = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.ttbRefresh = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbShowClient = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator1 = new System.Windows.Forms.ToolBarButton();
            this.tbbPrintClientInfo = new System.Windows.Forms.ToolBarButton();
            this.tbbTPSTVQ = new System.Windows.Forms.ToolBarButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PrintRelever = new System.Drawing.Printing.PrintDocument();
            this.cbAutoFind = new System.Windows.Forms.CheckBox();
            this.ImageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFindAll = new System.Windows.Forms.RadioButton();
            this.cbFindMoto = new System.Windows.Forms.RadioButton();
            this.cbFindAuto = new System.Windows.Forms.RadioButton();
            this.listFindResult = new Barette.Library.Listview.ListViewEx();
            this.colheadContratNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadAdresseComplete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadNumeroPermis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadDateNaissance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadAttestationNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientControl1 = new Barette.Library.UserControls.Client.ClientControl();
            this.cbfindCyclomoteur = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdEqual
            // 
            this.cmdEqual.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdEqual.Location = new System.Drawing.Point(247, 121);
            this.cmdEqual.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.cmdEqual.Name = "cmdEqual";
            this.cmdEqual.Size = new System.Drawing.Size(48, 23);
            this.cmdEqual.TabIndex = 9;
            this.cmdEqual.Text = "=";
            this.cmdEqual.Click += new System.EventHandler(this.cmdEqual_Click);
            // 
            // mcLigue2
            // 
            this.mcLigue2.Location = new System.Drawing.Point(302, 52);
            this.mcLigue2.Margin = new System.Windows.Forms.Padding(4, 9, 9, 9);
            this.mcLigue2.MaxSelectionCount = 1;
            this.mcLigue2.Name = "mcLigue2";
            this.mcLigue2.TabIndex = 4;
            this.mcLigue2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcRecu2_DateChanged);
            // 
            // mcLigue1
            // 
            this.mcLigue1.Location = new System.Drawing.Point(8, 52);
            this.mcLigue1.MaxSelectionCount = 1;
            this.mcLigue1.Name = "mcLigue1";
            this.mcLigue1.TabIndex = 3;
            this.mcLigue1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcRecu1_DateChanged);
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
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            // 
            // toolBar1
            // 
            this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBar1.AutoSize = false;
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.ttbRefresh,
            this.tbbSeparator,
            this.tbbShowClient,
            this.tbbSeparator1,
            this.tbbPrintClientInfo,
            this.tbbTPSTVQ});
            this.toolBar1.Divider = false;
            this.toolBar1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Location = new System.Drawing.Point(8, 8);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(329, 42);
            this.toolBar1.TabIndex = 13;
            this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // ttbRefresh
            // 
            this.ttbRefresh.ImageIndex = 4;
            this.ttbRefresh.Name = "ttbRefresh";
            this.ttbRefresh.Tag = "REFRESH";
            this.ttbRefresh.ToolTipText = "Rafraîchir la recherche";
            // 
            // tbbSeparator
            // 
            this.tbbSeparator.Name = "tbbSeparator";
            this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbShowClient
            // 
            this.tbbShowClient.ImageIndex = 3;
            this.tbbShowClient.Name = "tbbShowClient";
            this.tbbShowClient.Tag = "SHOWCLIENT";
            this.tbbShowClient.ToolTipText = "Affiche le client";
            // 
            // tbbSeparator1
            // 
            this.tbbSeparator1.Name = "tbbSeparator1";
            this.tbbSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbPrintClientInfo
            // 
            this.tbbPrintClientInfo.ImageIndex = 0;
            this.tbbPrintClientInfo.Name = "tbbPrintClientInfo";
            this.tbbPrintClientInfo.Tag = "PRINT";
            this.tbbPrintClientInfo.Text = "Infos Client";
            // 
            // tbbTPSTVQ
            // 
            this.tbbTPSTVQ.ImageIndex = 0;
            this.tbbTPSTVQ.Name = "tbbTPSTVQ";
            this.tbbTPSTVQ.Tag = "RAPPORTLIGUESECUR";
            this.tbbTPSTVQ.Text = "Rapport";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PrintRelever
            // 
            this.PrintRelever.DocumentName = "Rapport Ligue Sécurité";
            this.PrintRelever.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintRelever_PrintPage);
            // 
            // cbAutoFind
            // 
            this.cbAutoFind.Checked = true;
            this.cbAutoFind.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoFind.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbAutoFind.Location = new System.Drawing.Point(8, 219);
            this.cbAutoFind.Name = "cbAutoFind";
            this.cbAutoFind.Size = new System.Drawing.Size(232, 24);
            this.cbAutoFind.TabIndex = 17;
            this.cbAutoFind.Text = "Recherche automatique lors d\'un clique";
            this.cbAutoFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAutoFind.CheckedChanged += new System.EventHandler(this.cbAutoFind_CheckedChanged);
            // 
            // ImageListSmall
            // 
            this.ImageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListSmall.ImageStream")));
            this.ImageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListSmall.Images.SetKeyName(0, "Moto");
            this.ImageListSmall.Images.SetKeyName(1, "Auto");
            this.ImageListSmall.Images.SetKeyName(2, "Camion");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbfindCyclomoteur);
            this.groupBox1.Controls.Add(this.cbFindAll);
            this.groupBox1.Controls.Add(this.cbFindMoto);
            this.groupBox1.Controls.Add(this.cbFindAuto);
            this.groupBox1.Location = new System.Drawing.Point(541, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 162);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options de recherche";
            // 
            // cbFindAll
            // 
            this.cbFindAll.AutoSize = true;
            this.cbFindAll.Checked = true;
            this.cbFindAll.Location = new System.Drawing.Point(48, 106);
            this.cbFindAll.Name = "cbFindAll";
            this.cbFindAll.Size = new System.Drawing.Size(49, 17);
            this.cbFindAll.TabIndex = 2;
            this.cbFindAll.TabStop = true;
            this.cbFindAll.Text = "Tous";
            this.cbFindAll.UseVisualStyleBackColor = true;
            this.cbFindAll.Click += new System.EventHandler(this.cbFindAll_Click);
            // 
            // cbFindMoto
            // 
            this.cbFindMoto.AutoSize = true;
            this.cbFindMoto.Location = new System.Drawing.Point(48, 60);
            this.cbFindMoto.Name = "cbFindMoto";
            this.cbFindMoto.Size = new System.Drawing.Size(86, 17);
            this.cbFindMoto.TabIndex = 1;
            this.cbFindMoto.Text = "Motocyclette";
            this.cbFindMoto.UseVisualStyleBackColor = true;
            this.cbFindMoto.Click += new System.EventHandler(this.cbFindMoto_Click);
            // 
            // cbFindAuto
            // 
            this.cbFindAuto.AutoSize = true;
            this.cbFindAuto.Location = new System.Drawing.Point(48, 37);
            this.cbFindAuto.Name = "cbFindAuto";
            this.cbFindAuto.Size = new System.Drawing.Size(77, 17);
            this.cbFindAuto.TabIndex = 0;
            this.cbFindAuto.Text = "Automobile";
            this.cbFindAuto.UseVisualStyleBackColor = true;
            this.cbFindAuto.Click += new System.EventHandler(this.cbFindAuto_Click);
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
            this.colHeadAdresseComplete,
            this.colHeadNumeroPermis,
            this.colHeadDateNaissance,
            this.colHeadPhone,
            this.colHeadAttestationNumber});
            this.listFindResult.FullRowSelect = true;
            this.listFindResult.HideSelection = false;
            this.listFindResult.Location = new System.Drawing.Point(8, 241);
            this.listFindResult.MultiSelect = false;
            this.listFindResult.Name = "listFindResult";
            this.listFindResult.Size = new System.Drawing.Size(904, 262);
            this.listFindResult.SmallImageList = this.ImageListSmall;
            this.listFindResult.TabIndex = 0;
            this.listFindResult.UseCompatibleStateImageBehavior = false;
            this.listFindResult.View = System.Windows.Forms.View.Details;
            this.listFindResult.Click += new System.EventHandler(this.listFindResult_Click);
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
            this.colheadName.Width = 156;
            // 
            // colHeadAdresseComplete
            // 
            this.colHeadAdresseComplete.Text = "Adresse complete";
            this.colHeadAdresseComplete.Width = 237;
            // 
            // colHeadNumeroPermis
            // 
            this.colHeadNumeroPermis.Text = "No. Permis";
            this.colHeadNumeroPermis.Width = 70;
            // 
            // colHeadDateNaissance
            // 
            this.colHeadDateNaissance.Text = "Date Naissance";
            this.colHeadDateNaissance.Width = 74;
            // 
            // colHeadPhone
            // 
            this.colHeadPhone.Text = "Téléphone";
            this.colHeadPhone.Width = 91;
            // 
            // colHeadAttestationNumber
            // 
            this.colHeadAttestationNumber.Text = "No. attestation";
            this.colHeadAttestationNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colHeadAttestationNumber.Width = 94;
            // 
            // clientControl1
            // 
            this.clientControl1.AutoUpdate = true;
            this.clientControl1.BackColor = System.Drawing.SystemColors.Control;
            customer5.AttestationNumber1 = "";
            customer5.AttestationNumber2 = "";
            customer5.BVA = false;
            customer5.BVADate = new System.DateTime(2005, 2, 20, 21, 27, 11, 328);
            customer5.City = "";
            customer5.ClientNull = false;
            customer5.CodePostal = "   -";
            customer5.ContratNumber = "0";
            customer5.DateAttestation1 = new System.DateTime(2010, 5, 27, 12, 38, 39, 217);
            customer5.DateAttestation2 = new System.DateTime(2010, 5, 27, 12, 38, 39, 217);
            customer5.DateDebutCours = new System.DateTime(2010, 3, 11, 8, 31, 48, 196);
            customer5.DateExpiration = new System.DateTime(2010, 3, 11, 8, 31, 48, 196);
            customer5.DateInscription = new System.DateTime(2003, 8, 26, 0, 0, 0, 0);
            customer5.DateNaissance = new System.DateTime(2010, 3, 11, 8, 31, 48, 196);
            customer5.DateTemporaire = new System.DateTime(2005, 2, 20, 21, 27, 11, 328);
            customer5.DisponibilityAM = false;
            customer5.DisponibilityDimanche = false;
            customer5.DisponibilityPM = false;
            customer5.DisponibilitySamedi = false;
            customer5.DisponibilitySoirer = false;
            customer5.FirstName = "";
            customer5.HaveTemporaire = false;
            customer5.LastRecuNumber = "";
            customer5.LocationAutomobile = false;
            customer5.LocationMoto = false;
            customer5.MontantCours = "";
            customer5.MontantLocation = "0 $";
            customer5.Name = "";
            customer5.No6R = "";
            customer5.Notes = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3084{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
                "ans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            customer5.NumeroPermis = "";
            customer5.Phone = "(418)418-418";
            customer5.PhoneBureau = "(418)418-418";
            customer5.Solde = "0 $";
            customer5.StreetApp = "";
            customer5.StreetName = "";
            customer5.StreetNumber = "";
            customer5.TauxHorairePratique = "";
            customer5.TauxHoraireTheorique = "";
            customer5.TypeClient = Barette.Library.Client.ProfileType.Actif;
            customer5.TypeVehicule = Barette.Library.Client.VehiculeType.Automatique;
            this.clientControl1.Client = customer5;
            this.clientControl1.Location = new System.Drawing.Point(761, 23);
            this.clientControl1.Name = "clientControl1";
            this.clientControl1.School = null;
            this.clientControl1.Size = new System.Drawing.Size(121, 121);
            this.clientControl1.TabIndex = 15;
            this.clientControl1.Visible = false;
            // 
            // cbfindCyclomoteur
            // 
            this.cbfindCyclomoteur.AutoSize = true;
            this.cbfindCyclomoteur.Location = new System.Drawing.Point(48, 83);
            this.cbfindCyclomoteur.Name = "cbfindCyclomoteur";
            this.cbfindCyclomoteur.Size = new System.Drawing.Size(83, 17);
            this.cbfindCyclomoteur.TabIndex = 3;
            this.cbfindCyclomoteur.Text = "Cyclomoteur";
            this.cbfindCyclomoteur.UseVisualStyleBackColor = true;
            this.cbfindCyclomoteur.Click += new System.EventHandler(this.cbfindCyclomoteur_Click);
            // 
            // FormLigueSecuriter
            // 
            this.ClientSize = new System.Drawing.Size(920, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listFindResult);
            this.Controls.Add(this.cbAutoFind);
            this.Controls.Add(this.clientControl1);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.cmdEqual);
            this.Controls.Add(this.mcLigue2);
            this.Controls.Add(this.mcLigue1);
            this.Name = "FormLigueSecuriter";
            this.Text = "FormLigueSecur";
            this.Load += new System.EventHandler(this.FormFindClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region Methodes
		/// <summary>
		/// Trie par date
		/// </summary>
		private void SortByDate(){
			listFindResult.SortColumn(3);
		}

		private void Find(){
			listFindResult.Items.Clear();

			Cursor.Current = Cursors.WaitCursor;

            //Recherche tous les enregistrements
            if (cbFindAll.Checked == true) {
                RapportType = TypeRapport.All; 
                FindLigue();
            }
            else if (cbFindAuto.Checked == true) {
                //Recherche tous sauf les motos
                RapportType = TypeRapport.Auto;
                FindLigue(VehiculeType.Automobile);
            }
            else if (cbFindMoto.Checked == true) {
                //Recherche les motos
                RapportType = TypeRapport.Moto;
                FindLigue(VehiculeType.Moto);
            } 
            else if (cbfindCyclomoteur.Checked == true) {
                //Recherche les motos
                RapportType = TypeRapport.Cyclomoteur;
                FindLigue(VehiculeType.Cyclomoteur);
            }
			Cursor.Current = Cursors.Default;
		}

		/// <summary>
		/// Recherche par date de recu incluant un type de char
		/// </summary>
		private void FindLigue(VehiculeType typeChar) {
			CustomerCollection ClientList = this._FormMain.ClientList;

            switch (typeChar) {
                case VehiculeType.Automobile:
                    for (int i = 0; i < ClientList.Count; i++) {
                        if ((mcLigue1.SelectionStart.Date <= ClientList[i].DateInscription.Date) &&
                            (mcLigue2.SelectionStart.Date >= ClientList[i].DateInscription.Date))
                            if (!ClientList[i].ClientNull && (ClientList[i].TypeVehicule == VehiculeType.Manuel || ClientList[i].TypeVehicule == VehiculeType.Automatique))
                                AddClientToList(ClientList[i]);

                    }
                    break;
                case VehiculeType.Cyclomoteur:
                    for (int i = 0; i < ClientList.Count; i++) {
                        if ((mcLigue1.SelectionStart.Date <= ClientList[i].DateInscription.Date) &&
                            (mcLigue2.SelectionStart.Date >= ClientList[i].DateInscription.Date))
                            if (!ClientList[i].ClientNull && (ClientList[i].TypeVehicule == VehiculeType.Cyclomoteur))
                                AddClientToList(ClientList[i]);

                    }
                    break;
                case VehiculeType.Moto:
                    for (int i = 0; i < ClientList.Count; i++) {
                        if ((mcLigue1.SelectionStart.Date <= ClientList[i].DateInscription.Date) &&
                            (mcLigue2.SelectionStart.Date >= ClientList[i].DateInscription.Date))
                            if (!ClientList[i].ClientNull && (ClientList[i].TypeVehicule == VehiculeType.Moto))
                                AddClientToList(ClientList[i]);

                    }
                    break;

                default:
                    for (int i = 0; i < ClientList.Count; i++) {
                        if ((mcLigue1.SelectionStart.Date <= ClientList[i].DateInscription.Date) &&
                            (mcLigue2.SelectionStart.Date >= ClientList[i].DateInscription.Date))
                            if (!ClientList[i].ClientNull && (ClientList[i].TypeVehicule == typeChar))
                                AddClientToList(ClientList[i]);

                    }
                    break;
            }
		}

        /// <summary>
        /// Recherche par date de recu
        /// </summary>
        private void FindLigue() {
            CustomerCollection ClientList = this._FormMain.ClientList;

            for (int i = 0; i < ClientList.Count; i++) {
                if ((mcLigue1.SelectionStart.Date <= ClientList[i].DateInscription.Date) &&
                    (mcLigue2.SelectionStart.Date >= ClientList[i].DateInscription.Date))
                    if (!ClientList[i].ClientNull)
                        AddClientToList(ClientList[i]);

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
            itm.SubItems.Add(client.DateInscription.ToShortDateString());
			itm.SubItems.Add(client.FirstName + " " + client.Name);
            itm.SubItems.Add(client.StreetNumber + " " + client.StreetName + " " + client.StreetApp + ", " + client.City + " " + client.CodePostal);
            itm.SubItems.Add(client.NumeroPermis);
            itm.SubItems.Add(client.DateNaissance.ToShortDateString());
            itm.SubItems.Add(client.Phone);
			itm.SubItems.Add(client.AttestationNumber1);

			switch (client.TypeVehicule) {
				case VehiculeType.Automatique:
					itm.ImageKey = "Auto";
					break;
				case VehiculeType.Cyclomoteur:
					itm.ImageKey = "Camion";
					break;
				case VehiculeType.Manuel:
					itm.ImageKey = "Auto";
					break;
				case VehiculeType.Moto:
					itm.ImageKey = "Moto";
					break;
			}

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
		/// Lance l'impression du document et initialise les variable global
		/// pour l'impression sur plusieurs pages.
		/// </summary>
		private void PrintDoc() {
			//assigne les variables par default
			_TotalPage = 0;
			_TotalPagePrinted = 1;
			_TotalLine = 0;
			_HeaderPrinted = false;
			_LinesPerPage = 0;
			_LinePrinted = -1;

			PrintRelever.DefaultPageSettings.Landscape = true;

#if DEBUG
			PrintPreviewDialog prev = new PrintPreviewDialog();
			prev.Document = PrintRelever;			
			prev.ShowDialog();

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
			Font printFont = new Font("Times New Roman", 8, FontStyle.Regular);
			Font printFontBold = new Font("Times New Roman", 10, FontStyle.Bold);
			Font printFontBold16 = new Font("Times New Roman", 14, FontStyle.Bold);

			float yPos = 0f;			
					
			#region Header
			if (_HeaderPrinted == false){
                //Ecriture du header (image)                
                Stream strm = Type.GetType("Barette.IDE.Forms.LigueSecuriter.FormLigueSecuriter").Assembly.GetManifestResourceStream("Barette.IDE.Resources.Printlogo.png");
                Bitmap img = new Bitmap(strm);
                e.Graphics.DrawImage(img, 0, 0, 192, 104);
                //topMargin = img.Height + 20;

				//Initialisation des variables dans le bloc header pour q'il ne le face qu'a la premiere page
				_TotalLine = listFindResult.Items.Count;
				_LinesPerPage = Convert.ToInt16((e.MarginBounds.Height - 30) / printFont.GetHeight(e.Graphics)); 				
				_TotalPage = Convert.ToInt16(Decimal.Round(Convert.ToDecimal(_TotalLine) / Convert.ToDecimal(_LinesPerPage), 0));

				if (_TotalLine > 41) _TotalPage += 1;

				if (_TotalPage == 0) _TotalPage =1;
				
				//Date(s) de relever : Choisi le bon type de Header a écrire
				yPos = topMargin + 5;
                e.Graphics.DrawString("Ligue de Sécurité du Québec - Régistre d'incription : " + GetTypeRapport(), printFontBold16, Brushes.Black, leftMargin + 200, yPos, new StringFormat());                
				yPos += printFontBold16.Height + 15 ;
                e.Graphics.DrawString("Relevé : " + mcLigue1.SelectionStart.Date.ToLongDateString() + " au " + mcLigue2.SelectionStart.Date.ToLongDateString(), printFontBold16, Brushes.Black, leftMargin + 200, yPos, new StringFormat());

				_HeaderPrinted = true; //Header Imprimé
			}
			#endregion

			//Entete des colones
			yPos += 50;			
            e.Graphics.DrawString("Date", printFontBold, Brushes.Black,             leftMargin + 50, yPos, new StringFormat());
            e.Graphics.DrawString("inscription", printFontBold, Brushes.Black,      leftMargin + 50, yPos + printFont.Height, new StringFormat());

			e.Graphics.DrawString("Nom du client" , printFontBold , Brushes.Black,  leftMargin + 125, yPos, new StringFormat());
            e.Graphics.DrawString("Adresse", printFontBold, Brushes.Black,          leftMargin + 300, yPos, new StringFormat());            
            e.Graphics.DrawString("No. Permis.", printFontBold, Brushes.Black,      leftMargin + 560, yPos, new StringFormat());            

            e.Graphics.DrawString("Date", printFontBold, Brushes.Black,             leftMargin + 660, yPos, new StringFormat());
            e.Graphics.DrawString("Naissance", printFontBold, Brushes.Black,        leftMargin + 660, yPos + printFont.Height, new StringFormat());			

            e.Graphics.DrawString("No.", printFontBold, Brushes.Black,              leftMargin + 740, yPos, new StringFormat());
            e.Graphics.DrawString("Contrat", printFontBold, Brushes.Black,          leftMargin + 740, yPos + printFont.Height, new StringFormat());

			e.Graphics.DrawString("T / TP" , printFontBold , Brushes.Black,         leftMargin + 800, yPos, new StringFormat());
            e.Graphics.DrawString("Téléphone", printFontBold, Brushes.Black,        leftMargin + 875, yPos, new StringFormat());
			
            e.Graphics.DrawString("No.", printFontBold, Brushes.Black,              leftMargin + 950, yPos, new StringFormat());
            e.Graphics.DrawString("Attestation", printFontBold, Brushes.Black,      leftMargin + 950, yPos + printFont.Height, new StringFormat());
			
			//Creation de l'objet client
			Customer client = null;

            yPos += printFont.Height + 20;			
			//Impression de toute les lignes du tableau
			while (_LinePrinted < listFindResult.Items.Count -1){				
				_LinePrinted++;

				client = GetClient(listFindResult.Items[_LinePrinted].Text);
				
				if (client != null){

					yPos += printFont.Height;
                    e.Graphics.DrawString((_LinePrinted + 1) + " - ", printFont, Brushes.Black, leftMargin + 5, yPos, new StringFormat());

                    e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[1].Text, printFont, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
					e.Graphics.DrawString(client.FirstName + " " + client.Name, printFont , Brushes.Black,               leftMargin + 125, yPos, new StringFormat());					
					e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[3].Text, printFont, Brushes.Black, leftMargin + 300, yPos, new StringFormat());
					e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[4].Text, printFont, Brushes.Black, leftMargin + 560, yPos, new StringFormat());
					e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[5].Text, printFont, Brushes.Black, leftMargin + 660, yPos, new StringFormat());
					e.Graphics.DrawString(listFindResult.Items[_LinePrinted].Text, printFont, Brushes.Black,             leftMargin + 740, yPos, new StringFormat());					
					e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[6].Text, printFont, Brushes.Black, leftMargin + 875, yPos, new StringFormat());
                    e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[7].Text, printFont, Brushes.Black, leftMargin + 950, yPos, new StringFormat());

                    //Print la case check 2x
                    //Ecriture du header (image)
                    Stream strm = Type.GetType("Barette.IDE.Forms.LigueSecuriter.FormLigueSecuriter").Assembly.GetManifestResourceStream("Barette.IDE.Resources.check.png");
                    Bitmap img = new Bitmap(strm);
                    e.Graphics.DrawImage(img, leftMargin + 800, yPos + 2);
                    e.Graphics.DrawString("/", printFontBold, Brushes.Black, leftMargin + 815, yPos, new StringFormat());
                    e.Graphics.DrawImage(img, leftMargin + 830, yPos + 2);

					#region Creation d'une nouvelle page et numéro de page
                    string PageNumber = "Page : " + _TotalPagePrinted.ToString(); // +"/" + _TotalPage.ToString();
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
					}else{
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

        /// <summary>
        /// Sert a determiner le type de rapport a imprimer
        /// </summary>
        /// <returns>Retourne un chaine de caractere</returns>
        private string GetTypeRapport() {
            switch (RapportType){
                case TypeRapport.All:
                    return "Automobile, Motocyclette et Cyclomoteur";
                case TypeRapport.Auto:
                    return "Automobile";
                case TypeRapport.Moto:
                    return "Motocyclette";
                case TypeRapport.Cyclomoteur:
                    return "Cyclomoteur";
            }

            return "";
        }


		/// <summary>
		/// Retourne un client basé sur un numéro de client
		/// </summary>
		/// <param name="ContratNumber">Retourne le client trouvé, si null aucun client n'a été trouvé</param>
		private Customer GetClient(string ContratNumber) {
			//Selection du bon client
			CustomerCollection ClientList = this._FormMain.ClientList;

			for (int i = 0; i< ClientList.Count; i++){
				if (ClientList[i].ContratNumber == ContratNumber) //Recherche par numero de contrat
					return ClientList[i];
			}

			return null;
		}
		#endregion

		private void FormFindClient_Load(object sender, System.EventArgs e) {
			
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e) {
			switch(e.Button.Tag.ToString()){
				case "PRINT":
                    clientControl1.PrintDoc(Barette.Library.UserControls.Client.PrintDocumentType.InfoClient);
					break;
				case "SHOWCLIENT":
					this._FormMain.CreationListClient(listFindResult.SelectedItems[0].Text);
					break;
				case "RAPPORTLIGUESECUR":
					PrintDoc();
					break;
				case "REFRESH":
					Find();
					break;
			}
		}

		private void listFindResult_Click(object sender, System.EventArgs e) {
			try{
				Customer client = GetClient(listFindResult.SelectedItems[0].Text);

				if (client != null)
					clientControl1.Client = GetClient(listFindResult.SelectedItems[0].Text);
			}
			catch{}
		}

		private void timer1_Tick(object sender, System.EventArgs e) {
			if (listFindResult.SelectedItems.Count == 0){
				tbbShowClient.Enabled = 
					tbbPrintClientInfo.Enabled = false;
			}
			else{
				tbbShowClient.Enabled = 
					tbbPrintClientInfo.Enabled = true;
			}

			if(listFindResult.Items.Count >0)
				tbbTPSTVQ.Enabled = true;
			else
				tbbTPSTVQ.Enabled = false;
		}

		private void cmdEqual_Click(object sender, System.EventArgs e) {
			mcLigue2.SelectionStart = mcLigue1.SelectionStart;
		}

		private void mcRecu1_DateChanged(object sender, System.Windows.Forms.DateRangeEventArgs e) {
			if (cbAutoFind.Checked == true)
				Find();
		}

		private void mcRecu2_DateChanged(object sender, System.Windows.Forms.DateRangeEventArgs e) {
			if (cbAutoFind.Checked == true)
				Find();
		}

		private void dtpFixeDate_ValueChanged(object sender, System.EventArgs e) {
			if (cbAutoFind.Checked == true)
				Find();
		}

		private void cbAutoFind_CheckedChanged(object sender, System.EventArgs e) {
			if (cbAutoFind.Checked == true)
				Find();			
		}


        private void cbFindAuto_Click(object sender, EventArgs e) {
            if (cbAutoFind.Checked == true)
                Find();
        }

        private void cbFindMoto_Click(object sender, EventArgs e) {
            if (cbAutoFind.Checked == true)
                Find();
        }

        private void cbFindAll_Click(object sender, EventArgs e) {
            if (cbAutoFind.Checked == true)
                Find();
        }

        private void cbfindCyclomoteur_Click(object sender, EventArgs e) {
            if (cbAutoFind.Checked == true)
                Find();
        }
	}
}

