namespace Barette.IDE.Forms.GestionGroup {
    partial class FormAddGroup {
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdValidate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdNumeroAuto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCyclomoteur = new System.Windows.Forms.RadioButton();
            this.cbMoto = new System.Windows.Forms.RadioButton();
            this.cbAutomobile = new System.Windows.Forms.RadioButton();
            this.ntbGroupNumber = new UtilityLibrary.WinControls.NumericTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(178, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(251, 20);
            this.txtName.TabIndex = 1;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Image = global::Barette.IDE.Properties.Resources.Cancel_2_icon;
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancel.Location = new System.Drawing.Point(372, 226);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(88, 43);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Annuler";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdValidate
            // 
            this.cmdValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdValidate.Image = global::Barette.IDE.Properties.Resources.accept_icon;
            this.cmdValidate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdValidate.Location = new System.Drawing.Point(282, 226);
            this.cmdValidate.Name = "cmdValidate";
            this.cmdValidate.Size = new System.Drawing.Size(84, 43);
            this.cmdValidate.TabIndex = 2;
            this.cmdValidate.Text = "Ajouter";
            this.cmdValidate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdValidate.Click += new System.EventHandler(this.cmdValidate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numéro du groupe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom du groupe (Optionnel) :";
            // 
            // cmdNumeroAuto
            // 
            this.cmdNumeroAuto.Location = new System.Drawing.Point(284, 13);
            this.cmdNumeroAuto.Name = "cmdNumeroAuto";
            this.cmdNumeroAuto.Size = new System.Drawing.Size(96, 23);
            this.cmdNumeroAuto.TabIndex = 6;
            this.cmdNumeroAuto.Text = "Automatique";
            this.cmdNumeroAuto.UseVisualStyleBackColor = true;
            this.cmdNumeroAuto.Click += new System.EventHandler(this.cmdNumeroAuto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCyclomoteur);
            this.groupBox1.Controls.Add(this.cbMoto);
            this.groupBox1.Controls.Add(this.cbAutomobile);
            this.groupBox1.Location = new System.Drawing.Point(16, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 117);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type de groupe";
            // 
            // cbCyclomoteur
            // 
            this.cbCyclomoteur.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbCyclomoteur.AutoSize = true;
            this.cbCyclomoteur.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbCyclomoteur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCyclomoteur.Location = new System.Drawing.Point(324, 51);
            this.cbCyclomoteur.Name = "cbCyclomoteur";
            this.cbCyclomoteur.Size = new System.Drawing.Size(89, 18);
            this.cbCyclomoteur.TabIndex = 2;
            this.cbCyclomoteur.Text = "Cyclomoteur";
            this.cbCyclomoteur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbCyclomoteur.UseVisualStyleBackColor = true;
            this.cbCyclomoteur.CheckedChanged += new System.EventHandler(this.cbCyclomoteur_CheckedChanged);
            // 
            // cbMoto
            // 
            this.cbMoto.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbMoto.AutoSize = true;
            this.cbMoto.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbMoto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbMoto.Location = new System.Drawing.Point(170, 51);
            this.cbMoto.Name = "cbMoto";
            this.cbMoto.Size = new System.Drawing.Size(92, 18);
            this.cbMoto.TabIndex = 1;
            this.cbMoto.Text = "Motocyclette";
            this.cbMoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbMoto.UseVisualStyleBackColor = true;
            this.cbMoto.CheckedChanged += new System.EventHandler(this.cbMoto_CheckedChanged);
            // 
            // cbAutomobile
            // 
            this.cbAutomobile.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbAutomobile.AutoSize = true;
            this.cbAutomobile.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAutomobile.Checked = true;
            this.cbAutomobile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbAutomobile.Location = new System.Drawing.Point(28, 51);
            this.cbAutomobile.Name = "cbAutomobile";
            this.cbAutomobile.Size = new System.Drawing.Size(83, 18);
            this.cbAutomobile.TabIndex = 0;
            this.cbAutomobile.TabStop = true;
            this.cbAutomobile.Text = "Automobile";
            this.cbAutomobile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAutomobile.UseVisualStyleBackColor = true;
            this.cbAutomobile.CheckedChanged += new System.EventHandler(this.cbAutomobile_CheckedChanged);
            // 
            // ntbGroupNumber
            // 
            this.ntbGroupNumber.Location = new System.Drawing.Point(178, 16);
            this.ntbGroupNumber.Name = "ntbGroupNumber";
            this.ntbGroupNumber.SetRange = new System.Drawing.Size(0, 9999999);
            this.ntbGroupNumber.Size = new System.Drawing.Size(100, 20);
            this.ntbGroupNumber.TabIndex = 0;
            this.ntbGroupNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormAddGroup
            // 
            this.AcceptButton = this.cmdValidate;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(472, 281);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdNumeroAuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdValidate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.ntbGroupNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddGroup";
            this.Text = "Ajout d\'un groupe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UtilityLibrary.WinControls.NumericTextBox ntbGroupNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdValidate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdNumeroAuto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cbCyclomoteur;
        private System.Windows.Forms.RadioButton cbMoto;
        private System.Windows.Forms.RadioButton cbAutomobile;
    }
}