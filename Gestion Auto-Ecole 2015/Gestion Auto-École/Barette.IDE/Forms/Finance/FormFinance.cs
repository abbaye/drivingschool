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


namespace Barette.IDE.Forms.Finance {
	/// <summary>
	/// Description résumée de FormFindClient.
	/// </summary>
	public class FormFinance : System.Windows.Forms.Form {
		/// <summary>
		/// acces a la Fenetre principal
		/// </summary>		
		public FormMain _FormMain = null;

		/// <summary>
		/// Type de relever
		/// </summary>
		private TypeRelever _ReleverMode = TypeRelever.Taxe; //taxe par défaut
 
		private System.Windows.Forms.CheckBox chkDisponibilityPM;
		private System.Windows.Forms.CheckBox chkDisponibilityAM;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolBarButton tbbShowClient;
		private System.Windows.Forms.ToolBarButton tbbSeparator1;
		private System.Windows.Forms.MonthCalendar mcRecu1;
		private System.Windows.Forms.MonthCalendar mcRecu2;
		private System.Windows.Forms.DateTimePicker dtpFixeDate;
		private System.Windows.Forms.Button cmdEqual;
		private System.Windows.Forms.RadioButton rbBetween;
		private System.Windows.Forms.RadioButton rbOr;
		private System.Windows.Forms.ToolBarButton tbbTPSTVQ;
		private System.Drawing.Printing.PrintDocument PrintRelever;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ToolBarButton ttbRefresh;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbShowSeance;
		private System.Windows.Forms.ToolBarButton tbbPrintClientInfo;
		private System.Windows.Forms.CheckBox cbAutoFind;
		private Label lblMontantIncluTaxe;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Label lblMontantExcluTaxe;
		private System.Windows.Forms.Label label3;
		private Label lblTVQ;
		private System.Windows.Forms.Label label4;
		private Label lblTPS;
		private System.Windows.Forms.Label label5;		
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label label6;
		//private System.Windows.Forms.ToolBarButton tbbHoraireInfo;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private Label lblMontantPD;
		private Label lblMontantCheque;
		private Label lblMontantAutre;
		private ImageList ImageListSmall;
		private TabControl tcRapportType;
		private TabPage tpRapportTaxe;
		private TabPage tpCompteARecevoir;
		private MonthCalendar mcCompteARecevoir;
		private Label lblMontantAC;
		public PourCentTextBox txtTPS;
		public PourCentTextBox txtTVQ;
		private ClientControl clientControl1;
		private ListViewEx listFindResult;
		private ColumnHeader colheadContratNumber;
		private ColumnHeader colheadName;
		private ColumnHeader colheadDate;
		private ColumnHeader colHeadPhone;
		private ColumnHeader colHeadTypeVehicule;
		private ColumnHeader colHeadSolde;
		private ColumnHeader colHeadLastRecuNumber;
		private ColumnHeader colHeadMontant;
		private ColumnHeader colHeadDateRecu;
		private ColumnHeader colHeadRL;
		private ColumnHeader colHeadTypePaiment;
		private System.Drawing.Printing.PrintDocument PrintCompteARecevoir;
        private ToolBarButton tbbHorraireInfo;
		private System.Windows.Forms.GroupBox groupBox2; 

