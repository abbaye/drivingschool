using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Text;

using Barette.Library.UserControls;
using Barette.Library.Client;
using Barette.Library.Listview;

namespace Barette.Library.UserControls.Client {
	/// <summary>
	/// Description résumée de FormPaiment.
	/// </summary>
	public class FormPaiment : System.Windows.Forms.Form {
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ColumnHeader colHeadDate;
		private System.Windows.Forms.ColumnHeader colHeadMontant;
		private System.Windows.Forms.ColumnHeader colHeadRecuNumber;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblSolde;
		private System.Windows.Forms.DateTimePicker DateFacture;
		private System.Windows.Forms.ListView ListViewPaiment;
		private System.Windows.Forms.Button cmdMakePaiment;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.GroupBox gbPaiment;

		//Control Client référancé
		private ClientControl _ClientCtrl = null;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;

		private Customer _Client = null;
        private SchoolInfo _infoSchool = null;

		private PaiementMode _Mode = PaiementMode.Nouveau;
		private System.Windows.Forms.Button cmdAddLocation;
		private System.Windows.Forms.ColumnHeader colHeadRL;
		private System.Windows.Forms.Button cmdApply;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton tbbAddPaiment;
		private System.Windows.Forms.ToolBarButton tbbDelete;
		private System.Windows.Forms.ToolBarButton tbbSeparator1;
		private System.Windows.Forms.ToolBarButton tbbPrint;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Timer timerSelection;
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
		private long _RecuNumberWhenOpen = 0;

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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Livres", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Location Automobile", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Paiements Normaux", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Absense", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Credit", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaiment));
            ListViewPaiment = new System.Windows.Forms.ListView();
            colHeadDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colHeadMontant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colHeadRecuNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colHeadRL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colHeadTypePaiment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colHeadTPS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            colHeadTVQ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            label1 = new System.Windows.Forms.Label();
            gbPaiment = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            cbAbsence = new System.Windows.Forms.RadioButton();
            cbLocationAuto = new System.Windows.Forms.RadioButton();
            cbRetourLivre = new System.Windows.Forms.RadioButton();
            button1 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtTypePaiment = new System.Windows.Forms.TextBox();
            rbAutre = new System.Windows.Forms.RadioButton();
            rbArgentComptant = new System.Windows.Forms.RadioButton();
            rbPaimentDirect = new System.Windows.Forms.RadioButton();
            rbCheque = new System.Windows.Forms.RadioButton();
            NumeroRecu = new UtilityLibrary.WinControls.NumericTextBox();
            label3 = new System.Windows.Forms.Label();
            DateFacture = new System.Windows.Forms.DateTimePicker();
            label15 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cmdMakePaiment = new System.Windows.Forms.Button();
            cmdCancel = new System.Windows.Forms.Button();
            cmdApply = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            lblSolde = new System.Windows.Forms.Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            cmdAddLocation = new System.Windows.Forms.Button();
            toolBar1 = new System.Windows.Forms.ToolBar();
            tbbAddPaiment = new System.Windows.Forms.ToolBarButton();
            tbbDelete = new System.Windows.Forms.ToolBarButton();
            tbbSeparator1 = new System.Windows.Forms.ToolBarButton();
            tbbPrint = new System.Windows.Forms.ToolBarButton();
            imageList1 = new System.Windows.Forms.ImageList(components);
            timerSelection = new System.Windows.Forms.Timer(components);
            timerAutuUpdate = new System.Timers.Timer();
            MontantPaiment = new Barette.Library.UserControls.CashTextBox();
            cbTotalCours = new Barette.Library.UserControls.CashTextBox();
            gbPaiment.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(timerAutuUpdate)).BeginInit();
            SuspendLayout();
            // 
            // ListViewPaiment
            // 
            ListViewPaiment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            ListViewPaiment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            colHeadDate,
            colHeadMontant,
            colHeadTPS,
            colHeadTVQ,
            colHeadRecuNumber,
            colHeadRL,
            colHeadTypePaiment});
            ListViewPaiment.FullRowSelect = true;
            listViewGroup1.Header = "Livres";
            listViewGroup1.Name = "RetourLivre";
            listViewGroup2.Header = "Location Automobile";
            listViewGroup2.Name = "LocationAuto";
            listViewGroup3.Header = "Paiements Normaux";
            listViewGroup3.Name = "General";
            listViewGroup4.Header = "Absense";
            listViewGroup4.Name = "Absense";
            listViewGroup5.Header = "Credit";
            listViewGroup5.Name = "Credit";
            ListViewPaiment.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
            ListViewPaiment.HideSelection = false;
            ListViewPaiment.LabelWrap = false;
            ListViewPaiment.Location = new System.Drawing.Point(8, 48);
            ListViewPaiment.MultiSelect = false;
            ListViewPaiment.Name = "ListViewPaiment";
            ListViewPaiment.Size = new System.Drawing.Size(555, 361);
            ListViewPaiment.TabIndex = 0;
            ListViewPaiment.TabStop = false;
            ListViewPaiment.UseCompatibleStateImageBehavior = false;
            ListViewPaiment.View = System.Windows.Forms.View.Details;
            ListViewPaiment.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(ListViewPaiment_ColumnClick);
            ListViewPaiment.SelectedIndexChanged += new System.EventHandler(ListViewPaiment_SelectedIndexChanged);
            // 
            // colHeadDate
            // 
            colHeadDate.Text = "Date";
            colHeadDate.Width = 84;
            // 
            // colHeadMontant
            // 
            colHeadMontant.Text = "Montant (tx inc)";
            colHeadMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            colHeadMontant.Width = 90;
            // 
            // colHeadRecuNumber
            // 
            colHeadRecuNumber.Text = "Numéro de reçu";
            colHeadRecuNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            colHeadRecuNumber.Width = 96;
            // 
            // colHeadRL
            // 
            colHeadRL.Text = "Type";
            colHeadRL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            colHeadRL.Width = 56;
            // 
            // colHeadTypePaiment
            // 
            colHeadTypePaiment.Text = "Type Paiment";
            colHeadTypePaiment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            colHeadTypePaiment.Width = 79;
            // 
            // colHeadTPS
            // 
            colHeadTPS.Text = "TPS";
            colHeadTPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colHeadTVQ
            // 
            colHeadTVQ.Text = "TVQ";
            colHeadTVQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(574, 48);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(160, 20);
            label1.TabIndex = 2;
            label1.Text = "Montant (Cours +                     )";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbPaiment
            // 
            gbPaiment.Controls.Add(groupBox2);
            gbPaiment.Controls.Add(groupBox1);
            gbPaiment.Controls.Add(NumeroRecu);
            gbPaiment.Controls.Add(label3);
            gbPaiment.Controls.Add(DateFacture);
            gbPaiment.Controls.Add(label15);
            gbPaiment.Controls.Add(MontantPaiment);
            gbPaiment.Controls.Add(label2);
            gbPaiment.Controls.Add(cmdMakePaiment);
            gbPaiment.Enabled = false;
            gbPaiment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            gbPaiment.Location = new System.Drawing.Point(574, 75);
            gbPaiment.Name = "gbPaiment";
            gbPaiment.Size = new System.Drawing.Size(312, 292);
            gbPaiment.TabIndex = 1;
            gbPaiment.TabStop = false;
            gbPaiment.Text = "Information sur le paiment";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            groupBox2.Controls.Add(cbAbsence);
            groupBox2.Controls.Add(cbLocationAuto);
            groupBox2.Controls.Add(cbRetourLivre);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new System.Drawing.Point(167, 115);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(133, 124);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Type";
            // 
            // cbAbsence
            // 
            cbAbsence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            cbAbsence.AutoSize = true;
            cbAbsence.Location = new System.Drawing.Point(7, 68);
            cbAbsence.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            cbAbsence.Name = "cbAbsence";
            cbAbsence.Size = new System.Drawing.Size(67, 17);
            cbAbsence.TabIndex = 31;
            cbAbsence.Text = "Absence";
            // 
            // cbLocationAuto
            // 
            cbLocationAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            cbLocationAuto.AutoSize = true;
            cbLocationAuto.Location = new System.Drawing.Point(7, 44);
            cbLocationAuto.Name = "cbLocationAuto";
            cbLocationAuto.Size = new System.Drawing.Size(66, 17);
            cbLocationAuto.TabIndex = 30;
            cbLocationAuto.Text = "Location";
            // 
            // cbRetourLivre
            // 
            cbRetourLivre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            cbRetourLivre.AutoSize = true;
            cbRetourLivre.Location = new System.Drawing.Point(7, 19);
            cbRetourLivre.Name = "cbRetourLivre";
            cbRetourLivre.Size = new System.Drawing.Size(53, 17);
            cbRetourLivre.TabIndex = 29;
            cbRetourLivre.Text = "Livres";
            // 
            // button1
            // 
            button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            button1.Location = new System.Drawing.Point(52, 92);
            button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 28;
            button1.Text = "Aucun";
            button1.Click += new System.EventHandler(button1_Click);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTypePaiment);
            groupBox1.Controls.Add(rbAutre);
            groupBox1.Controls.Add(rbArgentComptant);
            groupBox1.Controls.Add(rbPaimentDirect);
            groupBox1.Controls.Add(rbCheque);
            groupBox1.Location = new System.Drawing.Point(7, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(153, 124);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Type de Paiment";
            // 
            // txtTypePaiment
            // 
            txtTypePaiment.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            txtTypePaiment.Location = new System.Drawing.Point(73, 95);
            txtTypePaiment.MaxLength = 8;
            txtTypePaiment.Name = "txtTypePaiment";
            txtTypePaiment.Size = new System.Drawing.Size(71, 20);
            txtTypePaiment.TabIndex = 4;
            // 
            // rbAutre
            // 
            rbAutre.AutoSize = true;
            rbAutre.Location = new System.Drawing.Point(7, 96);
            rbAutre.Name = "rbAutre";
            rbAutre.Size = new System.Drawing.Size(56, 17);
            rbAutre.TabIndex = 3;
            rbAutre.Text = "Autre :";
            // 
            // rbArgentComptant
            // 
            rbArgentComptant.AutoSize = true;
            rbArgentComptant.Location = new System.Drawing.Point(7, 72);
            rbArgentComptant.Name = "rbArgentComptant";
            rbArgentComptant.Size = new System.Drawing.Size(103, 17);
            rbArgentComptant.TabIndex = 2;
            rbArgentComptant.Text = "Argent comptant";
            // 
            // rbPaimentDirect
            // 
            rbPaimentDirect.AutoSize = true;
            rbPaimentDirect.Location = new System.Drawing.Point(7, 48);
            rbPaimentDirect.Name = "rbPaimentDirect";
            rbPaimentDirect.Size = new System.Drawing.Size(94, 17);
            rbPaimentDirect.TabIndex = 1;
            rbPaimentDirect.Text = "Paiment Direct";
            // 
            // rbCheque
            // 
            rbCheque.AutoSize = true;
            rbCheque.Location = new System.Drawing.Point(7, 24);
            rbCheque.Name = "rbCheque";
            rbCheque.Size = new System.Drawing.Size(62, 17);
            rbCheque.TabIndex = 0;
            rbCheque.Text = "Chèque";
            // 
            // NumeroRecu
            // 
            NumeroRecu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            NumeroRecu.Location = new System.Drawing.Point(144, 88);
            NumeroRecu.Name = "NumeroRecu";
            NumeroRecu.SetRange = new System.Drawing.Size(0, 99999999);
            NumeroRecu.ShortcutsEnabled = false;
            NumeroRecu.Size = new System.Drawing.Size(89, 20);
            NumeroRecu.TabIndex = 25;
            NumeroRecu.Text = "0";
            NumeroRecu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            NumeroRecu.Value = 0;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(7, 24);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(100, 20);
            label3.TabIndex = 23;
            label3.Text = "Date :";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateFacture
            // 
            DateFacture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            DateFacture.Location = new System.Drawing.Point(144, 24);
            DateFacture.Name = "DateFacture";
            DateFacture.Size = new System.Drawing.Size(160, 20);
            DateFacture.TabIndex = 0;
            // 
            // label15
            // 
            label15.Location = new System.Drawing.Point(7, 88);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(120, 16);
            label15.TabIndex = 20;
            label15.Text = "Numéro de reçu :";
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(7, 56);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(120, 20);
            label2.TabIndex = 18;
            label2.Text = "Montant du paiment :";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdMakePaiment
            // 
            cmdMakePaiment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            cmdMakePaiment.Image = global::Barette.Library.Properties.Resources.add_icon;
            cmdMakePaiment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cmdMakePaiment.Location = new System.Drawing.Point(155, 246);
            cmdMakePaiment.Name = "cmdMakePaiment";
            cmdMakePaiment.Size = new System.Drawing.Size(151, 40);
            cmdMakePaiment.TabIndex = 4;
            cmdMakePaiment.Text = "Effectuer un paiment";
            cmdMakePaiment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cmdMakePaiment.Click += new System.EventHandler(cmdMakePaiment_Click);
            // 
            // cmdCancel
            // 
            cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cmdCancel.Image = global::Barette.Library.Properties.Resources.Cancel_2_icon;
            cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cmdCancel.Location = new System.Drawing.Point(796, 418);
            cmdCancel.Name = "cmdCancel";
            cmdCancel.Size = new System.Drawing.Size(89, 41);
            cmdCancel.TabIndex = 5;
            cmdCancel.Text = "Annuler ";
            cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cmdCancel.Click += new System.EventHandler(cmdCancel_Click);
            // 
            // cmdApply
            // 
            cmdApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            cmdApply.Image = global::Barette.Library.Properties.Resources.accept_icon;
            cmdApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cmdApply.Location = new System.Drawing.Point(698, 418);
            cmdApply.Name = "cmdApply";
            cmdApply.Size = new System.Drawing.Size(92, 41);
            cmdApply.TabIndex = 4;
            cmdApply.Text = "Appliquer";
            cmdApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cmdApply.Click += new System.EventHandler(cmdApply_Click);
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(809, 50);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(76, 16);
            label4.TabIndex = 22;
            label4.Text = "(incluant taxe)";
            // 
            // label6
            // 
            label6.Location = new System.Drawing.Point(576, 379);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(48, 16);
            label6.TabIndex = 23;
            label6.Text = "Solde :";
            // 
            // lblSolde
            // 
            lblSolde.ForeColor = System.Drawing.Color.Blue;
            lblSolde.Location = new System.Drawing.Point(640, 379);
            lblSolde.Name = "lblSolde";
            lblSolde.Size = new System.Drawing.Size(246, 16);
            lblSolde.TabIndex = 24;
            lblSolde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // cmdAddLocation
            // 
            cmdAddLocation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAddLocation.Location = new System.Drawing.Point(662, 45);
            cmdAddLocation.Name = "cmdAddLocation";
            cmdAddLocation.Size = new System.Drawing.Size(56, 23);
            cmdAddLocation.TabIndex = 25;
            cmdAddLocation.Text = "Location";
            cmdAddLocation.Click += new System.EventHandler(cmdAddLocation_Click);
            // 
            // toolBar1
            // 
            toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            tbbAddPaiment,
            tbbDelete,
            tbbSeparator1,
            tbbPrint});
            toolBar1.Divider = false;
            toolBar1.Dock = System.Windows.Forms.DockStyle.None;
            toolBar1.DropDownArrows = true;
            toolBar1.ImageList = imageList1;
            toolBar1.Location = new System.Drawing.Point(8, 8);
            toolBar1.Name = "toolBar1";
            toolBar1.ShowToolTips = true;
            toolBar1.Size = new System.Drawing.Size(252, 42);
            toolBar1.TabIndex = 26;
            toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(toolBar1_ButtonClick);
            // 
            // tbbAddPaiment
            // 
            tbbAddPaiment.ImageIndex = 0;
            tbbAddPaiment.Name = "tbbAddPaiment";
            tbbAddPaiment.Tag = "ADD";
            tbbAddPaiment.Text = "Nouveau";
            tbbAddPaiment.ToolTipText = "Nouveau Paiment";
            // 
            // tbbDelete
            // 
            tbbDelete.Enabled = false;
            tbbDelete.ImageIndex = 1;
            tbbDelete.Name = "tbbDelete";
            tbbDelete.Tag = "DELETE";
            tbbDelete.Text = "Supprimer";
            tbbDelete.ToolTipText = "Effacer un Paiment";
            // 
            // tbbSeparator1
            // 
            tbbSeparator1.Name = "tbbSeparator1";
            tbbSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbPrint
            // 
            tbbPrint.Enabled = false;
            tbbPrint.ImageIndex = 3;
            tbbPrint.Name = "tbbPrint";
            tbbPrint.Tag = "PRINT";
            tbbPrint.ToolTipText = "Imprimer";
            // 
            // imageList1
            // 
            imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "new-page-icon.png");
            imageList1.Images.SetKeyName(1, "delete-icon.png");
            imageList1.Images.SetKeyName(2, "");
            imageList1.Images.SetKeyName(3, "");
            imageList1.Images.SetKeyName(4, "");
            // 
            // timerSelection
            // 
            timerSelection.Enabled = true;
            timerSelection.Tick += new System.EventHandler(timerSelection_Tick);
            // 
            // timerAutuUpdate
            // 
            timerAutuUpdate.SynchronizingObject = this;
            timerAutuUpdate.Elapsed += new System.Timers.ElapsedEventHandler(timerAutuUpdate_Elapsed);
            // 
            // MontantPaiment
            // 
            MontantPaiment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            MontantPaiment.Location = new System.Drawing.Point(145, 56);
            MontantPaiment.Name = "MontantPaiment";
            MontantPaiment.Size = new System.Drawing.Size(88, 20);
            MontantPaiment.TabIndex = 1;
            MontantPaiment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbTotalCours
            // 
            cbTotalCours.Location = new System.Drawing.Point(737, 48);
            cbTotalCours.Name = "cbTotalCours";
            cbTotalCours.Size = new System.Drawing.Size(70, 20);
            cbTotalCours.TabIndex = 0;
            cbTotalCours.Text = "0 $";
            cbTotalCours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            cbTotalCours.TextChanged += new System.EventHandler(cbTotalCours_TextChanged);
            cbTotalCours.Leave += new System.EventHandler(cbTotalCours_Leave);
            // 
            // FormPaiment
            // 
            ClientSize = new System.Drawing.Size(896, 468);
            Controls.Add(cmdAddLocation);
            Controls.Add(ListViewPaiment);
            Controls.Add(toolBar1);
            Controls.Add(lblSolde);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(cmdCancel);
            Controls.Add(cmdApply);
            Controls.Add(gbPaiment);
            Controls.Add(cbTotalCours);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPaiment";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Détail de paiment";
            gbPaiment.ResumeLayout(false);
            gbPaiment.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(timerAutuUpdate)).EndInit();
            ResumeLayout(false);
            PerformLayout();

		}
		#endregion

		private void cmdCancel_Click(object sender, System.EventArgs e) {
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

		private void cmdMakePaiment_Click(object sender, System.EventArgs e) {
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
				else {
					typePaiment = txtTypePaiment.Text;
				}

                //Creation de l'item et ajout dans les bonnes sections
                TaxeExtractor taxe = new TaxeExtractor();

                if (DateFacture.Value.Date.Year < 2011)
                    taxe = new TaxeExtractor(Convert.ToDecimal(MontantPaiment.Text.Replace(" $", "")), TaxeExtractor.Years.Y2008_to_2010);
                else if (DateFacture.Value.Date.Year == 2011)
                    taxe = new TaxeExtractor(Convert.ToDecimal(MontantPaiment.Text.Replace(" $", "")), TaxeExtractor.Years.Y2011);
                else if (DateFacture.Value.Date.Year >= 2012)
                    taxe = new TaxeExtractor(Convert.ToDecimal(MontantPaiment.Text.Replace(" $", "")), TaxeExtractor.Years.Y2012);
                                
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
                    else {
                        typePaiment = txtTypePaiment.Text;
                    }

                    //Creation de l'item et ajout dans les bonnes sections
                    TaxeExtractor taxe = new TaxeExtractor();

                    if (DateFacture.Value.Date.Year < 2011)
                        taxe = new TaxeExtractor(Convert.ToDecimal(MontantPaiment.Text.Replace(" $", "")), TaxeExtractor.Years.Y2008_to_2010);
                    else if (DateFacture.Value.Date.Year == 2011)
                        taxe = new TaxeExtractor(Convert.ToDecimal(MontantPaiment.Text.Replace(" $", "")), TaxeExtractor.Years.Y2011);
                    else if (DateFacture.Value.Date.Year >= 2012)
                        taxe = new TaxeExtractor(Convert.ToDecimal(MontantPaiment.Text.Replace(" $", "")), TaxeExtractor.Years.Y2012);

                    ListViewItem itm = new ListViewItem();
                    itm.Text = DateFacture.Value.ToShortDateString();
                    itm.Tag = taxe.Value.NoTaxe;
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
                else if (paiment.DatePaiment.Date.Year >= 2012)
                    taxe = new TaxeExtractor(Convert.ToDecimal(paiment.Montant.Replace(" $", "")), TaxeExtractor.Years.Y2012);

                ListViewItem itm = new ListViewItem(new string[] { paiment.DatePaiment.ToShortDateString(), 
                    paiment.Montant, 
                    taxe.Value.TPS.ToString() + " $", 
                    taxe.Value.TVQ.ToString() + " $", 
                    paiment.NumeroRecu.ToString(),
                    type,
                    typePaiment});

                itm.Tag = taxe.Value.NoTaxe;
				
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

		private void cbTotalCours_Leave(object sender, System.EventArgs e) {
			ShowSolde();
		}

		/// <summary>
		/// Ajout de paiment dans le client en cours
		/// </summary>
		private void cmdApply_Click(object sender, System.EventArgs e) {
            _ClientCtrl.CashBox_Solde.Text = lblSolde.Text;
            _ClientCtrl._MontantCours = cbTotalCours.Text;

			AddCashSymbol();

            _Client.Paiment.Clear();

			if (ListViewPaiment.Items.Count > 0) { //Si au moins 1 items
                _ClientCtrl.dbRecuNumber.Text = ListViewPaiment.Items[ListViewPaiment.Items.Count - 1].SubItems[4].Text;

				Paiement paiment = null;
				foreach (ListViewItem item in ListViewPaiment.Items) {
					paiment = new Paiement();
					paiment.DatePaiment = DateTime.Parse(item.SubItems[0].Text);
					paiment.Montant = item.SubItems[1].Text;
					paiment.NumeroRecu = Convert.ToInt16(item.SubItems[4].Text);

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

		private void cbTotalCours_TextChanged(object sender, System.EventArgs e) {
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
			PrintDialog printConfig = new PrintDialog();

			printConfig.PrinterSettings = printDocument1.PrinterSettings;

			AddCashSymbol();
#if DEBUG
			PrintPreviewDialog prev = new PrintPreviewDialog();
			prev.Document = printDocument1;
			prev.ShowDialog();

#else
			if(printConfig.ShowDialog(this) == DialogResult.OK)	
					printDocument1.Print();			
#endif	
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
            #region Facrication des fonts
            Font printFont = new System.Drawing.Font("Courier New", 11);
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

		private void ListViewPaiment_SelectedIndexChanged(object sender, System.EventArgs e) {
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
					case "":
						rbPaimentDirect.Checked = false;
						rbAutre.Checked = false;
						rbArgentComptant.Checked = false;
						rbCheque.Checked = false;
						break;
					default:
						rbAutre.Checked = true;
						txtTypePaiment.Text = ListViewPaiment.Items[0].SubItems[4].Text;
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
			XmlTextWriter myWriter = new XmlTextWriter(@"Data\recunumber.xml", Encoding.Unicode);
			myWriter.Formatting = Formatting.Indented;

			//Ecriture du fichier
			myWriter.WriteStartElement("ECBRecuNumber");
			myWriter.WriteAttributeString("CurrentAutomatiqueNumber", Number.ToString());

			//Fermeture du tag
			myWriter.WriteEndElement();

			//Fermeture du fichier
			myWriter.Close();
		}
		#endregion

		private void cmdAddLocation_Click(object sender, System.EventArgs e) {
			if (MessageBox.Show(this, "Voulez vous vraiment ajouter le montant de " + _ClientCtrl.Client.MontantLocation.ToString() + " à votre montant global ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
				cbTotalCours.Add(Convert.ToDouble(_ClientCtrl.Client.MontantLocation.Replace(" $", "")));
			}
		}

		private void ListViewPaiment_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e) {
            ListViewPaiment.ListViewItemSorter = new ListViewItemComparer(e.Column);

			ListViewPaiment.Sort();
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e) {
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

		private void timerSelection_Tick(object sender, System.EventArgs e) {
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
