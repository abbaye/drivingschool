namespace Barette.IDE.Forms.Notes {
	partial class FormAddEditPostIt {
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditPostIt));
            this.cmdClose = new System.Windows.Forms.Button();
            this.cbAlerte = new System.Windows.Forms.CheckBox();
            this.DateTimeAlerte = new System.Windows.Forms.DateTimePicker();
            this.DatePostIt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdClose.Enabled = false;
            this.cmdClose.Image = global::Barette.IDE.Properties.Resources.accept_icon;
            this.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdClose.Location = new System.Drawing.Point(416, 446);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(96, 44);
            this.cmdClose.TabIndex = 1;
            this.cmdClose.Text = "Fermer";
            this.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbAlerte
            // 
            this.cbAlerte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAlerte.AutoSize = true;
            this.cbAlerte.Location = new System.Drawing.Point(13, 419);
            this.cbAlerte.Name = "cbAlerte";
            this.cbAlerte.Size = new System.Drawing.Size(53, 17);
            this.cbAlerte.TabIndex = 2;
            this.cbAlerte.Text = "Alerte";
            this.cbAlerte.CheckedChanged += new System.EventHandler(this.cbAlerte_CheckedChanged);
            // 
            // DateTimeAlerte
            // 
            this.DateTimeAlerte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DateTimeAlerte.CustomFormat = "ddd MM/dd/yyyy \'        Heure:\' HH:mm";
            this.DateTimeAlerte.Enabled = false;
            this.DateTimeAlerte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeAlerte.Location = new System.Drawing.Point(69, 417);
            this.DateTimeAlerte.Name = "DateTimeAlerte";
            this.DateTimeAlerte.Size = new System.Drawing.Size(235, 20);
            this.DateTimeAlerte.TabIndex = 3;
            // 
            // DatePostIt
            // 
            this.DatePostIt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePostIt.CustomFormat = "ddd MM/dd/yyyy \'";
            this.DatePostIt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePostIt.Location = new System.Drawing.Point(356, 68);
            this.DatePostIt.Name = "DatePostIt";
            this.DatePostIt.Size = new System.Drawing.Size(157, 20);
            this.DatePostIt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date :";
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.BackColor = System.Drawing.SystemColors.Window;
            this.txtMessage.Location = new System.Drawing.Point(13, 94);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(499, 309);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 79);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormAddEditPostIt
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(525, 502);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatePostIt);
            this.Controls.Add(this.DateTimeAlerte);
            this.Controls.Add(this.cbAlerte);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.txtMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddEditPostIt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Notes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdClose;
		private System.Windows.Forms.CheckBox cbAlerte;
		private System.Windows.Forms.DateTimePicker DateTimeAlerte;
		private System.Windows.Forms.DateTimePicker DatePostIt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
	}
}