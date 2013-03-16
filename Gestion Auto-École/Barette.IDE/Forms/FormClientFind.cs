using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Barette.Library;
using Barette.Library.Collections;
using Barette.Library.Client; 

namespace Barette.IDE.Forms {
    public partial class FormClientFind : Form {

        private enum FindMode {
            ContratNumber,
            FullName,
            GroupeNumber,
            All
        }

        CustomerCollection _ClientList;
        FormClients _formClients;
        Config _AppConfig;
        
        public FormClientFind(CustomerCollection ClientList, FormClients formClients, Config AppConfig) {
            InitializeComponent();

            this._ClientList = ClientList;
            this._formClients = formClients;
            this._AppConfig = AppConfig;

            LoadList();
            FindClient(FindMode.All);
        }

        /// <summary>
        /// Cree la liste des numeros de groupe disponible
        /// </summary>
        private void LoadList() {
            var GroupList = from client in this._ClientList.Cast<Customer>()
                            group client by client.NumeroGroupe into d 
                            orderby d.Key ascending 
                            select d;

            txtGroupNumber.Items.Add("");
            foreach (var count in GroupList)
                txtGroupNumber.Items.Add(count.Key);
           
        }


        /// <summary>
        /// Recherche de client dynamique
        /// </summary>
        /// <param name="mode"></param>
        private void FindClient(FindMode mode) {
            Cursor.Current = Cursors.WaitCursor;
            lvClient.Items.Clear();

            if (this._AppConfig.ShowGestionClient_CoursFinish)
                switch (mode) {
                    case FindMode.All:
                        var ClientAll = from client in this._ClientList.Cast<Customer>()
                                        select client;

                        foreach (Customer client in ClientAll)
                            AddClient(client);
                        break;
                    case FindMode.ContratNumber:
                        var ClientContractNumber = from client in this._ClientList.Cast<Customer>()
                                                   where client.ContratNumber.ToLower().Contains(txtNumeroContrat.Text.ToLower())
                                                   select client;

                        foreach (Customer client in ClientContractNumber)
                            AddClient(client);
                        break;
                    case FindMode.FullName:
                        var ClientFullName = from client in this._ClientList.Cast<Customer>()
                                             where client.GetFullName(false).ToLower().Contains(txtFullName.Text.ToLower())
                                             select client;

                        foreach (Customer client in ClientFullName)
                            AddClient(client);
                        break;
                    case FindMode.GroupeNumber:
                        var ClientGroupNumber = from client in this._ClientList.Cast<Customer>()
                                                where client.NumeroGroupe.ToString().Contains(txtGroupNumber.Text)
                                                select client;

                        foreach (Customer client in ClientGroupNumber)
                            AddClient(client);
                        break;
                }
            else
                switch (mode) {
                    case FindMode.All:
                        var ClientAll = from client in this._ClientList.Cast<Customer>()
                                        where client.TypeClient == ProfileType.Actif
                                        select client;

                        foreach (Customer client in ClientAll)
                            AddClient(client);
                        break;
                    case FindMode.ContratNumber:
                        var ClientContractNumber = from client in this._ClientList.Cast<Customer>()
                                                   where client.ContratNumber.ToLower().Contains(txtNumeroContrat.Text.ToLower()) && client.TypeClient == ProfileType.Actif
                                                   select client;

                        foreach (Customer client in ClientContractNumber)
                            AddClient(client);
                        break;
                    case FindMode.FullName:
                        var ClientFullName = from client in this._ClientList.Cast<Customer>()
                                             where client.GetFullName(false).ToLower().Contains(txtFullName.Text.ToLower()) && client.TypeClient == ProfileType.Actif
                                             select client;

                        foreach (Customer client in ClientFullName)
                            AddClient(client);
                        break;
                    case FindMode.GroupeNumber:
                        var ClientGroupNumber = from client in this._ClientList.Cast<Customer>()
                                                where client.NumeroGroupe.ToString().Contains(txtGroupNumber.Text) && client.TypeClient == ProfileType.Actif
                                                select client;

                        foreach (Customer client in ClientGroupNumber)
                            AddClient(client);
                        break;
                }

            Cursor.Current = Cursors.Default;

            lblResult.Text = "Client(s) trouvés : " + lvClient.Items.Count.ToString();
        }

        internal void AddClient(Customer client) {
            ListViewItem itm = new ListViewItem();

            itm.Text = client.GetFullName(false);

            itm.SubItems.Add(client.ContratNumber);
            itm.SubItems.Add(client.NumeroGroupe.ToString());

            //Type de profile
            if (client.TypeClient == ProfileType.CoursTerminer) {
                switch (client.TypeVehicule) {
                    case VehiculeType.Automatique:
                        itm.ImageIndex = 1;
                        break;
                    case VehiculeType.Moto:
                        itm.ImageIndex = 0;
                        break;
                    case VehiculeType.Cyclomoteur:
                        itm.ImageIndex = 0;
                        break;
                    case VehiculeType.Manuel:
                        itm.ImageIndex = 1;
                        break;
                }
                 lvClient.Groups[4].Items.Add(itm);
            }
            else {
                switch (client.TypeVehicule) {
                    case VehiculeType.Automatique:
                        itm.ImageIndex = 1;
                        lvClient.Groups[2].Items.Add(itm);
                        break;
                    case VehiculeType.Moto:
                        itm.ImageIndex = 0;
                        lvClient.Groups[3].Items.Add(itm);
                        break;
                    case VehiculeType.Cyclomoteur:
                        itm.ImageIndex = 0;
                        lvClient.Groups[1].Items.Add(itm);
                        break;
                    case VehiculeType.Manuel:
                        itm.ImageIndex = 1;
                        lvClient.Groups[0].Items.Add(itm);
                        break;
                }
            }

            lvClient.Items.Add(itm);
        }

        private void txtFullName_TextChanged(object sender, EventArgs e) {
            clientControl1.CloseClient();
            cmdAccept.Enabled = false;
            FindClient(FindMode.FullName);
        }

        private void txtNumeroContrat_TextChanged(object sender, EventArgs e) {
            clientControl1.CloseClient();
            cmdAccept.Enabled = false;
            FindClient(FindMode.ContratNumber);
        }

        private void cmdCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtGroupNumber_TextChanged(object sender, EventArgs e) {
            clientControl1.CloseClient();
            cmdAccept.Enabled = false;
            FindClient(FindMode.GroupeNumber);
        }

        private void txtClear_Click(object sender, EventArgs e) {
            txtNumeroContrat.Text = txtGroupNumber.Text = txtFullName.Text = "";
        }

        private void lvClient_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                clientControl1.Client = this._ClientList.GetClient(lvClient.SelectedItems[0].SubItems[1].Text);
                cmdAccept.Enabled = true;
                
            }
            catch {
                clientControl1.CloseClient();
                cmdAccept.Enabled = false;
            };
        }

        private void cmdAccept_Click(object sender, EventArgs e) {
            this._formClients.SelectionClient(lvClient.SelectedItems[0].SubItems[1].Text);
            this.Close();
        }
    }
}
