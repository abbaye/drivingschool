namespace Barette.IDE.Forms.InfoEcole
{
    partial class FormInfoEcole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfoEcole));
            this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.txtStreetNumber = new UtilityLibrary.WinControls.NumericTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.txtSchoolName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbTVQ = new System.Windows.Forms.MaskedTextBox();
            this.mtbTPS = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRegistreIncriptionMoto = new System.Windows.Forms.TextBox();
            this.txtRegistreIncriptionAuto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCourseStreetName = new System.Windows.Forms.TextBox();
            this.txtCourseBatisseName = new System.Windows.Forms.TextBox();
            this.txtCourseCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.txtCourseStreetNumber = new UtilityLibrary.WinControls.NumericTextBox();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtCourseCity = new Barette.Library.UserControls.ComboCityPicker();
            this.cbCity = new Barette.Library.UserControls.ComboCityPicker();
            this.ctbTauxPratique = new Barette.Library.UserControls.CashTextBox();
            this.ctbTauxTheorie = new Barette.Library.UserControls.CashTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(147, 98);
            this.txtPhoneNumber.Mask = "(999)000-0000";
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(459, 72);
            this.txtCodePostal.Mask = "L0L-0L0";
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.ShortcutsEnabled = false;
            this.txtCodePostal.Size = new System.Drawing.Size(56, 20);
            this.txtCodePostal.TabIndex = 4;
            this.txtCodePostal.Leave += new System.EventHandler(this.txtCourseCodePostal_Leave);
            // 
            // txtStreetNumber
            // 
            this.txtStreetNumber.Location = new System.Drawing.Point(147, 46);
            this.txtStreetNumber.MaxLength = 6;
            this.txtStreetNumber.Name = "txtStreetNumber";
            this.txtStreetNumber.SetRange = new System.Drawing.Size(0, 9999999);
            this.txtStreetNumber.ShortcutsEnabled = false;
            this.txtStreetNumber.Size = new System.Drawing.Size(65, 20);
            this.txtStreetNumber.TabIndex = 1;
            this.txtStreetNumber.Text = "0";
            this.txtStreetNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStreetNumber.Value = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Code Postale :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Téléphone :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Adresse:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "No";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rue";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ville :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nom de l\'école :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(251, 46);
            this.txtStreetName.MaxLength = 70;
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(296, 20);
            this.txtStreetName.TabIndex = 2;
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.Location = new System.Drawing.Point(147, 19);
            this.txtSchoolName.MaxLength = 50;
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.Size = new System.Drawing.Size(265, 20);
            this.txtSchoolName.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Fax :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(147, 125);
            this.txtFax.Mask = "(999)000-0000";
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(100, 20);
            this.txtFax.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbTVQ);
            this.groupBox1.Controls.Add(this.mtbTPS);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(50, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numéro de taxe";
            // 
            // mtbTVQ
            // 
            this.mtbTVQ.Location = new System.Drawing.Point(58, 60);
            this.mtbTVQ.Mask = ">0000000000LL0000L";
            this.mtbTVQ.Name = "mtbTVQ";
            this.mtbTVQ.Size = new System.Drawing.Size(115, 20);
            this.mtbTVQ.TabIndex = 13;
            // 
            // mtbTPS
            // 
            this.mtbTPS.Location = new System.Drawing.Point(58, 34);
            this.mtbTPS.Mask = ">000000000LL";
            this.mtbTPS.Name = "mtbTPS";
            this.mtbTPS.Size = new System.Drawing.Size(115, 20);
            this.mtbTPS.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "TVQ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "TPS :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRegistreIncriptionMoto);
            this.groupBox2.Controls.Add(this.txtRegistreIncriptionAuto);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(247, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Régistre d\'inscription";
            // 
            // txtRegistreIncriptionMoto
            // 
            this.txtRegistreIncriptionMoto.Location = new System.Drawing.Point(89, 60);
            this.txtRegistreIncriptionMoto.Name = "txtRegistreIncriptionMoto";
            this.txtRegistreIncriptionMoto.Size = new System.Drawing.Size(100, 20);
            this.txtRegistreIncriptionMoto.TabIndex = 15;
            // 
            // txtRegistreIncriptionAuto
            // 
            this.txtRegistreIncriptionAuto.Location = new System.Drawing.Point(89, 34);
            this.txtRegistreIncriptionAuto.Name = "txtRegistreIncriptionAuto";
            this.txtRegistreIncriptionAuto.Size = new System.Drawing.Size(100, 20);
            this.txtRegistreIncriptionAuto.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Moto :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Automobile :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ctbTauxPratique);
            this.groupBox3.Controls.Add(this.ctbTauxTheorie);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(455, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Taux horaire par défault";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Pratique :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Théorie :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbCity);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtPhoneNumber);
            this.groupBox4.Controls.Add(this.txtStreetName);
            this.groupBox4.Controls.Add(this.txtFax);
            this.groupBox4.Controls.Add(this.txtSchoolName);
            this.groupBox4.Controls.Add(this.txtCodePostal);
            this.groupBox4.Controls.Add(this.txtStreetNumber);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(50, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(571, 157);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informations sur le siège social";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCourseCity);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.txtCourseStreetName);
            this.groupBox5.Controls.Add(this.txtCourseBatisseName);
            this.groupBox5.Controls.Add(this.txtCourseCodePostal);
            this.groupBox5.Controls.Add(this.txtCourseStreetNumber);
            this.groupBox5.Location = new System.Drawing.Point(50, 175);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(571, 117);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Informations sur le lieu de cours de moto en circuit fermé";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Nom de l\'établissement :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(125, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "No";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Adresse:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(218, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "Rue";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "Ville :";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(355, 76);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "Code Postale :";
            // 
            // txtCourseStreetName
            // 
            this.txtCourseStreetName.Location = new System.Drawing.Point(251, 46);
            this.txtCourseStreetName.MaxLength = 70;
            this.txtCourseStreetName.Name = "txtCourseStreetName";
            this.txtCourseStreetName.Size = new System.Drawing.Size(296, 20);
            this.txtCourseStreetName.TabIndex = 9;
            // 
            // txtCourseBatisseName
            // 
            this.txtCourseBatisseName.Location = new System.Drawing.Point(147, 19);
            this.txtCourseBatisseName.MaxLength = 50;
            this.txtCourseBatisseName.Name = "txtCourseBatisseName";
            this.txtCourseBatisseName.Size = new System.Drawing.Size(265, 20);
            this.txtCourseBatisseName.TabIndex = 7;
            // 
            // txtCourseCodePostal
            // 
            this.txtCourseCodePostal.Location = new System.Drawing.Point(459, 73);
            this.txtCourseCodePostal.Mask = "L0L-0L0";
            this.txtCourseCodePostal.Name = "txtCourseCodePostal";
            this.txtCourseCodePostal.ShortcutsEnabled = false;
            this.txtCourseCodePostal.Size = new System.Drawing.Size(56, 20);
            this.txtCourseCodePostal.TabIndex = 11;
            this.txtCourseCodePostal.Leave += new System.EventHandler(this.txtCourseCodePostal_Leave);
            // 
            // txtCourseStreetNumber
            // 
            this.txtCourseStreetNumber.Location = new System.Drawing.Point(147, 46);
            this.txtCourseStreetNumber.MaxLength = 6;
            this.txtCourseStreetNumber.Name = "txtCourseStreetNumber";
            this.txtCourseStreetNumber.SetRange = new System.Drawing.Size(0, 9999999);
            this.txtCourseStreetNumber.ShortcutsEnabled = false;
            this.txtCourseStreetNumber.Size = new System.Drawing.Size(65, 20);
            this.txtCourseStreetNumber.TabIndex = 8;
            this.txtCourseStreetNumber.Text = "0";
            this.txtCourseStreetNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCourseStreetNumber.Value = 0;
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.Image = global::Barette.IDE.Properties.Resources.accept_icon;
            this.cmdOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdOK.Location = new System.Drawing.Point(437, 407);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(91, 41);
            this.cmdOK.TabIndex = 28;
            this.cmdOK.Text = "Appliquer";
            this.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Image = global::Barette.IDE.Properties.Resources.Cancel_2_icon;
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancel.Location = new System.Drawing.Point(534, 407);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(88, 41);
            this.cmdCancel.TabIndex = 27;
            this.cmdCancel.Text = "Annuler";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // txtCourseCity
            // 
            this.txtCourseCity.AutoCompleteCustomSource.AddRange(new string[] {
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
            "La Doré",
            "La Romaine",
            "Labrecque",
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
            "Schefferville",
            "Sept-Iles",
            "Tadoussac",
            "Ville Saguenay"});
            this.txtCourseCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCourseCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCourseCity.Location = new System.Drawing.Point(147, 73);
            this.txtCourseCity.Name = "txtCourseCity";
            this.txtCourseCity.Size = new System.Drawing.Size(200, 20);
            this.txtCourseCity.TabIndex = 10;
            // 
            // cbCity
            // 
            this.cbCity.AutoCompleteCustomSource.AddRange(new string[] {
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
            "La Doré",
            "La Romaine",
            "Labrecque",
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
            "Schefferville",
            "Sept-Iles",
            "Tadoussac",
            "Ville Saguenay"});
            this.cbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbCity.Location = new System.Drawing.Point(147, 71);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(200, 20);
            this.cbCity.TabIndex = 3;
            // 
            // ctbTauxPratique
            // 
            this.ctbTauxPratique.Location = new System.Drawing.Point(90, 60);
            this.ctbTauxPratique.Name = "ctbTauxPratique";
            this.ctbTauxPratique.Size = new System.Drawing.Size(63, 20);
            this.ctbTauxPratique.TabIndex = 17;
            this.ctbTauxPratique.Text = "0,00 $";
            // 
            // ctbTauxTheorie
            // 
            this.ctbTauxTheorie.Location = new System.Drawing.Point(90, 34);
            this.ctbTauxTheorie.Name = "ctbTauxTheorie";
            this.ctbTauxTheorie.Size = new System.Drawing.Size(63, 20);
            this.ctbTauxTheorie.TabIndex = 16;
            this.ctbTauxTheorie.Text = "0,00 $";
            // 
            // FormInfoEcole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(634, 460);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInfoEcole";
            this.ShowInTaskbar = false;
            this.Text = "Informations sur l\'école de conduite";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtPhoneNumber;
        private System.Windows.Forms.MaskedTextBox txtCodePostal;
        public UtilityLibrary.WinControls.NumericTextBox txtStreetNumber;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.TextBox txtSchoolName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtFax;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtbTVQ;
        private System.Windows.Forms.MaskedTextBox mtbTPS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRegistreIncriptionMoto;
        private System.Windows.Forms.TextBox txtRegistreIncriptionAuto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Barette.Library.UserControls.CashTextBox ctbTauxPratique;
        private Barette.Library.UserControls.CashTextBox ctbTauxTheorie;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCourseStreetName;
        private System.Windows.Forms.TextBox txtCourseBatisseName;
        private System.Windows.Forms.MaskedTextBox txtCourseCodePostal;
        public UtilityLibrary.WinControls.NumericTextBox txtCourseStreetNumber;
        private Library.UserControls.ComboCityPicker cbCity;
        private Library.UserControls.ComboCityPicker txtCourseCity;
    }
}