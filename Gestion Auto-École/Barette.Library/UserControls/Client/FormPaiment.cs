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
	/// Description r�sum�e de FormPaiment.
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

		//Control Client r�f�ranc�
		private ClientControl _ClientCtrl = null;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;

		private Customer _Client = null;
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
		private long _RecuNumberWhenOpen = 0;

		public FormPaiment(ClientControl clientCtrl, Customer client) {
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			this._ClientCtrl = clientCtrl;
			this._Client = client;

			//Ecrire la date du jour
			DateFacture.Value = DateTime.Now;

			LoadList();
			MakeNew();

			//cr�ation du ficher : num�ro de recu
			if (!File.Exists(@"Data\recunumber.xml"))
				SaveNewRecuNumber(12000);

			this._RecuNumberWhenOpen = GetRecuNumber();
		}

		/// <summary>
		/// Nettoyage des ressources utilis�es.
		/// </summary>
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Code g�n�r� par le Concepteur Windows Form
		/// <summary>
		/// M�thode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette m�thode avec l'�diteur de code.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Livres", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Location Automobile", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Paiements Normaux", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Absense", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Credit", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaiment));
            this.ListViewPaiment = new System.Windows.Forms.ListView();
            this.colHeadDate = new System.Windows.Forms.ColumnHeader();
            this.colHeadMontant = new System.Windows.Forms.ColumnHeader();
            this.colHeadRecuNumber = new System.Windows.Forms.ColumnHeader();
            this.colHeadRL = new System.Windows.Forms.ColumnHeader();
            this.colHeadTypePaiment = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPaiment = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbAbsence = new System.Windows.Forms.RadioButton();
            this.cbLocationAuto = new System.Windows.Forms.RadioButton();
            this.cbRetourLivre = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTypePaiment = new System.Windows.Forms.TextBox();
            this.rbAutre = new System.Windows.Forms.RadioButton();
            this.rbArgentComptant = new System.Windows.Forms.RadioButton();
            this.rbPaimentDirect = new System.Windows.Forms.RadioButton();
            this.rbCheque = new System.Windows.Forms.RadioButton();
            this.NumeroRecu = new UtilityLibrary.WinControls.NumericTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateFacture = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.MontantPaiment = new Barette.Library.UserControls.CashTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdMakePaiment = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdApply = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSolde = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.cmdAddLocation = new System.Windows.Forms.Button();
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.tbbAddPaiment = new System.Windows.Forms.ToolBarButton();
            this.tbbDelete = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator1 = new System.Windows.Forms.ToolBarButton();
            this.tbbPrint = new System.Windows.Forms.ToolBarButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timerSelection = new System.Windows.Forms.Timer(this.components);
            this.timerAutuUpdate = new System.Timers.Timer();
            this.cbTotalCours = new Barette.Library.UserControls.CashTextBox();
            this.gbPaiment.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerAutuUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // ListViewPaiment
            // 
            this.ListViewPaiment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.ListViewPaiment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadDate,
            this.colHeadMontant,
            this.colHeadRecuNumber,
            this.colHeadRL,
            this.colHeadTypePaiment});
            this.ListViewPaiment.FullRowSelect = true;
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
            this.ListViewPaiment.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
            this.ListViewPaiment.HideSelection = false;
            this.ListViewPaiment.LabelWrap = false;
            this.ListViewPaiment.Location = new System.Drawing.Point(8, 48);
            this.ListViewPaiment.MultiSelect = false;
            this.ListViewPaiment.Name = "ListViewPaiment";
            this.ListViewPaiment.Size = new System.Drawing.Size(421, 361);
            this.ListViewPaiment.TabIndex = 0;
            this.ListViewPaiment.TabStop = false;
            this.ListViewPaiment.UseCompatibleStateImageBehavior = false;
            this.ListViewPaiment.View = System.Windows.Forms.View.Details;
            this.ListViewPaiment.SelectedIndexChanged += new System.EventHandler(this.ListViewPaiment_SelectedIndexChanged);
            this.ListViewPaiment.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewPaiment_ColumnClick);
            // 
            // colHeadDate
            // 
            this.colHeadDate.Text = "Date";
            this.colHeadDate.Width = 84;
            // 
            // colHeadMontant
            // 
            this.colHeadMontant.Text = "Montant";
            this.colHeadMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colHeadMontant.Width = 72;
            // 
            // colHeadRecuNumber
            // 
            this.colHeadRecuNumber.Text = "Num�ro de re�u";
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
            this.label1.Location = new System.Drawing.Point(436, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
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
            this.gbPaiment.Location = new System.Drawing.Point(436, 80);
            this.gbPaiment.Name = "gbPaiment";
            this.gbPaiment.Size = new System.Drawing.Size(312, 292);
            this.gbPaiment.TabIndex = 1;
            this.gbPaiment.TabStop = false;
            this.gbPaiment.Text = "Information sur le paiment";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbAbsence);
            this.groupBox2.Controls.Add(this.cbLocationAuto);
            this.groupBox2.Controls.Add(this.cbRetourLivre);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(167, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 124);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type";
            // 
            // cbAbsence
            // 
            this.cbAbsence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAbsence.AutoSize = true;
            this.cbAbsence.Location = new System.Drawing.Point(7, 68);
            this.cbAbsence.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.cbAbsence.Name = "cbAbsence";
            this.cbAbsence.Size = new System.Drawing.Size(67, 17);
            this.cbAbsence.TabIndex = 31;
            this.cbAbsence.Text = "Absence";
            // 
            // cbLocationAuto
            // 
            this.cbLocationAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLocationAuto.AutoSize = true;
            this.cbLocationAuto.Location = new System.Drawing.Point(7, 44);
            this.cbLocationAuto.Name = "cbLocationAuto";
            this.cbLocationAuto.Size = new System.Drawing.Size(66, 17);
            this.cbLocationAuto.TabIndex = 30;
            this.cbLocationAuto.Text = "Location";
            // 
            // cbRetourLivre
            // 
            this.cbRetourLivre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRetourLivre.AutoSize = true;
            this.cbRetourLivre.Location = new System.Drawing.Point(7, 19);
            this.cbRetourLivre.Name = "cbRetourLivre";
            this.cbRetourLivre.Size = new System.Drawing.Size(53, 17);
            this.cbRetourLivre.TabIndex = 29;
            this.cbRetourLivre.Text = "Livres";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(52, 92);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Aucun";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTypePaiment);
            this.groupBox1.Controls.Add(this.rbAutre);
            this.groupBox1.Controls.Add(this.rbArgentComptant);
            this.groupBox1.Controls.Add(this.rbPaimentDirect);
            this.groupBox1.Controls.Add(this.rbCheque);
            this.groupBox1.Location = new System.Drawing.Point(7, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 124);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type de Paiment";
            // 
            // txtTypePaiment
            // 
            this.txtTypePaiment.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTypePaiment.Location = new System.Drawing.Point(73, 95);
            this.txtTypePaiment.MaxLength = 8;
            this.txtTypePaiment.Name = "txtTypePaiment";
            this.txtTypePaiment.Size = new System.Drawing.Size(71, 20);
            this.txtTypePaiment.TabIndex = 4;
            // 
            // rbAutre
            // 
            this.rbAutre.AutoSize = true;
            this.rbAutre.Location = new System.Drawing.Point(7, 96);
            this.rbAutre.Name = "rbAutre";
            this.rbAutre.Size = new System.Drawing.Size(56, 17);
            this.rbAutre.TabIndex = 3;
            this.rbAutre.Text = "Autre :";
            // 
            // rbArgentComptant
            // 
            this.rbArgentComptant.AutoSize = true;
            this.rbArgentComptant.Location = new System.Drawing.Point(7, 72);
            this.rbArgentComptant.Name = "rbArgentComptant";
            this.rbArgentComptant.Size = new System.Drawing.Size(103, 17);
            this.rbArgentComptant.TabIndex = 2;
            this.rbArgentComptant.Text = "Argent comptant";
            // 
            // rbPaimentDirect
            // 
            this.rbPaimentDirect.AutoSize = true;
            this.rbPaimentDirect.Location = new System.Drawing.Point(7, 48);
            this.rbPaimentDirect.Name = "rbPaimentDirect";
            this.rbPaimentDirect.Size = new System.Drawing.Size(94, 17);
            this.rbPaimentDirect.TabIndex = 1;
            this.rbPaimentDirect.Text = "Paiment Direct";
            // 
            // rbCheque
            // 
            this.rbCheque.AutoSize = true;
            this.rbCheque.Location = new System.Drawing.Point(7, 24);
            this.rbCheque.Name = "rbCheque";
            this.rbCheque.Size = new System.Drawing.Size(62, 17);
            this.rbCheque.TabIndex = 0;
            this.rbCheque.Text = "Ch�que";
            // 
            // NumeroRecu
            // 
            this.NumeroRecu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NumeroRecu.Location = new System.Drawing.Point(144, 88);
            this.NumeroRecu.Name = "NumeroRecu";
            this.NumeroRecu.SetRange = new System.Drawing.Size(0, 99999999);
            this.NumeroRecu.Size = new System.Drawing.Size(89, 20);
            this.NumeroRecu.TabIndex = 25;
            this.NumeroRecu.Text = "0";
            this.NumeroRecu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Date :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateFacture
            // 
            this.DateFacture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DateFacture.Location = new System.Drawing.Point(144, 24);
            this.DateFacture.Name = "DateFacture";
            this.DateFacture.Size = new System.Drawing.Size(160, 20);
            this.DateFacture.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(7, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 16);
            this.label15.TabIndex = 20;
            this.label15.Text = "Num�ro de re�u :";
            // 
            // MontantPaiment
            // 
            this.MontantPaiment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MontantPaiment.Location = new System.Drawing.Point(145, 56);
            this.MontantPaiment.Name = "MontantPaiment";
            this.MontantPaiment.Size = new System.Drawing.Size(88, 20);
            this.MontantPaiment.TabIndex = 1;
            this.MontantPaiment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Montant du paiment :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdMakePaiment
            // 
            this.cmdMakePaiment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdMakePaiment.Image = global::Barette.Library.Properties.Resources.add_icon;
            this.cmdMakePaiment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdMakePaiment.Location = new System.Drawing.Point(155, 246);
            this.cmdMakePaiment.Name = "cmdMakePaiment";
            this.cmdMakePaiment.Size = new System.Drawing.Size(151, 40);
            this.cmdMakePaiment.TabIndex = 4;
            this.cmdMakePaiment.Text = "Effectuer un paiment";
            this.cmdMakePaiment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdMakePaiment.Click += new System.EventHandler(this.cmdMakePaiment_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Image = global::Barette.Library.Properties.Resources.Cancel_2_icon;
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancel.Location = new System.Drawing.Point(660, 418);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(89, 41);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "Annuler ";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdApply
            // 
            this.cmdApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdApply.Image = global::Barette.Library.Properties.Resources.accept_icon;
            this.cmdApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdApply.Location = new System.Drawing.Point(562, 418);
            this.cmdApply.Name = "cmdApply";
            this.cmdApply.Size = new System.Drawing.Size(92, 41);
            this.cmdApply.TabIndex = 4;
            this.cmdApply.Text = "Appliquer";
            this.cmdApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdApply.Click += new System.EventHandler(this.cmdApply_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(666, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "(incluant taxe)";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(438, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Solde :";
            // 
            // lblSolde
            // 
            this.lblSolde.ForeColor = System.Drawing.Color.Blue;
            this.lblSolde.Location = new System.Drawing.Point(502, 384);
            this.lblSolde.Name = "lblSolde";
            this.lblSolde.Size = new System.Drawing.Size(246, 16);
            this.lblSolde.TabIndex = 24;
            this.lblSolde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // cmdAddLocation
            // 
            this.cmdAddLocation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAddLocation.Location = new System.Drawing.Point(524, 48);
            this.cmdAddLocation.Name = "cmdAddLocation";
            this.cmdAddLocation.Size = new System.Drawing.Size(56, 23);
            this.cmdAddLocation.TabIndex = 25;
            this.cmdAddLocation.Text = "Location";
            this.cmdAddLocation.Click += new System.EventHandler(this.cmdAddLocation_Click);
            // 
            // toolBar1
            // 
            this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbAddPaiment,
            this.tbbDelete,
            this.tbbSeparator1,
            this.tbbPrint});
            this.toolBar1.Divider = false;
            this.toolBar1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Location = new System.Drawing.Point(8, 8);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(252, 42);
            this.toolBar1.TabIndex = 26;
            this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
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
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
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
            this.timerSelection.Tick += new System.EventHandler(this.timerSelection_Tick);
            // 
            // timerAutuUpdate
            // 
            this.timerAutuUpdate.SynchronizingObject = this;
            this.timerAutuUpdate.Elapsed += new System.Timers.ElapsedEventHandler(this.timerAutuUpdate_Elapsed);
            // 
            // cbTotalCours
            // 
            this.cbTotalCours.Location = new System.Drawing.Point(599, 51);
            this.cbTotalCours.Name = "cbTotalCours";
            this.cbTotalCours.Size = new System.Drawing.Size(64, 20);
            this.cbTotalCours.TabIndex = 0;
            this.cbTotalCours.Text = "0 $";
            this.cbTotalCours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbTotalCours.TextChanged += new System.EventHandler(this.cbTotalCours_TextChanged);
            this.cbTotalCours.Leave += new System.EventHandler(this.cbTotalCours_Leave);
            // 
            // FormPaiment
            // 
            this.ClientSize = new System.Drawing.Size(760, 468);
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
            this.Text = "Paiement du solde";
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

		private void cmdCancel_Click(object sender, System.EventArgs e) {
			SaveNewRecuNumber(this._RecuNumberWhenOpen);
			this.DialogResult = DialogResult.Cancel;
			this.Close(); //Ferme la boite de dialogue
		}

		/// <summary>
		/// Supprimer le paiment Selection�
		/// </summary>
		private void DeletePaiment() {
			//Supprimer un paiment
			if (ListViewPaiment.SelectedItems.Count > 0)
				if (MessageBox.Show(this, "Voulez vous vraiment effacer ce paiment ?",
					"Ecole de conduite Barrette",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question) == DialogResult.Yes)
					ListViewPaiment.Items.RemoveAt(ListViewPaiment.SelectedItems[0].Index);

			ShowSolde();
		}

		private void cmdMakePaiment_Click(object sender, System.EventArgs e) {
			NumeroRecu.Focus();

			switch (this._Mode) {
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
		/// Faire un calcule du solde avec les paiments effectu�
		/// </summary>
		private double CalculSolde() {
			double MontantPayer = 0;

			for (int i = 0; i < ListViewPaiment.Items.Count; i++)
                if (ListViewPaiment.Items[i].SubItems[3].Text != "RL")
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

				ListViewPaiment.SelectedItems[0].Text = DateFacture.Value.ToShortDateString();
				ListViewPaiment.SelectedItems[0].SubItems[1].Text = MontantPaiment.Text;
				ListViewPaiment.SelectedItems[0].SubItems[2].Text = NumeroRecu.Text;
				ListViewPaiment.SelectedItems[0].SubItems[3].Text = type;
				ListViewPaiment.SelectedItems[0].SubItems[4].Text = typePaiment;

			} else {
				MessageBox.Show(this, "Ce num�ro de re�u est d�ja pr�sent dans votre liste de paiment et le montant doit �tre valide.", "Gestion Auto �cole",
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
		/// Ajouter un paiment � la viste
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

					//Ajouter le paiement a la liste de paiement
					ListViewItem itm = new ListViewItem(new string[] { DateFacture.Value.ToShortDateString(), MontantPaiment.Text, NumeroRecu.Text, type, typePaiment });
					
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
					MessageBox.Show(this, "Veuillez inscrire le montant du paiement et le num�ro de re�u.", "Gestion Auto �cole",
						MessageBoxButtons.OK,
						MessageBoxIcon.Exclamation);
				}
			} else {
                MessageBox.Show(this, "Ce num�ro de re�u est d�ja pr�sent dans votre liste de paiment.", "Gestion Auto �cole",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
		}

		/// <summary>
		/// Retourne true si le num�ro de recu est existant
        /// TODO : regard� dans tous les clients.....
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
            }
		}

		/// <summary>
		/// Chargement de la liste de paiment
		/// </summary>
		private void LoadList() {
			Paiement paiment = null;
			string type;
			string typePaiment = "";

			cbTotalCours.Text = this._ClientCtrl._MontantCours;

			for (int i = 0; i < this._Client.Paiment.Count; i++) {
				paiment = this._Client.Paiment[i];

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
				ListViewItem itm = new ListViewItem(new string[] { paiment.DatePaiment.ToShortDateString(), paiment.Montant, paiment.NumeroRecu.ToString(), type, typePaiment });
				
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
			this._ClientCtrl.CashBox_Solde.Text = lblSolde.Text;
			this._ClientCtrl._MontantCours = cbTotalCours.Text;

			AddCashSymbol();

			this._Client.Paiment.Clear();

			if (ListViewPaiment.Items.Count > 0) { //Si au moins 1 items
				this._ClientCtrl.dbRecuNumber.Text = ListViewPaiment.Items[ListViewPaiment.Items.Count - 1].SubItems[2].Text;

				//Paiment du client
				//this._Client.Paiment.Clear();

				Paiement paiment = null;
				foreach (ListViewItem item in ListViewPaiment.Items) {
					paiment = new Paiement();
					paiment.DatePaiment = DateTime.Parse(item.SubItems[0].Text);
					paiment.Montant = item.SubItems[1].Text;
					paiment.NumeroRecu = Convert.ToInt16(item.SubItems[2].Text);

					if (item.SubItems[3].Text == "RL")
						paiment.Type = PaiementType.RetourLivre;
					else if (item.SubItems[3].Text == "LA")
						paiment.Type = PaiementType.LocationAuto;
					else if (item.SubItems[3].Text == "ABS")
						paiment.Type = PaiementType.Absence;
					else
						paiment.Type = PaiementType.Nothing;

					switch (item.SubItems[4].Text) {
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

					this._Client.Paiment.Add(paiment);
				}
			}

			//Ferme la dialogbox
			this.DialogResult = DialogResult.OK;
			this.Close();
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
		/// <param name="Number">Num�ro du paiment a s�lectionn�</param>
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
		private void PrintListPaiment() {
			//Lance l'impression
			PrintDialog printConfig = new PrintDialog();

			printConfig.PrinterSettings = printDocument1.PrinterSettings;

			AddCashSymbol();
#if DEBUG
			PrintPreviewDialog prev = new PrintPreviewDialog();
			prev.Document = printDocument1;
			prev.ShowDialog(this);

#else
			if(printConfig.ShowDialog(this) == DialogResult.OK)	
					printDocument1.Print();			
#endif	
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {

			//Ecriture du header (image)
			Stream strm = Type.GetType("Barette.Library.UserControls.Client.ClientControl").Assembly.GetManifestResourceStream("Barette.Library.res.Printlogo.png");
			Bitmap img = new Bitmap(strm);
            e.Graphics.DrawImage(img, 0, 0, 250, 200);
			float topMargin = img.Height + 30;
			float leftMargin = 0;//e.MarginBounds.Left;
			string typePaiment = "";

			//Facrication de la font
			Font printFont = new System.Drawing.Font("Courier New", 12);

			float yPos = 0f;
			float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

			//Donn�e a imprimer
			yPos = topMargin + 5;
			e.Graphics.DrawString("Liste des paiments", new Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, leftMargin, yPos, new StringFormat());
			e.Graphics.DrawString("Imprim� le : " + DateTime.Now.ToShortDateString(), new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, leftMargin + 450, yPos, new StringFormat());

			yPos += printFont.Height + 16;
			e.Graphics.DrawString("Nom du client: " + this._Client.Name + " " + this._Client.FirstName, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
			yPos += printFont.Height;
			e.Graphics.DrawString("Num�ro de contrat: " + this._Client.ContratNumber, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

			yPos += printFont.Height + 35;
			//Header du tableau
			e.Graphics.DrawString("Date", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, leftMargin + 20, yPos, new StringFormat());
			e.Graphics.DrawString("Num�ro de re�u", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, leftMargin + 200, yPos, new StringFormat());
			e.Graphics.DrawString("Montant", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, leftMargin + 350, yPos, new StringFormat());
			e.Graphics.DrawString("Type", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, leftMargin + 450, yPos, new StringFormat());
			e.Graphics.DrawString("Type de Paiment", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, leftMargin + 550, yPos, new StringFormat());
			yPos += printFont.Height + 10;
			for (int i = 0; i < ListViewPaiment.Items.Count; i++) {
				e.Graphics.DrawString(ListViewPaiment.Items[i].Text, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
				e.Graphics.DrawString(ListViewPaiment.Items[i].SubItems[2].Text, printFont, Brushes.Black, leftMargin + 200, yPos, new StringFormat());
				e.Graphics.DrawString(ListViewPaiment.Items[i].SubItems[1].Text, printFont, Brushes.Black, 440 - e.Graphics.MeasureString(ListViewPaiment.Items[i].SubItems[1].Text, printFont).Width, yPos, new StringFormat());
				e.Graphics.DrawString(ListViewPaiment.Items[i].SubItems[3].Text, printFont, Brushes.Black, leftMargin + 450, yPos, new StringFormat());

				switch (ListViewPaiment.Items[i].SubItems[4].Text) {
					case "AC":
						typePaiment = "Argent Comptant";
						break;
					case "CH":
						typePaiment = "Ch�que";
						break;
					case "PD":
						typePaiment = "Paiment Direct";
						break;
					case "":
						typePaiment = "";
						break;
					default:
						typePaiment = ListViewPaiment.Items[i].SubItems[4].Text;
						break;
				}

				e.Graphics.DrawString(typePaiment, printFont, Brushes.Black, leftMargin + 550, yPos, new StringFormat());

				yPos += printFont.Height;
			}

			yPos += printFont.Height;
			e.Graphics.DrawString("Solde : " + this.lblSolde.Text, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

			yPos += (printFont.Height * 2);
			e.Graphics.DrawString("LES TAXES TPS ET TVQ SONT COMPRISES DANS LES MONTANTS", printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

			yPos += 40;
			e.Graphics.DrawString("Signature du client:_______________________________", printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
			yPos += 25;
			e.Graphics.DrawString("Signature du commercant:___________________________", printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
		}

		private void ListViewPaiment_SelectedIndexChanged(object sender, System.EventArgs e) {
			try {
				this._Mode = PaiementMode.Modifier;
				cmdMakePaiment.Text = "Modifier";
                cmdMakePaiment.Image = global::Barette.Library.Properties.Resources.accept_icon;

				DateFacture.Value = Convert.ToDateTime(ListViewPaiment.SelectedItems[0].Text);
				MontantPaiment.Text = ListViewPaiment.SelectedItems[0].SubItems[1].Text.Replace(" $", "");
				NumeroRecu.Text = ListViewPaiment.SelectedItems[0].SubItems[2].Text;

				if (ListViewPaiment.SelectedItems[0].SubItems[3].Text == "RL")
					cbRetourLivre.Checked = true;
				else
					cbRetourLivre.Checked = false;

				switch (ListViewPaiment.SelectedItems[0].SubItems[4].Text) {
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

				switch (ListViewPaiment.SelectedItems[0].SubItems[3].Text) {
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
		/// Cr�� un nouveau paiment vierge
		/// </summary>
		private void MakeNew() {
			this._Mode = PaiementMode.Nouveau;
			MontantPaiment.Text = "";
			NumeroRecu.Text = GetRecuNumber().ToString();
			DateFacture.Value = DateTime.Now;
			cbRetourLivre.Checked = cbAbsence.Checked = cbLocationAuto.Checked = false;
			rbArgentComptant.Checked = true;
			cmdMakePaiment.Text = "Effectuer un paiment";
            cmdMakePaiment.Image = global::Barette.Library.Properties.Resources.add_icon;
			MontantPaiment.Focus();
		}

		#region Num�ro de re�u Automatique
		/// <summary>
		/// Obtenir le num�ro de recu
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
			if (MessageBox.Show(this, "Voulez vous vraiment ajouter le montant de " + this._ClientCtrl.Client.MontantLocation.ToString() + " � votre montant global ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
				cbTotalCours.Add(Convert.ToDouble(this._ClientCtrl.Client.MontantLocation.Replace(" $", "")));
			}
		}

		private void ListViewPaiment_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e) {
			this.ListViewPaiment.ListViewItemSorter = new ListViewItemComparer(e.Column);

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
			if (this._Mode == PaiementMode.Modifier)
				ModifierPaiment();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			cbAbsence.Checked = cbLocationAuto.Checked = cbRetourLivre.Checked = false;
		}

	}
}
