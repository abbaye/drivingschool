namespace Barette.IDE.Forms.GestionGroup {
    partial class FormGroupSeanceTheorique {
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
            Barette.Library.Client.Seance seance1 = new Barette.Library.Client.Seance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGroupSeanceTheorique));
            this.seancePicker1 = new Barette.Library.UserControls.SeancePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb11 = new System.Windows.Forms.RadioButton();
            this.rb12 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.rb9 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb7 = new System.Windows.Forms.RadioButton();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdAddClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // seancePicker1
            // 
            this.seancePicker1.Absence = false;
            this.seancePicker1.Checked = false;
            this.seancePicker1.Code = "";
            this.seancePicker1.DateModified = new System.DateTime(2010, 6, 29, 18, 17, 37, 434);
            this.seancePicker1.DateModifiedChecked = false;
            this.seancePicker1.Employer = "";
            this.seancePicker1.Location = new System.Drawing.Point(25, 204);
            this.seancePicker1.Name = "seancePicker1";
            this.seancePicker1.NumeroSeance = 1;
            seance1.Absence = false;
            seance1.Active = false;
            seance1.Code = "";
            seance1.DateHeure = new System.DateTime(2010, 6, 29, 18, 17, 37, 441);
            seance1.DateModified = new System.DateTime(2010, 6, 29, 18, 17, 37, 434);
            seance1.DateModifiedChecked = false;
            seance1.Employer = "";
            seance1.Montant = "";
            seance1.SceanceNumber = 1;
            this.seancePicker1.Seance = seance1;
            this.seancePicker1.SeanceDateTime = new System.DateTime(2010, 6, 29, 18, 17, 37, 441);
            this.seancePicker1.Size = new System.Drawing.Size(584, 25);
            this.seancePicker1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 16);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numéro de la séance";
            // 
            // rb1
            // 
            this.rb1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(25, 117);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(23, 23);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Tag = "1";
            this.rb1.Text = "1";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb11
            // 
            this.rb11.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb11.AutoSize = true;
            this.rb11.Location = new System.Drawing.Point(321, 117);
            this.rb11.Name = "rb11";
            this.rb11.Size = new System.Drawing.Size(29, 23);
            this.rb11.TabIndex = 1;
            this.rb11.Tag = "11";
            this.rb11.Text = "11";
            this.rb11.UseVisualStyleBackColor = true;
            this.rb11.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb12
            // 
            this.rb12.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb12.AutoSize = true;
            this.rb12.Location = new System.Drawing.Point(356, 117);
            this.rb12.Name = "rb12";
            this.rb12.Size = new System.Drawing.Size(29, 23);
            this.rb12.TabIndex = 3;
            this.rb12.Tag = "12";
            this.rb12.Text = "12";
            this.rb12.UseVisualStyleBackColor = true;
            this.rb12.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb10
            // 
            this.rb10.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb10.AutoSize = true;
            this.rb10.Location = new System.Drawing.Point(286, 117);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(29, 23);
            this.rb10.TabIndex = 5;
            this.rb10.Tag = "10";
            this.rb10.Text = "10";
            this.rb10.UseVisualStyleBackColor = true;
            this.rb10.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb9
            // 
            this.rb9.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb9.AutoSize = true;
            this.rb9.Location = new System.Drawing.Point(257, 117);
            this.rb9.Name = "rb9";
            this.rb9.Size = new System.Drawing.Size(23, 23);
            this.rb9.TabIndex = 6;
            this.rb9.Tag = "9";
            this.rb9.Text = "9";
            this.rb9.UseVisualStyleBackColor = true;
            this.rb9.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb8
            // 
            this.rb8.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb8.AutoSize = true;
            this.rb8.Location = new System.Drawing.Point(228, 117);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(23, 23);
            this.rb8.TabIndex = 7;
            this.rb8.Tag = "8";
            this.rb8.Text = "8";
            this.rb8.UseVisualStyleBackColor = true;
            this.rb8.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(54, 117);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(23, 23);
            this.rb2.TabIndex = 8;
            this.rb2.Tag = "2";
            this.rb2.Text = "2";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb3
            // 
            this.rb3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(83, 117);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(23, 23);
            this.rb3.TabIndex = 9;
            this.rb3.Tag = "3";
            this.rb3.Text = "3";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb5
            // 
            this.rb5.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(141, 117);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(23, 23);
            this.rb5.TabIndex = 10;
            this.rb5.Tag = "5";
            this.rb5.Text = "5";
            this.rb5.UseVisualStyleBackColor = true;
            this.rb5.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb6
            // 
            this.rb6.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb6.AutoSize = true;
            this.rb6.Location = new System.Drawing.Point(170, 117);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(23, 23);
            this.rb6.TabIndex = 11;
            this.rb6.Tag = "6";
            this.rb6.Text = "6";
            this.rb6.UseVisualStyleBackColor = true;
            this.rb6.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb4
            // 
            this.rb4.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(112, 117);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(23, 23);
            this.rb4.TabIndex = 12;
            this.rb4.Tag = "4";
            this.rb4.Text = "4";
            this.rb4.UseVisualStyleBackColor = true;
            this.rb4.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb7
            // 
            this.rb7.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb7.AutoSize = true;
            this.rb7.Location = new System.Drawing.Point(199, 117);
            this.rb7.Name = "rb7";
            this.rb7.Size = new System.Drawing.Size(23, 23);
            this.rb7.TabIndex = 13;
            this.rb7.Tag = "7";
            this.rb7.Text = "7";
            this.rb7.UseVisualStyleBackColor = true;
            this.rb7.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Image = global::Barette.IDE.Properties.Resources.Cancel_2_icon;
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancel.Location = new System.Drawing.Point(581, 280);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(88, 43);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "Annuler";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdAddClient
            // 
            this.cmdAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAddClient.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAddClient.Image = global::Barette.IDE.Properties.Resources.accept_icon;
            this.cmdAddClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAddClient.Location = new System.Drawing.Point(480, 280);
            this.cmdAddClient.Name = "cmdAddClient";
            this.cmdAddClient.Size = new System.Drawing.Size(95, 43);
            this.cmdAddClient.TabIndex = 4;
            this.cmdAddClient.Text = "Appliquer";
            this.cmdAddClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAddClient.Click += new System.EventHandler(this.cmdAddClient_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(57, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 48);
            this.label1.TabIndex = 16;
            this.label1.Text = "Les modifications faites ici, seront affecté à tous les membres de votre groupe. " +
    " Choisissez un numéro de séance et entré les informations pour la cédule.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 16);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations de la séance sélectionné";
            // 
            // FormGroupSeanceTheorique
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(681, 335);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.rb7);
            this.Controls.Add(this.cmdAddClient);
            this.Controls.Add(this.rb4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rb6);
            this.Controls.Add(this.seancePicker1);
            this.Controls.Add(this.rb5);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb11);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb8);
            this.Controls.Add(this.rb12);
            this.Controls.Add(this.rb9);
            this.Controls.Add(this.rb10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGroupSeanceTheorique";
            this.Text = "Mise à jour : Séance théorique de groupe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Library.UserControls.SeancePicker seancePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb7;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb9;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.RadioButton rb12;
        private System.Windows.Forms.RadioButton rb11;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdAddClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}