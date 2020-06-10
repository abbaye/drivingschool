using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Text;
using Barette.Library.Client;
using Barette.Library.Listview;

namespace Barette.Library.UserControls.Client
{
    /// <summary>
    /// Description résumée de FormPaiment.
    /// </summary>
    public class FormPaiment : Form
    {
		private Label label1;
		private Button cmdCancel;
		private Label label2;
		private Label label15;
		private ColumnHeader colHeadDate;
		private ColumnHeader colHeadMontant;
		private ColumnHeader colHeadRecuNumber;
		private Label label3;
		private Label label4;
		private Label label6;
		private Label lblSolde;
		private DateTimePicker DateFacture;
		private ListView ListViewPaiment;
		private Button cmdMakePaiment;
		private System.ComponentModel.IContainer components;
		private GroupBox gbPaiment;

		//Control Client référancé
		private readonly ClientControl _ClientCtrl = null;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private PrintPreviewDialog printPreviewDialog1;

		private readonly Customer _Client = null;
        private readonly SchoolInfo _infoSchool = null;

		private PaiementMode _Mode = PaiementMode.Nouveau;
		private Button cmdAddLocation;
		private ColumnHeader colHeadRL;
		private Button cmdApply;
		private ToolBar toolBar1;
		private ToolBarButton tbbAddPaiment;
		private ToolBarButton tbbDelete;
		private ToolBarButton tbbSeparator1;
		private ToolBarButton tbbPrint;
		private ImageList imageList1;
		private Timer timerSelection;
		private GroupBox groupBox1;
		private ColumnHeader colHeadTypePaiment;
		private RadioButton rbAutre;
		private RadioButton rbArgentComptant;
		private RadioButton rbPaimentDirect;
		private RadioButton rbCheque;
		private TextBox txtTypePaiment;
		private System.Timers.Timer timerAutuUpdate;
		private UtilityLibrary.WinControls.NumericTextBox NumeroRecu;
		private CashTextBox MontantPaiment;
		private CashTextBox cbTotalCours;
		private GroupBox groupBox2;
		private Button button1;
		private RadioButton cbRetourLivre;
		private RadioButton cbLocationAuto;
        private RadioButton cbAbsence;
        private ColumnHeader colHeadTPS;
        private ColumnHeader colHeadTVQ;
        private RadioButton rbMasterCard;
        private RadioButton rbVISA;
        private readonly long _RecuNumberWhenOpen = 0;

