namespace Barette.IDE.Forms {
	partial class FormAjoutEmploye {
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
            Barette.Library.Employer.Employe employe1 = new Barette.Library.Employer.Employe();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.employeControl1 = new Barette.Library.UserControls.EmployeControl();
            this.SuspendLayout();
            // 
            // cmdAdd
            // 
            this.cmdAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAdd.Image = global::Barette.IDE.Properties.Resources.accept_icon;
            this.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAdd.Location = new System.Drawing.Point(459, 515);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(82, 43);
            this.cmdAdd.TabIndex = 1;
            this.cmdAdd.Text = "Ajouter";
            this.cmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Image = global::Barette.IDE.Properties.Resources.Cancel_2_icon;
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancel.Location = new System.Drawing.Point(547, 515);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(83, 43);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Annuler";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // employeControl1
            // 
            this.employeControl1.Employer = employe1;
            this.employeControl1.Location = new System.Drawing.Point(12, 12);
            this.employeControl1.Name = "employeControl1";
            this.employeControl1.Size = new System.Drawing.Size(618, 497);
            this.employeControl1.TabIndex = 0;
            // 
            // FormAjoutEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 564);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.employeControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAjoutEmploye";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un employé";
            this.ResumeLayout(false);

		}

		#endregion

		private Barette.Library.UserControls.EmployeControl employeControl1;
		private System.Windows.Forms.Button cmdAdd;
		private System.Windows.Forms.Button cmdCancel;
	}
}