namespace Barette.IDE.Forms {
    partial class FormClientFind {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientFind));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Véhicule : Manuel", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Véhicule : Cyclomoteur", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Véhicule : Automatique", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Véhicule : Motocyclette", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Cours Terminé", System.Windows.Forms.HorizontalAlignment.Left);
            Barette.Library.Client.Customer customer1 = new Barette.Library.Client.Customer();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdAccept = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtNumeroContrat = new System.Windows.Forms.TextBox();
            this.ImageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.lvClient = new Barette.Library.Listview.ListViewEx();
            this.colhClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhClientNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhClientNoGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientControl1 = new Barette.Library.UserControls.Client.ClientControl();
            this.txtClear = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtGroupNumber = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Image = global::Barette.IDE.Properties.Resources.Cancel_2_icon;
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancel.Location = new System.Drawing.Point(569, 587);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(88, 43);
            this.cmdCancel.TabIndex = 6;
            this.cmdCancel.Text = "Annuler";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdAccept
            // 
            this.cmdAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAccept.Enabled = false;
            this.cmdAccept.Image = global::Barette.IDE.Properties.Resources.accept_icon;
            this.cmdAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAccept.Location = new System.Drawing.Point(479, 587);
            this.cmdAccept.Name = "cmdAccept";
            this.cmdAccept.Size = new System.Drawing.Size(84, 43);
            this.cmdAccept.TabIndex = 5;
            this.cmdAccept.Text = "OK";
            this.cmdAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAccept.Click += new System.EventHandler(this.cmdAccept_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(76, 87);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(483, 20);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // txtNumeroContrat
            // 
            this.txtNumeroContrat.Location = new System.Drawing.Point(12, 87);
            this.txtNumeroContrat.Name = "txtNumeroContrat";
            this.txtNumeroContrat.Size = new System.Drawing.Size(63, 20);
            this.txtNumeroContrat.TabIndex = 0;
            this.txtNumeroContrat.TextChanged += new System.EventHandler(this.txtNumeroContrat_TextChanged);
            // 
            // ImageListSmall
            // 
            this.ImageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListSmall.ImageStream")));
            this.ImageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListSmall.Images.SetKeyName(0, "Moto");
            this.ImageListSmall.Images.SetKeyName(1, "auto.ico");
            this.ImageListSmall.Images.SetKeyName(2, "Camion.ico");
            // 
            // lvClient
            // 
            this.lvClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colhClientName,
            this.colhClientNumber,
            this.colhClientNoGroup});
            this.lvClient.FullRowSelect = true;
            listViewGroup1.Header = "Véhicule : Manuel";
            listViewGroup1.Name = "Manuel";
            listViewGroup2.Header = "Véhicule : Cyclomoteur";
            listViewGroup2.Name = "Camion";
            listViewGroup3.Header = "Véhicule : Automatique";
            listViewGroup3.Name = "Automatique";
            listViewGroup4.Header = "Véhicule : Motocyclette";
            listViewGroup4.Name = "Moto";
            listViewGroup5.Header = "Cours Terminé";
            listViewGroup5.Name = "CoursTermine";
            this.lvClient.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
            this.lvClient.HideSelection = false;
            this.lvClient.Location = new System.Drawing.Point(12, 113);
            this.lvClient.MultiSelect = false;
            this.lvClient.Name = "lvClient";
            this.lvClient.ShowItemToolTips = true;
            this.lvClient.Size = new System.Drawing.Size(645, 293);
            this.lvClient.SmallImageList = this.ImageListSmall;
            this.lvClient.TabIndex = 4;
            this.lvClient.UseCompatibleStateImageBehavior = false;
            this.lvClient.View = System.Windows.Forms.View.Details;
            this.lvClient.SelectedIndexChanged += new System.EventHandler(this.lvClient_SelectedIndexChanged);
            this.lvClient.DoubleClick += new System.EventHandler(this.lvClient_DoubleClick);
            // 
            // colhClientName
            // 
            this.colhClientName.DisplayIndex = 1;
            this.colhClientName.Text = "Nom";
            this.colhClientName.Width = 484;
            // 
            // colhClientNumber
            // 
            this.colhClientNumber.DisplayIndex = 0;
            this.colhClientNumber.Text = "#Contrat";
            this.colhClientNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colhClientNumber.Width = 61;
            // 
            // colhClientNoGroup
            // 
            this.colhClientNoGroup.Text = "Nº Groupe";
            this.colhClientNoGroup.Width = 69;
            // 
            // clientControl1
            // 
            this.clientControl1.AutoUpdate = true;
            this.clientControl1.BackColor = System.Drawing.SystemColors.Control;
            customer1.AttestationNumber1 = "0";
            customer1.AttestationNumber2 = "0";
            customer1.BVA = false;
            customer1.BVADate = new System.DateTime(2010, 10, 2, 15, 17, 42, 41);
            customer1.City = "";
            customer1.ClientNull = false;
            customer1.CodePostal = "   -";
            customer1.ContratNumber = "0";
            customer1.DateAttestation1 = new System.DateTime(2010, 5, 26, 14, 42, 36, 938);
            customer1.DateAttestation2 = new System.DateTime(2010, 5, 26, 14, 42, 36, 938);
            customer1.DateDebutCours = new System.DateTime(2003, 8, 26, 0, 0, 0, 0);
            customer1.DateExpiration = new System.DateTime(2003, 8, 26, 0, 0, 0, 0);
            customer1.DateInscription = new System.DateTime(2003, 8, 26, 0, 0, 0, 0);
            customer1.DateNaissance = new System.DateTime(2010, 10, 2, 15, 17, 42, 92);
            customer1.DateTemporaire = new System.DateTime(2010, 10, 2, 15, 17, 42, 37);
            customer1.DisponibilityAlway = false;
            customer1.DisponibilityAM = false;
            customer1.DisponibilityDimanche = false;
            customer1.DisponibilityPM = false;
            customer1.DisponibilitySamedi = false;
            customer1.DisponibilitySoirer = false;
            customer1.Email = "";
            customer1.FirstName = "";
            customer1.HaveTemporaire = false;
            customer1.LastRecuNumber = "0";
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
            customer1.StreetNumber = "0";
            customer1.TauxHorairePratique = "0 $";
            customer1.TauxHoraireTheorique = "0 $";
            customer1.TypeClient = Barette.Library.Client.ProfileType.Actif;
            customer1.TypeVehicule = Barette.Library.Client.VehiculeType.Automatique;
            this.clientControl1.Client = customer1;
            this.clientControl1.Enabled = false;
            this.clientControl1.Location = new System.Drawing.Point(12, 303);
            this.clientControl1.Name = "clientControl1";
            this.clientControl1.School = null;
            this.clientControl1.Size = new System.Drawing.Size(645, 272);
            this.clientControl1.TabIndex = 8;
            this.clientControl1.TabStop = false;
            // 
            // txtClear
            // 
            this.txtClear.Location = new System.Drawing.Point(637, 88);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(20, 20);
            this.txtClear.TabIndex = 3;
            this.txtClear.Text = "X";
            this.toolTip1.SetToolTip(this.txtClear, "Supprimer le text de recherche");
            this.txtClear.UseVisualStyleBackColor = true;
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(64, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Inscrivez le texte à rechercher dans l’une des cases si dessous. \r\nSi vous n’insc" +
                "rivez aucun texte, tous les clients apparaîtront dans la zone de recherche. ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtGroupNumber
            // 
            this.txtGroupNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGroupNumber.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtGroupNumber.FormattingEnabled = true;
            this.txtGroupNumber.Location = new System.Drawing.Point(560, 87);
            this.txtGroupNumber.Name = "txtGroupNumber";
            this.txtGroupNumber.Size = new System.Drawing.Size(68, 21);
            this.txtGroupNumber.TabIndex = 13;
            this.txtGroupNumber.SelectedIndexChanged += new System.EventHandler(this.txtGroupNumber_TextChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 67);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(14, 13);
            this.lblResult.TabIndex = 14;
            this.lblResult.Text = "#";
            // 
            // FormClientFind
            // 
            this.AcceptButton = this.cmdAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(669, 641);
            this.ControlBox = false;
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtGroupNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtClear);
            this.Controls.Add(this.lvClient);
            this.Controls.Add(this.clientControl1);
            this.Controls.Add(this.txtNumeroContrat);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdAccept);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormClientFind";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recherche de clients";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdAccept;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtNumeroContrat;
        private System.Windows.Forms.ImageList ImageListSmall;
        private Library.Listview.ListViewEx lvClient;
        private System.Windows.Forms.ColumnHeader colhClientName;
        private System.Windows.Forms.ColumnHeader colhClientNumber;
        private System.Windows.Forms.ColumnHeader colhClientNoGroup;
        private Library.UserControls.Client.ClientControl clientControl1;
        private System.Windows.Forms.Button txtClear;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox txtGroupNumber;
        private System.Windows.Forms.Label lblResult;
    }
}