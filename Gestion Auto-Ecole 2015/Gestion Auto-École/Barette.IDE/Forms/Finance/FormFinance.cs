using System;
using System.Drawing;
using System.Windows.Forms;
using Barette.Library.Client;
using Barette.Library.Collections;
using Barette.Library.Listview;
using Barette.Library.UserControls;
using Barette.Library.UserControls.Client;


namespace Barette.IDE.Forms.Finance
{
    /// <summary>
    /// Description résumée de FormFindClient.
    /// </summary>
    public class FormFinance : Form
    {
        /// <summary>
        /// acces a la Fenetre principal
        /// </summary>		
        public FormMain _FormMain = null;

        /// <summary>
        /// Type de relever
        /// </summary>
        private TypeRelever _ReleverMode = TypeRelever.Taxe; //taxe par défaut

        private CheckBox chkDisponibilityPM;
        private CheckBox chkDisponibilityAM;
        private ImageList imageList1;
        private ToolBar toolBar1;
        private Timer timer1;
        private ToolBarButton tbbShowClient;
        private ToolBarButton tbbSeparator1;
        private MonthCalendar mcRecu1;
        private MonthCalendar mcRecu2;
        private DateTimePicker dtpFixeDate;
        private Button cmdEqual;
        private RadioButton rbBetween;
        private RadioButton rbOr;
        private ToolBarButton tbbTPSTVQ;
        private System.Drawing.Printing.PrintDocument PrintRelever;
        private GroupBox groupBox1;
        private ToolBarButton ttbRefresh;
        private ToolBarButton tbbSeparator;
        private ToolBarButton tbbShowSeance;
        private ToolBarButton tbbPrintClientInfo;
        private CheckBox cbAutoFind;
        private Label lblMontantIncluTaxe;
        private Label label1;
        private Label label2;
        private Label lblMontantExcluTaxe;
        private Label label3;
        private Label lblTVQ;
        private Label label4;
        private Label lblTPS;
        private Label label5;
        private System.ComponentModel.IContainer components;
        private Label label6;
        //private System.Windows.Forms.ToolBarButton tbbHoraireInfo;
        private ToolBarButton tbbSeparator2;
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
        private GroupBox groupBox2;

