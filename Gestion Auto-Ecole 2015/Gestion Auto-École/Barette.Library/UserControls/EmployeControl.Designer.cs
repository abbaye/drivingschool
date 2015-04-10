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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeControl));
            this.cbTypeContractuel = new System.Windows.Forms.RadioButton();
            this.cbTypeDirigeant = new System.Windows.Forms.RadioButton();
            this.cbTypeTauxHorraire = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControlEmploye = new System.Windows.Forms.TabControl();
            this.tpNotes = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtPhoneOther = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdressNumber = new UtilityLibrary.WinControls.NumericTextBox();
            this.txtCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.txtAdressApp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdressStreet = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.ctbSalaire = new Barette.Library.UserControls.CashTextBox();
            this.cbCity = new Barette.Library.UserControls.ComboCityPicker();
            this.teNotes = new Barette.Library.UserControls.TextEdit.TextEditor();
            tpFiche = new System.Windows.Forms.TabPage();
            tpFiche.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControlEmploye.SuspendLayout();
            this.tpNotes.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tpFiche
            // 
            tpFiche.Controls.Add(this.groupBox2);
            tpFiche.Controls.Add(this.groupBox3);
            tpFiche.Controls.Add(this.groupBox6);
            tpFiche.Controls.Add(this.groupBox1);
            tpFiche.Controls.Add(this.cbNatureEmploie);
            tpFiche.Controls.Add(this.label17);
            tpFiche.Controls.Add(this.cbTitre);
            tpFiche.Controls.Add(this.label13);
            tpFiche.Controls.Add(this.txtNumeroEmploye);
            tpFiche.Controls.Add(this.label14);
            tpFiche.Controls.Add(this.txtName);
            tpFiche.Controls.Add(this.label11);
            tpFiche.Controls.Add(this.txtFirstName);
            tpFiche.Controls.Add(this.label7);
            tpFiche.Location = new System.Drawing.Point(4, 22);
            tpFiche.Name = "tpFiche";
            tpFiche.Padding = new System.Windows.Forms.Padding(3);
            tpFiche.Size = new System.Drawing.Size(650, 462);
            tpFiche.TabIndex = 0;
            tpFiche.Tag = "ETATCIVIL";
            tpFiche.Text = "Fiche";
            // 
            // cbTypeContractuel
            // 
            this.cbTypeContractuel.AutoSize = true;
            this.cbTypeContractuel.Location = new System.Drawing.Point(18, 142);
            this.cbTypeContractuel.Name = "cbTypeContractuel";
            this.cbTypeContractuel.Size = new System.Drawing.Size(79, 17);
            this.cbTypeContractuel.TabIndex = 21;
            this.cbTypeContractuel.Text = "Contractuel";
            // 
            // cbTypeDirigeant
            // 
            this.cbTypeDirigeant.AutoSize = true;
            this.cbTypeDirigeant.Location = new System.Drawing.Point(18, 114);
            this.cbTypeDirigeant.Name = "cbTypeDirigeant";
            this.cbTypeDirigeant.Size = new System.Drawing.Size(67, 17);
            this.cbTypeDirigeant.TabIndex = 20;
            this.cbTypeDirigeant.Text = "Dirigeant";
            // 
            // cbTypeTauxHorraire
            // 
            this.cbTypeTauxHorraire.AutoSize = true;
            this.cbTypeTauxHorraire.Location = new System.Drawing.Point(18, 88);
            this.cbTypeTauxHorraire.Name = "cbTypeTauxHorraire";
            this.cbTypeTauxHorraire.Size = new System.Drawing.Size(92, 17);
            this.cbTypeTauxHorraire.TabIndex = 19;
            this.cbTypeTauxHorraire.Text = "Payé à l\'heure";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cbTypeContractuel);
            this.groupBox3.Controls.Add(this.ctbSalaire);
            this.groupBox3.Controls.Add(this.cbTypeDirigeant);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.cbTypeTauxHorraire);
            this.groupBox3.Location = new System.Drawing.Point(310, 237);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 189);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salaire et status";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 38);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Salaire / heures :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cbLastDay);
            this.groupBox2.Controls.Add(this.dtpLastDay);
            this.groupBox2.Controls.Add(this.dtpFirstDay);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(9, 237);
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
            this.cbLastDay.TabIndex = 13;
            this.cbLastDay.CheckedChanged += new System.EventHandler(this.cbLastDay_CheckedChanged);
            // 
            // dtpLastDay
            // 
            this.dtpLastDay.Enabled = false;
            this.dtpLastDay.Location = new System.Drawing.Point(144, 41);
            this.dtpLastDay.Name = "dtpLastDay";
            this.dtpLastDay.Size = new System.Drawing.Size(136, 20);
            this.dtpLastDay.TabIndex = 14;
            // 
            // dtpFirstDay
            // 
            this.dtpFirstDay.Location = new System.Drawing.Point(144, 14);
            this.dtpFirstDay.Name = "dtpFirstDay";
            this.dtpFirstDay.Size = new System.Drawing.Size(136, 20);
            this.dtpFirstDay.TabIndex = 12;
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
            this.cbNatureEmploie.Location = new System.Drawing.Point(370, 12);
            this.cbNatureEmploie.Name = "cbNatureEmploie";
            this.cbNatureEmploie.Size = new System.Drawing.Size(262, 21);
            this.cbNatureEmploie.Sorted = true;
            this.cbNatureEmploie.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(274, 17);
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
            this.cbTitre.Location = new System.Drawing.Point(101, 39);
            this.cbTitre.Name = "cbTitre";
            this.cbTitre.Size = new System.Drawing.Size(73, 21);
            this.cbTitre.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(5, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 55;
            this.label13.Text = "Titre :";
            // 
            // txtNumeroEmploye
            // 
            this.txtNumeroEmploye.Location = new System.Drawing.Point(101, 14);
            this.txtNumeroEmploye.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.txtNumeroEmploye.Name = "txtNumeroEmploye";
            this.txtNumeroEmploye.SetRange = new System.Drawing.Size(0, 9999999);
            this.txtNumeroEmploye.ShortcutsEnabled = false;
            this.txtNumeroEmploye.Size = new System.Drawing.Size(73, 20);
            this.txtNumeroEmploye.TabIndex = 0;
            this.txtNumeroEmploye.Text = "0";
            this.txtNumeroEmploye.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumeroEmploye.Value = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(6, 17);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Nº employé :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(369, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 20);
            this.txtName.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(5, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Nom :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(101, 67);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(155, 20);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(274, 70);
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
            this.tabControlEmploye.Size = new System.Drawing.Size(658, 488);
            this.tabControlEmploye.TabIndex = 56;
            // 
            // tpNotes
            // 
            this.tpNotes.Controls.Add(this.teNotes);
            this.tpNotes.Location = new System.Drawing.Point(4, 22);
            this.tpNotes.Name = "tpNotes";
            this.tpNotes.Padding = new System.Windows.Forms.Padding(3);
            this.tpNotes.Size = new System.Drawing.Size(650, 462);
            this.tpNotes.TabIndex = 1;
            this.tpNotes.Tag = "NOTES";
            this.tpNotes.Text = "Notes";
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
            this.groupBox6.Location = new System.Drawing.Point(9, 315);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(291, 111);
            this.groupBox6.TabIndex = 61;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Situation et naissance";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 81);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 13);
            this.label22.TabIndex = 65;
            this.label22.Text = "Date naissance :";
            // 
            // dtbDateNaissance
            // 
            this.dtbDateNaissance.Location = new System.Drawing.Point(104, 77);
            this.dtbDateNaissance.Name = "dtbDateNaissance";
            this.dtbDateNaissance.Size = new System.Drawing.Size(140, 20);
            this.dtbDateNaissance.TabIndex = 17;
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
            this.cbSituationFamiliale.Location = new System.Drawing.Point(104, 22);
            this.cbSituationFamiliale.Name = "cbSituationFamiliale";
            this.cbSituationFamiliale.Size = new System.Drawing.Size(140, 21);
            this.cbSituationFamiliale.TabIndex = 15;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 13);
            this.label21.TabIndex = 53;
            this.label21.Text = "Situation familiale :";
            // 
            // mtNAS
            // 
            this.mtNAS.Location = new System.Drawing.Point(104, 51);
            this.mtNAS.Mask = "000 000 000";
            this.mtNAS.Name = "mtNAS";
            this.mtNAS.Size = new System.Drawing.Size(85, 20);
            this.mtNAS.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 54);
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
            this.groupBox5.Location = new System.Drawing.Point(191, 88);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(130, 72);
            this.groupBox5.TabIndex = 60;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Personne à charge";
            // 
            // ntbAdultACharge
            // 
            this.ntbAdultACharge.Location = new System.Drawing.Point(73, 46);
            this.ntbAdultACharge.Name = "ntbAdultACharge";
            this.ntbAdultACharge.SetRange = new System.Drawing.Size(0, 50);
            this.ntbAdultACharge.ShortcutsEnabled = false;
            this.ntbAdultACharge.Size = new System.Drawing.Size(46, 20);
            this.ntbAdultACharge.TabIndex = 23;
            this.ntbAdultACharge.Text = "0";
            this.ntbAdultACharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntbAdultACharge.Value = 0;
            // 
            // ntbEnfantACharge
            // 
            this.ntbEnfantACharge.Location = new System.Drawing.Point(73, 20);
            this.ntbEnfantACharge.Name = "ntbEnfantACharge";
            this.ntbEnfantACharge.SetRange = new System.Drawing.Size(0, 50);
            this.ntbEnfantACharge.ShortcutsEnabled = false;
            this.ntbEnfantACharge.Size = new System.Drawing.Size(46, 20);
            this.ntbEnfantACharge.TabIndex = 22;
            this.ntbEnfantACharge.Text = "0";
            this.ntbEnfantACharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntbEnfantACharge.Value = 0;
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
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(159, 70);
            this.txtPhoneNumber.Mask = "(999)000-0000";
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 10;
            // 
            // txtPhoneOther
            // 
            this.txtPhoneOther.Location = new System.Drawing.Point(159, 98);
            this.txtPhoneOther.Mask = "(999)000-0000";
            this.txtPhoneOther.Name = "txtPhoneOther";
            this.txtPhoneOther.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneOther.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtPhoneOther);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.cbCity);
            this.groupBox1.Controls.Add(this.txtAdressNumber);
            this.groupBox1.Controls.Add(this.txtCodePostal);
            this.groupBox1.Controls.Add(this.txtAdressApp);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAdressStreet);
            this.groupBox1.Location = new System.Drawing.Point(8, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 129);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations sur l\'employé";
            // 
            // txtAdressNumber
            // 
            this.txtAdressNumber.Location = new System.Drawing.Point(180, 16);
            this.txtAdressNumber.Name = "txtAdressNumber";
            this.txtAdressNumber.SetRange = new System.Drawing.Size(0, 9999999);
            this.txtAdressNumber.ShortcutsEnabled = false;
            this.txtAdressNumber.Size = new System.Drawing.Size(65, 20);
            this.txtAdressNumber.TabIndex = 5;
            this.txtAdressNumber.Text = "0";
            this.txtAdressNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAdressNumber.Value = 0;
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(493, 42);
            this.txtCodePostal.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.txtCodePostal.Mask = "L0L-0L0";
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(57, 20);
            this.txtCodePostal.TabIndex = 9;
            // 
            // txtAdressApp
            // 
            this.txtAdressApp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAdressApp.Location = new System.Drawing.Point(576, 14);
            this.txtAdressApp.Name = "txtAdressApp";
            this.txtAdressApp.Size = new System.Drawing.Size(48, 20);
            this.txtAdressApp.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(412, 45);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Code Postale :";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(156, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "No";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(266, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Rue";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(544, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "App.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAdressStreet
            // 
            this.txtAdressStreet.Location = new System.Drawing.Point(304, 15);
            this.txtAdressStreet.Name = "txtAdressStreet";
            this.txtAdressStreet.Size = new System.Drawing.Size(234, 20);
            this.txtAdressStreet.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(49, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Téléphone :";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(49, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 27;
            this.label19.Text = "Adresse:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(49, 45);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 13);
            this.label23.TabIndex = 26;
            this.label23.Text = "Ville :";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(49, 101);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(95, 13);
            this.label25.TabIndex = 29;
            this.label25.Text = "Téléphone (Autre):";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctbSalaire
            // 
            this.ctbSalaire.Location = new System.Drawing.Point(108, 34);
            this.ctbSalaire.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.ctbSalaire.Name = "ctbSalaire";
            this.ctbSalaire.Size = new System.Drawing.Size(75, 20);
            this.ctbSalaire.TabIndex = 18;
            this.ctbSalaire.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.cbCity.Location = new System.Drawing.Point(159, 42);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(239, 20);
            this.cbCity.TabIndex = 8;
            // 
            // teNotes
            // 
            this.teNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teNotes.Location = new System.Drawing.Point(3, 3);
            this.teNotes.Name = "teNotes";
            this.teNotes.PlainText = "";
            this.teNotes.RTFCode = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3084{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
                "ans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.teNotes.Size = new System.Drawing.Size(644, 456);
            this.teNotes.TabIndex = 31;
            // 
            // EmployeControl
            // 
            this.Controls.Add(this.tabControlEmploye);
            this.Name = "EmployeControl";
            this.Size = new System.Drawing.Size(658, 488);
            tpFiche.ResumeLayout(false);
            tpFiche.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControlEmploye.ResumeLayout(false);
            this.tpNotes.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label14;
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
        private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.RadioButton  cbTypeContractuel;
		private System.Windows.Forms.RadioButton cbTypeDirigeant;
        private System.Windows.Forms.RadioButton cbTypeTauxHorraire;
		private CashTextBox ctbSalaire;
		public UtilityLibrary.WinControls.NumericTextBox txtNumeroEmploye;
        private Barette.Library.UserControls.TextEdit.TextEditor teNotes;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker dtbDateNaissance;
        private System.Windows.Forms.ComboBox cbSituationFamiliale;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.MaskedTextBox mtNAS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private UtilityLibrary.WinControls.NumericTextBox ntbAdultACharge;
        private UtilityLibrary.WinControls.NumericTextBox ntbEnfantACharge;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtPhoneNumber;
        private System.Windows.Forms.MaskedTextBox txtPhoneOther;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComboCityPicker cbCity;
        public UtilityLibrary.WinControls.NumericTextBox txtAdressNumber;
        private System.Windows.Forms.MaskedTextBox txtCodePostal;
        private System.Windows.Forms.TextBox txtAdressApp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdressStreet;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
	}
}
