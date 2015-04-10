using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Barette.Library.Client;
using Barette.Library.UserControls.Client;
using Barette.Library.Collections;

namespace Barette.Library.UserControls.Client {
	/// <summary>
	/// Description résumée de FormSeanceMoto.
	/// </summary>
    public class FormSeanceMotocyclette : System.Windows.Forms.Form
    {
		/// <summary>
		/// client referer
		/// </summary>
		private Customer _client;
		private ClientControl _ctrlClient;

        private System.Windows.Forms.GroupBox groupBox1;
		private Barette.Library.UserControls.SeancePicker seancePicker3;
		private Barette.Library.UserControls.SeancePicker seancePicker2;
		private Label label4;
		private Barette.Library.UserControls.SeancePicker seancePicker1;
		private Label label3;
		private Label label2;
        private Label label1;
        private Label label9;
		private Button cmdPrint;
		private ImageList imageList1;
        private IContainer components;
        private Button cmdAnnuler;
        private Button cmdOK;

		private EmployeCollection _ListEmploye;

		public FormSeanceMotocyclette(Customer client, ClientControl ctrl, EmployeCollection ListEmploye) {
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			this._client = client;
			this._ctrlClient = ctrl;
			this._ListEmploye = ListEmploye; 

			InitializeSeance();

            ////Position la fenetre
            //Point p = new Point();
            //p.Y = Screen.PrimaryScreen.WorkingArea.Height - this.Height; 
            //p.X = Screen.PrimaryScreen.WorkingArea.Width - this.Width; 
            //this.Location = p;
			
		}

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeanceMotocyclette));
            Barette.Library.Client.Seance seance1 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance2 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance3 = new Barette.Library.Client.Seance();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.seancePicker3 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker2 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker1 = new Barette.Library.UserControls.SeancePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdPrint);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.seancePicker3);
            this.groupBox1.Controls.Add(this.seancePicker2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.seancePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 132);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hors route";
            // 
            // cmdPrint
            // 
            this.cmdPrint.ImageIndex = 0;
            this.cmdPrint.ImageList = this.imageList1;
            this.cmdPrint.Location = new System.Drawing.Point(815, 19);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(51, 46);
            this.cmdPrint.TabIndex = 40;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrintHorsRoute_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(683, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Montant";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(538, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Modification";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Employé";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Code";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Date et heure";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAnnuler.Image = global::Barette.Library.Properties.Resources.Cancel_2_icon;
            this.cmdAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAnnuler.Location = new System.Drawing.Point(800, 154);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.Size = new System.Drawing.Size(85, 45);
            this.cmdAnnuler.TabIndex = 30;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Image = global::Barette.Library.Properties.Resources.accept_icon;
            this.cmdOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdOK.Location = new System.Drawing.Point(699, 154);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(95, 45);
            this.cmdOK.TabIndex = 29;
            this.cmdOK.Text = "Appliquer";
            this.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // seancePicker3
            // 
            this.seancePicker3.Absence = false;
            this.seancePicker3.Checked = false;
            this.seancePicker3.Code = "";
            this.seancePicker3.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 551);
            this.seancePicker3.DateModifiedChecked = false;
            this.seancePicker3.Employer = "";
            this.seancePicker3.Location = new System.Drawing.Point(19, 96);
            this.seancePicker3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.seancePicker3.Name = "seancePicker3";
            this.seancePicker3.NumeroSeance = 3;
            seance1.Absence = false;
            seance1.Active = false;
            seance1.Code = "";
            seance1.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance1.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 551);
            seance1.DateModifiedChecked = false;
            seance1.Employer = "";
            seance1.Montant = "";
            seance1.SceanceNumber = 3;
            this.seancePicker3.Seance = seance1;
            this.seancePicker3.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker3.Size = new System.Drawing.Size(786, 25);
            this.seancePicker3.TabIndex = 30;
            // 
            // seancePicker2
            // 
            this.seancePicker2.Absence = false;
            this.seancePicker2.Checked = false;
            this.seancePicker2.Code = "";
            this.seancePicker2.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 571);
            this.seancePicker2.DateModifiedChecked = false;
            this.seancePicker2.Employer = "";
            this.seancePicker2.Location = new System.Drawing.Point(19, 68);
            this.seancePicker2.Name = "seancePicker2";
            this.seancePicker2.NumeroSeance = 2;
            seance2.Absence = false;
            seance2.Active = false;
            seance2.Code = "";
            seance2.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance2.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 571);
            seance2.DateModifiedChecked = false;
            seance2.Employer = "";
            seance2.Montant = "";
            seance2.SceanceNumber = 2;
            this.seancePicker2.Seance = seance2;
            this.seancePicker2.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker2.Size = new System.Drawing.Size(786, 25);
            this.seancePicker2.TabIndex = 29;
            // 
            // seancePicker1
            // 
            this.seancePicker1.Absence = false;
            this.seancePicker1.Checked = false;
            this.seancePicker1.Code = "";
            this.seancePicker1.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 581);
            this.seancePicker1.DateModifiedChecked = false;
            this.seancePicker1.Employer = "";
            this.seancePicker1.Location = new System.Drawing.Point(19, 40);
            this.seancePicker1.Name = "seancePicker1";
            this.seancePicker1.NumeroSeance = 1;
            seance3.Absence = false;
            seance3.Active = false;
            seance3.Code = "";
            seance3.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance3.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 581);
            seance3.DateModifiedChecked = false;
            seance3.Employer = "";
            seance3.Montant = "";
            seance3.SceanceNumber = 1;
            this.seancePicker1.Seance = seance3;
            this.seancePicker1.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker1.Size = new System.Drawing.Size(786, 25);
            this.seancePicker1.TabIndex = 27;
            // 
            // FormSeanceMotocyclette
            // 
            this.ClientSize = new System.Drawing.Size(893, 209);
            this.ControlBox = false;
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSeanceMotocyclette";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Séance de cours pratique : Cyclomoteur";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void cmdCancel_Click(object sender, System.EventArgs e) {
			this.Close();
		}

		private void cmdOK_Click(object sender, System.EventArgs e) {
			//Suppression des seance en cours
			this._client.Seances.Clear();

            if (seancePicker1.Checked == true) this._client.Seances.Add(seancePicker1.Seance);
            if (seancePicker2.Checked == true) this._client.Seances.Add(seancePicker2.Seance);
            if (seancePicker3.Checked == true) this._client.Seances.Add(seancePicker3.Seance);

			//Fermer la boite
			this.Close();
		}

		private void InitializeSeance() {
			seancePicker1.ListEmploye = seancePicker2.ListEmploye =
				seancePicker3.ListEmploye = this._ListEmploye;

            for (int i = 0; i < this._client.Seances.Count; i++) {
                switch (this._client.Seances[i].SceanceNumber) {
                    case 1:
                        seancePicker1.Seance = this._client.Seances[i];
                        break;
                    case 2:
                        seancePicker2.Seance = this._client.Seances[i];
                        break;
                    case 3:
                        seancePicker3.Seance = this._client.Seances[i];
                        break;
                }
            }
		}

		private void cmdPrintHorsRoute_Click(object sender, EventArgs e) {
			AddSeanceTemp();
			
			this._ctrlClient.Client = this._client;
			this._ctrlClient.PrintDoc(true, true, false, PrintDocumentType.InfoClient); 
		}

		private void AddSeanceTemp() {
			this._ctrlClient.Client.Seances.Clear();

			this._ctrlClient.Client.Seances.Add(seancePicker1.Seance);
			this._ctrlClient.Client.Seances.Add(seancePicker2.Seance);
			this._ctrlClient.Client.Seances.Add(seancePicker3.Seance);
		}

		private void cmdPrintRoute_Click(object sender, EventArgs e) {
            //AddSeanceTemp();
            //this._ctrlClient.Client = this._client;
            //this._ctrlClient.PrintDoc(true, false, true, PrintDocumentType.InfoClient); 
		}

	}
}
