using System;
using System.Windows.Forms;

using Barette.Library.Client;
using Barette.Library;

namespace Barette.IDE.Forms
{
    /// <summary>
    /// Description résumée de FormAjoutClient.
    /// </summary>
    public class FormAjoutClient : Form
    {
        /// <summary>
        /// Fenetre principal
        /// </summary>
        private readonly FormClients _formClients = null;
        private readonly SchoolInfo _infoEcole = null;
        private readonly Config _AppConfig = null;

        private Button cmdCancel;
        private Button cmdAddClient;
        public Library.UserControls.Client.ClientControl clientControl1;
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private readonly System.ComponentModel.Container components = null;

        public FormAjoutClient(FormClients clientForm, SchoolInfo infoEcole, Config AppConfig) {
            //
            // Requis pour la prise en charge du Concepteur Windows Forms
            //
            InitializeComponent();

            //cree un access a la dialog principal de l'application
            _formClients = clientForm;
            _infoEcole = infoEcole;
            _AppConfig = AppConfig;

            clientControl1.Now();

            //Numero de contrat
            Customer client = clientControl1.Client;
            client.ContratNumber = (AppConfig.LastContractNumber + 1).ToString();

            //Taux horaire par default
            client.TauxHorairePratique = _infoEcole.TauxHorairePratique;
            client.TauxHoraireTheorique = _infoEcole.TauxHoraireTheorie;

            clientControl1.Client = client;
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
            Customer customer1 = new Customer();
            cmdCancel = new Button();
            clientControl1 = new Library.UserControls.Client.ClientControl();
            cmdAddClient = new Button();
            SuspendLayout();
            // 
            // cmdCancel
            // 
            cmdCancel.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cmdCancel.Image = global::Barette.IDE.Properties.Resources.Cancel_2_icon;
            cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cmdCancel.Location = new System.Drawing.Point(557, 546);
            cmdCancel.Name = "cmdCancel";
            cmdCancel.Size = new System.Drawing.Size(88, 43);
            cmdCancel.TabIndex = 1;
            cmdCancel.Text = "Annuler";
            cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cmdCancel.Click += new EventHandler(cmdCancel_Click);
            // 
            // clientControl1
            // 
            clientControl1.AutoScroll = true;
            clientControl1.AutoUpdate = true;
            clientControl1.BackColor = System.Drawing.SystemColors.Control;
            customer1.AttestationNumber1 = "";
            customer1.AttestationNumber2 = "";
            customer1.BVA = false;
            customer1.BVADate = new DateTime(2010, 3, 14, 19, 59, 19, 434);
            customer1.City = "";
            customer1.ClientNull = false;
            customer1.CodePostal = "   -";
            customer1.ContratNumber = "0";
            customer1.DateAttestation1 = new DateTime(2010, 6, 25, 10, 29, 12, 53);
            customer1.DateAttestation2 = new DateTime(2010, 6, 25, 10, 29, 12, 53);
            customer1.DateDebutCours = new DateTime(2010, 3, 14, 19, 59, 19, 434);
            customer1.DateExpiration = new DateTime(2010, 3, 14, 19, 59, 19, 434);
            customer1.DateInscription = new DateTime(2010, 3, 14, 19, 59, 19, 434);
            customer1.DateNaissance = new DateTime(2010, 3, 14, 19, 59, 19, 434);
            customer1.DateTemporaire = new DateTime(2010, 3, 14, 19, 59, 19, 434);
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
            clientControl1.Client = customer1;
            clientControl1.Location = new System.Drawing.Point(8, 8);
            clientControl1.Name = "clientControl1";
            clientControl1.School = null;
            clientControl1.Size = new System.Drawing.Size(648, 534);
            clientControl1.TabIndex = 15;
            // 
            // cmdAddClient
            // 
            cmdAddClient.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            cmdAddClient.Image = global::Barette.IDE.Properties.Resources.accept_icon;
            cmdAddClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cmdAddClient.Location = new System.Drawing.Point(467, 546);
            cmdAddClient.Name = "cmdAddClient";
            cmdAddClient.Size = new System.Drawing.Size(84, 43);
            cmdAddClient.TabIndex = 0;
            cmdAddClient.Text = "Ajouter";
            cmdAddClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            cmdAddClient.Click += new EventHandler(cmdAddClient_Click);
            // 
            // FormAjoutClient
            // 
            ClientSize = new System.Drawing.Size(657, 601);
            ControlBox = false;
            Controls.Add(clientControl1);
            Controls.Add(cmdCancel);
            Controls.Add(cmdAddClient);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "FormAjoutClient";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Ajouter un client";
            ResumeLayout(false);

        }
        #endregion

        private void cmdCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void cmdAddClient_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;

            if (clientControl1.ValidateClient() == true) {

                _formClients.AddClientToList(clientControl1.Client);
                _formClients.AddClient(clientControl1.Client);

                DialogResult = DialogResult.OK;

                _AppConfig.LastContractNumber = Convert.ToInt32(clientControl1.Client.ContratNumber);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
