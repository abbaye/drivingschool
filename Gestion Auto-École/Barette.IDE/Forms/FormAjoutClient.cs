using System;
using System.Windows.Forms;
using Barette.Library;
using Barette.Library.Client;

namespace Barette.IDE.Forms {
    /// <summary>
    /// Description résumée de FormAjoutClient.
    /// </summary>
    public class FormAjoutClient : System.Windows.Forms.Form {
        /// <summary>
        /// Fenetre principal
        /// </summary>
        private FormClients _formClients = null;
        private SchoolInfo _infoEcole = null;
        private Config _AppConfig = null;

        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdAddClient;
        public Barette.Library.UserControls.Client.ClientControl clientControl1;
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public FormAjoutClient(FormClients clientForm, SchoolInfo infoEcole, Config AppConfig) {
            //
            // Requis pour la prise en charge du Concepteur Windows Forms
            //
            InitializeComponent();

            //cree un access a la dialog principal de l'application
            this._formClients = clientForm;
            this._infoEcole = infoEcole;
            this._AppConfig = AppConfig;

            this.clientControl1.Now();

            //Numero de contrat
            Customer client = clientControl1.Client;
            client.ContratNumber = (AppConfig.LastContractNumber + 1).ToString();

            //Taux horaire par default
            client.TauxHorairePratique = _infoEcole.TauxHorairePratique;
            client.TauxHoraireTheorique = _infoEcole.TauxHoraireTheorie;

            this.clientControl1.Client = client;
        }

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            Barette.Library.Client.Customer customer1 = new Barette.Library.Client.Customer();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.clientControl1 = new Barette.Library.UserControls.Client.ClientControl();
            this.cmdAddClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Image = global::Barette.IDE.Properties.Resources.Cancel_2_icon;
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancel.Location = new System.Drawing.Point(557, 546);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(88, 43);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Annuler";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // clientControl1
            // 
            this.clientControl1.AutoScroll = true;
            this.clientControl1.AutoUpdate = true;
            this.clientControl1.BackColor = System.Drawing.SystemColors.Control;
            customer1.AttestationNumber1 = "";
            customer1.AttestationNumber2 = "";
            customer1.BVA = false;
            customer1.BVADate = new System.DateTime(2010, 3, 14, 19, 59, 19, 434);
            customer1.City = "";
            customer1.ClientNull = false;
            customer1.CodePostal = "   -";
            customer1.ContratNumber = "0";
            customer1.DateAttestation1 = new System.DateTime(2010, 6, 25, 10, 29, 12, 53);
            customer1.DateAttestation2 = new System.DateTime(2010, 6, 25, 10, 29, 12, 53);
            customer1.DateDebutCours = new System.DateTime(2010, 3, 14, 19, 59, 19, 434);
            customer1.DateExpiration = new System.DateTime(2010, 3, 14, 19, 59, 19, 434);
            customer1.DateInscription = new System.DateTime(2010, 3, 14, 19, 59, 19, 434);
            customer1.DateNaissance = new System.DateTime(2010, 3, 14, 19, 59, 19, 434);
            customer1.DateTemporaire = new System.DateTime(2010, 3, 14, 19, 59, 19, 434);
            customer1.DisponibilityAM = false;
            customer1.DisponibilityDimanche = false;
            customer1.DisponibilityPM = false;
            customer1.DisponibilitySamedi = false;
            customer1.DisponibilitySoirer = false;
            customer1.FirstName = "";
            customer1.HaveTemporaire = false;
            customer1.LastRecuNumber = "";
            customer1.LocationAutomobile = false;
            customer1.LocationMoto = false;
            customer1.MontantCours = "";
            customer1.MontantLocation = "0 $";
            customer1.Name = "";
            customer1.No6R = "";
            customer1.Notes = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3084{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
                "ans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            customer1.NumeroGroupe = 0;
            customer1.NumeroPermis = "";
            customer1.Phone = "(   )   -";
            customer1.PhoneBureau = "(   )   -";
            customer1.Solde = "0 $";
            customer1.StreetApp = "";
            customer1.StreetName = "";
            customer1.StreetNumber = "";
            customer1.TauxHorairePratique = "";
            customer1.TauxHoraireTheorique = "";
            customer1.TypeClient = Barette.Library.Client.ProfileType.Actif;
            customer1.TypeVehicule = Barette.Library.Client.VehiculeType.Automatique;
            this.clientControl1.Client = customer1;
            this.clientControl1.Location = new System.Drawing.Point(8, 8);
            this.clientControl1.Name = "clientControl1";
            this.clientControl1.School = null;
            this.clientControl1.Size = new System.Drawing.Size(648, 534);
            this.clientControl1.TabIndex = 15;
            // 
            // cmdAddClient
            // 
            this.cmdAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAddClient.Image = global::Barette.IDE.Properties.Resources.accept_icon;
            this.cmdAddClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAddClient.Location = new System.Drawing.Point(467, 546);
            this.cmdAddClient.Name = "cmdAddClient";
            this.cmdAddClient.Size = new System.Drawing.Size(84, 43);
            this.cmdAddClient.TabIndex = 0;
            this.cmdAddClient.Text = "Ajouter";
            this.cmdAddClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAddClient.Click += new System.EventHandler(this.cmdAddClient_Click);
            // 
            // FormAjoutClient
            // 
            this.ClientSize = new System.Drawing.Size(657, 601);
            this.ControlBox = false;
            this.Controls.Add(this.clientControl1);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdAddClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAjoutClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un client";
            this.ResumeLayout(false);

        }
        #endregion

        private void cmdCancel_Click(object sender, System.EventArgs e) {
            this.Close();
        }

        private void cmdAddClient_Click(object sender, System.EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;

            if (clientControl1.ValidateClient() == true) {

                this._formClients.AddClientToList(clientControl1.Client);
                this._formClients.AddClient(clientControl1.Client);

                this.DialogResult = DialogResult.OK;

                _AppConfig.LastContractNumber = Convert.ToInt32(clientControl1.Client.ContratNumber);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