		public FormFinance(FormMain main) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinance));
            Barette.Library.Client.Customer customer1 = new Barette.Library.Client.Customer();
            this.cmdEqual = new System.Windows.Forms.Button();
            this.rbOr = new System.Windows.Forms.RadioButton();
            this.rbBetween = new System.Windows.Forms.RadioButton();
            this.dtpFixeDate = new System.Windows.Forms.DateTimePicker();
            this.mcRecu2 = new System.Windows.Forms.MonthCalendar();
            this.mcRecu1 = new System.Windows.Forms.MonthCalendar();
            this.chkDisponibilityPM = new System.Windows.Forms.CheckBox();
            this.chkDisponibilityAM = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.ttbRefresh = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbHorraireInfo = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbShowClient = new System.Windows.Forms.ToolBarButton();
            this.tbbShowSeance = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator1 = new System.Windows.Forms.ToolBarButton();
            this.tbbPrintClientInfo = new System.Windows.Forms.ToolBarButton();
            this.tbbTPSTVQ = new System.Windows.Forms.ToolBarButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PrintRelever = new System.Drawing.Printing.PrintDocument();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTPS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTVQ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMontantExcluTaxe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMontantIncluTaxe = new System.Windows.Forms.Label();
            this.lblMontantPD = new System.Windows.Forms.Label();
            this.lblMontantCheque = new System.Windows.Forms.Label();
            this.cbAutoFind = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTPS = new Barette.Library.UserControls.PourCentTextBox();
            this.txtTVQ = new Barette.Library.UserControls.PourCentTextBox();
            this.ImageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.lblMontantAutre = new System.Windows.Forms.Label();
            this.tcRapportType = new System.Windows.Forms.TabControl();
            this.tpRapportTaxe = new System.Windows.Forms.TabPage();
            this.tpCompteARecevoir = new System.Windows.Forms.TabPage();
            this.mcCompteARecevoir = new System.Windows.Forms.MonthCalendar();
            this.lblMontantAC = new System.Windows.Forms.Label();
            this.PrintCompteARecevoir = new System.Drawing.Printing.PrintDocument();
            this.clientControl1 = new Barette.Library.UserControls.Client.ClientControl();
            this.listFindResult = new Barette.Library.Listview.ListViewEx();
            this.colheadContratNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadTypeVehicule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadSolde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadLastRecuNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadMontant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadDateRecu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadRL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadTypePaiment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tcRapportType.SuspendLayout();
            this.tpRapportTaxe.SuspendLayout();
            this.tpCompteARecevoir.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdEqual
            // 
            this.cmdEqual.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdEqual.Location = new System.Drawing.Point(248, 58);
            this.cmdEqual.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.cmdEqual.Name = "cmdEqual";
            this.cmdEqual.Size = new System.Drawing.Size(48, 23);
            this.cmdEqual.TabIndex = 9;
            this.cmdEqual.Text = "=";
            this.cmdEqual.Click += new System.EventHandler(this.cmdEqual_Click);
            // 
            // rbOr
            // 
            this.rbOr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbOr.Location = new System.Drawing.Point(240, 180);
            this.rbOr.Name = "rbOr";
            this.rbOr.Size = new System.Drawing.Size(72, 24);
            this.rbOr.TabIndex = 8;
            this.rbOr.Text = "Date fixe";
            // 
            // rbBetween
            // 
            this.rbBetween.Checked = true;
            this.rbBetween.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbBetween.Location = new System.Drawing.Point(240, 82);
            this.rbBetween.Margin = new System.Windows.Forms.Padding(3, 0, 4, 3);
            this.rbBetween.Name = "rbBetween";
            this.rbBetween.Size = new System.Drawing.Size(64, 24);
            this.rbBetween.TabIndex = 7;
            this.rbBetween.TabStop = true;
            this.rbBetween.Text = "Intervale";
            // 
            // dtpFixeDate
            // 
            this.dtpFixeDate.Location = new System.Drawing.Point(312, 180);
            this.dtpFixeDate.Name = "dtpFixeDate";
            this.dtpFixeDate.Size = new System.Drawing.Size(128, 20);
            this.dtpFixeDate.TabIndex = 6;
            this.dtpFixeDate.ValueChanged += new System.EventHandler(this.dtpFixeDate_ValueChanged);
            // 
            // mcRecu2
            // 
            this.mcRecu2.Location = new System.Drawing.Point(312, 12);
            this.mcRecu2.Margin = new System.Windows.Forms.Padding(4, 9, 9, 9);
            this.mcRecu2.MaxSelectionCount = 1;
            this.mcRecu2.Name = "mcRecu2";
            this.mcRecu2.TabIndex = 4;
            this.mcRecu2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcRecu2_DateChanged);
            // 
            // mcRecu1
            // 
            this.mcRecu1.Location = new System.Drawing.Point(9, 12);
            this.mcRecu1.MaxSelectionCount = 1;
            this.mcRecu1.Name = "mcRecu1";
            this.mcRecu1.TabIndex = 3;
            this.mcRecu1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcRecu1_DateChanged);
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
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.ttbRefresh,
            this.tbbSeparator,
            this.tbbHorraireInfo,
            this.tbbSeparator2,
            this.tbbShowClient,
            this.tbbShowSeance,
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
            this.toolBar1.Size = new System.Drawing.Size(376, 42);
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
            // tbbHorraireInfo
            // 
            this.tbbHorraireInfo.ImageIndex = 5;
            this.tbbHorraireInfo.Name = "tbbHorraireInfo";
            this.tbbHorraireInfo.Tag = "ETATSGLOBAL";
            this.tbbHorraireInfo.ToolTipText = "Affiche l\'état global de l\'année en court";
            // 
            // tbbSeparator2
            // 
            this.tbbSeparator2.Name = "tbbSeparator2";
            this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbShowClient
            // 
            this.tbbShowClient.ImageIndex = 3;
            this.tbbShowClient.Name = "tbbShowClient";
            this.tbbShowClient.Tag = "SHOWCLIENT";
            this.tbbShowClient.ToolTipText = "Affiche le client";
            // 
            // tbbShowSeance
            // 
            this.tbbShowSeance.ImageIndex = 1;
            this.tbbShowSeance.Name = "tbbShowSeance";
            this.tbbShowSeance.Tag = "OPENSEANCE";
            this.tbbShowSeance.ToolTipText = "Affiche la boîte de Paiment";
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
            this.tbbTPSTVQ.Tag = "RELEVERTPSTVQ";
            this.tbbTPSTVQ.Text = "Relevé";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PrintRelever
            // 
            this.PrintRelever.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintRelever_PrintPage);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblTPS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTVQ);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblMontantExcluTaxe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblMontantIncluTaxe);
            this.groupBox1.Location = new System.Drawing.Point(8, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 112);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information sur la période";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "TPS :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTPS
            // 
            this.lblTPS.ForeColor = System.Drawing.Color.Blue;
            this.lblTPS.Location = new System.Drawing.Point(135, 40);
            this.lblTPS.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.lblTPS.Name = "lblTPS";
            this.lblTPS.Size = new System.Drawing.Size(97, 16);
            this.lblTPS.TabIndex = 6;
            this.lblTPS.Text = "-";
            this.lblTPS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "TVQ :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTVQ
            // 
            this.lblTVQ.ForeColor = System.Drawing.Color.Blue;
            this.lblTVQ.Location = new System.Drawing.Point(135, 64);
            this.lblTVQ.Name = "lblTVQ";
            this.lblTVQ.Size = new System.Drawing.Size(97, 16);
            this.lblTVQ.TabIndex = 4;
            this.lblTVQ.Text = "-";
            this.lblTVQ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total partiel :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMontantExcluTaxe
            // 
            this.lblMontantExcluTaxe.ForeColor = System.Drawing.Color.Blue;
            this.lblMontantExcluTaxe.Location = new System.Drawing.Point(135, 16);
            this.lblMontantExcluTaxe.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.lblMontantExcluTaxe.Name = "lblMontantExcluTaxe";
            this.lblMontantExcluTaxe.Size = new System.Drawing.Size(97, 16);
            this.lblMontantExcluTaxe.TabIndex = 2;
            this.lblMontantExcluTaxe.Text = "-";
            this.lblMontantExcluTaxe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total  :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMontantIncluTaxe
            // 
            this.lblMontantIncluTaxe.ForeColor = System.Drawing.Color.Blue;
            this.lblMontantIncluTaxe.Location = new System.Drawing.Point(135, 88);
            this.lblMontantIncluTaxe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.lblMontantIncluTaxe.Name = "lblMontantIncluTaxe";
            this.lblMontantIncluTaxe.Size = new System.Drawing.Size(97, 16);
            this.lblMontantIncluTaxe.TabIndex = 0;
            this.lblMontantIncluTaxe.Text = "-";
            this.lblMontantIncluTaxe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMontantPD
            // 
            this.lblMontantPD.AutoSize = true;
            this.lblMontantPD.ForeColor = System.Drawing.Color.Blue;
            this.lblMontantPD.Location = new System.Drawing.Point(601, 18);
            this.lblMontantPD.Name = "lblMontantPD";
            this.lblMontantPD.Size = new System.Drawing.Size(10, 13);
            this.lblMontantPD.TabIndex = 12;
            this.lblMontantPD.Text = "-";
            this.lblMontantPD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMontantPD.Visible = false;
            // 
            // lblMontantCheque
            // 
            this.lblMontantCheque.AutoSize = true;
            this.lblMontantCheque.ForeColor = System.Drawing.Color.Blue;
            this.lblMontantCheque.Location = new System.Drawing.Point(615, 18);
            this.lblMontantCheque.Name = "lblMontantCheque";
            this.lblMontantCheque.Size = new System.Drawing.Size(10, 13);
            this.lblMontantCheque.TabIndex = 10;
            this.lblMontantCheque.Text = "-";
            this.lblMontantCheque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMontantCheque.Visible = false;
            // 
            // cbAutoFind
            // 
            this.cbAutoFind.Checked = true;
            this.cbAutoFind.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoFind.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbAutoFind.Location = new System.Drawing.Point(8, 255);
            this.cbAutoFind.Name = "cbAutoFind";
            this.cbAutoFind.Size = new System.Drawing.Size(232, 24);
            this.cbAutoFind.TabIndex = 17;
            this.cbAutoFind.Text = "Recherche automatique lors d\'un clique";
            this.cbAutoFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAutoFind.CheckedChanged += new System.EventHandler(this.cbAutoFind_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "TPS :";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "TVQ :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTPS);
            this.groupBox2.Controls.Add(this.txtTVQ);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(264, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 112);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Taxes";
            // 
            // txtTPS
            // 
            this.txtTPS.Location = new System.Drawing.Point(49, 37);
            this.txtTPS.Name = "txtTPS";
            this.txtTPS.Size = new System.Drawing.Size(65, 20);
            this.txtTPS.TabIndex = 19;
            this.txtTPS.Text = "5 %";
            this.txtTPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTVQ
            // 
            this.txtTVQ.Location = new System.Drawing.Point(49, 69);
            this.txtTVQ.Name = "txtTVQ";
            this.txtTVQ.Size = new System.Drawing.Size(65, 20);
            this.txtTVQ.TabIndex = 21;
            this.txtTVQ.Text = "8,5 %";
            this.txtTVQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ImageListSmall
            // 
            this.ImageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListSmall.ImageStream")));
            this.ImageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListSmall.Images.SetKeyName(0, "Moto");
            this.ImageListSmall.Images.SetKeyName(1, "Auto");
            this.ImageListSmall.Images.SetKeyName(2, "Camion");
            // 
            // lblMontantAutre
            // 
            this.lblMontantAutre.AutoSize = true;
            this.lblMontantAutre.Location = new System.Drawing.Point(576, 17);
            this.lblMontantAutre.Name = "lblMontantAutre";
            this.lblMontantAutre.Size = new System.Drawing.Size(10, 13);
            this.lblMontantAutre.TabIndex = 23;
            this.lblMontantAutre.Text = "-";
            this.lblMontantAutre.Visible = false;
            // 
            // tcRapportType
            // 
            this.tcRapportType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcRapportType.Controls.Add(this.tpRapportTaxe);
            this.tcRapportType.Controls.Add(this.tpCompteARecevoir);
            this.tcRapportType.Location = new System.Drawing.Point(390, 47);
            this.tcRapportType.Name = "tcRapportType";
            this.tcRapportType.SelectedIndex = 0;
            this.tcRapportType.Size = new System.Drawing.Size(633, 236);
            this.tcRapportType.TabIndex = 24;
            this.tcRapportType.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcRapportType_Selected);
            // 
            // tpRapportTaxe
            // 
            this.tpRapportTaxe.Controls.Add(this.mcRecu1);
            this.tpRapportTaxe.Controls.Add(this.mcRecu2);
            this.tpRapportTaxe.Controls.Add(this.dtpFixeDate);
            this.tpRapportTaxe.Controls.Add(this.rbOr);
            this.tpRapportTaxe.Controls.Add(this.cmdEqual);
            this.tpRapportTaxe.Controls.Add(this.rbBetween);
            this.tpRapportTaxe.Location = new System.Drawing.Point(4, 22);
            this.tpRapportTaxe.Name = "tpRapportTaxe";
            this.tpRapportTaxe.Padding = new System.Windows.Forms.Padding(3);
            this.tpRapportTaxe.Size = new System.Drawing.Size(625, 210);
            this.tpRapportTaxe.TabIndex = 0;
            this.tpRapportTaxe.Tag = "TAXE";
            this.tpRapportTaxe.Text = "Relevé de paiment";
            // 
            // tpCompteARecevoir
            // 
            this.tpCompteARecevoir.Controls.Add(this.mcCompteARecevoir);
            this.tpCompteARecevoir.Location = new System.Drawing.Point(4, 22);
            this.tpCompteARecevoir.Name = "tpCompteARecevoir";
            this.tpCompteARecevoir.Padding = new System.Windows.Forms.Padding(3);
            this.tpCompteARecevoir.Size = new System.Drawing.Size(567, 210);
            this.tpCompteARecevoir.TabIndex = 1;
            this.tpCompteARecevoir.Tag = "COMPTEARECEVOIR";
            this.tpCompteARecevoir.Text = "Compte à recevoir";
            // 
            // mcCompteARecevoir
            // 
            this.mcCompteARecevoir.Location = new System.Drawing.Point(34, 27);
            this.mcCompteARecevoir.MaxSelectionCount = 1;
            this.mcCompteARecevoir.Name = "mcCompteARecevoir";
            this.mcCompteARecevoir.TabIndex = 4;
            this.mcCompteARecevoir.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcCompteARecevoir_DateChanged);
            // 
            // lblMontantAC
            // 
            this.lblMontantAC.AutoSize = true;
            this.lblMontantAC.ForeColor = System.Drawing.Color.Blue;
            this.lblMontantAC.Location = new System.Drawing.Point(588, 18);
            this.lblMontantAC.Name = "lblMontantAC";
            this.lblMontantAC.Size = new System.Drawing.Size(10, 13);
            this.lblMontantAC.TabIndex = 14;
            this.lblMontantAC.Text = "-";
            this.lblMontantAC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMontantAC.Visible = false;
            // 
            // PrintCompteARecevoir
            // 
            this.PrintCompteARecevoir.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintCompteARecevoir_PrintPage);
            // 
            // clientControl1
            // 
            this.clientControl1.AutoUpdate = true;
            this.clientControl1.BackColor = System.Drawing.SystemColors.Control;
            customer1.AttestationNumber1 = "";
            customer1.AttestationNumber2 = "";
            customer1.BVA = false;
            customer1.BVADate = new System.DateTime(2005, 2, 20, 21, 27, 11, 328);
            customer1.City = "";
            customer1.ClientNull = false;
            customer1.CodePostal = "   -";
            customer1.ContratNumber = "0";
            customer1.DateAttestation1 = new System.DateTime(2011, 3, 31, 21, 12, 18, 576);
            customer1.DateAttestation2 = new System.DateTime(2011, 3, 31, 21, 12, 18, 576);
            customer1.DateDebutCours = new System.DateTime(2010, 3, 12, 6, 47, 55, 192);
            customer1.DateExpiration = new System.DateTime(2010, 3, 12, 6, 47, 55, 192);
            customer1.DateInscription = new System.DateTime(2003, 8, 26, 0, 0, 0, 0);
            customer1.DateNaissance = new System.DateTime(2010, 3, 12, 6, 47, 55, 192);
            customer1.DateTemporaire = new System.DateTime(2005, 2, 20, 21, 27, 11, 328);
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
            customer1.Solde = "0 $";
            customer1.StreetApp = "";
            customer1.StreetName = "";
            customer1.StreetNumber = "";
            customer1.TauxHorairePratique = "";
            customer1.TauxHoraireTheorique = "";
            customer1.TypeClient = Barette.Library.Client.ProfileType.Actif;
            customer1.TypeVehicule = Barette.Library.Client.VehiculeType.Automatique;
            this.clientControl1.Client = customer1;
            this.clientControl1.Location = new System.Drawing.Point(434, 300);
            this.clientControl1.Name = "clientControl1";
            this.clientControl1.School = null;
            this.clientControl1.Size = new System.Drawing.Size(149, 152);
            this.clientControl1.TabIndex = 15;
            this.clientControl1.Visible = false;
            // 
            // listFindResult
            // 
            this.listFindResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listFindResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colheadContratNumber,
            this.colheadName,
            this.colheadDate,
            this.colHeadPhone,
            this.colHeadTypeVehicule,
            this.colHeadSolde,
            this.colHeadLastRecuNumber,
            this.colHeadMontant,
            this.colHeadDateRecu,
            this.colHeadRL,
            this.colHeadTypePaiment});
            this.listFindResult.FullRowSelect = true;
            this.listFindResult.HideSelection = false;
            this.listFindResult.Location = new System.Drawing.Point(8, 286);
            this.listFindResult.MultiSelect = false;
            this.listFindResult.Name = "listFindResult";
            this.listFindResult.Size = new System.Drawing.Size(1011, 226);
            this.listFindResult.SmallImageList = this.ImageListSmall;
            this.listFindResult.TabIndex = 0;
            this.listFindResult.UseCompatibleStateImageBehavior = false;
            this.listFindResult.View = System.Windows.Forms.View.Details;
            this.listFindResult.Click += new System.EventHandler(this.listFindResult_Click);
            // 
            // colheadContratNumber
            // 
            this.colheadContratNumber.Text = "# Contrat";
            this.colheadContratNumber.Width = 66;
            // 
            // colheadName
            // 
            this.colheadName.Text = "Nom du client";
            this.colheadName.Width = 156;
            // 
            // colheadDate
            // 
            this.colheadDate.Text = "Date du paiment";
            this.colheadDate.Width = 91;
            // 
            // colHeadPhone
            // 
            this.colHeadPhone.Text = "Téléphone";
            this.colHeadPhone.Width = 91;
            // 
            // colHeadTypeVehicule
            // 
            this.colHeadTypeVehicule.Text = "Type de cours";
            this.colHeadTypeVehicule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHeadTypeVehicule.Width = 92;
            // 
            // colHeadSolde
            // 
            this.colHeadSolde.Text = "Solde";
            this.colHeadSolde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colHeadSolde.Width = 64;
            // 
            // colHeadLastRecuNumber
            // 
            this.colHeadLastRecuNumber.Text = "Numéro de recu";
            this.colHeadLastRecuNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHeadLastRecuNumber.Width = 89;
            // 
            // colHeadMontant
            // 
            this.colHeadMontant.Text = "Montant";
            this.colHeadMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colHeadMontant.Width = 63;
            // 
            // colHeadDateRecu
            // 
            this.colHeadDateRecu.Text = "Date reçu";
            this.colHeadDateRecu.Width = 0;
            // 
            // colHeadRL
            // 
            this.colHeadRL.Text = "Type";
            this.colHeadRL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colHeadTypePaiment
            // 
            this.colHeadTypePaiment.Text = "Type Paiment";
            this.colHeadTypePaiment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHeadTypePaiment.Width = 84;
            // 
            // FormFinance
            // 
            this.ClientSize = new System.Drawing.Size(1027, 518);
            this.Controls.Add(this.tcRapportType);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.lblMontantAutre);
            this.Controls.Add(this.lblMontantAC);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblMontantCheque);
            this.Controls.Add(this.lblMontantPD);
            this.Controls.Add(this.cbAutoFind);
            this.Controls.Add(this.clientControl1);
            this.Controls.Add(this.listFindResult);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormFinance";
            this.Text = "FormFinance";
            this.Load += new System.EventHandler(this.FormFindClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tcRapportType.ResumeLayout(false);
            this.tpRapportTaxe.ResumeLayout(false);
            this.tpCompteARecevoir.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region Methodes
		/// <summary>
		/// Trie par date
		/// </summary>
		private void SortByDate(){
			listFindResult.SortColumn(2);
		}

		private void Find(){
			listFindResult.Items.Clear();

			Cursor.Current = Cursors.WaitCursor;

			switch (this._ReleverMode) {
				case TypeRelever.CompteARecevoir:
					FindDateCompteARecevoir();
					break;
				case TypeRelever.Taxe:
					FindDateRecu();
					break;
			}
			
			ShowPaimentInfo();

			Cursor.Current = Cursors.Default;
		}

		/// <summary>
		/// Recherche les comptes a recevoir
		/// </summary>
		private void FindDateCompteARecevoir() {
			CustomerCollection ClientList = this._FormMain.ClientList;
			decimal solde = 0;

			for (int i = 0; i < ClientList.Count; i++) {
				//Avant la recherche il faut verifier que le client etais inscrit a ce moment la
				if (ClientList[i].DateInscription.Date <= mcCompteARecevoir.SelectionStart.Date) {
					solde = Decimal.Round(ClientList[i].GetSolde(mcCompteARecevoir.SelectionStart.Date), 2);

					if (solde > 0)
						AddClientToList(ClientList[i], solde);
				}
			}
		}

		/// <summary>
		/// Recherche par date de recu
		/// </summary>
		private void FindDateRecu(){
			CustomerCollection ClientList = this._FormMain.ClientList;
			Paiement paiment = null; 

			for(int i=0; i < ClientList.Count; i++){ 
				for(int j=0; j < ClientList[i].Paiment.Count; j++){ 
					paiment = ClientList[i].Paiment[j]; 

					switch(rbBetween.Checked){
						case true: // ==
							if ((mcRecu1.SelectionStart.Date <= paiment.DatePaiment.Date) && 
								(mcRecu2.SelectionStart.Date >= paiment.DatePaiment.Date))
								AddClientToList(ClientList[i], paiment);
							break;
						case false: // >
							if (dtpFixeDate.Value.Date == paiment.DatePaiment.Date)
								AddClientToList(ClientList[i], paiment);
							break;						
					}
				}
			}
		}

		/// <summary>
		/// Affiche le total de paiment pour l'anné courante
		/// </summary>
		private void PaimentAnneeCourante(){
		}

		/// <summary>
		/// Affiche les informations sur la prériodes dans les controles
		/// </summary>
		private void ShowPaimentInfo() {
			decimal tps = 0;
			decimal tvq = 0;
			decimal montant = 0;
			decimal Total = 0;
			decimal TotalSansTaxe = 0;
			decimal TotalCheque = 0;
			decimal TotalArgentComptant = 0;
			decimal TotalPaimentDirect = 0;
			decimal TotalAutre = 0;
            decimal TotalLivre = 0;
			//const decimal VariableTaxe = 113.95M;

            decimal VariableTaxe = (100 * (txtTPS.DecimalValue + 1)) * (txtTVQ.DecimalValue + 1);

			//Initialise a 0;
			lblTPS.Text = lblTVQ.Text =	lblMontantExcluTaxe.Text = lblMontantIncluTaxe.Text =
			lblMontantCheque.Text =	lblMontantAC.Text =	lblMontantPD.Text =	"0,00 $";

			for (int i = 0; i < listFindResult.Items.Count; i++) {
				switch (this._ReleverMode) {
					case TypeRelever.CompteARecevoir:
						montant = Convert.ToDecimal(listFindResult.Items[i].SubItems[5].Text.Replace(" $", ""));
						break;
					case TypeRelever.Taxe:
						montant = Convert.ToDecimal(listFindResult.Items[i].SubItems[7].Text.Replace(" $", ""));
						break;
				}
				
                switch (listFindResult.Items[i].SubItems[10].Text) {
					case "AC":
						TotalArgentComptant += montant;
						break;
					case "PD":
						TotalPaimentDirect += montant;
						break;
					case "CH":
						TotalCheque += montant;
						break;
					default:
						TotalAutre += montant;
						break;
				}

                switch (listFindResult.Items[i].SubItems[9].Text) {
                    case "RL":
                        TotalLivre += montant;
                        break;
                }

				TotalSansTaxe += (montant / VariableTaxe) * 100;
				Total += montant;

			}

            //Cacule de la taxe
            //if (TotalLivre != 0) //si il y a des livre avec 1 taxe seulement (TVQ)
            //    tps = (((Total - TotalLivre) / VariableTaxe) * 100) * txtTPS.DecimalValue;
            //else
            //    tps = (TotalSansTaxe) * txtTPS.DecimalValue;                
            //tvq = (TotalSansTaxe + tps) * txtTVQ.DecimalValue;

            //Cacule de la taxe
            if (TotalLivre != 0) { //si il y a des livre avec 1 taxe seulement (TVQ)
                tps = (TotalSansTaxe) * txtTPS.DecimalValue;
                tvq = ((((Total - TotalLivre) / VariableTaxe) * 100) + tps) * txtTVQ.DecimalValue;         
                //tvq = (TotalSansTaxe + tps) * txtTVQ.DecimalValue;
            }
            else {
                tps = (TotalSansTaxe) * txtTPS.DecimalValue;
                tvq = (TotalSansTaxe + tps) * txtTVQ.DecimalValue;
            }            

			lblTPS.Text = Decimal.Round(tps, 2).ToString() + " $";
			lblTVQ.Text = Decimal.Round(tvq, 2).ToString() + " $";
			lblMontantExcluTaxe.Text = Decimal.Round(TotalSansTaxe, 2).ToString() + " $";
			lblMontantIncluTaxe.Text = Decimal.Round(Total, 2).ToString() + " $";
			lblMontantAC.Text = Decimal.Round(TotalArgentComptant, 2).ToString() + " $";
			lblMontantPD.Text = Decimal.Round(TotalPaimentDirect, 2).ToString() + " $";
			lblMontantCheque.Text = Decimal.Round(TotalCheque, 2).ToString() + " $";
			lblMontantAutre.Text = Decimal.Round(TotalAutre, 2).ToString() + " $";
		}

		/// <summary>
		/// Ajoute un client a la liste
		/// (Finir cette fonction)
		/// </summary>
		/// <param name="client"></param>
		private void AddClientToList(Customer client, Paiement paimentInfo){
			ListViewItem itm = new ListViewItem();
			string type;
			string typePaiment = "";

			itm.Text = client.ContratNumber;
			itm.SubItems.Add(client.FirstName + " " + client.Name);
			itm.SubItems.Add(paimentInfo.DatePaiment.ToShortDateString());
			itm.SubItems.Add(client.Phone);
			itm.SubItems.Add(client.TypeVehicule.ToString());
			itm.SubItems.Add(client.Solde);				
			itm.SubItems.Add(paimentInfo.NumeroRecu.ToString());
			itm.SubItems.Add(paimentInfo.Montant);
			itm.SubItems.Add(paimentInfo.DatePaiment.ToShortDateString());

			if (paimentInfo.Type == PaiementType.RetourLivre)
				type = "RL";
			else if (paimentInfo.Type == PaiementType.LocationAuto)
				type = "LA";
			else if (paimentInfo.Type == PaiementType.Absence)
				type = "ABS";
			else
				type = "";
			
			itm.SubItems.Add(type);
			
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
			
			switch (paimentInfo.TypePaiment) {
				case TypePaiment.ArgentComptant:
					typePaiment = "AC";
					break;
				case TypePaiment.Autre:
					typePaiment = paimentInfo.PaimentAutre;
					break;
				case TypePaiment.Cheque:
					typePaiment = "CH";
					break;
				case TypePaiment.PaimentDirect:
					typePaiment = "PD";
					break;
				case TypePaiment.Nothing:
					typePaiment = "";
					break;
			}
			itm.SubItems.Add(typePaiment);

			listFindResult.Items.Add(itm);
		}

		/// <summary>
		/// Ajoute un client a la liste (Compte a recevoir)
		/// (Finir cette fonction)
		/// </summary>
		/// <param name="client"></param>
		private void AddClientToList(Customer client, decimal solde) {
			ListViewItem itm = new ListViewItem();

			itm.Text = client.ContratNumber;
			itm.SubItems.Add(client.FirstName + " " + client.Name);
			itm.SubItems.Add("");
			itm.SubItems.Add(client.Phone);
			itm.SubItems.Add(client.TypeVehicule.ToString());
			itm.SubItems.Add(solde + " $");
			itm.SubItems.Add("");
			itm.SubItems.Add("");
			itm.SubItems.Add("");
			itm.SubItems.Add("");

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
		private bool _FootPrinted = false;
				
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
			_FootPrinted = false;
			_LinesPerPage = 0;
			_LinePrinted = -1;

#if DEBUG
			PrintPreviewDialog prev = new PrintPreviewDialog();

			switch (this._ReleverMode) {
				case TypeRelever.Taxe:
					prev.Document = PrintRelever;
					break;
				case TypeRelever.CompteARecevoir:
					prev.Document = PrintCompteARecevoir;
					break;
			}

			prev.ShowDialog(this);

#else

			//Lance l'impression
			PrintDialog printConfig = new PrintDialog();			
			printConfig.PrinterSettings = PrintRelever.PrinterSettings; 

			if(printConfig.ShowDialog(this) == DialogResult.OK)
				switch (this._ReleverMode) {
					case TypeRelever.Taxe:
						PrintRelever.Print();
						break;
					case TypeRelever.CompteARecevoir:
						PrintCompteARecevoir.Print();
						break;
				}				
#endif
		}

		private void PrintRelever_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
			float topMargin = 30;
			float leftMargin = 0;//e.MarginBounds.Left;
			float rightMargin = e.MarginBounds.Right;

			//Defini le style de l'alignement
			StringFormat style = new StringFormat();
			style.Alignment = StringAlignment.Near;

			//Facrication de la font
			Font printFont = new Font("Times New Roman", 12, FontStyle.Regular);
			Font printFontBold = new Font("Times New Roman", 12, FontStyle.Bold);
			Font printFontBold16 = new Font("Times New Roman", 16, FontStyle.Bold);

			float yPos = 0f;			
					
			#region Header
			if (_HeaderPrinted == false){
				//Initialisation des variables dans le bloc header pour q'il ne le
				//face qu'a la premiere page
				_TotalLine = listFindResult.Items.Count;
				_LinesPerPage = Convert.ToInt16((e.MarginBounds.Height - 40) / printFont.GetHeight(e.Graphics)); 				
				_TotalPage = Convert.ToInt16(Decimal.Round(Convert.ToDecimal(_TotalLine) / Convert.ToDecimal(_LinesPerPage), 0));
				if (_TotalPage == 0) _TotalPage =1;
				
				//Date(s) de relever : Choisi le bon type de Header a écrire
				yPos = topMargin + 5;
				switch (rbBetween.Checked == true){
					case true:
						e.Graphics.DrawString("Relevé : " + mcRecu1.SelectionStart.Date.ToLongDateString() + " au " + mcRecu2.SelectionStart.Date.ToLongDateString(), printFontBold16, Brushes.Black, leftMargin, yPos, new StringFormat());
						break;
					case false:
						e.Graphics.DrawString("Relevé : " + dtpFixeDate.Value.Date.ToLongDateString(), printFontBold16, Brushes.Black, leftMargin, yPos, new StringFormat());
						break;
				}

				_HeaderPrinted = true; //Header Imprimé
			}
			#endregion

			//Entete des colones
			yPos += 50;			
			e.Graphics.DrawString("Nom du client" , printFontBold , Brushes.Black, leftMargin + 50, yPos, new StringFormat());
			e.Graphics.DrawString("# Contrat" , printFontBold , Brushes.Black, leftMargin + 300, yPos, new StringFormat());
			e.Graphics.DrawString("# Reçu" , printFontBold , Brushes.Black, leftMargin + 400, yPos, new StringFormat());
			e.Graphics.DrawString("Date" , printFontBold , Brushes.Black, leftMargin + 475, yPos, new StringFormat());			
			e.Graphics.DrawString("Montant" , printFontBold , Brushes.Black, leftMargin + 575, yPos, new StringFormat());			
			e.Graphics.DrawString("Type" , printFontBold , Brushes.Black, leftMargin + 650, yPos, new StringFormat());
			e.Graphics.DrawString("TP", printFontBold, Brushes.Black, leftMargin + 720, yPos, new StringFormat());
			
			//Creation de l'objet client
			Customer client = null;
			
			yPos += 20;			
			//Impression de toute les lignes du tableau
			while (_LinePrinted < listFindResult.Items.Count -1){				
				_LinePrinted++;

				client = GetClient(listFindResult.Items[_LinePrinted].Text);
				
				if (client != null){

					//Montant des locations
					if (client.MontantLocation == "")
						client.MontantLocation = "0,00 $";

					yPos += printFont.Height;
					e.Graphics.DrawString((_LinePrinted +1) + " - ", printFont , Brushes.Black, leftMargin + 5, yPos, new StringFormat());
					e.Graphics.DrawString(client.FirstName + " " + client.Name, printFont , Brushes.Black, leftMargin + 50, yPos, new StringFormat());
					e.Graphics.DrawString(listFindResult.Items[_LinePrinted].Text, printFont , Brushes.Black, leftMargin + 300, yPos, new StringFormat());
					e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[6].Text, printFont , Brushes.Black, leftMargin + 400, yPos, new StringFormat());
					e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[8].Text, printFont , Brushes.Black, leftMargin + 475, yPos, new StringFormat());
					e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[7].Text, printFont, Brushes.Black, 640 - e.Graphics.MeasureString(listFindResult.Items[_LinePrinted].SubItems[7].Text, printFont).Width, yPos, new StringFormat());
					e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[9].Text, printFont , Brushes.Black, leftMargin + 650, yPos, new StringFormat());
					e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[10].Text, printFont, Brushes.Black, leftMargin + 720, yPos, new StringFormat());

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
					}else{
						//Numéro de page
						e.Graphics.DrawString(PageNumber,
							printFontBold,
							Brushes.Black,
							e.MarginBounds.Right - e.Graphics.MeasureString(PageNumber, printFontBold).Width,
							e.MarginBounds.Bottom,
							new StringFormat());
						_FootPrinted = true; //indique que le pied du document doit etre imprimer
					}
					#endregion

				}				
			}

			#region Foot
			if (_FootPrinted == true){
				//Impression du calcule des taxe (TPS et TVQ)
				yPos += 30;
				e.Graphics.DrawString("Cumulatif des Paiments _______________________" , printFontBold16 , Brushes.Black, leftMargin + 50, yPos, new StringFormat());
				yPos += printFont.Height + 15;
				e.Graphics.DrawString("Nombre de paiments : ", printFont , Brushes.Black, leftMargin + 50, yPos, new StringFormat());
				e.Graphics.DrawString((_LinePrinted +1) + "", printFont , Brushes.Black, leftMargin + 220, yPos, new StringFormat());
				yPos += printFont.Height;
				e.Graphics.DrawString("Total partiel : ", printFont , Brushes.Black, leftMargin + 50, yPos, new StringFormat());
				e.Graphics.DrawString(lblMontantExcluTaxe.Text, printFont, Brushes.Black, 300 - e.Graphics.MeasureString(lblMontantExcluTaxe.Text, printFont).Width, yPos, new StringFormat());
				e.Graphics.DrawString("Chèque : ", printFont, Brushes.Black, leftMargin + 350, yPos, new StringFormat());
				e.Graphics.DrawString(lblMontantCheque.Text, printFont, Brushes.Black, 600 - e.Graphics.MeasureString(lblMontantCheque.Text, printFont).Width, yPos, new StringFormat());
				yPos += printFont.Height;
				e.Graphics.DrawString("TPS : ", printFont , Brushes.Black, leftMargin + 50, yPos, new StringFormat());
				e.Graphics.DrawString(lblTPS.Text, printFont, Brushes.Black, 300 - e.Graphics.MeasureString(lblTPS.Text, printFont).Width, yPos, new StringFormat());
				e.Graphics.DrawString("Argent Comptant : ", printFont, Brushes.Black, leftMargin + 350, yPos, new StringFormat());
				e.Graphics.DrawString(lblMontantAC.Text, printFont, Brushes.Black, 600 - e.Graphics.MeasureString(lblMontantAC.Text, printFont).Width, yPos, new StringFormat());
				yPos += printFont.Height;
				e.Graphics.DrawString("TVQ : ", printFont , Brushes.Black, leftMargin + 50, yPos, new StringFormat());
				e.Graphics.DrawString(lblTVQ.Text, printFont, Brushes.Black, 300 - e.Graphics.MeasureString(lblTVQ.Text, printFont).Width, yPos, new StringFormat());
				e.Graphics.DrawString("Paiment Direct : ", printFont, Brushes.Black, leftMargin + 350, yPos, new StringFormat());
				e.Graphics.DrawString(lblMontantPD.Text, printFont, Brushes.Black, 600 - e.Graphics.MeasureString(lblMontantPD.Text, printFont).Width, yPos, new StringFormat());
				yPos += printFont.Height;
				e.Graphics.DrawString("Total : ", printFont , Brushes.Black, leftMargin + 50, yPos, new StringFormat());
				e.Graphics.DrawString(lblMontantIncluTaxe.Text, printFont, Brushes.Black, 300 - e.Graphics.MeasureString(lblMontantIncluTaxe.Text, printFont).Width, yPos, new StringFormat());
				e.Graphics.DrawString("Autre : ", printFont, Brushes.Black, leftMargin + 350, yPos, new StringFormat());
				e.Graphics.DrawString(lblMontantAutre.Text, printFont, Brushes.Black, 600 - e.Graphics.MeasureString(lblMontantAutre.Text, printFont).Width, yPos, new StringFormat());

				_FootPrinted = false; //pied imprimé
			}
			#endregion
		}


		private void PrintCompteARecevoir_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
			float topMargin = 30;
			float leftMargin = 0;//e.MarginBounds.Left;
			float rightMargin = e.MarginBounds.Right;

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

				//Date(s) de relever : Choisi le bon type de Header a écrire
				yPos = topMargin + 5;
				e.Graphics.DrawString("Compte à recevoir : " + mcCompteARecevoir.SelectionStart.Date.ToLongDateString(), printFontBold16, Brushes.Black, leftMargin, yPos, new StringFormat());

				_HeaderPrinted = true; //Header Imprimé
			}
			#endregion

			//Entete des colones
			yPos += 50;
			e.Graphics.DrawString("Nom du client", printFontBold, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
			e.Graphics.DrawString("# Contrat", printFontBold, Brushes.Black, leftMargin + 400, yPos, new StringFormat());
			e.Graphics.DrawString("Solde", printFontBold, Brushes.Black, leftMargin + 530, yPos, new StringFormat());

			//Creation de l'objet client
			Customer client = null;

			yPos += 20;
			//Impression de toute les lignes du tableau
			while (_LinePrinted < listFindResult.Items.Count - 1) {
				_LinePrinted++;

				client = GetClient(listFindResult.Items[_LinePrinted].Text);

				if (client != null) {

					//Montant des locations
					if (client.MontantLocation == "")
						client.MontantLocation = "0,00 $";

					yPos += printFont.Height;
					e.Graphics.DrawString((_LinePrinted + 1) + " - ", printFont, Brushes.Black, leftMargin + 5, yPos, new StringFormat());
					e.Graphics.DrawString(client.FirstName + " " + client.Name, printFont, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
					e.Graphics.DrawString(listFindResult.Items[_LinePrinted].Text, printFont, Brushes.Black, leftMargin + 400, yPos, new StringFormat());
					e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[5].Text, printFont, Brushes.Black, 575 - e.Graphics.MeasureString(listFindResult.Items[_LinePrinted].SubItems[5].Text, printFont).Width, yPos, new StringFormat());

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
						_FootPrinted = true; //indique que le pied du document doit etre imprimer
					}
					#endregion

				}
			}

			#region Foot
			if (_FootPrinted == true) {
				//Impression du calcule des taxe (TPS et TVQ)
				yPos += 30;
				e.Graphics.DrawString("Cumulatif _______________________", printFontBold16, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
				yPos += printFont.Height + 15;
				e.Graphics.DrawString("Nombre de clients : ", printFont, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
				e.Graphics.DrawString((_LinePrinted + 1) + "", printFont, Brushes.Black, leftMargin + 220, yPos, new StringFormat());
				yPos += printFont.Height;
				e.Graphics.DrawString("Total partiel : ", printFont, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
				e.Graphics.DrawString(lblMontantExcluTaxe.Text, printFont, Brushes.Black, leftMargin + 220, yPos, new StringFormat());
				yPos += printFont.Height;
				e.Graphics.DrawString("TPS : ", printFont, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
				e.Graphics.DrawString(lblTPS.Text, printFont, Brushes.Black, leftMargin + 220, yPos, new StringFormat());
				yPos += printFont.Height;
				e.Graphics.DrawString("TVQ : ", printFont, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
				e.Graphics.DrawString(lblTVQ.Text, printFont, Brushes.Black, leftMargin + 220, yPos, new StringFormat());
				yPos += printFont.Height;
				e.Graphics.DrawString("Total : ", printFont, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
				e.Graphics.DrawString(lblMontantIncluTaxe.Text, printFont, Brushes.Black, leftMargin + 220, yPos, new StringFormat());
				_FootPrinted = false; //pied imprimé
			}
			#endregion
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
				case "OPENSEANCE":
					if (listFindResult.SelectedItems[0].SubItems[6].Text != "") {
						if (clientControl1.ShowPaiement(Convert.ToInt32(listFindResult.SelectedItems[0].SubItems[6].Text)) == DialogResult.OK) {
							Find();
							ShowPaimentInfo();
						}
					} else {
						if (clientControl1.ShowPaiement() == DialogResult.OK) {
							Find();
							ShowPaimentInfo();
						}
					}
						break;
				case "SHOWCLIENT":
					this._FormMain.CreationListClient(listFindResult.SelectedItems[0].Text);
					break;
				case "RELEVERTPSTVQ":
					ShowPaimentInfo();
					PrintDoc();
					break;
				case "REFRESH":
					Find();
					break;
				case "ETATSGLOBAL":
					new FormFinanceEtatsGlobal(this).ShowDialog(this);
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
					tbbShowSeance.Enabled = 
					tbbPrintClientInfo.Enabled = false;
			}
			else{
				tbbShowClient.Enabled = 
					tbbShowSeance.Enabled = 
					tbbPrintClientInfo.Enabled = true;
			}

			if(listFindResult.Items.Count >0)
				tbbTPSTVQ.Enabled = true;
			else
				tbbTPSTVQ.Enabled = false;
		}

		private void cmdEqual_Click(object sender, System.EventArgs e) {
			mcRecu2.SelectionStart = mcRecu1.SelectionStart;
		}

		private void mcRecu1_DateChanged(object sender, System.Windows.Forms.DateRangeEventArgs e) {
			rbBetween.Checked = true;
			if (cbAutoFind.Checked == true)
				Find();
		}

		private void mcRecu2_DateChanged(object sender, System.Windows.Forms.DateRangeEventArgs e) {
			rbBetween.Checked = true;
			if (cbAutoFind.Checked == true)
				Find();
		}

		private void dtpFixeDate_ValueChanged(object sender, System.EventArgs e) {
			rbOr.Checked = true;
			if (cbAutoFind.Checked == true)
				Find();
		}

		private void cbAutoFind_CheckedChanged(object sender, System.EventArgs e) {
			if (cbAutoFind.Checked == true)
				Find();			
		}

		private void tcRapportType_Selected(object sender, TabControlEventArgs e) {
			switch (e.TabPage.Tag.ToString()) {
				case "COMPTEARECEVOIR":
					this._ReleverMode = TypeRelever.CompteARecevoir;
					break;
				case "TAXE":
					this._ReleverMode = TypeRelever.Taxe;
					break;
			}

			//listFindResult.Items.Clear();
			if (cbAutoFind.Checked == true)
				Find();
		}

		private void mcCompteARecevoir_DateChanged(object sender, DateRangeEventArgs e) {
			if (cbAutoFind.Checked == true)
				Find();
		}
	}
}

