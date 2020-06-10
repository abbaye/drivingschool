using System;
using System.Linq;
using System.Windows.Forms;

using Barette.Library.Client;
using Barette.Library.Collections;


namespace Barette.IDE.Forms {
    public partial class FormStatistiques : Form {
        readonly CustomerCollection _clientlist;

        ///// <summary>
        ///// TEST
        ///// </summary>
        ///// <param name="typeVehicule"></param>
        //private delegate void RemplirClientListDelegate(VehiculeType typeVehicule);
        ///// <summary>
        ///// TEST
        ///// </summary>
        ///// <param name="profileType"></param>
        //private delegate void RemplirClientListDelegate(ProfileType profileType);

        public FormStatistiques(CustomerCollection clientlist) {
            InitializeComponent();

            _clientlist = clientlist;

            //Annee en cours
            dtpStartMonth.Value = new DateTime(DateTime.Now.Year, 1, 1); 

            MakeStatistiques();

            MakeGraph();
        }

        private void MakeGraph() {
            DateTime date = new DateTime(dtpStartMonth.Value.Year, dtpStartMonth.Value.Month, 1);
            

            //Group By ... Donnee pour le graph
            var grouped = from p in _clientlist.Cast<Customer>()
                          where p.DateInscription >= date 
                          group p by new { month = p.DateInscription.Month, year = p.DateInscription.Year } into d
                          orderby d.Key.year, d.Key.month ascending
                          select new { datetime = string.Format("{0}/{1}", d.Key.month, d.Key.year), count = d.Count() };

            var groupedMoto = from p in _clientlist.Cast<Customer>()
                          where (p.DateInscription >= date) && (p.TypeVehicule == VehiculeType.Moto)
                          group p by new { month = p.DateInscription.Month, year = p.DateInscription.Year } into d
                          orderby d.Key.year, d.Key.month ascending
                          select new { datetime = string.Format("{0}/{1}", d.Key.month, d.Key.year), count = d.Count() };

            var groupedCyclomoteur = from p in _clientlist.Cast<Customer>()
                              where (p.DateInscription >= date) && (p.TypeVehicule == VehiculeType.Cyclomoteur)
                              group p by new { month = p.DateInscription.Month, year = p.DateInscription.Year } into d
                              orderby d.Key.year, d.Key.month ascending
                              select new { datetime = string.Format("{0}/{1}", d.Key.month, d.Key.year), count = d.Count() };

            var groupedAutomobile = from p in _clientlist.Cast<Customer>()
                                    where (p.DateInscription >= date) && (p.TypeVehicule == VehiculeType.Manuel || p.TypeVehicule == VehiculeType.Automatique)
                              group p by new { month = p.DateInscription.Month, year = p.DateInscription.Year } into d
                              orderby d.Key.year, d.Key.month ascending
                              select new { datetime = string.Format("{0}/{1}", d.Key.month, d.Key.year), count = d.Count() };
             
            
            //Cree un link au tableau
            chart1.Series["Inscriptions"].Points.DataBind(grouped, "datetime", "count", "");
            chart1.Series["Motocyclette"].Points.DataBind(groupedMoto, "datetime", "count", "");
            chart1.Series["Cyclomoteur"].Points.DataBind(groupedCyclomoteur, "datetime", "count", "");
            chart1.Series["Automobile"].Points.DataBind(groupedAutomobile, "datetime", "count", ""); 
            
        }

        /// <summary>
        /// Ajouter un statistique à la liste des statistiques avec une icon
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="info"></param>
        private void AddStatistique(string Name, string info, VehiculeType Icon) {
            ListViewItem itm = new ListViewItem
            {
                Text = Name
            };
            itm.SubItems.Add(info);

            switch (Icon) {
                case VehiculeType.Automobile:
                    itm.ImageIndex = 1;                    
                    break;
                case VehiculeType.Moto:
                    itm.ImageIndex = 0;
                    break;
                case VehiculeType.Cyclomoteur:
                    itm.ImageIndex = 0;
                    break;
            }

            lvStats.Items.Add(itm);
        }
        
        /// <summary>
        /// Ajouter un statistique à la liste des statistiques
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="info"></param>
        private void AddStatistique(string Name, string info) {
            ListViewItem itm = new ListViewItem
            {
                Text = Name
            };
            itm.SubItems.Add(info);

            lvStats.Items.Add(itm);
        }

        /// <summary>
        /// Affiche les statistiques
        /// </summary>
        private void MakeStatistiques() {
            lvStats.Items.Clear();

            var GroupTypeVehicule = from V in _clientlist.Cast<Customer>()
                                    group V by V.TypeVehicule into M
                                    select M;

            var GroupTypeClient = from V in _clientlist.Cast<Customer>()
                                  group V by V.TypeClient into M
                                  select M;

            AddStatistique("Total des clients", _clientlist.Count.ToString());

            foreach (var client in GroupTypeClient) {
                switch (client.Key) {
                    case ProfileType.Actif:
                        AddStatistique("Clients Actif", client.Count().ToString());
                        break;
                    case ProfileType.CoursTerminer:
                        AddStatistique("Clients Terminé", client.Count().ToString());
                        break;
                }
            }

            foreach (var client in GroupTypeVehicule) {
                switch (client.Key) {
                    case VehiculeType.Moto:
                        AddStatistique("Motocyclette", client.Count().ToString(), VehiculeType.Moto);
                        break;
                    case VehiculeType.Cyclomoteur:
                        AddStatistique("Cyclomoteur", client.Count().ToString(), VehiculeType.Cyclomoteur);
                        break;
                    case VehiculeType.Manuel:
                        AddStatistique("Conduite Manuel", client.Count().ToString(), VehiculeType.Automobile);
                        break;
                    case VehiculeType.Automatique:
                        AddStatistique("Conduite Automatique", client.Count().ToString(), VehiculeType.Automobile);
                        break;
                }
            }

        }

        private void cmdAddClient_Click(object sender, EventArgs e) {

        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e) {
            switch (e.Button.Tag.ToString()) {
                case "REFRESH":
                    MakeStatistiques();
                    MakeGraph();
                    break;
            }
        }

        private void dtpStartMonth_ValueChanged(object sender, EventArgs e) {
            MakeGraph();
        }

        private void lvStats_SelectedIndexChanged(object sender, EventArgs e) {
            //RemplirListClient();
        }

        ///// <summary>
        ///// Remplir la liste de client avec le type selectionner
        ///// </summary>
        //private void RemplirListClient(VehiculeType typeVehicule) {
        //    lvClient.Items.Clear();

        //    try {
        //        var list = from v in this._clientlist.Cast<Customer>()
        //                   where v.TypeVehicule == typeVehicule 
        //                   select v;


        //        foreach (Customer client in list) {
        //            lvClient.Items.Add(client.GetFullName(false)); 
        //        }
        //    } catch { }

        //}

        ///// <summary>
        ///// Remplir la liste de client avec le type selectionner
        ///// </summary>
        //private void RemplirListClient(ProfileType typeClient) {
        //    lvClient.Items.Clear();

        //    try {
        //        var list = from v in this._clientlist.Cast<Customer>()
        //                   where v.TypeClient == typeClient
        //                   select v;


        //        foreach (Customer client in list) {
        //            lvClient.Items.Add(client.GetFullName(false));
        //        }
        //    } catch { }

        //}
    }
}
