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
    public partial class FormExport : Form {
        /// <summary>
        /// Type d'exportation
        /// </summary>
        private enum ExportType {
            TextFile,
            ClientFile
        }
        
        /// <summary>
        /// List de client
        /// </summary>
        private CustomerCollection _clientList;

        private Config _Appconfig;

        public FormExport(CustomerCollection clientlist, Config appconfig) {
            InitializeComponent();
            
            this._clientList = clientlist;
            this._Appconfig = appconfig;
                        

            FindClient(false);
        }

        private void cmdCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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
            
            //Recherche dans tous les clients
            foreach (Customer client in this._clientList) {

                if (AddCoursTerminer) 
                    AddClientToList(client);                
                else 
                    if (client.TypeClient != ProfileType.CoursTerminer)
                        AddClientToList(client); 
            }
        }

        /// <summary>
        /// Recherche les clients et les ajoute à la liste
        /// </summary>
        private void FindClient(bool AddCoursTerminer, string ContainContractNumber) {
            listFindResult.Items.Clear();


            var ListClientTous = from V in this._clientList.Cast<Customer>()
                                   where V.ContratNumber.Contains(ContainContractNumber)
                                   select V;
            
            var ListClient = from V in this._clientList.Cast<Customer>()
                                   where V.ContratNumber.Contains(ContainContractNumber) && V.TypeClient != ProfileType.CoursTerminer
                                   select V;            

            //Recherche dans tous les clients
            if (AddCoursTerminer)
                foreach (Customer client in ListClientTous)
                    AddClientToList(client);
            else
                foreach (Customer client in ListClient)
                    AddClientToList(client);            
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

        private void txtFind_TextChanged(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            FindClient(tbbAddCoursFinish.Pushed, txtFind.Text);
            Cursor.Current = Cursors.Default;
        }

        private void cmdClearbox_Click(object sender, EventArgs e) {
            txtFind.Text = "";
        }

        private void tbStudentsList_ButtonDropDown(object sender, ToolBarButtonClickEventArgs e) {
            
        }

    }
}
