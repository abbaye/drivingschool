using System;
using System.ComponentModel;
using System.Windows.Forms;

using Barette.Library.Client;
using Barette.Library.Collections;

namespace Barette.Library.UserControls.Client
{
    /// <summary>
    /// Description résumée de FormSeanceMoto.
    /// </summary>
    public class FormSeanceMotocyclette : Form
    {
		/// <summary>
		/// client referer
		/// </summary>
		private readonly Customer _client;
		private readonly ClientControl _ctrlClient;

        private GroupBox groupBox1;
		private SeancePicker seancePicker3;
        private SeancePicker seancePicker2;
        private SeancePicker seancePicker1;
		private Button cmdPrint;
		private ImageList imageList1;
        private IContainer components;
        private Button cmdAnnuler;
        private Button cmdOK;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;

		private readonly EmployeCollection _ListEmploye;

		public FormSeanceMotocyclette(Customer client, ClientControl ctrl, EmployeCollection ListEmploye) {
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

            _client = client;
            _ctrlClient = ctrl;
            _ListEmploye = ListEmploye; 

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
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormSeanceMotocyclette));
            Seance seance1 = new Seance();
            Seance seance2 = new Seance();
            Seance seance3 = new Seance();
            groupBox1 = new GroupBox();
            cmdPrint = new Button();
            imageList1 = new ImageList(components);
            seancePicker3 = new SeancePicker();
            seancePicker2 = new SeancePicker();
            seancePicker1 = new SeancePicker();
            cmdAnnuler = new Button();
            cmdOK = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmdPrint);
            groupBox1.Controls.Add(seancePicker3);
            groupBox1.Controls.Add(seancePicker2);
            groupBox1.Controls.Add(seancePicker1);
            groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            groupBox1.Location = new System.Drawing.Point(10, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(875, 132);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hors route";
            // 
            // cmdPrint
            // 
            cmdPrint.ImageIndex = 0;
            cmdPrint.ImageList = imageList1;
            cmdPrint.Location = new System.Drawing.Point(815, 19);
            cmdPrint.Name = "cmdPrint";
            cmdPrint.Size = new System.Drawing.Size(51, 46);
            cmdPrint.TabIndex = 40;
            cmdPrint.Click += new EventHandler(cmdPrintHorsRoute_Click);
            // 
            // imageList1
            // 
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "");
            // 
            // seancePicker3
            // 
            seancePicker3.Absence = false;
            seancePicker3.Checked = false;
            seancePicker3.Code = "";
            seancePicker3.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 551);
            seancePicker3.DateModifiedChecked = false;
            seancePicker3.Employer = "";
            seancePicker3.Location = new System.Drawing.Point(19, 96);
            seancePicker3.Margin = new Padding(3, 3, 3, 2);
            seancePicker3.Name = "seancePicker3";
            seancePicker3.NumeroSeance = 3;
            seance1.Absence = false;
            seance1.Active = false;
            seance1.Code = "";
            seance1.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance1.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 551);
            seance1.DateModifiedChecked = false;
            seance1.Employer = "";
            seance1.Montant = "";
            seance1.SceanceNumber = 3;
            seancePicker3.Seance = seance1;
            seancePicker3.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker3.Size = new System.Drawing.Size(786, 25);
            seancePicker3.TabIndex = 30;
            // 
            // seancePicker2
            // 
            seancePicker2.Absence = false;
            seancePicker2.Checked = false;
            seancePicker2.Code = "";
            seancePicker2.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 571);
            seancePicker2.DateModifiedChecked = false;
            seancePicker2.Employer = "";
            seancePicker2.Location = new System.Drawing.Point(19, 68);
            seancePicker2.Name = "seancePicker2";
            seancePicker2.NumeroSeance = 2;
            seance2.Absence = false;
            seance2.Active = false;
            seance2.Code = "";
            seance2.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance2.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 571);
            seance2.DateModifiedChecked = false;
            seance2.Employer = "";
            seance2.Montant = "";
            seance2.SceanceNumber = 2;
            seancePicker2.Seance = seance2;
            seancePicker2.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker2.Size = new System.Drawing.Size(786, 25);
            seancePicker2.TabIndex = 29;
            // 
            // seancePicker1
            // 
            seancePicker1.Absence = false;
            seancePicker1.Checked = false;
            seancePicker1.Code = "";
            seancePicker1.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 581);
            seancePicker1.DateModifiedChecked = false;
            seancePicker1.Employer = "";
            seancePicker1.Location = new System.Drawing.Point(19, 40);
            seancePicker1.Name = "seancePicker1";
            seancePicker1.NumeroSeance = 1;
            seance3.Absence = false;
            seance3.Active = false;
            seance3.Code = "";
            seance3.DateHeure = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance3.DateModified = new DateTime(2005, 2, 27, 8, 25, 29, 581);
            seance3.DateModifiedChecked = false;
            seance3.Employer = "";
            seance3.Montant = "";
            seance3.SceanceNumber = 1;
            seancePicker1.Seance = seance3;
            seancePicker1.SeanceDateTime = new DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker1.Size = new System.Drawing.Size(786, 25);
            seancePicker1.TabIndex = 27;
            // 
            // cmdAnnuler
            // 
            cmdAnnuler.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            cmdAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cmdAnnuler.Image = global::Barette.Library.Properties.Resources.Cancel_2_icon;
            cmdAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cmdAnnuler.Location = new System.Drawing.Point(800, 154);
            cmdAnnuler.Name = "cmdAnnuler";
            cmdAnnuler.Size = new System.Drawing.Size(85, 45);
            cmdAnnuler.TabIndex = 30;
            cmdAnnuler.Text = "Annuler";
            cmdAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cmdAnnuler.Click += new EventHandler(cmdCancel_Click);
            // 
            // cmdOK
            // 
            cmdOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            cmdOK.Image = global::Barette.Library.Properties.Resources.accept_icon;
            cmdOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cmdOK.Location = new System.Drawing.Point(699, 154);
            cmdOK.Name = "cmdOK";
            cmdOK.Size = new System.Drawing.Size(95, 45);
            cmdOK.TabIndex = 29;
            cmdOK.Text = "Appliquer";
            cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cmdOK.Click += new EventHandler(cmdOK_Click);
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(606, 15);
            label5.Margin = new Padding(3, 3, 3, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(59, 23);
            label5.TabIndex = 45;
            label5.Text = "Montant";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(289, 14);
            label4.Margin = new Padding(3, 3, 3, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(128, 23);
            label4.TabIndex = 44;
            label4.Text = "Heures (fin)";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(496, 14);
            label3.Margin = new Padding(3, 3, 3, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(97, 23);
            label3.TabIndex = 43;
            label3.Text = "Employé";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(423, 14);
            label2.Margin = new Padding(3, 3, 3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 23);
            label2.TabIndex = 42;
            label2.Text = "Code";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(102, 14);
            label1.Margin = new Padding(3, 3, 3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(200, 23);
            label1.TabIndex = 41;
            label1.Text = "Date et heure (début)";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSeanceMotocyclette
            // 
            ClientSize = new System.Drawing.Size(893, 209);
            ControlBox = false;
            Controls.Add(cmdAnnuler);
            Controls.Add(cmdOK);
            Controls.Add(groupBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "FormSeanceMotocyclette";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Séance de cours pratique : Cyclomoteur";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);

		}
		#endregion

		private void cmdCancel_Click(object sender, EventArgs e) {
            Close();
		}

		private void cmdOK_Click(object sender, EventArgs e) {
            //Suppression des seance en cours
            _client.Seances.Clear();

            if (seancePicker1.Checked == true) _client.Seances.Add(seancePicker1.Seance);
            if (seancePicker2.Checked == true) _client.Seances.Add(seancePicker2.Seance);
            if (seancePicker3.Checked == true) _client.Seances.Add(seancePicker3.Seance);

            //Fermer la boite
            Close();
		}

		private void InitializeSeance() {
			seancePicker1.ListEmploye = seancePicker2.ListEmploye =
				seancePicker3.ListEmploye = _ListEmploye;

            for (int i = 0; i < _client.Seances.Count; i++) {
                switch (_client.Seances[i].SceanceNumber) {
                    case 1:
                        seancePicker1.Seance = _client.Seances[i];
                        break;
                    case 2:
                        seancePicker2.Seance = _client.Seances[i];
                        break;
                    case 3:
                        seancePicker3.Seance = _client.Seances[i];
                        break;
                }
            }
		}

		private void cmdPrintHorsRoute_Click(object sender, EventArgs e) {
			AddSeanceTemp();

            _ctrlClient.Client = _client;
            _ctrlClient.PrintDoc(true, true, false, PrintDocumentType.InfoClient); 
		}

		private void AddSeanceTemp() {
            _ctrlClient.Client.Seances.Clear();

            _ctrlClient.Client.Seances.Add(seancePicker1.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker2.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker3.Seance);
		}

		private void cmdPrintRoute_Click(object sender, EventArgs e) {
            //AddSeanceTemp();
            //this._ctrlClient.Client = this._client;
            //this._ctrlClient.PrintDoc(true, false, true, PrintDocumentType.InfoClient); 
		}

	}
}
