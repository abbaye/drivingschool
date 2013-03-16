namespace Barette.Library.UserControls.Schedule {
	partial class ScheduleControl {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTotalCours = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewEx1 = new Barette.Library.Listview.ListViewEx();
            this.colHeadHours = new System.Windows.Forms.ColumnHeader();
            this.colHeadContratNumber = new System.Windows.Forms.ColumnHeader();
            this.colHeadClientName = new System.Windows.Forms.ColumnHeader();
            this.colHeadSeanceNumber = new System.Windows.Forms.ColumnHeader();
            this.colHeadSeanceCode = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(0, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDate.Size = new System.Drawing.Size(281, 23);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "-";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCours
            // 
            this.lblTotalCours.AutoSize = true;
            this.lblTotalCours.Location = new System.Drawing.Point(3, 38);
            this.lblTotalCours.Name = "lblTotalCours";
            this.lblTotalCours.Size = new System.Drawing.Size(10, 13);
            this.lblTotalCours.TabIndex = 2;
            this.lblTotalCours.Text = "-";
            // 
            // txtNotes
            // 
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNotes.Enabled = false;
            this.txtNotes.Location = new System.Drawing.Point(0, 273);
            this.txtNotes.MaxLength = 250;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(281, 98);
            this.txtNotes.TabIndex = 22;
            this.txtNotes.Visible = false;
            this.txtNotes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNotes_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(0, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Notes (imprimable)";
            this.label2.Visible = false;
            // 
            // listViewEx1
            // 
            this.listViewEx1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewEx1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadHours,
            this.colHeadContratNumber,
            this.colHeadClientName,
            this.colHeadSeanceNumber,
            this.colHeadSeanceCode});
            this.listViewEx1.FullRowSelect = true;
            this.listViewEx1.Location = new System.Drawing.Point(0, 54);
            this.listViewEx1.MultiSelect = false;
            this.listViewEx1.Name = "listViewEx1";
            this.listViewEx1.Size = new System.Drawing.Size(281, 317);
            this.listViewEx1.TabIndex = 3;
            this.listViewEx1.UseCompatibleStateImageBehavior = false;
            this.listViewEx1.View = System.Windows.Forms.View.Details;
            this.listViewEx1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewEx1_MouseDoubleClick);
            this.listViewEx1.SelectedIndexChanged += new System.EventHandler(this.listViewEx1_SelectedIndexChanged);
            // 
            // colHeadHours
            // 
            this.colHeadHours.Text = "Heures";
            this.colHeadHours.Width = 50;
            // 
            // colHeadContratNumber
            // 
            this.colHeadContratNumber.Text = "# Contrat";
            this.colHeadContratNumber.Width = 0;
            // 
            // colHeadClientName
            // 
            this.colHeadClientName.Text = "Nom du Client";
            this.colHeadClientName.Width = 125;
            // 
            // colHeadSeanceNumber
            // 
            this.colHeadSeanceNumber.Text = "#Seance";
            this.colHeadSeanceNumber.Width = 30;
            // 
            // colHeadSeanceCode
            // 
            this.colHeadSeanceCode.Text = "Code seance";
            this.colHeadSeanceCode.Width = 50;
            // 
            // ScheduleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewEx1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalCours);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtNotes);
            this.Name = "ScheduleControl";
            this.Size = new System.Drawing.Size(281, 371);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Label lblTotalCours;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.Label label2;
		private Barette.Library.Listview.ListViewEx listViewEx1;
		private System.Windows.Forms.ColumnHeader colHeadHours;
		private System.Windows.Forms.ColumnHeader colHeadContratNumber;
		private System.Windows.Forms.ColumnHeader colHeadClientName;
		private System.Windows.Forms.ColumnHeader colHeadSeanceNumber;
		private System.Windows.Forms.ColumnHeader colHeadSeanceCode;
	}
}
