﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Barette.Library.Listview;
using Barette.Library.Client;
using Barette.Library.Collections;

namespace Barette.IDE.Forms {
    public partial class FormSuivieCoursMoto2015 : Form {

        /// <summary>
        /// Represente une collection de client
        /// </summary>
        CustomerCollection _clientlist = null;

        /// <summary>
        /// Fenetre principal
        /// </summary>
        FormMain _FormMain = null;


        public FormSuivieCoursMoto2015(CustomerCollection client, FormMain frmMain) {
            InitializeComponent();

            _clientlist = client;
            _FormMain = frmMain;

            //cbFindCours.SelectedIndex = 0;

            Find();
        }

        private void tbMain_ButtonClick(object sender, ToolBarButtonClickEventArgs e) {
            switch (e.Button.Tag.ToString()) {
                case "REFRESH":
                    if (tbbActivateModePratique.Pushed == true)
                        FindPratique();
                    else
                        Find();
                    break;
                case "SHOWSEANCE":
                    if (tbbActivateModePratique.Pushed == true)
                        ShowSeance();
                    else
                        ShowSeanceTheorique();            
                    break;
                case "SHOWCLIENT":
                    try { _FormMain.CreationListClient(ListCours.SelectedItems[0].Text); }
                    catch { };
                    break;
                case "COURSPRATIQUE":
                    if (tbbActivateModePratique.Pushed == true)
                        FindPratique();
                    else
                        Find();
                    break;
            }
        }

        /// <summary>
        /// Affiche la seance du client selectionner
        /// </summary>
        private void ShowSeanceTheorique() {
            try { clientControl1.ShowCoursTheorique(); }
            catch { }
            finally { UpdateFind(); };
        }

        /// <summary>
        /// Affiche la seance du client selectionner
        /// </summary>
        private void ShowSeance() {
            try { clientControl1.ShowCours(); }
            catch { }
            finally { UpdateFind(); };
        }

        /// <summary>
        /// Mise a jour de la recherche après modification
        /// </summary>
        private void UpdateFind() {
            Customer client = _clientlist.GetClient(ListCours.SelectedItems[0].Text);

            for (int i = 0; i < 15; i++) {
                ListCours.SelectedItems[0].SubItems[i + 4].Text = " ";
            }

            switch (client.ProgramMoto)
            {
                case ProgramMoto.Program2015:
                    ListCours.SelectedItems[0].SubItems[13].Text = "Nouveau";
                    break;
                case ProgramMoto.ProgramNormal:
                    ListCours.SelectedItems[0].SubItems[13].Text = "Ancien";
                    break;
            }

            switch (tbbActivateModePratique.Pushed) {
                case false:
                    for (int j = 0; j < client.SeancesTheorique.Count; j++)
                    {
                        if (client.ProgramMoto == ProgramMoto.Program2015)
                            switch (client.SeancesTheorique[j].SceanceNumber)
                            {
                                case 1:
                                    ListCours.SelectedItems[0].SubItems[4].Text = "X";
                                    break;
                                case 6:
                                    ListCours.SelectedItems[0].SubItems[5].Text = "X";
                                    break;
                            }
                        else
                            switch (client.SeancesTheorique[j].SceanceNumber)
                            {
                                case 1:
                                    ListCours.SelectedItems[0].SubItems[4].Text = "X";
                                    break;
                                case 2:
                                    ListCours.SelectedItems[0].SubItems[5].Text = "X";
                                    break;
                                case 3:
                                    ListCours.SelectedItems[0].SubItems[6].Text = "X";
                                    break;
                            }
                    }
                    break;
                case true:
                    for (int j = 0; j < client.Seances.Count; j++)
                    {
                        if (client.ProgramMoto == ProgramMoto.Program2015)
                            switch (client.Seances[j].SceanceNumber)
                            {
                                case 2:
                                    ListCours.SelectedItems[0].SubItems[4].Text = "X";
                                    break;
                                case 3:
                                    ListCours.SelectedItems[0].SubItems[5].Text = "X";
                                    break;
                                case 4:
                                    ListCours.SelectedItems[0].SubItems[6].Text = "X";
                                    break;
                                case 5:
                                    ListCours.SelectedItems[0].SubItems[7].Text = "X";
                                    break;
                                case 7:
                                    ListCours.SelectedItems[0].SubItems[8].Text = "X";
                                    break;
                                case 8:
                                    ListCours.SelectedItems[0].SubItems[9].Text = "X";
                                    break;
                                case 9:
                                    ListCours.SelectedItems[0].SubItems[10].Text = "X";
                                    break;
                                case 10:
                                    ListCours.SelectedItems[0].SubItems[11].Text = "X";
                                    break;
                                case 11:
                                    ListCours.SelectedItems[0].SubItems[12].Text = "X";
                                    break;
                            }
                        else
                            switch (client.Seances[j].SceanceNumber)
                            {
                                case 1:
                                    ListCours.SelectedItems[0].SubItems[4].Text = "X";
                                    break;
                                case 2:
                                    ListCours.SelectedItems[0].SubItems[5].Text = "X";
                                    break;
                                case 3:
                                    ListCours.SelectedItems[0].SubItems[6].Text = "X";
                                    break;
                                case 4:
                                    ListCours.SelectedItems[0].SubItems[7].Text = "X";
                                    break;
                                case 5:
                                    ListCours.SelectedItems[0].SubItems[8].Text = "X";
                                    break;
                                case 6:
                                    ListCours.SelectedItems[0].SubItems[9].Text = "X";
                                    break;
                                case 7:
                                    ListCours.SelectedItems[0].SubItems[10].Text = "X";
                                    break;
                                case 8:
                                    ListCours.SelectedItems[0].SubItems[11].Text = "X";
                                    break;
                                case 9:
                                    ListCours.SelectedItems[0].SubItems[12].Text = "X";
                                    break;
                            }
                    }
                    break;
            }
        }

