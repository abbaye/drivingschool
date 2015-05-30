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
	public class FormLigueSecuriter : Form
    {
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

            _FormMain = main;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLigueSecuriter));
            Barette.Library.Client.Customer customer5 = new Barette.Library.Client.Customer();
            cmdEqual = new System.Windows.Forms.Button();
            mcLigue2 = new System.Windows.Forms.MonthCalendar();
            mcLigue1 = new System.Windows.Forms.MonthCalendar();
            chkDisponibilityPM = new System.Windows.Forms.CheckBox();
            chkDisponibilityAM = new System.Windows.Forms.CheckBox();
            imageList1 = new System.Windows.Forms.ImageList(components);
            toolBar1 = new System.Windows.Forms.ToolBar();
            ttbRefresh = new System.Windows.Forms.ToolBarButton();
            tbbSeparator = new System.Windows.Forms.ToolBarButton();
            tbbShowClient = new System.Windows.Forms.ToolBarButton();
            tbbSeparator1 = new System.Windows.Forms.ToolBarButton();
            tbbPrintClientInfo = new System.Windows.Forms.ToolBarButton();
            tbbTPSTVQ = new System.Windows.Forms.ToolBarButton();
            timer1 = new System.Windows.Forms.Timer(components);
            PrintRelever = new System.Drawing.Printing.PrintDocument();
            cbAutoFind = new System.Windows.Forms.CheckBox();
            ImageListSmall = new System.Windows.Forms.ImageList(components);
            groupBox1 = new System.Windows.Forms.GroupBox();
            cbFindAll = new System.Windows.Forms.RadioButton();
            cbFindMoto = new System.Windows.Forms.RadioButton();
            cbFindAuto = new System.Windows.Forms.RadioButton();
            listFindResult = new Barette.Library.Listview.ListViewEx();
            colheadContratNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colheadDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colheadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colHeadAdresseComplete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colHeadNumeroPermis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colHeadDateNaissance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colHeadPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colHeadAttestationNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            clientControl1 = new Barette.Library.UserControls.Client.ClientControl();
            cbfindCyclomoteur = new System.Windows.Forms.RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmdEqual
            // 
            cmdEqual.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdEqual.Location = new System.Drawing.Point(247, 121);
            cmdEqual.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            cmdEqual.Name = "cmdEqual";
            cmdEqual.Size = new System.Drawing.Size(48, 23);
            cmdEqual.TabIndex = 9;
            cmdEqual.Text = "=";
            cmdEqual.Click += new System.EventHandler(cmdEqual_Click);
            // 
            // mcLigue2
            // 
            mcLigue2.Location = new System.Drawing.Point(302, 52);
            mcLigue2.Margin = new System.Windows.Forms.Padding(4, 9, 9, 9);
            mcLigue2.MaxSelectionCount = 1;
            mcLigue2.Name = "mcLigue2";
            mcLigue2.TabIndex = 4;
            mcLigue2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(mcRecu2_DateChanged);
            // 
            // mcLigue1
            // 
            mcLigue1.Location = new System.Drawing.Point(8, 52);
            mcLigue1.MaxSelectionCount = 1;
            mcLigue1.Name = "mcLigue1";
            mcLigue1.TabIndex = 3;
            mcLigue1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(mcRecu1_DateChanged);
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
            imageList1.Images.SetKeyName(4, "");
            imageList1.Images.SetKeyName(5, "");
            // 
            // toolBar1
            // 
            toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            toolBar1.AutoSize = false;
            toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            ttbRefresh,
            tbbSeparator,
            tbbShowClient,
            tbbSeparator1,
            tbbPrintClientInfo,
            tbbTPSTVQ});
            toolBar1.Divider = false;
            toolBar1.Dock = System.Windows.Forms.DockStyle.None;
            toolBar1.DropDownArrows = true;
            toolBar1.ImageList = imageList1;
            toolBar1.Location = new System.Drawing.Point(8, 8);
            toolBar1.Name = "toolBar1";
            toolBar1.ShowToolTips = true;
            toolBar1.Size = new System.Drawing.Size(329, 42);
            toolBar1.TabIndex = 13;
            toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(toolBar1_ButtonClick);
            // 
            // ttbRefresh
            // 
            ttbRefresh.ImageIndex = 4;
            ttbRefresh.Name = "ttbRefresh";
            ttbRefresh.Tag = "REFRESH";
            ttbRefresh.ToolTipText = "Rafraîchir la recherche";
            // 
            // tbbSeparator
            // 
            tbbSeparator.Name = "tbbSeparator";
            tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbShowClient
            // 
            tbbShowClient.ImageIndex = 3;
            tbbShowClient.Name = "tbbShowClient";
            tbbShowClient.Tag = "SHOWCLIENT";
            tbbShowClient.ToolTipText = "Affiche le client";
            // 
            // tbbSeparator1
            // 
            tbbSeparator1.Name = "tbbSeparator1";
            tbbSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbPrintClientInfo
            // 
            tbbPrintClientInfo.ImageIndex = 0;
            tbbPrintClientInfo.Name = "tbbPrintClientInfo";
            tbbPrintClientInfo.Tag = "PRINT";
            tbbPrintClientInfo.Text = "Infos Client";
            // 
            // tbbTPSTVQ
            // 
            tbbTPSTVQ.ImageIndex = 0;
            tbbTPSTVQ.Name = "tbbTPSTVQ";
            tbbTPSTVQ.Tag = "RAPPORTLIGUESECUR";
            tbbTPSTVQ.Text = "Rapport";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 200;
            timer1.Tick += new System.EventHandler(timer1_Tick);
            // 
            // PrintRelever
            // 
            PrintRelever.DocumentName = "Rapport Ligue Sécurité";
            PrintRelever.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintRelever_PrintPage);
            // 
            // cbAutoFind
            // 
            cbAutoFind.Checked = true;
            cbAutoFind.CheckState = System.Windows.Forms.CheckState.Checked;
            cbAutoFind.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cbAutoFind.Location = new System.Drawing.Point(8, 219);
            cbAutoFind.Name = "cbAutoFind";
            cbAutoFind.Size = new System.Drawing.Size(232, 24);
            cbAutoFind.TabIndex = 17;
            cbAutoFind.Text = "Recherche automatique lors d\'un clique";
            cbAutoFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cbAutoFind.CheckedChanged += new System.EventHandler(cbAutoFind_CheckedChanged);
            // 
            // ImageListSmall
            // 
            ImageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListSmall.ImageStream")));
            ImageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            ImageListSmall.Images.SetKeyName(0, "Moto");
            ImageListSmall.Images.SetKeyName(1, "Auto");
            ImageListSmall.Images.SetKeyName(2, "Camion");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbfindCyclomoteur);
            groupBox1.Controls.Add(cbFindAll);
            groupBox1.Controls.Add(cbFindMoto);
            groupBox1.Controls.Add(cbFindAuto);
            groupBox1.Location = new System.Drawing.Point(541, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(185, 162);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Options de recherche";
            // 
            // cbFindAll
            // 
            cbFindAll.AutoSize = true;
            cbFindAll.Checked = true;
            cbFindAll.Location = new System.Drawing.Point(48, 106);
            cbFindAll.Name = "cbFindAll";
            cbFindAll.Size = new System.Drawing.Size(49, 17);
            cbFindAll.TabIndex = 2;
            cbFindAll.TabStop = true;
            cbFindAll.Text = "Tous";
            cbFindAll.UseVisualStyleBackColor = true;
            cbFindAll.Click += new System.EventHandler(cbFindAll_Click);
            // 
            // cbFindMoto
            // 
            cbFindMoto.AutoSize = true;
            cbFindMoto.Location = new System.Drawing.Point(48, 60);
            cbFindMoto.Name = "cbFindMoto";
            cbFindMoto.Size = new System.Drawing.Size(86, 17);
            cbFindMoto.TabIndex = 1;
            cbFindMoto.Text = "Motocyclette";
            cbFindMoto.UseVisualStyleBackColor = true;
            cbFindMoto.Click += new System.EventHandler(cbFindMoto_Click);
            // 
            // cbFindAuto
            // 
            cbFindAuto.AutoSize = true;
            cbFindAuto.Location = new System.Drawing.Point(48, 37);
            cbFindAuto.Name = "cbFindAuto";
            cbFindAuto.Size = new System.Drawing.Size(77, 17);
            cbFindAuto.TabIndex = 0;
            cbFindAuto.Text = "Automobile";
            cbFindAuto.UseVisualStyleBackColor = true;
            cbFindAuto.Click += new System.EventHandler(cbFindAuto_Click);
            // 
            // listFindResult
            // 
            listFindResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            listFindResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            colheadContratNumber,
            colheadDate,
            colheadName,
            colHeadAdresseComplete,
            colHeadNumeroPermis,
            colHeadDateNaissance,
            colHeadPhone,
            colHeadAttestationNumber});
            listFindResult.FullRowSelect = true;
            listFindResult.HideSelection = false;
            listFindResult.Location = new System.Drawing.Point(8, 241);
            listFindResult.MultiSelect = false;
            listFindResult.Name = "listFindResult";
            listFindResult.Size = new System.Drawing.Size(904, 262);
            listFindResult.SmallImageList = ImageListSmall;
            listFindResult.TabIndex = 0;
            listFindResult.UseCompatibleStateImageBehavior = false;
            listFindResult.View = System.Windows.Forms.View.Details;
            listFindResult.Click += new System.EventHandler(listFindResult_Click);
            // 
            // colheadContratNumber
            // 
            colheadContratNumber.Text = "No. Contrat";
            colheadContratNumber.Width = 66;
            // 
            // colheadDate
            // 
            colheadDate.Text = "Date inscription";
            colheadDate.Width = 91;
            // 
            // colheadName
            // 
            colheadName.Text = "Nom du client";
            colheadName.Width = 156;
            // 
            // colHeadAdresseComplete
            // 
            colHeadAdresseComplete.Text = "Adresse complete";
            colHeadAdresseComplete.Width = 237;
            // 
            // colHeadNumeroPermis
            // 
            colHeadNumeroPermis.Text = "No. Permis";
            colHeadNumeroPermis.Width = 70;
            // 
            // colHeadDateNaissance
            // 
            colHeadDateNaissance.Text = "Date Naissance";
            colHeadDateNaissance.Width = 74;
            // 
            // colHeadPhone
            // 
            colHeadPhone.Text = "Téléphone";
            colHeadPhone.Width = 91;
            // 
            // colHeadAttestationNumber
            // 
            colHeadAttestationNumber.Text = "No. attestation";
            colHeadAttestationNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            colHeadAttestationNumber.Width = 94;
            // 
            // clientControl1
            // 
            clientControl1.AutoUpdate = true;
            clientControl1.BackColor = System.Drawing.SystemColors.Control;
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
            clientControl1.Client = customer5;
            clientControl1.Location = new System.Drawing.Point(761, 23);
            clientControl1.Name = "clientControl1";
            clientControl1.School = null;
            clientControl1.Size = new System.Drawing.Size(121, 121);
            clientControl1.TabIndex = 15;
            clientControl1.Visible = false;
            // 
            // cbfindCyclomoteur
            // 
            cbfindCyclomoteur.AutoSize = true;
            cbfindCyclomoteur.Location = new System.Drawing.Point(48, 83);
            cbfindCyclomoteur.Name = "cbfindCyclomoteur";
            cbfindCyclomoteur.Size = new System.Drawing.Size(83, 17);
            cbfindCyclomoteur.TabIndex = 3;
            cbfindCyclomoteur.Text = "Cyclomoteur";
            cbfindCyclomoteur.UseVisualStyleBackColor = true;
            cbfindCyclomoteur.Click += new System.EventHandler(cbfindCyclomoteur_Click);
            // 
            // FormLigueSecuriter
            // 
            ClientSize = new System.Drawing.Size(920, 518);
            Controls.Add(groupBox1);
            Controls.Add(listFindResult);
            Controls.Add(cbAutoFind);
            Controls.Add(clientControl1);
            Controls.Add(toolBar1);
            Controls.Add(cmdEqual);
            Controls.Add(mcLigue2);
            Controls.Add(mcLigue1);
            Name = "FormLigueSecuriter";
            Text = "FormLigueSecur";
            Load += new System.EventHandler(FormFindClient_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

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
			CustomerCollection ClientList = _FormMain.ClientList;

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
            CustomerCollection ClientList = _FormMain.ClientList;

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
			CustomerCollection ClientList = _FormMain.ClientList;

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
                    _FormMain.CreationListClient(listFindResult.SelectedItems[0].Text);
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