		public FormPaiment(ClientControl clientCtrl, Customer client, SchoolInfo info) {
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

            _ClientCtrl = clientCtrl;
            _Client = client;
            _infoSchool = info;

			//Ecrire la date du jour
			DateFacture.Value = DateTime.Now;

			LoadList();
			MakeNew();

			//création du ficher : numéro de recu
			if (!File.Exists(@"Data\recunumber.xml"))
				SaveNewRecuNumber(12000);

            _RecuNumberWhenOpen = GetRecuNumber();
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

		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            ListViewGroup listViewGroup11 = new ListViewGroup("Livres", System.Windows.Forms.HorizontalAlignment.Left);
            ListViewGroup listViewGroup12 = new ListViewGroup("Location Automobile", System.Windows.Forms.HorizontalAlignment.Left);
            ListViewGroup listViewGroup13 = new ListViewGroup("Paiements Normaux", System.Windows.Forms.HorizontalAlignment.Left);
            ListViewGroup listViewGroup14 = new ListViewGroup("Absense", System.Windows.Forms.HorizontalAlignment.Left);
            ListViewGroup listViewGroup15 = new ListViewGroup("Credit", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaiment));
            this.ListViewPaiment = new ListView();
            this.colHeadDate = ((ColumnHeader)(new ColumnHeader()));
            this.colHeadMontant = ((ColumnHeader)(new ColumnHeader()));
            this.colHeadTPS = ((ColumnHeader)(new ColumnHeader()));
            this.colHeadTVQ = ((ColumnHeader)(new ColumnHeader()));
            this.colHeadRecuNumber = ((ColumnHeader)(new ColumnHeader()));
            this.colHeadRL = ((ColumnHeader)(new ColumnHeader()));
            this.colHeadTypePaiment = ((ColumnHeader)(new ColumnHeader()));
            this.label1 = new Label();
            this.gbPaiment = new GroupBox();
            this.groupBox2 = new GroupBox();
            this.cbAbsence = new RadioButton();
            this.cbLocationAuto = new RadioButton();
            this.cbRetourLivre = new RadioButton();
            this.button1 = new Button();
            this.groupBox1 = new GroupBox();
            this.rbMasterCard = new RadioButton();
            this.rbVISA = new RadioButton();
            this.txtTypePaiment = new TextBox();
            this.rbAutre = new RadioButton();
            this.rbArgentComptant = new RadioButton();
            this.rbPaimentDirect = new RadioButton();
            this.rbCheque = new RadioButton();
            this.NumeroRecu = new UtilityLibrary.WinControls.NumericTextBox();
            this.label3 = new Label();
            this.DateFacture = new DateTimePicker();
            this.label15 = new Label();
            this.MontantPaiment = new CashTextBox();
            this.label2 = new Label();
            this.cmdMakePaiment = new Button();
            this.cmdCancel = new Button();
            this.cmdApply = new Button();
            this.label4 = new Label();
            this.label6 = new Label();
            this.lblSolde = new Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new PrintPreviewDialog();
            this.cmdAddLocation = new Button();
            this.toolBar1 = new ToolBar();
            this.tbbAddPaiment = new ToolBarButton();
            this.tbbDelete = new ToolBarButton();
            this.tbbSeparator1 = new ToolBarButton();
            this.tbbPrint = new ToolBarButton();
            this.imageList1 = new ImageList(this.components);
            this.timerSelection = new Timer(this.components);
            this.timerAutuUpdate = new System.Timers.Timer();
            this.cbTotalCours = new CashTextBox();
            this.gbPaiment.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerAutuUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // ListViewPaiment
            // 
            this.ListViewPaiment.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListViewPaiment.Columns.AddRange(new ColumnHeader[] {
            this.colHeadDate,
            this.colHeadMontant,
            this.colHeadTPS,
            this.colHeadTVQ,
            this.colHeadRecuNumber,
            this.colHeadRL,
            this.colHeadTypePaiment});
            this.ListViewPaiment.FullRowSelect = true;
            listViewGroup11.Header = "Livres";
            listViewGroup11.Name = "RetourLivre";
            listViewGroup12.Header = "Location Automobile";
            listViewGroup12.Name = "LocationAuto";
            listViewGroup13.Header = "Paiements Normaux";
            listViewGroup13.Name = "General";
            listViewGroup14.Header = "Absense";
            listViewGroup14.Name = "Absense";
            listViewGroup15.Header = "Credit";
            listViewGroup15.Name = "Credit";
            this.ListViewPaiment.Groups.AddRange(new ListViewGroup[] {
            listViewGroup11,
            listViewGroup12,
            listViewGroup13,
            listViewGroup14,
            listViewGroup15});
            this.ListViewPaiment.HideSelection = false;
            this.ListViewPaiment.LabelWrap = false;
            this.ListViewPaiment.Location = new Point(8, 48);
            this.ListViewPaiment.MultiSelect = false;
            this.ListViewPaiment.Name = "ListViewPaiment";
            this.ListViewPaiment.Size = new Size(555, 403);
            this.ListViewPaiment.TabIndex = 0;
            this.ListViewPaiment.TabStop = false;
            this.ListViewPaiment.UseCompatibleStateImageBehavior = false;
            this.ListViewPaiment.View = System.Windows.Forms.View.Details;
            this.ListViewPaiment.ColumnClick += new ColumnClickEventHandler(this.ListViewPaiment_ColumnClick);
            this.ListViewPaiment.SelectedIndexChanged += new EventHandler(this.ListViewPaiment_SelectedIndexChanged);
            // 
            // colHeadDate
            // 
            this.colHeadDate.Text = "Date";
            this.colHeadDate.Width = 84;
            // 
            // colHeadMontant
            // 
            this.colHeadMontant.Text = "Montant (tx inc)";
            this.colHeadMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colHeadMontant.Width = 90;
            // 
            // colHeadTPS
            // 
            this.colHeadTPS.Text = "TPS";
            this.colHeadTPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colHeadTVQ
            // 
            this.colHeadTVQ.Text = "TVQ";
            this.colHeadTVQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colHeadRecuNumber
            // 
            this.colHeadRecuNumber.Text = "Numéro de reçu";
            this.colHeadRecuNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHeadRecuNumber.Width = 96;
            // 
            // colHeadRL
            // 
            this.colHeadRL.Text = "Type";
            this.colHeadRL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHeadRL.Width = 56;
            // 
            // colHeadTypePaiment
            // 
            this.colHeadTypePaiment.Text = "Type Paiment";
            this.colHeadTypePaiment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHeadTypePaiment.Width = 79;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new Point(574, 48);
            this.label1.Name = "label1";
            this.label1.Size = new Size(160, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Montant (Cours +                     )";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbPaiment
            // 
            this.gbPaiment.Controls.Add(this.groupBox2);
            this.gbPaiment.Controls.Add(this.groupBox1);
            this.gbPaiment.Controls.Add(this.NumeroRecu);
            this.gbPaiment.Controls.Add(this.label3);
            this.gbPaiment.Controls.Add(this.DateFacture);
            this.gbPaiment.Controls.Add(this.label15);
            this.gbPaiment.Controls.Add(this.MontantPaiment);
            this.gbPaiment.Controls.Add(this.label2);
            this.gbPaiment.Controls.Add(this.cmdMakePaiment);
            this.gbPaiment.Enabled = false;
            this.gbPaiment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbPaiment.Location = new Point(574, 75);
            this.gbPaiment.Name = "gbPaiment";
            this.gbPaiment.Size = new Size(312, 343);
            this.gbPaiment.TabIndex = 1;
            this.gbPaiment.TabStop = false;
            this.gbPaiment.Text = "Information sur le paiment";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbAbsence);
            this.groupBox2.Controls.Add(this.cbLocationAuto);
            this.groupBox2.Controls.Add(this.cbRetourLivre);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new Point(167, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(133, 174);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type";
            // 
            // cbAbsence
            // 
            this.cbAbsence.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAbsence.AutoSize = true;
            this.cbAbsence.Location = new Point(7, 73);
            this.cbAbsence.Margin = new Padding(3, 3, 3, 1);
            this.cbAbsence.Name = "cbAbsence";
            this.cbAbsence.Size = new Size(67, 17);
            this.cbAbsence.TabIndex = 31;
            this.cbAbsence.Text = "Absence";
            // 
            // cbLocationAuto
            // 
            this.cbLocationAuto.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLocationAuto.AutoSize = true;
            this.cbLocationAuto.Location = new Point(7, 49);
            this.cbLocationAuto.Name = "cbLocationAuto";
            this.cbLocationAuto.Size = new Size(66, 17);
            this.cbLocationAuto.TabIndex = 30;
            this.cbLocationAuto.Text = "Location";
            // 
            // cbRetourLivre
            // 
            this.cbRetourLivre.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRetourLivre.AutoSize = true;
            this.cbRetourLivre.Location = new Point(7, 24);
            this.cbRetourLivre.Name = "cbRetourLivre";
            this.cbRetourLivre.Size = new Size(53, 17);
            this.cbRetourLivre.TabIndex = 29;
            this.cbRetourLivre.Text = "Livres";
            // 
            // button1
            // 
            this.button1.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new Point(7, 138);
            this.button1.Margin = new Padding(3, 2, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new Size(120, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Aucun";
            this.button1.Click += new EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMasterCard);
            this.groupBox1.Controls.Add(this.rbVISA);
            this.groupBox1.Controls.Add(this.txtTypePaiment);
            this.groupBox1.Controls.Add(this.rbAutre);
            this.groupBox1.Controls.Add(this.rbArgentComptant);
            this.groupBox1.Controls.Add(this.rbPaimentDirect);
            this.groupBox1.Controls.Add(this.rbCheque);
            this.groupBox1.Location = new Point(7, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(153, 174);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type de Paiment";
            // 
            // rbMasterCard
            // 
            this.rbMasterCard.AutoSize = true;
            this.rbMasterCard.Location = new Point(7, 118);
            this.rbMasterCard.Name = "rbMasterCard";
            this.rbMasterCard.Size = new Size(79, 17);
            this.rbMasterCard.TabIndex = 6;
            this.rbMasterCard.Text = "MasterCard";
            // 
            // rbVISA
            // 
            this.rbVISA.AutoSize = true;
            this.rbVISA.Location = new Point(7, 95);
            this.rbVISA.Name = "rbVISA";
            this.rbVISA.Size = new Size(49, 17);
            this.rbVISA.TabIndex = 5;
            this.rbVISA.Text = "VISA";
            // 
            // txtTypePaiment
            // 
            this.txtTypePaiment.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTypePaiment.Location = new Point(73, 140);
            this.txtTypePaiment.MaxLength = 8;
            this.txtTypePaiment.Name = "txtTypePaiment";
            this.txtTypePaiment.Size = new Size(71, 20);
            this.txtTypePaiment.TabIndex = 4;
            // 
            // rbAutre
            // 
            this.rbAutre.AutoSize = true;
            this.rbAutre.Location = new Point(7, 141);
            this.rbAutre.Name = "rbAutre";
            this.rbAutre.Size = new Size(56, 17);
            this.rbAutre.TabIndex = 3;
            this.rbAutre.Text = "Autre :";
            // 
            // rbArgentComptant
            // 
            this.rbArgentComptant.AutoSize = true;
            this.rbArgentComptant.Location = new Point(7, 72);
            this.rbArgentComptant.Name = "rbArgentComptant";
            this.rbArgentComptant.Size = new Size(103, 17);
            this.rbArgentComptant.TabIndex = 2;
            this.rbArgentComptant.Text = "Argent comptant";
            // 
            // rbPaimentDirect
            // 
            this.rbPaimentDirect.AutoSize = true;
            this.rbPaimentDirect.Location = new Point(7, 48);
            this.rbPaimentDirect.Name = "rbPaimentDirect";
            this.rbPaimentDirect.Size = new Size(94, 17);
            this.rbPaimentDirect.TabIndex = 1;
            this.rbPaimentDirect.Text = "Paiment Direct";
            // 
            // rbCheque
            // 
            this.rbCheque.AutoSize = true;
            this.rbCheque.Location = new Point(7, 24);
            this.rbCheque.Name = "rbCheque";
            this.rbCheque.Size = new Size(62, 17);
            this.rbCheque.TabIndex = 0;
            this.rbCheque.Text = "Chèque";
            // 
            // NumeroRecu
            // 
            this.NumeroRecu.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumeroRecu.Location = new Point(144, 88);
            this.NumeroRecu.Name = "NumeroRecu";
            this.NumeroRecu.SetRange = new Size(0, 99999999);
            this.NumeroRecu.ShortcutsEnabled = false;
            this.NumeroRecu.Size = new Size(89, 20);
            this.NumeroRecu.TabIndex = 25;
            this.NumeroRecu.Text = "0";
            this.NumeroRecu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumeroRecu.Value = 0;
            // 
            // label3
            // 
            this.label3.Location = new Point(7, 24);
            this.label3.Name = "label3";
            this.label3.Size = new Size(100, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Date :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateFacture
            // 
            this.DateFacture.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateFacture.Location = new Point(144, 24);
            this.DateFacture.Name = "DateFacture";
            this.DateFacture.Size = new Size(160, 20);
            this.DateFacture.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.Location = new Point(7, 88);
            this.label15.Name = "label15";
            this.label15.Size = new Size(120, 16);
            this.label15.TabIndex = 20;
            this.label15.Text = "Numéro de reçu :";
            // 
            // MontantPaiment
            // 
            this.MontantPaiment.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MontantPaiment.Location = new Point(144, 56);
            this.MontantPaiment.Name = "MontantPaiment";
            this.MontantPaiment.Size = new Size(88, 20);
            this.MontantPaiment.TabIndex = 1;
            this.MontantPaiment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Location = new Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new Size(120, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Montant du paiment :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdMakePaiment
            // 
            this.cmdMakePaiment.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdMakePaiment.Image = global::Barette.Library.Properties.Resources.add_icon;
            this.cmdMakePaiment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdMakePaiment.Location = new Point(153, 295);
            this.cmdMakePaiment.Name = "cmdMakePaiment";
            this.cmdMakePaiment.Size = new Size(151, 40);
            this.cmdMakePaiment.TabIndex = 4;
            this.cmdMakePaiment.Text = "Effectuer un paiment";
            this.cmdMakePaiment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdMakePaiment.Click += new EventHandler(this.cmdMakePaiment_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Image = global::Barette.Library.Properties.Resources.Cancel_2_icon;
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancel.Location = new Point(796, 460);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new Size(89, 41);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "Annuler ";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancel.Click += new EventHandler(this.cmdCancel_Click);
            // 
            // cmdApply
            // 
            this.cmdApply.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdApply.Image = global::Barette.Library.Properties.Resources.accept_icon;
            this.cmdApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdApply.Location = new Point(698, 460);
            this.cmdApply.Name = "cmdApply";
            this.cmdApply.Size = new Size(92, 41);
            this.cmdApply.TabIndex = 4;
            this.cmdApply.Text = "Appliquer";
            this.cmdApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdApply.Click += new EventHandler(this.cmdApply_Click);
            // 
            // label4
            // 
            this.label4.Location = new Point(809, 50);
            this.label4.Name = "label4";
            this.label4.Size = new Size(76, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "(incluant taxe)";
            // 
            // label6
            // 
            this.label6.Location = new Point(574, 435);
            this.label6.Name = "label6";
            this.label6.Size = new Size(48, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Solde :";
            // 
            // lblSolde
            // 
            this.lblSolde.ForeColor = System.Drawing.Color.Blue;
            this.lblSolde.Location = new Point(638, 435);
            this.lblSolde.Name = "lblSolde";
            this.lblSolde.Size = new Size(246, 16);
            this.lblSolde.TabIndex = 24;
            this.lblSolde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            this.printPreviewDialog1.ClientSize = new Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // cmdAddLocation
            // 
            this.cmdAddLocation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAddLocation.Location = new Point(662, 45);
            this.cmdAddLocation.Name = "cmdAddLocation";
            this.cmdAddLocation.Size = new Size(56, 23);
            this.cmdAddLocation.TabIndex = 25;
            this.cmdAddLocation.Text = "Location";
            this.cmdAddLocation.Click += new EventHandler(this.cmdAddLocation_Click);
            // 
            // toolBar1
            // 
            this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBar1.Buttons.AddRange(new ToolBarButton[] {
            this.tbbAddPaiment,
            this.tbbDelete,
            this.tbbSeparator1,
            this.tbbPrint});
            this.toolBar1.Divider = false;
            this.toolBar1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Location = new Point(8, 8);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new Size(252, 42);
            this.toolBar1.TabIndex = 26;
            this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.toolBar1.ButtonClick += new ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // tbbAddPaiment
            // 
            this.tbbAddPaiment.ImageIndex = 0;
            this.tbbAddPaiment.Name = "tbbAddPaiment";
            this.tbbAddPaiment.Tag = "ADD";
            this.tbbAddPaiment.Text = "Nouveau";
            this.tbbAddPaiment.ToolTipText = "Nouveau Paiment";
            // 
            // tbbDelete
            // 
            this.tbbDelete.Enabled = false;
            this.tbbDelete.ImageIndex = 1;
            this.tbbDelete.Name = "tbbDelete";
            this.tbbDelete.Tag = "DELETE";
            this.tbbDelete.Text = "Supprimer";
            this.tbbDelete.ToolTipText = "Effacer un Paiment";
            // 
            // tbbSeparator1
            // 
            this.tbbSeparator1.Name = "tbbSeparator1";
            this.tbbSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbPrint
            // 
            this.tbbPrint.Enabled = false;
            this.tbbPrint.ImageIndex = 3;
            this.tbbPrint.Name = "tbbPrint";
            this.tbbPrint.Tag = "PRINT";
            this.tbbPrint.ToolTipText = "Imprimer";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "new-page-icon.png");
            this.imageList1.Images.SetKeyName(1, "delete-icon.png");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            // 
            // timerSelection
            // 
            this.timerSelection.Enabled = true;
            this.timerSelection.Tick += new EventHandler(this.timerSelection_Tick);
            // 
            // timerAutuUpdate
            // 
            this.timerAutuUpdate.SynchronizingObject = this;
            this.timerAutuUpdate.Elapsed += new System.Timers.ElapsedEventHandler(this.timerAutuUpdate_Elapsed);
            // 
            // cbTotalCours
            // 
            this.cbTotalCours.Location = new Point(737, 48);
            this.cbTotalCours.Name = "cbTotalCours";
            this.cbTotalCours.Size = new Size(70, 20);
            this.cbTotalCours.TabIndex = 0;
            this.cbTotalCours.Text = "0 $";
            this.cbTotalCours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbTotalCours.TextChanged += new EventHandler(this.cbTotalCours_TextChanged);
            this.cbTotalCours.Leave += new EventHandler(this.cbTotalCours_Leave);
            // 
            // FormPaiment
            // 
            this.ClientSize = new Size(896, 510);
            this.Controls.Add(this.cmdAddLocation);
            this.Controls.Add(this.ListViewPaiment);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.lblSolde);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdApply);
            this.Controls.Add(this.gbPaiment);
            this.Controls.Add(this.cbTotalCours);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPaiment";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Détail de paiment";
            this.gbPaiment.ResumeLayout(false);
            this.gbPaiment.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerAutuUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void cmdCancel_Click(object sender, EventArgs e) {
			SaveNewRecuNumber(_RecuNumberWhenOpen);
            DialogResult = DialogResult.Cancel;
            Close(); //Ferme la boite de dialogue
		}

		/// <summary>
		/// Supprimer le paiment Selectioné
		/// </summary>
		private void DeletePaiment() {
			//Supprimer un paiment
			if (ListViewPaiment.SelectedItems.Count > 0)
				if (MessageBox.Show(this, "Voulez vous vraiment effacer ce paiment ?",
					"Gestion Auto Ecole 2010",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question) == DialogResult.Yes)
					ListViewPaiment.Items.RemoveAt(ListViewPaiment.SelectedItems[0].Index);

			ShowSolde();
		}

		private void cmdMakePaiment_Click(object sender, EventArgs e) {
			NumeroRecu.Focus();

			switch (_Mode) {
				case PaiementMode.Nouveau:
					AjouterPaiement();
					MakeNew();
					break;
				case PaiementMode.Modifier:
					ModifierPaiment();
					break;
			}

			AddCashSymbol();
		}

		/// <summary>
		/// Faire un calcule du solde avec les paiments effectué
		/// </summary>
		private double CalculSolde() {
			double MontantPayer = 0;

			for (int i = 0; i < ListViewPaiment.Items.Count; i++)
                if (ListViewPaiment.Items[i].SubItems[5].Text != "RL")
                    MontantPayer += Convert.ToDouble(ListViewPaiment.Items[i].SubItems[1].Text.Replace(" $", ""));

			double total = cbTotalCours.Value - MontantPayer;

			return total;
		}

		/// <summary>
		/// Modifier un paiment existant
		/// </summary>
		private void ModifierPaiment() {
			string type;
			string typePaiment = "";

			if (!NumeroRecuExistant(true) && MontantPaiment.Value != 0) {
				if (cbRetourLivre.Checked == true) {
					ListViewPaiment.Groups[0].Items.Add(ListViewPaiment.SelectedItems[0]);
					type = "RL";
				} else if (cbLocationAuto.Checked == true) {
					ListViewPaiment.Groups[1].Items.Add(ListViewPaiment.SelectedItems[0]);
					type = "LA";
				} else if (cbAbsence.Checked == true) {
					ListViewPaiment.Groups[3].Items.Add(ListViewPaiment.SelectedItems[0]);
					type = "ABS";
				} else if (MontantPaiment.Value < 0) {
					ListViewPaiment.Groups[4].Items.Add(ListViewPaiment.SelectedItems[0]);
					type = "";
				} else {
					ListViewPaiment.Groups[2].Items.Add(ListViewPaiment.SelectedItems[0]);
					type = "";
				}

				if (rbArgentComptant.Checked == true)
					typePaiment = "AC";
				else if (rbCheque.Checked == true)
					typePaiment = "CH";
				else if (rbPaimentDirect.Checked == true)
					typePaiment = "PD";
                else if (rbVISA.Checked == true)
                    typePaiment = "VISA";
                else if (rbMasterCard.Checked == true)
                    typePaiment = "MASTER";
                else {
					typePaiment = txtTypePaiment.Text;
				}

                //Creation de l'item et ajout dans les bonnes sections
                TaxeExtractor taxe = new TaxeExtractor();

                if (DateFacture.Value.Date.Year < 2011)
                    taxe = new TaxeExtractor(Convert.ToDecimal(MontantPaiment.Text.Replace(" $", "")), TaxeExtractor.Years.Y2008_to_2010);
                else if (DateFacture.Value.Date.Year == 2011)
                    taxe = new TaxeExtractor(Convert.ToDecimal(MontantPaiment.Text.Replace(" $", "")), TaxeExtractor.Years.Y2011);
                else if (DateFacture.Value.Date.Year >= 2012 && DateFacture.Value.Date.Year < 2014)
                    taxe = new TaxeExtractor(Convert.ToDecimal(MontantPaiment.Text.Replace(" $", "")), TaxeExtractor.Years.Y2012);
                else if (DateFacture.Value.Date.Year >= 2014)
                    taxe = new TaxeExtractor(Convert.ToDecimal(MontantPaiment.Text.Replace(" $", "")), TaxeExtractor.Years.Y2014);

                ListViewPaiment.SelectedItems[0].Text = DateFacture.Value.ToShortDateString();
				ListViewPaiment.SelectedItems[0].SubItems[1].Text = MontantPaiment.Text;
                ListViewPaiment.SelectedItems[0].SubItems[2].Text = taxe.Value.TPS.ToString() + " $" ;
                ListViewPaiment.SelectedItems[0].SubItems[3].Text = taxe.Value.TVQ.ToString() + " $";
				ListViewPaiment.SelectedItems[0].SubItems[4].Text = NumeroRecu.Text;
				ListViewPaiment.SelectedItems[0].SubItems[5].Text = type;
				ListViewPaiment.SelectedItems[0].SubItems[6].Text = typePaiment;

			} else {
				MessageBox.Show(this, "Ce numéro de reçu est déja présent dans votre liste de paiment et le montant doit être valide.", "Gestion Auto École",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}

			ShowSolde();
		}

		/// <summary>
		/// Affiche le Solde et l'arrondi a 2 decimal
		/// </summary>
		private void ShowSolde() {
			lblSolde.Text = Decimal.Round(Convert.ToDecimal(CalculSolde()), 2).ToString() + " $";
		}

		/// <summary>
		/// Ajouter un paiment à la viste
		/// </summary>
		private void AjouterPaiement() {
			string type;
			string typePaiment = "";

			if (!NumeroRecuExistant(false)) {
                if (MontantPaiment.Value != 0 && NumeroRecu.Text != "") {

                    if (cbRetourLivre.Checked == true)
                        type = "RL";
                    else if (cbLocationAuto.Checked == true)
                        type = "LA";
                    else if (cbAbsence.Checked == true)
                        type = "ABS";
                    else
                        type = "";

                    if (rbArgentComptant.Checked == true)
                        typePaiment = "AC";
                    else if (rbCheque.Checked == true)
                        typePaiment = "CH";
                    else if (rbPaimentDirect.Checked == true)
                        typePaiment = "PD";
                    else if (rbVISA.Checked == true)
                        typePaiment = "VISA";
                    else if (rbMasterCard.Checked == true)
                        typePaiment = "MASTER";
                    else {
                        typePaiment = txtTypePaiment.Text;
                    }

                    //Creation de l'item et ajout dans les bonnes sections
                    TaxeExtractor taxe = new TaxeExtractor();

                    if (DateFacture.Value.Date.Year < 2011)
                        taxe = new TaxeExtractor(Convert.ToDecimal(MontantPaiment.Text.Replace(" $", "")), TaxeExtractor.Years.Y2008_to_2010);
                    else if (DateFacture.Value.Date.Year == 2011)
                        taxe = new TaxeExtractor(Convert.ToDecimal(MontantPaiment.Text.Replace(" $", "")), TaxeExtractor.Years.Y2011);                    
                    else if (DateFacture.Value.Date.Year >= 2012 && DateFacture.Value.Date.Year < 2014)
                        taxe = new TaxeExtractor(Convert.ToDecimal(MontantPaiment.Text.Replace(" $", "")), TaxeExtractor.Years.Y2012);
                    else if (DateFacture.Value.Date.Year >= 2014)
                        taxe = new TaxeExtractor(Convert.ToDecimal(MontantPaiment.Text.Replace(" $", "")), TaxeExtractor.Years.Y2014);
                    ListViewItem itm = new ListViewItem
                    {
                        Text = DateFacture.Value.ToShortDateString(),
                        Tag = taxe.Value.NoTaxe
                    };
                    itm.SubItems.Add(MontantPaiment.Text);
                    itm.SubItems.Add(taxe.Value.TPS.ToString() + " $");
                    itm.SubItems.Add(taxe.Value.TVQ.ToString() + " $");
                    itm.SubItems.Add(NumeroRecu.Text);
                    itm.SubItems.Add(type);
                    itm.SubItems.Add(typePaiment);

                    if (type == "RL")
                        ListViewPaiment.Groups[0].Items.Add(itm);
                    else if (type == "LA")
                        ListViewPaiment.Groups[1].Items.Add(itm);
                    else if (type == "ABS")
                        ListViewPaiment.Groups[3].Items.Add(itm);
                    else if (MontantPaiment.Value < 0)
                        ListViewPaiment.Groups[4].Items.Add(itm);
                    else
                        ListViewPaiment.Groups[2].Items.Add(itm);

                    ListViewPaiment.Items.Add(itm);
                    ShowSolde();

                    SaveNewRecuNumber(GetRecuNumber() + 1);
                } else {
                    MessageBox.Show(this, "Veuillez inscrire le montant du paiement et le numéro de reçu.", "Gestion Auto École",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
			} else {
                MessageBox.Show(this, "Ce numéro de reçu est déja présent dans votre liste de paiment.", "Gestion Auto École",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
		}

		/// <summary>
		/// Retourne true si le numéro de recu est existant
        /// TODO : regardé dans tous les clients.....
		/// </summary>
		/// <returns></returns>
		private bool NumeroRecuExistant(bool CheckSelected) {
			int selectedIndex = 0;

			if (CheckSelected == true)
				selectedIndex = ListViewPaiment.SelectedItems[0].Index;

			for (int i = 0; i < ListViewPaiment.Items.Count; i++)
				if (selectedIndex != i && CheckSelected == true)
					if (NumeroRecu.Text == ListViewPaiment.Items[i].SubItems[2].Text)
						return true;

			//Rien trouver
			return false;
		}

		/// <summary>
		/// Ajout le Signe $
		/// </summary>
		private void AddCashSymbol() {
            foreach (ListViewItem item in ListViewPaiment.Items) {
                if (!item.SubItems[1].Text.EndsWith(" $"))
                    item.SubItems[1].Text += " $";

                if (!item.SubItems[2].Text.EndsWith(" $"))
                    item.SubItems[2].Text += " $";

                if (!item.SubItems[3].Text.EndsWith(" $"))
                    item.SubItems[3].Text += " $";
            }
		}

		/// <summary>
		/// Chargement de la liste de paiment
		/// </summary>
		private void LoadList() {
			Paiement paiment = null;
			string type;
			string typePaiment = "";

			cbTotalCours.Text = _ClientCtrl._MontantCours;

			for (int i = 0; i < _Client.Paiment.Count; i++) {
				paiment = _Client.Paiment[i];

				switch (paiment.Type) {
					case PaiementType.RetourLivre:
						type = "RL";
						break;
					case PaiementType.LocationAuto:
						type = "LA";
						break;
					case PaiementType.Absence:
						type = "ABS";
						break;
					default:
						type = "";
						break;
				}

				switch (paiment.TypePaiment) {
					case TypePaiment.ArgentComptant:
						typePaiment = "AC";
						break;
					case TypePaiment.Autre:
						typePaiment = paiment.PaimentAutre;
						break;
					case TypePaiment.Cheque:
						typePaiment = "CH";
						break;
                    case TypePaiment.VISA:
                        typePaiment = "VISA";
                        break;
                    case TypePaiment.MasterCard:
                        typePaiment = "MASTER";
                        break;
                    case TypePaiment.PaimentDirect:
						typePaiment = "PD";
						break;
					case TypePaiment.Nothing:
						typePaiment = "";
						break;
				}


				//Creation de l'item et ajout dans les bonnes sections
                TaxeExtractor taxe = new TaxeExtractor();

                if (paiment.DatePaiment.Date.Year < 2011)
                    taxe = new TaxeExtractor(Convert.ToDecimal(paiment.Montant.Replace(" $", "")), TaxeExtractor.Years.Y2008_to_2010);                
                else if (paiment.DatePaiment.Date.Year == 2011)
                    taxe = new TaxeExtractor(Convert.ToDecimal(paiment.Montant.Replace(" $", "")), TaxeExtractor.Years.Y2011);
                else if (DateFacture.Value.Date.Year >= 2012 && DateFacture.Value.Date.Year < 2014)
                    taxe = new TaxeExtractor(Convert.ToDecimal(paiment.Montant.Replace(" $", "")), TaxeExtractor.Years.Y2012);
                else if (DateFacture.Value.Date.Year >= 2014)
                    taxe = new TaxeExtractor(Convert.ToDecimal(paiment.Montant.Replace(" $", "")), TaxeExtractor.Years.Y2014);

                ListViewItem itm = new ListViewItem(new string[] { paiment.DatePaiment.ToShortDateString(),
                    paiment.Montant,
                    taxe.Value.TPS.ToString() + " $",
                    taxe.Value.TVQ.ToString() + " $",
                    paiment.NumeroRecu.ToString(),
                    type,
                    typePaiment})
                {
                    Tag = taxe.Value.NoTaxe
                };

                if (type == "RL")
					ListViewPaiment.Groups[0].Items.Add(itm);
				else if (type == "LA")
					ListViewPaiment.Groups[1].Items.Add(itm);
				else if (type == "ABS")
					ListViewPaiment.Groups[3].Items.Add(itm);
				else if (paiment.Value < 0)
					ListViewPaiment.Groups[4].Items.Add(itm);
				else
					ListViewPaiment.Groups[2].Items.Add(itm);

				ListViewPaiment.Items.Add(itm);
			}
			//Calcule le solde
			ShowSolde();
		}

		private void cbTotalCours_Leave(object sender, EventArgs e) {
			ShowSolde();
		}

		/// <summary>
		/// Ajout de paiment dans le client en cours
		/// </summary>
		private void cmdApply_Click(object sender, EventArgs e) {
            _ClientCtrl.CashBox_Solde.Text = lblSolde.Text;
            _ClientCtrl._MontantCours = cbTotalCours.Text;

			AddCashSymbol();

            _Client.Paiment.Clear();

			if (ListViewPaiment.Items.Count > 0) { //Si au moins 1 items
                _ClientCtrl.dbRecuNumber.Text = ListViewPaiment.Items[ListViewPaiment.Items.Count - 1].SubItems[4].Text;

				Paiement paiment = null;
				foreach (ListViewItem item in ListViewPaiment.Items) {
                    paiment = new Paiement
                    {
                        DatePaiment = DateTime.Parse(item.SubItems[0].Text),
                        Montant = item.SubItems[1].Text,
                        NumeroRecu = Convert.ToInt32(item.SubItems[4].Text)
                    };

                    switch (item.SubItems[5].Text) {
                        case "RL":
                            paiment.Type = PaiementType.RetourLivre;
                            break;
                        case "LA":
                            paiment.Type = PaiementType.LocationAuto;
                            break;
                        case "ABS":
                            paiment.Type = PaiementType.Absence;
                            break;
                        default:
                            paiment.Type = PaiementType.Nothing;
                            break;
                    }

					switch (item.SubItems[6].Text) {
						case "AC":
							paiment.TypePaiment = TypePaiment.ArgentComptant;
							break;
						case "CH":
							paiment.TypePaiment = TypePaiment.Cheque;
							break;
						case "PD":
							paiment.TypePaiment = TypePaiment.PaimentDirect;
							break;
						case "":
							paiment.TypePaiment = TypePaiment.Nothing;
							break;
                        case "VISA":
                            paiment.TypePaiment = TypePaiment.VISA;
                            break;
                        case "MASTER":
                            paiment.TypePaiment = TypePaiment.MasterCard;
                            break;
                        default:
							paiment.TypePaiment = TypePaiment.Autre;
							paiment.PaimentAutre = txtTypePaiment.Text;
							break;
					}

                    _Client.Paiment.Add(paiment);
				}
			}

            //Ferme la dialogbox
            DialogResult = DialogResult.OK;
            Close();
		}

		private void cbTotalCours_TextChanged(object sender, EventArgs e) {
			if (cbTotalCours.Value > 0)
				gbPaiment.Enabled = true;
			else
				gbPaiment.Enabled = false;
		}

		/// <summary>
		/// Selectionne un paiment dans la liste
		/// </summary>
		/// <param name="Number">Numéro du paiment a sélectionné</param>
		public void SelectPaiment(int Number) {
			for (int i = 0; i < ListViewPaiment.Items.Count; i++) {
				if (Number.ToString() == ListViewPaiment.Items[i].SubItems[2].Text) {
					ListViewPaiment.Items[i].Selected = true;
					break;
				}
			}			
		}


		/// <summary>
		/// Imprime la liste de paiment
		/// </summary>
		public void PrintListPaiment() {
            //Lance l'impression
            PrintDialog printConfig = new PrintDialog
            {
                PrinterSettings = printDocument1.PrinterSettings
            };

            AddCashSymbol();
#if DEBUG
            PrintPreviewDialog prev = new PrintPreviewDialog
            {
                Document = printDocument1
            };
            prev.ShowDialog();

#else
			if(printConfig.ShowDialog(this) == DialogResult.OK)	
					printDocument1.Print();			
#endif	
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
            #region Facrication des fonts
            Font printFont = new Font("Courier New", 11);
            Font printFontTime8 = new Font("Times New Roman", 8, FontStyle.Regular);
            Font printFontTime10 = new Font("Times New Roman", 10, FontStyle.Regular);
            Font printFontTime12 = new Font("Times New Roman", 12, FontStyle.Regular);
            Font printFontBold = new Font("Times New Roman", 12, FontStyle.Bold);
            Font printFontBold8 = new Font("Times New Roman", 8, FontStyle.Bold);
            Font printFontBold10 = new Font("Times New Roman", 10, FontStyle.Bold);
            Font printFontBold12 = new Font("Times New Roman", 12, FontStyle.Bold);
            Font printFontBold14 = new Font("Times New Roman", 14, FontStyle.Bold);
            Font printFontBold16 = new Font("Times New Roman", 16, FontStyle.Bold);
            Font printFontBold24 = new Font("Times New Roman", 24, FontStyle.Bold);
            Font printFontBoldItalic16 = new Font("Times New Roman", 16, FontStyle.Bold & FontStyle.Italic);
            #endregion

            #region variables
            float leftMargin = 0;
            string typePaiment = "";
            string type = "";
            float yPos = 0f;
            //float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);
            #endregion

            #region Header
            //Ecriture du header (image et texte)
            Stream strm = Type.GetType("Barette.Library.UserControls.Client.FormPaiment").Assembly.GetManifestResourceStream("Barette.Library.res.Printlogo.png");
            Bitmap img = new Bitmap(strm);
            e.Graphics.DrawImage(img, 0, 0, 180, 100);

            //Info Ecole et Adresse
            yPos = 5;
            e.Graphics.DrawString(_infoSchool.SchoolName, printFontTime10, Brushes.Black, 225, yPos, new StringFormat());
            yPos += printFontTime10.Height;
            e.Graphics.DrawString(_infoSchool.StreetNumber + " " + _infoSchool.StreetName, printFontTime10, Brushes.Black, 225, yPos, new StringFormat());
            yPos += printFontTime10.Height;
            e.Graphics.DrawString(_infoSchool.City + ", QC, " + _infoSchool.PostalCode, printFontTime10, Brushes.Black, 225, yPos, new StringFormat());
            yPos += printFontTime10.Height;
            e.Graphics.DrawString("Tel." + _infoSchool.Phone + "   Fax." + _infoSchool.Fax, printFontTime10, Brushes.Black, 225, yPos, new StringFormat());
            
            yPos += printFontBold14.Height + 20;
            e.Graphics.DrawString("Liste des paiments", printFontBold24, Brushes.Black, 225, yPos, new StringFormat());
            
			//Date d'impression
			yPos += printFontBold14.Height + 100;
			e.Graphics.DrawString("Imprimé le : " + DateTime.Now.ToShortDateString(), printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());

			yPos += printFont.Height + 16;
            e.Graphics.DrawString("Nom du client: " + _Client.Name + " " + _Client.FirstName, printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
			yPos += printFont.Height;
            e.Graphics.DrawString("Numéro de contrat: " + _Client.ContratNumber, printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            #endregion 

            #region Header du tableau de paiment
            yPos += printFont.Height + 35;
            //Date
			e.Graphics.DrawString("Date", printFontBold12, Brushes.Black, leftMargin, yPos, new StringFormat());
            //Numero recu
            e.Graphics.DrawString("Numéro", printFontBold12, Brushes.Black, leftMargin + 90, yPos, new StringFormat());
            e.Graphics.DrawString("de reçu", printFontBold12, Brushes.Black, leftMargin + 90, yPos + printFontBold12.Height, new StringFormat());
            //montant avant taxe
            e.Graphics.DrawString("Sous-Total", printFontBold12, Brushes.Black, leftMargin + 175, yPos, new StringFormat());
            //montant TPS
            e.Graphics.DrawString("TPS", printFontBold12, Brushes.Black, leftMargin + 275, yPos, new StringFormat());
            //montant TVQ
            e.Graphics.DrawString("TVQ", printFontBold12, Brushes.Black, leftMargin + 335, yPos, new StringFormat());
            //total taxe inclut
            e.Graphics.DrawString("Total", printFontBold12, Brushes.Black, leftMargin + 400, yPos, new StringFormat());
            //Type
            e.Graphics.DrawString("Type", printFontBold12, Brushes.Black, leftMargin + 480, yPos, new StringFormat());
            //Type de paiment
            e.Graphics.DrawString("Type de", printFontBold12, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
            e.Graphics.DrawString("Paiment", printFontBold12, Brushes.Black, leftMargin + 590, yPos + printFontBold12.Height, new StringFormat());
            #endregion

            yPos += printFont.Height + 30;
			for (int i = 0; i < ListViewPaiment.Items.Count; i++) {
                //Date
                e.Graphics.DrawString(ListViewPaiment.Items[i].Text, printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
                //Numero de recu
                e.Graphics.DrawString(ListViewPaiment.Items[i].SubItems[4].Text, printFontTime10, Brushes.Black, leftMargin + 90, yPos, new StringFormat());
                //montant avant taxe
                e.Graphics.DrawString(ListViewPaiment.Items[i].Tag.ToString() + " $", printFontTime10, Brushes.Black, leftMargin + 175, yPos, new StringFormat());
                //TPS
                e.Graphics.DrawString(ListViewPaiment.Items[i].SubItems[2].Text, printFontTime10, Brushes.Black, leftMargin + 275, yPos, new StringFormat());
                //TVQ
                e.Graphics.DrawString(ListViewPaiment.Items[i].SubItems[3].Text, printFontTime10, Brushes.Black, leftMargin + 335, yPos, new StringFormat());
                //Total
                e.Graphics.DrawString(ListViewPaiment.Items[i].SubItems[1].Text, printFontTime10, Brushes.Black, leftMargin + 400, yPos, new StringFormat());
                //montant avant taxe
                
                //Type de paiment
				switch (ListViewPaiment.Items[i].SubItems[6].Text) {
					case "AC":
						typePaiment = "Argent Comptant";
						break;
					case "CH":
						typePaiment = "Chèque";
						break;
					case "PD":
						typePaiment = "Paiment Direct";
						break;
                    case "VISA":
                        typePaiment = "VISA";
                        break;
                    case "MASTER":
                        typePaiment = "MasterCard";
                        break;
                    case "":
						typePaiment = "";
						break;
					default:
						typePaiment = ListViewPaiment.Items[i].SubItems[6].Text;
						break;
				}
                e.Graphics.DrawString(typePaiment, printFontTime10, Brushes.Black, leftMargin + 590, yPos, new StringFormat());

                //Type
                switch (ListViewPaiment.Items[i].SubItems[5].Text) {
                    case "RL":
                        type = "Livres";
                        break;
                    case "LA":
                        type = "Location";
                        break;
                    case "ABS":
                        type = "Absence";
                        break;
                    default:
                        type = "";
                        break;
                }
                e.Graphics.DrawString(type, printFontTime10, Brushes.Black, leftMargin + 480, yPos, new StringFormat());

				yPos += printFont.Height;
			}

			yPos += printFont.Height;
            e.Graphics.DrawString("Solde : " + lblSolde.Text, printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());

			yPos += (printFont.Height * 2);
            e.Graphics.DrawString("TPS : " + _infoSchool.TPS, printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            yPos += (printFont.Height);
            e.Graphics.DrawString("TVQ : " + _infoSchool.TVQ, printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());

			yPos += 40;
            e.Graphics.DrawString("Signature du client", printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            e.Graphics.DrawString("___________________________________", printFontTime10, Brushes.Black, leftMargin + 150, yPos, new StringFormat());
			yPos += 35;
            e.Graphics.DrawString("Signature du commercant", printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            e.Graphics.DrawString("___________________________________", printFontTime10, Brushes.Black, leftMargin + 150, yPos, new StringFormat());
		}

		private void ListViewPaiment_SelectedIndexChanged(object sender, EventArgs e) {
			try {
                _Mode = PaiementMode.Modifier;
				cmdMakePaiment.Text = "Modifier";
                cmdMakePaiment.Image = global::Barette.Library.Properties.Resources.accept_icon;

				DateFacture.Value = Convert.ToDateTime(ListViewPaiment.SelectedItems[0].Text);
				MontantPaiment.Text = ListViewPaiment.SelectedItems[0].SubItems[1].Text.Replace(" $", "");
				NumeroRecu.Text = ListViewPaiment.SelectedItems[0].SubItems[4].Text;

				if (ListViewPaiment.SelectedItems[0].SubItems[5].Text == "RL")
					cbRetourLivre.Checked = true;
				else
					cbRetourLivre.Checked = false;

				switch (ListViewPaiment.SelectedItems[0].SubItems[6].Text) {
					case "AC":
						rbArgentComptant.Checked = true;
						break;
					case "CH":
						rbCheque.Checked = true;
						break;
					case "PD":
						rbPaimentDirect.Checked = true;
						break;
                    case "MASTER":
                        rbMasterCard.Checked = true;
                        break;
                    case "VISA":
                        rbVISA.Checked = true;
                        break;
                    case "":
						rbPaimentDirect.Checked = false;
						rbAutre.Checked = false;
						rbArgentComptant.Checked = false;
						rbCheque.Checked = false;
						break;
					default:
						rbAutre.Checked = true;
						txtTypePaiment.Text = ListViewPaiment.Items[0].SubItems[6].Text;
						break;
				}

				switch (ListViewPaiment.SelectedItems[0].SubItems[5].Text) {
					case "RL":
						cbRetourLivre.Checked = true;
						break;
					case "LA":
						cbLocationAuto.Checked = true;
						break;
					case "ABS":
						cbAbsence.Checked = true;
						break;
				}

			} catch {
				MakeNew();
			}
		}

		/// <summary>
		/// Créé un nouveau paiment vierge
		/// </summary>
		private void MakeNew() {
            _Mode = PaiementMode.Nouveau;
            MontantPaiment.Text = "";
            NumeroRecu.Text = GetRecuNumber().ToString();
            DateFacture.Value = DateTime.Now;
            cbRetourLivre.Checked = cbAbsence.Checked = cbLocationAuto.Checked = false;
            rbArgentComptant.Checked = true;
            cmdMakePaiment.Text = "Effectuer un paiment";
            cmdMakePaiment.Image = global::Barette.Library.Properties.Resources.add_icon;
			MontantPaiment.Focus();
		}

		#region Numéro de reçu Automatique
		/// <summary>
		/// Obtenir le numéro de recu
		/// </summary>		
		private long GetRecuNumber() {
			if (File.Exists(@"Data\recunumber.xml")) {
				//Creation du reader
				XmlDocument doc = new XmlDocument();
				XmlTextReader reader = new XmlTextReader(@"Data\recunumber.xml");

				//Lecture du document
				doc.Load(reader);

				long recuNumber = Convert.ToInt32(doc.ChildNodes.Item(0).Attributes["CurrentAutomatiqueNumber"].Value);

				reader.Close();

				//Lecture du dernier
				return recuNumber;
			}

			return 0;
		}

		private void SaveNewRecuNumber(long Number) {
            XmlTextWriter myWriter = new XmlTextWriter(@"Data\recunumber.xml", Encoding.Unicode)
            {
                Formatting = Formatting.Indented
            };

            //Ecriture du fichier
            myWriter.WriteStartElement("ECBRecuNumber");
			myWriter.WriteAttributeString("CurrentAutomatiqueNumber", Number.ToString());

			//Fermeture du tag
			myWriter.WriteEndElement();

			//Fermeture du fichier
			myWriter.Close();
		}
		#endregion

		private void cmdAddLocation_Click(object sender, EventArgs e) {
			if (MessageBox.Show(this, "Voulez vous vraiment ajouter le montant de " + _ClientCtrl.Client.MontantLocation.ToString() + " à votre montant global ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
				cbTotalCours.Add(Convert.ToDouble(_ClientCtrl.Client.MontantLocation.Replace(" $", "")));
			}
		}

		private void ListViewPaiment_ColumnClick(object sender, ColumnClickEventArgs e) {
            ListViewPaiment.ListViewItemSorter = new ListViewItemComparer(e.Column);

			ListViewPaiment.Sort();
		}

		private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e) {
			switch (e.Button.Tag.ToString()) {
				case "DELETE":
					DeletePaiment();
					break;
				case "PRINT":
					PrintListPaiment();
					break;
				case "ADD":
					MakeNew();
					AddCashSymbol();
					break;
			}
		}

		private void timerSelection_Tick(object sender, EventArgs e) {
			if (ListViewPaiment.SelectedItems.Count > 0)
				tbbDelete.Enabled = true;
			else
				tbbDelete.Enabled = false;

			if (ListViewPaiment.Items.Count > 0)
				tbbPrint.Enabled = true;
			else
				tbbPrint.Enabled = false;
		}

		private void timerAutuUpdate_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {
			if (_Mode == PaiementMode.Modifier)
				ModifierPaiment();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			cbAbsence.Checked = cbLocationAuto.Checked = cbRetourLivre.Checked = false;
		}

    }
}