        public FormFinance(FormMain main)
        {
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

        #region Code généré par le Concepteur Windows Form
        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinance));
            Customer customer1 = new Customer();
            cmdEqual = new Button();
            rbOr = new RadioButton();
            rbBetween = new RadioButton();
            dtpFixeDate = new DateTimePicker();
            mcRecu2 = new MonthCalendar();
            mcRecu1 = new MonthCalendar();
            chkDisponibilityPM = new CheckBox();
            chkDisponibilityAM = new CheckBox();
            imageList1 = new ImageList(components);
            toolBar1 = new ToolBar();
            ttbRefresh = new ToolBarButton();
            tbbSeparator = new ToolBarButton();
            tbbHorraireInfo = new ToolBarButton();
            tbbSeparator2 = new ToolBarButton();
            tbbShowClient = new ToolBarButton();
            tbbShowSeance = new ToolBarButton();
            tbbSeparator1 = new ToolBarButton();
            tbbPrintClientInfo = new ToolBarButton();
            tbbTPSTVQ = new ToolBarButton();
            timer1 = new Timer(components);
            PrintRelever = new System.Drawing.Printing.PrintDocument();
            groupBox1 = new GroupBox();
            label4 = new Label();
            lblTPS = new Label();
            label3 = new Label();
            lblTVQ = new Label();
            label2 = new Label();
            lblMontantExcluTaxe = new Label();
            label1 = new Label();
            lblMontantIncluTaxe = new Label();
            lblMontantPD = new Label();
            lblMontantCheque = new Label();
            cbAutoFind = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            txtTPS = new PourCentTextBox();
            txtTVQ = new PourCentTextBox();
            ImageListSmall = new ImageList(components);
            lblMontantAutre = new Label();
            tcRapportType = new TabControl();
            tpRapportTaxe = new TabPage();
            tpCompteARecevoir = new TabPage();
            mcCompteARecevoir = new MonthCalendar();
            lblMontantAC = new Label();
            PrintCompteARecevoir = new System.Drawing.Printing.PrintDocument();
            clientControl1 = new ClientControl();
            listFindResult = new ListViewEx();
            colheadContratNumber = new ColumnHeader();
            colheadName = new ColumnHeader();
            colheadDate = new ColumnHeader();
            colHeadPhone = new ColumnHeader();
            colHeadTypeVehicule = new ColumnHeader();
            colHeadSolde = new ColumnHeader();
            colHeadLastRecuNumber = new ColumnHeader();
            colHeadMontant = new ColumnHeader();
            colHeadDateRecu = new ColumnHeader();
            colHeadRL = new ColumnHeader();
            colHeadTypePaiment = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tcRapportType.SuspendLayout();
            tpRapportTaxe.SuspendLayout();
            tpCompteARecevoir.SuspendLayout();
            SuspendLayout();
            // 
            // cmdEqual
            // 
            cmdEqual.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdEqual.Location = new Point(248, 58);
            cmdEqual.Margin = new Padding(3, 3, 3, 1);
            cmdEqual.Name = "cmdEqual";
            cmdEqual.Size = new Size(48, 23);
            cmdEqual.TabIndex = 9;
            cmdEqual.Text = "=";
            cmdEqual.Click += new EventHandler(cmdEqual_Click);
            // 
            // rbOr
            // 
            rbOr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            rbOr.Location = new Point(240, 180);
            rbOr.Name = "rbOr";
            rbOr.Size = new Size(72, 24);
            rbOr.TabIndex = 8;
            rbOr.Text = "Date fixe";
            // 
            // rbBetween
            // 
            rbBetween.Checked = true;
            rbBetween.FlatStyle = System.Windows.Forms.FlatStyle.System;
            rbBetween.Location = new Point(240, 82);
            rbBetween.Margin = new Padding(3, 0, 4, 3);
            rbBetween.Name = "rbBetween";
            rbBetween.Size = new Size(64, 24);
            rbBetween.TabIndex = 7;
            rbBetween.TabStop = true;
            rbBetween.Text = "Intervale";
            // 
            // dtpFixeDate
            // 
            dtpFixeDate.Location = new Point(312, 180);
            dtpFixeDate.Name = "dtpFixeDate";
            dtpFixeDate.Size = new Size(128, 20);
            dtpFixeDate.TabIndex = 6;
            dtpFixeDate.ValueChanged += new EventHandler(dtpFixeDate_ValueChanged);
            // 
            // mcRecu2
            // 
            mcRecu2.Location = new Point(312, 12);
            mcRecu2.Margin = new Padding(4, 9, 9, 9);
            mcRecu2.MaxSelectionCount = 1;
            mcRecu2.Name = "mcRecu2";
            mcRecu2.TabIndex = 4;
            mcRecu2.DateChanged += new DateRangeEventHandler(mcRecu2_DateChanged);
            // 
            // mcRecu1
            // 
            mcRecu1.Location = new Point(9, 12);
            mcRecu1.MaxSelectionCount = 1;
            mcRecu1.Name = "mcRecu1";
            mcRecu1.TabIndex = 3;
            mcRecu1.DateChanged += new DateRangeEventHandler(mcRecu1_DateChanged);
            // 
            // chkDisponibilityPM
            // 
            chkDisponibilityPM.Location = new Point(0, 0);
            chkDisponibilityPM.Name = "chkDisponibilityPM";
            chkDisponibilityPM.Size = new Size(104, 24);
            chkDisponibilityPM.TabIndex = 0;
            // 
            // chkDisponibilityAM
            // 
            chkDisponibilityAM.Location = new Point(0, 0);
            chkDisponibilityAM.Name = "chkDisponibilityAM";
            chkDisponibilityAM.Size = new Size(104, 24);
            chkDisponibilityAM.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
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
            toolBar1.Buttons.AddRange(new ToolBarButton[] {
            ttbRefresh,
            tbbSeparator,
            tbbHorraireInfo,
            tbbSeparator2,
            tbbShowClient,
            tbbShowSeance,
            tbbSeparator1,
            tbbPrintClientInfo,
            tbbTPSTVQ});
            toolBar1.Divider = false;
            toolBar1.Dock = System.Windows.Forms.DockStyle.None;
            toolBar1.DropDownArrows = true;
            toolBar1.ImageList = imageList1;
            toolBar1.Location = new Point(8, 8);
            toolBar1.Name = "toolBar1";
            toolBar1.ShowToolTips = true;
            toolBar1.Size = new Size(376, 42);
            toolBar1.TabIndex = 13;
            toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            toolBar1.ButtonClick += new ToolBarButtonClickEventHandler(toolBar1_ButtonClick);
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
            // tbbHorraireInfo
            // 
            tbbHorraireInfo.ImageIndex = 5;
            tbbHorraireInfo.Name = "tbbHorraireInfo";
            tbbHorraireInfo.Tag = "ETATSGLOBAL";
            tbbHorraireInfo.ToolTipText = "Affiche l\'état global de l\'année en court";
            // 
            // tbbSeparator2
            // 
            tbbSeparator2.Name = "tbbSeparator2";
            tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbShowClient
            // 
            tbbShowClient.ImageIndex = 3;
            tbbShowClient.Name = "tbbShowClient";
            tbbShowClient.Tag = "SHOWCLIENT";
            tbbShowClient.ToolTipText = "Affiche le client";
            // 
            // tbbShowSeance
            // 
            tbbShowSeance.ImageIndex = 1;
            tbbShowSeance.Name = "tbbShowSeance";
            tbbShowSeance.Tag = "OPENSEANCE";
            tbbShowSeance.ToolTipText = "Affiche la boîte de Paiment";
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
            tbbTPSTVQ.Tag = "RELEVERTPSTVQ";
            tbbTPSTVQ.Text = "Relevé";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 200;
            timer1.Tick += new EventHandler(timer1_Tick);
            // 
            // PrintRelever
            // 
            PrintRelever.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintRelever_PrintPage);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblTPS);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblTVQ);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblMontantExcluTaxe);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblMontantIncluTaxe);
            groupBox1.Location = new Point(8, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 112);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information sur la période";
            // 
            // label4
            // 
            label4.Location = new Point(10, 40);
            label4.Name = "label4";
            label4.Size = new Size(78, 16);
            label4.TabIndex = 7;
            label4.Text = "TPS :";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTPS
            // 
            lblTPS.ForeColor = System.Drawing.Color.Blue;
            lblTPS.Location = new Point(135, 40);
            lblTPS.Margin = new Padding(3, 1, 3, 3);
            lblTPS.Name = "lblTPS";
            lblTPS.Size = new Size(97, 16);
            lblTPS.TabIndex = 6;
            lblTPS.Text = "-";
            lblTPS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(10, 64);
            label3.Margin = new Padding(3, 3, 3, 1);
            label3.Name = "label3";
            label3.Size = new Size(78, 16);
            label3.TabIndex = 5;
            label3.Text = "TVQ :";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTVQ
            // 
            lblTVQ.ForeColor = System.Drawing.Color.Blue;
            lblTVQ.Location = new Point(135, 64);
            lblTVQ.Name = "lblTVQ";
            lblTVQ.Size = new Size(97, 16);
            lblTVQ.TabIndex = 4;
            lblTVQ.Text = "-";
            lblTVQ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(10, 16);
            label2.Name = "label2";
            label2.Size = new Size(78, 16);
            label2.TabIndex = 3;
            label2.Text = "Total partiel :";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMontantExcluTaxe
            // 
            lblMontantExcluTaxe.ForeColor = System.Drawing.Color.Blue;
            lblMontantExcluTaxe.Location = new Point(135, 16);
            lblMontantExcluTaxe.Margin = new Padding(3, 3, 3, 2);
            lblMontantExcluTaxe.Name = "lblMontantExcluTaxe";
            lblMontantExcluTaxe.Size = new Size(97, 16);
            lblMontantExcluTaxe.TabIndex = 2;
            lblMontantExcluTaxe.Text = "-";
            lblMontantExcluTaxe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(10, 88);
            label1.Name = "label1";
            label1.Size = new Size(54, 16);
            label1.TabIndex = 1;
            label1.Text = "Total  :";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMontantIncluTaxe
            // 
            lblMontantIncluTaxe.ForeColor = System.Drawing.Color.Blue;
            lblMontantIncluTaxe.Location = new Point(135, 88);
            lblMontantIncluTaxe.Margin = new Padding(3, 2, 3, 3);
            lblMontantIncluTaxe.Name = "lblMontantIncluTaxe";
            lblMontantIncluTaxe.Size = new Size(97, 16);
            lblMontantIncluTaxe.TabIndex = 0;
            lblMontantIncluTaxe.Text = "-";
            lblMontantIncluTaxe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMontantPD
            // 
            lblMontantPD.AutoSize = true;
            lblMontantPD.ForeColor = System.Drawing.Color.Blue;
            lblMontantPD.Location = new Point(601, 18);
            lblMontantPD.Name = "lblMontantPD";
            lblMontantPD.Size = new Size(10, 13);
            lblMontantPD.TabIndex = 12;
            lblMontantPD.Text = "-";
            lblMontantPD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lblMontantPD.Visible = false;
            // 
            // lblMontantCheque
            // 
            lblMontantCheque.AutoSize = true;
            lblMontantCheque.ForeColor = System.Drawing.Color.Blue;
            lblMontantCheque.Location = new Point(615, 18);
            lblMontantCheque.Name = "lblMontantCheque";
            lblMontantCheque.Size = new Size(10, 13);
            lblMontantCheque.TabIndex = 10;
            lblMontantCheque.Text = "-";
            lblMontantCheque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lblMontantCheque.Visible = false;
            // 
            // cbAutoFind
            // 
            cbAutoFind.Checked = true;
            cbAutoFind.CheckState = System.Windows.Forms.CheckState.Checked;
            cbAutoFind.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cbAutoFind.Location = new Point(8, 255);
            cbAutoFind.Name = "cbAutoFind";
            cbAutoFind.Size = new Size(232, 24);
            cbAutoFind.TabIndex = 17;
            cbAutoFind.Text = "Recherche automatique lors d\'un clique";
            cbAutoFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cbAutoFind.CheckedChanged += new EventHandler(cbAutoFind_CheckedChanged);
            // 
            // label5
            // 
            label5.Location = new Point(9, 39);
            label5.Name = "label5";
            label5.Size = new Size(32, 16);
            label5.TabIndex = 18;
            label5.Text = "TPS :";
            // 
            // label6
            // 
            label6.Location = new Point(9, 71);
            label6.Name = "label6";
            label6.Size = new Size(43, 16);
            label6.TabIndex = 20;
            label6.Text = "TVQ :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTPS);
            groupBox2.Controls.Add(txtTVQ);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            groupBox2.Location = new Point(264, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(120, 112);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Taxes";
            // 
            // txtTPS
            // 
            txtTPS.Location = new Point(49, 37);
            txtTPS.Name = "txtTPS";
            txtTPS.Size = new Size(65, 20);
            txtTPS.TabIndex = 19;
            txtTPS.Text = "5 %";
            txtTPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTVQ
            // 
            txtTVQ.Location = new Point(49, 69);
            txtTVQ.Name = "txtTVQ";
            txtTVQ.Size = new Size(65, 20);
            txtTVQ.TabIndex = 21;
            txtTVQ.Text = "8,5 %";
            txtTVQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ImageListSmall
            // 
            ImageListSmall.ImageStream = (ImageListStreamer)resources.GetObject("ImageListSmall.ImageStream");
            ImageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            ImageListSmall.Images.SetKeyName(0, "Moto");
            ImageListSmall.Images.SetKeyName(1, "Auto");
            ImageListSmall.Images.SetKeyName(2, "Camion");
            // 
            // lblMontantAutre
            // 
            lblMontantAutre.AutoSize = true;
            lblMontantAutre.Location = new Point(576, 17);
            lblMontantAutre.Name = "lblMontantAutre";
            lblMontantAutre.Size = new Size(10, 13);
            lblMontantAutre.TabIndex = 23;
            lblMontantAutre.Text = "-";
            lblMontantAutre.Visible = false;
            // 
            // tcRapportType
            // 
            tcRapportType.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left
                        | System.Windows.Forms.AnchorStyles.Right;
            tcRapportType.Controls.Add(tpRapportTaxe);
            tcRapportType.Controls.Add(tpCompteARecevoir);
            tcRapportType.Location = new Point(390, 47);
            tcRapportType.Name = "tcRapportType";
            tcRapportType.SelectedIndex = 0;
            tcRapportType.Size = new Size(633, 236);
            tcRapportType.TabIndex = 24;
            tcRapportType.Selected += new TabControlEventHandler(tcRapportType_Selected);
            // 
            // tpRapportTaxe
            // 
            tpRapportTaxe.Controls.Add(mcRecu1);
            tpRapportTaxe.Controls.Add(mcRecu2);
            tpRapportTaxe.Controls.Add(dtpFixeDate);
            tpRapportTaxe.Controls.Add(rbOr);
            tpRapportTaxe.Controls.Add(cmdEqual);
            tpRapportTaxe.Controls.Add(rbBetween);
            tpRapportTaxe.Location = new Point(4, 22);
            tpRapportTaxe.Name = "tpRapportTaxe";
            tpRapportTaxe.Padding = new Padding(3);
            tpRapportTaxe.Size = new Size(625, 210);
            tpRapportTaxe.TabIndex = 0;
            tpRapportTaxe.Tag = "TAXE";
            tpRapportTaxe.Text = "Relevé de paiment";
            // 
            // tpCompteARecevoir
            // 
            tpCompteARecevoir.Controls.Add(mcCompteARecevoir);
            tpCompteARecevoir.Location = new Point(4, 22);
            tpCompteARecevoir.Name = "tpCompteARecevoir";
            tpCompteARecevoir.Padding = new Padding(3);
            tpCompteARecevoir.Size = new Size(567, 210);
            tpCompteARecevoir.TabIndex = 1;
            tpCompteARecevoir.Tag = "COMPTEARECEVOIR";
            tpCompteARecevoir.Text = "Compte à recevoir";
            // 
            // mcCompteARecevoir
            // 
            mcCompteARecevoir.Location = new Point(34, 27);
            mcCompteARecevoir.MaxSelectionCount = 1;
            mcCompteARecevoir.Name = "mcCompteARecevoir";
            mcCompteARecevoir.TabIndex = 4;
            mcCompteARecevoir.DateChanged += new DateRangeEventHandler(mcCompteARecevoir_DateChanged);
            // 
            // lblMontantAC
            // 
            lblMontantAC.AutoSize = true;
            lblMontantAC.ForeColor = System.Drawing.Color.Blue;
            lblMontantAC.Location = new Point(588, 18);
            lblMontantAC.Name = "lblMontantAC";
            lblMontantAC.Size = new Size(10, 13);
            lblMontantAC.TabIndex = 14;
            lblMontantAC.Text = "-";
            lblMontantAC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lblMontantAC.Visible = false;
            // 
            // PrintCompteARecevoir
            // 
            PrintCompteARecevoir.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintCompteARecevoir_PrintPage);
            // 
            // clientControl1
            // 
            clientControl1.AutoUpdate = true;
            clientControl1.BackColor = System.Drawing.SystemColors.Control;
            customer1.AttestationNumber1 = "";
            customer1.AttestationNumber2 = "";
            customer1.BVA = false;
            customer1.BVADate = new DateTime(2005, 2, 20, 21, 27, 11, 328);
            customer1.City = "";
            customer1.ClientNull = false;
            customer1.CodePostal = "   -";
            customer1.ContratNumber = "0";
            customer1.DateAttestation1 = new DateTime(2011, 3, 31, 21, 12, 18, 576);
            customer1.DateAttestation2 = new DateTime(2011, 3, 31, 21, 12, 18, 576);
            customer1.DateDebutCours = new DateTime(2010, 3, 12, 6, 47, 55, 192);
            customer1.DateExpiration = new DateTime(2010, 3, 12, 6, 47, 55, 192);
            customer1.DateInscription = new DateTime(2003, 8, 26, 0, 0, 0, 0);
            customer1.DateNaissance = new DateTime(2010, 3, 12, 6, 47, 55, 192);
            customer1.DateTemporaire = new DateTime(2005, 2, 20, 21, 27, 11, 328);
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
            clientControl1.Client = customer1;
            clientControl1.Location = new Point(434, 300);
            clientControl1.Name = "clientControl1";
            clientControl1.School = null;
            clientControl1.Size = new Size(149, 152);
            clientControl1.TabIndex = 15;
            clientControl1.Visible = false;
            // 
            // listFindResult
            // 
            listFindResult.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom
                        | System.Windows.Forms.AnchorStyles.Left
                        | System.Windows.Forms.AnchorStyles.Right;
            listFindResult.Columns.AddRange(new ColumnHeader[] {
            colheadContratNumber,
            colheadName,
            colheadDate,
            colHeadPhone,
            colHeadTypeVehicule,
            colHeadSolde,
            colHeadLastRecuNumber,
            colHeadMontant,
            colHeadDateRecu,
            colHeadRL,
            colHeadTypePaiment});
            listFindResult.FullRowSelect = true;
            listFindResult.HideSelection = false;
            listFindResult.Location = new Point(8, 286);
            listFindResult.MultiSelect = false;
            listFindResult.Name = "listFindResult";
            listFindResult.Size = new Size(1011, 226);
            listFindResult.SmallImageList = ImageListSmall;
            listFindResult.TabIndex = 0;
            listFindResult.UseCompatibleStateImageBehavior = false;
            listFindResult.View = System.Windows.Forms.View.Details;
            listFindResult.Click += new EventHandler(listFindResult_Click);
            // 
            // colheadContratNumber
            // 
            colheadContratNumber.Text = "# Contrat";
            colheadContratNumber.Width = 66;
            // 
            // colheadName
            // 
            colheadName.Text = "Nom du client";
            colheadName.Width = 156;
            // 
            // colheadDate
            // 
            colheadDate.Text = "Date du paiment";
            colheadDate.Width = 91;
            // 
            // colHeadPhone
            // 
            colHeadPhone.Text = "Téléphone";
            colHeadPhone.Width = 91;
            // 
            // colHeadTypeVehicule
            // 
            colHeadTypeVehicule.Text = "Type de cours";
            colHeadTypeVehicule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            colHeadTypeVehicule.Width = 92;
            // 
            // colHeadSolde
            // 
            colHeadSolde.Text = "Solde";
            colHeadSolde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            colHeadSolde.Width = 64;
            // 
            // colHeadLastRecuNumber
            // 
            colHeadLastRecuNumber.Text = "Numéro de recu";
            colHeadLastRecuNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            colHeadLastRecuNumber.Width = 89;
            // 
            // colHeadMontant
            // 
            colHeadMontant.Text = "Montant";
            colHeadMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            colHeadMontant.Width = 63;
            // 
            // colHeadDateRecu
            // 
            colHeadDateRecu.Text = "Date reçu";
            colHeadDateRecu.Width = 0;
            // 
            // colHeadRL
            // 
            colHeadRL.Text = "Type";
            colHeadRL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colHeadTypePaiment
            // 
            colHeadTypePaiment.Text = "Type Paiment";
            colHeadTypePaiment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            colHeadTypePaiment.Width = 84;
            // 
            // FormFinance
            // 
            ClientSize = new Size(1027, 518);
            Controls.Add(tcRapportType);
            Controls.Add(toolBar1);
            Controls.Add(lblMontantAutre);
            Controls.Add(lblMontantAC);
            Controls.Add(groupBox2);
            Controls.Add(lblMontantCheque);
            Controls.Add(lblMontantPD);
            Controls.Add(cbAutoFind);
            Controls.Add(clientControl1);
            Controls.Add(listFindResult);
            Controls.Add(groupBox1);
            Name = "FormFinance";
            Text = "FormFinance";
            Load += new EventHandler(FormFindClient_Load);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tcRapportType.ResumeLayout(false);
            tpRapportTaxe.ResumeLayout(false);
            tpCompteARecevoir.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion

        #region Methodes
        /// <summary>
        /// Trie par date
        /// </summary>
        private void SortByDate()
        {
            listFindResult.SortColumn(2);
        }

        private void Find()
        {
            listFindResult.Items.Clear();

            Cursor.Current = Cursors.WaitCursor;

            switch (_ReleverMode)
            {
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
        private void FindDateCompteARecevoir()
        {
            CustomerCollection ClientList = _FormMain.ClientList;
            decimal solde = 0;

            for (int i = 0; i < ClientList.Count; i++)
            {
                //Avant la recherche il faut verifier que le client etais inscrit a ce moment la
                if (ClientList[i].DateInscription.Date <= mcCompteARecevoir.SelectionStart.Date)
                {
                    solde = Decimal.Round(ClientList[i].GetSolde(mcCompteARecevoir.SelectionStart.Date), 2);

                    if (solde > 0)
                        AddClientToList(ClientList[i], solde);
                }
            }
        }

        /// <summary>
        /// Recherche par date de recu
        /// </summary>
        private void FindDateRecu()
        {
            CustomerCollection ClientList = _FormMain.ClientList;
            Paiement paiment = null;

            for (int i = 0; i < ClientList.Count; i++)
            {
                for (int j = 0; j < ClientList[i].Paiment.Count; j++)
                {
                    paiment = ClientList[i].Paiment[j];

                    switch (rbBetween.Checked)
                    {
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
        private void PaimentAnneeCourante()
        {
        }

        /// <summary>
        /// Affiche les informations sur la prériodes dans les controles
        /// </summary>
        private void ShowPaimentInfo()
        {
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

            decimal VariableTaxe = 100 * (txtTPS.DecimalValue + 1) * (txtTVQ.DecimalValue + 1);

            //Initialise a 0;
            lblTPS.Text = lblTVQ.Text = lblMontantExcluTaxe.Text = lblMontantIncluTaxe.Text =
            lblMontantCheque.Text = lblMontantAC.Text = lblMontantPD.Text = "0,00 $";

            for (int i = 0; i < listFindResult.Items.Count; i++)
            {
                switch (_ReleverMode)
                {
                    case TypeRelever.CompteARecevoir:
                        montant = Convert.ToDecimal(listFindResult.Items[i].SubItems[5].Text.Replace(" $", ""));
                        break;
                    case TypeRelever.Taxe:
                        montant = Convert.ToDecimal(listFindResult.Items[i].SubItems[7].Text.Replace(" $", ""));
                        break;
                }

                switch (listFindResult.Items[i].SubItems[10].Text)
                {
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

                switch (listFindResult.Items[i].SubItems[9].Text)
                {
                    case "RL":
                        TotalLivre += montant;
                        break;
                }

                TotalSansTaxe += montant / VariableTaxe * 100;
                Total += montant;

            }

            //Cacule de la taxe
            //if (TotalLivre != 0) //si il y a des livre avec 1 taxe seulement (TVQ)
            //    tps = (((Total - TotalLivre) / VariableTaxe) * 100) * txtTPS.DecimalValue;
            //else
            //    tps = (TotalSansTaxe) * txtTPS.DecimalValue;                
            //tvq = (TotalSansTaxe + tps) * txtTVQ.DecimalValue;

            //Cacule de la taxe
            if (TotalLivre != 0)
            { //si il y a des livre avec 1 taxe seulement (TVQ)
                tps = TotalSansTaxe * txtTPS.DecimalValue;
                tvq = (((Total - TotalLivre) / VariableTaxe * 100) + tps) * txtTVQ.DecimalValue;
                //tvq = (TotalSansTaxe + tps) * txtTVQ.DecimalValue;
            }
            else
            {
                tps = TotalSansTaxe * txtTPS.DecimalValue;
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
        private void AddClientToList(Customer client, Paiement paimentInfo)
        {
            ListViewItem itm = new ListViewItem();
            string type;
            string typePaiment = "";

            itm.Text = client.ContratNumber;
            itm.SubItems.Add(client.FirstName + " " + client.Name);
            itm.SubItems.Add(paimentInfo.DatePaiment.ToShortDateString());
            itm.SubItems.Add(client.Phone);
            itm.SubItems.Add(client.TypeVehicule == VehiculeType.Cyclomoteur && client.IsSpyder
                                ? "Spyder" 
                                : client.TypeVehicule.ToString());
            itm.SubItems.Add(client.Solde);
            itm.SubItems.Add(paimentInfo.NumeroRecu.ToString());
            itm.SubItems.Add(paimentInfo.Montant);
            itm.SubItems.Add(paimentInfo.DatePaiment.ToShortDateString());

            if (paimentInfo.Type == PaiementType.RetourLivre)
                type = "RL";
            else if (paimentInfo.Type == PaiementType.LocationAuto)
                type = "LA";
            else type = paimentInfo.Type == PaiementType.Absence ? "ABS" : "";

            itm.SubItems.Add(type);

            switch (client.TypeVehicule)
            {
                case VehiculeType.Automatique:
                    itm.ImageKey = "Auto";
                    break;
                case VehiculeType.Cyclomoteur:
                    itm.ImageKey = "Moto";
                    break;
                case VehiculeType.Manuel:
                    itm.ImageKey = "Auto";
                    break;
                case VehiculeType.Moto:
                    itm.ImageKey = "Moto";
                    break;
            }

            switch (paimentInfo.TypePaiment)
            {
                case TypePaiment.ArgentComptant:
                    typePaiment = "AC";
                    break;
                case TypePaiment.VISA:
                    typePaiment = "VISA";
                    break;
                case TypePaiment.MasterCard:
                    typePaiment = "MC";
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
        private void AddClientToList(Customer client, decimal solde)
        {
            ListViewItem itm = new ListViewItem
            {
                Text = client.ContratNumber
            };
            itm.SubItems.Add(client.FirstName + " " + client.Name);
            itm.SubItems.Add("");
            itm.SubItems.Add(client.Phone);
            itm.SubItems.Add(client.TypeVehicule.ToString());
            itm.SubItems.Add(solde + " $");
            itm.SubItems.Add("");
            itm.SubItems.Add("");
            itm.SubItems.Add("");
            itm.SubItems.Add("");

            switch (client.TypeVehicule)
            {
                case VehiculeType.Automatique:
                    itm.ImageKey = "Auto";
                    break;
                case VehiculeType.Cyclomoteur:
                    itm.ImageKey = "Moto";
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
        private void PrintDoc()
        {
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

            switch (_ReleverMode)
            {
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

        private void PrintRelever_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float topMargin = 30;
            float leftMargin = 0;//e.MarginBounds.Left;
            float rightMargin = e.MarginBounds.Right;

            //Defini le style de l'alignement
            StringFormat style = new StringFormat
            {
                Alignment = StringAlignment.Near
            };

            //Facrication de la font
            Font printFont = new Font("Times New Roman", 12, FontStyle.Regular);
            Font printFontBold = new Font("Times New Roman", 12, FontStyle.Bold);
            Font printFontBold16 = new Font("Times New Roman", 16, FontStyle.Bold);

            float yPos = 0f;

            #region Header
            if (_HeaderPrinted == false)
            {
                //Initialisation des variables dans le bloc header pour q'il ne le
                //face qu'a la premiere page
                _TotalLine = listFindResult.Items.Count;
                _LinesPerPage = Convert.ToInt32((e.MarginBounds.Height - 40) / printFont.GetHeight(e.Graphics));
                _TotalPage = Convert.ToInt32(Decimal.Round(Convert.ToDecimal(_TotalLine) / Convert.ToDecimal(_LinesPerPage), 0));
                if (_TotalPage == 0) _TotalPage = 1;

                //Date(s) de relever : Choisi le bon type de Header a écrire
                yPos = topMargin + 5;
                switch (rbBetween.Checked == true)
                {
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
            e.Graphics.DrawString("Nom du client", printFontBold, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
            e.Graphics.DrawString("# Contrat", printFontBold, Brushes.Black, leftMargin + 300, yPos, new StringFormat());
            e.Graphics.DrawString("# Reçu", printFontBold, Brushes.Black, leftMargin + 400, yPos, new StringFormat());
            e.Graphics.DrawString("Date", printFontBold, Brushes.Black, leftMargin + 475, yPos, new StringFormat());
            e.Graphics.DrawString("Montant", printFontBold, Brushes.Black, leftMargin + 575, yPos, new StringFormat());
            e.Graphics.DrawString("Type", printFontBold, Brushes.Black, leftMargin + 650, yPos, new StringFormat());
            e.Graphics.DrawString("TP", printFontBold, Brushes.Black, leftMargin + 720, yPos, new StringFormat());

            //Creation de l'objet client
            Customer client = null;

            yPos += 20;
            //Impression de toute les lignes du tableau
            while (_LinePrinted < listFindResult.Items.Count - 1)
            {
                _LinePrinted++;

                client = GetClient(listFindResult.Items[_LinePrinted].Text);

                if (client != null)
                {

                    //Montant des locations
                    if (client.MontantLocation == "")
                        client.MontantLocation = "0,00 $";

                    yPos += printFont.Height;
                    e.Graphics.DrawString(_LinePrinted + 1 + " - ", printFont, Brushes.Black, leftMargin + 5, yPos, new StringFormat());
                    e.Graphics.DrawString(client.FirstName + " " + client.Name, printFont, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
                    e.Graphics.DrawString(listFindResult.Items[_LinePrinted].Text, printFont, Brushes.Black, leftMargin + 300, yPos, new StringFormat());
                    e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[6].Text, printFont, Brushes.Black, leftMargin + 400, yPos, new StringFormat());
                    e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[8].Text, printFont, Brushes.Black, leftMargin + 475, yPos, new StringFormat());
                    e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[7].Text, printFont, Brushes.Black, 640 - e.Graphics.MeasureString(listFindResult.Items[_LinePrinted].SubItems[7].Text, printFont).Width, yPos, new StringFormat());
                    e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[9].Text, printFont, Brushes.Black, leftMargin + 650, yPos, new StringFormat());
                    e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[10].Text, printFont, Brushes.Black, leftMargin + 720, yPos, new StringFormat());

                    #region Creation d'une nouvelle page et numéro de page
                    string PageNumber = "Page : " + _TotalPagePrinted.ToString() + "/" + _TotalPage.ToString();
                    if (yPos >= e.MarginBounds.Height + 50)
                    {
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
                    }
                    else
                    {
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
            if (_FootPrinted == true)
            {
                //Impression du calcule des taxe (TPS et TVQ)
                yPos += 30;
                e.Graphics.DrawString("Cumulatif des Paiments _______________________", printFontBold16, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
                yPos += printFont.Height + 15;
                e.Graphics.DrawString("Nombre de paiments : ", printFont, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
                e.Graphics.DrawString(_LinePrinted + 1 + "", printFont, Brushes.Black, leftMargin + 220, yPos, new StringFormat());
                yPos += printFont.Height;
                e.Graphics.DrawString("Total partiel : ", printFont, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
                e.Graphics.DrawString(lblMontantExcluTaxe.Text, printFont, Brushes.Black, 300 - e.Graphics.MeasureString(lblMontantExcluTaxe.Text, printFont).Width, yPos, new StringFormat());
                e.Graphics.DrawString("Chèque : ", printFont, Brushes.Black, leftMargin + 350, yPos, new StringFormat());
                e.Graphics.DrawString(lblMontantCheque.Text, printFont, Brushes.Black, 600 - e.Graphics.MeasureString(lblMontantCheque.Text, printFont).Width, yPos, new StringFormat());
                yPos += printFont.Height;
                e.Graphics.DrawString("TPS : ", printFont, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
                e.Graphics.DrawString(lblTPS.Text, printFont, Brushes.Black, 300 - e.Graphics.MeasureString(lblTPS.Text, printFont).Width, yPos, new StringFormat());
                e.Graphics.DrawString("Argent Comptant : ", printFont, Brushes.Black, leftMargin + 350, yPos, new StringFormat());
                e.Graphics.DrawString(lblMontantAC.Text, printFont, Brushes.Black, 600 - e.Graphics.MeasureString(lblMontantAC.Text, printFont).Width, yPos, new StringFormat());
                yPos += printFont.Height;
                e.Graphics.DrawString("TVQ : ", printFont, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
                e.Graphics.DrawString(lblTVQ.Text, printFont, Brushes.Black, 300 - e.Graphics.MeasureString(lblTVQ.Text, printFont).Width, yPos, new StringFormat());
                e.Graphics.DrawString("Paiment Direct : ", printFont, Brushes.Black, leftMargin + 350, yPos, new StringFormat());
                e.Graphics.DrawString(lblMontantPD.Text, printFont, Brushes.Black, 600 - e.Graphics.MeasureString(lblMontantPD.Text, printFont).Width, yPos, new StringFormat());
                yPos += printFont.Height;
                e.Graphics.DrawString("Total : ", printFont, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
                e.Graphics.DrawString(lblMontantIncluTaxe.Text, printFont, Brushes.Black, 300 - e.Graphics.MeasureString(lblMontantIncluTaxe.Text, printFont).Width, yPos, new StringFormat());
                e.Graphics.DrawString("Autre : ", printFont, Brushes.Black, leftMargin + 350, yPos, new StringFormat());
                e.Graphics.DrawString(lblMontantAutre.Text, printFont, Brushes.Black, 600 - e.Graphics.MeasureString(lblMontantAutre.Text, printFont).Width, yPos, new StringFormat());

                _FootPrinted = false; //pied imprimé
            }
            #endregion
        }


        private void PrintCompteARecevoir_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float topMargin = 30;
            float leftMargin = 0;//e.MarginBounds.Left;
            float rightMargin = e.MarginBounds.Right;

            //Defini le style de l'alignement
            StringFormat style = new StringFormat
            {
                Alignment = StringAlignment.Near
            };

            //Facrication de la font
            Font printFont = new Font("Times New Roman", 12, FontStyle.Regular);
            Font printFontBold = new Font("Times New Roman", 12, FontStyle.Bold);
            Font printFontBold16 = new Font("Times New Roman", 16, FontStyle.Bold);

            float yPos = 0f;

            #region Header
            if (_HeaderPrinted == false)
            {
                //Initialisation des variables dans le bloc header pour q'il ne le
                //face qu'a la premiere page
                _TotalLine = listFindResult.Items.Count;
                _LinesPerPage = Convert.ToInt32((e.MarginBounds.Height - 40) / printFont.GetHeight(e.Graphics));
                _TotalPage = Convert.ToInt32(Decimal.Round(Convert.ToDecimal(_TotalLine) / Convert.ToDecimal(_LinesPerPage), 0));
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
            while (_LinePrinted < listFindResult.Items.Count - 1)
            {
                _LinePrinted++;

                client = GetClient(listFindResult.Items[_LinePrinted].Text);

                if (client != null)
                {

                    //Montant des locations
                    if (client.MontantLocation == "")
                        client.MontantLocation = "0,00 $";

                    yPos += printFont.Height;
                    e.Graphics.DrawString(_LinePrinted + 1 + " - ", printFont, Brushes.Black, leftMargin + 5, yPos, new StringFormat());
                    e.Graphics.DrawString(client.FirstName + " " + client.Name, printFont, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
                    e.Graphics.DrawString(listFindResult.Items[_LinePrinted].Text, printFont, Brushes.Black, leftMargin + 400, yPos, new StringFormat());
                    e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[5].Text, printFont, Brushes.Black, 575 - e.Graphics.MeasureString(listFindResult.Items[_LinePrinted].SubItems[5].Text, printFont).Width, yPos, new StringFormat());

                    #region Creation d'une nouvelle page et numéro de page
                    string PageNumber = "Page : " + _TotalPagePrinted.ToString() + "/" + _TotalPage.ToString();
                    if (yPos >= e.MarginBounds.Height + 50)
                    {
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
                    }
                    else
                    {
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
            if (_FootPrinted == true)
            {
                //Impression du calcule des taxe (TPS et TVQ)
                yPos += 30;
                e.Graphics.DrawString("Cumulatif _______________________", printFontBold16, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
                yPos += printFont.Height + 15;
                e.Graphics.DrawString("Nombre de clients : ", printFont, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
                e.Graphics.DrawString(_LinePrinted + 1 + "", printFont, Brushes.Black, leftMargin + 220, yPos, new StringFormat());
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
        private Customer GetClient(string ContratNumber)
        {
            //Selection du bon client
            CustomerCollection ClientList = _FormMain.ClientList;

            for (int i = 0; i < ClientList.Count; i++)
            {
                if (ClientList[i].ContratNumber == ContratNumber) //Recherche par numero de contrat
                    return ClientList[i];
            }

            return null;
        }
        #endregion

        private void FormFindClient_Load(object sender, EventArgs e)
        {

        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            switch (e.Button.Tag.ToString())
            {
                case "PRINT":
                    clientControl1.PrintDoc(Barette.Library.UserControls.Client.PrintDocumentType.InfoClient);
                    break;
                case "OPENSEANCE":
                    if (listFindResult.SelectedItems[0].SubItems[6].Text != "")
                    {
                        if (clientControl1.ShowPaiement(Convert.ToInt32(listFindResult.SelectedItems[0].SubItems[6].Text)) == DialogResult.OK)
                        {
                            Find();
                            ShowPaimentInfo();
                        }
                    }
                    else
                    {
                        if (clientControl1.ShowPaiement() == DialogResult.OK)
                        {
                            Find();
                            ShowPaimentInfo();
                        }
                    }
                    break;
                case "SHOWCLIENT":
                    _FormMain.CreationListClient(listFindResult.SelectedItems[0].Text);
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

        private void listFindResult_Click(object sender, EventArgs e)
        {
            try
            {
                Customer client = GetClient(listFindResult.SelectedItems[0].Text);

                if (client != null)
                    clientControl1.Client = GetClient(listFindResult.SelectedItems[0].Text);
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tbbShowClient.Enabled = listFindResult.SelectedItems.Count == 0
                ? (tbbShowSeance.Enabled =
                    tbbPrintClientInfo.Enabled = false)
                : (tbbShowSeance.Enabled =
                    tbbPrintClientInfo.Enabled = true);

            tbbTPSTVQ.Enabled = listFindResult.Items.Count > 0;
        }

        private void cmdEqual_Click(object sender, EventArgs e)
        {
            mcRecu2.SelectionStart = mcRecu1.SelectionStart;
        }

        private void mcRecu1_DateChanged(object sender, DateRangeEventArgs e)
        {
            rbBetween.Checked = true;
            if (cbAutoFind.Checked == true)
                Find();
        }

        private void mcRecu2_DateChanged(object sender, DateRangeEventArgs e)
        {
            rbBetween.Checked = true;
            if (cbAutoFind.Checked == true)
                Find();
        }

        private void dtpFixeDate_ValueChanged(object sender, EventArgs e)
        {
            rbOr.Checked = true;
            if (cbAutoFind.Checked == true)
                Find();
        }

        private void cbAutoFind_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutoFind.Checked == true)
                Find();
        }

        private void tcRapportType_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPage.Tag.ToString())
            {
                case "COMPTEARECEVOIR":
                    _ReleverMode = TypeRelever.CompteARecevoir;
                    break;
                case "TAXE":
                    _ReleverMode = TypeRelever.Taxe;
                    break;
            }

            //listFindResult.Items.Clear();
            if (cbAutoFind.Checked == true)
                Find();
        }

        private void mcCompteARecevoir_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (cbAutoFind.Checked == true)
                Find();
        }
    }
}

