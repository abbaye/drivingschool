using System;
using System.ComponentModel;
using System.Windows.Forms;
using Barette.Library.Client;
using Barette.Library.Collections;

namespace Barette.Library.UserControls.Client
{
    /// <summary>
    /// Description résumée de FormSeanceGeneral.
    /// </summary>
    public class FormSeanceTheoriqueMotocyclette : Form
    {		
		/// <summary>
		/// client referer
		/// </summary>
        private readonly Customer _client;
        private IContainer components;
		private SeancePicker seancePicker3;
		private SeancePicker seancePicker2;
        private SeancePicker seancePicker1;
        private Button cmdAnnuler;
        private Button cmdOK;
        private ImageList imageList1;
        private Button cmdPrint;

		private readonly EmployeCollection _ListEmploye;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private readonly ClientControl _ctrlClient;

        public FormSeanceTheoriqueMotocyclette(Customer client, ClientControl ctrl, EmployeCollection ListEmploye)
        {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeanceTheoriqueMotocyclette));
            Barette.Library.Client.Seance seance1 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance2 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance3 = new Barette.Library.Client.Seance();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmdPrint = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.seancePicker3 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker2 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker1 = new Barette.Library.UserControls.SeancePicker();
            this.SuspendLayout();
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAnnuler.Image = global::Barette.Library.Properties.Resources.Cancel_2_icon;
            this.cmdAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAnnuler.Location = new System.Drawing.Point(781, 122);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.Size = new System.Drawing.Size(85, 45);
            this.cmdAnnuler.TabIndex = 32;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAnnuler.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Image = global::Barette.Library.Properties.Resources.accept_icon;
            this.cmdOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdOK.Location = new System.Drawing.Point(680, 122);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(95, 45);
            this.cmdOK.TabIndex = 31;
            this.cmdOK.Text = "Appliquer";
            this.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // cmdPrint
            // 
            this.cmdPrint.ImageIndex = 0;
            this.cmdPrint.ImageList = this.imageList1;
            this.cmdPrint.Location = new System.Drawing.Point(815, 32);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(51, 46);
            this.cmdPrint.TabIndex = 42;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(592, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 47;
            this.label5.Text = "Montant";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 46;
            this.label4.Text = "Heures (fin)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(482, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 45;
            this.label3.Text = "Employé";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "Code";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Date et heure (début)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seancePicker3
            // 
            this.seancePicker3.Absence = false;
            this.seancePicker3.Checked = false;
            this.seancePicker3.Code = "";
            this.seancePicker3.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 551);
            this.seancePicker3.DateModifiedChecked = false;
            this.seancePicker3.Employer = "";
            this.seancePicker3.Location = new System.Drawing.Point(8, 88);
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
            this.seancePicker3.Size = new System.Drawing.Size(790, 25);
            this.seancePicker3.TabIndex = 20;
            // 
            // seancePicker2
            // 
            this.seancePicker2.Absence = false;
            this.seancePicker2.Checked = false;
            this.seancePicker2.Code = "";
            this.seancePicker2.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 571);
            this.seancePicker2.DateModifiedChecked = false;
            this.seancePicker2.Employer = "";
            this.seancePicker2.Location = new System.Drawing.Point(8, 60);
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
            this.seancePicker2.Size = new System.Drawing.Size(790, 25);
            this.seancePicker2.TabIndex = 19;
            // 
            // seancePicker1
            // 
            this.seancePicker1.Absence = false;
            this.seancePicker1.Checked = false;
            this.seancePicker1.Code = "";
            this.seancePicker1.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 581);
            this.seancePicker1.DateModifiedChecked = false;
            this.seancePicker1.Employer = "";
            this.seancePicker1.Location = new System.Drawing.Point(8, 32);
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
            this.seancePicker1.Size = new System.Drawing.Size(790, 25);
            this.seancePicker1.TabIndex = 17;
            // 
            // FormSeanceTheoriqueMotocyclette
            // 
            this.ClientSize = new System.Drawing.Size(878, 179);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdPrint);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.seancePicker3);
            this.Controls.Add(this.seancePicker2);
            this.Controls.Add(this.seancePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSeanceTheoriqueMotocyclette";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Séance de cours théorique : Cyclomoteur et Spyder";
            this.ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, EventArgs e) {
            Close();
		}

		/// <summary>
		/// enregistrement des Seance
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cmdOK_Click(object sender, EventArgs e) 
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