        private void Find() {
            //Variable
            ListViewItem item;


            //Vide la liste avant de commancer le traitement
            ListCours.Items.Clear();

            //Desective la sort
            ListCours.Sorting = SortOrder.None;

            int i, j, k;
            for (i = 0; i < _clientlist.Count; i++) {
                if ((_clientlist[i].TypeClient != ProfileType.CoursTerminer) && IsMoto(_clientlist[i])) {
                    item = new ListViewItem(_clientlist[i].ContratNumber);

                    item.SubItems.Add(_clientlist[i].FirstName + " " + _clientlist[i].Name);
                    item.SubItems.Add(_clientlist[i].Phone);
                    item.SubItems.Add(_clientlist[i].PhoneBureau);
                                        
                    for (k = 0; k < 15; k++) {
                        item.SubItems.Add(" ");
                    }

                    switch (_clientlist[i].ProgramMoto)
                    {
                        case ProgramMoto.Program2015:
                            item.SubItems[13].Text = "Nouveau";
                            break;
                        case ProgramMoto.ProgramNormal:
                            item.SubItems[13].Text = "Ancien";
                            break;
                    }                   

                    for (j = 0; j < _clientlist[i].SeancesTheorique.Count; j++)
                    {
                        if (_clientlist[i].ProgramMoto == ProgramMoto.Program2015)
                            switch (_clientlist[i].SeancesTheorique[j].SceanceNumber)
                            {
                                case 1:
                                    item.SubItems[4].Text = "X";
                                    break;
                                case 6:
                                    item.SubItems[5].Text = "X";
                                    break;
                            }
                        else
                            switch (_clientlist[i].SeancesTheorique[j].SceanceNumber)
                            {
                                case 1:
                                    item.SubItems[4].Text = "X";
                                    break;
                                case 2:
                                    item.SubItems[5].Text = "X";
                                    break;
                                case 3:
                                    item.SubItems[6].Text = "X";
                                    break;
                            }
                    }

                    ListCours.Items.Add(item);
                }
            }
        }

