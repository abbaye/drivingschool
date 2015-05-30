using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Barette.Library.UserControls;
using Barette.Library.Client;
using Barette.Library.Collections;

namespace Barette.Library.UserControls.Client {
	/// <summary>
	/// Description résumée de FormSeanceGeneral.
	/// </summary>
	public class FormSeanceTheoriqueMoto : System.Windows.Forms.Form {		
		/// <summary>
		/// client referer
		/// </summary>
        private Customer _client;
        private ClientControl _ctrlClient;

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private Label label4;
        private Label label5;
        private IContainer components;
		private SeancePicker seancePicker3;
		private SeancePicker seancePicker2;
        private SeancePicker seancePicker1;
        private Button cmdAnnuler;
        private Button cmdOK;
        private ImageList imageList1;
        private Button cmdPrint;

		private EmployeCollection _ListEmploye;

        public FormSeanceTheoriqueMoto(Customer client, ClientControl ctrl,  EmployeCollection ListEmploye) {
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

            _client = client;
            _ctrlClient = ctrl;
            _ListEmploye = ListEmploye;

			InitializeSeance();
			
            ////teste
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeanceTheoriqueMoto));
            Barette.Library.Client.Seance seance1 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance2 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance3 = new Barette.Library.Client.Seance();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            cmdAnnuler = new System.Windows.Forms.Button();
            cmdOK = new System.Windows.Forms.Button();
            imageList1 = new System.Windows.Forms.ImageList(components);
            cmdPrint = new System.Windows.Forms.Button();
            seancePicker3 = new Barette.Library.UserControls.SeancePicker();
            seancePicker2 = new Barette.Library.UserControls.SeancePicker();
            seancePicker1 = new Barette.Library.UserControls.SeancePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(88, 5);
            label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(200, 23);
            label1.TabIndex = 14;
            label1.Text = "Date et heure (début)";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(409, 5);
            label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 23);
            label2.TabIndex = 15;
            label2.Text = "Code";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(482, 5);
            label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(97, 23);
            label3.TabIndex = 16;
            label3.Text = "Employé";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(275, 5);
            label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(128, 23);
            label4.TabIndex = 18;
            label4.Text = "Heures (fin)";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(592, 6);
            label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(59, 23);
            label5.TabIndex = 30;
            label5.Text = "Montant";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdAnnuler
            // 
            cmdAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            cmdAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cmdAnnuler.Image = global::Barette.Library.Properties.Resources.Cancel_2_icon;
            cmdAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cmdAnnuler.Location = new System.Drawing.Point(780, 122);
            cmdAnnuler.Name = "cmdAnnuler";
            cmdAnnuler.Size = new System.Drawing.Size(85, 45);
            cmdAnnuler.TabIndex = 32;
            cmdAnnuler.Text = "Annuler";
            cmdAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cmdAnnuler.Click += new System.EventHandler(button2_Click);
            // 
            // cmdOK
            // 
            cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            cmdOK.Image = global::Barette.Library.Properties.Resources.accept_icon;
            cmdOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cmdOK.Location = new System.Drawing.Point(679, 122);
            cmdOK.Name = "cmdOK";
            cmdOK.Size = new System.Drawing.Size(95, 45);
            cmdOK.TabIndex = 31;
            cmdOK.Text = "Appliquer";
            cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cmdOK.Click += new System.EventHandler(cmdOK_Click);
            // 
            // imageList1
            // 
            imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "");
            // 
            // cmdPrint
            // 
            cmdPrint.ImageIndex = 0;
            cmdPrint.ImageList = imageList1;
            cmdPrint.Location = new System.Drawing.Point(814, 32);
            cmdPrint.Name = "cmdPrint";
            cmdPrint.Size = new System.Drawing.Size(51, 46);
            cmdPrint.TabIndex = 43;
            cmdPrint.Click += new System.EventHandler(cmdPrint_Click);
            // 
            // seancePicker3
            // 
            seancePicker3.Absence = false;
            seancePicker3.Checked = false;
            seancePicker3.Code = "";
            seancePicker3.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 551);
            seancePicker3.DateModifiedChecked = false;
            seancePicker3.Employer = "";
            seancePicker3.Location = new System.Drawing.Point(8, 88);
            seancePicker3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            seancePicker3.Name = "seancePicker3";
            seancePicker3.NumeroSeance = 3;
            seance1.Absence = false;
            seance1.Active = false;
            seance1.Code = "";
            seance1.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance1.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 551);
            seance1.DateModifiedChecked = false;
            seance1.Employer = "";
            seance1.Montant = "";
            seance1.SceanceNumber = 3;
            seancePicker3.Seance = seance1;
            seancePicker3.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker3.Size = new System.Drawing.Size(790, 25);
            seancePicker3.TabIndex = 20;
            // 
            // seancePicker2
            // 
            seancePicker2.Absence = false;
            seancePicker2.Checked = false;
            seancePicker2.Code = "";
            seancePicker2.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 571);
            seancePicker2.DateModifiedChecked = false;
            seancePicker2.Employer = "";
            seancePicker2.Location = new System.Drawing.Point(8, 60);
            seancePicker2.Name = "seancePicker2";
            seancePicker2.NumeroSeance = 2;
            seance2.Absence = false;
            seance2.Active = false;
            seance2.Code = "";
            seance2.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance2.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 571);
            seance2.DateModifiedChecked = false;
            seance2.Employer = "";
            seance2.Montant = "";
            seance2.SceanceNumber = 2;
            seancePicker2.Seance = seance2;
            seancePicker2.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker2.Size = new System.Drawing.Size(790, 25);
            seancePicker2.TabIndex = 19;
            // 
            // seancePicker1
            // 
            seancePicker1.Absence = false;
            seancePicker1.Checked = false;
            seancePicker1.Code = "";
            seancePicker1.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 581);
            seancePicker1.DateModifiedChecked = false;
            seancePicker1.Employer = "";
            seancePicker1.Location = new System.Drawing.Point(8, 32);
            seancePicker1.Name = "seancePicker1";
            seancePicker1.NumeroSeance = 1;
            seance3.Absence = false;
            seance3.Active = false;
            seance3.Code = "";
            seance3.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance3.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 581);
            seance3.DateModifiedChecked = false;
            seance3.Employer = "";
            seance3.Montant = "";
            seance3.SceanceNumber = 1;
            seancePicker1.Seance = seance3;
            seancePicker1.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seancePicker1.Size = new System.Drawing.Size(790, 25);
            seancePicker1.TabIndex = 17;
            // 
            // FormSeanceTheoriqueMoto
            // 
            ClientSize = new System.Drawing.Size(877, 179);
            ControlBox = false;
            Controls.Add(cmdPrint);
            Controls.Add(cmdAnnuler);
            Controls.Add(cmdOK);
            Controls.Add(label5);
            Controls.Add(seancePicker3);
            Controls.Add(seancePicker2);
            Controls.Add(label4);
            Controls.Add(seancePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSeanceTheoriqueMoto";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Séance de cours théorique : Motocyclette";
            ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e) {
            Close();
		}

		/// <summary>
		/// enregistrement des Seance
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cmdOK_Click(object sender, System.EventArgs e) 
		{
            //Suppression des seance en cours
            _client.SeancesTheorique.Clear();
			
            if (seancePicker1.Checked == true) _client.SeancesTheorique.Add(seancePicker1.Seance);
            if (seancePicker2.Checked == true) _client.SeancesTheorique.Add(seancePicker2.Seance);
            if (seancePicker3.Checked == true) _client.SeancesTheorique.Add(seancePicker3.Seance);

            //Fermer la boite
            Close();
		}

		private void InitializeSeance() {
            //Chargement de la liste des employés
			seancePicker1.ListEmploye = seancePicker2.ListEmploye =
					seancePicker3.ListEmploye = _ListEmploye;

            for (int i = 0; i < _client.SeancesTheorique.Count; i++) {
                switch (_client.SeancesTheorique[i].SceanceNumber) {
                    case 1:
                        seancePicker1.Seance = _client.SeancesTheorique[i];
                        break;
                    case 2:
                        seancePicker2.Seance = _client.SeancesTheorique[i];
                        break;
                    case 3:
                        seancePicker3.Seance = _client.SeancesTheorique[i];
                        break;                    
                }
            }
		}

        private void AddSeanceTemp() {
            _ctrlClient.Client.SeancesTheorique.Clear();

            _ctrlClient.Client.SeancesTheorique.Add(seancePicker1.Seance);
            _ctrlClient.Client.SeancesTheorique.Add(seancePicker2.Seance);
            _ctrlClient.Client.SeancesTheorique.Add(seancePicker3.Seance);
        }

        private void cmdPrint_Click(object sender, EventArgs e) {
            AddSeanceTemp();

            _ctrlClient.Client = _client;
            _ctrlClient.PrintDoc(true, true, true, PrintDocumentType.InfoClientTheorique);
        }
	}
}
