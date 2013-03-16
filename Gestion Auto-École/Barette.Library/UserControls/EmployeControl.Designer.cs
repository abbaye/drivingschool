namespace Barette.Library.UserControls {
	partial class EmployeControl {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabPage tpFiche;
            System.Windows.Forms.TabPage tpEtatCivil;
            System.Windows.Forms.TabPage tpEntreSortie;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.dtbDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.cbSituationFamiliale = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.mtNAS = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ntbAdultACharge = new UtilityLibrary.WinControls.NumericTextBox();
            this.ntbEnfantACharge = new UtilityLibrary.WinControls.NumericTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPhoneOther = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdressNumber = new UtilityLibrary.WinControls.NumericTextBox();
            this.txtCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.txtAdressApp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAdressStreet = new System.Windows.Forms.TextBox();
            this.tpInfoPaye = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbTypeContractuel = new System.Windows.Forms.RadioButton();
            this.cbTypeDirigeant = new System.Windows.Forms.RadioButton();
            this.cbTypeTauxHorraire = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ctbSalaire = new Barette.Library.UserControls.CashTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbLastDay = new System.Windows.Forms.CheckBox();
            this.dtpLastDay = new System.Windows.Forms.DateTimePicker();
            this.dtpFirstDay = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNatureEmploie = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbTitre = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNumeroEmploye = new UtilityLibrary.WinControls.NumericTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControlEmploye = new System.Windows.Forms.TabControl();
            this.tpNotes = new System.Windows.Forms.TabPage();
            this.teNotes = new Barette.Library.UserControls.TextEdit.TextEditor();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            tpFiche = new System.Windows.Forms.TabPage();
            tpEtatCivil = new System.Windows.Forms.TabPage();
            tpEntreSortie = new System.Windows.Forms.TabPage();
            tpFiche.SuspendLayout();
            this.tabControl1.SuspendLayout();
            tpEtatCivil.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpInfoPaye.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            tpEntreSortie.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControlEmploye.SuspendLayout();
            this.tpNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpFiche
            // 
            tpFiche.Controls.Add(this.tabControl1);
            tpFiche.Controls.Add(this.cbNatureEmploie);
            tpFiche.Controls.Add(this.label17);
            tpFiche.Controls.Add(this.cbTitre);
            tpFiche.Controls.Add(this.label13);
            tpFiche.Controls.Add(this.txtNumeroEmploye);
            tpFiche.Controls.Add(this.label14);
            tpFiche.Controls.Add(this.pictureBox2);
            tpFiche.Controls.Add(this.txtName);
            tpFiche.Controls.Add(this.label11);
            tpFiche.Controls.Add(this.txtFirstName);
            tpFiche.Controls.Add(this.label7);
            tpFiche.Location = new System.Drawing.Point(4, 22);
            tpFiche.Name = "tpFiche";
            tpFiche.Padding = new System.Windows.Forms.Padding(3);
            tpFiche.Size = new System.Drawing.Size(783, 493);
            tpFiche.TabIndex = 0;
            tpFiche.Tag = "ETATCIVIL";
            tpFiche.Text = "Fiche";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(tpEtatCivil);
            this.tabControl1.Controls.Add(this.tpInfoPaye);
            this.tabControl1.Controls.Add(tpEntreSortie);
            this.tabControl1.Location = new System.Drawing.Point(7, 115);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 233);
            this.tabControl1.TabIndex = 4;
            // 
            // tpEtatCivil
            // 
            tpEtatCivil.Controls.Add(this.groupBox6);
            tpEtatCivil.Controls.Add(this.groupBox5);
            tpEtatCivil.Controls.Add(this.groupBox4);
            tpEtatCivil.Controls.Add(this.groupBox1);
            tpEtatCivil.Location = new System.Drawing.Point(4, 22);
            tpEtatCivil.Name = "tpEtatCivil";
            tpEtatCivil.Padding = new System.Windows.Forms.Padding(3);
            tpEtatCivil.Size = new System.Drawing.Size(586, 207);
            tpEtatCivil.TabIndex = 0;
            tpEtatCivil.Text = "Etat civil";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.dtbDateNaissance);
            this.groupBox6.Controls.Add(this.cbSituationFamiliale);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.mtNAS);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(336, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(240, 163);
            this.groupBox6.TabIndex = 49;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Situation et naissance";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 106);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 13);
            this.label22.TabIndex = 65;
            this.label22.Text = "Date naissance :";
            // 
            // dtbDateNaissance
            // 
            this.dtbDateNaissance.Location = new System.Drawing.Point(106, 103);
            this.dtbDateNaissance.Name = "dtbDateNaissance";
            this.dtbDateNaissance.Size = new System.Drawing.Size(128, 20);
            this.dtbDateNaissance.TabIndex = 11;
            // 
            // cbSituationFamiliale
            // 
            this.cbSituationFamiliale.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSituationFamiliale.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSituationFamiliale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSituationFamiliale.FormattingEnabled = true;
            this.cbSituationFamiliale.Items.AddRange(new object[] {
            "Célibataire",
            "Divorcé(e)",
            "Marié(e)",
            "Union Libre",
            "Veuf(ve)"});
            this.cbSituationFamiliale.Location = new System.Drawing.Point(106, 50);
            this.cbSituationFamiliale.Name = "cbSituationFamiliale";
            this.cbSituationFamiliale.Size = new System.Drawing.Size(128, 21);
            this.cbSituationFamiliale.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 55);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 13);
            this.label21.TabIndex = 53;
            this.label21.Text = "Situation familiale :";
            // 
            // mtNAS
            // 
            this.mtNAS.Location = new System.Drawing.Point(106, 76);
            this.mtNAS.Mask = "000 000 000";
            this.mtNAS.Name = "mtNAS";
            this.mtNAS.Size = new System.Drawing.Size(85, 20);
            this.mtNAS.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Numéro AS :";
            this.toolTip1.SetToolTip(this.label4, "Numéro d\'assurance sociale :");
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.ntbAdultACharge);
            this.groupBox5.Controls.Add(this.ntbEnfantACharge);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(199, 91);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(130, 76);
            this.groupBox5.TabIndex = 48;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Personne à charge";
            // 
            // ntbAdultACharge
            // 
            this.ntbAdultACharge.Location = new System.Drawing.Point(73, 46);
            this.ntbAdultACharge.Name = "ntbAdultACharge";
            this.ntbAdultACharge.SetRange = new System.Drawing.Size(0, 50);
            this.ntbAdultACharge.Size = new System.Drawing.Size(46, 20);
            this.ntbAdultACharge.TabIndex = 8;
            this.ntbAdultACharge.Text = "0";
            this.ntbAdultACharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ntbEnfantACharge
            // 
            this.ntbEnfantACharge.Location = new System.Drawing.Point(73, 20);
            this.ntbEnfantACharge.Name = "ntbEnfantACharge";
            this.ntbEnfantACharge.SetRange = new System.Drawing.Size(0, 50);
            this.ntbEnfantACharge.Size = new System.Drawing.Size(46, 20);
            this.ntbEnfantACharge.TabIndex = 7;
            this.ntbEnfantACharge.Text = "0";
            this.ntbEnfantACharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 48);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Adult :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enfants :";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtPhoneNumber);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtPhoneOther);
            this.groupBox4.Location = new System.Drawing.Point(7, 91);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(185, 76);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Téléphone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Personnel :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(79, 20);
            this.txtPhoneNumber.Mask = "(999)000-0000";
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Autre :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhoneOther
            // 
            this.txtPhoneOther.Location = new System.Drawing.Point(79, 46);
            this.txtPhoneOther.Mask = "(999)000-0000";
            this.txtPhoneOther.Name = "txtPhoneOther";
            this.txtPhoneOther.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneOther.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtAdressNumber);
            this.groupBox1.Controls.Add(this.txtCodePostal);
            this.groupBox1.Controls.Add(this.txtAdressApp);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbCity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtAdressStreet);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 79);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adresse";
            // 
            // txtAdressNumber
            // 
            this.txtAdressNumber.Location = new System.Drawing.Point(32, 21);
            this.txtAdressNumber.Name = "txtAdressNumber";
            this.txtAdressNumber.SetRange = new System.Drawing.Size(0, 9999999);
            this.txtAdressNumber.Size = new System.Drawing.Size(65, 20);
            this.txtAdressNumber.TabIndex = 1;
            this.txtAdressNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(264, 49);
            this.txtCodePostal.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.txtCodePostal.Mask = "L0L-0L0";
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(47, 20);
            this.txtCodePostal.TabIndex = 4;
            // 
            // txtAdressApp
            // 
            this.txtAdressApp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAdressApp.Location = new System.Drawing.Point(583, 51);
            this.txtAdressApp.Name = "txtAdressApp";
            this.txtAdressApp.Size = new System.Drawing.Size(48, 20);
            this.txtAdressApp.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(183, 52);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Code Postale :";
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Items.AddRange(new object[] {
            "",
            "Alma",
            "Chicoutimi",
            "Jonquiere",
            "La Baie",
            "St-Fulgence",
            "St-Honoré",
            "Falardeau",
            "Laterrière",
            "Canton Tremlay"});
            this.cbCity.Location = new System.Drawing.Point(64, 49);
            this.cbCity.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(115, 21);
            this.cbCity.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "No";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(104, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Rue";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(551, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "App.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(8, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Localité :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAdressStreet
            // 
            this.txtAdressStreet.Location = new System.Drawing.Point(136, 20);
            this.txtAdressStreet.Name = "txtAdressStreet";
            this.txtAdressStreet.Size = new System.Drawing.Size(174, 20);
            this.txtAdressStreet.TabIndex = 2;
            // 
            // tpInfoPaye
            // 
            this.tpInfoPaye.Controls.Add(this.groupBox7);
            this.tpInfoPaye.Controls.Add(this.groupBox3);
            this.tpInfoPaye.Location = new System.Drawing.Point(4, 22);
            this.tpInfoPaye.Name = "tpInfoPaye";
            this.tpInfoPaye.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfoPaye.Size = new System.Drawing.Size(586, 207);
            this.tpInfoPaye.TabIndex = 2;
            this.tpInfoPaye.Text = "Info. Paye";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.cbTypeContractuel);
            this.groupBox7.Controls.Add(this.cbTypeDirigeant);
            this.groupBox7.Controls.Add(this.cbTypeTauxHorraire);
            this.groupBox7.Location = new System.Drawing.Point(7, 5);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(176, 137);
            this.groupBox7.TabIndex = 53;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Statut dans la société";
            // 
            // cbTypeContractuel
            // 
            this.cbTypeContractuel.AutoSize = true;
            this.cbTypeContractuel.Location = new System.Drawing.Point(38, 95);
            this.cbTypeContractuel.Name = "cbTypeContractuel";
            this.cbTypeContractuel.Size = new System.Drawing.Size(79, 17);
            this.cbTypeContractuel.TabIndex = 3;
            this.cbTypeContractuel.Text = "Contractuel";
            // 
            // cbTypeDirigeant
            // 
            this.cbTypeDirigeant.AutoSize = true;
            this.cbTypeDirigeant.Location = new System.Drawing.Point(38, 67);
            this.cbTypeDirigeant.Name = "cbTypeDirigeant";
            this.cbTypeDirigeant.Size = new System.Drawing.Size(67, 17);
            this.cbTypeDirigeant.TabIndex = 2;
            this.cbTypeDirigeant.Text = "Dirigeant";
            // 
            // cbTypeTauxHorraire
            // 
            this.cbTypeTauxHorraire.AutoSize = true;
            this.cbTypeTauxHorraire.Location = new System.Drawing.Point(38, 41);
            this.cbTypeTauxHorraire.Name = "cbTypeTauxHorraire";
            this.cbTypeTauxHorraire.Size = new System.Drawing.Size(92, 17);
            this.cbTypeTauxHorraire.TabIndex = 1;
            this.cbTypeTauxHorraire.Text = "Payé à l\'heure";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.ctbSalaire);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(190, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 72);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salaire";
            // 
            // ctbSalaire
            // 
            this.ctbSalaire.Location = new System.Drawing.Point(100, 27);
            this.ctbSalaire.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.ctbSalaire.Name = "ctbSalaire";
            this.ctbSalaire.Size = new System.Drawing.Size(53, 20);
            this.ctbSalaire.TabIndex = 4;
            this.ctbSalaire.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 31);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Salaire / heures :";
            // 
            // tpEntreSortie
            // 
            tpEntreSortie.Controls.Add(this.groupBox2);
            tpEntreSortie.Location = new System.Drawing.Point(4, 22);
            tpEntreSortie.Name = "tpEntreSortie";
            tpEntreSortie.Padding = new System.Windows.Forms.Padding(3);
            tpEntreSortie.Size = new System.Drawing.Size(586, 207);
            tpEntreSortie.TabIndex = 1;
            tpEntreSortie.Text = "Entrée / Sortie";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cbLastDay);
            this.groupBox2.Controls.Add(this.dtpLastDay);
            this.groupBox2.Controls.Add(this.dtpFirstDay);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(7, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 72);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date";
            // 
            // cbLastDay
            // 
            this.cbLastDay.AutoSize = true;
            this.cbLastDay.Location = new System.Drawing.Point(129, 44);
            this.cbLastDay.Name = "cbLastDay";
            this.cbLastDay.Size = new System.Drawing.Size(15, 14);
            this.cbLastDay.TabIndex = 2;
            this.cbLastDay.CheckedChanged += new System.EventHandler(this.cbLastDay_CheckedChanged);
            // 
            // dtpLastDay
            // 
            this.dtpLastDay.Enabled = false;
            this.dtpLastDay.Location = new System.Drawing.Point(144, 41);
            this.dtpLastDay.Name = "dtpLastDay";
            this.dtpLastDay.Size = new System.Drawing.Size(136, 20);
            this.dtpLastDay.TabIndex = 3;
            // 
            // dtpFirstDay
            // 
            this.dtpFirstDay.Location = new System.Drawing.Point(144, 14);
            this.dtpFirstDay.Name = "dtpFirstDay";
            this.dtpFirstDay.Size = new System.Drawing.Size(136, 20);
            this.dtpFirstDay.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Dernier jour travaillé :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date d\'embauche :";
            // 
            // cbNatureEmploie
            // 
            this.cbNatureEmploie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbNatureEmploie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNatureEmploie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNatureEmploie.FormattingEnabled = true;
            this.cbNatureEmploie.Items.AddRange(new object[] {
            "Assistant Comptable",
            "Directeur Commercial",
            "Formateur",
            "Responsable Administratif",
            "Responsable Technique",
            "Secrétaire",
            "Technicien"});
            this.cbNatureEmploie.Location = new System.Drawing.Point(411, 6);
            this.cbNatureEmploie.Name = "cbNatureEmploie";
            this.cbNatureEmploie.Size = new System.Drawing.Size(144, 21);
            this.cbNatureEmploie.Sorted = true;
            this.cbNatureEmploie.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(315, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 57;
            this.label17.Text = "Nature d\'emploi :";
            // 
            // cbTitre
            // 
            this.cbTitre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTitre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTitre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTitre.FormattingEnabled = true;
            this.cbTitre.Items.AddRange(new object[] {
            "M",
            "Mme",
            "Mle"});
            this.cbTitre.Location = new System.Drawing.Point(142, 33);
            this.cbTitre.Name = "cbTitre";
            this.cbTitre.Size = new System.Drawing.Size(73, 21);
            this.cbTitre.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(46, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 55;
            this.label13.Text = "Titre :";
            // 
            // txtNumeroEmploye
            // 
            this.txtNumeroEmploye.Location = new System.Drawing.Point(142, 8);
            this.txtNumeroEmploye.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.txtNumeroEmploye.Name = "txtNumeroEmploye";
            this.txtNumeroEmploye.SetRange = new System.Drawing.Size(0, 9999999);
            this.txtNumeroEmploye.Size = new System.Drawing.Size(73, 20);
            this.txtNumeroEmploye.TabIndex = 0;
            this.txtNumeroEmploye.Text = "0";
            this.txtNumeroEmploye.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(47, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Nº employé :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(142, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 20);
            this.txtName.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(46, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Nom :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(142, 61);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(155, 20);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(47, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Prénom :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControlEmploye
            // 
            this.tabControlEmploye.Controls.Add(tpFiche);
            this.tabControlEmploye.Controls.Add(this.tpNotes);
            this.tabControlEmploye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEmploye.Location = new System.Drawing.Point(0, 0);
            this.tabControlEmploye.Name = "tabControlEmploye";
            this.tabControlEmploye.SelectedIndex = 0;
            this.tabControlEmploye.Size = new System.Drawing.Size(791, 519);
            this.tabControlEmploye.TabIndex = 56;
            // 
            // tpNotes
            // 
            this.tpNotes.Controls.Add(this.teNotes);
            this.tpNotes.Location = new System.Drawing.Point(4, 22);
            this.tpNotes.Name = "tpNotes";
            this.tpNotes.Padding = new System.Windows.Forms.Padding(3);
            this.tpNotes.Size = new System.Drawing.Size(783, 493);
            this.tpNotes.TabIndex = 1;
            this.tpNotes.Tag = "NOTES";
            this.tpNotes.Text = "Notes";
            // 
            // teNotes
            // 
            this.teNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teNotes.Location = new System.Drawing.Point(3, 3);
            this.teNotes.Name = "teNotes";
            this.teNotes.PlainText = "";
            this.teNotes.RTFCode = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3084{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
                "ans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.teNotes.Size = new System.Drawing.Size(777, 487);
            this.teNotes.TabIndex = 31;
            // 
            // EmployeControl
            // 
            this.Controls.Add(this.tabControlEmploye);
            this.Name = "EmployeControl";
            this.Size = new System.Drawing.Size(791, 519);
            tpFiche.ResumeLayout(false);
            tpFiche.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            tpEtatCivil.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpInfoPaye.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            tpEntreSortie.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControlEmploye.ResumeLayout(false);
            this.tpNotes.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MaskedTextBox txtPhoneOther;
		private System.Windows.Forms.MaskedTextBox txtCodePostal;
		private System.Windows.Forms.MaskedTextBox txtPhoneNumber;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox txtAdressApp;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cbCity;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtAdressStreet;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox mtNAS;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpFirstDay;
		private System.Windows.Forms.DateTimePicker dtpLastDay;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.CheckBox cbLastDay;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TabControl tabControlEmploye;
        private System.Windows.Forms.TabPage tpNotes;
		private System.Windows.Forms.ComboBox cbTitre;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox cbNatureEmploie;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.ComboBox cbSituationFamiliale;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.DateTimePicker dtbDateNaissance;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TabPage tpInfoPaye;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.RadioButton  cbTypeContractuel;
		private System.Windows.Forms.RadioButton cbTypeDirigeant;
		private System.Windows.Forms.RadioButton cbTypeTauxHorraire;
		private UtilityLibrary.WinControls.NumericTextBox ntbAdultACharge;
		private UtilityLibrary.WinControls.NumericTextBox ntbEnfantACharge;
		public UtilityLibrary.WinControls.NumericTextBox txtAdressNumber;
		private CashTextBox ctbSalaire;
		public UtilityLibrary.WinControls.NumericTextBox txtNumeroEmploye;
		private Barette.Library.UserControls.TextEdit.TextEditor teNotes;
	}
}
