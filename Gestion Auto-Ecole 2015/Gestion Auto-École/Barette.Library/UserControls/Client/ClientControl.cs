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
using Barette.Library.Employer;

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
        private GroupBox gbProgramMoto;
        private RadioButton rbProgramMoto2015;
        private RadioButton rbProgramMotoNormal;
        private System.Windows.Forms.CheckBox cbBVA;

        public ClientControl(SchoolInfo info) {
            // Cet appel est requis par le Concepteur de formulaires Windows.Forms.
            InitializeComponent();

            _infoSchool = info;
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientControl));
            groupBox2 = new System.Windows.Forms.GroupBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            cmdAlwayDispo = new System.Windows.Forms.Button();
            chkDisponibilityDimanche = new System.Windows.Forms.CheckBox();
            chkDisponibilitySamedi = new System.Windows.Forms.CheckBox();
            chkDisponibilitySoir = new System.Windows.Forms.CheckBox();
            chkDisponibilityPM = new System.Windows.Forms.CheckBox();
            chkDisponibilityAM = new System.Windows.Forms.CheckBox();
            txtNumeroPermis = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            gbCoursType = new System.Windows.Forms.GroupBox();
            label19 = new System.Windows.Forms.Label();
            txtN6R = new System.Windows.Forms.TextBox();
            rbVehiculMotocyclette = new System.Windows.Forms.RadioButton();
            rbVehiculMoto = new System.Windows.Forms.RadioButton();
            rbVehiculManuel = new System.Windows.Forms.RadioButton();
            rbVehiculAutomatique = new System.Windows.Forms.RadioButton();
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtEmail = new System.Windows.Forms.TextBox();
            label26 = new System.Windows.Forms.Label();
            DateNaissance = new System.Windows.Forms.DateTimePicker();
            label21 = new System.Windows.Forms.Label();
            txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            txtCodePostal = new System.Windows.Forms.MaskedTextBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            txtAdressApp = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtAdressStreet = new System.Windows.Forms.TextBox();
            txtFirstName = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            txtPhoneBureau = new System.Windows.Forms.MaskedTextBox();
            label10 = new System.Windows.Forms.Label();
            groupBox5 = new System.Windows.Forms.GroupBox();
            rbTypeClientFinish = new System.Windows.Forms.RadioButton();
            rbTypeClientActif = new System.Windows.Forms.RadioButton();
            DateInscription = new System.Windows.Forms.DateTimePicker();
            label13 = new System.Windows.Forms.Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            groupBox7 = new System.Windows.Forms.GroupBox();
            button1 = new System.Windows.Forms.Button();
            label15 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            groupBox8 = new System.Windows.Forms.GroupBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ImageListToolBar = new System.Windows.Forms.ImageList(components);
            toolTipText = new System.Windows.Forms.ToolTip(components);
            cbBVA = new System.Windows.Forms.CheckBox();
            label20 = new System.Windows.Forms.Label();
            cbNullContrat = new System.Windows.Forms.CheckBox();
            cmdShowSeanceT = new System.Windows.Forms.Button();
            cmdShowSeanceTheorique = new System.Windows.Forms.Button();
            cmdAutoDateExpiration = new System.Windows.Forms.Button();
            label24 = new System.Windows.Forms.Label();
            cmdClearbox = new System.Windows.Forms.Button();
            cmdShowSeancesMoto2015 = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            dtpBVA = new System.Windows.Forms.DateTimePicker();
            cbMoto = new System.Windows.Forms.CheckBox();
            cbAuto = new System.Windows.Forms.CheckBox();
            label16 = new System.Windows.Forms.Label();
            timerCheckClientValid = new System.Windows.Forms.Timer(components);
            dtpDatePermis = new System.Windows.Forms.DateTimePicker();
            groupBox6 = new System.Windows.Forms.GroupBox();
            cbPermisObtenue = new System.Windows.Forms.CheckBox();
            dtpDatePermisPlus8 = new System.Windows.Forms.DateTimePicker();
            label17 = new System.Windows.Forms.Label();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            label18 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            DateExpiration = new System.Windows.Forms.DateTimePicker();
            label23 = new System.Windows.Forms.Label();
            DateDebutCours = new System.Windows.Forms.DateTimePicker();
            printDocContract = new System.Drawing.Printing.PrintDocument();
            dtpAttestation2 = new System.Windows.Forms.DateTimePicker();
            dtpAttestation1 = new System.Windows.Forms.DateTimePicker();
            printDocTheorique = new System.Drawing.Printing.PrintDocument();
            label25 = new System.Windows.Forms.Label();
            EmailError = new System.Windows.Forms.ErrorProvider(components);
            printDocMoto2015 = new System.Drawing.Printing.PrintDocument();
            gbProgramMoto = new System.Windows.Forms.GroupBox();
            rbProgramMoto2015 = new System.Windows.Forms.RadioButton();
            rbProgramMotoNormal = new System.Windows.Forms.RadioButton();
            txtNumeroGroupe = new UtilityLibrary.WinControls.NumericTextBox();
            txtNumeroAttestation2 = new UtilityLibrary.WinControls.NumericTextBox();
            txtNumeroContrat = new UtilityLibrary.WinControls.NumericTextBox();
            txtNumeroAttestation = new UtilityLibrary.WinControls.NumericTextBox();
            dbRecuNumber = new UtilityLibrary.WinControls.NumericTextBox();
            txtAdressNumber = new UtilityLibrary.WinControls.NumericTextBox();
            ctbTauxHorairePratique = new Barette.Library.UserControls.CashTextBox();
            ctbTauxHoraireTheorique = new Barette.Library.UserControls.CashTextBox();
            ctbLocationMontant = new Barette.Library.UserControls.CashTextBox();
            CashBox_Solde = new Barette.Library.UserControls.CashTextBox();
            txtNotes = new Barette.Library.UserControls.TextEdit.TextEditor();
            cbCity = new Barette.Library.UserControls.ComboCityPicker();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox4)).BeginInit();
            gbCoursType.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            groupBox5.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            groupBox3.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(EmailError)).BeginInit();
            gbProgramMoto.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(cmdAlwayDispo);
            groupBox2.Controls.Add(chkDisponibilityDimanche);
            groupBox2.Controls.Add(chkDisponibilitySamedi);
            groupBox2.Controls.Add(chkDisponibilitySoir);
            groupBox2.Controls.Add(chkDisponibilityPM);
            groupBox2.Controls.Add(chkDisponibilityAM);
            groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            groupBox2.Location = new System.Drawing.Point(0, 355);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(220, 80);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Disponibilité";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = global::Barette.Library.Properties.Resources.stylish8;
            pictureBox4.Location = new System.Drawing.Point(7, 20);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(32, 32);
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // cmdAlwayDispo
            // 
            cmdAlwayDispo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAlwayDispo.Location = new System.Drawing.Point(132, 14);
            cmdAlwayDispo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            cmdAlwayDispo.Name = "cmdAlwayDispo";
            cmdAlwayDispo.Size = new System.Drawing.Size(75, 23);
            cmdAlwayDispo.TabIndex = 6;
            cmdAlwayDispo.Text = "Toujours";
            cmdAlwayDispo.Click += new System.EventHandler(cmdAlwayDispo_Click);
            // 
            // chkDisponibilityDimanche
            // 
            chkDisponibilityDimanche.AutoSize = true;
            chkDisponibilityDimanche.FlatStyle = System.Windows.Forms.FlatStyle.System;
            chkDisponibilityDimanche.Location = new System.Drawing.Point(132, 54);
            chkDisponibilityDimanche.Name = "chkDisponibilityDimanche";
            chkDisponibilityDimanche.Size = new System.Drawing.Size(80, 18);
            chkDisponibilityDimanche.TabIndex = 5;
            chkDisponibilityDimanche.Text = "Dimanche";
            // 
            // chkDisponibilitySamedi
            // 
            chkDisponibilitySamedi.AutoSize = true;
            chkDisponibilitySamedi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            chkDisponibilitySamedi.Location = new System.Drawing.Point(132, 38);
            chkDisponibilitySamedi.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            chkDisponibilitySamedi.Name = "chkDisponibilitySamedi";
            chkDisponibilitySamedi.Size = new System.Drawing.Size(67, 18);
            chkDisponibilitySamedi.TabIndex = 4;
            chkDisponibilitySamedi.Text = "Samedi";
            // 
            // chkDisponibilitySoir
            // 
            chkDisponibilitySoir.AutoSize = true;
            chkDisponibilitySoir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            chkDisponibilitySoir.Location = new System.Drawing.Point(44, 54);
            chkDisponibilitySoir.Name = "chkDisponibilitySoir";
            chkDisponibilitySoir.Size = new System.Drawing.Size(62, 18);
            chkDisponibilitySoir.TabIndex = 3;
            chkDisponibilitySoir.Text = "Soirée";
            // 
            // chkDisponibilityPM
            // 
            chkDisponibilityPM.AutoSize = true;
            chkDisponibilityPM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            chkDisponibilityPM.Location = new System.Drawing.Point(44, 38);
            chkDisponibilityPM.Name = "chkDisponibilityPM";
            chkDisponibilityPM.Size = new System.Drawing.Size(81, 18);
            chkDisponibilityPM.TabIndex = 2;
            chkDisponibilityPM.Text = "Après Midi";
            // 
            // chkDisponibilityAM
            // 
            chkDisponibilityAM.AutoSize = true;
            chkDisponibilityAM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            chkDisponibilityAM.Location = new System.Drawing.Point(44, 22);
            chkDisponibilityAM.Name = "chkDisponibilityAM";
            chkDisponibilityAM.Size = new System.Drawing.Size(58, 18);
            chkDisponibilityAM.TabIndex = 1;
            chkDisponibilityAM.Text = "Matin";
            // 
            // txtNumeroPermis
            // 
            txtNumeroPermis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            txtNumeroPermis.Location = new System.Drawing.Point(128, 31);
            txtNumeroPermis.MaxLength = 20;
            txtNumeroPermis.Name = "txtNumeroPermis";
            txtNumeroPermis.Size = new System.Drawing.Size(144, 20);
            txtNumeroPermis.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(48, 31);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(72, 13);
            label11.TabIndex = 13;
            label11.Text = "No. de permis";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbCoursType
            // 
            gbCoursType.Controls.Add(label19);
            gbCoursType.Controls.Add(txtN6R);
            gbCoursType.Controls.Add(rbVehiculMotocyclette);
            gbCoursType.Controls.Add(rbVehiculMoto);
            gbCoursType.Controls.Add(rbVehiculManuel);
            gbCoursType.Controls.Add(rbVehiculAutomatique);
            gbCoursType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            gbCoursType.Location = new System.Drawing.Point(0, 442);
            gbCoursType.Name = "gbCoursType";
            gbCoursType.Size = new System.Drawing.Size(183, 88);
            gbCoursType.TabIndex = 12;
            gbCoursType.TabStop = false;
            gbCoursType.Text = "Type de véhicule";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(8, 66);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(36, 13);
            label19.TabIndex = 23;
            label19.Text = "Nº6R:";
            // 
            // txtN6R
            // 
            txtN6R.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            txtN6R.Enabled = false;
            txtN6R.Location = new System.Drawing.Point(48, 64);
            txtN6R.Name = "txtN6R";
            txtN6R.Size = new System.Drawing.Size(122, 20);
            txtN6R.TabIndex = 5;
            // 
            // rbVehiculMotocyclette
            // 
            rbVehiculMotocyclette.AutoSize = true;
            rbVehiculMotocyclette.FlatStyle = System.Windows.Forms.FlatStyle.System;
            rbVehiculMotocyclette.Location = new System.Drawing.Point(95, 39);
            rbVehiculMotocyclette.Name = "rbVehiculMotocyclette";
            rbVehiculMotocyclette.Size = new System.Drawing.Size(89, 18);
            rbVehiculMotocyclette.TabIndex = 4;
            rbVehiculMotocyclette.Tag = "General";
            rbVehiculMotocyclette.Text = "Cyclomoteur";
            rbVehiculMotocyclette.CheckedChanged += new System.EventHandler(rbCamion_CheckedChanged);
            // 
            // rbVehiculMoto
            // 
            rbVehiculMoto.AutoSize = true;
            rbVehiculMoto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            rbVehiculMoto.Location = new System.Drawing.Point(8, 39);
            rbVehiculMoto.Name = "rbVehiculMoto";
            rbVehiculMoto.Size = new System.Drawing.Size(55, 18);
            rbVehiculMoto.TabIndex = 2;
            rbVehiculMoto.Tag = "Moto";
            rbVehiculMoto.Text = "Moto";
            rbVehiculMoto.CheckedChanged += new System.EventHandler(rbMoto_CheckedChanged);
            // 
            // rbVehiculManuel
            // 
            rbVehiculManuel.AutoSize = true;
            rbVehiculManuel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            rbVehiculManuel.Location = new System.Drawing.Point(95, 16);
            rbVehiculManuel.Name = "rbVehiculManuel";
            rbVehiculManuel.Size = new System.Drawing.Size(66, 18);
            rbVehiculManuel.TabIndex = 3;
            rbVehiculManuel.Tag = "General";
            rbVehiculManuel.Text = "Manuel";
            rbVehiculManuel.CheckedChanged += new System.EventHandler(rbManuel_CheckedChanged);
            // 
            // rbVehiculAutomatique
            // 
            rbVehiculAutomatique.AutoSize = true;
            rbVehiculAutomatique.Checked = true;
            rbVehiculAutomatique.FlatStyle = System.Windows.Forms.FlatStyle.System;
            rbVehiculAutomatique.Location = new System.Drawing.Point(8, 16);
            rbVehiculAutomatique.Name = "rbVehiculAutomatique";
            rbVehiculAutomatique.Size = new System.Drawing.Size(90, 18);
            rbVehiculAutomatique.TabIndex = 1;
            rbVehiculAutomatique.TabStop = true;
            rbVehiculAutomatique.Tag = "General";
            rbVehiculAutomatique.Text = "Automatique";
            rbVehiculAutomatique.CheckedChanged += new System.EventHandler(rbAutomatique_CheckedChanged);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbCity);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label26);
            groupBox1.Controls.Add(DateNaissance);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(txtCodePostal);
            groupBox1.Controls.Add(txtAdressNumber);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(txtAdressApp);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtAdressStreet);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtPhoneBureau);
            groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            groupBox1.Location = new System.Drawing.Point(0, 112);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(640, 158);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informations sur le client";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(456, 132);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(176, 20);
            txtEmail.TabIndex = 28;
            txtEmail.Leave += new System.EventHandler(txtEmail_Leave);
            txtEmail.Validating += new System.ComponentModel.CancelEventHandler(txtEmail_Validating);
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new System.Drawing.Point(352, 135);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(48, 13);
            label26.TabIndex = 27;
            label26.Text = "Courriel :";
            // 
            // DateNaissance
            // 
            DateNaissance.Location = new System.Drawing.Point(456, 106);
            DateNaissance.Name = "DateNaissance";
            DateNaissance.Size = new System.Drawing.Size(123, 20);
            DateNaissance.TabIndex = 10;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(352, 109);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(87, 13);
            label21.TabIndex = 26;
            label21.Text = "Date naissance :";
            label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new System.Drawing.Point(162, 107);
            txtPhoneNumber.Mask = "(999)000-0000";
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            txtPhoneNumber.TabIndex = 8;
            txtPhoneNumber.Enter += new System.EventHandler(txtPhoneNumber_Enter);
            // 
            // txtCodePostal
            // 
            txtCodePostal.Location = new System.Drawing.Point(456, 78);
            txtCodePostal.Mask = "L0L-0L0";
            txtCodePostal.Name = "txtCodePostal";
            txtCodePostal.Size = new System.Drawing.Size(56, 20);
            txtCodePostal.TabIndex = 7;
            txtCodePostal.Enter += new System.EventHandler(txtCodePostal_Enter);
            txtCodePostal.Leave += new System.EventHandler(txtCodePostal_Leave);
            // 
            // pictureBox2
            // 
            pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            pictureBox2.Location = new System.Drawing.Point(8, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(32, 32);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // txtAdressApp
            // 
            txtAdressApp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            txtAdressApp.Location = new System.Drawing.Point(584, 51);
            txtAdressApp.Name = "txtAdressApp";
            txtAdressApp.Size = new System.Drawing.Size(48, 20);
            txtAdressApp.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(352, 79);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(76, 13);
            label9.TabIndex = 22;
            label9.Text = "Code Postale :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(48, 109);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(64, 13);
            label8.TabIndex = 19;
            label8.Text = "Téléphone :";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(329, 27);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(49, 13);
            label7.TabIndex = 16;
            label7.Text = "Prénom :";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(48, 54);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(48, 13);
            label6.TabIndex = 15;
            label6.Text = "Adresse:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(122, 55);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(27, 13);
            label5.TabIndex = 14;
            label5.Text = "No :";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(215, 55);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(33, 13);
            label4.TabIndex = 13;
            label4.Text = "Rue :";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(550, 50);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(32, 20);
            label3.TabIndex = 12;
            label3.Text = "App.";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(48, 81);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(32, 13);
            label2.TabIndex = 11;
            label2.Text = "Ville :";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(48, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 13);
            label1.TabIndex = 10;
            label1.Text = "Nom :";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAdressStreet
            // 
            txtAdressStreet.Location = new System.Drawing.Point(254, 51);
            txtAdressStreet.Name = "txtAdressStreet";
            txtAdressStreet.Size = new System.Drawing.Size(290, 20);
            txtAdressStreet.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new System.Drawing.Point(384, 24);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(248, 20);
            txtFirstName.TabIndex = 2;
            txtFirstName.TextChanged += new System.EventHandler(txtFirstName_TextChanged);
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(120, 24);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(192, 20);
            txtName.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(48, 134);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(95, 13);
            label12.TabIndex = 21;
            label12.Text = "Téléphone (Autre):";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhoneBureau
            // 
            txtPhoneBureau.Location = new System.Drawing.Point(162, 132);
            txtPhoneBureau.Mask = "(999)000-0000";
            txtPhoneBureau.Name = "txtPhoneBureau";
            txtPhoneBureau.Size = new System.Drawing.Size(100, 20);
            txtPhoneBureau.TabIndex = 9;
            txtPhoneBureau.Enter += new System.EventHandler(txtPhoneBureau_Enter);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(5, 12);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(58, 13);
            label10.TabIndex = 27;
            label10.Text = "Nº contrat:";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(rbTypeClientFinish);
            groupBox5.Controls.Add(rbTypeClientActif);
            groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            groupBox5.Location = new System.Drawing.Point(190, 442);
            groupBox5.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(93, 88);
            groupBox5.TabIndex = 13;
            groupBox5.TabStop = false;
            groupBox5.Text = "États du client";
            // 
            // rbTypeClientFinish
            // 
            rbTypeClientFinish.AutoSize = true;
            rbTypeClientFinish.FlatStyle = System.Windows.Forms.FlatStyle.System;
            rbTypeClientFinish.Location = new System.Drawing.Point(6, 54);
            rbTypeClientFinish.Name = "rbTypeClientFinish";
            rbTypeClientFinish.Size = new System.Drawing.Size(95, 18);
            rbTypeClientFinish.TabIndex = 2;
            rbTypeClientFinish.Text = "Cours terminé";
            rbTypeClientFinish.CheckedChanged += new System.EventHandler(rbTypeClientFinish_CheckedChanged);
            // 
            // rbTypeClientActif
            // 
            rbTypeClientActif.Checked = true;
            rbTypeClientActif.FlatStyle = System.Windows.Forms.FlatStyle.System;
            rbTypeClientActif.Location = new System.Drawing.Point(6, 27);
            rbTypeClientActif.Name = "rbTypeClientActif";
            rbTypeClientActif.Size = new System.Drawing.Size(88, 16);
            rbTypeClientActif.TabIndex = 1;
            rbTypeClientActif.TabStop = true;
            rbTypeClientActif.Text = "Actif";
            // 
            // DateInscription
            // 
            DateInscription.Location = new System.Drawing.Point(487, 9);
            DateInscription.Name = "DateInscription";
            DateInscription.Size = new System.Drawing.Size(128, 20);
            DateInscription.TabIndex = 3;
            DateInscription.Value = new System.DateTime(2015, 4, 11, 0, 0, 0, 0);
            DateInscription.ValueChanged += new System.EventHandler(DateInscription_ValueChanged);
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(378, 11);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(61, 13);
            label13.TabIndex = 33;
            label13.Text = "Inscription :";
            label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // printDocument1
            // 
            printDocument1.DocumentName = "Fichier Client";
            printDocument1.OriginAtMargins = true;
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(dbRecuNumber);
            groupBox7.Controls.Add(button1);
            groupBox7.Controls.Add(label15);
            groupBox7.Controls.Add(CashBox_Solde);
            groupBox7.Controls.Add(label14);
            groupBox7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            groupBox7.Location = new System.Drawing.Point(227, 355);
            groupBox7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new System.Drawing.Size(301, 80);
            groupBox7.TabIndex = 9;
            groupBox7.TabStop = false;
            groupBox7.Text = "Information sur le solde";
            // 
            // button1
            // 
            button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            button1.Location = new System.Drawing.Point(224, 20);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(64, 48);
            button1.TabIndex = 3;
            toolTipText.SetToolTip(button1, "Paiement et reçu");
            button1.Click += new System.EventHandler(button1_Click);
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(9, 50);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(118, 13);
            label15.TabIndex = 7;
            label15.Text = "Dernier numéro de reçu";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(9, 28);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(34, 13);
            label14.TabIndex = 1;
            label14.Text = "Solde";
            // 
            // groupBox8
            // 
            groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            groupBox8.Controls.Add(txtNotes);
            groupBox8.Controls.Add(pictureBox1);
            groupBox8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            groupBox8.Location = new System.Drawing.Point(0, 538);
            groupBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new System.Drawing.Size(640, 177);
            groupBox8.TabIndex = 31;
            groupBox8.TabStop = false;
            groupBox8.Text = "Notes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(8, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(32, 32);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // ImageListToolBar
            // 
            ImageListToolBar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            ImageListToolBar.ImageSize = new System.Drawing.Size(16, 16);
            ImageListToolBar.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cbBVA
            // 
            cbBVA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cbBVA.Location = new System.Drawing.Point(8, 23);
            cbBVA.Name = "cbBVA";
            cbBVA.Size = new System.Drawing.Size(48, 24);
            cbBVA.TabIndex = 1;
            cbBVA.Text = "BVA";
            toolTipText.SetToolTip(cbBVA, "Date pour le Bureau des Véhicules Automobile.");
            cbBVA.CheckedChanged += new System.EventHandler(cbBVA_CheckedChanged);
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(5, 37);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(84, 13);
            label20.TabIndex = 39;
            label20.Text = "Nº Attestation 1:";
            label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            toolTipText.SetToolTip(label20, "Nº Attestation de la Ligue de Sécurité");
            // 
            // cbNullContrat
            // 
            cbNullContrat.AutoSize = true;
            cbNullContrat.Location = new System.Drawing.Point(187, 11);
            cbNullContrat.Name = "cbNullContrat";
            cbNullContrat.Size = new System.Drawing.Size(15, 14);
            cbNullContrat.TabIndex = 41;
            toolTipText.SetToolTip(cbNullContrat, "Cocher cette case permet de ne pas afficher ce contrat dans le rapport : ligue de" +
        " sécurité.");
            // 
            // cmdShowSeanceT
            // 
            cmdShowSeanceT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            cmdShowSeanceT.Image = ((System.Drawing.Image)(resources.GetObject("cmdShowSeanceT.Image")));
            cmdShowSeanceT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cmdShowSeanceT.Location = new System.Drawing.Point(534, 398);
            cmdShowSeanceT.Name = "cmdShowSeanceT";
            cmdShowSeanceT.Size = new System.Drawing.Size(104, 43);
            cmdShowSeanceT.TabIndex = 11;
            cmdShowSeanceT.TabStop = false;
            cmdShowSeanceT.Text = "Pratique";
            cmdShowSeanceT.TextAlign = System.Drawing.ContentAlignment.TopRight;
            toolTipText.SetToolTip(cmdShowSeanceT, "Afficher les séances");
            cmdShowSeanceT.Click += new System.EventHandler(cmdShowSeance_Click);
            // 
            // cmdShowSeanceTheorique
            // 
            cmdShowSeanceTheorique.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            cmdShowSeanceTheorique.Image = global::Barette.Library.Properties.Resources.book_icon;
            cmdShowSeanceTheorique.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cmdShowSeanceTheorique.Location = new System.Drawing.Point(534, 353);
            cmdShowSeanceTheorique.Name = "cmdShowSeanceTheorique";
            cmdShowSeanceTheorique.Size = new System.Drawing.Size(104, 43);
            cmdShowSeanceTheorique.TabIndex = 10;
            cmdShowSeanceTheorique.TabStop = false;
            cmdShowSeanceTheorique.Text = "Théorique";
            cmdShowSeanceTheorique.TextAlign = System.Drawing.ContentAlignment.TopRight;
            toolTipText.SetToolTip(cmdShowSeanceTheorique, "Afficher les séances");
            cmdShowSeanceTheorique.Click += new System.EventHandler(cmdShowSeanceTheorique_Click);
            // 
            // cmdAutoDateExpiration
            // 
            cmdAutoDateExpiration.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cmdAutoDateExpiration.Location = new System.Drawing.Point(615, 33);
            cmdAutoDateExpiration.Name = "cmdAutoDateExpiration";
            cmdAutoDateExpiration.Size = new System.Drawing.Size(20, 20);
            cmdAutoDateExpiration.TabIndex = 47;
            toolTipText.SetToolTip(cmdAutoDateExpiration, "Ajoute 365 jour à la date d\'inscription");
            cmdAutoDateExpiration.Click += new System.EventHandler(cmdAutoDateExpiration_Click);
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new System.Drawing.Point(5, 61);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(84, 13);
            label24.TabIndex = 51;
            label24.Text = "Nº Attestation 2:";
            label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            toolTipText.SetToolTip(label24, "Nº Attestation de la Ligue de Sécurité");
            // 
            // cmdClearbox
            // 
            cmdClearbox.Enabled = false;
            cmdClearbox.Location = new System.Drawing.Point(189, 81);
            cmdClearbox.Name = "cmdClearbox";
            cmdClearbox.Size = new System.Drawing.Size(22, 20);
            cmdClearbox.TabIndex = 56;
            cmdClearbox.Text = "X";
            toolTipText.SetToolTip(cmdClearbox, "Supprimer du group");
            cmdClearbox.UseVisualStyleBackColor = true;
            cmdClearbox.Click += new System.EventHandler(cmdClearbox_Click);
            // 
            // cmdShowSeancesMoto2015
            // 
            cmdShowSeancesMoto2015.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            cmdShowSeancesMoto2015.Image = global::Barette.Library.Properties.Resources.book_icon;
            cmdShowSeancesMoto2015.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cmdShowSeancesMoto2015.Location = new System.Drawing.Point(534, 353);
            cmdShowSeancesMoto2015.Name = "cmdShowSeancesMoto2015";
            cmdShowSeancesMoto2015.Size = new System.Drawing.Size(104, 88);
            cmdShowSeancesMoto2015.TabIndex = 57;
            cmdShowSeancesMoto2015.TabStop = false;
            cmdShowSeancesMoto2015.Text = "Séances ";
            cmdShowSeancesMoto2015.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            toolTipText.SetToolTip(cmdShowSeancesMoto2015, "Afficher les séances");
            cmdShowSeancesMoto2015.Click += new System.EventHandler(cmdShowSeancesMoto2015_Click);
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtpBVA);
            groupBox3.Controls.Add(cbBVA);
            groupBox3.Controls.Add(cbMoto);
            groupBox3.Controls.Add(cbAuto);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(ctbLocationMontant);
            groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            groupBox3.Location = new System.Drawing.Point(289, 444);
            groupBox3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(265, 88);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Location";
            // 
            // dtpBVA
            // 
            dtpBVA.CustomFormat = "ddd yyyy/MM/dd \'  Heure:\' HH:mm";
            dtpBVA.Enabled = false;
            dtpBVA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpBVA.Location = new System.Drawing.Point(56, 23);
            dtpBVA.Name = "dtpBVA";
            dtpBVA.Size = new System.Drawing.Size(199, 20);
            dtpBVA.TabIndex = 2;
            // 
            // cbMoto
            // 
            cbMoto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cbMoto.Location = new System.Drawing.Point(209, 52);
            cbMoto.Name = "cbMoto";
            cbMoto.Size = new System.Drawing.Size(48, 24);
            cbMoto.TabIndex = 5;
            cbMoto.Text = "Moto";
            // 
            // cbAuto
            // 
            cbAuto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cbAuto.Location = new System.Drawing.Point(130, 52);
            cbAuto.Name = "cbAuto";
            cbAuto.Size = new System.Drawing.Size(80, 24);
            cbAuto.TabIndex = 4;
            cbAuto.Text = "Automobile";
            cbAuto.CheckedChanged += new System.EventHandler(cbAuto_CheckedChanged);
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(8, 58);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(46, 13);
            label16.TabIndex = 18;
            label16.Text = "Montant";
            // 
            // timerCheckClientValid
            // 
            timerCheckClientValid.Enabled = true;
            timerCheckClientValid.Tick += new System.EventHandler(timerCheckClientValid_Tick);
            // 
            // dtpDatePermis
            // 
            dtpDatePermis.CustomFormat = "dd MMMM yyyy";
            dtpDatePermis.Enabled = false;
            dtpDatePermis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpDatePermis.Location = new System.Drawing.Point(480, 16);
            dtpDatePermis.Name = "dtpDatePermis";
            dtpDatePermis.Size = new System.Drawing.Size(152, 20);
            dtpDatePermis.TabIndex = 3;
            dtpDatePermis.ValueChanged += new System.EventHandler(dtpDatePermis_ValueChanged);
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(cbPermisObtenue);
            groupBox6.Controls.Add(dtpDatePermisPlus8);
            groupBox6.Controls.Add(label17);
            groupBox6.Controls.Add(pictureBox3);
            groupBox6.Controls.Add(txtNumeroPermis);
            groupBox6.Controls.Add(dtpDatePermis);
            groupBox6.Controls.Add(label11);
            groupBox6.Controls.Add(label18);
            groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            groupBox6.Location = new System.Drawing.Point(0, 274);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new System.Drawing.Size(640, 72);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "Permis de conduire";
            // 
            // cbPermisObtenue
            // 
            cbPermisObtenue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cbPermisObtenue.Location = new System.Drawing.Point(462, 27);
            cbPermisObtenue.Name = "cbPermisObtenue";
            cbPermisObtenue.Size = new System.Drawing.Size(16, 24);
            cbPermisObtenue.TabIndex = 2;
            cbPermisObtenue.CheckedChanged += new System.EventHandler(cbPermisObtenue_CheckedChanged);
            // 
            // dtpDatePermisPlus8
            // 
            dtpDatePermisPlus8.CustomFormat = "dd MMMM yyyy";
            dtpDatePermisPlus8.Enabled = false;
            dtpDatePermisPlus8.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpDatePermisPlus8.Location = new System.Drawing.Point(480, 40);
            dtpDatePermisPlus8.Name = "dtpDatePermisPlus8";
            dtpDatePermisPlus8.Size = new System.Drawing.Size(152, 20);
            dtpDatePermisPlus8.TabIndex = 4;
            // 
            // label17
            // 
            label17.Location = new System.Drawing.Point(288, 18);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(100, 16);
            label17.TabIndex = 29;
            label17.Text = "Date d\'obtention:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            pictureBox3.Location = new System.Drawing.Point(8, 25);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(32, 32);
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(288, 42);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(159, 13);
            label18.TabIndex = 30;
            label18.Text = "Date min. de l’examen pratique :";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(378, 37);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(98, 13);
            label22.TabIndex = 43;
            label22.Text = "Expiration (contrat):";
            label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateExpiration
            // 
            DateExpiration.Location = new System.Drawing.Point(488, 34);
            DateExpiration.Name = "DateExpiration";
            DateExpiration.Size = new System.Drawing.Size(128, 20);
            DateExpiration.TabIndex = 4;
            DateExpiration.Value = new System.DateTime(2015, 4, 11, 0, 0, 0, 0);
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(378, 62);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(91, 13);
            label23.TabIndex = 45;
            label23.Text = "Début des cours :";
            label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateDebutCours
            // 
            DateDebutCours.Location = new System.Drawing.Point(488, 60);
            DateDebutCours.Name = "DateDebutCours";
            DateDebutCours.Size = new System.Drawing.Size(128, 20);
            DateDebutCours.TabIndex = 5;
            DateDebutCours.Value = new System.DateTime(2015, 4, 11, 0, 0, 0, 0);
            // 
            // printDocContract
            // 
            printDocContract.DocumentName = "Contrat du client";
            printDocContract.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocContract_PrintPage);
            // 
            // dtpAttestation2
            // 
            dtpAttestation2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpAttestation2.Location = new System.Drawing.Point(187, 58);
            dtpAttestation2.Name = "dtpAttestation2";
            dtpAttestation2.Size = new System.Drawing.Size(95, 20);
            dtpAttestation2.TabIndex = 52;
            dtpAttestation2.Value = new System.DateTime(2015, 4, 11, 0, 0, 0, 0);
            // 
            // dtpAttestation1
            // 
            dtpAttestation1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpAttestation1.Location = new System.Drawing.Point(187, 34);
            dtpAttestation1.Name = "dtpAttestation1";
            dtpAttestation1.Size = new System.Drawing.Size(95, 20);
            dtpAttestation1.TabIndex = 53;
            dtpAttestation1.Value = new System.DateTime(2015, 4, 11, 0, 0, 0, 0);
            // 
            // printDocTheorique
            // 
            printDocTheorique.DocumentName = "Fichier du client";
            printDocTheorique.OriginAtMargins = true;
            printDocTheorique.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocTheorique_PrintPage);
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new System.Drawing.Point(5, 85);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(63, 13);
            label25.TabIndex = 55;
            label25.Text = "Nº Groupe :";
            // 
            // EmailError
            // 
            EmailError.ContainerControl = this;
            // 
            // printDocMoto2015
            // 
            printDocMoto2015.DocumentName = "Fichier du client";
            printDocMoto2015.OriginAtMargins = true;
            printDocMoto2015.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocMoto2015_PrintPage);
            // 
            // gbProgramMoto
            // 
            gbProgramMoto.Controls.Add(rbProgramMoto2015);
            gbProgramMoto.Controls.Add(rbProgramMotoNormal);
            gbProgramMoto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            gbProgramMoto.Location = new System.Drawing.Point(560, 445);
            gbProgramMoto.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            gbProgramMoto.Name = "gbProgramMoto";
            gbProgramMoto.Size = new System.Drawing.Size(80, 88);
            gbProgramMoto.TabIndex = 58;
            gbProgramMoto.TabStop = false;
            gbProgramMoto.Text = "Moto Program";
            // 
            // rbProgramMoto2015
            // 
            rbProgramMoto2015.AutoSize = true;
            rbProgramMoto2015.FlatStyle = System.Windows.Forms.FlatStyle.System;
            rbProgramMoto2015.Location = new System.Drawing.Point(6, 54);
            rbProgramMoto2015.Name = "rbProgramMoto2015";
            rbProgramMoto2015.Size = new System.Drawing.Size(75, 18);
            rbProgramMoto2015.TabIndex = 2;
            rbProgramMoto2015.Text = "Nouveau";
            rbProgramMoto2015.CheckedChanged += new System.EventHandler(rbProgramMoto2015_CheckedChanged);
            // 
            // rbProgramMotoNormal
            // 
            rbProgramMotoNormal.Checked = true;
            rbProgramMotoNormal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            rbProgramMotoNormal.Location = new System.Drawing.Point(6, 27);
            rbProgramMotoNormal.Name = "rbProgramMotoNormal";
            rbProgramMotoNormal.Size = new System.Drawing.Size(69, 21);
            rbProgramMotoNormal.TabIndex = 1;
            rbProgramMotoNormal.TabStop = true;
            rbProgramMotoNormal.Text = "Ancien";
            rbProgramMotoNormal.CheckedChanged += new System.EventHandler(rbProgramMotoNormal_CheckedChanged);
            // 
            // txtNumeroGroupe
            // 
            txtNumeroGroupe.Enabled = false;
            txtNumeroGroupe.Location = new System.Drawing.Point(103, 82);
            txtNumeroGroupe.Name = "txtNumeroGroupe";
            txtNumeroGroupe.SetRange = new System.Drawing.Size(0, 9999999);
            txtNumeroGroupe.ShortcutsEnabled = false;
            txtNumeroGroupe.Size = new System.Drawing.Size(80, 20);
            txtNumeroGroupe.TabIndex = 54;
            txtNumeroGroupe.Text = "0";
            txtNumeroGroupe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtNumeroGroupe.Value = 0;
            // 
            // txtNumeroAttestation2
            // 
            txtNumeroAttestation2.Location = new System.Drawing.Point(103, 58);
            txtNumeroAttestation2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            txtNumeroAttestation2.Name = "txtNumeroAttestation2";
            txtNumeroAttestation2.SetRange = new System.Drawing.Size(0, 9999999);
            txtNumeroAttestation2.ShortcutsEnabled = false;
            txtNumeroAttestation2.Size = new System.Drawing.Size(80, 20);
            txtNumeroAttestation2.TabIndex = 50;
            txtNumeroAttestation2.Text = "0";
            txtNumeroAttestation2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtNumeroAttestation2.Value = 0;
            // 
            // txtNumeroContrat
            // 
            txtNumeroContrat.Location = new System.Drawing.Point(103, 9);
            txtNumeroContrat.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            txtNumeroContrat.Name = "txtNumeroContrat";
            txtNumeroContrat.SetRange = new System.Drawing.Size(0, 9999999);
            txtNumeroContrat.ShortcutsEnabled = false;
            txtNumeroContrat.Size = new System.Drawing.Size(80, 20);
            txtNumeroContrat.TabIndex = 1;
            txtNumeroContrat.Text = "0";
            txtNumeroContrat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtNumeroContrat.Value = 0;
            // 
            // txtNumeroAttestation
            // 
            txtNumeroAttestation.Location = new System.Drawing.Point(103, 34);
            txtNumeroAttestation.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            txtNumeroAttestation.Name = "txtNumeroAttestation";
            txtNumeroAttestation.SetRange = new System.Drawing.Size(0, 9999999);
            txtNumeroAttestation.ShortcutsEnabled = false;
            txtNumeroAttestation.Size = new System.Drawing.Size(80, 20);
            txtNumeroAttestation.TabIndex = 2;
            txtNumeroAttestation.Text = "0";
            txtNumeroAttestation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtNumeroAttestation.Value = 0;
            // 
            // dbRecuNumber
            // 
            dbRecuNumber.Location = new System.Drawing.Point(154, 47);
            dbRecuNumber.Name = "dbRecuNumber";
            dbRecuNumber.SetRange = new System.Drawing.Size(0, 9999999);
            dbRecuNumber.ShortcutsEnabled = false;
            dbRecuNumber.Size = new System.Drawing.Size(64, 20);
            dbRecuNumber.TabIndex = 2;
            dbRecuNumber.Text = "0";
            dbRecuNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            dbRecuNumber.Value = 0;
            // 
            // txtAdressNumber
            // 
            txtAdressNumber.Location = new System.Drawing.Point(155, 51);
            txtAdressNumber.Name = "txtAdressNumber";
            txtAdressNumber.SetRange = new System.Drawing.Size(0, 9999999);
            txtAdressNumber.ShortcutsEnabled = false;
            txtAdressNumber.Size = new System.Drawing.Size(54, 20);
            txtAdressNumber.TabIndex = 3;
            txtAdressNumber.Text = "0";
            txtAdressNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtAdressNumber.Value = 0;
            // 
            // ctbTauxHorairePratique
            // 
            ctbTauxHorairePratique.BackColor = System.Drawing.SystemColors.Window;
            ctbTauxHorairePratique.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            ctbTauxHorairePratique.Location = new System.Drawing.Point(584, 415);
            ctbTauxHorairePratique.Name = "ctbTauxHorairePratique";
            ctbTauxHorairePratique.Size = new System.Drawing.Size(48, 18);
            ctbTauxHorairePratique.TabIndex = 49;
            ctbTauxHorairePratique.Text = "0 $";
            ctbTauxHorairePratique.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            toolTipText.SetToolTip(ctbTauxHorairePratique, "Taux horaire pour les cours pratique");
            // 
            // ctbTauxHoraireTheorique
            // 
            ctbTauxHoraireTheorique.BackColor = System.Drawing.SystemColors.Window;
            ctbTauxHoraireTheorique.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ctbTauxHoraireTheorique.Location = new System.Drawing.Point(584, 371);
            ctbTauxHoraireTheorique.Name = "ctbTauxHoraireTheorique";
            ctbTauxHoraireTheorique.Size = new System.Drawing.Size(48, 18);
            ctbTauxHoraireTheorique.TabIndex = 48;
            ctbTauxHoraireTheorique.Text = "0 $";
            ctbTauxHoraireTheorique.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            toolTipText.SetToolTip(ctbTauxHoraireTheorique, "Taux horaire pour les cours théorique");
            // 
            // ctbLocationMontant
            // 
            ctbLocationMontant.BackColor = System.Drawing.SystemColors.Window;
            ctbLocationMontant.Location = new System.Drawing.Point(56, 56);
            ctbLocationMontant.Name = "ctbLocationMontant";
            ctbLocationMontant.Size = new System.Drawing.Size(54, 20);
            ctbLocationMontant.TabIndex = 3;
            ctbLocationMontant.Text = "0 $";
            ctbLocationMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            ctbLocationMontant.Leave += new System.EventHandler(ctbLocationMontant_Leave);
            // 
            // CashBox_Solde
            // 
            CashBox_Solde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            CashBox_Solde.Location = new System.Drawing.Point(154, 23);
            CashBox_Solde.Name = "CashBox_Solde";
            CashBox_Solde.ReadOnly = true;
            CashBox_Solde.Size = new System.Drawing.Size(64, 20);
            CashBox_Solde.TabIndex = 1;
            CashBox_Solde.Text = "0 $";
            CashBox_Solde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNotes
            // 
            txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            txtNotes.Location = new System.Drawing.Point(46, 16);
            txtNotes.Name = "txtNotes";
            txtNotes.PlainText = "";
            txtNotes.RTFCode = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3084{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
    "ans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            txtNotes.RTFTextChanged = true;
            txtNotes.Size = new System.Drawing.Size(591, 155);
            txtNotes.TabIndex = 15;
            // 
            // cbCity
            // 
            cbCity.AutoCompleteCustomSource.AddRange(new string[] {
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
            cbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            cbCity.Location = new System.Drawing.Point(120, 78);
            cbCity.Name = "cbCity";
            cbCity.Size = new System.Drawing.Size(213, 20);
            cbCity.TabIndex = 29;
            // 
            // ClientControl
            // 
            BackColor = System.Drawing.SystemColors.Control;
            Controls.Add(gbProgramMoto);
            Controls.Add(ctbTauxHorairePratique);
            Controls.Add(ctbTauxHoraireTheorique);
            Controls.Add(cmdShowSeancesMoto2015);
            Controls.Add(cmdClearbox);
            Controls.Add(label25);
            Controls.Add(txtNumeroGroupe);
            Controls.Add(dtpAttestation1);
            Controls.Add(dtpAttestation2);
            Controls.Add(txtNumeroAttestation2);
            Controls.Add(label24);
            Controls.Add(txtNumeroContrat);
            Controls.Add(cmdAutoDateExpiration);
            Controls.Add(label23);
            Controls.Add(DateDebutCours);
            Controls.Add(label22);
            Controls.Add(DateExpiration);
            Controls.Add(cbNullContrat);
            Controls.Add(txtNumeroAttestation);
            Controls.Add(label20);
            Controls.Add(groupBox6);
            Controls.Add(groupBox3);
            Controls.Add(groupBox7);
            Controls.Add(groupBox8);
            Controls.Add(label13);
            Controls.Add(DateInscription);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(gbCoursType);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Controls.Add(cmdShowSeanceT);
            Controls.Add(cmdShowSeanceTheorique);
            DoubleBuffered = true;
            Name = "ClientControl";
            Size = new System.Drawing.Size(640, 718);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox4)).EndInit();
            gbCoursType.ResumeLayout(false);
            gbCoursType.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(EmailError)).EndInit();
            gbProgramMoto.ResumeLayout(false);
            gbProgramMoto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion

        private void cmdShowSeance_Click(object sender, System.EventArgs e) {
            ShowCours();
        }

        #region Type de Seance
        private void rbManuel_CheckedChanged(object sender, System.EventArgs e) {
            _SceanceType = SeanceType.Automobile;

            UpdateProgramMotoControl();
        }

        private void rbCamion_CheckedChanged(object sender, System.EventArgs e) {
            _SceanceType = SeanceType.Cyclomoteur;

            UpdateProgramMotoControl();
        }

        private void rbAutomatique_CheckedChanged(object sender, System.EventArgs e) {
            _SceanceType = SeanceType.Automobile;
            
            UpdateProgramMotoControl();
        }

        private void rbMoto_CheckedChanged(object sender, System.EventArgs e) {
            _SceanceType = SeanceType.Moto;
            txtN6R.Enabled = rbVehiculMoto.Checked;

            UpdateProgramMotoControl();
        }


        #endregion

        #region Property
        public Customer Client {
            get {
                MakeClient();
                return _Client;
            }
            set {
                MakeControl(value);
                _Client = value;
            }
        }

        /// <summary>
        /// Liste d'employe du logiciel
        /// </summary>
        public EmployeCollection ListeEmploye {
            get {
                return _EmployeList;
            }
            set {
                _EmployeList = value;
            }
        }

        /// <summary>
        /// Information de l'ecole de conduite
        /// </summary>
        public SchoolInfo School {
            get {
                return _infoSchool;
            }
            set {
                _infoSchool = value;
            }
        }

        /// <summary>
        /// Si true, Mise a jour Automatiquement
        /// </summary>
        public bool AutoUpdate {
            get {
                return _AutoUpdate;
            }
            set {
                _AutoUpdate = value;
            }
        }

        /// <summary>
        /// Retourne le nom du client (Prenom + Nom)
        /// </summary>
        public string NomComplet {
            get {
                return txtFirstName.Text + " " + txtName.Text;
            }
        }

        /// <summary>
        /// Retourne le nom du client (Prenom + Nom)
        /// </summary>
        public string NomCompletReverse {
            get {
                return txtName.Text + " " + txtFirstName.Text;
            }
        }


        /// <summary>
        /// Retourne le nom du client (Nom + Prenom)
        /// </summary>
        public string NomPrenom {
            get {
                return txtName.Text + " " + txtFirstName.Text;
            }
        }

        /// <summary>
        /// Retourne le numéro de contrat
        /// </summary>
        public string ContratNumber {
            get {
                return txtNumeroContrat.Text;
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

            switch (_SceanceType) {
                case SeanceType.Automobile:
                    return new FormSeanceGeneral(_Client, this, _EmployeList).ShowDialog();
                case SeanceType.Moto:                    
                    if (_Client.ProgramMoto != Library.Client.ProgramMoto.Program2015)
                        return new FormSeanceMoto(_Client, this, _EmployeList).ShowDialog();
                    else
                        return ShowCours2015();
                case SeanceType.Cyclomoteur:
                    return new FormSeanceMotocyclette(_Client, this, _EmployeList).ShowDialog();
            }

            return DialogResult.None;
        }

        /// <summary>
        /// Affiche la liste de cours.
        /// </summary>
        public DialogResult ShowCoursTheorique() {
            MakeClient();

            switch (_SceanceType) {
                case SeanceType.Automobile:
                    return new FormSeanceTheorique(_Client, this, _EmployeList).ShowDialog();
                case SeanceType.Moto:
                    if (_Client.ProgramMoto != Library.Client.ProgramMoto.Program2015)
                        return new FormSeanceTheoriqueMoto(_Client, this, _EmployeList).ShowDialog();
                    else
                        return ShowCours2015();
                case SeanceType.Cyclomoteur:
                    return new FormSeanceTheoriqueMotocyclette(_Client, this, _EmployeList).ShowDialog();
            }

            return DialogResult.None;
        }


        public DialogResult ShowCours2015()
        {
            MakeClient();

            return new FormSeanceMoto2015(_Client, this, _EmployeList).ShowDialog();

            //return DialogResult.None;
        }

        private void UpdateProgramMotoControl()
        {
            //MakeClient();

            if (TypeVehicule == VehiculeType.Moto)
            {
                gbProgramMoto.Enabled = true;

                if (DateInscription.Value >= new DateTime(2016, 06, 01))
                {
                    cmdShowSeancesMoto2015.Visible = true;
                    gbProgramMoto.Enabled = false;
                    rbProgramMoto2015.Checked = true;
                }
                else
                {
                    switch (ProgramMoto)
                    {
                        case ProgramMoto.Nothing:
                        case ProgramMoto.Program2015:
                            rbProgramMoto2015.Checked = true;
                            cmdShowSeancesMoto2015.Visible = true;
                            break;
                        case ProgramMoto.ProgramNormal:
                            rbProgramMotoNormal.Checked = true;
                            cmdShowSeancesMoto2015.Visible = false;
                            break;
                    }
                }
            }
            else
            {
                gbProgramMoto.Enabled = false;
                rbProgramMotoNormal.Checked = false;
                rbProgramMoto2015.Checked = false;
                cmdShowSeancesMoto2015.Visible = false;
            }
        }

        /// <summary>
        /// Fabrique un client a partir du control
        /// </summary>
        private void MakeClient() {
            //Backup seance list
            SeanceCollection seances = new SeanceCollection();
            SeanceCollection seancesTheorique = new SeanceCollection();
            PaimentCollection paiment = new PaimentCollection();

            if (_Client != null) {
                seances = _Client.Seances;
                seancesTheorique = _Client.SeancesTheorique;
                paiment = _Client.Paiment;
            }

            //Creation d'un nouveau client
            _Client = new Customer();

            //Replace les seances
            _Client.Seances = seances;

            //Replace les paiments
            _Client.Paiment = paiment;

            //Replace les seance de cours theorique
            _Client.SeancesTheorique = seancesTheorique;

            //Information
            _Client.City = cbCity.Text;
            _Client.ContratNumber = txtNumeroContrat.Text;
            _Client.ClientNull = cbNullContrat.Checked;
            _Client.AttestationNumber1 = txtNumeroAttestation.Text;
            _Client.AttestationNumber2 = txtNumeroAttestation2.Text;
            _Client.DateInscription = DateInscription.Value;
            _Client.FirstName = txtFirstName.Text;
            _Client.Name = txtName.Text;
            _Client.No6R = txtN6R.Text;
            _Client.Phone = txtPhoneNumber.Text;
            _Client.PhoneBureau = txtPhoneBureau.Text;
            _Client.StreetApp = txtAdressApp.Text;
            _Client.StreetName = txtAdressStreet.Text;
            _Client.StreetNumber = txtAdressNumber.Text;
            _Client.CodePostal = txtCodePostal.Text;
            _Client.Notes = txtNotes.RTFCode;
            _Client.DateNaissance = DateNaissance.Value;
            _Client.DateExpiration = DateExpiration.Value;
            _Client.DateDebutCours = DateDebutCours.Value;
            _Client.DateAttestation1 = dtpAttestation1.Value;
            _Client.DateAttestation2 = dtpAttestation2.Value;
            _Client.NumeroGroupe = Convert.ToInt32(txtNumeroGroupe.Text);
            _Client.Email = txtEmail.Text;

            //Taux horaire
            _Client.TauxHorairePratique = ctbTauxHorairePratique.Text;
            _Client.TauxHoraireTheorique = ctbTauxHoraireTheorique.Text;

            //Permis de conduire
            _Client.NumeroPermis = txtNumeroPermis.Text;
            _Client.DateTemporaire = dtpDatePermis.Value;
            _Client.HaveTemporaire = cbPermisObtenue.Checked;

            //Location de vehicule
            _Client.LocationAutomobile = cbAuto.Checked;
            _Client.LocationMoto = cbMoto.Checked;
            _Client.MontantLocation = ctbLocationMontant.Text;
            _Client.BVA = cbBVA.Checked;
            _Client.BVADate = dtpBVA.Value;

            //Information sur le solde du client
            _Client.Solde = CashBox_Solde.Text;
            _Client.LastRecuNumber = dbRecuNumber.Text;
            _Client.MontantCours = _MontantCours;

            //Disponibiliter
            _Client.DisponibilityAM = chkDisponibilityAM.Checked;
            _Client.DisponibilityPM = chkDisponibilityPM.Checked;
            _Client.DisponibilitySoirer = chkDisponibilitySoir.Checked;
            _Client.DisponibilitySamedi = chkDisponibilitySamedi.Checked;
            _Client.DisponibilityDimanche = chkDisponibilityDimanche.Checked;

            //Type de client
            if (rbTypeClientActif.Checked)
                _Client.TypeClient = ProfileType.Actif;
            else if (rbTypeClientFinish.Checked)
                _Client.TypeClient = ProfileType.CoursTerminer;

            //Type de vehicule
            if (rbVehiculAutomatique.Checked)
                _Client.TypeVehicule = VehiculeType.Automatique;
            else if (rbVehiculMotocyclette.Checked)
                _Client.TypeVehicule = VehiculeType.Cyclomoteur;
            else if (rbVehiculManuel.Checked)
                _Client.TypeVehicule = VehiculeType.Manuel;
            else if (rbVehiculMoto.Checked)
                _Client.TypeVehicule = VehiculeType.Moto;
            
            //ProgramMoto
            if (rbProgramMotoNormal.Checked)
                _Client.ProgramMoto = ProgramMoto.ProgramNormal;
            else if (rbProgramMoto2015.Checked)
                _Client.ProgramMoto = ProgramMoto.Program2015;
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
            _MontantCours = "";

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

            rbProgramMoto2015.Checked = false;
            rbProgramMotoNormal.Checked = false;
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
                _MontantCours = client.MontantCours;

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

                //ProgramMoto
                if (client.TypeVehicule == VehiculeType.Moto)
                {
                    gbProgramMoto.Enabled = true;

                    if (client.DateInscription >= new DateTime(2015, 06, 01))
                        cmdShowSeancesMoto2015.Visible = true;
                    else
                    {
                        switch (client.ProgramMoto)
                        {
                            case ProgramMoto.Program2015:
                                rbProgramMoto2015.Checked = true;
                                cmdShowSeancesMoto2015.Visible = true;
                                break;
                            case ProgramMoto.ProgramNormal:
                                rbProgramMotoNormal.Checked = true;
                                cmdShowSeancesMoto2015.Visible = false;
                                break;
                        }
                    }                    
                }
                else
                {
                    gbProgramMoto.Enabled = false;
                    rbProgramMotoNormal.Checked = false;
                    rbProgramMoto2015.Checked = false;
                    cmdShowSeancesMoto2015.Visible = false;
                }
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
            _AutoUpdate = false;

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

            _AutoUpdate = true;
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
                    FormPaiment frmPaiment = new FormPaiment(this, _Client, _infoSchool);
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
            MakeClient();

            //Rectangle de contour
            //e.Graphics.DrawRectangle(new Pen(Color.Black), leftMargin, topMargin, e.MarginBounds.Size.Width, 5 * printFont.Height + 10);

            //Donnée a imprimer
            yPos = topMargin + 5;
            e.Graphics.DrawString("Informations général", printFontBold16, Brushes.Black, leftMargin, yPos, new StringFormat());
            e.Graphics.DrawString("Imprimé le : " + DateTime.Now.ToShortDateString(), printFontTime, Brushes.Black, leftMargin + 450, yPos, new StringFormat());
            yPos += printFont.Height + 16;

            e.Graphics.DrawString("Nom : " + _Client.Name + " " + Client.FirstName, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Nº contrat : " + _Client.ContratNumber, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Date d'inscription : " + _Client.DateInscription.ToShortDateString(), printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Adresse : " + _Client.StreetNumber + " " + Client.StreetName + " App. " + Client.StreetApp, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Code Postale : " + _Client.CodePostal, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Ville : " + _Client.City, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Numéro de permis : " + _Client.NumeroPermis, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

            if (_Client.TypeVehicule == VehiculeType.Moto) {
                yPos += printFont.Height;
                e.Graphics.DrawString("Type de cours : Moto           Numéro 6R :" + Client.No6R, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            }
            else {
                yPos += printFont.Height;
                e.Graphics.DrawString("Type de cours : " + Client.TypeVehicule, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            }

            yPos += printFont.Height;
            e.Graphics.DrawString("Téléphone : " + _Client.Phone, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Téléphone (Autre) : " + _Client.PhoneBureau, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

            yPos += printFont.Height;
            e.Graphics.DrawString("État du client : " + _Client.TypeClient, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

            if (_Client.BVA == true) {
                yPos += printFont.Height;
                e.Graphics.DrawString("Date BVA : " + _Client.BVADate.ToShortDateString() + " " + _Client.BVADate.ToShortTimeString(), printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            }

            //Ecriture des seances
            yPos += printFont.Height * 2;
            e.Graphics.DrawString("Séance de cours", printFontBold16, Brushes.Black, leftMargin, yPos, new StringFormat());
            yPos += 30;

            //Header des colone
            if (_Client.TypeVehicule != VehiculeType.Moto)
            {
                e.Graphics.DrawString("Date et heure", printFontBold, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
                e.Graphics.DrawString("Endroit", printFontBold, Brushes.Black, leftMargin + 420, yPos, new StringFormat());
                e.Graphics.DrawString("Moniteur", printFontBold, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
            }
            else
            {
                e.Graphics.DrawString("Date et heure (début et fin)", printFontBold, Brushes.Black, leftMargin + 40, yPos, new StringFormat());
                e.Graphics.DrawString("Endroit", printFontBold, Brushes.Black, leftMargin + 670, yPos, new StringFormat());

                var testString1 = "Signature (élève et professeur)";
                e.Graphics.DrawString(testString1, printFontBold, Brushes.Black, 670 - e.Graphics.MeasureString(testString1, printFont).Width, yPos, new StringFormat());
            }

            Seance seance = null;
            if (_Client.TypeVehicule != VehiculeType.Moto) {

                //Header de la colone montant
                e.Graphics.DrawString("Montant", printFontBold, Brushes.Black, 580 - e.Graphics.MeasureString("Montant", printFont).Width, yPos, new StringFormat());
                yPos += 16;

                for (int i = 0; i < Client.Seances.Count; i++) {
                    seance = (Seance)_Client.Seances[i];

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

                //e.Graphics.DrawString("Signature", printFontBold, Brushes.Black, leftMargin + 490, yPos, new StringFormat());

                for (int i = 0; i < Client.Seances.Count; i++) {
                    seance = (Seance)_Client.Seances[i];

                    //fabrique les donnees pour le type moto
                    if (i == 0) {
                        if (_PrintHorsRoute) {
                            yPos += printFont.Height * 2;
                            e.Graphics.DrawString("Hors Route", printFontBoldItalic16, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                            yPos += 16;

                            if (seance.Active) {
                                yPos += printFont.Height;
                                //e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 40, yPos, new StringFormat());
                                //e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToLongDateString(), printFont, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
                                //e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 340, yPos, new StringFormat());
                                //e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 420, yPos, new StringFormat());
                                //e.Graphics.DrawString(seance.Employer, printFont, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
                                e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                                e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToShortDateString(), printFont, Brushes.Black, leftMargin + 60, yPos, new StringFormat());

                                e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 220, yPos, new StringFormat());
                                e.Graphics.DrawString("à", printFont, Brushes.Black, leftMargin + 280, yPos, new StringFormat());
                                e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateModified), printFont, Brushes.Black, leftMargin + 300, yPos, new StringFormat());

                                e.Graphics.DrawString("_______________", printFont, Brushes.Black, leftMargin + 360, yPos + 1, new StringFormat());
                                e.Graphics.DrawString("_______________", printFont, Brushes.Black, leftMargin + 350 + e.Graphics.MeasureString("_________________", printFont).Width, yPos + 1, new StringFormat());
                                e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 670, yPos, new StringFormat());
                            }

                        }
                    }
                    else if (i < 4) {

                        if (seance.Active && _PrintHorsRoute) {
                            yPos += printFont.Height;
                            //e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 40, yPos, new StringFormat());
                            //e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToLongDateString(), printFont, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
                            //e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 340, yPos, new StringFormat());
                            //e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 420, yPos, new StringFormat());
                            //e.Graphics.DrawString(seance.Employer, printFont, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
                            e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                            e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToShortDateString(), printFont, Brushes.Black, leftMargin + 60, yPos, new StringFormat());

                            e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 220, yPos, new StringFormat());
                            e.Graphics.DrawString("à", printFont, Brushes.Black, leftMargin + 280, yPos, new StringFormat());
                            e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateModified), printFont, Brushes.Black, leftMargin + 300, yPos, new StringFormat());

                            e.Graphics.DrawString("_______________", printFont, Brushes.Black, leftMargin + 360, yPos + 1, new StringFormat());
                            e.Graphics.DrawString("_______________", printFont, Brushes.Black, leftMargin + 350 + e.Graphics.MeasureString("_________________", printFont).Width, yPos + 1, new StringFormat());
                            e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 670, yPos, new StringFormat());
                        }
                    }
                    else if (i == 4) {
                        if (_PrintRoute) {
                            yPos += printFont.Height * 2;
                            e.Graphics.DrawString("Route", printFontBoldItalic16, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                            yPos += 16;

                            if (seance.Active) {
                                yPos += printFont.Height;
                                //e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 40, yPos, new StringFormat());
                                //e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToLongDateString(), printFont, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
                                //e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 340, yPos, new StringFormat());
                                //e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 420, yPos, new StringFormat());
                                //e.Graphics.DrawString(seance.Employer, printFont, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
                                e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                                e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToShortDateString(), printFont, Brushes.Black, leftMargin + 60, yPos, new StringFormat());

                                e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 220, yPos, new StringFormat());
                                e.Graphics.DrawString("à", printFont, Brushes.Black, leftMargin + 280, yPos, new StringFormat());
                                e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateModified), printFont, Brushes.Black, leftMargin + 300, yPos, new StringFormat());

                                e.Graphics.DrawString("_______________", printFont, Brushes.Black, leftMargin + 360, yPos + 1, new StringFormat());
                                e.Graphics.DrawString("_______________", printFont, Brushes.Black, leftMargin + 350 + e.Graphics.MeasureString("_________________", printFont).Width, yPos + 1, new StringFormat());
                                e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 670, yPos, new StringFormat());
                            }
                        }
                    }
                    else {
                        if (seance.Active && _PrintRoute) {
                            yPos += printFont.Height;
                            //e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 40, yPos, new StringFormat());
                            //e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToLongDateString(), printFont, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
                            //e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 340, yPos, new StringFormat());
                            //e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 420, yPos, new StringFormat());
                            //e.Graphics.DrawString(seance.Employer, printFont, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
                            e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                            e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToShortDateString(), printFont, Brushes.Black, leftMargin + 60, yPos, new StringFormat());

                            e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 220, yPos, new StringFormat());
                            e.Graphics.DrawString("à", printFont, Brushes.Black, leftMargin + 280, yPos, new StringFormat());
                            e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateModified), printFont, Brushes.Black, leftMargin + 300, yPos, new StringFormat());

                            e.Graphics.DrawString("_______________", printFont, Brushes.Black, leftMargin + 360, yPos + 1, new StringFormat());
                            e.Graphics.DrawString("_______________", printFont, Brushes.Black, leftMargin + 350 + e.Graphics.MeasureString("_________________", printFont).Width, yPos + 1, new StringFormat());
                            e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 670, yPos, new StringFormat());
                        }
                    }
                }
            }


            //Impression de l'équipement
            if (_Client.TypeVehicule == VehiculeType.Moto) {
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
            if (_Client.TypeVehicule == VehiculeType.Automatique) {
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
            MakeClient();

            //Rectangle de contour
            //e.Graphics.DrawRectangle(new Pen(Color.Black), leftMargin, topMargin, e.MarginBounds.Size.Width, 5 * printFont.Height + 10);

            //Donnée a imprimer
            yPos = topMargin + 5;
            e.Graphics.DrawString("Informations général", printFontBold16, Brushes.Black, leftMargin, yPos, new StringFormat());
            e.Graphics.DrawString("Imprimé le : " + DateTime.Now.ToShortDateString(), printFontTime, Brushes.Black, leftMargin + 450, yPos, new StringFormat());
            yPos += printFont.Height + 16;

            e.Graphics.DrawString("Nom : " + _Client.Name + " " + Client.FirstName, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Nº contrat : " + _Client.ContratNumber, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Date d'inscription : " + _Client.DateInscription.ToShortDateString(), printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Adresse : " + _Client.StreetNumber + " " + Client.StreetName + " App. " + Client.StreetApp, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Code Postale : " + _Client.CodePostal, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Ville : " + _Client.City, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Numéro de permis : " + _Client.NumeroPermis, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

            if (_Client.TypeVehicule == VehiculeType.Moto) {
                yPos += printFont.Height;
                e.Graphics.DrawString("Type de cours : Moto           Numéro 6R :" + Client.No6R, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            }
            else {
                yPos += printFont.Height;
                e.Graphics.DrawString("Type de cours : " + Client.TypeVehicule, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            }

            yPos += printFont.Height;
            e.Graphics.DrawString("Téléphone : " + _Client.Phone, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Téléphone (Autre) : " + _Client.PhoneBureau, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

            yPos += printFont.Height;
            e.Graphics.DrawString("État du client : " + _Client.TypeClient, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

            if (_Client.BVA == true) {
                yPos += printFont.Height;
                e.Graphics.DrawString("Date BVA : " + _Client.BVADate.ToShortDateString() + " " + _Client.BVADate.ToShortTimeString(), printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            }

            //Ecriture des seances
            yPos += printFont.Height * 2;
            e.Graphics.DrawString("Séance de cours théorique", printFontBold16, Brushes.Black, leftMargin, yPos, new StringFormat());
            yPos += 30;

            //Header des colone

            if (_Client.TypeVehicule != VehiculeType.Moto)
            {
                e.Graphics.DrawString("Date et heure", printFontBold, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
            }
            else
            {

                e.Graphics.DrawString("Date et heure (début et fin)", printFontBold, Brushes.Black, leftMargin + 40, yPos, new StringFormat());
                e.Graphics.DrawString("Endroit", printFontBold, Brushes.Black, leftMargin + 670, yPos, new StringFormat());

                var testString1 = "Signature (élève et professeur)";
                e.Graphics.DrawString(testString1, printFontBold, Brushes.Black, 670 - e.Graphics.MeasureString(testString1, printFont).Width, yPos, new StringFormat());
            }

            Seance seance = null;
            if (_Client.TypeVehicule != VehiculeType.Moto) {

                //Header de la colone montant
                e.Graphics.DrawString("Montant", printFontBold, Brushes.Black, 580 - e.Graphics.MeasureString("Montant", printFont).Width, yPos, new StringFormat());
                yPos += 16;

                for (int i = 0; i < Client.SeancesTheorique.Count; i++) {
                    seance = (Seance)_Client.SeancesTheorique[i];

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

                //e.Graphics.DrawString("Signature", printFontBold, Brushes.Black, leftMargin + 490, yPos, new StringFormat());

                for (int i = 0; i < Client.SeancesTheorique.Count; i++) {
                    seance = (Seance)_Client.SeancesTheorique[i];

                    //fabrique les donnees pour le type moto
                    if (i == 0) {
                        if (_PrintHorsRoute) {
                            yPos += printFont.Height * 2;
                            e.Graphics.DrawString("Hors Route", printFontBoldItalic16, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                            yPos += 16;

                            if (seance.Active) {
                                yPos += printFont.Height;
                                //e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 40, yPos, new StringFormat());
                                //e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToLongDateString(), printFont, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
                                //e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 340, yPos, new StringFormat());
                                //e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 420, yPos, new StringFormat());
                                //e.Graphics.DrawString(seance.Employer, printFont, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
                                e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                                e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToShortDateString(), printFont, Brushes.Black, leftMargin + 60, yPos, new StringFormat());

                                e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 220, yPos, new StringFormat());
                                e.Graphics.DrawString("à", printFont, Brushes.Black, leftMargin + 280, yPos, new StringFormat());
                                e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateModified), printFont, Brushes.Black, leftMargin + 300, yPos, new StringFormat());

                                e.Graphics.DrawString("_______________", printFont, Brushes.Black, leftMargin + 360, yPos + 1, new StringFormat());
                                e.Graphics.DrawString("_______________", printFont, Brushes.Black, leftMargin + 350 + e.Graphics.MeasureString("_________________", printFont).Width, yPos + 1, new StringFormat());
                                e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 670, yPos, new StringFormat());
                            }
                        }
                    }
                    else if (i < 4) {

                        if (seance.Active && _PrintHorsRoute) {
                            yPos += printFont.Height;
                            //e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 40, yPos, new StringFormat());
                            //e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToLongDateString(), printFont, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
                            //e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 340, yPos, new StringFormat());
                            //e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 420, yPos, new StringFormat());
                            //e.Graphics.DrawString(seance.Employer, printFont, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
                            e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                            e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToShortDateString(), printFont, Brushes.Black, leftMargin + 60, yPos, new StringFormat());

                            e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 220, yPos, new StringFormat());
                            e.Graphics.DrawString("à", printFont, Brushes.Black, leftMargin + 280, yPos, new StringFormat());
                            e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateModified), printFont, Brushes.Black, leftMargin + 300, yPos, new StringFormat());

                            e.Graphics.DrawString("_______________", printFont, Brushes.Black, leftMargin + 360, yPos + 1, new StringFormat());
                            e.Graphics.DrawString("_______________", printFont, Brushes.Black, leftMargin + 350 + e.Graphics.MeasureString("_________________", printFont).Width, yPos + 1, new StringFormat());
                            e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 670, yPos, new StringFormat());
                        }
                    }
                    else if (i == 4) {
                        if (_PrintRoute) {
                            yPos += printFont.Height * 2;
                            e.Graphics.DrawString("Route", printFontBoldItalic16, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                            yPos += 16;

                            if (seance.Active) {
                                yPos += printFont.Height;
                                //e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 40, yPos, new StringFormat());
                                //e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToLongDateString(), printFont, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
                                //e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 340, yPos, new StringFormat());
                                //e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 420, yPos, new StringFormat());
                                //e.Graphics.DrawString(seance.Employer, printFont, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
                                e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                                e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToShortDateString(), printFont, Brushes.Black, leftMargin + 60, yPos, new StringFormat());

                                e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 220, yPos, new StringFormat());
                                e.Graphics.DrawString("à", printFont, Brushes.Black, leftMargin + 280, yPos, new StringFormat());
                                e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateModified), printFont, Brushes.Black, leftMargin + 300, yPos, new StringFormat());

                                e.Graphics.DrawString("_______________", printFont, Brushes.Black, leftMargin + 360, yPos + 1, new StringFormat());
                                e.Graphics.DrawString("_______________", printFont, Brushes.Black, leftMargin + 350 + e.Graphics.MeasureString("_________________", printFont).Width, yPos + 1, new StringFormat());
                                e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 670, yPos, new StringFormat());
                            }
                        }
                    }
                    else {
                        if (seance.Active && _PrintRoute) {
                            yPos += printFont.Height;
                            //e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 40, yPos, new StringFormat());
                            //e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToLongDateString(), printFont, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
                            //e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 340, yPos, new StringFormat());
                            //e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 420, yPos, new StringFormat());
                            //e.Graphics.DrawString(seance.Employer, printFont, Brushes.Black, leftMargin + 590, yPos, new StringFormat());
                            e.Graphics.DrawString(seance.SceanceNumber + ".", printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
                            e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToShortDateString(), printFont, Brushes.Black, leftMargin + 60, yPos, new StringFormat());

                            e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 220, yPos, new StringFormat());
                            e.Graphics.DrawString("à", printFont, Brushes.Black, leftMargin + 280, yPos, new StringFormat());
                            e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateModified), printFont, Brushes.Black, leftMargin + 300, yPos, new StringFormat());

                            e.Graphics.DrawString("_______________", printFont, Brushes.Black, leftMargin + 360, yPos + 1, new StringFormat());
                            e.Graphics.DrawString("_______________", printFont, Brushes.Black, leftMargin + 350 + e.Graphics.MeasureString("_________________", printFont).Width, yPos + 1, new StringFormat());
                            e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 670, yPos, new StringFormat());
                        }
                    }
                }
            }


            //Impression de l'équipement
            if (_Client.TypeVehicule == VehiculeType.Moto) {
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
            if (_Client.TypeVehicule == VehiculeType.Automatique) {
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
            FormPaiment frmPaiment = new FormPaiment(this, _Client, _infoSchool);

            frmPaiment.SelectPaiment(Number);
            frmPaiment.ShowDialog();
            return frmPaiment.DialogResult;
        }

        /// <summary>
        /// Affiche la liste de paiment
        /// </summary>
        public DialogResult ShowPaiement() {
            FormPaiment frmPaiment = new FormPaiment(this, _Client, _infoSchool);

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
            if (ValidNoText()) _AutoUpdate = true;

            if (txtNumeroGroupe.Value == 0) {
                gbCoursType.Enabled = true;
                cmdClearbox.Enabled = false;
            }
            else {
                gbCoursType.Enabled = false;
                cmdClearbox.Enabled = true;
            }

            //if ((TypeVehicule == VehiculeType.Moto || TypeVehicule == VehiculeType.Cyclomoteur) && DateInscription.Value >= new DateTime(2015,04,10))           
            
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

        public ProgramMoto ProgramMoto
        {
            get
            {
                if (rbProgramMoto2015.Checked)
                    return Library.Client.ProgramMoto.Program2015;
                else if (rbProgramMotoNormal.Checked)
                    return Library.Client.ProgramMoto.ProgramNormal;

                return Library.Client.ProgramMoto.Nothing;
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
            Font printFontBold8 = new Font("Times New Roman", 8, FontStyle.Bold);
            Font printFontBold10 = new Font("Times New Roman", 10, FontStyle.Bold);
            Font printFontBold14 = new Font("Times New Roman", 14, FontStyle.Bold);
            Font printFontBold16 = new Font("Times New Roman", 16, FontStyle.Bold);
            Font printFontBold24 = new Font("Times New Roman", 24, FontStyle.Bold);
            Font printFontBoldItalic16 = new Font("Times New Roman", 16, FontStyle.Bold & FontStyle.Italic);

            float leftMargin = 0;//e.MarginBounds.Left;
            float yPos = 0f;
            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

            //Fabrication du client avant impression	
            MakeClient();

            #region Header
            //Ecriture du header (image et texte)
            Stream strm = Type.GetType("Barette.Library.UserControls.Client.ClientControl").Assembly.GetManifestResourceStream("Barette.Library.res.Printlogo.png");
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

            yPos += printFontBold14.Height;
            e.Graphics.DrawString("Contrat de service", printFontBold24, Brushes.Black, 225, yPos, new StringFormat());


            //yPos += printFontBold24.Height + 50;
            //e.Graphics.DrawString("Imprimé le : " + DateTime.Now.ToShortDateString(), printFontTime12, Brushes.Black, leftMargin + 600, yPos, new StringFormat());
            #endregion

            #region Informations Ecole
            yPos = 130;
            e.Graphics.DrawString("Informations sur l'école", printFontBold14, Brushes.Black, leftMargin, yPos, new StringFormat());
            yPos += printFontBold14.Height;
            e.Graphics.DrawString(_infoSchool.SchoolName, printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            yPos += printFontTime10.Height;
            e.Graphics.DrawString(_infoSchool.StreetNumber + " " + _infoSchool.StreetName, printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            yPos += printFontTime10.Height;
            e.Graphics.DrawString(_infoSchool.City + ", QC, " + _infoSchool.PostalCode, printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());

            //Numero de permis
            yPos = 130 + printFontBold14.Height;
            e.Graphics.DrawString("Permis : ", printFontTime10, Brushes.Black, leftMargin + 400, yPos, new StringFormat());
            switch (_Client.TypeVehicule) {
                case VehiculeType.Moto:
                    e.Graphics.DrawString(_infoSchool.RegistrationMoto, printFontTime10, Brushes.Black, leftMargin + 530, yPos, new StringFormat());
                    break;
                default:
                    e.Graphics.DrawString(_infoSchool.RegistrationAuto, printFontTime10, Brushes.Black, leftMargin + 530, yPos, new StringFormat());
                    break;
            }

            //Contrat
            yPos += printFontTime10.Height;
            e.Graphics.DrawString("Contrat : ", printFontTime10, Brushes.Black, leftMargin + 400, yPos, new StringFormat());
            e.Graphics.DrawString(_Client.ContratNumber, printFontTime10, Brushes.Black, leftMargin + 530, yPos, new StringFormat());

            //TPS et TVQ
            yPos += printFontTime10.Height;
            e.Graphics.DrawString("TPS : ", printFontTime10, Brushes.Black, leftMargin + 400, yPos, new StringFormat());
            e.Graphics.DrawString(_infoSchool.TPS, printFontTime10, Brushes.Black, leftMargin + 530, yPos, new StringFormat());
            yPos += printFontTime10.Height;
            e.Graphics.DrawString("TVQ : ", printFontTime10, Brushes.Black, leftMargin + 400, yPos, new StringFormat());
            e.Graphics.DrawString(_infoSchool.TVQ, printFontTime10, Brushes.Black, leftMargin + 530, yPos, new StringFormat());
            #endregion

            #region Eleves
            float hauteurEleve;

            yPos += printFontBold14.Height;
            e.Graphics.DrawString("Informations sur l'élève", printFontBold14, Brushes.Black, leftMargin, yPos, new StringFormat());

            //Nom
            yPos += printFontBold14.Height;
            hauteurEleve = yPos;
            e.Graphics.DrawString("Nom :", printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            e.Graphics.DrawString(_Client.Name, printFontTime10, Brushes.Black, leftMargin + 80, yPos, new StringFormat());

            //Prénom
            yPos += printFontTime10.Height;
            e.Graphics.DrawString("Prénom :", printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            e.Graphics.DrawString(_Client.FirstName, printFontTime10, Brushes.Black, leftMargin + 80, yPos, new StringFormat());

            //Adresse
            yPos += printFontTime10.Height;
            e.Graphics.DrawString("Adresse :", printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());

            if (_Client.StreetApp != "")
                e.Graphics.DrawString(_Client.StreetNumber + " " + _Client.StreetName + "    App # " + _Client.StreetApp, printFontTime10, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
            else
                e.Graphics.DrawString(_Client.StreetNumber + " " + _Client.StreetName, printFontTime10, Brushes.Black, leftMargin + 80, yPos, new StringFormat());

            yPos += printFontTime10.Height;
            e.Graphics.DrawString("Ville :", printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            e.Graphics.DrawString(_Client.City + ", QC", printFontTime10, Brushes.Black, leftMargin + 80, yPos, new StringFormat());
            yPos += printFontTime10.Height;
            e.Graphics.DrawString("Code Postal :", printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            e.Graphics.DrawString(_Client.CodePostal, printFontTime10, Brushes.Black, leftMargin + 80, yPos, new StringFormat());

            //Date de naissance            
            e.Graphics.DrawString("Date de naissance : ", printFontTime10, Brushes.Black, leftMargin + 400, hauteurEleve, new StringFormat());
            e.Graphics.DrawString(_Client.DateNaissance.ToLongDateString(), printFontTime10, Brushes.Black, leftMargin + 530, hauteurEleve, new StringFormat());

            // Telephone
            hauteurEleve += printFontTime10.Height;
            e.Graphics.DrawString("Téléphone (domicile): ", printFontTime10, Brushes.Black, leftMargin + 400, hauteurEleve, new StringFormat());
            e.Graphics.DrawString(_Client.Phone, printFontTime10, Brushes.Black, leftMargin + 530, hauteurEleve, new StringFormat());

            // Telephone (autre)
            hauteurEleve += printFontTime10.Height;
            e.Graphics.DrawString("Téléphone (autre): ", printFontTime10, Brushes.Black, leftMargin + 400, hauteurEleve, new StringFormat());
            e.Graphics.DrawString(_Client.PhoneBureau, printFontTime10, Brushes.Black, leftMargin + 530, hauteurEleve, new StringFormat());
            #endregion

            #region Détail du cours
            float hauteurDescription;

            yPos += printFontBold14.Height;
            e.Graphics.DrawString("Détails du cours", printFontBold14, Brushes.Black, leftMargin, yPos, new StringFormat());

            //Type de cours
            yPos += printFontBold14.Height;
            hauteurDescription = yPos;
            e.Graphics.DrawString("Type de cours :", printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            switch (_Client.TypeVehicule) {
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
            e.Graphics.DrawString(_Client.DateInscription.ToLongDateString(), printFontTime10, Brushes.Black, leftMargin + 120, yPos, new StringFormat());

            //Date expiration
            yPos += printFontTime10.Height;
            e.Graphics.DrawString("Date d'expiration :", printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            e.Graphics.DrawString(_Client.DateExpiration.ToLongDateString(), printFontTime10, Brushes.Black, leftMargin + 120, yPos, new StringFormat());

            //Date debut cours
            yPos += printFontTime10.Height;
            e.Graphics.DrawString("Date début du cours :", printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
            e.Graphics.DrawString(_Client.DateDebutCours.ToLongDateString(), printFontTime10, Brushes.Black, leftMargin + 120, yPos, new StringFormat());

            //Prix du cours
            TaxeExtractor taxe = new TaxeExtractor();

            if (_Client.DateInscription.Year == 2011)
                taxe = new TaxeExtractor(Convert.ToDecimal(_Client.MontantCours.Replace("$", "").Trim()), TaxeExtractor.Years.Y2011);
            else if (_Client.DateInscription.Year < 2011)
                taxe = new TaxeExtractor(Convert.ToDecimal(_Client.MontantCours.Replace("$", "").Trim()), TaxeExtractor.Years.Y2008_to_2010);
            else if (_Client.DateInscription.Year >= 2012 && _Client.DateInscription.Year < 2014)
                taxe = new TaxeExtractor(Convert.ToDecimal(_Client.MontantCours.Replace("$", "").Trim()), TaxeExtractor.Years.Y2012);
            else if (_Client.DateInscription.Year >= 2014)
                taxe = new TaxeExtractor(Convert.ToDecimal(_Client.MontantCours.Replace("$", "").Trim()), TaxeExtractor.Years.Y2014);

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
            switch (_Client.TypeVehicule) {
                case VehiculeType.Moto:
                    //Theorie
                    hauteurDescription += printFontTime10.Height;
                    e.Graphics.DrawString("Théorie : 9 Heures @ ", printFontTime10, Brushes.Black, leftMargin + 400, hauteurDescription, new StringFormat());
                    e.Graphics.DrawString(_Client.TauxHoraireTheorique + " / heures", printFontTime10, Brushes.Black, leftMargin + 540, hauteurDescription, new StringFormat());

                    //Pratique
                    hauteurDescription += printFontTime10.Height;
                    e.Graphics.DrawString("Pratique: 22 Heures @ ", printFontTime10, Brushes.Black, leftMargin + 400, hauteurDescription, new StringFormat());
                    e.Graphics.DrawString(_Client.TauxHorairePratique + " / heures", printFontTime10, Brushes.Black, leftMargin + 540, hauteurDescription, new StringFormat());

                    break;
                case VehiculeType.Cyclomoteur:
                    //theorie
                    hauteurDescription += printFontTime10.Height;
                    e.Graphics.DrawString("Théorie : 3 Heures @ ", printFontTime10, Brushes.Black, leftMargin + 400, hauteurDescription, new StringFormat());
                    e.Graphics.DrawString(_Client.TauxHoraireTheorique + " / heures", printFontTime10, Brushes.Black, leftMargin + 540, hauteurDescription, new StringFormat());

                    //Pratique
                    hauteurDescription += printFontTime10.Height;
                    e.Graphics.DrawString("Pratique: 3 Heures @ ", printFontTime10, Brushes.Black, leftMargin + 400, hauteurDescription, new StringFormat());
                    e.Graphics.DrawString(_Client.TauxHorairePratique + " / heures", printFontTime10, Brushes.Black, leftMargin + 540, hauteurDescription, new StringFormat());

                    break;
                default:
                    //theorie
                    hauteurDescription += printFontTime10.Height;
                    e.Graphics.DrawString("Théorie : 24 Heures @ ", printFontTime10, Brushes.Black, leftMargin + 400, hauteurDescription, new StringFormat());
                    e.Graphics.DrawString(_Client.TauxHoraireTheorique + " / heures", printFontTime10, Brushes.Black, leftMargin + 540, hauteurDescription, new StringFormat());

                    //Pratique
                    hauteurDescription += printFontTime10.Height;
                    e.Graphics.DrawString("Pratique: 15 Heures @ ", printFontTime10, Brushes.Black, leftMargin + 400, hauteurDescription, new StringFormat());
                    e.Graphics.DrawString(_Client.TauxHorairePratique + " / heures", printFontTime10, Brushes.Black, leftMargin + 540, hauteurDescription, new StringFormat());

                    break;
            }

            #endregion

            #region Lieu de formation en circuit fermé pour moto et cylclo
            //Ajouter le lieu de formation de moto en cas de client moto ou cylclomoteur
            if ((_Client.TypeVehicule == VehiculeType.Moto) || (_Client.TypeVehicule == VehiculeType.Cyclomoteur)) {
                yPos += printFontBold24.Height;
                e.Graphics.DrawString("Lieu de formation en circuit fermé", printFontBold14, Brushes.Black, leftMargin, yPos, new StringFormat());
                yPos += printFontBold14.Height;
                e.Graphics.DrawString(_infoSchool.CourseBatisseName, printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
                yPos += printFontTime10.Height;
                e.Graphics.DrawString(_infoSchool.CourseStreetNumber + " " + _infoSchool.CourseStreetName, printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
                yPos += printFontTime10.Height;
                e.Graphics.DrawString(_infoSchool.CourseCity + ", QC, " + _infoSchool.CoursePostalCode, printFontTime10, Brushes.Black, leftMargin, yPos, new StringFormat());
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
            e.Graphics.DrawString("Fait et signé à " + _infoSchool.City + " le " + DateTime.Now.ToLongDateString(), printFontTime10, Brushes.Black, leftMargin + 5, yPos, new StringFormat());
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

            UpdateProgramMotoControl();
        }

        private void cmdClearbox_Click(object sender, EventArgs e) {

            if (MessageBox.Show(this, "Voulez-vous enlever votre client du group No. : " + txtNumeroGroupe.Text + " ?", "Gestion Auto École", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            int TraficatedSeanceNumberForGerald = 0;

            //Facrication des fonts
            Font printFont = new System.Drawing.Font("Courier New", 10);
            Font printFontTime = new Font("Times New Roman", 11, FontStyle.Regular);
            Font printFontTime8 = new Font("Times New Roman", 8, FontStyle.Regular);
            Font printFontBold = new Font("Times New Roman", 11, FontStyle.Bold);
            Font printFontBold10 = new Font("Times New Roman", 10, FontStyle.Bold);
            Font printFontBold16 = new Font("Times New Roman", 16, FontStyle.Bold);            
            Font printFontBoldItalic16 = new Font("Times New Roman", 16, FontStyle.Bold & FontStyle.Italic);

            float yPos = 0f;
            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

            //Fabrication du client avant impression	
            MakeClient();

            //Rectangle de contour
            //e.Graphics.DrawRectangle(new Pen(Color.Black), leftMargin, topMargin, e.MarginBounds.Size.Width, 5 * printFont.Height + 10);

            //Donnée a imprimer
            yPos = topMargin + 5;
            e.Graphics.DrawString("Informations général", printFontBold16, Brushes.Black, leftMargin, yPos, new StringFormat());
            e.Graphics.DrawString("Imprimé le : " + DateTime.Now.ToShortDateString(), printFontTime, Brushes.Black, leftMargin + 450, yPos, new StringFormat());
            yPos += printFont.Height + 16;

            e.Graphics.DrawString("Nom : " + _Client.Name + " " + Client.FirstName, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Nº contrat : " + _Client.ContratNumber, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Date d'inscription : " + _Client.DateInscription.ToShortDateString(), printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Adresse : " + _Client.StreetNumber + " " + Client.StreetName + " App. " + Client.StreetApp, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Code Postale : " + _Client.CodePostal, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Ville : " + _Client.City, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Numéro de permis : " + _Client.NumeroPermis, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

            if (_Client.TypeVehicule == VehiculeType.Moto)
            {
                yPos += printFont.Height;
                e.Graphics.DrawString("Type de cours : Moto           Numéro 6R :" + Client.No6R, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            }
            else
            {
                yPos += printFont.Height;
                e.Graphics.DrawString("Type de cours : " + Client.TypeVehicule, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            }

            yPos += printFont.Height;
            e.Graphics.DrawString("Téléphone : " + _Client.Phone, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Téléphone (Autre) : " + _Client.PhoneBureau, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

            yPos += printFont.Height;
            e.Graphics.DrawString("État du client : " + _Client.TypeClient, printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

            if (_Client.BVA == true)
            {
                yPos += printFont.Height;
                e.Graphics.DrawString("Date BVA : " + _Client.BVADate.ToShortDateString() + " " + _Client.BVADate.ToShortTimeString(), printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            }

            //Ecriture des seances
            yPos += printFont.Height * 2;
            e.Graphics.DrawString("Séance de cours", printFontBold16, Brushes.Black, leftMargin, yPos, new StringFormat());
            yPos += 30;

            //Header des colones
            e.Graphics.DrawString("Date et heure (début et fin)", printFontBold, Brushes.Black, leftMargin + 40, yPos, new StringFormat());
            e.Graphics.DrawString("Endroit", printFontBold, Brushes.Black, leftMargin + 670, yPos, new StringFormat());

            var testString1 = "Signature (élève et professeur)";
            e.Graphics.DrawString(testString1, printFontBold, Brushes.Black, 670 - e.Graphics.MeasureString(testString1, printFont).Width, yPos, new StringFormat());
            yPos += 16;

            var formationPrinted1 = false;
            var formationPrinted2 = false;            

            foreach (Seance seance in BuildSeanceForPrintSeanceMoto2015())
            {
                if (seance.Active)
                {
                    switch (seance.SceanceNumber)
                    {
                        case 1:
                            yPos += printFontBold.Height * 1.5F;
                            e.Graphics.DrawString("Formation théorique en circuit fermé (3h)", printFontBold, Brushes.Black, leftMargin, yPos, new StringFormat());
                            //yPos += 15;
                            break;
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                            if (!formationPrinted1)
                            {
                                yPos += printFontBold.Height * 1.5F;
                                e.Graphics.DrawString("Formation pratique en circuit fermé (16h)", printFontBold, Brushes.Black, leftMargin, yPos, new StringFormat());
                                formationPrinted1 = true;
                            }
                            break;
                        case 6:
                            yPos += printFontBold.Height * 1.5F;
                            e.Graphics.DrawString("Formation théorique sur route (3h)", printFontBold, Brushes.Black, leftMargin, yPos, new StringFormat());                            
                            break;
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                        case 11:
                            if (!formationPrinted2)
                            {
                                yPos += printFontBold.Height * 1.5F;
                                e.Graphics.DrawString("Formation pratique sur route (10h)", printFontBold, Brushes.Black, leftMargin, yPos, new StringFormat());
                                formationPrinted2 = true;
                            }
                            break;

                    }

                    yPos += printFont.Height +2;

                    switch (seance.SceanceNumber)
                    {
                        case 1:
                            TraficatedSeanceNumberForGerald = 1;
                            break;
                        case 2:
                            TraficatedSeanceNumberForGerald = 1;
                            break;
                        case 3:
                            TraficatedSeanceNumberForGerald = 2;
                            break;
                        case 4:
                            TraficatedSeanceNumberForGerald = 3;
                            break;
                        case 5:
                            TraficatedSeanceNumberForGerald = 4;
                            break;
                        case 6:
                            TraficatedSeanceNumberForGerald = 2;
                            break;
                        case 7:
                            TraficatedSeanceNumberForGerald = 5;
                            break;
                        case 8:
                            TraficatedSeanceNumberForGerald = 6;
                            break;
                        case 9:
                            TraficatedSeanceNumberForGerald = 7;
                            break;
                        case 10:
                            TraficatedSeanceNumberForGerald = 8;
                            break;
                        case 11:
                            TraficatedSeanceNumberForGerald = 9;
                            break;                            
                    }
                    e.Graphics.DrawString(TraficatedSeanceNumberForGerald + ".", printFont, Brushes.Black, leftMargin + 20, yPos, new StringFormat());

                    e.Graphics.DrawString(DateTimeFunc.DayOfWeekFRShort(seance.DateHeure.DayOfWeek) + " " + seance.DateHeure.ToShortDateString(), printFont, Brushes.Black, leftMargin + 60, yPos, new StringFormat());
                    
                    e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateHeure), printFont, Brushes.Black, leftMargin + 220, yPos, new StringFormat());
                    e.Graphics.DrawString("à", printFont, Brushes.Black, leftMargin + 280, yPos, new StringFormat());
                    e.Graphics.DrawString(DateTimeFunc.FormatHour(seance.DateModified), printFont, Brushes.Black, leftMargin + 300, yPos, new StringFormat());

                    e.Graphics.DrawString("_______________", printFont, Brushes.Black, leftMargin + 360, yPos + 1, new StringFormat());
                    e.Graphics.DrawString("_______________", printFont, Brushes.Black, leftMargin + 350 + e.Graphics.MeasureString("_________________", printFont).Width, yPos + 1, new StringFormat());
                    e.Graphics.DrawString(seance.Code, printFont, Brushes.Black, leftMargin + 670, yPos, new StringFormat());

                }                
            }

            ////////Print prof info avec la derniere seance ///////////
            Seance last = Client.GetLastMotoSeance();
            Employe employe = null;

            if (last != null)
                employe = ListeEmploye.GetFromNameOrDefault(last.Employer);
            else
                employe = ListeEmploye.GetFromNameOrDefault("");
            
            yPos += (printFontTime8.Height * 4);
            e.Graphics.DrawString("Nom du professeur : " + employe.NomAffichageRapport + "           No. Permis : " + employe.NumeroPermis, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
            ///////////////////////////////////////////////////////////

            yPos += (printFontBold.Height * 2);
            e.Graphics.DrawString("Équipements Nécessaires", printFontBold10, Brushes.Black, leftMargin, yPos, new StringFormat());
            yPos += printFontBold10.Height;
            e.Graphics.DrawString("1. Casque avec visière", printFontTime8, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFontTime8.Height;
            e.Graphics.DrawString("2. Bottes sécuritaires (couvrant la cheville)", printFontTime8, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFontTime8.Height;
            e.Graphics.DrawString("3. Gants de cuir (couvrant le poignet de préférence)", printFontTime8, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            yPos += printFontTime8.Height;
            e.Graphics.DrawString("4. Habit de pluie 2 parties séparées (haut et bas)", printFontTime8, Brushes.Black, leftMargin + 20, yPos, new StringFormat());
            
            //Imprime les messages d'attention
            yPos += 50;
            Font myFont = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("ATTENTION", myFont, Brushes.Black, leftMargin, yPos, new StringFormat());

            SizeF strLength = e.Graphics.MeasureString("ATTENTION", myFont); //Largeur de la chaine
            if (_Client.TypeVehicule == VehiculeType.Automatique)
            {
                e.Graphics.DrawString("Un pré-avis de 24 heures est requis tel que convenue sur le contrat de service;", printFontTime8, Brushes.Black, leftMargin + strLength.Width, yPos, new StringFormat());
            }
            else
                e.Graphics.DrawString("Un pré-avis de 48 heures est requis tel que convenue sur le contrat de service;", printFontTime8, Brushes.Black, leftMargin + strLength.Width, yPos, new StringFormat());

            yPos += myFont.Height;
            e.Graphics.DrawString("pour l'annulation de séances pratiques", printFontTime8, Brushes.Black, leftMargin + strLength.Width, yPos, new StringFormat());
            yPos += (myFont.Height * 2);
            e.Graphics.DrawString("Les locations Auto/Moto sont non remboursables.", printFontTime8, Brushes.Black, leftMargin + strLength.Width, yPos, new StringFormat());

            
            //yPos += (myFont.Height * 2);
            //e.Graphics.DrawString("Les locations Auto/Moto sont non remboursables.", printFontTime, Brushes.Black, leftMargin + strLength.Width, yPos, new StringFormat());
        }

        private IEnumerable BuildSeanceForPrintSeanceMoto2015()
        {
            SeanceCollection seances = new SeanceCollection();
            foreach (Seance seance in _Client.Seances)
                seances.Add(seance);
            foreach (Seance seance in _Client.SeancesTheorique)
                seances.Add(seance);

            return from seance in seances.Cast<Seance>()
                   orderby seance.SceanceNumber
                   select seance;
        }

        private void cbAuto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbTypeClientFinish_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbProgramMotoNormal_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgramMotoControl();
        }

        private void rbProgramMoto2015_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProgramMotoControl();
        }
    }
}