using System;
using System.ComponentModel;
using System.Windows.Forms;

using Barette.Library.Client;
using Barette.Library.Collections;

namespace Barette.Library.UserControls.Client
{
    /// <summary>
    /// Description r�sum�e de FormSeanceMoto.
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
        private GroupBox groupBox2;
        private readonly EmployeCollection _ListEmploye;

        public FormSeanceMotocyclette(Customer client, ClientControl ctrl, EmployeCollection ListEmploye)
        {
            //
            // Requis pour la prise en charge du Concepteur Windows Forms
            //
            InitializeComponent();

            _client = client;
            _ctrlClient = ctrl;
            _ListEmploye = ListEmploye;

            InitializeSeance();

        }

        /// <summary>
        /// Nettoyage des ressources utilis�es.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                if (components != null)
                    components.Dispose();

            base.Dispose(disposing);
        }

        #region Code g�n�r� par le Concepteur Windows Form
        /// <summary>
        /// M�thode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette m�thode avec l'�diteur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Barette.Library.Client.Seance seance4 = new Barette.Library.Client.Seance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeanceMotocyclette));
            Barette.Library.Client.Seance seance5 = new Barette.Library.Client.Seance();
            Barette.Library.Client.Seance seance6 = new Barette.Library.Client.Seance();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.seancePicker1 = new Barette.Library.UserControls.SeancePicker();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.seancePicker3 = new Barette.Library.UserControls.SeancePicker();
            this.seancePicker2 = new Barette.Library.UserControls.SeancePicker();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.seancePicker1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 90);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Circuit ferm� (3h cyclomoteur / 2h spyder)";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(606, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 45;
            this.label5.Text = "Montant";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 44;
            this.label4.Text = "Heures (fin)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(496, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "Employ�";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Code";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "Date et heure (d�but)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            seance4.Absence = false;
            seance4.Active = false;
            seance4.Code = "";
            seance4.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance4.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 581);
            seance4.DateModifiedChecked = false;
            seance4.Employer = "";
            seance4.Montant = "";
            seance4.SceanceNumber = 1;
            this.seancePicker1.Seance = seance4;
            this.seancePicker1.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker1.Size = new System.Drawing.Size(786, 25);
            this.seancePicker1.TabIndex = 27;
            // 
            // cmdPrint
            // 
            this.cmdPrint.ImageIndex = 0;
            this.cmdPrint.ImageList = this.imageList1;
            this.cmdPrint.Location = new System.Drawing.Point(834, 83);
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
            // seancePicker3
            // 
            this.seancePicker3.Absence = false;
            this.seancePicker3.Checked = false;
            this.seancePicker3.Code = "";
            this.seancePicker3.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 551);
            this.seancePicker3.DateModifiedChecked = false;
            this.seancePicker3.Employer = "";
            this.seancePicker3.Location = new System.Drawing.Point(19, 47);
            this.seancePicker3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.seancePicker3.Name = "seancePicker3";
            this.seancePicker3.NumeroSeance = 3;
            seance5.Absence = false;
            seance5.Active = false;
            seance5.Code = "";
            seance5.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance5.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 551);
            seance5.DateModifiedChecked = false;
            seance5.Employer = "";
            seance5.Montant = "";
            seance5.SceanceNumber = 3;
            this.seancePicker3.Seance = seance5;
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
            this.seancePicker2.Location = new System.Drawing.Point(19, 19);
            this.seancePicker2.Name = "seancePicker2";
            this.seancePicker2.NumeroSeance = 2;
            seance6.Absence = false;
            seance6.Active = false;
            seance6.Code = "";
            seance6.DateHeure = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            seance6.DateModified = new System.DateTime(2005, 2, 27, 8, 25, 29, 571);
            seance6.DateModifiedChecked = false;
            seance6.Employer = "";
            seance6.Montant = "";
            seance6.SceanceNumber = 2;
            this.seancePicker2.Seance = seance6;
            this.seancePicker2.SeanceDateTime = new System.DateTime(2005, 2, 27, 7, 47, 43, 572);
            this.seancePicker2.Size = new System.Drawing.Size(786, 25);
            this.seancePicker2.TabIndex = 29;
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAnnuler.Image = global::Barette.Library.Properties.Resources.Cancel_2_icon;
            this.cmdAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAnnuler.Location = new System.Drawing.Point(800, 216);
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
            this.cmdOK.Location = new System.Drawing.Point(699, 216);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(95, 45);
            this.cmdOK.TabIndex = 29;
            this.cmdOK.Text = "Appliquer";
            this.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.seancePicker2);
            this.groupBox2.Controls.Add(this.seancePicker3);
            this.groupBox2.Location = new System.Drawing.Point(10, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(814, 90);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pratique sur route (2h spyder)";
            // 
            // FormSeanceMotocyclette
            // 
            this.ClientSize = new System.Drawing.Size(893, 271);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSeanceMotocyclette";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S�ance de cours pratique : Cyclomoteur et Spyder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private void cmdCancel_Click(object sender, EventArgs e) => Close();

        private void cmdOK_Click(object sender, EventArgs e)
        {
            //Suppression des seance en cours
            _client.Seances.Clear();

            if (seancePicker1.Checked == true) _client.Seances.Add(seancePicker1.Seance);
            if (seancePicker2.Checked == true) _client.Seances.Add(seancePicker2.Seance);
            if (seancePicker3.Checked == true) _client.Seances.Add(seancePicker3.Seance);

            //Fermer la boite
            Close();
        }

        private void InitializeSeance()
        {
            seancePicker1.ListEmploye = seancePicker2.ListEmploye =
                seancePicker3.ListEmploye = _ListEmploye;

            for (int i = 0; i < _client.Seances.Count; i++)
            {
                switch (_client.Seances[i].SceanceNumber)
                {
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

        private void cmdPrintHorsRoute_Click(object sender, EventArgs e)
        {
            AddSeanceTemp();

            _ctrlClient.Client = _client;
            _ctrlClient.PrintDoc(true, true, false, PrintDocumentType.InfoClient);
        }

        private void AddSeanceTemp()
        {
            _ctrlClient.Client.Seances.Clear();

            _ctrlClient.Client.Seances.Add(seancePicker1.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker2.Seance);
            _ctrlClient.Client.Seances.Add(seancePicker3.Seance);
        }

        private void cmdPrintRoute_Click(object sender, EventArgs e)
        {
            //AddSeanceTemp();
            //this._ctrlClient.Client = this._client;
            //this._ctrlClient.PrintDoc(true, false, true, PrintDocumentType.InfoClient); 
        }

    }
}
