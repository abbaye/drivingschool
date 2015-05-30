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

namespace Barette.IDE.Forms.GestionGroup {
    public partial class FormAddStudent : Form {

        /// <summary>
        /// List de client
        /// </summary>
        private CustomerCollection _clientList;

        private StudentGroup _groupe;

        private Config _Appconfig;

        public FormAddStudent(CustomerCollection clientlist, StudentGroup group, Config appconfig) {
            InitializeComponent();

            _clientList = clientlist;
            _groupe = group;
            _Appconfig = appconfig;
                        

            FindClient(false);
        }

        private void cmdCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Ajoute un client a la liste
        /// (Finir cette fonction)
        /// </summary>
        /// <param name="client"></param>
        private void AddClientToList(Customer client) {
            ListViewItem itm = new ListViewItem();

            itm.Text = client.ContratNumber;
            itm.SubItems.Add(client.DateInscription.ToShortDateString());

            itm.SubItems.Add(client.FirstName + " " + client.Name);
            itm.SubItems.Add(client.NumeroPermis);
            itm.SubItems.Add(client.Phone);

            itm.SubItems.Add(client.PhoneBureau);
            itm.SubItems.Add(client.NumeroGroupe.ToString());
            itm.SubItems.Add(client.TypeClient.ToString());

            switch (client.TypeVehicule) {
                case VehiculeType.Automatique:
                    itm.ImageKey = "Auto";
                    break;
                case VehiculeType.Cyclomoteur:
                    itm.ImageKey = "Moto";
                    break;
                case VehiculeType.Manuel:
                    itm.ImageKey = "Auto";
                    break;
                case VehiculeType.Moto:
                    itm.ImageKey = "Moto";
                    break;
            }

            listFindResult.Items.Add(itm);
        }

        /// <summary>
        /// Recherche les clients et les ajoute à la liste
        /// </summary>
        private void FindClient(bool AddCoursTerminer) {
            listFindResult.Items.Clear();

            var clientsAll = from client in _clientList.Cast<Customer>()
                             where (client.GetCustomerType() == _groupe.Type)
                             select client;

            var clients = from client in _clientList.Cast<Customer>()
                          where (client.GetCustomerType() == _groupe.Type) && (client.TypeClient != ProfileType.CoursTerminer)
                          select client;

            switch (AddCoursTerminer) {
                case true:
                    foreach (Customer client in clientsAll)
                        AddClientToList(client);
                    break;
                case false:
                    foreach (Customer client in clients)
                        AddClientToList(client);
                    break;
            }  
        }

        /// <summary>
        /// Recherche les clients et les ajoute à la liste
        /// </summary>
        private void FindClient(bool AddCoursTerminer, string ContainContractNumber) {
            listFindResult.Items.Clear();


            var ListClientTous = from V in _clientList.Cast<Customer>()
                                   where V.ContratNumber.Contains(ContainContractNumber) && V.GetCustomerType() == _groupe.Type
                                   select V;
            
            var ListClient = from V in _clientList.Cast<Customer>()
                                   where V.ContratNumber.Contains(ContainContractNumber) && V.GetCustomerType() == _groupe.Type && V.TypeClient != ProfileType.CoursTerminer
                                   select V;
            

            //Recherche dans tous les clients
            if (AddCoursTerminer)
                foreach (Customer client in ListClientTous)
                    AddClientToList(client);
            else
                foreach (Customer client in ListClient)
                    AddClientToList(client);            
        }

        /// <summary>
        /// Transfere toute client selectionner vers le groupe cible this._groupnumber
        /// </summary>
        private void MakeGroup() {
            //Ferme le client ouvert dans FormClient si la from est ouverte.

            //Applique le changement de groupe
            Customer client;
            foreach (ListViewItem item in listFindResult.CheckedItems) {
                client = _clientList.GetClient(item.Text);
                client.NumeroGroupe = _groupe.GroupeNumber; 
            }
        }

        private void tbStudentsList_ButtonClick(object sender, ToolBarButtonClickEventArgs e) {
            switch (e.Button.Tag.ToString()){
                case "REFRESH":
                    FindClient(tbbAddCoursFinish.Pushed);
                    break;
                case "COURSTERMINER":
                    FindClient(tbbAddCoursFinish.Pushed);
                    break;

            }
        }

        /// <summary>
        /// Verififie que les clients selectione dans la liste n'ont pas de groupe
        /// </summary>
        /// <returns> 
        /// True = Si un item dans tous la list a un groupe diferent de 0
        /// False = Si aucun item n'a de groupe
        /// </returns>
        private bool ClientHaveGroupe() {
            foreach (ListViewItem item in listFindResult.CheckedItems) {
                if (item.SubItems[6].Text != "0")
                    return true;
            }

            return false;
        }

        private void cmdAddClient_Click(object sender, EventArgs e) {
            if (ClientHaveGroupe()) {
                if (MessageBox.Show(this, @"Un ou plusieurs client sélectionné sont déjà assigné à un groupe.  

Voulez vous quand même les ajouter dans le groupe : " + _groupe.GroupeNumber.ToString() + " ?", _Appconfig.ApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    MakeGroup();
                }

            } 
            else
                MakeGroup();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtFind_TextChanged(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            FindClient(tbbAddCoursFinish.Pushed, txtFind.Text);
            Cursor.Current = Cursors.Default;
        }

        private void cmdClearbox_Click(object sender, EventArgs e) {
            txtFind.Text = "";
        }

    }
}
