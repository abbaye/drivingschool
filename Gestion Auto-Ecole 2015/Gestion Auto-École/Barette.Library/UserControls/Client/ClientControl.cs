using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;

using Barette.Library;
using Barette.Library.Forms;
using Barette.Library.Client;
using Barette.Library.Collections;
using Barette.Library.UserControls.Client;
using Barette.Library.UserControls.TextEdit;
using Barette.Library.Web;

namespace Barette.Library.UserControls.Client {
    /// <summary>
    /// Description résumée de ClientControl.
    /// </summary>
    [ToolboxItem(true)]
    public class ClientControl : System.Windows.Forms.UserControl {
        /// <summary>
        /// Type de Seance
        /// </summary>
        private enum SeanceType {
            Automobile,
            Moto,
            Cyclomoteur
        }

        /// <!-- CHANGER CETTE VARIABLE POUR UN ENUM-->
        private SeanceType _SceanceType = SeanceType.Automobile;


        /// <summary>
        /// Client que contient le control
        /// </summary>
        private Customer _Client = new Customer();

        /// <summary>
        /// Liste d'employe
        /// </summary>
        private EmployeCollection _EmployeList = new EmployeCollection();

        private bool _AutoUpdate = true;
        public string _MontantCours = "";
        private SchoolInfo _infoSchool = null;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbCoursType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button cmdShowSeanceTheorique;
        private System.Windows.Forms.TextBox txtN6R;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAdressStreet;
        private System.Windows.Forms.TextBox txtNumeroPermis;
        private System.Windows.Forms.DateTimePicker DateInscription;
        private System.Windows.Forms.CheckBox chkDisponibilityDimanche;
        private System.Windows.Forms.CheckBox chkDisponibilitySamedi;
        private System.Windows.Forms.CheckBox chkDisponibilitySoir;
        private System.Windows.Forms.CheckBox chkDisponibilityPM;
        private System.Windows.Forms.CheckBox chkDisponibilityAM;
        private System.Windows.Forms.RadioButton rbTypeClientFinish;
        private System.Windows.Forms.RadioButton rbTypeClientActif;
        private System.Windows.Forms.RadioButton rbVehiculMotocyclette;
        private System.Windows.Forms.RadioButton rbVehiculMoto;
        private System.Windows.Forms.RadioButton rbVehiculAutomatique;
        private System.Windows.Forms.RadioButton rbVehiculManuel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ImageList ImageListToolBar;
        private System.Windows.Forms.ToolTip toolTipText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAdressApp;
        private System.Windows.Forms.CheckBox cbMoto;
        private System.Windows.Forms.CheckBox cbAuto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Button cmdAlwayDispo;
        private System.Windows.Forms.DateTimePicker dtpBVA;
        private System.Windows.Forms.Timer timerCheckClientValid;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dtpDatePermis;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpDatePermisPlus8;
        private System.Windows.Forms.CheckBox cbPermisObtenue;
        private PictureBox pictureBox4;
        private Label label19;
        private Label label20;
        public UtilityLibrary.WinControls.NumericTextBox txtAdressNumber;
        public UtilityLibrary.WinControls.NumericTextBox dbRecuNumber;
        public UtilityLibrary.WinControls.NumericTextBox txtNumeroAttestation;
        private MaskedTextBox txtPhoneBureau;
        private MaskedTextBox txtPhoneNumber;
        private MaskedTextBox txtCodePostal;
        public CashTextBox CashBox_Solde;
        private TextEditor txtNotes;
        private CashTextBox ctbLocationMontant;
        private CheckBox cbNullContrat;
        private Label label21;
        private DateTimePicker DateNaissance;
        private Label label22;
        private DateTimePicker DateExpiration;
        private Label label23;
        private DateTimePicker DateDebutCours;
        private Button cmdShowSeanceT;
        private PrintDocument printDocContract;
        private Button cmdAutoDateExpiration;
        public UtilityLibrary.WinControls.NumericTextBox txtNumeroContrat;
        private CashTextBox ctbTauxHoraireTheorique;
        private CashTextBox ctbTauxHorairePratique;
        public UtilityLibrary.WinControls.NumericTextBox txtNumeroAttestation2;
        private Label label24;
        private DateTimePicker dtpAttestation2;
        private DateTimePicker dtpAttestation1;
        private PrintDocument printDocTheorique;
        private UtilityLibrary.WinControls.NumericTextBox txtNumeroGroupe;
        private Label label25;
        private Button cmdClearbox;
        private TextBox txtEmail;
        private Label label26;
        private ErrorProvider EmailError;
        private ComboCityPicker cbCity;
        private Button cmdShowSeancesMoto2015;
        private PrintDocument printDocMoto2015;
        private System.Windows.Forms.CheckBox cbBVA;

        public ClientControl(SchoolInfo info) {
            // Cet appel est requis par le Concepteur de formulaires Windows.Forms.
            InitializeComponent();

            this._infoSchool = info;
        }