        private void FindPratique() {
            //Variable
            ListViewItem item;


            //Vide la liste avant de commancer le traitement
            ListCours.Items.Clear();

            //Desective la sort
            ListCours.Sorting = SortOrder.None;

            int i, j, k;
            for (i = 0; i < _clientlist.Count; i++) {
                if ((_clientlist[i].TypeClient != ProfileType.CoursTerminer) && IsMoto(_clientlist[i])) {
                    item = new ListViewItem(_clientlist[i].ContratNumber);

                    item.SubItems.Add(_clientlist[i].FirstName + " " + _clientlist[i].Name);
                    item.SubItems.Add(_clientlist[i].Phone);
                    item.SubItems.Add(_clientlist[i].PhoneBureau);


                    for (k = 0; k < 15; k++) {
                        item.SubItems.Add(" ");
                    }

                    switch (_clientlist[i].ProgramMoto)
                    {
                        case ProgramMoto.Program2015:
                            item.SubItems[13].Text = "Nouveau";
                            break;
                        case ProgramMoto.ProgramNormal:
                            item.SubItems[13].Text = "Ancien";
                            break;
                    }

                    for (j = 0; j < _clientlist[i].Seances.Count; j++)
                    {
                        if (_clientlist[i].ProgramMoto == ProgramMoto.Program2015)
                            switch (_clientlist[i].Seances[j].SceanceNumber)
                            {
                                case 2:
                                    item.SubItems[4].Text = "X";
                                    break;
                                case 3:
                                    item.SubItems[5].Text = "X";
                                    break;
                                case 4:
                                    item.SubItems[6].Text = "X";
                                    break;
                                case 5:
                                    item.SubItems[7].Text = "X";
                                    break;
                                case 7:
                                    item.SubItems[8].Text = "X";
                                    break;
                                case 8:
                                    item.SubItems[9].Text = "X";
                                    break;
                                case 9:
                                    item.SubItems[10].Text = "X";
                                    break;
                                case 10:
                                    item.SubItems[11].Text = "X";
                                    break;
                                case 11:
                                    item.SubItems[12].Text = "X";
                                    break;
                            }
                        else
                            switch (_clientlist[i].Seances[j].SceanceNumber)
                            {
                                case 1:
                                    item.SubItems[4].Text = "X";
                                    break;
                                case 2:
                                    item.SubItems[5].Text = "X";
                                    break;
                                case 3:
                                    item.SubItems[6].Text = "X";
                                    break;
                                case 4:
                                    item.SubItems[7].Text = "X";
                                    break;
                                case 5:
                                    item.SubItems[8].Text = "X";
                                    break;
                                case 6:
                                    item.SubItems[9].Text = "X";
                                    break;
                                case 7:
                                    item.SubItems[10].Text = "X";
                                    break;
                                case 8:
                                    item.SubItems[11].Text = "X";
                                    break;
                                case 9:
                                    item.SubItems[12].Text = "X";
                                    break;
                            }
                    }

                    ListCours.Items.Add(item);
                }
            }
        }

        private void timerResize_Tick(object sender, EventArgs e) {

            if (tbbActivateModePratique.Pushed == true) {
                colHead1.Width = colHead2.Width = colHead3.Width = colHead4.Width = colHead5.Width = colHead6.Width = colHead7.Width =
                    colHead8.Width = colHead9.Width = 41;

                //ListCours.SmallImageList = null;
                tbbShowSeanceTheorique.ImageKey = "Drive.ico";
            }
            else {
                colHead4.Width = colHead5.Width = colHead6.Width = colHead7.Width =
                    colHead8.Width = colHead9.Width = 0;
                
                tbbShowSeanceTheorique.ImageKey = "book-icon";

                //ListCours.SmallImageList = imgListChiffre;
            }

            colHeadClientName.Width = 130;
            colHeadContractNumber.Width = 68;
            colHeadTelephone.Width = 90;
            colHeadTelephoneAutre.Width = 90;

        }

        private void ListCoursEffectuer_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void timerEnabled_Tick(object sender, EventArgs e) {
            if (ListCours.SelectedItems.Count == 0) {
                tbbShowClient.Enabled = false;
                tbbShowSeanceTheorique.Enabled = false;
            }
            else {
                tbbShowClient.Enabled = true;
                tbbShowSeanceTheorique.Enabled = true;
            }
        }

        /// <summary>
        /// Verifie que cest un cours automobile
        /// </summary>
        /// <param name="client"></param>
        private bool IsMoto(Customer client) {
            switch (client.TypeVehicule) {
                case VehiculeType.Moto:
                    return true;
                default:
                    return false;
            }
        }

        private void ListCours_DoubleClick(object sender, EventArgs e) {
            try {
                if (tbbActivateModePratique.Pushed == true)
                    ShowSeance();
                else
                    ShowSeanceTheorique();    
            }
            catch { }
        }

        private void cbFindCours_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    int findCoursNumber = -1;

            //    if (cbFindCours.SelectedIndex != 0)
            //        findCoursNumber = Convert.ToInt32(cbFindCours.SelectedItem.ToString());

            //    if (tbbActivateModePratique.Pushed == true)
            //        FindPratique();
            //    else
            //        Find();
            //}
            //catch { }
        }
    }
}
