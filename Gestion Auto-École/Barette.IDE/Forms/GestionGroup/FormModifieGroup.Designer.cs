namespace Barette.IDE.Forms.GestionGroup {
    partial class FormModifieGroup {
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
            this.ntbGroupNumber = new UtilityLibrary.WinControls.NumericTextBox();
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
            this.cmdCancel.Location = new System.Drawing.Point(372, 101);
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
            this.cmdValidate.Location = new System.Drawing.Point(271, 101);
            this.cmdValidate.Name = "cmdValidate";
            this.cmdValidate.Size = new System.Drawing.Size(95, 43);
            this.cmdValidate.TabIndex = 2;
            this.cmdValidate.Text = "Appliquer";
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
            // ntbGroupNumber
            // 
            this.ntbGroupNumber.Enabled = false;
            this.ntbGroupNumber.Location = new System.Drawing.Point(178, 16);
            this.ntbGroupNumber.Name = "ntbGroupNumber";
            this.ntbGroupNumber.SetRange = new System.Drawing.Size(0, 9999999);
            this.ntbGroupNumber.Size = new System.Drawing.Size(100, 20);
            this.ntbGroupNumber.TabIndex = 0;
            this.ntbGroupNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormModifieGroup
            // 
            this.AcceptButton = this.cmdValidate;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(472, 156);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdValidate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.ntbGroupNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormModifieGroup";
            this.Text = "Modification d\'un groupe";
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
    }
}