        public ClientControl() {
            // Cet appel est requis par le Concepteur de formulaires Windows.Forms.
            InitializeComponent();
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

        #region Component Designer generated code
        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientControl));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cmdAlwayDispo = new System.Windows.Forms.Button();
            this.chkDisponibilityDimanche = new System.Windows.Forms.CheckBox();
            this.chkDisponibilitySamedi = new System.Windows.Forms.CheckBox();
            this.chkDisponibilitySoir = new System.Windows.Forms.CheckBox();
            this.chkDisponibilityPM = new System.Windows.Forms.CheckBox();
            this.chkDisponibilityAM = new System.Windows.Forms.CheckBox();
            this.txtNumeroPermis = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbCoursType = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtN6R = new System.Windows.Forms.TextBox();
            this.rbVehiculMotocyclette = new System.Windows.Forms.RadioButton();
            this.rbVehiculMoto = new System.Windows.Forms.RadioButton();
            this.rbVehiculManuel = new System.Windows.Forms.RadioButton();
            this.rbVehiculAutomatique = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.DateNaissance = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.txtAdressNumber = new UtilityLibrary.WinControls.NumericTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtAdressApp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdressStreet = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPhoneBureau = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbTypeClientFinish = new System.Windows.Forms.RadioButton();
            this.rbTypeClientActif = new System.Windows.Forms.RadioButton();
            this.DateInscription = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dbRecuNumber = new UtilityLibrary.WinControls.NumericTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImageListToolBar = new System.Windows.Forms.ImageList(this.components);
            this.toolTipText = new System.Windows.Forms.ToolTip(this.components);
            this.cbBVA = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbNullContrat = new System.Windows.Forms.CheckBox();
            this.cmdShowSeanceT = new System.Windows.Forms.Button();
            this.cmdShowSeanceTheorique = new System.Windows.Forms.Button();
            this.cmdAutoDateExpiration = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.cmdClearbox = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpBVA = new System.Windows.Forms.DateTimePicker();
            this.cbMoto = new System.Windows.Forms.CheckBox();
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.timerCheckClientValid = new System.Windows.Forms.Timer(this.components);
            this.dtpDatePermis = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbPermisObtenue = new System.Windows.Forms.CheckBox();
            this.dtpDatePermisPlus8 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.DateExpiration = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.DateDebutCours = new System.Windows.Forms.DateTimePicker();
            this.printDocContract = new System.Drawing.Printing.PrintDocument();
            this.txtNumeroAttestation = new UtilityLibrary.WinControls.NumericTextBox();
            this.txtNumeroContrat = new UtilityLibrary.WinControls.NumericTextBox();
            this.txtNumeroAttestation2 = new UtilityLibrary.WinControls.NumericTextBox();
            this.dtpAttestation2 = new System.Windows.Forms.DateTimePicker();
            this.dtpAttestation1 = new System.Windows.Forms.DateTimePicker();
            this.printDocTheorique = new System.Drawing.Printing.PrintDocument();
            this.txtNumeroGroupe = new UtilityLibrary.WinControls.NumericTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.EmailError = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmdShowSeancesMoto2015 = new System.Windows.Forms.Button();
            this.ctbTauxHorairePratique = new Barette.Library.UserControls.CashTextBox();
            this.ctbTauxHoraireTheorique = new Barette.Library.UserControls.CashTextBox();
            this.ctbLocationMontant = new Barette.Library.UserControls.CashTextBox();
            this.CashBox_Solde = new Barette.Library.UserControls.CashTextBox();
            this.txtNotes = new Barette.Library.UserControls.TextEdit.TextEditor();
            this.cbCity = new Barette.Library.UserControls.ComboCityPicker();
            this.printDocMoto2015 = new System.Drawing.Printing.PrintDocument();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.gbCoursType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailError)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.cmdAlwayDispo);
            this.groupBox2.Controls.Add(this.chkDisponibilityDimanche);
            this.groupBox2.Controls.Add(this.chkDisponibilitySamedi);
            this.groupBox2.Controls.Add(this.chkDisponibilitySoir);
            this.groupBox2.Controls.Add(this.chkDisponibilityPM);
            this.groupBox2.Controls.Add(this.chkDisponibilityAM);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(0, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 80);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Disponibilité";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Barette.Library.Properties.Resources.stylish8;
            this.pictureBox4.Location = new System.Drawing.Point(7, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // cmdAlwayDispo
            // 
            this.cmdAlwayDispo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAlwayDispo.Location = new System.Drawing.Point(132, 14);
            this.cmdAlwayDispo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.cmdAlwayDispo.Name = "cmdAlwayDispo";
            this.cmdAlwayDispo.Size = new System.Drawing.Size(75, 23);
            this.cmdAlwayDispo.TabIndex = 6;
            this.cmdAlwayDispo.Text = "Toujours";
            this.cmdAlwayDispo.Click += new System.EventHandler(this.cmdAlwayDispo_Click);
            // 
            // chkDisponibilityDimanche
            // 
            this.chkDisponibilityDimanche.AutoSize = true;
            this.chkDisponibilityDimanche.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkDisponibilityDimanche.Location = new System.Drawing.Point(132, 54);
            this.chkDisponibilityDimanche.Name = "chkDisponibilityDimanche";
            this.chkDisponibilityDimanche.Size = new System.Drawing.Size(80, 18);
            this.chkDisponibilityDimanche.TabIndex = 5;
            this.chkDisponibilityDimanche.Text = "Dimanche";
            // 
            // chkDisponibilitySamedi
            // 
            this.chkDisponibilitySamedi.AutoSize = true;
            this.chkDisponibilitySamedi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkDisponibilitySamedi.Location = new System.Drawing.Point(132, 38);
            this.chkDisponibilitySamedi.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.chkDisponibilitySamedi.Name = "chkDisponibilitySamedi";
            this.chkDisponibilitySamedi.Size = new System.Drawing.Size(67, 18);
            this.chkDisponibilitySamedi.TabIndex = 4;
            this.chkDisponibilitySamedi.Text = "Samedi";
            // 
            // chkDisponibilitySoir
            // 
            this.chkDisponibilitySoir.AutoSize = true;
            this.chkDisponibilitySoir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkDisponibilitySoir.Location = new System.Drawing.Point(44, 54);
            this.chkDisponibilitySoir.Name = "chkDisponibilitySoir";
            this.chkDisponibilitySoir.Size = new System.Drawing.Size(62, 18);
            this.chkDisponibilitySoir.TabIndex = 3;
            this.chkDisponibilitySoir.Text = "Soirée";
            // 
            // chkDisponibilityPM
            // 
            this.chkDisponibilityPM.AutoSize = true;
            this.chkDisponibilityPM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkDisponibilityPM.Location = new System.Drawing.Point(44, 38);
            this.chkDisponibilityPM.Name = "chkDisponibilityPM";
            this.chkDisponibilityPM.Size = new System.Drawing.Size(81, 18);
            this.chkDisponibilityPM.TabIndex = 2;
            this.chkDisponibilityPM.Text = "Après Midi";
            // 
            // chkDisponibilityAM
            // 
            this.chkDisponibilityAM.AutoSize = true;
            this.chkDisponibilityAM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkDisponibilityAM.Location = new System.Drawing.Point(44, 22);
            this.chkDisponibilityAM.Name = "chkDisponibilityAM";
            this.chkDisponibilityAM.Size = new System.Drawing.Size(58, 18);
            this.chkDisponibilityAM.TabIndex = 1;
            this.chkDisponibilityAM.Text = "Matin";
            // 
            // txtNumeroPermis
            // 
            this.txtNumeroPermis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroPermis.Location = new System.Drawing.Point(128, 31);
            this.txtNumeroPermis.MaxLength = 20;
            this.txtNumeroPermis.Name = "txtNumeroPermis";
            this.txtNumeroPermis.Size = new System.Drawing.Size(144, 20);
            this.txtNumeroPermis.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "No. de permis";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbCoursType
            // 
            this.gbCoursType.Controls.Add(this.label19);
            this.gbCoursType.Controls.Add(this.txtN6R);
            this.gbCoursType.Controls.Add(this.rbVehiculMotocyclette);
            this.gbCoursType.Controls.Add(this.rbVehiculMoto);
            this.gbCoursType.Controls.Add(this.rbVehiculManuel);
            this.gbCoursType.Controls.Add(this.rbVehiculAutomatique);
            this.gbCoursType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbCoursType.Location = new System.Drawing.Point(0, 442);
            this.gbCoursType.Name = "gbCoursType";
            this.gbCoursType.Size = new System.Drawing.Size(195, 88);
            this.gbCoursType.TabIndex = 12;
            this.gbCoursType.TabStop = false;
            this.gbCoursType.Text = "Type de véhicule";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Nº6R:";
            // 
            // txtN6R
            // 
            this.txtN6R.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtN6R.Enabled = false;
            this.txtN6R.Location = new System.Drawing.Point(48, 64);
            this.txtN6R.Name = "txtN6R";
            this.txtN6R.Size = new System.Drawing.Size(139, 20);
            this.txtN6R.TabIndex = 5;
            // 
            // rbVehiculMotocyclette
            // 
            this.rbVehiculMotocyclette.AutoSize = true;
            this.rbVehiculMotocyclette.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbVehiculMotocyclette.Location = new System.Drawing.Point(95, 39);
            this.rbVehiculMotocyclette.Name = "rbVehiculMotocyclette";
            this.rbVehiculMotocyclette.Size = new System.Drawing.Size(89, 18);
            this.rbVehiculMotocyclette.TabIndex = 4;
            this.rbVehiculMotocyclette.Tag = "General";
            this.rbVehiculMotocyclette.Text = "Cyclomoteur";
            this.rbVehiculMotocyclette.CheckedChanged += new System.EventHandler(this.rbCamion_CheckedChanged);
            // 
            // rbVehiculMoto
            // 
            this.rbVehiculMoto.AutoSize = true;
            this.rbVehiculMoto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbVehiculMoto.Location = new System.Drawing.Point(8, 39);
            this.rbVehiculMoto.Name = "rbVehiculMoto";
            this.rbVehiculMoto.Size = new System.Drawing.Size(55, 18);
            this.rbVehiculMoto.TabIndex = 2;
            this.rbVehiculMoto.Tag = "Moto";
            this.rbVehiculMoto.Text = "Moto";
            this.rbVehiculMoto.CheckedChanged += new System.EventHandler(this.rbMoto_CheckedChanged);
            // 
            // rbVehiculManuel
            // 
            this.rbVehiculManuel.AutoSize = true;
            this.rbVehiculManuel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbVehiculManuel.Location = new System.Drawing.Point(95, 16);
            this.rbVehiculManuel.Name = "rbVehiculManuel";
            this.rbVehiculManuel.Size = new System.Drawing.Size(66, 18);
            this.rbVehiculManuel.TabIndex = 3;
            this.rbVehiculManuel.Tag = "General";
            this.rbVehiculManuel.Text = "Manuel";
            this.rbVehiculManuel.CheckedChanged += new System.EventHandler(this.rbManuel_CheckedChanged);
            // 
            // rbVehiculAutomatique
            // 
            this.rbVehiculAutomatique.AutoSize = true;
            this.rbVehiculAutomatique.Checked = true;
            this.rbVehiculAutomatique.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbVehiculAutomatique.Location = new System.Drawing.Point(8, 16);
            this.rbVehiculAutomatique.Name = "rbVehiculAutomatique";
            this.rbVehiculAutomatique.Size = new System.Drawing.Size(90, 18);
            this.rbVehiculAutomatique.TabIndex = 1;
            this.rbVehiculAutomatique.TabStop = true;
            this.rbVehiculAutomatique.Tag = "General";
            this.rbVehiculAutomatique.Text = "Automatique";
            this.rbVehiculAutomatique.CheckedChanged += new System.EventHandler(this.rbAutomatique_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCity);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.DateNaissance);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.txtCodePostal);
            this.groupBox1.Controls.Add(this.txtAdressNumber);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.txtAdressApp);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAdressStreet);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtPhoneBureau);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(0, 112);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 158);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations sur le client";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(456, 132);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(176, 20);
            this.txtEmail.TabIndex = 28;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(352, 135);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(48, 13);
            this.label26.TabIndex = 27;
            this.label26.Text = "Courriel :";
            // 
            // DateNaissance
            // 
            this.DateNaissance.Location = new System.Drawing.Point(456, 106);
            this.DateNaissance.Name = "DateNaissance";
            this.DateNaissance.Size = new System.Drawing.Size(123, 20);
            this.DateNaissance.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(352, 109);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 13);
            this.label21.TabIndex = 26;
            this.label21.Text = "Date naissance :";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(162, 107);
            this.txtPhoneNumber.Mask = "(999)000-0000";
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 8;
            this.txtPhoneNumber.Enter += new System.EventHandler(this.txtPhoneNumber_Enter);
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(456, 78);
            this.txtCodePostal.Mask = "L0L-0L0";
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(56, 20);
            this.txtCodePostal.TabIndex = 7;
            this.txtCodePostal.Enter += new System.EventHandler(this.txtCodePostal_Enter);
            this.txtCodePostal.Leave += new System.EventHandler(this.txtCodePostal_Leave);
            // 
            // txtAdressNumber
            // 
            this.txtAdressNumber.Location = new System.Drawing.Point(155, 51);
            this.txtAdressNumber.Name = "txtAdressNumber";
            this.txtAdressNumber.SetRange = new System.Drawing.Size(0, 9999999);
            this.txtAdressNumber.ShortcutsEnabled = false;
            this.txtAdressNumber.Size = new System.Drawing.Size(54, 20);
            this.txtAdressNumber.TabIndex = 3;
            this.txtAdressNumber.Text = "0";
            this.txtAdressNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAdressNumber.Value = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // txtAdressApp
            // 
            this.txtAdressApp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAdressApp.Location = new System.Drawing.Point(584, 51);
            this.txtAdressApp.Name = "txtAdressApp";
            this.txtAdressApp.Size = new System.Drawing.Size(48, 20);
            this.txtAdressApp.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Code Postale :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Téléphone :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Prénom :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Adresse:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "No :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rue :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(550, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "App.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ville :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nom :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAdressStreet
            // 
            this.txtAdressStreet.Location = new System.Drawing.Point(254, 51);
            this.txtAdressStreet.Name = "txtAdressStreet";
            this.txtAdressStreet.Size = new System.Drawing.Size(290, 20);
            this.txtAdressStreet.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(384, 24);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(248, 20);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 20);
            this.txtName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Téléphone (Autre):";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhoneBureau
            // 
            this.txtPhoneBureau.Location = new System.Drawing.Point(162, 132);
            this.txtPhoneBureau.Mask = "(999)000-0000";
            this.txtPhoneBureau.Name = "txtPhoneBureau";
            this.txtPhoneBureau.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneBureau.TabIndex = 9;
            this.txtPhoneBureau.Enter += new System.EventHandler(this.txtPhoneBureau_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Nº contrat:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbTypeClientFinish);
            this.groupBox5.Controls.Add(this.rbTypeClientActif);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox5.Location = new System.Drawing.Point(201, 442);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(111, 88);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "États du client";
            // 
            // rbTypeClientFinish
            // 
            this.rbTypeClientFinish.AutoSize = true;
            this.rbTypeClientFinish.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbTypeClientFinish.Location = new System.Drawing.Point(6, 54);
            this.rbTypeClientFinish.Name = "rbTypeClientFinish";
            this.rbTypeClientFinish.Size = new System.Drawing.Size(95, 18);
            this.rbTypeClientFinish.TabIndex = 2;
            this.rbTypeClientFinish.Text = "Cours terminé";
            // 
            // rbTypeClientActif
            // 
            this.rbTypeClientActif.Checked = true;
            this.rbTypeClientActif.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbTypeClientActif.Location = new System.Drawing.Point(6, 27);
            this.rbTypeClientActif.Name = "rbTypeClientActif";
            this.rbTypeClientActif.Size = new System.Drawing.Size(88, 16);
            this.rbTypeClientActif.TabIndex = 1;
            this.rbTypeClientActif.TabStop = true;
            this.rbTypeClientActif.Text = "Actif";
            // 
            // DateInscription
            // 
            this.DateInscription.Location = new System.Drawing.Point(487, 9);
            this.DateInscription.Name = "DateInscription";
            this.DateInscription.Size = new System.Drawing.Size(128, 20);
            this.DateInscription.TabIndex = 3;
            this.DateInscription.Value = new System.DateTime(2015, 4, 11, 0, 0, 0, 0);
            this.DateInscription.ValueChanged += new System.EventHandler(this.DateInscription_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(378, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Inscription :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "Fichier Client";
            this.printDocument1.OriginAtMargins = true;
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dbRecuNumber);
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.CashBox_Solde);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox7.Location = new System.Drawing.Point(227, 355);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(301, 80);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Information sur le solde";
            // 
            // dbRecuNumber
            // 
            this.dbRecuNumber.Location = new System.Drawing.Point(154, 47);
            this.dbRecuNumber.Name = "dbRecuNumber";
            this.dbRecuNumber.SetRange = new System.Drawing.Size(0, 9999999);
            this.dbRecuNumber.ShortcutsEnabled = false;
            this.dbRecuNumber.Size = new System.Drawing.Size(64, 20);
            this.dbRecuNumber.TabIndex = 2;
            this.dbRecuNumber.Text = "0";
            this.dbRecuNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dbRecuNumber.Value = 0;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(224, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 48);
            this.button1.TabIndex = 3;
            this.toolTipText.SetToolTip(this.button1, "Paiement et reçu");
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Dernier numéro de reçu";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Solde";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox8.Controls.Add(this.txtNotes);
            this.groupBox8.Controls.Add(this.pictureBox1);
            this.groupBox8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox8.Location = new System.Drawing.Point(0, 538);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(640, 177);
            this.groupBox8.TabIndex = 31;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Notes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // ImageListToolBar
            // 
            this.ImageListToolBar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImageListToolBar.ImageSize = new System.Drawing.Size(16, 16);
            this.ImageListToolBar.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cbBVA
            // 
            this.cbBVA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbBVA.Location = new System.Drawing.Point(8, 23);
            this.cbBVA.Name = "cbBVA";
            this.cbBVA.Size = new System.Drawing.Size(48, 24);
            this.cbBVA.TabIndex = 1;
            this.cbBVA.Text = "BVA";
            this.toolTipText.SetToolTip(this.cbBVA, "Date pour le Bureau des Véhicules Automobile.");
            this.cbBVA.CheckedChanged += new System.EventHandler(this.cbBVA_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 37);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 13);
            this.label20.TabIndex = 39;
            this.label20.Text = "Nº Attestation 1:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipText.SetToolTip(this.label20, "Nº Attestation de la Ligue de Sécurité");
            // 
            // cbNullContrat
            // 
            this.cbNullContrat.AutoSize = true;
            this.cbNullContrat.Location = new System.Drawing.Point(187, 11);
            this.cbNullContrat.Name = "cbNullContrat";
            this.cbNullContrat.Size = new System.Drawing.Size(15, 14);
            this.cbNullContrat.TabIndex = 41;
            this.toolTipText.SetToolTip(this.cbNullContrat, "Cocher cette case permet de ne pas afficher ce contrat dans le rapport : ligue de" +
        " sécurité.");
            // 
            // cmdShowSeanceT
            // 
            this.cmdShowSeanceT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.cmdShowSeanceT.Image = ((System.Drawing.Image)(resources.GetObject("cmdShowSeanceT.Image")));
            this.cmdShowSeanceT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdShowSeanceT.Location = new System.Drawing.Point(534, 398);
            this.cmdShowSeanceT.Name = "cmdShowSeanceT";
            this.cmdShowSeanceT.Size = new System.Drawing.Size(104, 43);
            this.cmdShowSeanceT.TabIndex = 11;
            this.cmdShowSeanceT.TabStop = false;
            this.cmdShowSeanceT.Text = "Pratique";
            this.cmdShowSeanceT.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTipText.SetToolTip(this.cmdShowSeanceT, "Afficher les séances");
            this.cmdShowSeanceT.Click += new System.EventHandler(this.cmdShowSeance_Click);
            // 
            // cmdShowSeanceTheorique
            // 
            this.cmdShowSeanceTheorique.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.cmdShowSeanceTheorique.Image = global::Barette.Library.Properties.Resources.book_icon;
            this.cmdShowSeanceTheorique.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdShowSeanceTheorique.Location = new System.Drawing.Point(534, 353);
            this.cmdShowSeanceTheorique.Name = "cmdShowSeanceTheorique";
            this.cmdShowSeanceTheorique.Size = new System.Drawing.Size(104, 43);
            this.cmdShowSeanceTheorique.TabIndex = 10;
            this.cmdShowSeanceTheorique.TabStop = false;
            this.cmdShowSeanceTheorique.Text = "Théorique";
            this.cmdShowSeanceTheorique.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTipText.SetToolTip(this.cmdShowSeanceTheorique, "Afficher les séances");
            this.cmdShowSeanceTheorique.Click += new System.EventHandler(this.cmdShowSeanceTheorique_Click);
            // 
            // cmdAutoDateExpiration
            // 
            this.cmdAutoDateExpiration.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAutoDateExpiration.Location = new System.Drawing.Point(615, 33);
            this.cmdAutoDateExpiration.Name = "cmdAutoDateExpiration";
            this.cmdAutoDateExpiration.Size = new System.Drawing.Size(20, 20);
            this.cmdAutoDateExpiration.TabIndex = 47;
            this.toolTipText.SetToolTip(this.cmdAutoDateExpiration, "Ajoute 365 jour à la date d\'inscription");
            this.cmdAutoDateExpiration.Click += new System.EventHandler(this.cmdAutoDateExpiration_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(5, 61);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(84, 13);
            this.label24.TabIndex = 51;
            this.label24.Text = "Nº Attestation 2:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipText.SetToolTip(this.label24, "Nº Attestation de la Ligue de Sécurité");
            // 
            // cmdClearbox
            // 
            this.cmdClearbox.Enabled = false;
            this.cmdClearbox.Location = new System.Drawing.Point(189, 81);
            this.cmdClearbox.Name = "cmdClearbox";
            this.cmdClearbox.Size = new System.Drawing.Size(22, 20);
            this.cmdClearbox.TabIndex = 56;
            this.cmdClearbox.Text = "X";
            this.toolTipText.SetToolTip(this.cmdClearbox, "Supprimer du group");
            this.cmdClearbox.UseVisualStyleBackColor = true;
            this.cmdClearbox.Click += new System.EventHandler(this.cmdClearbox_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpBVA);
            this.groupBox3.Controls.Add(this.cbBVA);
            this.groupBox3.Controls.Add(this.cbMoto);
            this.groupBox3.Controls.Add(this.cbAuto);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.ctbLocationMontant);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(318, 442);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 88);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Location";
            // 
            // dtpBVA
            // 
            this.dtpBVA.CustomFormat = "ddd MM/dd/yyyy \'      Heure:\' HH:mm";
            this.dtpBVA.Enabled = false;
            this.dtpBVA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBVA.Location = new System.Drawing.Point(63, 23);
            this.dtpBVA.Name = "dtpBVA";
            this.dtpBVA.Size = new System.Drawing.Size(231, 20);
            this.dtpBVA.TabIndex = 2;
            // 
            // cbMoto
            // 
            this.cbMoto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbMoto.Location = new System.Drawing.Point(246, 51);
            this.cbMoto.Name = "cbMoto";
            this.cbMoto.Size = new System.Drawing.Size(48, 24);
            this.cbMoto.TabIndex = 5;
            this.cbMoto.Text = "Moto";
            // 
            // cbAuto
            // 
            this.cbAuto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbAuto.Location = new System.Drawing.Point(160, 51);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(80, 24);
            this.cbAuto.TabIndex = 4;
            this.cbAuto.Text = "Automobile";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Montant";
            // 
            // timerCheckClientValid
            // 
            this.timerCheckClientValid.Enabled = true;
            this.timerCheckClientValid.Tick += new System.EventHandler(this.timerCheckClientValid_Tick);
            // 
            // dtpDatePermis
            // 
            this.dtpDatePermis.CustomFormat = "dd MMMM yyyy";
            this.dtpDatePermis.Enabled = false;
            this.dtpDatePermis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatePermis.Location = new System.Drawing.Point(480, 16);
            this.dtpDatePermis.Name = "dtpDatePermis";
            this.dtpDatePermis.Size = new System.Drawing.Size(152, 20);
            this.dtpDatePermis.TabIndex = 3;
            this.dtpDatePermis.ValueChanged += new System.EventHandler(this.dtpDatePermis_ValueChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbPermisObtenue);
            this.groupBox6.Controls.Add(this.dtpDatePermisPlus8);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.pictureBox3);
            this.groupBox6.Controls.Add(this.txtNumeroPermis);
            this.groupBox6.Controls.Add(this.dtpDatePermis);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox6.Location = new System.Drawing.Point(0, 274);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(640, 72);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Permis de conduire";
            // 
            // cbPermisObtenue
            // 
            this.cbPermisObtenue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbPermisObtenue.Location = new System.Drawing.Point(462, 27);
            this.cbPermisObtenue.Name = "cbPermisObtenue";
            this.cbPermisObtenue.Size = new System.Drawing.Size(16, 24);
            this.cbPermisObtenue.TabIndex = 2;
            this.cbPermisObtenue.CheckedChanged += new System.EventHandler(this.cbPermisObtenue_CheckedChanged);
            // 
            // dtpDatePermisPlus8
            // 
            this.dtpDatePermisPlus8.CustomFormat = "dd MMMM yyyy";
            this.dtpDatePermisPlus8.Enabled = false;
            this.dtpDatePermisPlus8.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatePermisPlus8.Location = new System.Drawing.Point(480, 40);
            this.dtpDatePermisPlus8.Name = "dtpDatePermisPlus8";
            this.dtpDatePermisPlus8.Size = new System.Drawing.Size(152, 20);
            this.dtpDatePermisPlus8.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(288, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 16);
            this.label17.TabIndex = 29;
            this.label17.Text = "Date d\'obtention:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(288, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(159, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "Date min. de l’examen pratique :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(378, 37);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 13);
            this.label22.TabIndex = 43;
            this.label22.Text = "Expiration (contrat):";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateExpiration
            // 
            this.DateExpiration.Location = new System.Drawing.Point(488, 34);
            this.DateExpiration.Name = "DateExpiration";
            this.DateExpiration.Size = new System.Drawing.Size(128, 20);
            this.DateExpiration.TabIndex = 4;
            this.DateExpiration.Value = new System.DateTime(2015, 4, 11, 0, 0, 0, 0);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(378, 62);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(91, 13);
            this.label23.TabIndex = 45;
            this.label23.Text = "Début des cours :";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateDebutCours
            // 
            this.DateDebutCours.Location = new System.Drawing.Point(488, 60);
            this.DateDebutCours.Name = "DateDebutCours";
            this.DateDebutCours.Size = new System.Drawing.Size(128, 20);
            this.DateDebutCours.TabIndex = 5;
            this.DateDebutCours.Value = new System.DateTime(2015, 4, 11, 0, 0, 0, 0);
            // 
            // printDocContract
            // 
            this.printDocContract.DocumentName = "Contrat du client";
            this.printDocContract.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocContract_PrintPage);
            // 
            // txtNumeroAttestation
            // 
            this.txtNumeroAttestation.Location = new System.Drawing.Point(103, 34);
            this.txtNumeroAttestation.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.txtNumeroAttestation.Name = "txtNumeroAttestation";
            this.txtNumeroAttestation.SetRange = new System.Drawing.Size(0, 9999999);
            this.txtNumeroAttestation.ShortcutsEnabled = false;
            this.txtNumeroAttestation.Size = new System.Drawing.Size(80, 20);
            this.txtNumeroAttestation.TabIndex = 2;
            this.txtNumeroAttestation.Text = "0";
            this.txtNumeroAttestation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumeroAttestation.Value = 0;
            // 
            // txtNumeroContrat
            // 
            this.txtNumeroContrat.Location = new System.Drawing.Point(103, 9);
            this.txtNumeroContrat.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.txtNumeroContrat.Name = "txtNumeroContrat";
            this.txtNumeroContrat.SetRange = new System.Drawing.Size(0, 9999999);
            this.txtNumeroContrat.ShortcutsEnabled = false;
            this.txtNumeroContrat.Size = new System.Drawing.Size(80, 20);
            this.txtNumeroContrat.TabIndex = 1;
            this.txtNumeroContrat.Text = "0";
            this.txtNumeroContrat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumeroContrat.Value = 0;
            // 
            // txtNumeroAttestation2
            // 
            this.txtNumeroAttestation2.Location = new System.Drawing.Point(103, 58);
            this.txtNumeroAttestation2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.txtNumeroAttestation2.Name = "txtNumeroAttestation2";
            this.txtNumeroAttestation2.SetRange = new System.Drawing.Size(0, 9999999);
            this.txtNumeroAttestation2.ShortcutsEnabled = false;
            this.txtNumeroAttestation2.Size = new System.Drawing.Size(80, 20);
            this.txtNumeroAttestation2.TabIndex = 50;
            this.txtNumeroAttestation2.Text = "0";
            this.txtNumeroAttestation2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumeroAttestation2.Value = 0;
            // 
            // dtpAttestation2
            // 
            this.dtpAttestation2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAttestation2.Location = new System.Drawing.Point(187, 58);
            this.dtpAttestation2.Name = "dtpAttestation2";
            this.dtpAttestation2.Size = new System.Drawing.Size(95, 20);
            this.dtpAttestation2.TabIndex = 52;
            this.dtpAttestation2.Value = new System.DateTime(2015, 4, 11, 0, 0, 0, 0);
            // 
            // dtpAttestation1
            // 
            this.dtpAttestation1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAttestation1.Location = new System.Drawing.Point(187, 34);
            this.dtpAttestation1.Name = "dtpAttestation1";
            this.dtpAttestation1.Size = new System.Drawing.Size(95, 20);
            this.dtpAttestation1.TabIndex = 53;
            this.dtpAttestation1.Value = new System.DateTime(2015, 4, 11, 0, 0, 0, 0);
            // 
            // printDocTheorique
            // 
            this.printDocTheorique.DocumentName = "Fichier du client";
            this.printDocTheorique.OriginAtMargins = true;
            this.printDocTheorique.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocTheorique_PrintPage);
            // 
            // txtNumeroGroupe
            // 
            this.txtNumeroGroupe.Enabled = false;
            this.txtNumeroGroupe.Location = new System.Drawing.Point(103, 82);
            this.txtNumeroGroupe.Name = "txtNumeroGroupe";
            this.txtNumeroGroupe.SetRange = new System.Drawing.Size(0, 9999999);
            this.txtNumeroGroupe.ShortcutsEnabled = false;
            this.txtNumeroGroupe.Size = new System.Drawing.Size(80, 20);
            this.txtNumeroGroupe.TabIndex = 54;
            this.txtNumeroGroupe.Text = "0";
            this.txtNumeroGroupe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumeroGroupe.Value = 0;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 85);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 55;
            this.label25.Text = "Nº Groupe :";
            // 
            // EmailError
            // 
            this.EmailError.ContainerControl = this;
            // 
            // cmdShowSeancesMoto2015
            // 
            this.cmdShowSeancesMoto2015.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.cmdShowSeancesMoto2015.Image = global::Barette.Library.Properties.Resources.book_icon;
            this.cmdShowSeancesMoto2015.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdShowSeancesMoto2015.Location = new System.Drawing.Point(534, 353);
            this.cmdShowSeancesMoto2015.Name = "cmdShowSeancesMoto2015";
            this.cmdShowSeancesMoto2015.Size = new System.Drawing.Size(104, 88);
            this.cmdShowSeancesMoto2015.TabIndex = 57;
            this.cmdShowSeancesMoto2015.TabStop = false;
            this.cmdShowSeancesMoto2015.Text = "Séances ";
            this.cmdShowSeancesMoto2015.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolTipText.SetToolTip(this.cmdShowSeancesMoto2015, "Afficher les séances");
            this.cmdShowSeancesMoto2015.Click += new System.EventHandler(this.cmdShowSeancesMoto2015_Click);
            // 
            // ctbTauxHorairePratique
            // 
            this.ctbTauxHorairePratique.BackColor = System.Drawing.SystemColors.Window;
            this.ctbTauxHorairePratique.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.ctbTauxHorairePratique.Location = new System.Drawing.Point(584, 415);
            this.ctbTauxHorairePratique.Name = "ctbTauxHorairePratique";
            this.ctbTauxHorairePratique.Size = new System.Drawing.Size(48, 18);
            this.ctbTauxHorairePratique.TabIndex = 49;
            this.ctbTauxHorairePratique.Text = "0 $";
            this.ctbTauxHorairePratique.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTipText.SetToolTip(this.ctbTauxHorairePratique, "Taux horaire pour les cours pratique");
            // 
            // ctbTauxHoraireTheorique
            // 
            this.ctbTauxHoraireTheorique.BackColor = System.Drawing.SystemColors.Window;
            this.ctbTauxHoraireTheorique.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctbTauxHoraireTheorique.Location = new System.Drawing.Point(584, 371);
            this.ctbTauxHoraireTheorique.Name = "ctbTauxHoraireTheorique";
            this.ctbTauxHoraireTheorique.Size = new System.Drawing.Size(48, 18);
            this.ctbTauxHoraireTheorique.TabIndex = 48;
            this.ctbTauxHoraireTheorique.Text = "0 $";
            this.ctbTauxHoraireTheorique.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTipText.SetToolTip(this.ctbTauxHoraireTheorique, "Taux horaire pour les cours théorique");
            // 
            // ctbLocationMontant
            // 
            this.ctbLocationMontant.BackColor = System.Drawing.SystemColors.Window;
            this.ctbLocationMontant.Location = new System.Drawing.Point(63, 56);
            this.ctbLocationMontant.Name = "ctbLocationMontant";
            this.ctbLocationMontant.Size = new System.Drawing.Size(54, 20);
            this.ctbLocationMontant.TabIndex = 3;
            this.ctbLocationMontant.Text = "0 $";
            this.ctbLocationMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctbLocationMontant.Leave += new System.EventHandler(this.ctbLocationMontant_Leave);
            // 
            // CashBox_Solde
            // 
            this.CashBox_Solde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CashBox_Solde.Location = new System.Drawing.Point(154, 23);
            this.CashBox_Solde.Name = "CashBox_Solde";
            this.CashBox_Solde.ReadOnly = true;
            this.CashBox_Solde.Size = new System.Drawing.Size(64, 20);
            this.CashBox_Solde.TabIndex = 1;
            this.CashBox_Solde.Text = "0 $";
            this.CashBox_Solde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNotes.Location = new System.Drawing.Point(46, 16);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlainText = "";
            this.txtNotes.RTFCode = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3084{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
    "ans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.txtNotes.RTFTextChanged = true;
            this.txtNotes.Size = new System.Drawing.Size(591, 155);
            this.txtNotes.TabIndex = 15;
            // 
            // cbCity
            // 
            this.cbCity.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "Abercorn",
            "Acton Vale",
            "Adstock",
            "Aguanish",
            "Akulivik",
            "Akwesasne",
            "Albanel",
            "Albertville",
            "Alleyn-et-Cawood",
            "Alma",
            "Amherst",
            "Amos",
            "Amqui",
            "Ange-Gardien",
            "Angliers",
            "Armagh",
            "Arundel",
            "Asbestos",
            "Ascot Corner",
            "Aston-Jonction",
            "Auclair",
            "Audet",
            "Aumond",
            "Aupaluk",
            "Austin",
            "Authier",
            "Authier-Nord",
            "Ayer\'s Cliff",
            "Baie-Comeau",
            "Baie-de-la-Bouteille",
            "Baie-des-Sables",
            "Baie-du-Febvre",
            "Baie-D\'Urfé",
            "Baie-James",
            "Baie-Johan-Beetz",
            "Baie-Sainte-Catherine",
            "Baie-Saint-Paul",
            "Baie-Trinité",
            "Barkmere",
            "Barnston-Ouest",
            "Barraute",
            "Batiscan",
            "Beaconsfield",
            "Béarn",
            "Beauceville",
            "Beauharnois",
            "Beaulac-Garthby",
            "Beaumont",
            "Beaupré",
            "Bécancour",
            "Bedford",
            "Bégin",
            "Belcourt",
            "Belleterre",
            "Beloeil",
            "Berry",
            "Berthier-sur-Mer",
            "Berthierville",
            "Béthanie",
            "Betsiamites",
            "Biencourt",
            "Blainville",
            "Blanc-Sablon",
            "Blue Sea",
            "Boileau",
            "Boisbriand",
            "Boischatel",
            "Bois-des-Filion",
            "Bois-Franc",
            "Bolton-Est",
            "Bolton-Ouest",
            "Bonaventure",
            "Bonne-Espérance",
            "Bonsecours",
            "Boucherville",
            "Bouchette",
            "Bowman",
            "Brébeuf",
            "Brigham",
            "Bristol",
            "Brome",
            "Bromont",
            "Brossard",
            "Brownsburg-Chatham",
            "Bryson",
            "Bury",
            "Cabano",
            "Cacouna",
            "Calixa-Lavallée",
            "Campbell\'s Bay",
            "Candiac",
            "Cantley",
            "Canton-Tremblay",
            "Cap-Chat",
            "Caplan",
            "Cap-Saint-Ignace",
            "Cap-Santé",
            "Carignan",
            "Carleton-sur-Mer",
            "Cascapédia–Saint-Jules",
            "Causapscal",
            "Cayamant",
            "Chambly",
            "Chambord",
            "Champlain",
            "Champneuf",
            "Chandler",
            "Chapais",
            "Charlemagne",
            "Charrette",
            "Chartierville",
            "Châteauguay",
            "Château-Richer",
            "Chazel",
            "Chelsea",
            "Chénéville",
            "Chertsey",
            "Chester-Est",
            "Chesterville",
            "Chibougamau",
            "Chichester",
            "Chicoutimi",
            "Chicoutimi-Nord",
            "Chisasibi",
            "Chute-aux-Outardes",
            "Chute-Des-Passes",
            "Chute-Saint-Philippe",
            "Clarendon",
            "Clermont",
            "Clermont",
            "Clerval",
            "Cleveland",
            "Cloridorme",
            "Coaticook",
            "Colombier",
            "Compton",
            "Contrecoeur",
            "Cookshire-Eaton",
            "Coteau-du-Lac",
            "Côte-Nord-du-Golfe-du-Saint-Laurent",
            "Côte-Saint-Luc",
            "Courcelles",
            "Cowansville",
            "Crabtree",
            "Danville",
            "Daveluyville",
            "Dégelis",
            "Déléage",
            "Delson",
            "Denholm",
            "Desbiens",
            "Deschaillons-sur-Saint-Laurent",
            "Deschambault-Grondines",
            "Deux-Montagnes",
            "Disraeli",
            "Dixville",
            "Dolbeau",
            "Dollard-Des Ormeaux",
            "Doncaster",
            "Donnacona",
            "Dorval",
            "Dosquet",
            "Drummondville",
            "Dudswell",
            "Duhamel",
            "Duhamel-Ouest",
            "Dundee",
            "Dunham",
            "Duparquet",
            "Dupuy",
            "Durham-Sud",
            "East Angus",
            "East Broughton",
            "East Farnham",
            "East Hereford",
            "Eastmain",
            "Eastman",
            "Egan-Sud",
            "Elgin",
            "Entrelacs",
            "Escuminac",
            "Esprit-Saint",
            "Essipit",
            "Estérel",
            "Farnham",
            "Fassett",
            "Ferland-et-Boilleau",
            "Ferme-Neuve",
            "Fermont",
            "Forestville",
            "Fort-Coulonge",
            "Fortierville",
            "Fossambault-sur-le-Lac",
            "Frampton",
            "Franklin",
            "Franquelin",
            "Frelighsburg",
            "Frontenac",
            "Fugèreville",
            "Gallichan",
            "Gaspé",
            "Gatineau",
            "Gesgapegiag",
            "Girardville",
            "Godbout",
            "Godmanchester",
            "Gore",
            "Gracefield",
            "Granby",
            "Grand-Calumet",
            "Grande-Rivière",
            "Grandes-Piles",
            "Grande-Vallée",
            "Grand-Métis",
            "Grand-Remous",
            "Grand-Saint-Esprit",
            "Grenville",
            "Grenville-sur-la-Rouge",
            "Gros-Mécatina",
            "Grosse-Île",
            "Grosses-Roches",
            "Guérin",
            "Ham-Nord",
            "Hampden",
            "Hampstead",
            "Harrington",
            "Hatley",
            "Havelock",
            "Havre-Saint-Pierre",
            "Hébertville",
            "Hébertville-Station",
            "Hemmingford",
            "Henryville",
            "Hérouxville",
            "Hinchinbrooke",
            "Honfleur",
            "Hope",
            "Hope Town",
            "Howick",
            "Huberdeau",
            "Hudson",
            "Huntingdon",
            "Inukjuak",
            "Inverness",
            "Irlande",
            "Ivry-sur-le-Lac",
            "Ivujivik",
            "Joliette",
            "Jonquière",
            "Kahnawake",
            "Kamouraska",
            "Kangiqsualujjuaq",
            "Kangiqsujuaq",
            "Kangirsuk",
            "Kawawachikamach",
            "Kazabazua",
            "Kebaowek",
            "Kiamika",
            "Kingsbury",
            "Kingsey Falls",
            "Kinnear\'s Mills",
            "Kipawa",
            "Kirkland",
            "Kitigan Zibi",
            "Kuujjuaq",
            "Kuujjuarapik",
            "La Baie",
            "La Bostonnais",
            "La Conception",
            "La Corne",
            "La Doré",
            "La Durantaye",
            "La Guadeloupe",
            "La Macaza",
            "La Malbaie",
            "La Martre",
            "La Minerve",
            "La Morandière",
            "La Motte",
            "La Patrie",
            "La Pêche",
            "La Pocatière",
            "La Prairie",
            "La Présentation",
            "La Rédemption",
            "La Reine",
            "La Romaine",
            "La Sarre",
            "La Trinité-des-Monts",
            "La Tuque",
            "La Visitation-de-l\'Île-Dupas",
            "La Visitation-de-Yamaska",
            "Labelle",
            "Labrecque",
            "Lac-Ashuapmushuan",
            "Lac-au-Brochet",
            "Lac-au-Saumon",
            "Lac-aux-Sables",
            "Lac-Beauport",
            "Lac-Bouchette",
            "Lac-Brome",
            "Lac-Casault",
            "Lac-Chicobi",
            "Lac-Delage",
            "Lac-des-Aigles",
            "Lac-des-Écorces",
            "Lac-Despinassy",
            "Lac-des-Plages",
            "Lac-des-Seize-Îles",
            "Lac-Devenyns",
            "Lac-Drolet",
            "Lac-du-Cerf",
            "Lac-Édouard",
            "Lac-Etchemin",
            "Lac-Fouillac",
            "Lac-Frontière",
            "Lac-Granet",
            "Lachute",
            "Lac-John",
            "Lac-Masketsi",
            "Lac-Matapédia",
            "Lac-Matawin",
            "Lac-Mégantic",
            "Lac-Nilgaut",
            "Lacolle",
            "Lac-Pikauba",
            "Lac-Poulin",
            "Lac-Pythonga",
            "Lac-Rapide",
            "Lac-Saguay",
            "Lac-Sainte-Marie",
            "Lac-Saint-Joseph",
            "Lac-Saint-Paul",
            "Lac-Sergent",
            "Lac-Simon",
            "Lac-Simon",
            "Lac-Supérieur",
            "Lac-Tremblant-Nord",
            "Lac-Walker",
            "Laforce",
            "Lamarche",
            "Lambton",
            "L\'Ancienne-Lorette",
            "Landrienne",
            "L\'Ange-Gardien",
            "L\'Ange-Gardien",
            "Laniel",
            "Lanoraie",
            "L\'Anse-Saint-Jean",
            "Lantier",
            "Larouche",
            "L\'Ascension",
            "L\'Ascension-de-Notre-Seigneur",
            "L\'Ascension-de-Patapédia",
            "L\'Assomption",
            "Laterrière",
            "Latulipe-et-Gaboury",
            "Launay",
            "Laurier-Station",
            "Laurierville",
            "Laval",
            "Lavaltrie",
            "L\'Avenir",
            "Laverlochère",
            "Lawrenceville",
            "Le Bic",
            "Lebel-sur-Quévillon",
            "Leclercville",
            "Lefebvre",
            "Lejeune",
            "Lemieux",
            "L\'Épiphanie",
            "Léry",
            "Les Bergeronnes",
            "Les Cèdres",
            "Les Coteaux",
            "Les Éboulements",
            "Les Escoumins",
            "Les Hauteurs",
            "Les Îles-de-la-Madeleine",
            "Les Méchins",
            "Lévis",
            "L\'Île-Cadieux",
            "L\'Île-d\'Anticosti",
            "L\'Île-Dorval",
            "L\'Île-Perrot",
            "Lingwick",
            "Linton",
            "L\'Isle-aux-Allumettes",
            "L\'Isle-aux-Coudres",
            "L\'Islet",
            "L\'Isle-Verte",
            "Listuguj",
            "Litchfield",
            "Lochaber",
            "Lochaber-Partie-Ouest",
            "Longue-Pointe-de-Mingan",
            "Longue-Rive",
            "Longueuil",
            "Lorraine",
            "Lorrainville",
            "Lotbinière",
            "Louiseville",
            "Low",
            "Lyster",
            "Macamic",
            "Maddington",
            "Magog",
            "Malartic",
            "Maliotenam",
            "Manawan",
            "Mandeville",
            "Maniwaki",
            "Manseau",
            "Mansfield-et-Pontefract",
            "Maria",
            "Maricourt",
            "Marieville",
            "Marsoui",
            "Marston",
            "Martinville",
            "Mascouche",
            "Mashteuiatsh",
            "Maskinongé",
            "Massueville",
            "Matagami",
            "Matane",
            "Matapédia",
            "Matchi-Manitou",
            "Matimekosh",
            "Mayo",
            "McMasterville",
            "Melbourne",
            "Mercier",
            "Messines",
            "Métabetchouan–Lac-à-la-Croix",
            "Métis-sur-Mer",
            "Milan",
            "Mille-Isles",
            "Mingan",
            "Mirabel",
            "Mistissini",
            "Moffet",
            "Mont-Albert",
            "Montcalm",
            "Mont-Carmel",
            "Montcerf-Lytton",
            "Montebello",
            "Mont-Élie",
            "Mont-Joli",
            "Mont-Laurier",
            "Montmagny",
            "Montpellier",
            "Montréal",
            "Montréal-Est",
            "Montréal-Ouest",
            "Mont-Royal",
            "Mont-Saint-Grégoire",
            "Mont-Saint-Hilaire",
            "Mont-Saint-Michel",
            "Mont-Saint-Pierre",
            "Mont-Tremblant",
            "Mont-Valin",
            "Morin-Heights",
            "Mulgrave-et-Derry",
            "Murdochville",
            "Namur",
            "Nantes",
            "Napierville",
            "Natashquan",
            "Natashquan",
            "Nédélec",
            "Nemiscau",
            "Neuville",
            "New Carlisle",
            "New Richmond",
            "Newport",
            "Nicolet",
            "Nominingue",
            "Norbertville",
            "Normandin",
            "Normétal",
            "North Hatley",
            "Notre-Dame-Auxiliatrice-de-Buckland",
            "Notre-Dame-de-Bonsecours",
            "Notre-Dame-de-Ham",
            "Notre-Dame-de-la-Merci",
            "Notre-Dame-de-la-Paix",
            "Notre-Dame-de-la-Salette",
            "Notre-Dame-de-l\'Île-Perrot",
            "Notre-Dame-de-Lorette",
            "Notre-Dame-de-Lourdes",
            "Notre-Dame-de-Lourdes",
            "Notre-Dame-de-Montauban",
            "Notre-Dame-de-Pontmain",
            "Notre-Dame-des-Anges",
            "Notre-Dame-des-Bois",
            "Notre-Dame-des-Monts",
            "Notre-Dame-des-Neiges",
            "Notre-Dame-des-Pins",
            "Notre-Dame-des-Prairies",
            "Notre-Dame-des-Sept-Douleurs",
            "Notre-Dame-de-Stanbridge",
            "Notre-Dame-du-Bon-Conseil",
            "Notre-Dame-du-Lac",
            "Notre-Dame-du-Laus",
            "Notre-Dame-du-Mont-Carmel",
            "Notre-Dame-du-Nord",
            "Notre-Dame-du-Portage",
            "Notre-Dame-du-Rosaire",
            "Notre-Dame-du-Sacré-Coeur-d\'Issoudun",
            "Nouvelle",
            "Noyan",
            "Obedjiwan",
            "Odanak",
            "Ogden",
            "Oka",
            "Orford",
            "Ormstown",
            "Otter Lake",
            "Otterburn Park",
            "Packington",
            "Padoue",
            "Palmarolle",
            "Papineauville",
            "Parisville",
            "Paspébiac",
            "Percé",
            "Péribonka",
            "Petite-Rivière-Saint-François",
            "Petite-Vallée",
            "Petit-Saguenay",
            "Picard",
            "Piedmont",
            "Pierreville",
            "Pikogan",
            "Pincourt",
            "Piopolis",
            "Plaisance",
            "Plessisville",
            "Pohénégamook",
            "Pointe-à-la-Croix",
            "Pointe-aux-Outardes",
            "Pointe-Calumet",
            "Pointe-Claire",
            "Pointe-des-Cascades",
            "Pointe-Fortune",
            "Pointe-Lebel",
            "Pontiac",
            "Pont-Rouge",
            "Portage-du-Fort",
            "Port-Cartier",
            "Port-Daniel–Gascons",
            "Portneuf",
            "Portneuf-sur-Mer",
            "Potton",
            "Poularies",
            "Preissac",
            "Prévost",
            "Price",
            "Princeville",
            "Puvirnituq",
            "Quaqtaq",
            "Québec",
            "Racine",
            "Ragueneau",
            "Rapide-Danseur",
            "Rapides-des-Joachims",
            "Rawdon",
            "Rémigny",
            "Repentigny",
            "Réservoir-Dozois",
            "Richelieu",
            "Richmond",
            "Rigaud",
            "Rimouski",
            "Ripon",
            "Ristigouche-Partie-Sud-Est",
            "Rivière-à-Claude",
            "Rivière-à-Pierre",
            "Rivière-au-Tonnerre",
            "Rivière-aux-Outardes",
            "Rivière-Beaudette",
            "Rivière-Bleue",
            "Rivière-du-Loup",
            "Rivière-Éternité",
            "Rivière-Héva",
            "Rivière-Mistassini",
            "Rivière-Ojima",
            "Rivière-Ouelle",
            "Rivière-Rouge",
            "Rivière-Saint-Jean",
            "Roberval",
            "Rochebaucourt",
            "Roquemaure",
            "Rosemère",
            "Rougemont",
            "Routhierville",
            "Rouyn-Noranda",
            "Roxton",
            "Roxton Falls",
            "Roxton Pond",
            "Sacré-Cœur",
            "Sacré-Coeur-de-Jésus",
            "Sagard",
            "Saint-Adalbert",
            "Saint-Adelme",
            "Saint-Adelphe",
            "Saint-Adolphe-d\'Howard",
            "Saint-Adrien",
            "Saint-Adrien-d\'Irlande",
            "Saint-Agapit",
            "Saint-Aimé",
            "Saint-Aimé-des-Lacs",
            "Saint-Aimé-du-Lac-des-Îles",
            "Saint-Alban",
            "Saint-Albert",
            "Saint-Alexandre",
            "Saint-Alexandre-de-Kamouraska",
            "Saint-Alexandre-des-Lacs",
            "Saint-Alexis",
            "Saint-Alexis-de-Matapédia",
            "Saint-Alexis-des-Monts",
            "Saint-Alfred",
            "Saint-Alphonse",
            "Saint-Alphonse",
            "Saint-Alphonse-Rodrigue",
            "Saint-Amable",
            "Saint-Ambroise",
            "Saint-Ambroise-de-Kildare",
            "Saint-Anaclet-de-Lessard",
            "Saint-André",
            "Saint-André-Avellin",
            "Saint-André-d\'Argenteuil",
            "Saint-André-de-Restigouche",
            "Saint-André-du-Lac-Saint-Jean",
            "Saint-Anicet",
            "Saint-Anselme",
            "Saint-Antoine-de-l\'Isle-aux-Grues",
            "Saint-Antoine-de-Tilly",
            "Saint-Antoine-sur-Richelieu",
            "Saint-Antonin",
            "Saint-Apollinaire",
            "Saint-Armand",
            "Saint-Arsène",
            "Saint-Athanase",
            "Saint-Aubert",
            "Saint-Augustin",
            "Saint-Augustin",
            "Saint-Augustin-de-Desmaures",
            "Saint-Augustin-de-Woburn",
            "Saint-Barnabé",
            "Saint-Barnabé-Sud",
            "Saint-Barthélemy",
            "Saint-Basile",
            "Saint-Basile-le-Grand",
            "Saint-Benjamin",
            "Saint-Benoît-du-Lac",
            "Saint-Benoît-Labre",
            "Saint-Bernard",
            "Saint-Bernard-de-Lacolle",
            "Saint-Bernard-de-Michaudville",
            "Saint-Blaise-sur-Richelieu",
            "Saint-Bonaventure",
            "Saint-Boniface",
            "Saint-Bruno",
            "Saint-Bruno-de-Guigues",
            "Saint-Bruno-de-Kamouraska",
            "Saint-Bruno-de-Montarville",
            "Saint-Calixte",
            "Saint-Camille",
            "Saint-Camille-de-Lellis",
            "Saint-Casimir",
            "Saint-Célestin",
            "Saint-Césaire",
            "Saint-Charles-Borromée",
            "Saint-Charles-de-Bellechasse",
            "Saint-Charles-de-Bourget",
            "Saint-Charles-Garnier",
            "Saint-Charles-sur-Richelieu",
            "Saint-Christophe-d\'Arthabaska",
            "Saint-Chrysostome",
            "Saint-Claude",
            "Saint-Clément",
            "Saint-Cléophas",
            "Saint-Cléophas-de-Brandon",
            "Saint-Clet",
            "Saint-Colomban",
            "Saint-Côme",
            "Saint-Côme–Linière",
            "Saint-Constant",
            "Saint-Cuthbert",
            "Saint-Cyprien",
            "Saint-Cyprien",
            "Saint-Cyprien-de-Napierville",
            "Saint-Cyrille-de-Lessard",
            "Saint-Cyrille-de-Wendover",
            "Saint-Damase",
            "Saint-Damase",
            "Saint-Damase-de-L\'Islet",
            "Saint-Damien",
            "Saint-Damien-de-Buckland",
            "Saint-David",
            "Saint-David-de-Falardeau",
            "Saint-Denis",
            "Saint-Denis-de-Brompton",
            "Saint-Denis-sur-Richelieu",
            "Saint-Didace",
            "Saint-Dominique",
            "Saint-Dominique-du-Rosaire",
            "Saint-Donat",
            "Saint-Donat",
            "Sainte-Adèle",
            "Sainte-Agathe-de-Lotbinière",
            "Sainte-Agathe-des-Monts",
            "Sainte-Angèle-de-Mérici",
            "Sainte-Angèle-de-Monnoir",
            "Sainte-Angèle-de-Prémont",
            "Sainte-Anne-de-Beaupré",
            "Sainte-Anne-de-Bellevue",
            "Sainte-Anne-de-la-Pérade",
            "Sainte-Anne-de-la-Pocatière",
            "Sainte-Anne-de-la-Rochelle",
            "Sainte-Anne-de-Sabrevois",
            "Sainte-Anne-des-Lacs",
            "Sainte-Anne-des-Monts",
            "Sainte-Anne-de-Sorel",
            "Sainte-Anne-des-Plaines",
            "Sainte-Anne-du-Lac",
            "Sainte-Anne-du-Sault",
            "Sainte-Apolline-de-Patton",
            "Sainte-Aurélie",
            "Sainte-Barbe",
            "Sainte-Béatrix",
            "Sainte-Brigide-d\'Iberville",
            "Sainte-Brigitte-de-Laval",
            "Sainte-Brigitte-des-Saults",
            "Sainte-Catherine",
            "Sainte-Catherine-de-Hatley",
            "Sainte-Catherine-de-la-Jacques-Cartier",
            "Sainte-Cécile-de-Lévrard",
            "Sainte-Cécile-de-Milton",
            "Sainte-Cécile-de-Whitton",
            "Sainte-Christine",
            "Sainte-Christine-d\'Auvergne",
            "Sainte-Claire",
            "Sainte-Clotilde-de-Beauce",
            "Sainte-Clotilde-de-Châteauguay",
            "Sainte-Clotilde-de-Horton",
            "Sainte-Croix",
            "Saint-Edmond-de-Grantham",
            "Saint-Edmond-les-Plaines",
            "Saint-Édouard",
            "Saint-Édouard-de-Fabre",
            "Saint-Édouard-de-Lotbinière",
            "Saint-Édouard-de-Maskinongé",
            "Sainte-Edwidge-de-Clifton",
            "Sainte-Élisabeth",
            "Sainte-Élisabeth-de-Warwick",
            "Sainte-Émélie-de-l\'Énergie",
            "Sainte-Eulalie",
            "Sainte-Euphémie-sur-Rivière-du-Sud",
            "Sainte-Famille",
            "Sainte-Félicité",
            "Sainte-Félicité",
            "Sainte-Flavie",
            "Sainte-Florence",
            "Sainte-Françoise",
            "Sainte-Françoise",
            "Sainte-Geneviève-de-Batiscan",
            "Sainte-Geneviève-de-Berthier",
            "Sainte-Germaine-Boulé",
            "Sainte-Gertrude-Manneville",
            "Sainte-Hedwidge",
            "Sainte-Hélène",
            "Sainte-Hélène-de-Bagot",
            "Sainte-Hélène-de-Mancebourg",
            "Sainte-Hénédine",
            "Sainte-Irène",
            "Sainte-Jeanne-d\'Arc",
            "Sainte-Jeanne-d\'Arc",
            "Sainte-Julie",
            "Sainte-Julienne",
            "Sainte-Justine",
            "Sainte-Justine-de-Newton",
            "Saint-Élie-de-Caxton",
            "Saint-Éloi",
            "Sainte-Louise",
            "Saint-Elphège",
            "Sainte-Luce",
            "Sainte-Lucie-de-Beauregard",
            "Sainte-Lucie-des-Laurentides",
            "Saint-Elzéar",
            "Saint-Elzéar",
            "Saint-Elzéar-de-Témiscouata",
            "Sainte-Madeleine",
            "Sainte-Madeleine-de-la-Rivière-Madeleine",
            "Sainte-Marcelline-de-Kildare",
            "Sainte-Marguerite",
            "Sainte-Marguerite",
            "Sainte-Marguerite-du-Lac-Masson",
            "Sainte-Marie",
            "Sainte-Marie-de-Blandford",
            "Sainte-Marie-Madeleine",
            "Sainte-Marie-Salomé",
            "Sainte-Marthe",
            "Sainte-Marthe-sur-le-Lac",
            "Sainte-Martine",
            "Sainte-Mélanie",
            "Saint-Émile-de-Suffolk",
            "Sainte-Monique",
            "Sainte-Monique",
            "Sainte-Paule",
            "Sainte-Perpétue",
            "Sainte-Perpétue",
            "Sainte-Pétronille",
            "Saint-Éphrem-de-Beauce",
            "Saint-Épiphane",
            "Sainte-Praxède",
            "Sainte-Rita",
            "Sainte-Rose-de-Watford",
            "Sainte-Rose-du-Nord",
            "Sainte-Sabine",
            "Sainte-Sabine",
            "Sainte-Séraphine",
            "Sainte-Sophie",
            "Sainte-Sophie-de-Lévrard",
            "Sainte-Sophie-d\'Halifax",
            "Saint-Esprit",
            "Sainte-Thècle",
            "Sainte-Thérèse",
            "Sainte-Thérèse-de-Gaspé",
            "Sainte-Thérèse-de-la-Gatineau",
            "Saint-Étienne-de-Beauharnois",
            "Saint-Étienne-de-Bolton",
            "Saint-Étienne-des-Grès",
            "Saint-Eugène",
            "Saint-Eugène-de-Guigues",
            "Saint-Eugène-de-Ladrière",
            "Saint-Eugènes",
            "Sainte-Ursule",
            "Saint-Eusèbe",
            "Saint-Eustache",
            "Saint-Évariste-de-Forsyth",
            "Sainte-Victoire-de-Sorel",
            "Saint-Fabien",
            "Saint-Fabien-de-Panet",
            "Saint-Faustin–Lac-Carré",
            "Saint-Félicien",
            "Saint-Félix-de-Dalquier",
            "Saint-Félix-de-Kingsey",
            "Saint-Félix-de-Valois",
            "Saint-Félix-d\'Otis",
            "Saint-Ferdinand",
            "Saint-Ferréol-les-Neiges",
            "Saint-Flavien",
            "Saint-Fortunat",
            "Saint-François-d\'Assise",
            "Saint-François-de-la-Rivière-du-Sud",
            "Saint-François-de-l\'Île-d\'Orléans",
            "Saint-François-de-Sales",
            "Saint-François-du-Lac",
            "Saint-François-Xavier-de-Brompton",
            "Saint-François-Xavier-de-Viger",
            "Saint-Frédéric",
            "Saint-Fulgence",
            "Saint-Gabriel",
            "Saint-Gabriel-de-Brandon",
            "Saint-Gabriel-de-Rimouski",
            "Saint-Gabriel-de-Valcartier",
            "Saint-Gabriel-Lalemant",
            "Saint-Gédéon",
            "Saint-Gédéon-de-Beauce",
            "Saint-Georges",
            "Saint-Georges-de-Clarenceville",
            "Saint-Georges-de-Windsor",
            "Saint-Gérard-Majella",
            "Saint-Germain",
            "Saint-Germain-de-Grantham",
            "Saint-Gervais",
            "Saint-Gilbert",
            "Saint-Gilles",
            "Saint-Godefroi",
            "Saint-Guillaume",
            "Saint-Guillaume-Nord",
            "Saint-Guy",
            "Saint-Henri",
            "Saint-Henri-de-Taillon",
            "Saint-Herménégilde",
            "Saint-Hilaire-de-Dorset",
            "Saint-Hilarion",
            "Saint-Hippolyte",
            "Saint-Honoré-de-Chicoutimi",
            "Saint-Honoré-de-Shenley",
            "Saint-Honoré-de-Témiscouata",
            "Saint-Hubert-de-Rivière-du-Loup",
            "Saint-Hugues",
            "Saint-Hyacinthe",
            "Saint-Ignace-de-Loyola",
            "Saint-Ignace-de-Stanbridge",
            "Saint-Irénée",
            "Saint-Isidore",
            "Saint-Isidore",
            "Saint-Isidore-de-Clifton",
            "Saint-Jacques",
            "Saint-Jacques-de-Leeds",
            "Saint-Jacques-le-Majeur-de-Wolfestown",
            "Saint-Jacques-le-Mineur",
            "Saint-Janvier-de-Joly",
            "Saint-Jean-Baptiste",
            "Saint-Jean-de-Brébeuf",
            "Saint-Jean-de-Cherbourg",
            "Saint-Jean-de-Dieu",
            "Saint-Jean-de-la-Lande",
            "Saint-Jean-de-l\'Île-d\'Orléans",
            "Saint-Jean-de-Matha",
            "Saint-Jean-Port-Joli",
            "Saint-Jean-sur-Richelieu",
            "Saint-Jérôme",
            "Saint-Joachim",
            "Saint-Joachim-de-Shefford",
            "Saint-Joseph-de-Beauce",
            "Saint-Joseph-de-Coleraine",
            "Saint-Joseph-de-Ham-Sud",
            "Saint-Joseph-de-Kamouraska",
            "Saint-Joseph-de-Lepage",
            "Saint-Joseph-des-Érables",
            "Saint-Joseph-de-Sorel",
            "Saint-Joseph-du-Lac",
            "Saint-Jude",
            "Saint-Jules",
            "Saint-Julien",
            "Saint-Just-de-Bretenières",
            "Saint-Juste-du-Lac",
            "Saint-Justin",
            "Saint-Lambert",
            "Saint-Lambert",
            "Saint-Lambert-de-Lauzon",
            "Saint-Laurent-de-l\'Île-d\'Orléans",
            "Saint-Lazare",
            "Saint-Lazare-de-Bellechasse",
            "Saint-Léandre",
            "Saint-Léonard-d\'Aston",
            "Saint-Léonard-de-Portneuf",
            "Saint-Léon-de-Standon",
            "Saint-Léon-le-Grand",
            "Saint-Léon-le-Grand",
            "Saint-Liboire",
            "Saint-Liguori",
            "Saint-Lin–Laurentides",
            "Saint-Louis",
            "Saint-Louis-de-Blandford",
            "Saint-Louis-de-Gonzague",
            "Saint-Louis-de-Gonzague",
            "Saint-Louis-de-Gonzague-du-Cap-Tourmente",
            "Saint-Louis-du-Ha! Ha!",
            "Saint-Luc-de-Bellechasse",
            "Saint-Luc-de-Vincennes",
            "Saint-Lucien",
            "Saint-Ludger",
            "Saint-Ludger-de-Milot",
            "Saint-Magloire",
            "Saint-Majorique-de-Grantham",
            "Saint-Malachie",
            "Saint-Malo",
            "Saint-Marc-de-Figuery",
            "Saint-Marc-des-Carrières",
            "Saint-Marc-du-Lac-Long",
            "Saint-Marcel",
            "Saint-Marcel-de-Richelieu",
            "Saint-Marcellin",
            "Saint-Marc-sur-Richelieu",
            "Saint-Martin",
            "Saint-Mathias-sur-Richelieu",
            "Saint-Mathieu",
            "Saint-Mathieu-de-Beloeil",
            "Saint-Mathieu-de-Rioux",
            "Saint-Mathieu-d\'Harricana",
            "Saint-Mathieu-du-Parc",
            "Saint-Maurice",
            "Saint-Maxime-du-Mont-Louis",
            "Saint-Médard",
            "Saint-Michel",
            "Saint-Michel-de-Bellechasse",
            "Saint-Michel-des-Saints",
            "Saint-Michel-du-Squatec",
            "Saint-Modeste",
            "Saint-Moïse",
            "Saint-Narcisse",
            "Saint-Narcisse-de-Beaurivage",
            "Saint-Narcisse-de-Rimouski",
            "Saint-Nazaire",
            "Saint-Nazaire-d\'Acton",
            "Saint-Nazaire-de-Dorchester",
            "Saint-Nérée",
            "Saint-Noël",
            "Saint-Norbert",
            "Saint-Norbert-d\'Arthabaska",
            "Saint-Octave-de-Métis",
            "Saint-Odilon-de-Cranbourne",
            "Saint-Omer",
            "Saint-Onésime-d\'Ixworth",
            "Saint-Ours",
            "Saint-Pacôme",
            "Saint-Pamphile",
            "Saint-Pascal",
            "Saint-Patrice-de-Beaurivage",
            "Saint-Patrice-de-Sherrington",
            "Saint-Paul",
            "Saint-Paul-d\'Abbotsford",
            "Saint-Paul-de-la-Croix",
            "Saint-Paul-de-l\'Île-aux-Noix",
            "Saint-Paul-de-Montminy",
            "Saint-Paulin",
            "Saint-Philémon",
            "Saint-Philibert",
            "Saint-Philippe",
            "Saint-Philippe-de-Néri",
            "Saint-Pie",
            "Saint-Pie-de-Guire",
            "Saint-Pierre",
            "Saint-Pierre-Baptiste",
            "Saint-Pierre-de-Broughton",
            "Saint-Pierre-de-Lamy",
            "Saint-Pierre-de-la-Rivière-du-Sud",
            "Saint-Pierre-de-l\'Île-d\'Orléans",
            "Saint-Pierre-de-Véronne-à-Pike-River",
            "Saint-Pierre-les-Becquets",
            "Saint-Placide",
            "Saint-Polycarpe",
            "Saint-Prime",
            "Saint-Prosper",
            "Saint-Prosper",
            "Saint-Raphaël",
            "Saint-Raymond",
            "Saint-Rémi",
            "Saint-Rémi-de-Tingwick",
            "Saint-René",
            "Saint-René-de-Matane",
            "Saint-Robert",
            "Saint-Robert-Bellarmin",
            "Saint-Roch-de-l\'Achigan",
            "Saint-Roch-de-Mékinac",
            "Saint-Roch-de-Richelieu",
            "Saint-Roch-des-Aulnaies",
            "Saint-Roch-Ouest",
            "Saint-Romain",
            "Saint-Romuald",
            "Saint-Rosaire",
            "Saint-Samuel",
            "Saints-Anges",
            "Saint-Sauveur",
            "Saint-Sébastien",
            "Saint-Sébastien",
            "Saint-Sévère",
            "Saint-Séverin",
            "Saint-Séverin",
            "Saint-Siméon",
            "Saint-Siméon",
            "Saint-Simon",
            "Saint-Simon",
            "Saint-Simon-les-Mines",
            "Saint-Sixte",
            "Saints-Martyrs-Canadiens",
            "Saint-Stanislas",
            "Saint-Stanislas",
            "Saint-Stanislas-de-Kostka",
            "Saint-Sulpice",
            "Saint-Sylvère",
            "Saint-Sylvestre",
            "Saint-Télesphore",
            "Saint-Tharcisius",
            "Saint-Théodore-d\'Acton",
            "Saint-Théophile",
            "Saint-Thomas",
            "Saint-Thomas Didyme",
            "Saint-Thuribe",
            "Saint-Tite",
            "Saint-Tite-des-Caps",
            "Saint-Ubalde",
            "Saint-Ulric",
            "Saint-Urbain",
            "Saint-Urbain-Premier",
            "Saint-Valentin",
            "Saint-Valère",
            "Saint-Valérien",
            "Saint-Valérien-de-Milton",
            "Saint-Vallier",
            "Saint-Venant-de-Paquette",
            "Saint-Vianney",
            "Saint-Victor",
            "Saint-Wenceslas",
            "Saint-Zacharie",
            "Saint-Zénon",
            "Saint-Zénon-du-Lac-Humqui",
            "Saint-Zéphirin-de-Courval",
            "Saint-Zotique",
            "Salaberry-de-Valleyfield",
            "Salluit",
            "Sayabec",
            "Schefferville",
            "Scotstown",
            "Scott",
            "Senneterre",
            "Senneville",
            "Sept-Iles",
            "Shannon",
            "Shawinigan",
            "Shawville",
            "Sheenboro",
            "Shefford",
            "Sherbrooke",
            "Shigawake",
            "Shipshaw",
            "Sorel-Tracy",
            "Stanbridge East",
            "Stanbridge Station",
            "Stanstead",
            "Stanstead-Est",
            "Stoke",
            "Stoneham-et-Tewkesbury",
            "Stornoway",
            "Stratford",
            "Stukely-Sud",
            "Sutton",
            "Tadoussac",
            "Taschereau",
            "Tasiujaq",
            "Témiscaming",
            "Terrasse-Vaudreuil",
            "Terrebonne",
            "Thetford Mines",
            "Thorne",
            "Thurso",
            "Timiskaming",
            "Tingwick",
            "Tourville",
            "Trécesson",
            "Très-Saint-Rédempteur",
            "Très-Saint-Sacrement",
            "Tring-Jonction",
            "Trois-Pistoles",
            "Trois-Rives",
            "Trois-Rivières",
            "Uashat",
            "Ulverton",
            "Umiujaq",
            "Upton",
            "Val-Alain",
            "Val-Brillant",
            "Valcourt",
            "Val-David",
            "Val-des-Bois",
            "Val-des-Lacs",
            "Val-des-Monts",
            "Val-d\'Or",
            "Val-Joli",
            "Vallée-Jonction",
            "Val-Morin",
            "Val-Racine",
            "Val-Saint-Gilles",
            "Varennes",
            "Vaudreuil-Dorion",
            "Vaudreuil-sur-le-Lac",
            "Venise-en-Québec",
            "Verchères",
            "Victoriaville",
            "Ville Saguenay",
            "Ville-Marie",
            "Villeroy",
            "Waltham",
            "Warden",
            "Warwick",
            "Waskaganish",
            "Waswanipi",
            "Waterloo",
            "Waterville",
            "Weedon",
            "Wemindji",
            "Wemotaci",
            "Wendake",
            "Wentworth",
            "Wentworth-Nord",
            "Westbury",
            "Westmount",
            "Whapmagoostui",
            "Wickham",
            "Windsor",
            "Wôlinak",
            "Wotton",
            "Yamachiche",
            "Yamaska",
            "",
            "Abercorn",
            "Acton Vale",
            "Adstock",
            "Aguanish",
            "Akulivik",
            "Akwesasne",
            "Albanel",
            "Albertville",
            "Alleyn-et-Cawood",
            "Alma",
            "Amherst",
            "Amos",
            "Amqui",
            "Ange-Gardien",
            "Angliers",
            "Armagh",
            "Arundel",
            "Asbestos",
            "Ascot Corner",
            "Aston-Jonction",
            "Auclair",
            "Audet",
            "Aumond",
            "Aupaluk",
            "Austin",
            "Authier",
            "Authier-Nord",
            "Ayer\'s Cliff",
            "Baie-Comeau",
            "Baie-de-la-Bouteille",
            "Baie-des-Sables",
            "Baie-du-Febvre",
            "Baie-D\'Urfé",
            "Baie-James",
            "Baie-Johan-Beetz",
            "Baie-Sainte-Catherine",
            "Baie-Saint-Paul",
            "Baie-Trinité",
            "Barkmere",
            "Barnston-Ouest",
            "Barraute",
            "Batiscan",
            "Beaconsfield",
            "Béarn",
            "Beauceville",
            "Beauharnois",
            "Beaulac-Garthby",
            "Beaumont",
            "Beaupré",
            "Bécancour",
            "Bedford",
            "Bégin",
            "Belcourt",
            "Belleterre",
            "Beloeil",
            "Berry",
            "Berthier-sur-Mer",
            "Berthierville",
            "Béthanie",
            "Betsiamites",
            "Biencourt",
            "Blainville",
            "Blanc-Sablon",
            "Blue Sea",
            "Boileau",
            "Boisbriand",
            "Boischatel",
            "Bois-des-Filion",
            "Bois-Franc",
            "Bolton-Est",
            "Bolton-Ouest",
            "Bonaventure",
            "Bonne-Espérance",
            "Bonsecours",
            "Boucherville",
            "Bouchette",
            "Bowman",
            "Brébeuf",
            "Brigham",
            "Bristol",
            "Brome",
            "Bromont",
            "Brossard",
            "Brownsburg-Chatham",
            "Bryson",
            "Bury",
            "Cabano",
            "Cacouna",
            "Calixa-Lavallée",
            "Campbell\'s Bay",
            "Candiac",
            "Cantley",
            "Canton-Tremblay",
            "Cap-Chat",
            "Caplan",
            "Cap-Saint-Ignace",
            "Cap-Santé",
            "Carignan",
            "Carleton-sur-Mer",
            "Cascapédia–Saint-Jules",
            "Causapscal",
            "Cayamant",
            "Chambly",
            "Chambord",
            "Champlain",
            "Champneuf",
            "Chandler",
            "Chapais",
            "Charlemagne",
            "Charrette",
            "Chartierville",
            "Châteauguay",
            "Château-Richer",
            "Chazel",
            "Chelsea",
            "Chénéville",
            "Chertsey",
            "Chester-Est",
            "Chesterville",
            "Chibougamau",
            "Chichester",
            "Chicoutimi",
            "Chicoutimi-Nord",
            "Chisasibi",
            "Chute-aux-Outardes",
            "Chute-Des-Passes",
            "Chute-Saint-Philippe",
            "Clarendon",
            "Clermont",
            "Clermont",
            "Clerval",
            "Cleveland",
            "Cloridorme",
            "Coaticook",
            "Colombier",
            "Compton",
            "Contrecoeur",
            "Cookshire-Eaton",
            "Coteau-du-Lac",
            "Côte-Nord-du-Golfe-du-Saint-Laurent",
            "Côte-Saint-Luc",
            "Courcelles",
            "Cowansville",
            "Crabtree",
            "Danville",
            "Daveluyville",
            "Dégelis",
            "Déléage",
            "Delson",
            "Denholm",
            "Desbiens",
            "Deschaillons-sur-Saint-Laurent",
            "Deschambault-Grondines",
            "Deux-Montagnes",
            "Disraeli",
            "Dixville",
            "Dolbeau",
            "Dollard-Des Ormeaux",
            "Doncaster",
            "Donnacona",
            "Dorval",
            "Dosquet",
            "Drummondville",
            "Dudswell",
            "Duhamel",
            "Duhamel-Ouest",
            "Dundee",
            "Dunham",
            "Duparquet",
            "Dupuy",
            "Durham-Sud",
            "East Angus",
            "East Broughton",
            "East Farnham",
            "East Hereford",
            "Eastmain",
            "Eastman",
            "Egan-Sud",
            "Elgin",
            "Entrelacs",
            "Escuminac",
            "Esprit-Saint",
            "Essipit",
            "Estérel",
            "Farnham",
            "Fassett",
            "Ferland-et-Boilleau",
            "Ferme-Neuve",
            "Fermont",
            "Forestville",
            "Fort-Coulonge",
            "Fortierville",
            "Fossambault-sur-le-Lac",
            "Frampton",
            "Franklin",
            "Franquelin",
            "Frelighsburg",
            "Frontenac",
            "Fugèreville",
            "Gallichan",
            "Gaspé",
            "Gatineau",
            "Gesgapegiag",
            "Girardville",
            "Godbout",
            "Godmanchester",
            "Gore",
            "Gracefield",
            "Granby",
            "Grand-Calumet",
            "Grande-Rivière",
            "Grandes-Piles",
            "Grande-Vallée",
            "Grand-Métis",
            "Grand-Remous",
            "Grand-Saint-Esprit",
            "Grenville",
            "Grenville-sur-la-Rouge",
            "Gros-Mécatina",
            "Grosse-Île",
            "Grosses-Roches",
            "Guérin",
            "Ham-Nord",
            "Hampden",
            "Hampstead",
            "Harrington",
            "Hatley",
            "Havelock",
            "Havre-Saint-Pierre",
            "Hébertville",
            "Hébertville-Station",
            "Hemmingford",
            "Henryville",
            "Hérouxville",
            "Hinchinbrooke",
            "Honfleur",
            "Hope",
            "Hope Town",
            "Howick",
            "Huberdeau",
            "Hudson",
            "Huntingdon",
            "Inukjuak",
            "Inverness",
            "Irlande",
            "Ivry-sur-le-Lac",
            "Ivujivik",
            "Joliette",
            "Jonquière",
            "Kahnawake",
            "Kamouraska",
            "Kangiqsualujjuaq",
            "Kangiqsujuaq",
            "Kangirsuk",
            "Kawawachikamach",
            "Kazabazua",
            "Kebaowek",
            "Kiamika",
            "Kingsbury",
            "Kingsey Falls",
            "Kinnear\'s Mills",
            "Kipawa",
            "Kirkland",
            "Kitigan Zibi",
            "Kuujjuaq",
            "Kuujjuarapik",
            "La Baie",
            "La Bostonnais",
            "La Conception",
            "La Corne",
            "La Doré",
            "La Durantaye",
            "La Guadeloupe",
            "La Macaza",
            "La Malbaie",
            "La Martre",
            "La Minerve",
            "La Morandière",
            "La Motte",
            "La Patrie",
            "La Pêche",
            "La Pocatière",
            "La Prairie",
            "La Présentation",
            "La Rédemption",
            "La Reine",
            "La Romaine",
            "La Sarre",
            "La Trinité-des-Monts",
            "La Tuque",
            "La Visitation-de-l\'Île-Dupas",
            "La Visitation-de-Yamaska",
            "Labelle",
            "Labrecque",
            "Lac-Ashuapmushuan",
            "Lac-au-Brochet",
            "Lac-au-Saumon",
            "Lac-aux-Sables",
            "Lac-Beauport",
            "Lac-Bouchette",
            "Lac-Brome",
            "Lac-Casault",
            "Lac-Chicobi",
            "Lac-Delage",
            "Lac-des-Aigles",
            "Lac-des-Écorces",
            "Lac-Despinassy",
            "Lac-des-Plages",
            "Lac-des-Seize-Îles",
            "Lac-Devenyns",
            "Lac-Drolet",
            "Lac-du-Cerf",
            "Lac-Édouard",
            "Lac-Etchemin",
            "Lac-Fouillac",
            "Lac-Frontière",
            "Lac-Granet",
            "Lachute",
            "Lac-John",
            "Lac-Masketsi",
            "Lac-Matapédia",
            "Lac-Matawin",
            "Lac-Mégantic",
            "Lac-Nilgaut",
            "Lacolle",
            "Lac-Pikauba",
            "Lac-Poulin",
            "Lac-Pythonga",
            "Lac-Rapide",
            "Lac-Saguay",
            "Lac-Sainte-Marie",
            "Lac-Saint-Joseph",
            "Lac-Saint-Paul",
            "Lac-Sergent",
            "Lac-Simon",
            "Lac-Simon",
            "Lac-Supérieur",
            "Lac-Tremblant-Nord",
            "Lac-Walker",
            "Laforce",
            "Lamarche",
            "Lambton",
            "L\'Ancienne-Lorette",
            "Landrienne",
            "L\'Ange-Gardien",
            "L\'Ange-Gardien",
            "Laniel",
            "Lanoraie",
            "L\'Anse-Saint-Jean",
            "Lantier",
            "Larouche",
            "L\'Ascension",
            "L\'Ascension-de-Notre-Seigneur",
            "L\'Ascension-de-Patapédia",
            "L\'Assomption",
            "Laterrière",
            "Latulipe-et-Gaboury",
            "Launay",
            "Laurier-Station",
            "Laurierville",
            "Laval",
            "Lavaltrie",
            "L\'Avenir",
            "Laverlochère",
            "Lawrenceville",
            "Le Bic",
            "Lebel-sur-Quévillon",
            "Leclercville",
            "Lefebvre",
            "Lejeune",
            "Lemieux",
            "L\'Épiphanie",
            "Léry",
            "Les Bergeronnes",
            "Les Cèdres",
            "Les Coteaux",
            "Les Éboulements",
            "Les Escoumins",
            "Les Hauteurs",
            "Les Îles-de-la-Madeleine",
            "Les Méchins",
            "Lévis",
            "L\'Île-Cadieux",
            "L\'Île-d\'Anticosti",
            "L\'Île-Dorval",
            "L\'Île-Perrot",
            "Lingwick",
            "Linton",
            "L\'Isle-aux-Allumettes",
            "L\'Isle-aux-Coudres",
            "L\'Islet",
            "L\'Isle-Verte",
            "Listuguj",
            "Litchfield",
            "Lochaber",
            "Lochaber-Partie-Ouest",
            "Longue-Pointe-de-Mingan",
            "Longue-Rive",
            "Longueuil",
            "Lorraine",
            "Lorrainville",
            "Lotbinière",
            "Louiseville",
            "Low",
            "Lyster",
            "Macamic",
            "Maddington",
            "Magog",
            "Malartic",
            "Maliotenam",
            "Manawan",
            "Mandeville",
            "Maniwaki",
            "Manseau",
            "Mansfield-et-Pontefract",
            "Maria",
            "Maricourt",
            "Marieville",
            "Marsoui",
            "Marston",
            "Martinville",
            "Mascouche",
            "Mashteuiatsh",
            "Maskinongé",
            "Massueville",
            "Matagami",
            "Matane",
            "Matapédia",
            "Matchi-Manitou",
            "Matimekosh",
            "Mayo",
            "McMasterville",
            "Melbourne",
            "Mercier",
            "Messines",
            "Métabetchouan–Lac-à-la-Croix",
            "Métis-sur-Mer",
            "Milan",
            "Mille-Isles",
            "Mingan",
            "Mirabel",
            "Mistissini",
            "Moffet",
            "Mont-Albert",
            "Montcalm",
            "Mont-Carmel",
            "Montcerf-Lytton",
            "Montebello",
            "Mont-Élie",
            "Mont-Joli",
            "Mont-Laurier",
            "Montmagny",
            "Montpellier",
            "Montréal",
            "Montréal-Est",
            "Montréal-Ouest",
            "Mont-Royal",
            "Mont-Saint-Grégoire",
            "Mont-Saint-Hilaire",
            "Mont-Saint-Michel",
            "Mont-Saint-Pierre",
            "Mont-Tremblant",
            "Mont-Valin",
            "Morin-Heights",
            "Mulgrave-et-Derry",
            "Murdochville",
            "Namur",
            "Nantes",
            "Napierville",
            "Natashquan",
            "Natashquan",
            "Nédélec",
            "Nemiscau",
            "Neuville",
            "New Carlisle",
            "New Richmond",
            "Newport",
            "Nicolet",
            "Nominingue",
            "Norbertville",
            "Normandin",
            "Normétal",
            "North Hatley",
            "Notre-Dame-Auxiliatrice-de-Buckland",
            "Notre-Dame-de-Bonsecours",
            "Notre-Dame-de-Ham",
            "Notre-Dame-de-la-Merci",
            "Notre-Dame-de-la-Paix",
            "Notre-Dame-de-la-Salette",
            "Notre-Dame-de-l\'Île-Perrot",
            "Notre-Dame-de-Lorette",
            "Notre-Dame-de-Lourdes",
            "Notre-Dame-de-Lourdes",
            "Notre-Dame-de-Montauban",
            "Notre-Dame-de-Pontmain",
            "Notre-Dame-des-Anges",
            "Notre-Dame-des-Bois",
            "Notre-Dame-des-Monts",
            "Notre-Dame-des-Neiges",
            "Notre-Dame-des-Pins",
            "Notre-Dame-des-Prairies",
            "Notre-Dame-des-Sept-Douleurs",
            "Notre-Dame-de-Stanbridge",
            "Notre-Dame-du-Bon-Conseil",
            "Notre-Dame-du-Lac",
            "Notre-Dame-du-Laus",
            "Notre-Dame-du-Mont-Carmel",
            "Notre-Dame-du-Nord",
            "Notre-Dame-du-Portage",
            "Notre-Dame-du-Rosaire",
            "Notre-Dame-du-Sacré-Coeur-d\'Issoudun",
            "Nouvelle",
            "Noyan",
            "Obedjiwan",
            "Odanak",
            "Ogden",
            "Oka",
            "Orford",
            "Ormstown",
            "Otter Lake",
            "Otterburn Park",
            "Packington",
            "Padoue",
            "Palmarolle",
            "Papineauville",
            "Parisville",
            "Paspébiac",
            "Percé",
            "Péribonka",
            "Petite-Rivière-Saint-François",
            "Petite-Vallée",
            "Petit-Saguenay",
            "Picard",
            "Piedmont",
            "Pierreville",
            "Pikogan",
            "Pincourt",
            "Piopolis",
            "Plaisance",
            "Plessisville",
            "Pohénégamook",
            "Pointe-à-la-Croix",
            "Pointe-aux-Outardes",
            "Pointe-Calumet",
            "Pointe-Claire",
            "Pointe-des-Cascades",
            "Pointe-Fortune",
            "Pointe-Lebel",
            "Pontiac",
            "Pont-Rouge",
            "Portage-du-Fort",
            "Port-Cartier",
            "Port-Daniel–Gascons",
            "Portneuf",
            "Portneuf-sur-Mer",
            "Potton",
            "Poularies",
            "Preissac",
            "Prévost",
            "Price",
            "Princeville",
            "Puvirnituq",
            "Quaqtaq",
            "Québec",
            "Racine",
            "Ragueneau",
            "Rapide-Danseur",
            "Rapides-des-Joachims",
            "Rawdon",
            "Rémigny",
            "Repentigny",
            "Réservoir-Dozois",
            "Richelieu",
            "Richmond",
            "Rigaud",
            "Rimouski",
            "Ripon",
            "Ristigouche-Partie-Sud-Est",
            "Rivière-à-Claude",
            "Rivière-à-Pierre",
            "Rivière-au-Tonnerre",
            "Rivière-aux-Outardes",
            "Rivière-Beaudette",
            "Rivière-Bleue",
            "Rivière-du-Loup",
            "Rivière-Éternité",
            "Rivière-Héva",
            "Rivière-Mistassini",
            "Rivière-Ojima",
            "Rivière-Ouelle",
            "Rivière-Rouge",
            "Rivière-Saint-Jean",
            "Roberval",
            "Rochebaucourt",
            "Roquemaure",
            "Rosemère",
            "Rougemont",
            "Routhierville",
            "Rouyn-Noranda",
            "Roxton",
            "Roxton Falls",
            "Roxton Pond",
            "Sacré-Cœur",
            "Sacré-Coeur-de-Jésus",
            "Sagard",
            "Saint-Adalbert",
            "Saint-Adelme",
            "Saint-Adelphe",
            "Saint-Adolphe-d\'Howard",
            "Saint-Adrien",
            "Saint-Adrien-d\'Irlande",
            "Saint-Agapit",
            "Saint-Aimé",
            "Saint-Aimé-des-Lacs",
            "Saint-Aimé-du-Lac-des-Îles",
            "Saint-Alban",
            "Saint-Albert",
            "Saint-Alexandre",
            "Saint-Alexandre-de-Kamouraska",
            "Saint-Alexandre-des-Lacs",
            "Saint-Alexis",
            "Saint-Alexis-de-Matapédia",
            "Saint-Alexis-des-Monts",
            "Saint-Alfred",
            "Saint-Alphonse",
            "Saint-Alphonse",
            "Saint-Alphonse-Rodrigue",
            "Saint-Amable",
            "Saint-Ambroise",
            "Saint-Ambroise-de-Kildare",
            "Saint-Anaclet-de-Lessard",
            "Saint-André",
            "Saint-André-Avellin",
            "Saint-André-d\'Argenteuil",
            "Saint-André-de-Restigouche",
            "Saint-André-du-Lac-Saint-Jean",
            "Saint-Anicet",
            "Saint-Anselme",
            "Saint-Antoine-de-l\'Isle-aux-Grues",
            "Saint-Antoine-de-Tilly",
            "Saint-Antoine-sur-Richelieu",
            "Saint-Antonin",
            "Saint-Apollinaire",
            "Saint-Armand",
            "Saint-Arsène",
            "Saint-Athanase",
            "Saint-Aubert",
            "Saint-Augustin",
            "Saint-Augustin",
            "Saint-Augustin-de-Desmaures",
            "Saint-Augustin-de-Woburn",
            "Saint-Barnabé",
            "Saint-Barnabé-Sud",
            "Saint-Barthélemy",
            "Saint-Basile",
            "Saint-Basile-le-Grand",
            "Saint-Benjamin",
            "Saint-Benoît-du-Lac",
            "Saint-Benoît-Labre",
            "Saint-Bernard",
            "Saint-Bernard-de-Lacolle",
            "Saint-Bernard-de-Michaudville",
            "Saint-Blaise-sur-Richelieu",
            "Saint-Bonaventure",
            "Saint-Boniface",
            "Saint-Bruno",
            "Saint-Bruno-de-Guigues",
            "Saint-Bruno-de-Kamouraska",
            "Saint-Bruno-de-Montarville",
            "Saint-Calixte",
            "Saint-Camille",
            "Saint-Camille-de-Lellis",
            "Saint-Casimir",
            "Saint-Célestin",
            "Saint-Césaire",
            "Saint-Charles-Borromée",
            "Saint-Charles-de-Bellechasse",
            "Saint-Charles-de-Bourget",
            "Saint-Charles-Garnier",
            "Saint-Charles-sur-Richelieu",
            "Saint-Christophe-d\'Arthabaska",
            "Saint-Chrysostome",
            "Saint-Claude",
            "Saint-Clément",
            "Saint-Cléophas",
            "Saint-Cléophas-de-Brandon",
            "Saint-Clet",
            "Saint-Colomban",
            "Saint-Côme",
            "Saint-Côme–Linière",
            "Saint-Constant",
            "Saint-Cuthbert",
            "Saint-Cyprien",
            "Saint-Cyprien",
            "Saint-Cyprien-de-Napierville",
            "Saint-Cyrille-de-Lessard",
            "Saint-Cyrille-de-Wendover",
            "Saint-Damase",
            "Saint-Damase",
            "Saint-Damase-de-L\'Islet",
            "Saint-Damien",
            "Saint-Damien-de-Buckland",
            "Saint-David",
            "Saint-David-de-Falardeau",
            "Saint-Denis",
            "Saint-Denis-de-Brompton",
            "Saint-Denis-sur-Richelieu",
            "Saint-Didace",
            "Saint-Dominique",
            "Saint-Dominique-du-Rosaire",
            "Saint-Donat",
            "Saint-Donat",
            "Sainte-Adèle",
            "Sainte-Agathe-de-Lotbinière",
            "Sainte-Agathe-des-Monts",
            "Sainte-Angèle-de-Mérici",
            "Sainte-Angèle-de-Monnoir",
            "Sainte-Angèle-de-Prémont",
            "Sainte-Anne-de-Beaupré",
            "Sainte-Anne-de-Bellevue",
            "Sainte-Anne-de-la-Pérade",
            "Sainte-Anne-de-la-Pocatière",
            "Sainte-Anne-de-la-Rochelle",
            "Sainte-Anne-de-Sabrevois",
            "Sainte-Anne-des-Lacs",
            "Sainte-Anne-des-Monts",
            "Sainte-Anne-de-Sorel",
            "Sainte-Anne-des-Plaines",
            "Sainte-Anne-du-Lac",
            "Sainte-Anne-du-Sault",
            "Sainte-Apolline-de-Patton",
            "Sainte-Aurélie",
            "Sainte-Barbe",
            "Sainte-Béatrix",
            "Sainte-Brigide-d\'Iberville",
            "Sainte-Brigitte-de-Laval",
            "Sainte-Brigitte-des-Saults",
            "Sainte-Catherine",
            "Sainte-Catherine-de-Hatley",
            "Sainte-Catherine-de-la-Jacques-Cartier",
            "Sainte-Cécile-de-Lévrard",
            "Sainte-Cécile-de-Milton",
            "Sainte-Cécile-de-Whitton",
            "Sainte-Christine",
            "Sainte-Christine-d\'Auvergne",
            "Sainte-Claire",
            "Sainte-Clotilde-de-Beauce",
            "Sainte-Clotilde-de-Châteauguay",
            "Sainte-Clotilde-de-Horton",
            "Sainte-Croix",
            "Saint-Edmond-de-Grantham",
            "Saint-Edmond-les-Plaines",
            "Saint-Édouard",
            "Saint-Édouard-de-Fabre",
            "Saint-Édouard-de-Lotbinière",
            "Saint-Édouard-de-Maskinongé",
            "Sainte-Edwidge-de-Clifton",
            "Sainte-Élisabeth",
            "Sainte-Élisabeth-de-Warwick",
            "Sainte-Émélie-de-l\'Énergie",
            "Sainte-Eulalie",
            "Sainte-Euphémie-sur-Rivière-du-Sud",
            "Sainte-Famille",
            "Sainte-Félicité",
            "Sainte-Félicité",
            "Sainte-Flavie",
            "Sainte-Florence",
            "Sainte-Françoise",
            "Sainte-Françoise",
            "Sainte-Geneviève-de-Batiscan",
            "Sainte-Geneviève-de-Berthier",
            "Sainte-Germaine-Boulé",
            "Sainte-Gertrude-Manneville",
            "Sainte-Hedwidge",
            "Sainte-Hélène",
            "Sainte-Hélène-de-Bagot",
            "Sainte-Hélène-de-Mancebourg",
            "Sainte-Hénédine",
            "Sainte-Irène",
            "Sainte-Jeanne-d\'Arc",
            "Sainte-Jeanne-d\'Arc",
            "Sainte-Julie",
            "Sainte-Julienne",
            "Sainte-Justine",
            "Sainte-Justine-de-Newton",
            "Saint-Élie-de-Caxton",
            "Saint-Éloi",
            "Sainte-Louise",
            "Saint-Elphège",
            "Sainte-Luce",
            "Sainte-Lucie-de-Beauregard",
            "Sainte-Lucie-des-Laurentides",
            "Saint-Elzéar",
            "Saint-Elzéar",
            "Saint-Elzéar-de-Témiscouata",
            "Sainte-Madeleine",
            "Sainte-Madeleine-de-la-Rivière-Madeleine",
            "Sainte-Marcelline-de-Kildare",
            "Sainte-Marguerite",
            "Sainte-Marguerite",
            "Sainte-Marguerite-du-Lac-Masson",
            "Sainte-Marie",
            "Sainte-Marie-de-Blandford",
            "Sainte-Marie-Madeleine",
            "Sainte-Marie-Salomé",
            "Sainte-Marthe",
            "Sainte-Marthe-sur-le-Lac",
            "Sainte-Martine",
            "Sainte-Mélanie",
            "Saint-Émile-de-Suffolk",
            "Sainte-Monique",
            "Sainte-Monique",
            "Sainte-Paule",
            "Sainte-Perpétue",
            "Sainte-Perpétue",
            "Sainte-Pétronille",
            "Saint-Éphrem-de-Beauce",
            "Saint-Épiphane",
            "Sainte-Praxède",
            "Sainte-Rita",
            "Sainte-Rose-de-Watford",
            "Sainte-Rose-du-Nord",
            "Sainte-Sabine",
            "Sainte-Sabine",
            "Sainte-Séraphine",
            "Sainte-Sophie",
            "Sainte-Sophie-de-Lévrard",
            "Sainte-Sophie-d\'Halifax",
            "Saint-Esprit",
            "Sainte-Thècle",
            "Sainte-Thérèse",
            "Sainte-Thérèse-de-Gaspé",
            "Sainte-Thérèse-de-la-Gatineau",
            "Saint-Étienne-de-Beauharnois",
            "Saint-Étienne-de-Bolton",
            "Saint-Étienne-des-Grès",
            "Saint-Eugène",
            "Saint-Eugène-de-Guigues",
            "Saint-Eugène-de-Ladrière",
            "Saint-Eugènes",
            "Sainte-Ursule",
            "Saint-Eusèbe",
            "Saint-Eustache",
            "Saint-Évariste-de-Forsyth",
            "Sainte-Victoire-de-Sorel",
            "Saint-Fabien",
            "Saint-Fabien-de-Panet",
            "Saint-Faustin–Lac-Carré",
            "Saint-Félicien",
            "Saint-Félix-de-Dalquier",
            "Saint-Félix-de-Kingsey",
            "Saint-Félix-de-Valois",
            "Saint-Félix-d\'Otis",
            "Saint-Ferdinand",
            "Saint-Ferréol-les-Neiges",
            "Saint-Flavien",
            "Saint-Fortunat",
            "Saint-François-d\'Assise",
            "Saint-François-de-la-Rivière-du-Sud",
            "Saint-François-de-l\'Île-d\'Orléans",
            "Saint-François-de-Sales",
            "Saint-François-du-Lac",
            "Saint-François-Xavier-de-Brompton",
            "Saint-François-Xavier-de-Viger",
            "Saint-Frédéric",
            "Saint-Fulgence",
            "Saint-Gabriel",
            "Saint-Gabriel-de-Brandon",
            "Saint-Gabriel-de-Rimouski",
            "Saint-Gabriel-de-Valcartier",
            "Saint-Gabriel-Lalemant",
            "Saint-Gédéon",
            "Saint-Gédéon-de-Beauce",
            "Saint-Georges",
            "Saint-Georges-de-Clarenceville",
            "Saint-Georges-de-Windsor",
            "Saint-Gérard-Majella",
            "Saint-Germain",
            "Saint-Germain-de-Grantham",
            "Saint-Gervais",
            "Saint-Gilbert",
            "Saint-Gilles",
            "Saint-Godefroi",
            "Saint-Guillaume",
            "Saint-Guillaume-Nord",
            "Saint-Guy",
            "Saint-Henri",
            "Saint-Henri-de-Taillon",
            "Saint-Herménégilde",
            "Saint-Hilaire-de-Dorset",
            "Saint-Hilarion",
            "Saint-Hippolyte",
            "Saint-Honoré-de-Chicoutimi",
            "Saint-Honoré-de-Shenley",
            "Saint-Honoré-de-Témiscouata",
            "Saint-Hubert-de-Rivière-du-Loup",
            "Saint-Hugues",
            "Saint-Hyacinthe",
            "Saint-Ignace-de-Loyola",
            "Saint-Ignace-de-Stanbridge",
            "Saint-Irénée",
            "Saint-Isidore",
            "Saint-Isidore",
            "Saint-Isidore-de-Clifton",
            "Saint-Jacques",
            "Saint-Jacques-de-Leeds",
            "Saint-Jacques-le-Majeur-de-Wolfestown",
            "Saint-Jacques-le-Mineur",
            "Saint-Janvier-de-Joly",
            "Saint-Jean-Baptiste",
            "Saint-Jean-de-Brébeuf",
            "Saint-Jean-de-Cherbourg",
            "Saint-Jean-de-Dieu",
            "Saint-Jean-de-la-Lande",
            "Saint-Jean-de-l\'Île-d\'Orléans",
            "Saint-Jean-de-Matha",
            "Saint-Jean-Port-Joli",
            "Saint-Jean-sur-Richelieu",
            "Saint-Jérôme",
            "Saint-Joachim",
            "Saint-Joachim-de-Shefford",
            "Saint-Joseph-de-Beauce",
            "Saint-Joseph-de-Coleraine",
            "Saint-Joseph-de-Ham-Sud",
            "Saint-Joseph-de-Kamouraska",
            "Saint-Joseph-de-Lepage",
            "Saint-Joseph-des-Érables",
            "Saint-Joseph-de-Sorel",
            "Saint-Joseph-du-Lac",
            "Saint-Jude",
            "Saint-Jules",
            "Saint-Julien",
            "Saint-Just-de-Bretenières",
            "Saint-Juste-du-Lac",
            "Saint-Justin",
            "Saint-Lambert",
            "Saint-Lambert",
            "Saint-Lambert-de-Lauzon",
            "Saint-Laurent-de-l\'Île-d\'Orléans",
            "Saint-Lazare",
            "Saint-Lazare-de-Bellechasse",
            "Saint-Léandre",
            "Saint-Léonard-d\'Aston",
            "Saint-Léonard-de-Portneuf",
            "Saint-Léon-de-Standon",
            "Saint-Léon-le-Grand",
            "Saint-Léon-le-Grand",
            "Saint-Liboire",
            "Saint-Liguori",
            "Saint-Lin–Laurentides",
            "Saint-Louis",
            "Saint-Louis-de-Blandford",
            "Saint-Louis-de-Gonzague",
            "Saint-Louis-de-Gonzague",
            "Saint-Louis-de-Gonzague-du-Cap-Tourmente",
            "Saint-Louis-du-Ha! Ha!",
            "Saint-Luc-de-Bellechasse",
            "Saint-Luc-de-Vincennes",
            "Saint-Lucien",
            "Saint-Ludger",
            "Saint-Ludger-de-Milot",
            "Saint-Magloire",
            "Saint-Majorique-de-Grantham",
            "Saint-Malachie",
            "Saint-Malo",
            "Saint-Marc-de-Figuery",
            "Saint-Marc-des-Carrières",
            "Saint-Marc-du-Lac-Long",
            "Saint-Marcel",
            "Saint-Marcel-de-Richelieu",
            "Saint-Marcellin",
            "Saint-Marc-sur-Richelieu",
            "Saint-Martin",
            "Saint-Mathias-sur-Richelieu",
            "Saint-Mathieu",
            "Saint-Mathieu-de-Beloeil",
            "Saint-Mathieu-de-Rioux",
            "Saint-Mathieu-d\'Harricana",
            "Saint-Mathieu-du-Parc",
            "Saint-Maurice",
            "Saint-Maxime-du-Mont-Louis",
            "Saint-Médard",
            "Saint-Michel",
            "Saint-Michel-de-Bellechasse",
            "Saint-Michel-des-Saints",
            "Saint-Michel-du-Squatec",
            "Saint-Modeste",
            "Saint-Moïse",
            "Saint-Narcisse",
            "Saint-Narcisse-de-Beaurivage",
            "Saint-Narcisse-de-Rimouski",
            "Saint-Nazaire",
            "Saint-Nazaire-d\'Acton",
            "Saint-Nazaire-de-Dorchester",
            "Saint-Nérée",
            "Saint-Noël",
            "Saint-Norbert",
            "Saint-Norbert-d\'Arthabaska",
            "Saint-Octave-de-Métis",
            "Saint-Odilon-de-Cranbourne",
            "Saint-Omer",
            "Saint-Onésime-d\'Ixworth",
            "Saint-Ours",
            "Saint-Pacôme",
            "Saint-Pamphile",
            "Saint-Pascal",
            "Saint-Patrice-de-Beaurivage",
            "Saint-Patrice-de-Sherrington",
            "Saint-Paul",
            "Saint-Paul-d\'Abbotsford",
            "Saint-Paul-de-la-Croix",
            "Saint-Paul-de-l\'Île-aux-Noix",
            "Saint-Paul-de-Montminy",
            "Saint-Paulin",
            "Saint-Philémon",
            "Saint-Philibert",
            "Saint-Philippe",
            "Saint-Philippe-de-Néri",
            "Saint-Pie",
            "Saint-Pie-de-Guire",
            "Saint-Pierre",
            "Saint-Pierre-Baptiste",
            "Saint-Pierre-de-Broughton",
            "Saint-Pierre-de-Lamy",
            "Saint-Pierre-de-la-Rivière-du-Sud",
            "Saint-Pierre-de-l\'Île-d\'Orléans",
            "Saint-Pierre-de-Véronne-à-Pike-River",
            "Saint-Pierre-les-Becquets",
            "Saint-Placide",
            "Saint-Polycarpe",
            "Saint-Prime",
            "Saint-Prosper",
            "Saint-Prosper",
            "Saint-Raphaël",
            "Saint-Raymond",
            "Saint-Rémi",
            "Saint-Rémi-de-Tingwick",
            "Saint-René",
            "Saint-René-de-Matane",
            "Saint-Robert",
            "Saint-Robert-Bellarmin",
            "Saint-Roch-de-l\'Achigan",
            "Saint-Roch-de-Mékinac",
            "Saint-Roch-de-Richelieu",
            "Saint-Roch-des-Aulnaies",
            "Saint-Roch-Ouest",
            "Saint-Romain",
            "Saint-Romuald",
            "Saint-Rosaire",
            "Saint-Samuel",
            "Saints-Anges",
            "Saint-Sauveur",
            "Saint-Sébastien",
            "Saint-Sébastien",
            "Saint-Sévère",
            "Saint-Séverin",
            "Saint-Séverin",
            "Saint-Siméon",
            "Saint-Siméon",
            "Saint-Simon",
            "Saint-Simon",
            "Saint-Simon-les-Mines",
            "Saint-Sixte",
            "Saints-Martyrs-Canadiens",
            "Saint-Stanislas",
            "Saint-Stanislas",
            "Saint-Stanislas-de-Kostka",
            "Saint-Sulpice",
            "Saint-Sylvère",
            "Saint-Sylvestre",
            "Saint-Télesphore",
            "Saint-Tharcisius",
            "Saint-Théodore-d\'Acton",
            "Saint-Théophile",
            "Saint-Thomas",
            "Saint-Thomas Didyme",
            "Saint-Thuribe",
            "Saint-Tite",
            "Saint-Tite-des-Caps",
            "Saint-Ubalde",
            "Saint-Ulric",
            "Saint-Urbain",
            "Saint-Urbain-Premier",
            "Saint-Valentin",
            "Saint-Valère",
            "Saint-Valérien",
            "Saint-Valérien-de-Milton",
            "Saint-Vallier",
            "Saint-Venant-de-Paquette",
            "Saint-Vianney",
            "Saint-Victor",
            "Saint-Wenceslas",
            "Saint-Zacharie",
            "Saint-Zénon",
            "Saint-Zénon-du-Lac-Humqui",
            "Saint-Zéphirin-de-Courval",
            "Saint-Zotique",
            "Salaberry-de-Valleyfield",
            "Salluit",
            "Sayabec",
            "Schefferville",
            "Scotstown",
            "Scott",
            "Senneterre",
            "Senneville",
            "Sept-Iles",
            "Shannon",
            "Shawinigan",
            "Shawville",
            "Sheenboro",
            "Shefford",
            "Sherbrooke",
            "Shigawake",
            "Shipshaw",
            "Sorel-Tracy",
            "Stanbridge East",
            "Stanbridge Station",
            "Stanstead",
            "Stanstead-Est",
            "Stoke",
            "Stoneham-et-Tewkesbury",
            "Stornoway",
            "Stratford",
            "Stukely-Sud",
            "Sutton",
            "Tadoussac",
            "Taschereau",
            "Tasiujaq",
            "Témiscaming",
            "Terrasse-Vaudreuil",
            "Terrebonne",
            "Thetford Mines",
            "Thorne",
            "Thurso",
            "Timiskaming",
            "Tingwick",
            "Tourville",
            "Trécesson",
            "Très-Saint-Rédempteur",
            "Très-Saint-Sacrement",
            "Tring-Jonction",
            "Trois-Pistoles",
            "Trois-Rives",
            "Trois-Rivières",
            "Uashat",
            "Ulverton",
            "Umiujaq",
            "Upton",
            "Val-Alain",
            "Val-Brillant",
            "Valcourt",
            "Val-David",
            "Val-des-Bois",
            "Val-des-Lacs",
            "Val-des-Monts",
            "Val-d\'Or",
            "Val-Joli",
            "Vallée-Jonction",
            "Val-Morin",
            "Val-Racine",
            "Val-Saint-Gilles",
            "Varennes",
            "Vaudreuil-Dorion",
            "Vaudreuil-sur-le-Lac",
            "Venise-en-Québec",
            "Verchères",
            "Victoriaville",
            "Ville Saguenay",
            "Ville-Marie",
            "Villeroy",
            "Waltham",
            "Warden",
            "Warwick",
            "Waskaganish",
            "Waswanipi",
            "Waterloo",
            "Waterville",
            "Weedon",
            "Wemindji",
            "Wemotaci",
            "Wendake",
            "Wentworth",
            "Wentworth-Nord",
            "Westbury",
            "Westmount",
            "Whapmagoostui",
            "Wickham",
            "Windsor",
            "Wôlinak",
            "Wotton",
            "Yamachiche",
            "Yamaska",
            "",
            "Abercorn",
            "Acton Vale",
            "Adstock",
            "Aguanish",
            "Akulivik",
            "Akwesasne",
            "Albanel",
            "Albertville",
            "Alleyn-et-Cawood",
            "Alma",
            "Amherst",
            "Amos",
            "Amqui",
            "Ange-Gardien",
            "Angliers",
            "Armagh",
            "Arundel",
            "Asbestos",
            "Ascot Corner",
            "Aston-Jonction",
            "Auclair",
            "Audet",
            "Aumond",
            "Aupaluk",
            "Austin",
            "Authier",
            "Authier-Nord",
            "Ayer\'s Cliff",
            "Baie-Comeau",
            "Baie-de-la-Bouteille",
            "Baie-des-Sables",
            "Baie-du-Febvre",
            "Baie-D\'Urfé",
            "Baie-James",
            "Baie-Johan-Beetz",
            "Baie-Sainte-Catherine",
            "Baie-Saint-Paul",
            "Baie-Trinité",
            "Barkmere",
            "Barnston-Ouest",
            "Barraute",
            "Batiscan",
            "Beaconsfield",
            "Béarn",
            "Beauceville",
            "Beauharnois",
            "Beaulac-Garthby",
            "Beaumont",
            "Beaupré",
            "Bécancour",
            "Bedford",
            "Bégin",
            "Belcourt",
            "Belleterre",
            "Beloeil",
            "Berry",
            "Berthier-sur-Mer",
            "Berthierville",
            "Béthanie",
            "Betsiamites",
            "Biencourt",
            "Blainville",
            "Blanc-Sablon",
            "Blue Sea",
            "Boileau",
            "Boisbriand",
            "Boischatel",
            "Bois-des-Filion",
            "Bois-Franc",
            "Bolton-Est",
            "Bolton-Ouest",
            "Bonaventure",
            "Bonne-Espérance",
            "Bonsecours",
            "Boucherville",
            "Bouchette",
            "Bowman",
            "Brébeuf",
            "Brigham",
            "Bristol",
            "Brome",
            "Bromont",
            "Brossard",
            "Brownsburg-Chatham",
            "Bryson",
            "Bury",
            "Cabano",
            "Cacouna",
            "Calixa-Lavallée",
            "Campbell\'s Bay",
            "Candiac",
            "Cantley",
            "Canton-Tremblay",
            "Cap-Chat",
            "Caplan",
            "Cap-Saint-Ignace",
            "Cap-Santé",
            "Carignan",
            "Carleton-sur-Mer",
            "Cascapédia–Saint-Jules",
            "Causapscal",
            "Cayamant",
            "Chambly",
            "Chambord",
            "Champlain",
            "Champneuf",
            "Chandler",
            "Chapais",
            "Charlemagne",
            "Charrette",
            "Chartierville",
            "Châteauguay",
            "Château-Richer",
            "Chazel",
            "Chelsea",
            "Chénéville",
            "Chertsey",
            "Chester-Est",
            "Chesterville",
            "Chibougamau",
            "Chichester",
            "Chicoutimi",
            "Chicoutimi-Nord",
            "Chisasibi",
            "Chute-aux-Outardes",
            "Chute-Des-Passes",
            "Chute-Saint-Philippe",
            "Clarendon",
            "Clermont",
            "Clermont",
            "Clerval",
            "Cleveland",
            "Cloridorme",
            "Coaticook",
            "Colombier",
            "Compton",
            "Contrecoeur",
            "Cookshire-Eaton",
            "Coteau-du-Lac",
            "Côte-Nord-du-Golfe-du-Saint-Laurent",
            "Côte-Saint-Luc",
            "Courcelles",
            "Cowansville",
            "Crabtree",
            "Danville",
            "Daveluyville",
            "Dégelis",
            "Déléage",
            "Delson",
            "Denholm",
            "Desbiens",
            "Deschaillons-sur-Saint-Laurent",
            "Deschambault-Grondines",
            "Deux-Montagnes",
            "Disraeli",
            "Dixville",
            "Dolbeau",
            "Dollard-Des Ormeaux",
            "Doncaster",
            "Donnacona",
            "Dorval",
            "Dosquet",
            "Drummondville",
            "Dudswell",
            "Duhamel",
            "Duhamel-Ouest",
            "Dundee",
            "Dunham",
            "Duparquet",
            "Dupuy",
            "Durham-Sud",
            "East Angus",
            "East Broughton",
            "East Farnham",
            "East Hereford",
            "Eastmain",
            "Eastman",
            "Egan-Sud",
            "Elgin",
            "Entrelacs",
            "Escuminac",
            "Esprit-Saint",
            "Essipit",
            "Estérel",
            "Farnham",
            "Fassett",
            "Ferland-et-Boilleau",
            "Ferme-Neuve",
            "Fermont",
            "Forestville",
            "Fort-Coulonge",
            "Fortierville",
            "Fossambault-sur-le-Lac",
            "Frampton",
            "Franklin",
            "Franquelin",
            "Frelighsburg",
            "Frontenac",
            "Fugèreville",
            "Gallichan",
            "Gaspé",
            "Gatineau",
            "Gesgapegiag",
            "Girardville",
            "Godbout",
            "Godmanchester",
            "Gore",
            "Gracefield",
            "Granby",
            "Grand-Calumet",
            "Grande-Rivière",
            "Grandes-Piles",
            "Grande-Vallée",
            "Grand-Métis",
            "Grand-Remous",
            "Grand-Saint-Esprit",
            "Grenville",
            "Grenville-sur-la-Rouge",
            "Gros-Mécatina",
            "Grosse-Île",
            "Grosses-Roches",
            "Guérin",
            "Ham-Nord",
            "Hampden",
            "Hampstead",
            "Harrington",
            "Hatley",
            "Havelock",
            "Havre-Saint-Pierre",
            "Hébertville",
            "Hébertville-Station",
            "Hemmingford",
            "Henryville",
            "Hérouxville",
            "Hinchinbrooke",
            "Honfleur",
            "Hope",
            "Hope Town",
            "Howick",
            "Huberdeau",
            "Hudson",
            "Huntingdon",
            "Inukjuak",
            "Inverness",
            "Irlande",
            "Ivry-sur-le-Lac",
            "Ivujivik",
            "Joliette",
            "Jonquière",
            "Kahnawake",
            "Kamouraska",
            "Kangiqsualujjuaq",
            "Kangiqsujuaq",
            "Kangirsuk",
            "Kawawachikamach",
            "Kazabazua",
            "Kebaowek",
            "Kiamika",
            "Kingsbury",
            "Kingsey Falls",
            "Kinnear\'s Mills",
            "Kipawa",
            "Kirkland",
            "Kitigan Zibi",
            "Kuujjuaq",
            "Kuujjuarapik",
            "La Baie",
            "La Bostonnais",
            "La Conception",
            "La Corne",
            "La Doré",
            "La Durantaye",
            "La Guadeloupe",
            "La Macaza",
            "La Malbaie",
            "La Martre",
            "La Minerve",
            "La Morandière",
            "La Motte",
            "La Patrie",
            "La Pêche",
            "La Pocatière",
            "La Prairie",
            "La Présentation",
            "La Rédemption",
            "La Reine",
            "La Romaine",
            "La Sarre",
            "La Trinité-des-Monts",
            "La Tuque",
            "La Visitation-de-l\'Île-Dupas",
            "La Visitation-de-Yamaska",
            "Labelle",
            "Labrecque",
            "Lac-Ashuapmushuan",
            "Lac-au-Brochet",
            "Lac-au-Saumon",
            "Lac-aux-Sables",
            "Lac-Beauport",
            "Lac-Bouchette",
            "Lac-Brome",
            "Lac-Casault",
            "Lac-Chicobi",
            "Lac-Delage",
            "Lac-des-Aigles",
            "Lac-des-Écorces",
            "Lac-Despinassy",
            "Lac-des-Plages",
            "Lac-des-Seize-Îles",
            "Lac-Devenyns",
            "Lac-Drolet",
            "Lac-du-Cerf",
            "Lac-Édouard",
            "Lac-Etchemin",
            "Lac-Fouillac",
            "Lac-Frontière",
            "Lac-Granet",
            "Lachute",
            "Lac-John",
            "Lac-Masketsi",
            "Lac-Matapédia",
            "Lac-Matawin",
            "Lac-Mégantic",
            "Lac-Nilgaut",
            "Lacolle",
            "Lac-Pikauba",
            "Lac-Poulin",
            "Lac-Pythonga",
            "Lac-Rapide",
            "Lac-Saguay",
            "Lac-Sainte-Marie",
            "Lac-Saint-Joseph",
            "Lac-Saint-Paul",
            "Lac-Sergent",
            "Lac-Simon",
            "Lac-Simon",
            "Lac-Supérieur",
            "Lac-Tremblant-Nord",
            "Lac-Walker",
            "Laforce",
            "Lamarche",
            "Lambton",
            "L\'Ancienne-Lorette",
            "Landrienne",
            "L\'Ange-Gardien",
            "L\'Ange-Gardien",
            "Laniel",
            "Lanoraie",
            "L\'Anse-Saint-Jean",
            "Lantier",
            "Larouche",
            "L\'Ascension",
            "L\'Ascension-de-Notre-Seigneur",
            "L\'Ascension-de-Patapédia",
            "L\'Assomption",
            "Laterrière",
            "Latulipe-et-Gaboury",
            "Launay",
            "Laurier-Station",
            "Laurierville",
            "Laval",
            "Lavaltrie",
            "L\'Avenir",
            "Laverlochère",
            "Lawrenceville",
            "Le Bic",
            "Lebel-sur-Quévillon",
            "Leclercville",
            "Lefebvre",
            "Lejeune",
            "Lemieux",
            "L\'Épiphanie",
            "Léry",
            "Les Bergeronnes",
            "Les Cèdres",
            "Les Coteaux",
            "Les Éboulements",
            "Les Escoumins",
            "Les Hauteurs",
            "Les Îles-de-la-Madeleine",
            "Les Méchins",
            "Lévis",
            "L\'Île-Cadieux",
            "L\'Île-d\'Anticosti",
            "L\'Île-Dorval",
            "L\'Île-Perrot",
            "Lingwick",
            "Linton",
            "L\'Isle-aux-Allumettes",
            "L\'Isle-aux-Coudres",
            "L\'Islet",
            "L\'Isle-Verte",
            "Listuguj",
            "Litchfield",
            "Lochaber",
            "Lochaber-Partie-Ouest",
            "Longue-Pointe-de-Mingan",
            "Longue-Rive",
            "Longueuil",
            "Lorraine",
            "Lorrainville",
            "Lotbinière",
            "Louiseville",
            "Low",
            "Lyster",
            "Macamic",
            "Maddington",
            "Magog",
            "Malartic",
            "Maliotenam",
            "Manawan",
            "Mandeville",
            "Maniwaki",
            "Manseau",
            "Mansfield-et-Pontefract",
            "Maria",
            "Maricourt",
            "Marieville",
            "Marsoui",
            "Marston",
            "Martinville",
            "Mascouche",
            "Mashteuiatsh",
            "Maskinongé",
            "Massueville",
            "Matagami",
            "Matane",
            "Matapédia",
            "Matchi-Manitou",
            "Matimekosh",
            "Mayo",
            "McMasterville",
            "Melbourne",
            "Mercier",
            "Messines",
            "Métabetchouan–Lac-à-la-Croix",
            "Métis-sur-Mer",
            "Milan",
            "Mille-Isles",
            "Mingan",
            "Mirabel",
            "Mistissini",
            "Moffet",
            "Mont-Albert",
            "Montcalm",
            "Mont-Carmel",
            "Montcerf-Lytton",
            "Montebello",
            "Mont-Élie",
            "Mont-Joli",
            "Mont-Laurier",
            "Montmagny",
            "Montpellier",
            "Montréal",
            "Montréal-Est",
            "Montréal-Ouest",
            "Mont-Royal",
            "Mont-Saint-Grégoire",
            "Mont-Saint-Hilaire",
            "Mont-Saint-Michel",
            "Mont-Saint-Pierre",
            "Mont-Tremblant",
            "Mont-Valin",
            "Morin-Heights",
            "Mulgrave-et-Derry",
            "Murdochville",
            "Namur",
            "Nantes",
            "Napierville",
            "Natashquan",
            "Natashquan",
            "Nédélec",
            "Nemiscau",
            "Neuville",
            "New Carlisle",
            "New Richmond",
            "Newport",
            "Nicolet",
            "Nominingue",
            "Norbertville",
            "Normandin",
            "Normétal",
            "North Hatley",
            "Notre-Dame-Auxiliatrice-de-Buckland",
            "Notre-Dame-de-Bonsecours",
            "Notre-Dame-de-Ham",
            "Notre-Dame-de-la-Merci",
            "Notre-Dame-de-la-Paix",
            "Notre-Dame-de-la-Salette",
            "Notre-Dame-de-l\'Île-Perrot",
            "Notre-Dame-de-Lorette",
            "Notre-Dame-de-Lourdes",
            "Notre-Dame-de-Lourdes",
            "Notre-Dame-de-Montauban",
            "Notre-Dame-de-Pontmain",
            "Notre-Dame-des-Anges",
            "Notre-Dame-des-Bois",
            "Notre-Dame-des-Monts",
            "Notre-Dame-des-Neiges",
            "Notre-Dame-des-Pins",
            "Notre-Dame-des-Prairies",
            "Notre-Dame-des-Sept-Douleurs",
            "Notre-Dame-de-Stanbridge",
            "Notre-Dame-du-Bon-Conseil",
            "Notre-Dame-du-Lac",
            "Notre-Dame-du-Laus",
            "Notre-Dame-du-Mont-Carmel",
            "Notre-Dame-du-Nord",
            "Notre-Dame-du-Portage",
            "Notre-Dame-du-Rosaire",
            "Notre-Dame-du-Sacré-Coeur-d\'Issoudun",
            "Nouvelle",
            "Noyan",
            "Obedjiwan",
            "Odanak",
            "Ogden",
            "Oka",
            "Orford",
            "Ormstown",
            "Otter Lake",
            "Otterburn Park",
            "Packington",
            "Padoue",
            "Palmarolle",
            "Papineauville",
            "Parisville",
            "Paspébiac",
            "Percé",
            "Péribonka",
            "Petite-Rivière-Saint-François",
            "Petite-Vallée",
            "Petit-Saguenay",
            "Picard",
            "Piedmont",
            "Pierreville",
            "Pikogan",
            "Pincourt",
            "Piopolis",
            "Plaisance",
            "Plessisville",
            "Pohénégamook",
            "Pointe-à-la-Croix",
            "Pointe-aux-Outardes",
            "Pointe-Calumet",
            "Pointe-Claire",
            "Pointe-des-Cascades",
            "Pointe-Fortune",
            "Pointe-Lebel",
            "Pontiac",
            "Pont-Rouge",
            "Portage-du-Fort",
            "Port-Cartier",
            "Port-Daniel–Gascons",
            "Portneuf",
            "Portneuf-sur-Mer",
            "Potton",
            "Poularies",
            "Preissac",
            "Prévost",
            "Price",
            "Princeville",
            "Puvirnituq",
            "Quaqtaq",
            "Québec",
            "Racine",
            "Ragueneau",
            "Rapide-Danseur",
            "Rapides-des-Joachims",
            "Rawdon",
            "Rémigny",
            "Repentigny",
            "Réservoir-Dozois",
            "Richelieu",
            "Richmond",
            "Rigaud",
            "Rimouski",
            "Ripon",
            "Ristigouche-Partie-Sud-Est",
            "Rivière-à-Claude",
            "Rivière-à-Pierre",
            "Rivière-au-Tonnerre",
            "Rivière-aux-Outardes",
            "Rivière-Beaudette",
            "Rivière-Bleue",
            "Rivière-du-Loup",
            "Rivière-Éternité",
            "Rivière-Héva",
            "Rivière-Mistassini",
            "Rivière-Ojima",
            "Rivière-Ouelle",
            "Rivière-Rouge",
            "Rivière-Saint-Jean",
            "Roberval",
            "Rochebaucourt",
            "Roquemaure",
            "Rosemère",
            "Rougemont",
            "Routhierville",
            "Rouyn-Noranda",
            "Roxton",
            "Roxton Falls",
            "Roxton Pond",
            "Sacré-Cœur",
            "Sacré-Coeur-de-Jésus",
            "Sagard",
            "Saint-Adalbert",
            "Saint-Adelme",
            "Saint-Adelphe",
            "Saint-Adolphe-d\'Howard",
            "Saint-Adrien",
            "Saint-Adrien-d\'Irlande",
            "Saint-Agapit",
            "Saint-Aimé",
            "Saint-Aimé-des-Lacs",
            "Saint-Aimé-du-Lac-des-Îles",
            "Saint-Alban",
            "Saint-Albert",
            "Saint-Alexandre",
            "Saint-Alexandre-de-Kamouraska",
            "Saint-Alexandre-des-Lacs",
            "Saint-Alexis",
            "Saint-Alexis-de-Matapédia",
            "Saint-Alexis-des-Monts",
            "Saint-Alfred",
            "Saint-Alphonse",
            "Saint-Alphonse",
            "Saint-Alphonse-Rodrigue",
            "Saint-Amable",
            "Saint-Ambroise",
            "Saint-Ambroise-de-Kildare",
            "Saint-Anaclet-de-Lessard",
            "Saint-André",
            "Saint-André-Avellin",
            "Saint-André-d\'Argenteuil",
            "Saint-André-de-Restigouche",
            "Saint-André-du-Lac-Saint-Jean",
            "Saint-Anicet",
            "Saint-Anselme",
            "Saint-Antoine-de-l\'Isle-aux-Grues",
            "Saint-Antoine-de-Tilly",
            "Saint-Antoine-sur-Richelieu",
            "Saint-Antonin",
            "Saint-Apollinaire",
            "Saint-Armand",
            "Saint-Arsène",
            "Saint-Athanase",
            "Saint-Aubert",
            "Saint-Augustin",
            "Saint-Augustin",
            "Saint-Augustin-de-Desmaures",
            "Saint-Augustin-de-Woburn",
            "Saint-Barnabé",
            "Saint-Barnabé-Sud",
            "Saint-Barthélemy",
            "Saint-Basile",
            "Saint-Basile-le-Grand",
            "Saint-Benjamin",
            "Saint-Benoît-du-Lac",
            "Saint-Benoît-Labre",
            "Saint-Bernard",
            "Saint-Bernard-de-Lacolle",
            "Saint-Bernard-de-Michaudville",
            "Saint-Blaise-sur-Richelieu",
            "Saint-Bonaventure",
            "Saint-Boniface",
            "Saint-Bruno",
            "Saint-Bruno-de-Guigues",
            "Saint-Bruno-de-Kamouraska",
            "Saint-Bruno-de-Montarville",
            "Saint-Calixte",
            "Saint-Camille",
            "Saint-Camille-de-Lellis",
            "Saint-Casimir",
            "Saint-Célestin",
            "Saint-Césaire",
            "Saint-Charles-Borromée",
            "Saint-Charles-de-Bellechasse",
            "Saint-Charles-de-Bourget",
            "Saint-Charles-Garnier",
            "Saint-Charles-sur-Richelieu",
            "Saint-Christophe-d\'Arthabaska",
            "Saint-Chrysostome",
            "Saint-Claude",
            "Saint-Clément",
            "Saint-Cléophas",
            "Saint-Cléophas-de-Brandon",
            "Saint-Clet",
            "Saint-Colomban",
            "Saint-Côme",
            "Saint-Côme–Linière",
            "Saint-Constant",
            "Saint-Cuthbert",
            "Saint-Cyprien",
            "Saint-Cyprien",
            "Saint-Cyprien-de-Napierville",
            "Saint-Cyrille-de-Lessard",
            "Saint-Cyrille-de-Wendover",
            "Saint-Damase",
            "Saint-Damase",
            "Saint-Damase-de-L\'Islet",
            "Saint-Damien",
            "Saint-Damien-de-Buckland",
            "Saint-David",
            "Saint-David-de-Falardeau",
            "Saint-Denis",
            "Saint-Denis-de-Brompton",
            "Saint-Denis-sur-Richelieu",
            "Saint-Didace",
            "Saint-Dominique",
            "Saint-Dominique-du-Rosaire",
            "Saint-Donat",
            "Saint-Donat",
            "Sainte-Adèle",
            "Sainte-Agathe-de-Lotbinière",
            "Sainte-Agathe-des-Monts",
            "Sainte-Angèle-de-Mérici",
            "Sainte-Angèle-de-Monnoir",
            "Sainte-Angèle-de-Prémont",
            "Sainte-Anne-de-Beaupré",
            "Sainte-Anne-de-Bellevue",
            "Sainte-Anne-de-la-Pérade",
            "Sainte-Anne-de-la-Pocatière",
            "Sainte-Anne-de-la-Rochelle",
            "Sainte-Anne-de-Sabrevois",
            "Sainte-Anne-des-Lacs",
            "Sainte-Anne-des-Monts",
            "Sainte-Anne-de-Sorel",
            "Sainte-Anne-des-Plaines",
            "Sainte-Anne-du-Lac",
            "Sainte-Anne-du-Sault",
            "Sainte-Apolline-de-Patton",
            "Sainte-Aurélie",
            "Sainte-Barbe",
            "Sainte-Béatrix",
            "Sainte-Brigide-d\'Iberville",
            "Sainte-Brigitte-de-Laval",
            "Sainte-Brigitte-des-Saults",
            "Sainte-Catherine",
            "Sainte-Catherine-de-Hatley",
            "Sainte-Catherine-de-la-Jacques-Cartier",
            "Sainte-Cécile-de-Lévrard",
            "Sainte-Cécile-de-Milton",
            "Sainte-Cécile-de-Whitton",
            "Sainte-Christine",
            "Sainte-Christine-d\'Auvergne",
            "Sainte-Claire",
            "Sainte-Clotilde-de-Beauce",
            "Sainte-Clotilde-de-Châteauguay",
            "Sainte-Clotilde-de-Horton",
            "Sainte-Croix",
            "Saint-Edmond-de-Grantham",
            "Saint-Edmond-les-Plaines",
            "Saint-Édouard",
            "Saint-Édouard-de-Fabre",
            "Saint-Édouard-de-Lotbinière",
            "Saint-Édouard-de-Maskinongé",
            "Sainte-Edwidge-de-Clifton",
            "Sainte-Élisabeth",
            "Sainte-Élisabeth-de-Warwick",
            "Sainte-Émélie-de-l\'Énergie",
            "Sainte-Eulalie",
            "Sainte-Euphémie-sur-Rivière-du-Sud",
            "Sainte-Famille",
            "Sainte-Félicité",
            "Sainte-Félicité",
            "Sainte-Flavie",
            "Sainte-Florence",
            "Sainte-Françoise",
            "Sainte-Françoise",
            "Sainte-Geneviève-de-Batiscan",
            "Sainte-Geneviève-de-Berthier",
            "Sainte-Germaine-Boulé",
            "Sainte-Gertrude-Manneville",
            "Sainte-Hedwidge",
            "Sainte-Hélène",
            "Sainte-Hélène-de-Bagot",
            "Sainte-Hélène-de-Mancebourg",
            "Sainte-Hénédine",
            "Sainte-Irène",
            "Sainte-Jeanne-d\'Arc",
            "Sainte-Jeanne-d\'Arc",
            "Sainte-Julie",
            "Sainte-Julienne",
            "Sainte-Justine",
            "Sainte-Justine-de-Newton",
            "Saint-Élie-de-Caxton",
            "Saint-Éloi",
            "Sainte-Louise",
            "Saint-Elphège",
            "Sainte-Luce",
            "Sainte-Lucie-de-Beauregard",
            "Sainte-Lucie-des-Laurentides",
            "Saint-Elzéar",
            "Saint-Elzéar",
            "Saint-Elzéar-de-Témiscouata",
            "Sainte-Madeleine",
            "Sainte-Madeleine-de-la-Rivière-Madeleine",
            "Sainte-Marcelline-de-Kildare",
            "Sainte-Marguerite",
            "Sainte-Marguerite",
            "Sainte-Marguerite-du-Lac-Masson",
            "Sainte-Marie",
            "Sainte-Marie-de-Blandford",
            "Sainte-Marie-Madeleine",
            "Sainte-Marie-Salomé",
            "Sainte-Marthe",
            "Sainte-Marthe-sur-le-Lac",
            "Sainte-Martine",
            "Sainte-Mélanie",
            "Saint-Émile-de-Suffolk",
            "Sainte-Monique",
            "Sainte-Monique",
            "Sainte-Paule",
            "Sainte-Perpétue",
            "Sainte-Perpétue",
            "Sainte-Pétronille",
            "Saint-Éphrem-de-Beauce",
            "Saint-Épiphane",
            "Sainte-Praxède",
            "Sainte-Rita",
            "Sainte-Rose-de-Watford",
            "Sainte-Rose-du-Nord",
            "Sainte-Sabine",
            "Sainte-Sabine",
            "Sainte-Séraphine",
            "Sainte-Sophie",
            "Sainte-Sophie-de-Lévrard",
            "Sainte-Sophie-d\'Halifax",
            "Saint-Esprit",
            "Sainte-Thècle",
            "Sainte-Thérèse",
            "Sainte-Thérèse-de-Gaspé",
            "Sainte-Thérèse-de-la-Gatineau",
            "Saint-Étienne-de-Beauharnois",
            "Saint-Étienne-de-Bolton",
            "Saint-Étienne-des-Grès",
            "Saint-Eugène",
            "Saint-Eugène-de-Guigues",
            "Saint-Eugène-de-Ladrière",
            "Saint-Eugènes",
            "Sainte-Ursule",
            "Saint-Eusèbe",
            "Saint-Eustache",
            "Saint-Évariste-de-Forsyth",
            "Sainte-Victoire-de-Sorel",
            "Saint-Fabien",
            "Saint-Fabien-de-Panet",
            "Saint-Faustin–Lac-Carré",
            "Saint-Félicien",
            "Saint-Félix-de-Dalquier",
            "Saint-Félix-de-Kingsey",
            "Saint-Félix-de-Valois",
            "Saint-Félix-d\'Otis",
            "Saint-Ferdinand",
            "Saint-Ferréol-les-Neiges",
            "Saint-Flavien",
            "Saint-Fortunat",
            "Saint-François-d\'Assise",
            "Saint-François-de-la-Rivière-du-Sud",
            "Saint-François-de-l\'Île-d\'Orléans",
            "Saint-François-de-Sales",
            "Saint-François-du-Lac",
            "Saint-François-Xavier-de-Brompton",
            "Saint-François-Xavier-de-Viger",
            "Saint-Frédéric",
            "Saint-Fulgence",
            "Saint-Gabriel",
            "Saint-Gabriel-de-Brandon",
            "Saint-Gabriel-de-Rimouski",
            "Saint-Gabriel-de-Valcartier",
            "Saint-Gabriel-Lalemant",
            "Saint-Gédéon",
            "Saint-Gédéon-de-Beauce",
            "Saint-Georges",
            "Saint-Georges-de-Clarenceville",
            "Saint-Georges-de-Windsor",
            "Saint-Gérard-Majella",
            "Saint-Germain",
            "Saint-Germain-de-Grantham",
            "Saint-Gervais",
            "Saint-Gilbert",
            "Saint-Gilles",
            "Saint-Godefroi",
            "Saint-Guillaume",
            "Saint-Guillaume-Nord",
            "Saint-Guy",
            "Saint-Henri",
            "Saint-Henri-de-Taillon",
            "Saint-Herménégilde",
            "Saint-Hilaire-de-Dorset",
            "Saint-Hilarion",
            "Saint-Hippolyte",
            "Saint-Honoré-de-Chicoutimi",
            "Saint-Honoré-de-Shenley",
            "Saint-Honoré-de-Témiscouata",
            "Saint-Hubert-de-Rivière-du-Loup",
            "Saint-Hugues",
            "Saint-Hyacinthe",
            "Saint-Ignace-de-Loyola",
            "Saint-Ignace-de-Stanbridge",
            "Saint-Irénée",
            "Saint-Isidore",
            "Saint-Isidore",
            "Saint-Isidore-de-Clifton",
            "Saint-Jacques",
            "Saint-Jacques-de-Leeds",
            "Saint-Jacques-le-Majeur-de-Wolfestown",
            "Saint-Jacques-le-Mineur",
            "Saint-Janvier-de-Joly",
            "Saint-Jean-Baptiste",
            "Saint-Jean-de-Brébeuf",
            "Saint-Jean-de-Cherbourg",
            "Saint-Jean-de-Dieu",
            "Saint-Jean-de-la-Lande",
            "Saint-Jean-de-l\'Île-d\'Orléans",
            "Saint-Jean-de-Matha",
            "Saint-Jean-Port-Joli",
            "Saint-Jean-sur-Richelieu",
            "Saint-Jérôme",
            "Saint-Joachim",
            "Saint-Joachim-de-Shefford",
            "Saint-Joseph-de-Beauce",
            "Saint-Joseph-de-Coleraine",
            "Saint-Joseph-de-Ham-Sud",
            "Saint-Joseph-de-Kamouraska",
            "Saint-Joseph-de-Lepage",
            "Saint-Joseph-des-Érables",
            "Saint-Joseph-de-Sorel",
            "Saint-Joseph-du-Lac",
            "Saint-Jude",
            "Saint-Jules",
            "Saint-Julien",
            "Saint-Just-de-Bretenières",
            "Saint-Juste-du-Lac",
            "Saint-Justin",
            "Saint-Lambert",
            "Saint-Lambert",
            "Saint-Lambert-de-Lauzon",
            "Saint-Laurent-de-l\'Île-d\'Orléans",
            "Saint-Lazare",
            "Saint-Lazare-de-Bellechasse",
            "Saint-Léandre",
            "Saint-Léonard-d\'Aston",
            "Saint-Léonard-de-Portneuf",
            "Saint-Léon-de-Standon",
            "Saint-Léon-le-Grand",
            "Saint-Léon-le-Grand",
            "Saint-Liboire",
            "Saint-Liguori",
            "Saint-Lin–Laurentides",
            "Saint-Louis",
            "Saint-Louis-de-Blandford",
            "Saint-Louis-de-Gonzague",
            "Saint-Louis-de-Gonzague",
            "Saint-Louis-de-Gonzague-du-Cap-Tourmente",
            "Saint-Louis-du-Ha! Ha!",
            "Saint-Luc-de-Bellechasse",
            "Saint-Luc-de-Vincennes",
            "Saint-Lucien",
            "Saint-Ludger",
            "Saint-Ludger-de-Milot",
            "Saint-Magloire",
            "Saint-Majorique-de-Grantham",
            "Saint-Malachie",
            "Saint-Malo",
            "Saint-Marc-de-Figuery",
            "Saint-Marc-des-Carrières",
            "Saint-Marc-du-Lac-Long",
            "Saint-Marcel",
            "Saint-Marcel-de-Richelieu",
            "Saint-Marcellin",
            "Saint-Marc-sur-Richelieu",
            "Saint-Martin",
            "Saint-Mathias-sur-Richelieu",
            "Saint-Mathieu",
            "Saint-Mathieu-de-Beloeil",
            "Saint-Mathieu-de-Rioux",
            "Saint-Mathieu-d\'Harricana",
            "Saint-Mathieu-du-Parc",
            "Saint-Maurice",
            "Saint-Maxime-du-Mont-Louis",
            "Saint-Médard",
            "Saint-Michel",
            "Saint-Michel-de-Bellechasse",
            "Saint-Michel-des-Saints",
            "Saint-Michel-du-Squatec",
            "Saint-Modeste",
            "Saint-Moïse",
            "Saint-Narcisse",
            "Saint-Narcisse-de-Beaurivage",
            "Saint-Narcisse-de-Rimouski",
            "Saint-Nazaire",
            "Saint-Nazaire-d\'Acton",
            "Saint-Nazaire-de-Dorchester",
            "Saint-Nérée",
            "Saint-Noël",
            "Saint-Norbert",
            "Saint-Norbert-d\'Arthabaska",
            "Saint-Octave-de-Métis",
            "Saint-Odilon-de-Cranbourne",
            "Saint-Omer",
            "Saint-Onésime-d\'Ixworth",
            "Saint-Ours",
            "Saint-Pacôme",
            "Saint-Pamphile",
            "Saint-Pascal",
            "Saint-Patrice-de-Beaurivage",
            "Saint-Patrice-de-Sherrington",
            "Saint-Paul",
            "Saint-Paul-d\'Abbotsford",
            "Saint-Paul-de-la-Croix",
            "Saint-Paul-de-l\'Île-aux-Noix",
            "Saint-Paul-de-Montminy",
            "Saint-Paulin",
            "Saint-Philémon",
            "Saint-Philibert",
            "Saint-Philippe",
            "Saint-Philippe-de-Néri",
            "Saint-Pie",
            "Saint-Pie-de-Guire",
            "Saint-Pierre",
            "Saint-Pierre-Baptiste",
            "Saint-Pierre-de-Broughton",
            "Saint-Pierre-de-Lamy",
            "Saint-Pierre-de-la-Rivière-du-Sud",
            "Saint-Pierre-de-l\'Île-d\'Orléans",
            "Saint-Pierre-de-Véronne-à-Pike-River",
            "Saint-Pierre-les-Becquets",
            "Saint-Placide",
            "Saint-Polycarpe",
            "Saint-Prime",
            "Saint-Prosper",
            "Saint-Prosper",
            "Saint-Raphaël",
            "Saint-Raymond",
            "Saint-Rémi",
            "Saint-Rémi-de-Tingwick",
            "Saint-René",
            "Saint-René-de-Matane",
            "Saint-Robert",
            "Saint-Robert-Bellarmin",
            "Saint-Roch-de-l\'Achigan",
            "Saint-Roch-de-Mékinac",
            "Saint-Roch-de-Richelieu",
            "Saint-Roch-des-Aulnaies",
            "Saint-Roch-Ouest",
            "Saint-Romain",
            "Saint-Romuald",
            "Saint-Rosaire",
            "Saint-Samuel",
            "Saints-Anges",
            "Saint-Sauveur",
            "Saint-Sébastien",
            "Saint-Sébastien",
            "Saint-Sévère",
            "Saint-Séverin",
            "Saint-Séverin",
            "Saint-Siméon",
            "Saint-Siméon",
            "Saint-Simon",
            "Saint-Simon",
            "Saint-Simon-les-Mines",
            "Saint-Sixte",
            "Saints-Martyrs-Canadiens",
            "Saint-Stanislas",
            "Saint-Stanislas",
            "Saint-Stanislas-de-Kostka",
            "Saint-Sulpice",
            "Saint-Sylvère",
            "Saint-Sylvestre",
            "Saint-Télesphore",
            "Saint-Tharcisius",
            "Saint-Théodore-d\'Acton",
            "Saint-Théophile",
            "Saint-Thomas",
            "Saint-Thomas Didyme",
            "Saint-Thuribe",
            "Saint-Tite",
            "Saint-Tite-des-Caps",
            "Saint-Ubalde",
            "Saint-Ulric",
            "Saint-Urbain",
            "Saint-Urbain-Premier",
            "Saint-Valentin",
            "Saint-Valère",
            "Saint-Valérien",
            "Saint-Valérien-de-Milton",
            "Saint-Vallier",
            "Saint-Venant-de-Paquette",
            "Saint-Vianney",
            "Saint-Victor",
            "Saint-Wenceslas",
            "Saint-Zacharie",
            "Saint-Zénon",
            "Saint-Zénon-du-Lac-Humqui",
            "Saint-Zéphirin-de-Courval",
            "Saint-Zotique",
            "Salaberry-de-Valleyfield",
            "Salluit",
            "Sayabec",
            "Schefferville",
            "Scotstown",
            "Scott",
            "Senneterre",
            "Senneville",
            "Sept-Iles",
            "Shannon",
            "Shawinigan",
            "Shawville",
            "Sheenboro",
            "Shefford",
            "Sherbrooke",
            "Shigawake",
            "Shipshaw",
            "Sorel-Tracy",
            "Stanbridge East",
            "Stanbridge Station",
            "Stanstead",
            "Stanstead-Est",
            "Stoke",
            "Stoneham-et-Tewkesbury",
            "Stornoway",
            "Stratford",
            "Stukely-Sud",
            "Sutton",
            "Tadoussac",
            "Taschereau",
            "Tasiujaq",
            "Témiscaming",
            "Terrasse-Vaudreuil",
            "Terrebonne",
            "Thetford Mines",
            "Thorne",
            "Thurso",
            "Timiskaming",
            "Tingwick",
            "Tourville",
            "Trécesson",
            "Très-Saint-Rédempteur",
            "Très-Saint-Sacrement",
            "Tring-Jonction",
            "Trois-Pistoles",
            "Trois-Rives",
            "Trois-Rivières",
            "Uashat",
            "Ulverton",
            "Umiujaq",
            "Upton",
            "Val-Alain",
            "Val-Brillant",
            "Valcourt",
            "Val-David",
            "Val-des-Bois",
            "Val-des-Lacs",
            "Val-des-Monts",
            "Val-d\'Or",
            "Val-Joli",
            "Vallée-Jonction",
            "Val-Morin",
            "Val-Racine",
            "Val-Saint-Gilles",
            "Varennes",
            "Vaudreuil-Dorion",
            "Vaudreuil-sur-le-Lac",
            "Venise-en-Québec",
            "Verchères",
            "Victoriaville",
            "Ville Saguenay",
            "Ville-Marie",
            "Villeroy",
            "Waltham",
            "Warden",
            "Warwick",
            "Waskaganish",
            "Waswanipi",
            "Waterloo",
            "Waterville",
            "Weedon",
            "Wemindji",
            "Wemotaci",
            "Wendake",
            "Wentworth",
            "Wentworth-Nord",
            "Westbury",
            "Westmount",
            "Whapmagoostui",
            "Wickham",
            "Windsor",
            "Wôlinak",
            "Wotton",
            "Yamachiche",
            "Yamaska",
            "",
            "Abercorn",
            "Acton Vale",
            "Adstock",
            "Aguanish",
            "Akulivik",
            "Akwesasne",
            "Albanel",
            "Albertville",
            "Alleyn-et-Cawood",
            "Alma",
            "Amherst",
            "Amos",
            "Amqui",
            "Ange-Gardien",
            "Angliers",
            "Armagh",
            "Arundel",
            "Asbestos",
            "Ascot Corner",
            "Aston-Jonction",
            "Auclair",
            "Audet",
            "Aumond",
            "Aupaluk",
            "Austin",
            "Authier",
            "Authier-Nord",
            "Ayer\'s Cliff",
            "Baie-Comeau",
            "Baie-de-la-Bouteille",
            "Baie-des-Sables",
            "Baie-du-Febvre",
            "Baie-D\'Urfé",
            "Baie-James",
            "Baie-Johan-Beetz",
            "Baie-Sainte-Catherine",
            "Baie-Saint-Paul",
            "Baie-Trinité",
            "Barkmere",
            "Barnston-Ouest",
            "Barraute",
            "Batiscan",
            "Beaconsfield",
            "Béarn",
            "Beauceville",
            "Beauharnois",
            "Beaulac-Garthby",
            "Beaumont",
            "Beaupré",
            "Bécancour",
            "Bedford",
            "Bégin",
            "Belcourt",
            "Belleterre",
            "Beloeil",
            "Berry",
            "Berthier-sur-Mer",
            "Berthierville",
            "Béthanie",
            "Betsiamites",
            "Biencourt",
            "Blainville",
            "Blanc-Sablon",
            "Blue Sea",
            "Boileau",
            "Boisbriand",
            "Boischatel",
            "Bois-des-Filion",
            "Bois-Franc",
            "Bolton-Est",
            "Bolton-Ouest",
            "Bonaventure",
            "Bonne-Espérance",
            "Bonsecours",
            "Boucherville",
            "Bouchette",
            "Bowman",
            "Brébeuf",
            "Brigham",
            "Bristol",
            "Brome",
            "Bromont",
            "Brossard",
            "Brownsburg-Chatham",
            "Bryson",
            "Bury",
            "Cabano",
            "Cacouna",
            "Calixa-Lavallée",
            "Campbell\'s Bay",
            "Candiac",
            "Cantley",
            "Canton-Tremblay",
            "Cap-Chat",
            "Caplan",
            "Cap-Saint-Ignace",
            "Cap-Santé",
            "Carignan",
            "Carleton-sur-Mer",
            "Cascapédia–Saint-Jules",
            "Causapscal",
            "Cayamant",
            "Chambly",
            "Chambord",
            "Champlain",
            "Champneuf",
            "Chandler",
            "Chapais",
            "Charlemagne",
            "Charrette",
            "Chartierville",
            "Châteauguay",
            "Château-Richer",
            "Chazel",
            "Chelsea",
            "Chénéville",
            "Chertsey",
            "Chester-Est",
            "Chesterville",
            "Chibougamau",
            "Chichester",
            "Chicoutimi",
            "Chicoutimi-Nord",
            "Chisasibi",
            "Chute-aux-Outardes",
            "Chute-Des-Passes",
            "Chute-Saint-Philippe",
            "Clarendon",
            "Clermont",
            "Clermont",
            "Clerval",
            "Cleveland",
            "Cloridorme",
            "Coaticook",
            "Colombier",
            "Compton",
            "Contrecoeur",
            "Cookshire-Eaton",
            "Coteau-du-Lac",
            "Côte-Nord-du-Golfe-du-Saint-Laurent",
            "Côte-Saint-Luc",
            "Courcelles",
            "Cowansville",
            "Crabtree",
            "Danville",
            "Daveluyville",
            "Dégelis",
            "Déléage",
            "Delson",
            "Denholm",
            "Desbiens",
            "Deschaillons-sur-Saint-Laurent",
            "Deschambault-Grondines",
            "Deux-Montagnes",
            "Disraeli",
            "Dixville",
            "Dolbeau",
            "Dollard-Des Ormeaux",
            "Doncaster",
            "Donnacona",
            "Dorval",
            "Dosquet",
            "Drummondville",
            "Dudswell",
            "Duhamel",
            "Duhamel-Ouest",
            "Dundee",
            "Dunham",
            "Duparquet",
            "Dupuy",
            "Durham-Sud",
            "East Angus",
            "East Broughton",
            "East Farnham",
            "East Hereford",
            "Eastmain",
            "Eastman",
            "Egan-Sud",
            "Elgin",
            "Entrelacs",
            "Escuminac",
            "Esprit-Saint",
            "Essipit",
            "Estérel",
            "Farnham",
            "Fassett",
            "Ferland-et-Boilleau",
            "Ferme-Neuve",
            "Fermont",
            "Forestville",
            "Fort-Coulonge",
            "Fortierville",
            "Fossambault-sur-le-Lac",
            "Frampton",
            "Franklin",
            "Franquelin",
            "Frelighsburg",
            "Frontenac",
            "Fugèreville",
            "Gallichan",
            "Gaspé",
            "Gatineau",
            "Gesgapegiag",
            "Girardville",
            "Godbout",
            "Godmanchester",
            "Gore",
            "Gracefield",
            "Granby",
            "Grand-Calumet",
            "Grande-Rivière",
            "Grandes-Piles",
            "Grande-Vallée",
            "Grand-Métis",
            "Grand-Remous",
            "Grand-Saint-Esprit",
            "Grenville",
            "Grenville-sur-la-Rouge",
            "Gros-Mécatina",
            "Grosse-Île",
            "Grosses-Roches",
            "Guérin",
            "Ham-Nord",
            "Hampden",
            "Hampstead",
            "Harrington",
            "Hatley",
            "Havelock",
            "Havre-Saint-Pierre",
            "Hébertville",
            "Hébertville-Station",
            "Hemmingford",
            "Henryville",
            "Hérouxville",
            "Hinchinbrooke",
            "Honfleur",
            "Hope",
            "Hope Town",
            "Howick",
            "Huberdeau",
            "Hudson",
            "Huntingdon",
            "Inukjuak",
            "Inverness",
            "Irlande",
            "Ivry-sur-le-Lac",
            "Ivujivik",
            "Joliette",
            "Jonquière",
            "Kahnawake",
            "Kamouraska",
            "Kangiqsualujjuaq",
            "Kangiqsujuaq",
            "Kangirsuk",
            "Kawawachikamach",
            "Kazabazua",
            "Kebaowek",
            "Kiamika",
            "Kingsbury",
            "Kingsey Falls",
            "Kinnear\'s Mills",
            "Kipawa",
            "Kirkland",
            "Kitigan Zibi",
            "Kuujjuaq",
            "Kuujjuarapik",
            "La Baie",
            "La Bostonnais",
            "La Conception",
            "La Corne",
            "La Doré",
            "La Durantaye",
            "La Guadeloupe",
            "La Macaza",
            "La Malbaie",
            "La Martre",
            "La Minerve",
            "La Morandière",
            "La Motte",
            "La Patrie",
            "La Pêche",
            "La Pocatière",
            "La Prairie",
            "La Présentation",
            "La Rédemption",
            "La Reine",
            "La Romaine",
            "La Sarre",
            "La Trinité-des-Monts",
            "La Tuque",
            "La Visitation-de-l\'Île-Dupas",
            "La Visitation-de-Yamaska",
            "Labelle",
            "Labrecque",
            "Lac-Ashuapmushuan",
            "Lac-au-Brochet",
            "Lac-au-Saumon",
            "Lac-aux-Sables",
            "Lac-Beauport",
            "Lac-Bouchette",
            "Lac-Brome",
            "Lac-Casault",
            "Lac-Chicobi",
            "Lac-Delage",
            "Lac-des-Aigles",
            "Lac-des-Écorces",
            "Lac-Despinassy",
            "Lac-des-Plages",
            "Lac-des-Seize-Îles",
            "Lac-Devenyns",
            "Lac-Drolet",
            "Lac-du-Cerf",
            "Lac-Édouard",
            "Lac-Etchemin",
            "Lac-Fouillac",
            "Lac-Frontière",
            "Lac-Granet",
            "Lachute",
            "Lac-John",
            "Lac-Masketsi",
            "Lac-Matapédia",
            "Lac-Matawin",
            "Lac-Mégantic",
            "Lac-Nilgaut",
            "Lacolle",
            "Lac-Pikauba",
            "Lac-Poulin",
            "Lac-Pythonga",
            "Lac-Rapide",
            "Lac-Saguay",
            "Lac-Sainte-Marie",
            "Lac-Saint-Joseph",
            "Lac-Saint-Paul",
            "Lac-Sergent",
            "Lac-Simon",
            "Lac-Simon",
            "Lac-Supérieur",
            "Lac-Tremblant-Nord",
            "Lac-Walker",
            "Laforce",
            "Lamarche",
            "Lambton",
            "L\'Ancienne-Lorette",
            "Landrienne",
            "L\'Ange-Gardien",
            "L\'Ange-Gardien",
            "Laniel",
            "Lanoraie",
            "L\'Anse-Saint-Jean",
            "Lantier",
            "Larouche",
            "L\'Ascension",
            "L\'Ascension-de-Notre-Seigneur",
            "L\'Ascension-de-Patapédia",
            "L\'Assomption",
            "Laterrière",
            "Latulipe-et-Gaboury",
            "Launay",
            "Laurier-Station",
            "Laurierville",
            "Laval",
            "Lavaltrie",
            "L\'Avenir",
            "Laverlochère",
            "Lawrenceville",
            "Le Bic",
            "Lebel-sur-Quévillon",
            "Leclercville",
            "Lefebvre",
            "Lejeune",
            "Lemieux",
            "L\'Épiphanie",
            "Léry",
            "Les Bergeronnes",
            "Les Cèdres",
            "Les Coteaux",
            "Les Éboulements",
            "Les Escoumins",
            "Les Hauteurs",
            "Les Îles-de-la-Madeleine",
            "Les Méchins",
            "Lévis",
            "L\'Île-Cadieux",
            "L\'Île-d\'Anticosti",
            "L\'Île-Dorval",
            "L\'Île-Perrot",
            "Lingwick",
            "Linton",
            "L\'Isle-aux-Allumettes",
            "L\'Isle-aux-Coudres",
            "L\'Islet",
            "L\'Isle-Verte",
            "Listuguj",
            "Litchfield",
            "Lochaber",
            "Lochaber-Partie-Ouest",
            "Longue-Pointe-de-Mingan",
            "Longue-Rive",
            "Longueuil",
            "Lorraine",
            "Lorrainville",
            "Lotbinière",
            "Louiseville",
            "Low",
            "Lyster",
            "Macamic",
            "Maddington",
            "Magog",
            "Malartic",
            "Maliotenam",
            "Manawan",
            "Mandeville",
            "Maniwaki",
            "Manseau",
            "Mansfield-et-Pontefract",
            "Maria",
            "Maricourt",
            "Marieville",
            "Marsoui",
            "Marston",
            "Martinville",
            "Mascouche",
            "Mashteuiatsh",
            "Maskinongé",
            "Massueville",
            "Matagami",
            "Matane",
            "Matapédia",
            "Matchi-Manitou",
            "Matimekosh",
            "Mayo",
            "McMasterville",
            "Melbourne",
            "Mercier",
            "Messines",
            "Métabetchouan–Lac-à-la-Croix",
            "Métis-sur-Mer",
            "Milan",
            "Mille-Isles",
            "Mingan",
            "Mirabel",
            "Mistissini",
            "Moffet",
            "Mont-Albert",
            "Montcalm",
            "Mont-Carmel",
            "Montcerf-Lytton",
            "Montebello",
            "Mont-Élie",
            "Mont-Joli",
            "Mont-Laurier",
            "Montmagny",
            "Montpellier",
            "Montréal",
            "Montréal-Est",
            "Montréal-Ouest",
            "Mont-Royal",
            "Mont-Saint-Grégoire",
            "Mont-Saint-Hilaire",
            "Mont-Saint-Michel",
            "Mont-Saint-Pierre",
            "Mont-Tremblant",
            "Mont-Valin",
            "Morin-Heights",
            "Mulgrave-et-Derry",
            "Murdochville",
            "Namur",
            "Nantes",
            "Napierville",
            "Natashquan",
            "Natashquan",
            "Nédélec",
            "Nemiscau",
            "Neuville",
            "New Carlisle",
            "New Richmond",
            "Newport",
            "Nicolet",
            "Nominingue",
            "Norbertville",
            "Normandin",
            "Normétal",
            "North Hatley",
            "Notre-Dame-Auxiliatrice-de-Buckland",
            "Notre-Dame-de-Bonsecours",
            "Notre-Dame-de-Ham",
            "Notre-Dame-de-la-Merci",
            "Notre-Dame-de-la-Paix",
            "Notre-Dame-de-la-Salette",
            "Notre-Dame-de-l\'Île-Perrot",
            "Notre-Dame-de-Lorette",
            "Notre-Dame-de-Lourdes",
            "Notre-Dame-de-Lourdes",
            "Notre-Dame-de-Montauban",
            "Notre-Dame-de-Pontmain",
            "Notre-Dame-des-Anges",
            "Notre-Dame-des-Bois",
            "Notre-Dame-des-Monts",
            "Notre-Dame-des-Neiges",
            "Notre-Dame-des-Pins",
            "Notre-Dame-des-Prairies",
            "Notre-Dame-des-Sept-Douleurs",
            "Notre-Dame-de-Stanbridge",
            "Notre-Dame-du-Bon-Conseil",
            "Notre-Dame-du-Lac",
            "Notre-Dame-du-Laus",
            "Notre-Dame-du-Mont-Carmel",
            "Notre-Dame-du-Nord",
            "Notre-Dame-du-Portage",
            "Notre-Dame-du-Rosaire",
            "Notre-Dame-du-Sacré-Coeur-d\'Issoudun",
            "Nouvelle",
            "Noyan",
            "Obedjiwan",
            "Odanak",
            "Ogden",
            "Oka",
            "Orford",
            "Ormstown",
            "Otter Lake",
            "Otterburn Park",
            "Packington",
            "Padoue",
            "Palmarolle",
            "Papineauville",
            "Parisville",
            "Paspébiac",
            "Percé",
            "Péribonka",
            "Petite-Rivière-Saint-François",
            "Petite-Vallée",
            "Petit-Saguenay",
            "Picard",
            "Piedmont",
            "Pierreville",
            "Pikogan",
            "Pincourt",
            "Piopolis",
            "Plaisance",
            "Plessisville",
            "Pohénégamook",
            "Pointe-à-la-Croix",
            "Pointe-aux-Outardes",
            "Pointe-Calumet",
            "Pointe-Claire",
            "Pointe-des-Cascades",
            "Pointe-Fortune",
            "Pointe-Lebel",
            "Pontiac",
            "Pont-Rouge",
            "Portage-du-Fort",
            "Port-Cartier",
            "Port-Daniel–Gascons",
            "Portneuf",
            "Portneuf-sur-Mer",
            "Potton",
            "Poularies",
            "Preissac",
            "Prévost",
            "Price",
            "Princeville",
            "Puvirnituq",
            "Quaqtaq",
            "Québec",
            "Racine",
            "Ragueneau",
            "Rapide-Danseur",
            "Rapides-des-Joachims",
            "Rawdon",
            "Rémigny",
            "Repentigny",
            "Réservoir-Dozois",
            "Richelieu",
            "Richmond",
            "Rigaud",
            "Rimouski",
            "Ripon",
            "Ristigouche-Partie-Sud-Est",
            "Rivière-à-Claude",
            "Rivière-à-Pierre",
            "Rivière-au-Tonnerre",
            "Rivière-aux-Outardes",
            "Rivière-Beaudette",
            "Rivière-Bleue",
            "Rivière-du-Loup",
            "Rivière-Éternité",
            "Rivière-Héva",
            "Rivière-Mistassini",
            "Rivière-Ojima",
            "Rivière-Ouelle",
            "Rivière-Rouge",
            "Rivière-Saint-Jean",
            "Roberval",
            "Rochebaucourt",
            "Roquemaure",
            "Rosemère",
            "Rougemont",
            "Routhierville",
            "Rouyn-Noranda",
            "Roxton",
            "Roxton Falls",
            "Roxton Pond",
            "Sacré-Cœur",
            "Sacré-Coeur-de-Jésus",
            "Sagard",
            "Saint-Adalbert",
            "Saint-Adelme",
            "Saint-Adelphe",
            "Saint-Adolphe-d\'Howard",
            "Saint-Adrien",
            "Saint-Adrien-d\'Irlande",
            "Saint-Agapit",
            "Saint-Aimé",
            "Saint-Aimé-des-Lacs",
            "Saint-Aimé-du-Lac-des-Îles",
            "Saint-Alban",
            "Saint-Albert",
            "Saint-Alexandre",
            "Saint-Alexandre-de-Kamouraska",
            "Saint-Alexandre-des-Lacs",
            "Saint-Alexis",
            "Saint-Alexis-de-Matapédia",
            "Saint-Alexis-des-Monts",
            "Saint-Alfred",
            "Saint-Alphonse",
            "Saint-Alphonse",
            "Saint-Alphonse-Rodrigue",
            "Saint-Amable",
            "Saint-Ambroise",
            "Saint-Ambroise-de-Kildare",
            "Saint-Anaclet-de-Lessard",
            "Saint-André",
            "Saint-André-Avellin",
            "Saint-André-d\'Argenteuil",
            "Saint-André-de-Restigouche",
            "Saint-André-du-Lac-Saint-Jean",
            "Saint-Anicet",
            "Saint-Anselme",
            "Saint-Antoine-de-l\'Isle-aux-Grues",
            "Saint-Antoine-de-Tilly",
            "Saint-Antoine-sur-Richelieu",
            "Saint-Antonin",
            "Saint-Apollinaire",
            "Saint-Armand",
            "Saint-Arsène",
            "Saint-Athanase",
            "Saint-Aubert",
            "Saint-Augustin",
            "Saint-Augustin",
            "Saint-Augustin-de-Desmaures",
            "Saint-Augustin-de-Woburn",
            "Saint-Barnabé",
            "Saint-Barnabé-Sud",
            "Saint-Barthélemy",
            "Saint-Basile",
            "Saint-Basile-le-Grand",
            "Saint-Benjamin",
            "Saint-Benoît-du-Lac",
            "Saint-Benoît-Labre",
            "Saint-Bernard",
            "Saint-Bernard-de-Lacolle",
            "Saint-Bernard-de-Michaudville",
            "Saint-Blaise-sur-Richelieu",
            "Saint-Bonaventure",
            "Saint-Boniface",
            "Saint-Bruno",
            "Saint-Bruno-de-Guigues",
            "Saint-Bruno-de-Kamouraska",
            "Saint-Bruno-de-Montarville",
            "Saint-Calixte",
            "Saint-Camille",
            "Saint-Camille-de-Lellis",
            "Saint-Casimir",
            "Saint-Célestin",
            "Saint-Césaire",
            "Saint-Charles-Borromée",
            "Saint-Charles-de-Bellechasse",
            "Saint-Charles-de-Bourget",
            "Saint-Charles-Garnier",
            "Saint-Charles-sur-Richelieu",
            "Saint-Christophe-d\'Arthabaska",
            "Saint-Chrysostome",
            "Saint-Claude",
            "Saint-Clément",
            "Saint-Cléophas",
            "Saint-Cléophas-de-Brandon",
            "Saint-Clet",
            "Saint-Colomban",
            "Saint-Côme",
            "Saint-Côme–Linière",
            "Saint-Constant",
            "Saint-Cuthbert",
            "Saint-Cyprien",
            "Saint-Cyprien",
            "Saint-Cyprien-de-Napierville",
            "Saint-Cyrille-de-Lessard",
            "Saint-Cyrille-de-Wendover",
            "Saint-Damase",
            "Saint-Damase",
            "Saint-Damase-de-L\'Islet",
            "Saint-Damien",
            "Saint-Damien-de-Buckland",
            "Saint-David",
            "Saint-David-de-Falardeau",
            "Saint-Denis",
            "Saint-Denis-de-Brompton",
            "Saint-Denis-sur-Richelieu",
            "Saint-Didace",
            "Saint-Dominique",
            "Saint-Dominique-du-Rosaire",
            "Saint-Donat",
            "Saint-Donat",
            "Sainte-Adèle",
            "Sainte-Agathe-de-Lotbinière",
            "Sainte-Agathe-des-Monts",
            "Sainte-Angèle-de-Mérici",
            "Sainte-Angèle-de-Monnoir",
            "Sainte-Angèle-de-Prémont",
            "Sainte-Anne-de-Beaupré",
            "Sainte-Anne-de-Bellevue",
            "Sainte-Anne-de-la-Pérade",
            "Sainte-Anne-de-la-Pocatière",
            "Sainte-Anne-de-la-Rochelle",
            "Sainte-Anne-de-Sabrevois",
            "Sainte-Anne-des-Lacs",
            "Sainte-Anne-des-Monts",
            "Sainte-Anne-de-Sorel",
            "Sainte-Anne-des-Plaines",
            "Sainte-Anne-du-Lac",
            "Sainte-Anne-du-Sault",
            "Sainte-Apolline-de-Patton",
            "Sainte-Aurélie",
            "Sainte-Barbe",
            "Sainte-Béatrix",
            "Sainte-Brigide-d\'Iberville",
            "Sainte-Brigitte-de-Laval",
            "Sainte-Brigitte-des-Saults",
            "Sainte-Catherine",
            "Sainte-Catherine-de-Hatley",
            "Sainte-Catherine-de-la-Jacques-Cartier",
            "Sainte-Cécile-de-Lévrard",
            "Sainte-Cécile-de-Milton",
            "Sainte-Cécile-de-Whitton",
            "Sainte-Christine",
            "Sainte-Christine-d\'Auvergne",
            "Sainte-Claire",
            "Sainte-Clotilde-de-Beauce",
            "Sainte-Clotilde-de-Châteauguay",
            "Sainte-Clotilde-de-Horton",
            "Sainte-Croix",
            "Saint-Edmond-de-Grantham",
            "Saint-Edmond-les-Plaines",
            "Saint-Édouard",
            "Saint-Édouard-de-Fabre",
            "Saint-Édouard-de-Lotbinière",
            "Saint-Édouard-de-Maskinongé",
            "Sainte-Edwidge-de-Clifton",
            "Sainte-Élisabeth",
            "Sainte-Élisabeth-de-Warwick",
            "Sainte-Émélie-de-l\'Énergie",
            "Sainte-Eulalie",
            "Sainte-Euphémie-sur-Rivière-du-Sud",
            "Sainte-Famille",
            "Sainte-Félicité",
            "Sainte-Félicité",
            "Sainte-Flavie",
            "Sainte-Florence",
            "Sainte-Françoise",
            "Sainte-Françoise",
            "Sainte-Geneviève-de-Batiscan",
            "Sainte-Geneviève-de-Berthier",
            "Sainte-Germaine-Boulé",
            "Sainte-Gertrude-Manneville",
            "Sainte-Hedwidge",
            "Sainte-Hélène",
            "Sainte-Hélène-de-Bagot",
            "Sainte-Hélène-de-Mancebourg",
            "Sainte-Hénédine",
            "Sainte-Irène",
            "Sainte-Jeanne-d\'Arc",
            "Sainte-Jeanne-d\'Arc",
            "Sainte-Julie",
            "Sainte-Julienne",
            "Sainte-Justine",
            "Sainte-Justine-de-Newton",
            "Saint-Élie-de-Caxton",
            "Saint-Éloi",
            "Sainte-Louise",
            "Saint-Elphège",
            "Sainte-Luce",
            "Sainte-Lucie-de-Beauregard",
            "Sainte-Lucie-des-Laurentides",
            "Saint-Elzéar",
            "Saint-Elzéar",
            "Saint-Elzéar-de-Témiscouata",
            "Sainte-Madeleine",
            "Sainte-Madeleine-de-la-Rivière-Madeleine",
            "Sainte-Marcelline-de-Kildare",
            "Sainte-Marguerite",
            "Sainte-Marguerite",
            "Sainte-Marguerite-du-Lac-Masson",
            "Sainte-Marie",
            "Sainte-Marie-de-Blandford",
            "Sainte-Marie-Madeleine",
            "Sainte-Marie-Salomé",
            "Sainte-Marthe",
            "Sainte-Marthe-sur-le-Lac",
            "Sainte-Martine",
            "Sainte-Mélanie",
            "Saint-Émile-de-Suffolk",
            "Sainte-Monique",
            "Sainte-Monique",
            "Sainte-Paule",
            "Sainte-Perpétue",
            "Sainte-Perpétue",
            "Sainte-Pétronille",
            "Saint-Éphrem-de-Beauce",
            "Saint-Épiphane",
            "Sainte-Praxède",
            "Sainte-Rita",
            "Sainte-Rose-de-Watford",
            "Sainte-Rose-du-Nord",
            "Sainte-Sabine",
            "Sainte-Sabine",
            "Sainte-Séraphine",
            "Sainte-Sophie",
            "Sainte-Sophie-de-Lévrard",
            "Sainte-Sophie-d\'Halifax",
            "Saint-Esprit",
            "Sainte-Thècle",
            "Sainte-Thérèse",
            "Sainte-Thérèse-de-Gaspé",
            "Sainte-Thérèse-de-la-Gatineau",
            "Saint-Étienne-de-Beauharnois",
            "Saint-Étienne-de-Bolton",
            "Saint-Étienne-des-Grès",
            "Saint-Eugène",
            "Saint-Eugène-de-Guigues",
            "Saint-Eugène-de-Ladrière",
            "Saint-Eugènes",
            "Sainte-Ursule",
            "Saint-Eusèbe",
            "Saint-Eustache",
            "Saint-Évariste-de-Forsyth",
            "Sainte-Victoire-de-Sorel",
            "Saint-Fabien",
            "Saint-Fabien-de-Panet",
            "Saint-Faustin–Lac-Carré",
            "Saint-Félicien",
            "Saint-Félix-de-Dalquier",
            "Saint-Félix-de-Kingsey",
            "Saint-Félix-de-Valois",
            "Saint-Félix-d\'Otis",
            "Saint-Ferdinand",
            "Saint-Ferréol-les-Neiges",
            "Saint-Flavien",
            "Saint-Fortunat",
            "Saint-François-d\'Assise",
            "Saint-François-de-la-Rivière-du-Sud",
            "Saint-François-de-l\'Île-d\'Orléans",
            "Saint-François-de-Sales",
            "Saint-François-du-Lac",
            "Saint-François-Xavier-de-Brompton",
            "Saint-François-Xavier-de-Viger",
            "Saint-Frédéric",
            "Saint-Fulgence",
            "Saint-Gabriel",
            "Saint-Gabriel-de-Brandon",
            "Saint-Gabriel-de-Rimouski",
            "Saint-Gabriel-de-Valcartier",
            "Saint-Gabriel-Lalemant",
            "Saint-Gédéon",
            "Saint-Gédéon-de-Beauce",
            "Saint-Georges",
            "Saint-Georges-de-Clarenceville",
            "Saint-Georges-de-Windsor",
            "Saint-Gérard-Majella",
            "Saint-Germain",
            "Saint-Germain-de-Grantham",
            "Saint-Gervais",
            "Saint-Gilbert",
            "Saint-Gilles",
            "Saint-Godefroi",
            "Saint-Guillaume",
            "Saint-Guillaume-Nord",
            "Saint-Guy",
            "Saint-Henri",
            "Saint-Henri-de-Taillon",
            "Saint-Herménégilde",
            "Saint-Hilaire-de-Dorset",
            "Saint-Hilarion",
            "Saint-Hippolyte",
            "Saint-Honoré-de-Chicoutimi",
            "Saint-Honoré-de-Shenley",
            "Saint-Honoré-de-Témiscouata",
            "Saint-Hubert-de-Rivière-du-Loup",
            "Saint-Hugues",
            "Saint-Hyacinthe",
            "Saint-Ignace-de-Loyola",
            "Saint-Ignace-de-Stanbridge",
            "Saint-Irénée",
            "Saint-Isidore",
            "Saint-Isidore",
            "Saint-Isidore-de-Clifton",
            "Saint-Jacques",
            "Saint-Jacques-de-Leeds",
            "Saint-Jacques-le-Majeur-de-Wolfestown",
            "Saint-Jacques-le-Mineur",
            "Saint-Janvier-de-Joly",
            "Saint-Jean-Baptiste",
            "Saint-Jean-de-Brébeuf",
            "Saint-Jean-de-Cherbourg",
            "Saint-Jean-de-Dieu",
            "Saint-Jean-de-la-Lande",
            "Saint-Jean-de-l\'Île-d\'Orléans",
            "Saint-Jean-de-Matha",
            "Saint-Jean-Port-Joli",
            "Saint-Jean-sur-Richelieu",
            "Saint-Jérôme",
            "Saint-Joachim",
            "Saint-Joachim-de-Shefford",
            "Saint-Joseph-de-Beauce",
            "Saint-Joseph-de-Coleraine",
            "Saint-Joseph-de-Ham-Sud",
            "Saint-Joseph-de-Kamouraska",
            "Saint-Joseph-de-Lepage",
            "Saint-Joseph-des-Érables",
            "Saint-Joseph-de-Sorel",
            "Saint-Joseph-du-Lac",
            "Saint-Jude",
            "Saint-Jules",
            "Saint-Julien",
            "Saint-Just-de-Bretenières",
            "Saint-Juste-du-Lac",
            "Saint-Justin",
            "Saint-Lambert",
            "Saint-Lambert",
            "Saint-Lambert-de-Lauzon",
            "Saint-Laurent-de-l\'Île-d\'Orléans",
            "Saint-Lazare",
            "Saint-Lazare-de-Bellechasse",
            "Saint-Léandre",
            "Saint-Léonard-d\'Aston",
            "Saint-Léonard-de-Portneuf",
            "Saint-Léon-de-Standon",
            "Saint-Léon-le-Grand",
            "Saint-Léon-le-Grand",
            "Saint-Liboire",
            "Saint-Liguori",
            "Saint-Lin–Laurentides",
            "Saint-Louis",
            "Saint-Louis-de-Blandford",
            "Saint-Louis-de-Gonzague",
            "Saint-Louis-de-Gonzague",
            "Saint-Louis-de-Gonzague-du-Cap-Tourmente",
            "Saint-Louis-du-Ha! Ha!",
            "Saint-Luc-de-Bellechasse",
            "Saint-Luc-de-Vincennes",
            "Saint-Lucien",
            "Saint-Ludger",
            "Saint-Ludger-de-Milot",
            "Saint-Magloire",
            "Saint-Majorique-de-Grantham",
            "Saint-Malachie",
            "Saint-Malo",
            "Saint-Marc-de-Figuery",
            "Saint-Marc-des-Carrières",
            "Saint-Marc-du-Lac-Long",
            "Saint-Marcel",
            "Saint-Marcel-de-Richelieu",
            "Saint-Marcellin",
            "Saint-Marc-sur-Richelieu",
            "Saint-Martin",
            "Saint-Mathias-sur-Richelieu",
            "Saint-Mathieu",
            "Saint-Mathieu-de-Beloeil",
            "Saint-Mathieu-de-Rioux",
            "Saint-Mathieu-d\'Harricana",
            "Saint-Mathieu-du-Parc",
            "Saint-Maurice",
            "Saint-Maxime-du-Mont-Louis",
            "Saint-Médard",
            "Saint-Michel",
            "Saint-Michel-de-Bellechasse",
            "Saint-Michel-des-Saints",
            "Saint-Michel-du-Squatec",
            "Saint-Modeste",
            "Saint-Moïse",
            "Saint-Narcisse",
            "Saint-Narcisse-de-Beaurivage",
            "Saint-Narcisse-de-Rimouski",
            "Saint-Nazaire",
            "Saint-Nazaire-d\'Acton",
            "Saint-Nazaire-de-Dorchester",
            "Saint-Nérée",
            "Saint-Noël",
            "Saint-Norbert",
            "Saint-Norbert-d\'Arthabaska",
            "Saint-Octave-de-Métis",
            "Saint-Odilon-de-Cranbourne",
            "Saint-Omer",
            "Saint-Onésime-d\'Ixworth",
            "Saint-Ours",
            "Saint-Pacôme",
            "Saint-Pamphile",
            "Saint-Pascal",
            "Saint-Patrice-de-Beaurivage",
            "Saint-Patrice-de-Sherrington",
            "Saint-Paul",
            "Saint-Paul-d\'Abbotsford",
            "Saint-Paul-de-la-Croix",
            "Saint-Paul-de-l\'Île-aux-Noix",
            "Saint-Paul-de-Montminy",
            "Saint-Paulin",
            "Saint-Philémon",
            "Saint-Philibert",
            "Saint-Philippe",
            "Saint-Philippe-de-Néri",
            "Saint-Pie",
            "Saint-Pie-de-Guire",
            "Saint-Pierre",
            "Saint-Pierre-Baptiste",
            "Saint-Pierre-de-Broughton",
            "Saint-Pierre-de-Lamy",
            "Saint-Pierre-de-la-Rivière-du-Sud",
            "Saint-Pierre-de-l\'Île-d\'Orléans",
            "Saint-Pierre-de-Véronne-à-Pike-River",
            "Saint-Pierre-les-Becquets",
            "Saint-Placide",
            "Saint-Polycarpe",
            "Saint-Prime",
            "Saint-Prosper",
            "Saint-Prosper",
            "Saint-Raphaël",
            "Saint-Raymond",
            "Saint-Rémi",
            "Saint-Rémi-de-Tingwick",
            "Saint-René",
            "Saint-René-de-Matane",
            "Saint-Robert",
            "Saint-Robert-Bellarmin",
            "Saint-Roch-de-l\'Achigan",
            "Saint-Roch-de-Mékinac",
            "Saint-Roch-de-Richelieu",
            "Saint-Roch-des-Aulnaies",
            "Saint-Roch-Ouest",
            "Saint-Romain",
            "Saint-Romuald",
            "Saint-Rosaire",
            "Saint-Samuel",
            "Saints-Anges",
            "Saint-Sauveur",
            "Saint-Sébastien",
            "Saint-Sébastien",
            "Saint-Sévère",
            "Saint-Séverin",
            "Saint-Séverin",
            "Saint-Siméon",
            "Saint-Siméon",
            "Saint-Simon",
            "Saint-Simon",
            "Saint-Simon-les-Mines",
            "Saint-Sixte",
            "Saints-Martyrs-Canadiens",
            "Saint-Stanislas",
            "Saint-Stanislas",
            "Saint-Stanislas-de-Kostka",
            "Saint-Sulpice",
            "Saint-Sylvère",
            "Saint-Sylvestre",
            "Saint-Télesphore",
            "Saint-Tharcisius",
            "Saint-Théodore-d\'Acton",
            "Saint-Théophile",
            "Saint-Thomas",
            "Saint-Thomas Didyme",
            "Saint-Thuribe",
            "Saint-Tite",
            "Saint-Tite-des-Caps",
            "Saint-Ubalde",
            "Saint-Ulric",
            "Saint-Urbain",
            "Saint-Urbain-Premier",
            "Saint-Valentin",
            "Saint-Valère",
            "Saint-Valérien",
            "Saint-Valérien-de-Milton",
            "Saint-Vallier",
            "Saint-Venant-de-Paquette",
            "Saint-Vianney",
            "Saint-Victor",
            "Saint-Wenceslas",
            "Saint-Zacharie",
            "Saint-Zénon",
            "Saint-Zénon-du-Lac-Humqui",
            "Saint-Zéphirin-de-Courval",
            "Saint-Zotique",
            "Salaberry-de-Valleyfield",
            "Salluit",
            "Sayabec",
            "Schefferville",
            "Scotstown",
            "Scott",
            "Senneterre",
            "Senneville",
            "Sept-Iles",
            "Shannon",
            "Shawinigan",
            "Shawville",
            "Sheenboro",
            "Shefford",
            "Sherbrooke",
            "Shigawake",
            "Shipshaw",
            "Sorel-Tracy",
            "Stanbridge East",
            "Stanbridge Station",
            "Stanstead",
            "Stanstead-Est",
            "Stoke",
            "Stoneham-et-Tewkesbury",
            "Stornoway",
            "Stratford",
            "Stukely-Sud",
            "Sutton",
            "Tadoussac",
            "Taschereau",
            "Tasiujaq",
            "Témiscaming",
            "Terrasse-Vaudreuil",
            "Terrebonne",
            "Thetford Mines",
            "Thorne",
            "Thurso",
            "Timiskaming",
            "Tingwick",
            "Tourville",
            "Trécesson",
            "Très-Saint-Rédempteur",
            "Très-Saint-Sacrement",
            "Tring-Jonction",
            "Trois-Pistoles",
            "Trois-Rives",
            "Trois-Rivières",
            "Uashat",
            "Ulverton",
            "Umiujaq",
            "Upton",
            "Val-Alain",
            "Val-Brillant",
            "Valcourt",
            "Val-David",
            "Val-des-Bois",
            "Val-des-Lacs",
            "Val-des-Monts",
            "Val-d\'Or",
            "Val-Joli",
            "Vallée-Jonction",
            "Val-Morin",
            "Val-Racine",
            "Val-Saint-Gilles",
            "Varennes",
            "Vaudreuil-Dorion",
            "Vaudreuil-sur-le-Lac",
            "Venise-en-Québec",
            "Verchères",
            "Victoriaville",
            "Ville Saguenay",
            "Ville-Marie",
            "Villeroy",
            "Waltham",
            "Warden",
            "Warwick",
            "Waskaganish",
            "Waswanipi",
            "Waterloo",
            "Waterville",
            "Weedon",
            "Wemindji",
            "Wemotaci",
            "Wendake",
            "Wentworth",
            "Wentworth-Nord",
            "Westbury",
            "Westmount",
            "Whapmagoostui",
            "Wickham",
            "Windsor",
            "Wôlinak",
            "Wotton",
            "Yamachiche",
            "Yamaska",
            "",
            "Abercorn",
            "Acton Vale",
            "Adstock",
            "Aguanish",
            "Akulivik",
            "Akwesasne",
            "Albanel",
            "Albertville",
            "Alleyn-et-Cawood",
            "Alma",
            "Amherst",
            "Amos",
            "Amqui",
            "Ange-Gardien",
            "Angliers",
            "Armagh",
            "Arundel",
            "Asbestos",
            "Ascot Corner",
            "Aston-Jonction",
            "Auclair",
            "Audet",
            "Aumond",
            "Aupaluk",
            "Austin",
            "Authier",
            "Authier-Nord",
            "Ayer\'s Cliff",
            "Baie-Comeau",
            "Baie-de-la-Bouteille",
            "Baie-des-Sables",
            "Baie-du-Febvre",
            "Baie-D\'Urfé",
            "Baie-James",
            "Baie-Johan-Beetz",
            "Baie-Sainte-Catherine",
            "Baie-Saint-Paul",
            "Baie-Trinité",
            "Barkmere",
            "Barnston-Ouest",
            "Barraute",
            "Batiscan",
            "Beaconsfield",
            "Béarn",
            "Beauceville",
            "Beauharnois",
            "Beaulac-Garthby",
            "Beaumont",
            "Beaupré",
            "Bécancour",
            "Bedford",
            "Bégin",
            "Belcourt",
            "Belleterre",
            "Beloeil",
            "Berry",
            "Berthier-sur-Mer",
            "Berthierville",
            "Béthanie",
            "Betsiamites",
            "Biencourt",
            "Blainville",
            "Blanc-Sablon",
            "Blue Sea",
            "Boileau",
            "Boisbriand",
            "Boischatel",
            "Bois-des-Filion",
            "Bois-Franc",
            "Bolton-Est",
            "Bolton-Ouest",
            "Bonaventure",
            "Bonne-Espérance",
            "Bonsecours",
            "Boucherville",
            "Bouchette",
            "Bowman",
            "Brébeuf",
            "Brigham",
            "Bristol",
            "Brome",
            "Bromont",
            "Brossard",
            "Brownsburg-Chatham",
            "Bryson",
            "Bury",
            "Cabano",
            "Cacouna",
            "Calixa-Lavallée",
            "Campbell\'s Bay",
            "Candiac",
            "Cantley",
            "Canton-Tremblay",
            "Cap-Chat",
            "Caplan",
            "Cap-Saint-Ignace",
            "Cap-Santé",
            "Carignan",
            "Carleton-sur-Mer",
            "Cascapédia–Saint-Jules",
            "Causapscal",
            "Cayamant",
            "Chambly",
            "Chambord",
            "Champlain",
            "Champneuf",
            "Chandler",
            "Chapais",
            "Charlemagne",
            "Charrette",
            "Chartierville",
            "Châteauguay",
            "Château-Richer",
            "Chazel",
            "Chelsea",
            "Chénéville",
            "Chertsey",
            "Chester-Est",
            "Chesterville",
            "Chibougamau",
            "Chichester",
            "Chicoutimi",
            "Chicoutimi-Nord",
            "Chisasibi",
            "Chute-aux-Outardes",
            "Chute-Des-Passes",
            "Chute-Saint-Philippe",
            "Clarendon",
            "Clermont",
            "Clermont",
            "Clerval",
            "Cleveland",
            "Cloridorme",
            "Coaticook",
            "Colombier",
            "Compton",
            "Contrecoeur",
            "Cookshire-Eaton",
            "Coteau-du-Lac",
            "Côte-Nord-du-Golfe-du-Saint-Laurent",
            "Côte-Saint-Luc",
            "Courcelles",
            "Cowansville",
            "Crabtree",
            "Danville",
            "Daveluyville",
            "Dégelis",
            "Déléage",
            "Delson",
            "Denholm",
            "Desbiens",
            "Deschaillons-sur-Saint-Laurent",
            "Deschambault-Grondines",
            "Deux-Montagnes",
            "Disraeli",
            "Dixville",
            "Dolbeau",
            "Dollard-Des Ormeaux",
            "Doncaster",
            "Donnacona",
            "Dorval",
            "Dosquet",
            "Drummondville",
            "Dudswell",
            "Duhamel",
            "Duhamel-Ouest",
            "Dundee",
            "Dunham",
            "Duparquet",
            "Dupuy",
            "Durham-Sud",
            "East Angus",
            "East Broughton",
            "East Farnham",
            "East Hereford",
            "Eastmain",
            "Eastman",
            "Egan-Sud",
            "Elgin",
            "Entrelacs",
            "Escuminac",
            "Esprit-Saint",
            "Essipit",
            "Estérel",
            "Farnham",
            "Fassett",
            "Ferland-et-Boilleau",
            "Ferme-Neuve",
            "Fermont",
            "Forestville",
            "Fort-Coulonge",
            "Fortierville",
            "Fossambault-sur-le-Lac",
            "Frampton",
            "Franklin",
            "Franquelin",
            "Frelighsburg",
            "Frontenac",
            "Fugèreville",
            "Gallichan",
            "Gaspé",
            "Gatineau",
            "Gesgapegiag",
            "Girardville",
            "Godbout",
            "Godmanchester",
            "Gore",
            "Gracefield",
            "Granby",
            "Grand-Calumet",
            "Grande-Rivière",
            "Grandes-Piles",
            "Grande-Vallée",
            "Grand-Métis",
            "Grand-Remous",
            "Grand-Saint-Esprit",
            "Grenville",
            "Grenville-sur-la-Rouge",
            "Gros-Mécatina",
            "Grosse-Île",
            "Grosses-Roches",
            "Guérin",
            "Ham-Nord",
            "Hampden",
            "Hampstead",
            "Harrington",
            "Hatley",
            "Havelock",
            "Havre-Saint-Pierre",
            "Hébertville",
            "Hébertville-Station",
            "Hemmingford",
            "Henryville",
            "Hérouxville",
            "Hinchinbrooke",
            "Honfleur",
            "Hope",
            "Hope Town",
            "Howick",
            "Huberdeau",
            "Hudson",
            "Huntingdon",
            "Inukjuak",
            "Inverness",
            "Irlande",
            "Ivry-sur-le-Lac",
            "Ivujivik",
            "Joliette",
            "Jonquière",
            "Kahnawake",
            "Kamouraska",
            "Kangiqsualujjuaq",
            "Kangiqsujuaq",
            "Kangirsuk",
            "Kawawachikamach",
            "Kazabazua",
            "Kebaowek",
            "Kiamika",
            "Kingsbury",
            "Kingsey Falls",
            "Kinnear\'s Mills",
            "Kipawa",
            "Kirkland",
            "Kitigan Zibi",
            "Kuujjuaq",
            "Kuujjuarapik",
            "La Baie",
            "La Bostonnais",
            "La Conception",
            "La Corne",
            "La Doré",
            "La Durantaye",
            "La Guadeloupe",
            "La Macaza",
            "La Malbaie",
            "La Martre",
            "La Minerve",
            "La Morandière",
            "La Motte",
            "La Patrie",
            "La Pêche",
            "La Pocatière",
            "La Prairie",
            "La Présentation",
            "La Rédemption",
            "La Reine",
            "La Romaine",
            "La Sarre",
            "La Trinité-des-Monts",
            "La Tuque",
            "La Visitation-de-l\'Île-Dupas",
            "La Visitation-de-Yamaska",
            "Labelle",
            "Labrecque",
            "Lac-Ashuapmushuan",
            "Lac-au-Brochet",
            "Lac-au-Saumon",
            "Lac-aux-Sables",
            "Lac-Beauport",
            "Lac-Bouchette",
            "Lac-Brome",
            "Lac-Casault",
            "Lac-Chicobi",
            "Lac-Delage",
            "Lac-des-Aigles",
            "Lac-des-Écorces",
            "Lac-Despinassy",
            "Lac-des-Plages",
            "Lac-des-Seize-Îles",
            "Lac-Devenyns",
            "Lac-Drolet",
            "Lac-du-Cerf",
            "Lac-Édouard",
            "Lac-Etchemin",
            "Lac-Fouillac",
            "Lac-Frontière",
            "Lac-Granet",
            "Lachute",
            "Lac-John",
            "Lac-Masketsi",
            "Lac-Matapédia",
            "Lac-Matawin",
            "Lac-Mégantic",
            "Lac-Nilgaut",
            "Lacolle",
            "Lac-Pikauba",
            "Lac-Poulin",
            "Lac-Pythonga",
            "Lac-Rapide",
            "Lac-Saguay",
            "Lac-Sainte-Marie",
            "Lac-Saint-Joseph",
            "Lac-Saint-Paul",
            "Lac-Sergent",
            "Lac-Simon",
            "Lac-Simon",
            "Lac-Supérieur",
            "Lac-Tremblant-Nord",
            "Lac-Walker",
            "Laforce",
            "Lamarche",
            "Lambton",
            "L\'Ancienne-Lorette",
            "Landrienne",
            "L\'Ange-Gardien",
            "L\'Ange-Gardien",
            "Laniel",
            "Lanoraie",
            "L\'Anse-Saint-Jean",
            "Lantier",
            "Larouche",
            "L\'Ascension",
            "L\'Ascension-de-Notre-Seigneur",
            "L\'Ascension-de-Patapédia",
            "L\'Assomption",
            "Laterrière",
            "Latulipe-et-Gaboury",
            "Launay",
            "Laurier-Station",
            "Laurierville",
            "Laval",
            "Lavaltrie",
            "L\'Avenir",
            "Laverlochère",
            "Lawrenceville",
            "Le Bic",
            "Lebel-sur-Quévillon",
            "Leclercville",
            "Lefebvre",
            "Lejeune",
            "Lemieux",
            "L\'Épiphanie",
            "Léry",
            "Les Bergeronnes",
            "Les Cèdres",
            "Les Coteaux",
            "Les Éboulements",
            "Les Escoumins",
            "Les Hauteurs",
            "Les Îles-de-la-Madeleine",
            "Les Méchins",
            "Lévis",
            "L\'Île-Cadieux",
            "L\'Île-d\'Anticosti",
            "L\'Île-Dorval",
            "L\'Île-Perrot",
            "Lingwick",
            "Linton",
            "L\'Isle-aux-Allumettes",
            "L\'Isle-aux-Coudres",
            "L\'Islet",
            "L\'Isle-Verte",
            "Listuguj",
            "Litchfield",
            "Lochaber",
            "Lochaber-Partie-Ouest",
            "Longue-Pointe-de-Mingan",
            "Longue-Rive",
            "Longueuil",
            "Lorraine",
            "Lorrainville",
            "Lotbinière",
            "Louiseville",
            "Low",
            "Lyster",
            "Macamic",
            "Maddington",
            "Magog",
            "Malartic",
            "Maliotenam",
            "Manawan",
            "Mandeville",
            "Maniwaki",
            "Manseau",
            "Mansfield-et-Pontefract",
            "Maria",
            "Maricourt",
            "Marieville",
            "Marsoui",
            "Marston",
            "Martinville",
            "Mascouche",
            "Mashteuiatsh",
            "Maskinongé",
            "Massueville",
            "Matagami",
            "Matane",
            "Matapédia",
            "Matchi-Manitou",
            "Matimekosh",
            "Mayo",
            "McMasterville",
            "Melbourne",
            "Mercier",
            "Messines",
            "Métabetchouan–Lac-à-la-Croix",
            "Métis-sur-Mer",
            "Milan",
            "Mille-Isles",
            "Mingan",
            "Mirabel",
            "Mistissini",
            "Moffet",
            "Mont-Albert",
            "Montcalm",
            "Mont-Carmel",
            "Montcerf-Lytton",
            "Montebello",
            "Mont-Élie",
            "Mont-Joli",
            "Mont-Laurier",
            "Montmagny",
            "Montpellier",
            "Montréal",
            "Montréal-Est",
            "Montréal-Ouest",
            "Mont-Royal",
            "Mont-Saint-Grégoire",
            "Mont-Saint-Hilaire",
            "Mont-Saint-Michel",
            "Mont-Saint-Pierre",
            "Mont-Tremblant",
            "Mont-Valin",
            "Morin-Heights",
            "Mulgrave-et-Derry",
            "Murdochville",
            "Namur",
            "Nantes",
            "Napierville",
            "Natashquan",
            "Natashquan",
            "Nédélec",
            "Nemiscau",
            "Neuville",
            "New Carlisle",
            "New Richmond",
            "Newport",
            "Nicolet",
            "Nominingue",
            "Norbertville",
            "Normandin",
            "Normétal",
            "North Hatley",
            "Notre-Dame-Auxiliatrice-de-Buckland",
            "Notre-Dame-de-Bonsecours",
            "Notre-Dame-de-Ham",
            "Notre-Dame-de-la-Merci",
            "Notre-Dame-de-la-Paix",
            "Notre-Dame-de-la-Salette",
            "Notre-Dame-de-l\'Île-Perrot",
            "Notre-Dame-de-Lorette",
            "Notre-Dame-de-Lourdes",
            "Notre-Dame-de-Lourdes",
            "Notre-Dame-de-Montauban",
            "Notre-Dame-de-Pontmain",
            "Notre-Dame-des-Anges",
            "Notre-Dame-des-Bois",
            "Notre-Dame-des-Monts",
            "Notre-Dame-des-Neiges",
            "Notre-Dame-des-Pins",
            "Notre-Dame-des-Prairies",
            "Notre-Dame-des-Sept-Douleurs",
            "Notre-Dame-de-Stanbridge",
            "Notre-Dame-du-Bon-Conseil",
            "Notre-Dame-du-Lac",
            "Notre-Dame-du-Laus",
            "Notre-Dame-du-Mont-Carmel",
            "Notre-Dame-du-Nord",
            "Notre-Dame-du-Portage",
            "Notre-Dame-du-Rosaire",
            "Notre-Dame-du-Sacré-Coeur-d\'Issoudun",
            "Nouvelle",
            "Noyan",
            "Obedjiwan",
            "Odanak",
            "Ogden",
            "Oka",
            "Orford",
            "Ormstown",
            "Otter Lake",
            "Otterburn Park",
            "Packington",
            "Padoue",
            "Palmarolle",
            "Papineauville",
            "Parisville",
            "Paspébiac",
            "Percé",
            "Péribonka",
            "Petite-Rivière-Saint-François",
            "Petite-Vallée",
            "Petit-Saguenay",
            "Picard",
            "Piedmont",
            "Pierreville",
            "Pikogan",
            "Pincourt",
            "Piopolis",
            "Plaisance",
            "Plessisville",
            "Pohénégamook",
            "Pointe-à-la-Croix",
            "Pointe-aux-Outardes",
            "Pointe-Calumet",
            "Pointe-Claire",
            "Pointe-des-Cascades",
            "Pointe-Fortune",
            "Pointe-Lebel",
            "Pontiac",
            "Pont-Rouge",
            "Portage-du-Fort",
            "Port-Cartier",
            "Port-Daniel–Gascons",
            "Portneuf",
            "Portneuf-sur-Mer",
            "Potton",
            "Poularies",
            "Preissac",
            "Prévost",
            "Price",
            "Princeville",
            "Puvirnituq",
            "Quaqtaq",
            "Québec",
            "Racine",
            "Ragueneau",
            "Rapide-Danseur",
            "Rapides-des-Joachims",
            "Rawdon",
            "Rémigny",
            "Repentigny",
            "Réservoir-Dozois",
            "Richelieu",
            "Richmond",
            "Rigaud",
            "Rimouski",
            "Ripon",
            "Ristigouche-Partie-Sud-Est",
            "Rivière-à-Claude",
            "Rivière-à-Pierre",
            "Rivière-au-Tonnerre",
            "Rivière-aux-Outardes",
            "Rivière-Beaudette",
            "Rivière-Bleue",
            "Rivière-du-Loup",
            "Rivière-Éternité",
            "Rivière-Héva",
            "Rivière-Mistassini",
            "Rivière-Ojima",
            "Rivière-Ouelle",
            "Rivière-Rouge",
            "Rivière-Saint-Jean",
            "Roberval",
            "Rochebaucourt",
            "Roquemaure",
            "Rosemère",
            "Rougemont",
            "Routhierville",
            "Rouyn-Noranda",
            "Roxton",
            "Roxton Falls",
            "Roxton Pond",
            "Sacré-Cœur",
            "Sacré-Coeur-de-Jésus",
            "Sagard",
            "Saint-Adalbert",
            "Saint-Adelme",
            "Saint-Adelphe",
            "Saint-Adolphe-d\'Howard",
            "Saint-Adrien",
            "Saint-Adrien-d\'Irlande",
            "Saint-Agapit",
            "Saint-Aimé",
            "Saint-Aimé-des-Lacs",
            "Saint-Aimé-du-Lac-des-Îles",
            "Saint-Alban",
            "Saint-Albert",
            "Saint-Alexandre",
            "Saint-Alexandre-de-Kamouraska",
            "Saint-Alexandre-des-Lacs",
            "Saint-Alexis",
            "Saint-Alexis-de-Matapédia",
            "Saint-Alexis-des-Monts",
            "Saint-Alfred",
            "Saint-Alphonse",
            "Saint-Alphonse",
            "Saint-Alphonse-Rodrigue",
            "Saint-Amable",
            "Saint-Ambroise",
            "Saint-Ambroise-de-Kildare",
            "Saint-Anaclet-de-Lessard",
            "Saint-André",
            "Saint-André-Avellin",
            "Saint-André-d\'Argenteuil",
            "Saint-André-de-Restigouche",
            "Saint-André-du-Lac-Saint-Jean",
            "Saint-Anicet",
            "Saint-Anselme",
            "Saint-Antoine-de-l\'Isle-aux-Grues",
            "Saint-Antoine-de-Tilly",
            "Saint-Antoine-sur-Richelieu",
            "Saint-Antonin",
            "Saint-Apollinaire",
            "Saint-Armand",
            "Saint-Arsène",
            "Saint-Athanase",
            "Saint-Aubert",
            "Saint-Augustin",
            "Saint-Augustin",
            "Saint-Augustin-de-Desmaures",
            "Saint-Augustin-de-Woburn",
            "Saint-Barnabé",
            "Saint-Barnabé-Sud",
            "Saint-Barthélemy",
            "Saint-Basile",
            "Saint-Basile-le-Grand",
            "Saint-Benjamin",
            "Saint-Benoît-du-Lac",
            "Saint-Benoît-Labre",
            "Saint-Bernard",
            "Saint-Bernard-de-Lacolle",
            "Saint-Bernard-de-Michaudville",
            "Saint-Blaise-sur-Richelieu",
            "Saint-Bonaventure",
            "Saint-Boniface",
            "Saint-Bruno",
            "Saint-Bruno-de-Guigues",
            "Saint-Bruno-de-Kamouraska",
            "Saint-Bruno-de-Montarville",
            "Saint-Calixte",
            "Saint-Camille",
            "Saint-Camille-de-Lellis",
            "Saint-Casimir",
            "Saint-Célestin",
            "Saint-Césaire",
            "Saint-Charles-Borromée",
            "Saint-Charles-de-Bellechasse",
            "Saint-Charles-de-Bourget",
            "Saint-Charles-Garnier",
            "Saint-Charles-sur-Richelieu",
            "Saint-Christophe-d\'Arthabaska",
            "Saint-Chrysostome",
            "Saint-Claude",
            "Saint-Clément",
            "Saint-Cléophas",
            "Saint-Cléophas-de-Brandon",
            "Saint-Clet",
            "Saint-Colomban",
            "Saint-Côme",
            "Saint-Côme–Linière",
            "Saint-Constant",
            "Saint-Cuthbert",
            "Saint-Cyprien",
            "Saint-Cyprien",
            "Saint-Cyprien-de-Napierville",
            "Saint-Cyrille-de-Lessard",
            "Saint-Cyrille-de-Wendover",
            "Saint-Damase",
            "Saint-Damase",
            "Saint-Damase-de-L\'Islet",
            "Saint-Damien",
            "Saint-Damien-de-Buckland",
            "Saint-David",
            "Saint-David-de-Falardeau",
            "Saint-Denis",
            "Saint-Denis-de-Brompton",
            "Saint-Denis-sur-Richelieu",
            "Saint-Didace",
            "Saint-Dominique",
            "Saint-Dominique-du-Rosaire",
            "Saint-Donat",
            "Saint-Donat",
            "Sainte-Adèle",
            "Sainte-Agathe-de-Lotbinière",
            "Sainte-Agathe-des-Monts",
            "Sainte-Angèle-de-Mérici",
            "Sainte-Angèle-de-Monnoir",
            "Sainte-Angèle-de-Prémont",
            "Sainte-Anne-de-Beaupré",
            "Sainte-Anne-de-Bellevue",
            "Sainte-Anne-de-la-Pérade",
            "Sainte-Anne-de-la-Pocatière",
            "Sainte-Anne-de-la-Rochelle",
            "Sainte-Anne-de-Sabrevois",
            "Sainte-Anne-des-Lacs",
            "Sainte-Anne-des-Monts",
            "Sainte-Anne-de-Sorel",
            "Sainte-Anne-des-Plaines",
            "Sainte-Anne-du-Lac",
            "Sainte-Anne-du-Sault",
            "Sainte-Apolline-de-Patton",
            "Sainte-Aurélie",
            "Sainte-Barbe",
            "Sainte-Béatrix",
            "Sainte-Brigide-d\'Iberville",
            "Sainte-Brigitte-de-Laval",
            "Sainte-Brigitte-des-Saults",
            "Sainte-Catherine",
            "Sainte-Catherine-de-Hatley",
            "Sainte-Catherine-de-la-Jacques-Cartier",
            "Sainte-Cécile-de-Lévrard",
            "Sainte-Cécile-de-Milton",
            "Sainte-Cécile-de-Whitton",
            "Sainte-Christine",
            "Sainte-Christine-d\'Auvergne",
            "Sainte-Claire",
            "Sainte-Clotilde-de-Beauce",
            "Sainte-Clotilde-de-Châteauguay",
            "Sainte-Clotilde-de-Horton",
            "Sainte-Croix",
            "Saint-Edmond-de-Grantham",
            "Saint-Edmond-les-Plaines",
            "Saint-Édouard",
            "Saint-Édouard-de-Fabre",
            "Saint-Édouard-de-Lotbinière",
            "Saint-Édouard-de-Maskinongé",
            "Sainte-Edwidge-de-Clifton",
            "Sainte-Élisabeth",
            "Sainte-Élisabeth-de-Warwick",
            "Sainte-Émélie-de-l\'Énergie",
            "Sainte-Eulalie",
            "Sainte-Euphémie-sur-Rivière-du-Sud",
            "Sainte-Famille",
            "Sainte-Félicité",
            "Sainte-Félicité",
            "Sainte-Flavie",
            "Sainte-Florence",
            "Sainte-Françoise",
            "Sainte-Françoise",
            "Sainte-Geneviève-de-Batiscan",
            "Sainte-Geneviève-de-Berthier",
            "Sainte-Germaine-Boulé",
            "Sainte-Gertrude-Manneville",
            "Sainte-Hedwidge",
            "Sainte-Hélène",
            "Sainte-Hélène-de-Bagot",
            "Sainte-Hélène-de-Mancebourg",
            "Sainte-Hénédine",
            "Sainte-Irène",
            "Sainte-Jeanne-d\'Arc",
            "Sainte-Jeanne-d\'Arc",
            "Sainte-Julie",
            "Sainte-Julienne",
            "Sainte-Justine",
            "Sainte-Justine-de-Newton",
            "Saint-Élie-de-Caxton",
            "Saint-Éloi",
            "Sainte-Louise",
            "Saint-Elphège",
            "Sainte-Luce",
            "Sainte-Lucie-de-Beauregard",
            "Sainte-Lucie-des-Laurentides",
            "Saint-Elzéar",
            "Saint-Elzéar",
            "Saint-Elzéar-de-Témiscouata",
            "Sainte-Madeleine",
            "Sainte-Madeleine-de-la-Rivière-Madeleine",
            "Sainte-Marcelline-de-Kildare",
            "Sainte-Marguerite",
            "Sainte-Marguerite",
            "Sainte-Marguerite-du-Lac-Masson",
            "Sainte-Marie",
            "Sainte-Marie-de-Blandford",
            "Sainte-Marie-Madeleine",
            "Sainte-Marie-Salomé",
            "Sainte-Marthe",
            "Sainte-Marthe-sur-le-Lac",
            "Sainte-Martine",
            "Sainte-Mélanie",
            "Saint-Émile-de-Suffolk",
            "Sainte-Monique",
            "Sainte-Monique",
            "Sainte-Paule",
            "Sainte-Perpétue",
            "Sainte-Perpétue",
            "Sainte-Pétronille",
            "Saint-Éphrem-de-Beauce",
            "Saint-Épiphane",
            "Sainte-Praxède",
            "Sainte-Rita",
            "Sainte-Rose-de-Watford",
            "Sainte-Rose-du-Nord",
            "Sainte-Sabine",
            "Sainte-Sabine",
            "Sainte-Séraphine",
            "Sainte-Sophie",
            "Sainte-Sophie-de-Lévrard",
            "Sainte-Sophie-d\'Halifax",
            "Saint-Esprit",
            "Sainte-Thècle",
            "Sainte-Thérèse",
            "Sainte-Thérèse-de-Gaspé",
            "Sainte-Thérèse-de-la-Gatineau",
            "Saint-Étienne-de-Beauharnois",
            "Saint-Étienne-de-Bolton",
            "Saint-Étienne-des-Grès",
            "Saint-Eugène",
            "Saint-Eugène-de-Guigues",
            "Saint-Eugène-de-Ladrière",
            "Saint-Eugènes",
            "Sainte-Ursule",
            "Saint-Eusèbe",
            "Saint-Eustache",
            "Saint-Évariste-de-Forsyth",
            "Sainte-Victoire-de-Sorel",
            "Saint-Fabien",
            "Saint-Fabien-de-Panet",
            "Saint-Faustin–Lac-Carré",
            "Saint-Félicien",
            "Saint-Félix-de-Dalquier",
            "Saint-Félix-de-Kingsey",
            "Saint-Félix-de-Valois",
            "Saint-Félix-d\'Otis",
            "Saint-Ferdinand",
            "Saint-Ferréol-les-Neiges",
            "Saint-Flavien",
            "Saint-Fortunat",
            "Saint-François-d\'Assise",
            "Saint-François-de-la-Rivière-du-Sud",
            "Saint-François-de-l\'Île-d\'Orléans",
            "Saint-François-de-Sales",
            "Saint-François-du-Lac",
            "Saint-François-Xavier-de-Brompton",
            "Saint-François-Xavier-de-Viger",
            "Saint-Frédéric",
            "Saint-Fulgence",
            "Saint-Gabriel",
            "Saint-Gabriel-de-Brandon",
            "Saint-Gabriel-de-Rimouski",
            "Saint-Gabriel-de-Valcartier",
            "Saint-Gabriel-Lalemant",
            "Saint-Gédéon",
            "Saint-Gédéon-de-Beauce",
            "Saint-Georges",
            "Saint-Georges-de-Clarenceville",
            "Saint-Georges-de-Windsor",
            "Saint-Gérard-Majella",
            "Saint-Germain",
            "Saint-Germain-de-Grantham",
            "Saint-Gervais",
            "Saint-Gilbert",
            "Saint-Gilles",
            "Saint-Godefroi",
            "Saint-Guillaume",
            "Saint-Guillaume-Nord",
            "Saint-Guy",
            "Saint-Henri",
            "Saint-Henri-de-Taillon",
            "Saint-Herménégilde",
            "Saint-Hilaire-de-Dorset",
            "Saint-Hilarion",
            "Saint-Hippolyte",
            "Saint-Honoré-de-Chicoutimi",
            "Saint-Honoré-de-Shenley",
            "Saint-Honoré-de-Témiscouata",
            "Saint-Hubert-de-Rivière-du-Loup",
            "Saint-Hugues",
            "Saint-Hyacinthe",
            "Saint-Ignace-de-Loyola",
            "Saint-Ignace-de-Stanbridge",
            "Saint-Irénée",
            "Saint-Isidore",
            "Saint-Isidore",
            "Saint-Isidore-de-Clifton",
            "Saint-Jacques",
            "Saint-Jacques-de-Leeds",
            "Saint-Jacques-le-Majeur-de-Wolfestown",
            "Saint-Jacques-le-Mineur",
            "Saint-Janvier-de-Joly",
            "Saint-Jean-Baptiste",
            "Saint-Jean-de-Brébeuf",
            "Saint-Jean-de-Cherbourg",
            "Saint-Jean-de-Dieu",
            "Saint-Jean-de-la-Lande",
            "Saint-Jean-de-l\'Île-d\'Orléans",
            "Saint-Jean-de-Matha",
            "Saint-Jean-Port-Joli",
            "Saint-Jean-sur-Richelieu",
            "Saint-Jérôme",
            "Saint-Joachim",
            "Saint-Joachim-de-Shefford",
            "Saint-Joseph-de-Beauce",
            "Saint-Joseph-de-Coleraine",
            "Saint-Joseph-de-Ham-Sud",
            "Saint-Joseph-de-Kamouraska",
            "Saint-Joseph-de-Lepage",
            "Saint-Joseph-des-Érables",
            "Saint-Joseph-de-Sorel",
            "Saint-Joseph-du-Lac",
            "Saint-Jude",
            "Saint-Jules",
            "Saint-Julien",
            "Saint-Just-de-Bretenières",
            "Saint-Juste-du-Lac",
            "Saint-Justin",
            "Saint-Lambert",
            "Saint-Lambert",
            "Saint-Lambert-de-Lauzon",
            "Saint-Laurent-de-l\'Île-d\'Orléans",
            "Saint-Lazare",
            "Saint-Lazare-de-Bellechasse",
            "Saint-Léandre",
            "Saint-Léonard-d\'Aston",
            "Saint-Léonard-de-Portneuf",
            "Saint-Léon-de-Standon",
            "Saint-Léon-le-Grand",
            "Saint-Léon-le-Grand",
            "Saint-Liboire",
            "Saint-Liguori",
            "Saint-Lin–Laurentides",
            "Saint-Louis",
            "Saint-Louis-de-Blandford",
            "Saint-Louis-de-Gonzague",
            "Saint-Louis-de-Gonzague",
            "Saint-Louis-de-Gonzague-du-Cap-Tourmente",
            "Saint-Louis-du-Ha! Ha!",
            "Saint-Luc-de-Bellechasse",
            "Saint-Luc-de-Vincennes",
            "Saint-Lucien",
            "Saint-Ludger",
            "Saint-Ludger-de-Milot",
            "Saint-Magloire",
            "Saint-Majorique-de-Grantham",
            "Saint-Malachie",
            "Saint-Malo",
            "Saint-Marc-de-Figuery",
            "Saint-Marc-des-Carrières",
            "Saint-Marc-du-Lac-Long",
            "Saint-Marcel",
            "Saint-Marcel-de-Richelieu",
            "Saint-Marcellin",
            "Saint-Marc-sur-Richelieu",
            "Saint-Martin",
            "Saint-Mathias-sur-Richelieu",
            "Saint-Mathieu",
            "Saint-Mathieu-de-Beloeil",
            "Saint-Mathieu-de-Rioux",
            "Saint-Mathieu-d\'Harricana",
            "Saint-Mathieu-du-Parc",
            "Saint-Maurice",
            "Saint-Maxime-du-Mont-Louis",
            "Saint-Médard",
            "Saint-Michel",
            "Saint-Michel-de-Bellechasse",
            "Saint-Michel-des-Saints",
            "Saint-Michel-du-Squatec",
            "Saint-Modeste",
            "Saint-Moïse",
            "Saint-Narcisse",
            "Saint-Narcisse-de-Beaurivage",
            "Saint-Narcisse-de-Rimouski",
            "Saint-Nazaire",
            "Saint-Nazaire-d\'Acton",
            "Saint-Nazaire-de-Dorchester",
            "Saint-Nérée",
            "Saint-Noël",
            "Saint-Norbert",
            "Saint-Norbert-d\'Arthabaska",
            "Saint-Octave-de-Métis",
            "Saint-Odilon-de-Cranbourne",
            "Saint-Omer",
            "Saint-Onésime-d\'Ixworth",
            "Saint-Ours",
            "Saint-Pacôme",
            "Saint-Pamphile",
            "Saint-Pascal",
            "Saint-Patrice-de-Beaurivage",
            "Saint-Patrice-de-Sherrington",
            "Saint-Paul",
            "Saint-Paul-d\'Abbotsford",
            "Saint-Paul-de-la-Croix",
            "Saint-Paul-de-l\'Île-aux-Noix",
            "Saint-Paul-de-Montminy",
            "Saint-Paulin",
            "Saint-Philémon",
            "Saint-Philibert",
            "Saint-Philippe",
            "Saint-Philippe-de-Néri",
            "Saint-Pie",
            "Saint-Pie-de-Guire",
            "Saint-Pierre",
            "Saint-Pierre-Baptiste",
            "Saint-Pierre-de-Broughton",
            "Saint-Pierre-de-Lamy",
            "Saint-Pierre-de-la-Rivière-du-Sud",
            "Saint-Pierre-de-l\'Île-d\'Orléans",
            "Saint-Pierre-de-Véronne-à-Pike-River",
            "Saint-Pierre-les-Becquets",
            "Saint-Placide",
            "Saint-Polycarpe",
            "Saint-Prime",
            "Saint-Prosper",
            "Saint-Prosper",
            "Saint-Raphaël",
            "Saint-Raymond",
            "Saint-Rémi",
            "Saint-Rémi-de-Tingwick",
            "Saint-René",
            "Saint-René-de-Matane",
            "Saint-Robert",
            "Saint-Robert-Bellarmin",
            "Saint-Roch-de-l\'Achigan",
            "Saint-Roch-de-Mékinac",
            "Saint-Roch-de-Richelieu",
            "Saint-Roch-des-Aulnaies",
            "Saint-Roch-Ouest",
            "Saint-Romain",
            "Saint-Romuald",
            "Saint-Rosaire",
            "Saint-Samuel",
            "Saints-Anges",
            "Saint-Sauveur",
            "Saint-Sébastien",
            "Saint-Sébastien",
            "Saint-Sévère",
            "Saint-Séverin",
            "Saint-Séverin",
            "Saint-Siméon",
            "Saint-Siméon",
            "Saint-Simon",
            "Saint-Simon",
            "Saint-Simon-les-Mines",
            "Saint-Sixte",
            "Saints-Martyrs-Canadiens",
            "Saint-Stanislas",
            "Saint-Stanislas",
            "Saint-Stanislas-de-Kostka",
            "Saint-Sulpice",
            "Saint-Sylvère",
            "Saint-Sylvestre",
            "Saint-Télesphore",
            "Saint-Tharcisius",
            "Saint-Théodore-d\'Acton",
            "Saint-Théophile",
            "Saint-Thomas",
            "Saint-Thomas Didyme",
            "Saint-Thuribe",
            "Saint-Tite",
            "Saint-Tite-des-Caps",
            "Saint-Ubalde",
            "Saint-Ulric",
            "Saint-Urbain",
            "Saint-Urbain-Premier",
            "Saint-Valentin",
            "Saint-Valère",
            "Saint-Valérien",
            "Saint-Valérien-de-Milton",
            "Saint-Vallier",
            "Saint-Venant-de-Paquette",
            "Saint-Vianney",
            "Saint-Victor",
            "Saint-Wenceslas",
            "Saint-Zacharie",
            "Saint-Zénon",
            "Saint-Zénon-du-Lac-Humqui",
            "Saint-Zéphirin-de-Courval",
            "Saint-Zotique",
            "Salaberry-de-Valleyfield",
            "Salluit",
            "Sayabec",
            "Schefferville",
            "Scotstown",
            "Scott",
            "Senneterre",
            "Senneville",
            "Sept-Iles",
            "Shannon",
            "Shawinigan",
            "Shawville",
            "Sheenboro",
            "Shefford",
            "Sherbrooke",
            "Shigawake",
            "Shipshaw",
            "Sorel-Tracy",
            "Stanbridge East",
            "Stanbridge Station",
            "Stanstead",
            "Stanstead-Est",
            "Stoke",
            "Stoneham-et-Tewkesbury",
            "Stornoway",
            "Stratford",
            "Stukely-Sud",
            "Sutton",
            "Tadoussac",
            "Taschereau",
            "Tasiujaq",
            "Témiscaming",
            "Terrasse-Vaudreuil",
            "Terrebonne",
            "Thetford Mines",
            "Thorne",
            "Thurso",
            "Timiskaming",
            "Tingwick",
            "Tourville",
            "Trécesson",
            "Très-Saint-Rédempteur",
            "Très-Saint-Sacrement",
            "Tring-Jonction",
            "Trois-Pistoles",
            "Trois-Rives",
            "Trois-Rivières",
            "Uashat",
            "Ulverton",
            "Umiujaq",
            "Upton",
            "Val-Alain",
            "Val-Brillant",
            "Valcourt",
            "Val-David",
            "Val-des-Bois",
            "Val-des-Lacs",
            "Val-des-Monts",
            "Val-d\'Or",
            "Val-Joli",
            "Vallée-Jonction",
            "Val-Morin",
            "Val-Racine",
            "Val-Saint-Gilles",
            "Varennes",
            "Vaudreuil-Dorion",
            "Vaudreuil-sur-le-Lac",
            "Venise-en-Québec",
            "Verchères",
            "Victoriaville",
            "Ville Saguenay",
            "Ville-Marie",
            "Villeroy",
            "Waltham",
            "Warden",
            "Warwick",
            "Waskaganish",
            "Waswanipi",
            "Waterloo",
            "Waterville",
            "Weedon",
            "Wemindji",
            "Wemotaci",
            "Wendake",
            "Wentworth",
            "Wentworth-Nord",
            "Westbury",
            "Westmount",
            "Whapmagoostui",
            "Wickham",
            "Windsor",
            "Wôlinak",
            "Wotton",
            "Yamachiche",
            "Yamaska",
            "",
            "Albanel",
            "Alma",
            "Baie-Comeau",
            "Baie-Johan-Beetz",
            "Baie-Trinité",
            "Bégin",
            "Betsiamites",
            "Blanc-Sablon",
            "Bonne-Espérance",
            "Chambord",
            "Chute-aux-Outardes",
            "Chute-Des-Passes",
            "Colombier",
            "Canton-Tremblay",
            "Chicoutimi",
            "Chicoutimi-Nord",
            "Côte-Nord-du-Golfe-du-Saint-Laurent",
            "Desbiens",
            "Dolbeau",
            "Essipit",
            "Ferland-et-Boilleau",
            "Fermont",
            "Forestville",
            "Franquelin",
            "Girardville",
            "Godbout",
            "Gros-Mécatina",
            "Havre-Saint-Pierre",
            "Hébertville",
            "Hébertville-Station",
            "Jonquière",
            "La Baie",
            "La Doré",
            "La Romaine",
            "Labrecque",
            "Laterrière",
            "Lac-Ashuapmushuan",
            "Lac-au-Brochet",
            "Lac-Bouchette",
            "Lac-John",
            "Lac-Walker",
            "Lamarche",
            "L\'Anse-Saint-Jean",
            "Larouche",
            "L\'Ascension-de-Notre-Seigneur",
            "Les Bergeronnes",
            "Les Escoumins",
            "L\'Île-d\'Anticosti",
            "Longue-Pointe-de-Mingan",
            "Longue-Rive",
            "Maliotenam",
            "Mashteuiatsh",
            "Matimekosh",
            "Métabetchouan–Lac-à-la-Croix",
            "Mingan",
            "Mont-Valin",
            "Natashquan",
            "Natashquan",
            "Normandin",
            "Notre-Dame-de-Lorette",
            "Péribonka",
            "Petit-Saguenay",
            "Pointe-aux-Outardes",
            "Pointe-Lebel",
            "Port-Cartier",
            "Portneuf-sur-Mer",
            "Ragueneau",
            "Rivière-au-Tonnerre",
            "Rivière-aux-Outardes",
            "Rivière-Éternité",
            "Rivière-Mistassini",
            "Rivière-Saint-Jean",
            "Roberval",
            "Sacré-Cœur",
            "Saint-Ambroise",
            "Saint-André-du-Lac-Saint-Jean",
            "Saint-Augustin",
            "Saint-Augustin",
            "Saint-Bruno",
            "Saint-Charles-de-Bourget",
            "Saint-David-de-Falardeau",
            "Saint-Edmond-les-Plaines",
            "Sainte-Hedwidge",
            "Sainte-Jeanne-d\'Arc",
            "Sainte-Monique",
            "Sainte-Rose-du-Nord",
            "Saint-Eugènes",
            "Saint-Félicien",
            "Saint-Félix-d\'Otis",
            "Saint-François-de-Sales",
            "Saint-Fulgence",
            "Saint-Gédéon",
            "Saint-Henri-de-Taillon",
            "Saint-Honoré-de-Chicoutimi",
            "Saint-Ludger-de-Milot",
            "Saint-Nazaire",
            "Saint-Prime",
            "Saint-Stanislas",
            "Saint-Thomas Didyme",
            "Shipshaw",
            "Schefferville",
            "Sept-Iles",
            "Tadoussac",
            "Ville Saguenay",
            "",
            "Albanel",
            "Alma",
            "Baie-Comeau",
            "Baie-Johan-Beetz",
            "Baie-Trinité",
            "Bégin",
            "Betsiamites",
            "Blanc-Sablon",
            "Bonne-Espérance",
            "Chambord",
            "Chute-aux-Outardes",
            "Chute-Des-Passes",
            "Colombier",
            "Chicoutimi",
            "Chicoutimi-Nord",
            "Côte-Nord-du-Golfe-du-Saint-Laurent",
            "Desbiens",
            "Dolbeau",
            "Essipit",
            "Ferland-et-Boilleau",
            "Fermont",
            "Forestville",
            "Franquelin",
            "Girardville",
            "Godbout",
            "Gros-Mécatina",
            "Havre-Saint-Pierre",
            "Hébertville",
            "Hébertville-Station",
            "Jonquière",
            "La Baie",
            "La Doré",
            "La Romaine",
            "Labrecque",
            "Laterrière",
            "Lac-Ashuapmushuan",
            "Lac-au-Brochet",
            "Lac-Bouchette",
            "Lac-John",
            "Lac-Walker",
            "Lamarche",
            "L\'Anse-Saint-Jean",
            "Larouche",
            "L\'Ascension-de-Notre-Seigneur",
            "Les Bergeronnes",
            "Les Escoumins",
            "L\'Île-d\'Anticosti",
            "Longue-Pointe-de-Mingan",
            "Longue-Rive",
            "Maliotenam",
            "Mashteuiatsh",
            "Matimekosh",
            "Métabetchouan–Lac-à-la-Croix",
            "Mingan",
            "Mont-Valin",
            "Natashquan",
            "Natashquan",
            "Normandin",
            "Notre-Dame-de-Lorette",
            "Péribonka",
            "Petit-Saguenay",
            "Pointe-aux-Outardes",
            "Pointe-Lebel",
            "Port-Cartier",
            "Portneuf-sur-Mer",
            "Ragueneau",
            "Rivière-au-Tonnerre",
            "Rivière-aux-Outardes",
            "Rivière-Éternité",
            "Rivière-Mistassini",
            "Rivière-Saint-Jean",
            "Roberval",
            "Sacré-Cœur",
            "Saint-Ambroise",
            "Saint-André-du-Lac-Saint-Jean",
            "Saint-Augustin",
            "Saint-Augustin",
            "Saint-Bruno",
            "Saint-Charles-de-Bourget",
            "Saint-David-de-Falardeau",
            "Saint-Edmond-les-Plaines",
            "Sainte-Hedwidge",
            "Sainte-Jeanne-d\'Arc",
            "Sainte-Monique",
            "Sainte-Rose-du-Nord",
            "Saint-Eugènes",
            "Saint-Félicien",
            "Saint-Félix-d\'Otis",
            "Saint-François-de-Sales",
            "Saint-Fulgence",
            "Saint-Gédéon",
            "Saint-Henri-de-Taillon",
            "Saint-Honoré-de-Chicoutimi",
            "Saint-Ludger-de-Milot",
            "Saint-Nazaire",
            "Saint-Prime",
            "Saint-Stanislas",
            "Saint-Thomas Didyme",
            "Shipshaw",
            "Schefferville",
            "Sept-Iles",
            "Tadoussac",
            "Ville Saguenay"});
            this.cbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbCity.Location = new System.Drawing.Point(120, 78);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(213, 20);
            this.cbCity.TabIndex = 29;
            // 
            // printDocMoto2015
            // 
            this.printDocMoto2015.DocumentName = "Fichier du client";
            this.printDocMoto2015.OriginAtMargins = true;
            this.printDocMoto2015.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocMoto2015_PrintPage);
            // 
            // ClientControl
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ctbTauxHorairePratique);
            this.Controls.Add(this.ctbTauxHoraireTheorique);
            this.Controls.Add(this.cmdShowSeancesMoto2015);
            this.Controls.Add(this.cmdClearbox);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtNumeroGroupe);
            this.Controls.Add(this.dtpAttestation1);
            this.Controls.Add(this.dtpAttestation2);
            this.Controls.Add(this.txtNumeroAttestation2);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtNumeroContrat);
            this.Controls.Add(this.cmdAutoDateExpiration);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.DateDebutCours);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.DateExpiration);
            this.Controls.Add(this.cbNullContrat);
            this.Controls.Add(this.txtNumeroAttestation);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DateInscription);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbCoursType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmdShowSeanceT);
            this.Controls.Add(this.cmdShowSeanceTheorique);
            this.DoubleBuffered = true;
            this.Name = "ClientControl";
            this.Size = new System.Drawing.Size(640, 718);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.gbCoursType.ResumeLayout(false);
            this.gbCoursType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void cmdShowSeance_Click(object sender, System.EventArgs e) {
            ShowCours();
        }

        #region Type de Seance
        private void rbManuel_CheckedChanged(object sender, System.EventArgs e) {
            this._SceanceType = SeanceType.Automobile;
        }

        private void rbCamion_CheckedChanged(object sender, System.EventArgs e) {
            this._SceanceType = SeanceType.Cyclomoteur;
        }

        private void rbAutomatique_CheckedChanged(object sender, System.EventArgs e) {
            this._SceanceType = SeanceType.Automobile;
        }

        private void rbMoto_CheckedChanged(object sender, System.EventArgs e) {
            this._SceanceType = SeanceType.Moto;
            txtN6R.Enabled = rbVehiculMoto.Checked;
        }
        #endregion

        #region Property
        public Customer Client {
            get {
                MakeClient();
                return this._Client;
            }
            set {
                MakeControl(value);
                this._Client = value;
            }
        }

        /// <summary>
        /// Liste d'employe du logiciel
        /// </summary>
        public EmployeCollection ListeEmploye {
            get {
                return this._EmployeList;
            }
            set {
                this._EmployeList = value;
            }
        }

        /// <summary>
        /// Information de l'ecole de conduite
        /// </summary>
        public SchoolInfo School {
            get {
                return this._infoSchool;
            }
            set {
                this._infoSchool = value;
            }
        }

        /// <summary>
        /// Si true, Mise a jour Automatiquement
        /// </summary>
        public bool AutoUpdate {
            get {
                return this._AutoUpdate;
            }
            set {
                this._AutoUpdate = value;
            }
        }

        /// <summary>
        /// Retourne le nom du client (Prenom + Nom)
        /// </summary>
        public string NomComplet {
            get {
                return this.txtFirstName.Text + " " + this.txtName.Text;
            }
        }

        /// <summary>
        /// Retourne le nom du client (Prenom + Nom)
        /// </summary>
        public string NomCompletReverse {
            get {
                return this.txtName.Text + " " + this.txtFirstName.Text;
            }
        }


        /// <summary>
        /// Retourne le nom du client (Nom + Prenom)
        /// </summary>
        public string NomPrenom {
            get {
                return this.txtName.Text + " " + this.txtFirstName.Text;
            }
        }

        /// <summary>
        /// Retourne le numéro de contrat
        /// </summary>
        public string ContratNumber {
            get {
                return this.txtNumeroContrat.Text;
            }
        }
        #endregion

        #region Methode
        /// <summary>
        /// Mettre la date d'inscription sur La date du jour
        /// </summary>
        public void Now() {
            DateInscription.Value = DateTime.Now;
        }

        /// <summary>
        /// Affiche la liste de cours.
        /// </summary>
        public DialogResult ShowCours() {
            MakeClient();

            switch (this._SceanceType) {
                case SeanceType.Automobile:
                    return new FormSeanceGeneral(this._Client, this, this._EmployeList).ShowDialog();
                case SeanceType.Moto:
                    return new FormSeanceMoto(this._Client, this, this._EmployeList).ShowDialog();
                case SeanceType.Cyclomoteur:
                    return new FormSeanceMotocyclette(this._Client, this, this._EmployeList).ShowDialog();
            }

            return DialogResult.None;
        }

        /// <summary>
        /// Affiche la liste de cours.
        /// </summary>
        public DialogResult ShowCoursTheorique() {
            MakeClient();

            switch (this._SceanceType) {
                case SeanceType.Automobile:
                    return new FormSeanceTheorique(this._Client, this, this._EmployeList).ShowDialog();
                case SeanceType.Moto:
                    return new FormSeanceTheoriqueMoto(this._Client, this, this._EmployeList).ShowDialog();
                case SeanceType.Cyclomoteur:
                    return new FormSeanceTheoriqueMotocyclette(this._Client, this, this._EmployeList).ShowDialog();
            }

            return DialogResult.None;
        }


        public DialogResult ShowCours2015()
        {
            MakeClient();

            return new FormSeanceMoto2015(this._Client, this, this._EmployeList).ShowDialog();

            //return DialogResult.None;
        }

        /// <summary>
        /// Fabrique un client a partir du control
        /// </summary>
        private void MakeClient() {
            //Backup seance list
            SeanceCollection seances = new SeanceCollection();
            SeanceCollection seancesTheorique = new SeanceCollection();
            PaimentCollection paiment = new PaimentCollection();

            if (this._Client != null) {
                seances = this._Client.Seances;
                seancesTheorique = this._Client.SeancesTheorique;
                paiment = this._Client.Paiment;
            }

            //Creation d'un nouveau client
            this._Client = new Customer();

            //Replace les seances
            this._Client.Seances = seances;

            //Replace les paiments
            this._Client.Paiment = paiment;

            //Replace les seance de cours theorique
            this._Client.SeancesTheorique = seancesTheorique;

            //Information
            this._Client.City = cbCity.Text;
            this._Client.ContratNumber = txtNumeroContrat.Text;
            this._Client.ClientNull = cbNullContrat.Checked;
            this._Client.AttestationNumber1 = txtNumeroAttestation.Text;
            this._Client.AttestationNumber2 = txtNumeroAttestation2.Text;
            this._Client.DateInscription = DateInscription.Value;
            this._Client.FirstName = txtFirstName.Text;
            this._Client.Name = txtName.Text;
            this._Client.No6R = txtN6R.Text;
            this._Client.Phone = txtPhoneNumber.Text;
            this._Client.PhoneBureau = txtPhoneBureau.Text;
            this._Client.StreetApp = txtAdressApp.Text;
            this._Client.StreetName = txtAdressStreet.Text;
            this._Client.StreetNumber = txtAdressNumber.Text;
            this._Client.CodePostal = txtCodePostal.Text;
            this._Client.Notes = txtNotes.RTFCode;
            this._Client.DateNaissance = DateNaissance.Value;
            this._Client.DateExpiration = DateExpiration.Value;
            this._Client.DateDebutCours = DateDebutCours.Value;
            this._Client.DateAttestation1 = dtpAttestation1.Value;
            this._Client.DateAttestation2 = dtpAttestation2.Value;
            this._Client.NumeroGroupe = Convert.ToInt32(txtNumeroGroupe.Text);
            this._Client.Email = txtEmail.Text;

            //Taux horaire
            this._Client.TauxHorairePratique = ctbTauxHorairePratique.Text;
            this._Client.TauxHoraireTheorique = ctbTauxHoraireTheorique.Text;

            //Permis de conduire
            this._Client.NumeroPermis = txtNumeroPermis.Text;
            this._Client.DateTemporaire = dtpDatePermis.Value;
            this._Client.HaveTemporaire = cbPermisObtenue.Checked;

            //Location de vehicule
            this._Client.LocationAutomobile = cbAuto.Checked;
            this._Client.LocationMoto = cbMoto.Checked;
            this._Client.MontantLocation = ctbLocationMontant.Text;
            this._Client.BVA = cbBVA.Checked;
            this._Client.BVADate = dtpBVA.Value;

            //Information sur le solde du client
            this._Client.Solde = CashBox_Solde.Text;
            this._Client.LastRecuNumber = dbRecuNumber.Text;
            this._Client.MontantCours = _MontantCours;

            //Disponibiliter
            this._Client.DisponibilityAM = chkDisponibilityAM.Checked;
            this._Client.DisponibilityPM = chkDisponibilityPM.Checked;
            this._Client.DisponibilitySoirer = chkDisponibilitySoir.Checked;
            this._Client.DisponibilitySamedi = chkDisponibilitySamedi.Checked;
            this._Client.DisponibilityDimanche = chkDisponibilityDimanche.Checked;

            //Type de client
            if (rbTypeClientActif.Checked)
                this._Client.TypeClient = ProfileType.Actif;
            else if (rbTypeClientFinish.Checked)
                this._Client.TypeClient = ProfileType.CoursTerminer;

            //Type de vehicule
            if (rbVehiculAutomatique.Checked)
                this._Client.TypeVehicule = VehiculeType.Automatique;
            else if (rbVehiculMotocyclette.Checked)
                this._Client.TypeVehicule = VehiculeType.Cyclomoteur;
            else if (rbVehiculManuel.Checked)
                this._Client.TypeVehicule = VehiculeType.Manuel;
            else if (rbVehiculMoto.Checked)
                this._Client.TypeVehicule = VehiculeType.Moto;
        }

        /// <summary>
        /// Ferme le client
        /// </summary>
        public void CloseClient() {
            //Information
            cbCity.Text = "";
            txtNumeroContrat.Text = "";
            txtNumeroAttestation.Text = "";
            txtNumeroGroupe.Text = "";
            cbNullContrat.Checked = false;

            if (DateInscription.Value != DateTime.Now)
                DateInscription.Value = DateTime.Now;

            txtFirstName.Text = "";
            txtName.Text = "";
            txtN6R.Text = "";
            txtNumeroPermis.Text = "";
            txtPhoneNumber.Text = "";
            txtPhoneBureau.Text = "";
            txtAdressApp.Text = "";
            txtAdressStreet.Text = "";
            txtAdressNumber.Text = "";
            txtCodePostal.Text = "";
            dbRecuNumber.Text = "0";
            CashBox_Solde.Text = "0,00 $";
            ctbTauxHorairePratique.Text = "0,00 $";
            ctbTauxHoraireTheorique.Text = "0,00 $";
            cbBVA.Checked = false;
            dtpBVA.Value = DateTime.Now;
            DateNaissance.Value = DateTime.Now;
            DateExpiration.Value = DateTime.Now;
            DateDebutCours.Value = DateTime.Now;
            txtEmail.Text = "";

            txtNotes.RTFCode = "";
            this._MontantCours = "";

            //Location de vehicule
            cbAuto.Checked = false;
            cbMoto.Checked = false;
            ctbLocationMontant.Text = "";

            //Disponibiliter
            chkDisponibilityAM.Checked = false;
            chkDisponibilityPM.Checked = false;
            chkDisponibilitySoir.Checked = false;
            chkDisponibilitySamedi.Checked = false;
            chkDisponibilityDimanche.Checked = false;

            //Permis de conduire			
            dtpDatePermis.Value = DateTime.Now;
            cbPermisObtenue.Checked = false; ;

            //Type de client
            rbTypeClientActif.Checked = false;
            //rbTypeClientAbsence.Checked = false;
            rbTypeClientFinish.Checked = false;
            //rbTypeClientSoldSouffrance.Checked = false;
            //rbTypeClientTheorie.Checked = false;

            //Type de vehicule
            rbVehiculAutomatique.Checked = false;
            rbVehiculMotocyclette.Checked = false;
            rbVehiculManuel.Checked = false;
            rbVehiculMoto.Checked = false;
        }

        /// <summary>
        /// Fabrique le control a partir d'un objet Client
        /// </summary>
        private void MakeControl(Customer client) {
            //Information
            if (client != null) {
                cbCity.Text = client.City;
                txtNumeroContrat.Text = client.ContratNumber;
                cbNullContrat.Checked = client.ClientNull;
                txtNumeroAttestation.Text = client.AttestationNumber1;
                txtNumeroAttestation2.Text = client.AttestationNumber2;
                DateInscription.Value = client.DateInscription;
                txtFirstName.Text = client.FirstName;
                txtName.Text = client.Name;
                txtN6R.Text = client.No6R;
                txtAdressApp.Text = client.StreetApp;
                txtAdressStreet.Text = client.StreetName;
                txtAdressNumber.Text = client.StreetNumber;
                txtCodePostal.Text = client.CodePostal;
                txtNumeroGroupe.Text = client.NumeroGroupe.ToString();
                txtEmail.Text = client.Email;

                //Date Naissance
                try {
                    DateNaissance.Value = client.DateNaissance;
                }
                catch {
                    DateNaissance.Value = DateTime.Now;
                }

                //Date Attestation 1
                try {
                    dtpAttestation1.Value = client.DateAttestation1;
                }
                catch {
                    dtpAttestation1.Value = DateTime.Now;
                }

                //Date Attestation 2
                try {
                    dtpAttestation2.Value = client.DateAttestation2;
                }
                catch {
                    dtpAttestation2.Value = DateTime.Now;
                }

                //Date Expiration
                try {
                    DateExpiration.Value = client.DateExpiration;
                }
                catch {
                    DateExpiration.Value = DateTime.Now;
                }

                //Date Debut cours
                try {
                    DateDebutCours.Value = client.DateDebutCours;
                }
                catch {
                    DateDebutCours.Value = DateTime.Now;
                }

                //Notes
                try {
                    txtNotes.RTFCode = client.Notes;
                }
                catch {
                    txtNotes.PlainText = client.Notes;
                }

                //Numéro de telephone a la maison
                string TempPhone = client.Phone.Replace("(", "");
                TempPhone = TempPhone.Replace(")", "");
                TempPhone = TempPhone.Replace("(", "");
                TempPhone = TempPhone.Replace("-", "");
                TempPhone = TempPhone.Replace(" ", "");

                txtPhoneNumber.Text = TempPhone;

                //Numéro de telephone au travail
                TempPhone = client.PhoneBureau.Replace("(", "");
                TempPhone = TempPhone.Replace(")", "");
                TempPhone = TempPhone.Replace("(", "");
                TempPhone = TempPhone.Replace("-", "");
                TempPhone = TempPhone.Replace(" ", "");
                txtPhoneBureau.Text = TempPhone;
                
                //Permis de conduire
                txtNumeroPermis.Text = client.NumeroPermis;
                cbPermisObtenue.Checked = client.HaveTemporaire;
                try {
                    dtpDatePermis.Value = client.DateTemporaire;
                }
                catch {
                    dtpDatePermis.Value = DateTime.Now;
                }
                dtpDatePermisPlus8.Value = dtpDatePermis.Value.AddMonths(8);

                //Disponibiliter
                chkDisponibilityAM.Checked = client.DisponibilityAM;
                chkDisponibilityPM.Checked = client.DisponibilityPM;
                chkDisponibilitySoir.Checked = client.DisponibilitySoirer;
                chkDisponibilitySamedi.Checked = client.DisponibilitySamedi;
                chkDisponibilityDimanche.Checked = client.DisponibilityDimanche;

                //Location de vehicule
                cbAuto.Checked = Convert.ToBoolean(client.LocationAutomobile);
                cbMoto.Checked = Convert.ToBoolean(client.LocationMoto);
                ctbLocationMontant.Text = client.MontantLocation;
                cbBVA.Checked = client.BVA;

                try {
                    dtpBVA.Value = client.BVADate;
                }
                catch {
                    dtpBVA.Value = DateTime.Now;
                }

                //Information sur le solde du client
                CashBox_Solde.Text = client.Solde;
                dbRecuNumber.Text = client.LastRecuNumber;
                this._MontantCours = client.MontantCours;

                //Taux horaire
                ctbTauxHorairePratique.Text = client.TauxHorairePratique;
                ctbTauxHoraireTheorique.Text = client.TauxHoraireTheorique;

                //Type de client
                if (client.TypeClient == ProfileType.Actif)
                    rbTypeClientActif.Checked = true;
                else if (client.TypeClient == ProfileType.CoursTerminer)
                    rbTypeClientFinish.Checked = true;

                //Type de vehicule
                if (client.TypeVehicule == VehiculeType.Automatique)
                    rbVehiculAutomatique.Checked = true;
                else if (client.TypeVehicule == VehiculeType.Cyclomoteur)
                    rbVehiculMotocyclette.Checked = true;
                else if (client.TypeVehicule == VehiculeType.Manuel)
                    rbVehiculManuel.Checked = true;
                else if (client.TypeVehicule == VehiculeType.Moto)
                    rbVehiculMoto.Checked = true;
            }
        }

        /// <summary>
        /// Vérifie si le client est valide mais n'affiche aucun messagebox contrairement au ValidateClient
        /// </summary>
        /// <returns></returns>
        private bool ValidNoText() {

            if (txtName.Text == "") return false;
            if (txtFirstName.Text == "") return false;
            if (txtAdressStreet.Text == "") return false;
            if (txtAdressNumber.Text == "") return false;
            if (txtNumeroContrat.Text == "") return false;
            if (txtPhoneNumber.Text == "") return false;

            return true;
        }

        /// <summary>
        /// Valise si le client est ok.
        /// TODO : CETTE FONCTION DOIT ÊTRE REFAITE
        /// </summary>
        /// <returns></returns>
        public bool ValidateClient() {
            this._AutoUpdate = false;

            if (txtName.Text == "") {
                MessageBox.Show(this, "Un client doit avoir un nom", "Gestion Auto-École", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return false;
            }

            if (txtFirstName.Text == "") {
                MessageBox.Show(this, "Un client doit avoir un prénom", "Gestion Auto-École", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFirstName.Focus();
                return false;
            }

            if (txtAdressStreet.Text == "") {
                MessageBox.Show(this, "Un client doit avoir un adresse", "Gestion Auto-École", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAdressStreet.Focus();
                return false;
            }

            if (txtAdressNumber.Text == "") {
                MessageBox.Show(this, "Un client doit avoir un numéro civic pour son adresse", "Gestion Auto-École", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAdressNumber.Focus();
                return false;
            }

            if (txtNumeroContrat.Text == "") {
                MessageBox.Show(this, "Un client doit avoir un numéro de contrat", "Gestion Auto-École", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumeroContrat.Focus();
                return false;
            }

            if (txtPhoneNumber.Text == "") {
                MessageBox.Show(this, "Un client doit avoir un numéro de téléphone", "Gestion Auto-École", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhoneNumber.Focus();
                return false;
            }

            this._AutoUpdate = true;
            return true;
        }
        #endregion

        #region Impression
        //Variable global pour l'impression
        bool _PrintHorsRoute = true;
        bool _PrintRoute = true;

        /// <summary>
        /// Impression de la fiche client
        /// </summary>
        public void PrintDoc(PrintDocumentType doctype) {
            PrintDoc(false, true, true, doctype);
            
        }

        /// <summary>
        /// Impression de la fiche client
        /// </summary>		
        /// <param name="confirmation">Demander une confirmation d'impression</param>		
        public void PrintDoc(bool confirmation, bool PrintHorsRoute, bool PrintRoute, PrintDocumentType DocType) {
            //modification des variables
            _PrintHorsRoute = PrintHorsRoute;
            _PrintRoute = PrintRoute;

            //Lance l'impression
            PrintDialog printConfig = new PrintDialog();

            printConfig.PrinterSettings = printDocument1.PrinterSettings;

#if DEBUG
            PrintPreviewDialog prev = new PrintPreviewDialog();

            // Type de document à imprimé
            switch (DocType) {
                case PrintDocumentType.InfoClient:
                    prev.Document = printDocument1;
                    break;
                case PrintDocumentType.Contract:
                    prev.Document = printDocContract;
                    break;
                case PrintDocumentType.InfoClientTheorique:
                    prev.Document = printDocTheorique;
                    break;
                case PrintDocumentType.Moto2015:
                    prev.Document = printDocMoto2015;
                    break;
                case PrintDocumentType.PaimentList:
                    FormPaiment frmPaiment = new FormPaiment(this, this._Client, this._infoSchool);
                    frmPaiment.PrintListPaiment();
                    frmPaiment.Close();
                    frmPaiment = null;
                    break;

            }

            prev.ShowDialog(this);

#else
			if (confirmation  == true){
				if(printConfig.ShowDialog(this) == DialogResult.OK)
                    // Type de document à imprimé
                    switch (DocType) {
                        case PrintDocumentType.InfoClient:
                            printDocument1.Print();
                            break;
                        case PrintDocumentType.Contract:
                            printDocContract.Print();
                            break;
                        case PrintDocumentType.InfoClientTheorique:
                            printDocTheorique.Print();
                            break;
                        case PrintDocumentType.Moto2015:
                            printDocMoto2015.Print();
                            break;
                        case PrintDocumentType.PaimentList:
                            FormPaiment frmPaiment = new FormPaiment(this, this._Client, this._infoSchool);
                            frmPaiment.PrintListPaiment();
                            frmPaiment.Close();
                            frmPaiment = null;
                            break;
                    }
			}
			else
                // Type de document à imprimé
                switch (DocType) {
                    case PrintDocumentType.InfoClient:
                        printDocument1.Print();
                        break;
                    case PrintDocumentType.Contract:
                        printDocContract.Print();
                        break;
                    case PrintDocumentType.InfoClientTheorique:
                        printDocTheorique.Print();
                        break;
                    case PrintDocumentType.Moto2015:
                        printDocMoto2015.Print();
                        break;
                    case PrintDocumentType.PaimentList:
                        FormPaiment frmPaiment = new FormPaiment(this, this._Client, this._infoSchool);
                        frmPaiment.PrintListPaiment();
                        frmPaiment.Close();
                        frmPaiment = null;
                        break;
                }
#endif

        }

        /// <summary>
        /// Défini l'impression de la fiche client.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {

            //Ecriture du header (image)
            Stream strm = Type.GetType("Barette.Library.UserControls.Client.ClientControl").Assembly.GetManifestResourceStream("Barette.Library.res.Printlogo.png");
            Bitmap img = new Bitmap(strm);
            e.Graphics.DrawImage(img, 0, 0, 383, 207);
            float topMargin = img.Height + 20;
            float leftMargin = 0;//e.MarginBounds.Left;

            //Facrication des fonts
            Font printFont = new System.Drawing.Font("Courier New", 11);
            Font printFontTime = new Font("Times New Roman", 12, FontStyle.Regular);
            Font printFontBold = new Font("Times New Roman", 12, FontStyle.Bold);
            Font printFontBold16 = new Font("Times New Roman", 16, FontStyle.Bold);
            Font printFontBoldItalic16 = new Font("Times New Roman", 16, FontStyle.Bold & FontStyle.Italic);

            float yPos = 0f;
            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

            //Fabrication du client avant impression	
            this.MakeClient();

            //Rectangle de contour
            //e.Graphics.DrawRectangle(new Pen(Color.Black), leftMargin, topMargin, e.MarginBounds.Size.Width, 5 * printFont.Height + 10);

            //Donnée a imprimer
            yPos = topMargin + 5;
            e.Graphics.DrawString("Informations général", printFontBold16, Brushes.Black, leftMargin, yPos, new StringFormat());
            e.Graphics.DrawString("Imprimé le : " + DateTime.Now.ToShortDateString(), printFontTime, Brushes.Black, leftMargin + 450, yPos, new StringFormat());
            yPos += printFont.Height + 16;

            e.Graphics.DrawString("Nom : " + this._Client.Name + " " + this.Client.FirstName, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Nº contrat : " + this._Client.ContratNumber, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Date d'inscription : " + this._Client.DateInscription.ToShortDateString(), printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Adresse : " + this._Client.StreetNumber + " " + this.Client.StreetName + " App. " + this.Client.StreetApp, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Code Postale : " + this._Client.CodePostal, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Ville : " + this._Client.City, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Numéro de permis : " + this._Client.NumeroPermis, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

            if (this._Client.TypeVehicule == VehiculeType.Moto) {
                yPos += printFont.Height;
                e.Graphics.DrawString("Type de cours : Moto           Numéro 6R :" + this.Client.No6R, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            }
            else {
                yPos += printFont.Height;
                e.Graphics.DrawString("Type de cours : " + this.Client.TypeVehicule, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            }

            yPos += printFont.Height;
            e.Graphics.DrawString("Téléphone : " + this._Client.Phone, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Téléphone (Autre) : " + this._Client.PhoneBureau, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

            yPos += printFont.Height;
            e.Graphics.DrawString("État du client : " + this._Client.TypeClient, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

            if (this._Client.BVA == true) {
                yPos += printFont.Height;
                e.Graphics.DrawString("Date BVA : " + this._Client.BVADate.ToShortDateString() + " " + this._Client.BVADate.ToShortTimeString(), printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            }

            //Ecriture des seances
            yPos += printFont.Height * 2;
            e.Graphics.DrawString("Séance de cours", printFontBold16, Brushes.Black, leftMargin, yPos, new StringFormat());
            yPos += 30;

            //Header des colone
            e.Graphics.DrawString("Date et heure", printFontBold, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
            e.Graphics.DrawString("Endroit", printFontBold, Brushes.Black, leftMargin + 420, yPos, new StringFormat());
            e.Graphics.DrawString("Moniteur", printFontBold, Brushes.Black, leftMargin + 590, yPos, new StringFormat());

            Seance seance = null;
            if (this._Client.TypeVehicule != VehiculeType.Moto) {

                //Header de la colone montant
                e.Graphics.DrawString("Montant", printFontBold, Brushes.Black, 580 - e.Graphics.MeasureString("Montant", printFont).Width, yPos, new StringFormat());
                yPos += 16;

                for (int i = 0; i < this.Client.Seances.Count; i++) {
                    seance = (Seance)this._Client.Seances[i];

                    //Seulement les automobiles
                    if (seance.Active) {
                        yPos += printFont.Height;
                        e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 40, yPos, new StringFormat());
                        e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToLongDateString(), printFont, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
                        e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 340, yPos, new StringFormat());
                        e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 420, yPos, new StringFormat());
                        e.Graphics.DrawString(seance.Montant, printFont, Brushes.Black, 580 - e.Graphics.MeasureString(seance.Montant, printFont).Width, yPos, new StringFormat());
                        e.Graphics.DrawString(seance.Employer, printFont, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
                    }
                }
            }
            else {

                e.Graphics.DrawString("Signature", printFontBold, Brushes.Black, leftMargin + 490, yPos, new StringFormat());

                for (int i = 0; i < this.Client.Seances.Count; i++) {
                    seance = (Seance)this._Client.Seances[i];

                    //fabrique les donnees pour le type moto
                    if (i == 0) {
                        if (this._PrintHorsRoute) {
                            yPos += printFont.Height * 2;
                            e.Graphics.DrawString("Hors Route", printFontBoldItalic16, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                            yPos += 16;

                            if (seance.Active) {
                                yPos += printFont.Height;
                                e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 40, yPos, new StringFormat());
                                e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToLongDateString(), printFont, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
                                e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 340, yPos, new StringFormat());
                                e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 420, yPos, new StringFormat());
                                e.Graphics.DrawString(seance.Employer, printFont, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
                            }
                        }
                    }
                    else if (i < 4) {

                        if (seance.Active && this._PrintHorsRoute) {
                            yPos += printFont.Height;
                            e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 40, yPos, new StringFormat());
                            e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToLongDateString(), printFont, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
                            e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 340, yPos, new StringFormat());
                            e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 420, yPos, new StringFormat());
                            e.Graphics.DrawString(seance.Employer, printFont, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
                        }
                    }
                    else if (i == 4) {
                        if (this._PrintRoute) {
                            yPos += printFont.Height * 2;
                            e.Graphics.DrawString("Route", printFontBoldItalic16, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                            yPos += 16;

                            if (seance.Active) {
                                yPos += printFont.Height;
                                e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 40, yPos, new StringFormat());
                                e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToLongDateString(), printFont, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
                                e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 340, yPos, new StringFormat());
                                e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 420, yPos, new StringFormat());
                                e.Graphics.DrawString(seance.Employer, printFont, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
                            }
                        }
                    }
                    else {
                        if (seance.Active && this._PrintRoute) {
                            yPos += printFont.Height;
                            e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 40, yPos, new StringFormat());
                            e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToLongDateString(), printFont, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
                            e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 340, yPos, new StringFormat());
                            e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 420, yPos, new StringFormat());
                            e.Graphics.DrawString(seance.Employer, printFont, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
                        }
                    }
                }
            }


            //Impression de l'équipement
            if (this._Client.TypeVehicule == VehiculeType.Moto) {
                yPos += (printFontBold.Height * 2);
                e.Graphics.DrawString("Équipements Nécessaires", printFontBold, Brushes.Black, leftMargin, yPos, new StringFormat());
                yPos += printFontTime.Height;
                e.Graphics.DrawString("1. Casque avec visière", printFontTime, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                yPos += printFontTime.Height;
                e.Graphics.DrawString("2. Bottes sécuritaires (couvrant la cheville)", printFontTime, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                yPos += printFontTime.Height;
                e.Graphics.DrawString("3. Gants de cuir (couvrant le poignet de préférence)", printFontTime, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                yPos += printFontTime.Height;
                e.Graphics.DrawString("4. Habit de pluie 2 parties séparées (haut et bas)", printFontTime, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            }

            //Imprime les messages d'attention
            yPos += 50;
            Font myFont = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("ATTENTION", myFont, Brushes.Black, leftMargin, yPos, new StringFormat());

            SizeF strLength = e.Graphics.MeasureString("ATTENTION", myFont); //Largeur de la chaine
            if (this._Client.TypeVehicule == VehiculeType.Automatique) {
                e.Graphics.DrawString("Un pré-avis de 24 heures est requis tel que convenue sur le contrat de service;", printFontTime, Brushes.Black, leftMargin + strLength.Width, yPos, new StringFormat());
            }
            else
                e.Graphics.DrawString("Un pré-avis de 48 heures est requis tel que convenue sur le contrat de service;", printFontTime, Brushes.Black, leftMargin + strLength.Width, yPos, new StringFormat());

            yPos += myFont.Height;
            e.Graphics.DrawString("pour l'annulation de séances pratiques", printFontTime, Brushes.Black, leftMargin + strLength.Width, yPos, new StringFormat());
            yPos += (myFont.Height * 2);
            e.Graphics.DrawString("Les locations Auto/Moto sont non remboursables.", printFontTime, Brushes.Black, leftMargin + strLength.Width, yPos, new StringFormat());
        }

        /// <summary>
        /// Défini l'impression de la fiche client pour les cours théoriques.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocTheorique_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {

            //Ecriture du header (image)
            Stream strm = Type.GetType("Barette.Library.UserControls.Client.ClientControl").Assembly.GetManifestResourceStream("Barette.Library.res.Printlogo.png");
            Bitmap img = new Bitmap(strm);
            e.Graphics.DrawImage(img, 0, 0, 383, 207);
            float topMargin = img.Height + 20;
            float leftMargin = 0;//e.MarginBounds.Left;

            //Facrication des fonts
            Font printFont = new System.Drawing.Font("Courier New", 11);
            Font printFontTime = new Font("Times New Roman", 12, FontStyle.Regular);
            Font printFontBold = new Font("Times New Roman", 12, FontStyle.Bold);
            Font printFontBold16 = new Font("Times New Roman", 16, FontStyle.Bold);
            Font printFontBoldItalic16 = new Font("Times New Roman", 16, FontStyle.Bold & FontStyle.Italic);

            float yPos = 0f;
            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

            //Fabrication du client avant impression	
            this.MakeClient();

            //Rectangle de contour
            //e.Graphics.DrawRectangle(new Pen(Color.Black), leftMargin, topMargin, e.MarginBounds.Size.Width, 5 * printFont.Height + 10);

            //Donnée a imprimer
            yPos = topMargin + 5;
            e.Graphics.DrawString("Informations général", printFontBold16, Brushes.Black, leftMargin, yPos, new StringFormat());
            e.Graphics.DrawString("Imprimé le : " + DateTime.Now.ToShortDateString(), printFontTime, Brushes.Black, leftMargin + 450, yPos, new StringFormat());
            yPos += printFont.Height + 16;

            e.Graphics.DrawString("Nom : " + this._Client.Name + " " + this.Client.FirstName, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Nº contrat : " + this._Client.ContratNumber, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Date d'inscription : " + this._Client.DateInscription.ToShortDateString(), printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Adresse : " + this._Client.StreetNumber + " " + this.Client.StreetName + " App. " + this.Client.StreetApp, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Code Postale : " + this._Client.CodePostal, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Ville : " + this._Client.City, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Numéro de permis : " + this._Client.NumeroPermis, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

            if (this._Client.TypeVehicule == VehiculeType.Moto) {
                yPos += printFont.Height;
                e.Graphics.DrawString("Type de cours : Moto           Numéro 6R :" + this.Client.No6R, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            }
            else {
                yPos += printFont.Height;
                e.Graphics.DrawString("Type de cours : " + this.Client.TypeVehicule, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            }

            yPos += printFont.Height;
            e.Graphics.DrawString("Téléphone : " + this._Client.Phone, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Téléphone (Autre) : " + this._Client.PhoneBureau, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

            yPos += printFont.Height;
            e.Graphics.DrawString("État du client : " + this._Client.TypeClient, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

            if (this._Client.BVA == true) {
                yPos += printFont.Height;
                e.Graphics.DrawString("Date BVA : " + this._Client.BVADate.ToShortDateString() + " " + this._Client.BVADate.ToShortTimeString(), printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            }

            //Ecriture des seances
            yPos += printFont.Height * 2;
            e.Graphics.DrawString("Séance de cours théorique", printFontBold16, Brushes.Black, leftMargin, yPos, new StringFormat());
            yPos += 30;

            //Header des colone
            e.Graphics.DrawString("Date et heure", printFontBold, Brushes.Black, leftMargin + 80, yPos, new StringFormat());

            Seance seance = null;
            if (this._Client.TypeVehicule != VehiculeType.Moto) {

                //Header de la colone montant
                e.Graphics.DrawString("Montant", printFontBold, Brushes.Black, 580 - e.Graphics.MeasureString("Montant", printFont).Width, yPos, new StringFormat());
                yPos += 16;

                for (int i = 0; i < this.Client.SeancesTheorique.Count; i++) {
                    seance = (Seance)this._Client.SeancesTheorique[i];

                    //Seulement les automobiles
                    if (seance.Active) {
                        yPos += printFont.Height;
                        e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 40, yPos, new StringFormat());
                        e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToLongDateString(), printFont, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
                        e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 340, yPos, new StringFormat());
                        e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 420, yPos, new StringFormat());
                        e.Graphics.DrawString(seance.Montant, printFont, Brushes.Black, 580 - e.Graphics.MeasureString(seance.Montant, printFont).Width, yPos, new StringFormat());
                        e.Graphics.DrawString(seance.Employer, printFont, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
                    }
                }
            }
            else {

                e.Graphics.DrawString("Signature", printFontBold, Brushes.Black, leftMargin + 490, yPos, new StringFormat());

                for (int i = 0; i < this.Client.SeancesTheorique.Count; i++) {
                    seance = (Seance)this._Client.SeancesTheorique[i];

                    //fabrique les donnees pour le type moto
                    if (i == 0) {
                        if (this._PrintHorsRoute) {
                            yPos += printFont.Height * 2;
                            e.Graphics.DrawString("Hors Route", printFontBoldItalic16, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                            yPos += 16;

                            if (seance.Active) {
                                yPos += printFont.Height;
                                e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 40, yPos, new StringFormat());
                                e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToLongDateString(), printFont, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
                                e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 340, yPos, new StringFormat());
                                e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 420, yPos, new StringFormat());
                                e.Graphics.DrawString(seance.Employer, printFont, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
                            }
                        }
                    }
                    else if (i < 4) {

                        if (seance.Active && this._PrintHorsRoute) {
                            yPos += printFont.Height;
                            e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 40, yPos, new StringFormat());
                            e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToLongDateString(), printFont, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
                            e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 340, yPos, new StringFormat());
                            e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 420, yPos, new StringFormat());
                            e.Graphics.DrawString(seance.Employer, printFont, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
                        }
                    }
                    else if (i == 4) {
                        if (this._PrintRoute) {
                            yPos += printFont.Height * 2;
                            e.Graphics.DrawString("Route", printFontBoldItalic16, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                            yPos += 16;

                            if (seance.Active) {
                                yPos += printFont.Height;
                                e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 40, yPos, new StringFormat());
                                e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToLongDateString(), printFont, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
                                e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 340, yPos, new StringFormat());
                                e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 420, yPos, new StringFormat());
                                e.Graphics.DrawString(seance.Employer, printFont, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
                            }
                        }
                    }
                    else {
                        if (seance.Active && this._PrintRoute) {
                            yPos += printFont.Height;
                            e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 40, yPos, new StringFormat());
                            e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToLongDateString(), printFont, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
                            e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 340, yPos, new StringFormat());
                            e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 420, yPos, new StringFormat());
                            e.Graphics.DrawString(seance.Employer, printFont, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
                        }
                    }
                }
            }


            //Impression de l'équipement
            if (this._Client.TypeVehicule == VehiculeType.Moto) {
                yPos += (printFontBold.Height * 2);
                e.Graphics.DrawString("Équipements Nécessaires", printFontBold, Brushes.Black, leftMargin, yPos, new StringFormat());
                yPos += printFontTime.Height;
                e.Graphics.DrawString("1. Casque avec visière", printFontTime, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                yPos += printFontTime.Height;
                e.Graphics.DrawString("2. Bottes sécuritaires (couvrant la cheville)", printFontTime, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                yPos += printFontTime.Height;
                e.Graphics.DrawString("3. Gants de cuir (couvrant le poignet de préférence)", printFontTime, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                yPos += printFontTime.Height;
                e.Graphics.DrawString("4. Habit de pluie 2 parties séparées (haut et bas)", printFontTime, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            }

            //Imprime les messages d'attention
            yPos += 50;
            Font myFont = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("ATTENTION", myFont, Brushes.Black, leftMargin, yPos, new StringFormat());

            SizeF strLength = e.Graphics.MeasureString("ATTENTION", myFont); //Largeur de la chaine
            if (this._Client.TypeVehicule == VehiculeType.Automatique) {
                e.Graphics.DrawString("Un pré-avis de 24 heures est requis tel que convenue sur le contrat de service;", printFontTime, Brushes.Black, leftMargin + strLength.Width, yPos, new StringFormat());
            }
            else
                e.Graphics.DrawString("Un pré-avis de 48 heures est requis tel que convenue sur le contrat de service;", printFontTime, Brushes.Black, leftMargin + strLength.Width, yPos, new StringFormat());

            yPos += myFont.Height;
            e.Graphics.DrawString("pour l'annulation de séances pratiques", printFontTime, Brushes.Black, leftMargin + strLength.Width, yPos, new StringFormat());
            yPos += (myFont.Height * 2);
            e.Graphics.DrawString("Les locations Auto/Moto sont non remboursables.", printFontTime, Brushes.Black, leftMargin + strLength.Width, yPos, new StringFormat());
        }
        #endregion

        /// <summary>
        /// Affiche la liste de paiment
        /// </summary>
        public DialogResult ShowPaiement(int Number) {
            FormPaiment frmPaiment = new FormPaiment(this, this._Client, this._infoSchool);

            frmPaiment.SelectPaiment(Number);
            frmPaiment.ShowDialog();
            return frmPaiment.DialogResult;
        }

        /// <summary>
        /// Affiche la liste de paiment
        /// </summary>
        public DialogResult ShowPaiement() {
            FormPaiment frmPaiment = new FormPaiment(this, this._Client, this._infoSchool);

            frmPaiment.ShowDialog();
            return frmPaiment.DialogResult;
        }


        private void cmdNow_Click(object sender, System.EventArgs e) {

        }

        private void button1_Click(object sender, System.EventArgs e) {
            ShowPaiement();

            //Afficher le solde et le dernier numero de recu
            //...
        }

        private void txtNotes_TextChanged(object sender, System.EventArgs e) {
            //			int CharRestant = txtNotes2.MaxLength - txtNotes2.Text.Length;
            //
            //			lblCharRestant.Text = CharRestant + " Caractères restant"; 
            //			lblCharRestant.Visible = true;

        }

        private void ctbLocationMontant_Leave(object sender, System.EventArgs e) {
            if (ctbLocationMontant.Text == "")
                ctbLocationMontant.Text = " 0 $";

        }

        private void cmdAlwayDispo_Click(object sender, System.EventArgs e) {
            chkDisponibilityAM.Checked = true;
            chkDisponibilityPM.Checked = true;
            chkDisponibilitySoir.Checked = true;
            chkDisponibilityDimanche.Checked = true;
            chkDisponibilitySamedi.Checked = true;
        }

        private void txtFirstName_TextChanged(object sender, System.EventArgs e) {

        }

        private void cbBVA_CheckedChanged(object sender, System.EventArgs e) {
            dtpBVA.Enabled = cbBVA.Checked;
        }

        private void timerCheckClientValid_Tick(object sender, System.EventArgs e) {
            if (ValidNoText()) this._AutoUpdate = true;

            if (this.txtNumeroGroupe.Value == 0) {
                gbCoursType.Enabled = true;
                cmdClearbox.Enabled = false;
            }
            else {
                gbCoursType.Enabled = false;
                cmdClearbox.Enabled = true;
            }

            //if ((TypeVehicule == VehiculeType.Moto || TypeVehicule == VehiculeType.Cyclomoteur) && DateInscription.Value >= new DateTime(2015,04,10))            
            if (TypeVehicule == VehiculeType.Moto && DateInscription.Value >= new DateTime(2015, 04, 10))
                cmdShowSeancesMoto2015.Visible = true;
            else
                cmdShowSeancesMoto2015.Visible = false;
        }

        private void dtpDatePermis_ValueChanged(object sender, System.EventArgs e) {
            dtpDatePermisPlus8.Value = dtpDatePermis.Value.AddMonths(8);
        }

        private void cbPermisObtenue_CheckedChanged(object sender, System.EventArgs e) {
            dtpDatePermis.Enabled = dtpDatePermisPlus8.Enabled = cbPermisObtenue.Checked;
        }

        public VehiculeType TypeVehicule {
            get {
                //Type de vehicule
                if (rbVehiculAutomatique.Checked)
                    return VehiculeType.Automatique;
                else if (rbVehiculMotocyclette.Checked)
                    return VehiculeType.Cyclomoteur;
                else if (rbVehiculManuel.Checked)
                    return VehiculeType.Manuel;
                else if (rbVehiculMoto.Checked)
                    return VehiculeType.Moto;

                return VehiculeType.Nothing;
            }
        }

        public ProfileType TypeClient {
            get {
                if (rbTypeClientActif.Checked)
                    return ProfileType.Actif;
                //else if (rbTypeClientAbsence.Checked)
                //    return ProfileType.Absence;
                else if (rbTypeClientFinish.Checked)
                    return ProfileType.CoursTerminer;
                //else if (rbTypeClientSoldSouffrance.Checked)
                //    return ProfileType.SoldSouffrance;
                //else if (rbTypeClientTheorie.Checked)
                //    return ProfileType.Theorie;

                return ProfileType.Nothing;
            }
        }

        private void txtCodePostal_Leave(object sender, EventArgs e) {
            txtCodePostal.Text = txtCodePostal.Text.ToUpper();
        }

        private void txtCodePostal_Enter(object sender, EventArgs e) {
            txtCodePostal.SelectionStart = 0;
        }

        private void txtPhoneNumber_Enter(object sender, EventArgs e) {
            //if (txtPhoneNumber.Text.StartsWith("(418)"))
            //    txtPhoneNumber.SelectionStart = 5;
            //else
            //    txtPhoneNumber.SelectionStart = 0;
        }

        private void txtPhoneBureau_Enter(object sender, EventArgs e) {
            //if (txtPhoneBureau.Text.StartsWith("(418)"))
            //    txtPhoneBureau.SelectionStart = 5;
            //else
            //    txtPhoneBureau.SelectionStart = 0;
        }

        private void cmdShowSeanceTheorique_Click(object sender, EventArgs e) {
            ShowCoursTheorique();
        }


        private void printDocContract_PrintPage(object sender, PrintPageEventArgs e) {
            //Fabrication des fonts
            Font printFont = new System.Drawing.Font("Courier New", 11);
            Font printFontTime8 = new Font("Times New Roman", 8, FontStyle.Regular);
            Font printFontTime10 = new Font("Times New Roman", 10, FontStyle.Regular);
            Font printFontTime12 = new Font("Times New Roman", 12, FontStyle.Regular);
            Font printFontBold = new Font("Times New Roman", 12, FontStyle.Bold);
            Font printFontBold10 = new Font("Times New Roman", 10, FontStyle.Bold);
            Font printFontBold14 = new Font("Times New Roman", 14, FontStyle.Bold);
            Font printFontBold16 = new Font("Times New Roman", 16, FontStyle.Bold);
            Font printFontBold24 = new Font("Times New Roman", 24, FontStyle.Bold);
            Font printFontBoldItalic16 = new Font("Times New Roman", 16, FontStyle.Bold & FontStyle.Italic);

            float leftMargin = 0;//e.MarginBounds.Left;
            float yPos = 0f;
            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

            //Fabrication du client avant impression	
            this.MakeClient();

            #region Header
            //Ecriture du header (image et texte)
            Stream strm = Type.GetType("Barette.Library.UserControls.Client.ClientControl").Assembly.GetManifestResourceStream("Barette.Library.res.Printlogo.png");
            Bitmap img = new Bitmap(strm);
            e.Graphics.DrawImage(img, 0, 0, 180, 100);

            //Info Ecole et Adresse
            yPos = 5;
            e.Graphics.DrawString(this._infoSchool.SchoolName, printFontTime10, Brushes.Black, 225, yPos, new StringFormat());
            yPos += printFontTime10.Height;
            e.Graphics.DrawString(this._infoSchool.StreetNumber + " " + this._infoSchool.StreetName, printFontTime10, Brushes.Black, 225, yPos, new StringFormat());
            yPos += printFontTime10.Height;
            e.Graphics.DrawString(this._infoSchool.City + ", QC, " + this._infoSchool.PostalCode, printFontTime10, Brushes.Black, 225, yPos, new StringFormat());
            yPos += printFontTime10.Height;
            e.Graphics.DrawString("Tel." + this._infoSchool.Phone + "   Fax." + this._infoSchool.Fax, printFontTime10, Brushes.Black, 225, yPos, new StringFormat());

            yPos += printFontBold14.Height;
            e.Graphics.DrawString("Contrat de service", printFontBold24, Brushes.Black, 225, yPos, new StringFormat());


            //yPos += printFontBold24.Height + 50;
            //e.Graphics.DrawString("Imprimé le : " + DateTime.Now.ToShortDateString(), printFontTime12, Brushes.Black, leftMargin + 600, yPos, new StringFormat());
            #endregion

            #region Informations Ecole
            yPos = 130;
            e.Graphics.DrawString("Informations sur l'école", printFontBold14, Brushes.Black, leftMargin, yPos, new StringFormat());
            yPos += printFontBold14.Height;
            e.Graphics.DrawString(this._infoSchool.SchoolName, printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            yPos += printFontTime10.Height;
            e.Graphics.DrawString(this._infoSchool.StreetNumber + " " + this._infoSchool.StreetName, printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            yPos += printFontTime10.Height;
            e.Graphics.DrawString(this._infoSchool.City + ", QC, " + this._infoSchool.PostalCode, printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());

            //Numero de permis
            yPos = 130 + printFontBold14.Height;
            e.Graphics.DrawString("Permis : ", printFontTime10, Brushes.Black, leftMargin + 400, yPos, new StringFormat());
            switch (this._Client.TypeVehicule) {
                case VehiculeType.Moto:
                    e.Graphics.DrawString(this._infoSchool.RegistrationMoto, printFontTime10, Brushes.Black, leftMargin + 530, yPos, new StringFormat());
                    break;
                default:
                    e.Graphics.DrawString(this._infoSchool.RegistrationAuto, printFontTime10, Brushes.Black, leftMargin + 530, yPos, new StringFormat());
                    break;
            }

            //Contrat
            yPos += printFontTime10.Height;
            e.Graphics.DrawString("Contrat : ", printFontTime10, Brushes.Black, leftMargin + 400, yPos, new StringFormat());
            e.Graphics.DrawString(this._Client.ContratNumber, printFontTime10, Brushes.Black, leftMargin + 530, yPos, new StringFormat());

            //TPS et TVQ
            yPos += printFontTime10.Height;
            e.Graphics.DrawString("TPS : ", printFontTime10, Brushes.Black, leftMargin + 400, yPos, new StringFormat());
            e.Graphics.DrawString(this._infoSchool.TPS, printFontTime10, Brushes.Black, leftMargin + 530, yPos, new StringFormat());
            yPos += printFontTime10.Height;
            e.Graphics.DrawString("TVQ : ", printFontTime10, Brushes.Black, leftMargin + 400, yPos, new StringFormat());
            e.Graphics.DrawString(this._infoSchool.TVQ, printFontTime10, Brushes.Black, leftMargin + 530, yPos, new StringFormat());
            #endregion

            #region Eleves
            float hauteurEleve;

            yPos += printFontBold14.Height;
            e.Graphics.DrawString("Informations sur l'élève", printFontBold14, Brushes.Black, leftMargin, yPos, new StringFormat());

            //Nom
            yPos += printFontBold14.Height;
            hauteurEleve = yPos;
            e.Graphics.DrawString("Nom :", printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            e.Graphics.DrawString(this._Client.Name, printFontTime10, Brushes.Black, leftMargin + 80, yPos, new StringFormat());

            //Prénom
            yPos += printFontTime10.Height;
            e.Graphics.DrawString("Prénom :", printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            e.Graphics.DrawString(this._Client.FirstName, printFontTime10, Brushes.Black, leftMargin + 80, yPos, new StringFormat());

            //Adresse
            yPos += printFontTime10.Height;
            e.Graphics.DrawString("Adresse :", printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());

            if (this._Client.StreetApp != "")
                e.Graphics.DrawString(this._Client.StreetNumber + " " + this._Client.StreetName + "    App # " + this._Client.StreetApp, printFontTime10, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
            else
                e.Graphics.DrawString(this._Client.StreetNumber + " " + this._Client.StreetName, printFontTime10, Brushes.Black, leftMargin + 80, yPos, new StringFormat());

            yPos += printFontTime10.Height;
            e.Graphics.DrawString("Ville :", printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            e.Graphics.DrawString(this._Client.City + ", QC", printFontTime10, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
            yPos += printFontTime10.Height;
            e.Graphics.DrawString("Code Postal :", printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            e.Graphics.DrawString(this._Client.CodePostal, printFontTime10, Brushes.Black, leftMargin + 80, yPos, new StringFormat());

            //Date de naissance            
            e.Graphics.DrawString("Date de naissance : ", printFontTime10, Brushes.Black, leftMargin + 400, hauteurEleve, new StringFormat());
            e.Graphics.DrawString(this._Client.DateNaissance.ToLongDateString(), printFontTime10, Brushes.Black, leftMargin + 530, hauteurEleve, new StringFormat());

            // Telephone
            hauteurEleve += printFontTime10.Height;
            e.Graphics.DrawString("Téléphone (domicile): ", printFontTime10, Brushes.Black, leftMargin + 400, hauteurEleve, new StringFormat());
            e.Graphics.DrawString(this._Client.Phone, printFontTime10, Brushes.Black, leftMargin + 530, hauteurEleve, new StringFormat());

            // Telephone (autre)
            hauteurEleve += printFontTime10.Height;
            e.Graphics.DrawString("Téléphone (autre): ", printFontTime10, Brushes.Black, leftMargin + 400, hauteurEleve, new StringFormat());
            e.Graphics.DrawString(this._Client.PhoneBureau, printFontTime10, Brushes.Black, leftMargin + 530, hauteurEleve, new StringFormat());
            #endregion

            #region Détail du cours
            float hauteurDescription;

            yPos += printFontBold14.Height;
            e.Graphics.DrawString("Détails du cours", printFontBold14, Brushes.Black, leftMargin, yPos, new StringFormat());

            //Type de cours
            yPos += printFontBold14.Height;
            hauteurDescription = yPos;
            e.Graphics.DrawString("Type de cours :", printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            switch (this._Client.TypeVehicule) {
                case VehiculeType.Moto:
                    e.Graphics.DrawString("Motocyclette", printFontTime10, Brushes.Black, leftMargin + 120, yPos, new StringFormat());
                    break;
                case VehiculeType.Cyclomoteur:
                    e.Graphics.DrawString("Cyclomoteur", printFontTime10, Brushes.Black, leftMargin + 120, yPos, new StringFormat());
                    break;
                default:
                    e.Graphics.DrawString("Automobile", printFontTime10, Brushes.Black, leftMargin + 120, yPos, new StringFormat());
                    break;
            }

            //Date inscription
            yPos += printFontTime10.Height;
            e.Graphics.DrawString("Date d'inscription :", printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            e.Graphics.DrawString(this._Client.DateInscription.ToLongDateString(), printFontTime10, Brushes.Black, leftMargin + 120, yPos, new StringFormat());

            //Date expiration
            yPos += printFontTime10.Height;
            e.Graphics.DrawString("Date d'expiration :", printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            e.Graphics.DrawString(this._Client.DateExpiration.ToLongDateString(), printFontTime10, Brushes.Black, leftMargin + 120, yPos, new StringFormat());

            //Date debut cours
            yPos += printFontTime10.Height;
            e.Graphics.DrawString("Date début du cours :", printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            e.Graphics.DrawString(this._Client.DateDebutCours.ToLongDateString(), printFontTime10, Brushes.Black, leftMargin + 120, yPos, new StringFormat());

            //Prix du cours
            TaxeExtractor taxe = new TaxeExtractor();

            if (this._Client.DateInscription.Year == 2011)
                taxe = new TaxeExtractor(Convert.ToDecimal(this._Client.MontantCours.Replace("$", "").Trim()), TaxeExtractor.Years.Y2011);
            else if (this._Client.DateInscription.Year < 2011)
                taxe = new TaxeExtractor(Convert.ToDecimal(this._Client.MontantCours.Replace("$", "").Trim()), TaxeExtractor.Years.Y2008_to_2010);
            else if (this._Client.DateInscription.Year >= 2012)
                taxe = new TaxeExtractor(Convert.ToDecimal(this._Client.MontantCours.Replace("$", "").Trim()), TaxeExtractor.Years.Y2012);

            yPos += printFontTime10.Height;
            e.Graphics.DrawString("Prix du cours :", printFontTime10, Brushes.Black, leftMargin + 400, hauteurDescription, new StringFormat());
            e.Graphics.DrawString(taxe.Value.NoTaxe.ToString() + " $", printFontTime10, Brushes.Black, leftMargin + 540, hauteurDescription, new StringFormat());
            hauteurDescription += printFontTime10.Height;
            e.Graphics.DrawString("TPS :", printFontTime10, Brushes.Black, leftMargin + 400, hauteurDescription, new StringFormat());
            e.Graphics.DrawString(taxe.Value.TPS.ToString() + " $", printFontTime10, Brushes.Black, leftMargin + 540, hauteurDescription, new StringFormat());
            hauteurDescription += printFontTime10.Height;
            e.Graphics.DrawString("TVQ :", printFontTime10, Brushes.Black, leftMargin + 400, hauteurDescription, new StringFormat());
            e.Graphics.DrawString(taxe.Value.TVQ.ToString() + " $", printFontTime10, Brushes.Black, leftMargin + 540, hauteurDescription, new StringFormat());
            hauteurDescription += printFontTime10.Height;
            e.Graphics.DrawString("Total :", printFontTime10, Brushes.Black, leftMargin + 400, hauteurDescription, new StringFormat());
            e.Graphics.DrawString(taxe.Value.Total.ToString() + " $", printFontBold10, Brushes.Black, leftMargin + 540, hauteurDescription, new StringFormat());


            //Théorie et pratique 
            switch (this._Client.TypeVehicule) {
                case VehiculeType.Moto:
                    //Theorie
                    hauteurDescription += printFontTime10.Height;
                    e.Graphics.DrawString("Théorie : 9 Heures @ ", printFontTime10, Brushes.Black, leftMargin + 400, hauteurDescription, new StringFormat());
                    e.Graphics.DrawString(this._Client.TauxHoraireTheorique + " / heures", printFontTime10, Brushes.Black, leftMargin + 540, hauteurDescription, new StringFormat());

                    //Pratique
                    hauteurDescription += printFontTime10.Height;
                    e.Graphics.DrawString("Pratique: 22 Heures @ ", printFontTime10, Brushes.Black, leftMargin + 400, hauteurDescription, new StringFormat());
                    e.Graphics.DrawString(this._Client.TauxHorairePratique + " / heures", printFontTime10, Brushes.Black, leftMargin + 540, hauteurDescription, new StringFormat());

                    break;
                case VehiculeType.Cyclomoteur:
                    //theorie
                    hauteurDescription += printFontTime10.Height;
                    e.Graphics.DrawString("Théorie : 3 Heures @ ", printFontTime10, Brushes.Black, leftMargin + 400, hauteurDescription, new StringFormat());
                    e.Graphics.DrawString(this._Client.TauxHoraireTheorique + " / heures", printFontTime10, Brushes.Black, leftMargin + 540, hauteurDescription, new StringFormat());

                    //Pratique
                    hauteurDescription += printFontTime10.Height;
                    e.Graphics.DrawString("Pratique: 3 Heures @ ", printFontTime10, Brushes.Black, leftMargin + 400, hauteurDescription, new StringFormat());
                    e.Graphics.DrawString(this._Client.TauxHorairePratique + " / heures", printFontTime10, Brushes.Black, leftMargin + 540, hauteurDescription, new StringFormat());

                    break;
                default:
                    //theorie
                    hauteurDescription += printFontTime10.Height;
                    e.Graphics.DrawString("Théorie : 24 Heures @ ", printFontTime10, Brushes.Black, leftMargin + 400, hauteurDescription, new StringFormat());
                    e.Graphics.DrawString(this._Client.TauxHoraireTheorique + " / heures", printFontTime10, Brushes.Black, leftMargin + 540, hauteurDescription, new StringFormat());

                    //Pratique
                    hauteurDescription += printFontTime10.Height;
                    e.Graphics.DrawString("Pratique: 15 Heures @ ", printFontTime10, Brushes.Black, leftMargin + 400, hauteurDescription, new StringFormat());
                    e.Graphics.DrawString(this._Client.TauxHorairePratique + " / heures", printFontTime10, Brushes.Black, leftMargin + 540, hauteurDescription, new StringFormat());

                    break;
            }

            #endregion

            #region Lieu de formation en circuit fermé pour moto et cylclo
            //Ajouter le lieu de formation de moto en cas de client moto ou cylclomoteur
            if ((this._Client.TypeVehicule == VehiculeType.Moto) || (this._Client.TypeVehicule == VehiculeType.Cyclomoteur)) {
                yPos += printFontBold24.Height;
                e.Graphics.DrawString("Lieu de formation en circuit fermé", printFontBold14, Brushes.Black, leftMargin, yPos, new StringFormat());
                yPos += printFontBold14.Height;
                e.Graphics.DrawString(this._infoSchool.CourseBatisseName, printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
                yPos += printFontTime10.Height;
                e.Graphics.DrawString(this._infoSchool.CourseStreetNumber + " " + this._infoSchool.CourseStreetName, printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
                yPos += printFontTime10.Height;
                e.Graphics.DrawString(this._infoSchool.CourseCity + ", QC, " + this._infoSchool.CoursePostalCode, printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            }
            #endregion

            #region Mention légal
            yPos += printFontBold24.Height;
            e.Graphics.DrawString("Mention légale", printFontBold14, Brushes.Black, leftMargin, yPos, new StringFormat());

            e.Graphics.DrawRectangle(new Pen(Color.Black), leftMargin, yPos + 20, 810, 19 * printFontTime8.Height + 5);
            //e.Graphics.DrawRectangle(new Pen(Color.Black), leftMargin, yPos + 20, 825, 11 * printFont.Height + 5);

            yPos += printFontBold14.Height + 10;
            string MentionLegal = @"Mention exigée par la Loi sur la Protection du Consommateur (Contrat de louage de services à exécution successive) Résiliation : Le consommateur peut, à tout moment 
et à sa discrétion, résilier ce contrat en envoyant la formule ci-annexée ou un autre avis écrit à cet effet au commerçant. Le contrat est résilié de plein droit 
à compter de l'envoie de la formule ou de l'avis. Frais : Si le consommateur résilie ce contrat avant que le commerçant n'ait commencé à exécuter son obligation 
principale, la résiliation s'effectue sans frais ni pénalité pour le consommateur. Sommes exigées: Si le consommateur résilie ce contrat après que le 
commerçant ait commencé à exécuter son obligation principale, les seules sommes que le commerçant peut exiger de lui sont : A) le prix des services qui lui ont 
été fournis, calculé au taux stipulé dans le contrat et B) à titre de pénalité, la moins élevée des sommes suivantes : 50$ ou 10% du prix des services qui 
ne lui ont pas été fournis. Restitution : Dans les dix (10) jours qui suivent la résiliation du contrat, le commerçant doit restituer au consommateur la somme
d'argent à ce dernier. Le consommateur aura avantage à consulter les articles 190 à 196 de la loi la protection du consommateur (L.R.Q., c. P-40.1) et, au besoin, 
à communiquer avec l'Offices de la Protection du Consommateur.

Ce contrat est d'une durée maximum de 549 jours à compter de la date d'émission. Si le solde n'est pas payé durant cette période, un ajustement de prix peut être 
effectué par l'école. L'élève devra informer l'école au moins 48 heures à l'avance (deux jours ouvrable) pour annuler ou reporter une ou des leçons pratiques, 
sinon une pénalité de 50$ de l'heure sera exigée. Des frais de 50$ seront exigés pour ré-ouvrir un dossier fermé ou annulé un contrat actif. J'autorise l'école 
à transmettre mes coordonnées à l'A.Q.T.R (Association Québecoise du Transport et des Routes) pour lui permettre d'effectuer des sondages de satisfaction au 
sujet de mon cours de conduite. NON ( )

INFORMATION: Un frais de 10,00$ s’ajoutera au contrat si le client ne se présente pas à son cours théorique.   ______ Initiales de l’élève";

            e.Graphics.DrawString(MentionLegal, printFontTime8, Brushes.Black, leftMargin + 5, yPos, new StringFormat());

            #endregion

            #region Formule de résiliation
            string resiliation = @"Clause de non-cession ou sous-traitance à un enseignant. En vertu de l'article 193
de la Loi sur la protection du consommateur, je résilie le présent contrat.

Date : __________________  Signature du résiliataire : ____________________";

            yPos += printFontTime8.Height * 19;
            //yPos += printFontBold14.Height;
            e.Graphics.DrawString("Formule de résiliation", printFontBold14, Brushes.Black, leftMargin, yPos, new StringFormat());

            yPos += printFontBold14.Height;
            e.Graphics.DrawString(resiliation, printFontTime10, Brushes.Black, leftMargin + 5, yPos + 5, new StringFormat());
            e.Graphics.DrawRectangle(new Pen(Color.Black), leftMargin, yPos, 810, 4 * printFont.Height + 10);

            yPos += printFontTime10.Height * 6;
            e.Graphics.DrawString("Fait et signé à " + this._infoSchool.City + " le " + DateTime.Now.ToLongDateString(), printFontTime10, Brushes.Black, leftMargin + 5, yPos, new StringFormat());
            yPos += printFontTime10.Height * 2;
            e.Graphics.DrawString(@"J’autorise l’école de conduite ci-haut mentionnée à transmettre mes coordonnées à l’organisme accréditeur et à la  Société de l’assurance
automobile du Québec pour fins de sondage ainsi que mon dossier en cas de cessation d’activités : ______ Initiales de l’élève", printFontTime10, Brushes.Black, leftMargin + 5, yPos, new StringFormat());

            yPos += (printFontTime10.Height * 3) -5;
            e.Graphics.DrawString("_________________________            _________________________                 _________________________", printFontTime10, Brushes.Black, leftMargin, yPos + 3, new StringFormat());
            yPos += printFontTime10.Height;
            e.Graphics.DrawString("Signature du commercant", printFontTime10, Brushes.Black, leftMargin, yPos + 3, new StringFormat());
            e.Graphics.DrawString("Signature d'un parent ou tuteur", printFontTime10, Brushes.Black, leftMargin + 215, yPos + 3, new StringFormat());
            e.Graphics.DrawString("Signature de l'élève", printFontTime10, Brushes.Black, leftMargin + 455, yPos + 3, new StringFormat());
            yPos += printFontTime10.Height;
            e.Graphics.DrawString("(Si moins de 18 ans)", printFontTime10, Brushes.Black, leftMargin + 215, yPos + 3, new StringFormat());
            #endregion
        }

        private void cmdAutoDateExpiration_Click(object sender, EventArgs e) {
            DateExpiration.Value = DateInscription.Value.AddMonths(18);
        }

        private void DateInscription_ValueChanged(object sender, EventArgs e) {
            DateExpiration.Value = DateInscription.Value.AddMonths(18);
        }

        private void cmdClearbox_Click(object sender, EventArgs e) {

            if (MessageBox.Show(this, "Voulez vous enlever votre client du group No. : " + txtNumeroGroupe.Text + " ?", "Gestion Auto École", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                txtNumeroGroupe.Value = 0;
        }

        private void txtEmail_Leave(object sender, EventArgs e) {

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e) {
            if (txtEmail.Text != "")
                if (!Email.IsValidEmailAddress(txtEmail.Text))
                    EmailError.SetError(txtEmail, "Cette addresse de courriel n'est pas valide.");
                else
                    EmailError.SetError(txtEmail, "");
            else
                EmailError.SetError(txtEmail, "");
        }

        private void cmdShowSeancesMoto2015_Click(object sender, EventArgs e)
        {
            ShowCours2015();
        }

        private void printDocMoto2015_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Ecriture du header (image)
            Stream strm = Type.GetType("Barette.Library.UserControls.Client.ClientControl").Assembly.GetManifestResourceStream("Barette.Library.res.Printlogo.png");
            Bitmap img = new Bitmap(strm);
            e.Graphics.DrawImage(img, 0, 0, 192, 104);
            float topMargin = 124;//img.Height + 20;
            float leftMargin = 0;//e.MarginBounds.Left;

            //Facrication des fonts
            Font printFont = new System.Drawing.Font("Courier New", 11);
            Font printFontTime = new Font("Times New Roman", 12, FontStyle.Regular);
            Font printFontBold = new Font("Times New Roman", 12, FontStyle.Bold);
            Font printFontBold16 = new Font("Times New Roman", 16, FontStyle.Bold);
            Font printFontBoldItalic16 = new Font("Times New Roman", 16, FontStyle.Bold & FontStyle.Italic);

            float yPos = 0f;
            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

            //Fabrication du client avant impression	
            this.MakeClient();

            //Rectangle de contour
            //e.Graphics.DrawRectangle(new Pen(Color.Black), leftMargin, topMargin, e.MarginBounds.Size.Width, 5 * printFont.Height + 10);

            //Donnée a imprimer
            yPos = topMargin + 5;
            e.Graphics.DrawString("Informations général", printFontBold16, Brushes.Black, leftMargin, yPos, new StringFormat());
            e.Graphics.DrawString("Imprimé le : " + DateTime.Now.ToShortDateString(), printFontTime, Brushes.Black, leftMargin + 450, yPos, new StringFormat());
            yPos += printFont.Height + 16;

            e.Graphics.DrawString("Nom : " + this._Client.Name + " " + this.Client.FirstName, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Nº contrat : " + this._Client.ContratNumber, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Date d'inscription : " + this._Client.DateInscription.ToShortDateString(), printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Adresse : " + this._Client.StreetNumber + " " + this.Client.StreetName + " App. " + this.Client.StreetApp, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Code Postale : " + this._Client.CodePostal, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Ville : " + this._Client.City, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Numéro de permis : " + this._Client.NumeroPermis, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

            if (this._Client.TypeVehicule == VehiculeType.Moto)
            {
                yPos += printFont.Height;
                e.Graphics.DrawString("Type de cours : Moto           Numéro 6R :" + this.Client.No6R, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            }
            else
            {
                yPos += printFont.Height;
                e.Graphics.DrawString("Type de cours : " + this.Client.TypeVehicule, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            }

            yPos += printFont.Height;
            e.Graphics.DrawString("Téléphone : " + this._Client.Phone, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Téléphone (Autre) : " + this._Client.PhoneBureau, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

            yPos += printFont.Height;
            e.Graphics.DrawString("État du client : " + this._Client.TypeClient, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

            if (this._Client.BVA == true)
            {
                yPos += printFont.Height;
                e.Graphics.DrawString("Date BVA : " + this._Client.BVADate.ToShortDateString() + " " + this._Client.BVADate.ToShortTimeString(), printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            }

            /////////////
            var SeancesList = BuildSeanceForPrintSeanceMoto2015();            
            /////////////

            //Ecriture des seances
            yPos += printFont.Height * 2;
            e.Graphics.DrawString("Séance de cours", printFontBold16, Brushes.Black, leftMargin, yPos, new StringFormat());
            yPos += 30;

            //Header des colone
            e.Graphics.DrawString("Date et heure", printFontBold, Brushes.Black, leftMargin + 80, yPos, new StringFormat());


            //Header de la colone montant
            e.Graphics.DrawString("Montant", printFontBold, Brushes.Black, 580 - e.Graphics.MeasureString("Montant", printFont).Width, yPos, new StringFormat());
            yPos += 16;
            
            foreach (Seance seance in SeancesList)
            {
                if (seance.Active)
                {
                    yPos += printFont.Height;
                    e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                    e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToShortDateString(), printFont, Brushes.Black, leftMargin + 60, yPos, new StringFormat());
                    
                    e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 220, yPos, new StringFormat());
                    e.Graphics.DrawString("à", printFont, Brushes.Black, leftMargin + 280, yPos, new StringFormat());
                    e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateModified), printFont, Brushes.Black, leftMargin + 300, yPos, new StringFormat());

                    e.Graphics.DrawString("_________________", printFont, Brushes.Black, leftMargin + 360, yPos, new StringFormat());
                    e.Graphics.DrawString("_________________", printFont, Brushes.Black, leftMargin + 370 + e.Graphics.MeasureString("_________________", printFont).Width, yPos, new StringFormat());

                    //e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 420, yPos, new StringFormat());
                    //e.Graphics.DrawString(seance.Montant, printFont, Brushes.Black, 580 - e.Graphics.MeasureString(seance.Montant, printFont).Width, yPos, new StringFormat());
                    //e.Graphics.DrawString(seance.Employer, printFont, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
                }                
            }
            
            yPos += (printFontBold.Height * 2);
            e.Graphics.DrawString("Équipements Nécessaires", printFontBold, Brushes.Black, leftMargin, yPos, new StringFormat());
            yPos += printFontTime.Height;
            e.Graphics.DrawString("1. Casque avec visière", printFontTime, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFontTime.Height;
            e.Graphics.DrawString("2. Bottes sécuritaires (couvrant la cheville)", printFontTime, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFontTime.Height;
            e.Graphics.DrawString("3. Gants de cuir (couvrant le poignet de préférence)", printFontTime, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFontTime.Height;
            e.Graphics.DrawString("4. Habit de pluie 2 parties séparées (haut et bas)", printFontTime, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            

            //Imprime les messages d'attention
            yPos += 50;
            Font myFont = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("ATTENTION", myFont, Brushes.Black, leftMargin, yPos, new StringFormat());

            SizeF strLength = e.Graphics.MeasureString("ATTENTION", myFont); //Largeur de la chaine
            if (this._Client.TypeVehicule == VehiculeType.Automatique)
            {
                e.Graphics.DrawString("Un pré-avis de 24 heures est requis tel que convenue sur le contrat de service;", printFontTime, Brushes.Black, leftMargin + strLength.Width, yPos, new StringFormat());
            }
            else
                e.Graphics.DrawString("Un pré-avis de 48 heures est requis tel que convenue sur le contrat de service;", printFontTime, Brushes.Black, leftMargin + strLength.Width, yPos, new StringFormat());

            yPos += myFont.Height;
            e.Graphics.DrawString("pour l'annulation de séances pratiques", printFontTime, Brushes.Black, leftMargin + strLength.Width, yPos, new StringFormat());
            yPos += (myFont.Height * 2);
            e.Graphics.DrawString("Les locations Auto/Moto sont non remboursables.", printFontTime, Brushes.Black, leftMargin + strLength.Width, yPos, new StringFormat());
        }

        private IEnumerable BuildSeanceForPrintSeanceMoto2015()
        {
            SeanceCollection seances = new SeanceCollection();
            foreach (Seance seance in this._Client.Seances)
                seances.Add(seance);
            foreach (Seance seance in this._Client.SeancesTheorique)
                seances.Add(seance);

            return from seance in seances.Cast<Seance>()
                   orderby seance.SceanceNumber
                   select seance;
        }
    }
}