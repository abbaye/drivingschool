namespace Barette.Library.UserControls {
	partial class SeancePicker {
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
            this.DateSceance = new System.Windows.Forms.DateTimePicker();
            this.lstEmploye = new System.Windows.Forms.ComboBox();
            this.lstChoice = new System.Windows.Forms.ComboBox();
            this.lblSceanceNumber = new System.Windows.Forms.CheckBox();
            this.DateModifiedPicker = new System.Windows.Forms.DateTimePicker();
            this.cbAbsence = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctbMontantCours = new Barette.Library.UserControls.CashTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // DateSceance
            // 
            this.DateSceance.CustomFormat = "MM/dd/yyyy \'   Heure:\' HH:mm";
            this.DateSceance.Enabled = false;
            this.DateSceance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateSceance.Location = new System.Drawing.Point(87, 3);
            this.DateSceance.Name = "DateSceance";
            this.DateSceance.Size = new System.Drawing.Size(180, 20);
            this.DateSceance.TabIndex = 0;
            // 
            // lstEmploye
            // 
            this.lstEmploye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstEmploye.Enabled = false;
            this.lstEmploye.FormattingEnabled = true;
            this.lstEmploye.Location = new System.Drawing.Point(339, 2);
            this.lstEmploye.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.lstEmploye.Name = "lstEmploye";
            this.lstEmploye.Size = new System.Drawing.Size(117, 21);
            this.lstEmploye.TabIndex = 7;
            // 
            // lstChoice
            // 
            this.lstChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstChoice.Enabled = false;
            this.lstChoice.FormattingEnabled = true;
            this.lstChoice.Location = new System.Drawing.Point(269, 2);
            this.lstChoice.Name = "lstChoice";
            this.lstChoice.Size = new System.Drawing.Size(68, 21);
            this.lstChoice.TabIndex = 6;
            // 
            // lblSceanceNumber
            // 
            this.lblSceanceNumber.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSceanceNumber.Location = new System.Drawing.Point(4, 3);
            this.lblSceanceNumber.Name = "lblSceanceNumber";
            this.lblSceanceNumber.Size = new System.Drawing.Size(83, 16);
            this.lblSceanceNumber.TabIndex = 5;
            this.lblSceanceNumber.Tag = "1";
            this.lblSceanceNumber.Text = "Seance : #";
            this.lblSceanceNumber.CheckedChanged += new System.EventHandler(this.lblSceanceNumber_CheckedChanged);
            // 
            // DateModifiedPicker
            // 
            this.DateModifiedPicker.Checked = false;
            this.DateModifiedPicker.CustomFormat = "MM/dd/yyyy \'   Heure:\' HH:mm";
            this.DateModifiedPicker.Enabled = false;
            this.DateModifiedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateModifiedPicker.Location = new System.Drawing.Point(459, 2);
            this.DateModifiedPicker.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.DateModifiedPicker.Name = "DateModifiedPicker";
            this.DateModifiedPicker.ShowCheckBox = true;
            this.DateModifiedPicker.Size = new System.Drawing.Size(197, 20);
            this.DateModifiedPicker.TabIndex = 8;
            // 
            // cbAbsence
            // 
            this.cbAbsence.AutoSize = true;
            this.cbAbsence.Enabled = false;
            this.cbAbsence.Location = new System.Drawing.Point(722, 4);
            this.cbAbsence.Name = "cbAbsence";
            this.cbAbsence.Size = new System.Drawing.Size(68, 17);
            this.cbAbsence.TabIndex = 9;
            this.cbAbsence.Text = "Absence";
            this.cbAbsence.CheckedChanged += new System.EventHandler(this.cbAbsence_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctbMontantCours
            // 
            this.ctbMontantCours.Enabled = false;
            this.ctbMontantCours.Location = new System.Drawing.Point(658, 2);
            this.ctbMontantCours.Name = "ctbMontantCours";
            this.ctbMontantCours.Size = new System.Drawing.Size(62, 20);
            this.ctbMontantCours.TabIndex = 10;
            // 
            // SeancePicker
            // 
            this.Controls.Add(this.ctbMontantCours);
            this.Controls.Add(this.cbAbsence);
            this.Controls.Add(this.DateModifiedPicker);
            this.Controls.Add(this.lstEmploye);
            this.Controls.Add(this.lstChoice);
            this.Controls.Add(this.DateSceance);
            this.Controls.Add(this.lblSceanceNumber);
            this.Name = "SeancePicker";
            this.Size = new System.Drawing.Size(792, 24);
            this.Resize += new System.EventHandler(this.SeancePicker_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker DateSceance;
		private System.Windows.Forms.ComboBox lstEmploye;
		private System.Windows.Forms.ComboBox lstChoice;
		private System.Windows.Forms.CheckBox lblSceanceNumber;
		private System.Windows.Forms.DateTimePicker DateModifiedPicker;
		private System.Windows.Forms.CheckBox cbAbsence;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private CashTextBox ctbMontantCours;
	}
}
