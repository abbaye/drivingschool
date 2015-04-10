namespace Barette.Library.Forms {
	partial class AlertForm {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertForm));
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.lblText = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.cmdClose = new System.Windows.Forms.Button();
			this.cbRappelle = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmdRappelle = new System.Windows.Forms.Button();
			this.lblDate = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.Images.SetKeyName(0, "");
			this.imageList1.Images.SetKeyName(1, "");
			this.imageList1.Images.SetKeyName(2, "");
			// 
			// lblText
			// 
			this.lblText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblText.BackColor = System.Drawing.SystemColors.Window;
			this.lblText.Location = new System.Drawing.Point(76, 29);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(463, 131);
			this.lblText.TabIndex = 8;
			this.lblText.Text = "message";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = Barette.Library.Properties.Resources.stylish8;
			this.pictureBox1.Location = new System.Drawing.Point(13, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 48);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// cmdClose
			// 
			this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdClose.Location = new System.Drawing.Point(446, 216);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.Size = new System.Drawing.Size(93, 23);
			this.cmdClose.TabIndex = 10;
			this.cmdClose.Text = "Faire disparaître";
			this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
			// 
			// cbRappelle
			// 
			this.cbRappelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cbRappelle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbRappelle.FormattingEnabled = true;
			this.cbRappelle.Items.AddRange(new object[] {
            "1 minute",
            "5 minutes",
            "10 minutes",
            "30 minutes",
            "1 heure",
            "2 heures",
            "5 heures",
            "1 jour",
            "2 jours"});
			this.cbRappelle.Location = new System.Drawing.Point(308, 175);
			this.cbRappelle.Name = "cbRappelle";
			this.cbRappelle.Size = new System.Drawing.Size(132, 21);
			this.cbRappelle.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(224, 178);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Rappeler dans :";
			// 
			// cmdRappelle
			// 
			this.cmdRappelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdRappelle.Location = new System.Drawing.Point(446, 173);
			this.cmdRappelle.Name = "cmdRappelle";
			this.cmdRappelle.Size = new System.Drawing.Size(93, 23);
			this.cmdRappelle.TabIndex = 13;
			this.cmdRappelle.Text = "Rappelle";
			this.cmdRappelle.Click += new System.EventHandler(this.cmdRappelle_Click);
			// 
			// lblDate
			// 
			this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDate.Location = new System.Drawing.Point(300, 9);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(239, 15);
			this.lblDate.TabIndex = 14;
			this.lblDate.Text = "-";
			this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// AlertForm
			// 
			this.AcceptButton = this.cmdClose;
			this.CancelButton = this.cmdClose;
			this.ClientSize = new System.Drawing.Size(551, 251);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.cmdRappelle);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbRappelle);
			this.Controls.Add(this.cmdClose);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AlertForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Alerte";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label lblText;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button cmdClose;
		private System.Windows.Forms.ComboBox cbRappelle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmdRappelle;
		private System.Windows.Forms.Label lblDate;
	}
}