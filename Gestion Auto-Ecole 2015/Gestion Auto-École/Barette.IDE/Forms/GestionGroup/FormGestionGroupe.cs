using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;

using Barette.Library;
using Barette.Library.Client;
using Barette.Library.Collections;
using Barette.Library.UserControls.Client;

namespace Barette.IDE.Forms.GestionGroup
{
    public partial class FormGestionGroupe : Form {

        /// <summary>
        /// List de groupe d'élèves
        /// </summary>
        private readonly List<StudentGroup> _StudentGroup;

        /// <summary>
        /// List des clients
        /// </summary>
        private readonly CustomerCollection _ClientList;

        /// <summary>
        /// Acces vers la form principale.
        /// </summary>
        private readonly FormMain _FormMain;

        /// <summary>
        /// Liste d'employer
        /// </summary>
        private readonly EmployeCollection _EmployerList;

        //Variable global privé pour l'impression sur plusieurs pages
        //c<est variable doivent etre obligatoirement global ou dans une classe statique...

        private int _TotalPage = 0;
        private int _TotalPagePrinted = 1;
        private int _TotalLine = 0;
        private int _LinesPerPage = 0;
        private int _LinePrinted = -1;
        private bool _HeaderPrinted = false;

        public FormGestionGroupe(List<StudentGroup> group, CustomerCollection clientList, FormMain mainform, EmployeCollection EmployerList) {
            InitializeComponent();

            //Initialise les variables
            _StudentGroup = group;
            _ClientList = clientList;
            _FormMain = mainform;
            _EmployerList = EmployerList;

            //remplir les listes
            RefreshGroupList();
            if (ListGroup.Items.Count > 0) ListGroup.Items[0].Selected = true;

        }

        private void tbStudentGroup_ButtonClick(object sender, ToolBarButtonClickEventArgs e) {
            switch (e.Button.Tag.ToString()){
                case "ADDGROUP":
                    new FormAddGroup(_StudentGroup, _FormMain.AppConfig).ShowDialog(this);
                    RefreshGroupList();                    
                    break;
                case "DELETEGROUP":
                    DeleteSelectedGroup();
                    break;
                case "REFRESH":
                    RefreshGroupList();
                    if (ListGroup.Items.Count > 0) ListGroup.Items[0].Selected = true; 
                    break;
                case "PRINT":
                    PrintDoc();
                    break;
                case "EDIT":
                    ShowEditGroupBox();
                    break;
            }
        }

        /// <summary>
        /// Lance l'impression du document et initialise les variable global
        /// pour l'impression sur plusieurs pages.
        /// </summary>
        private void PrintDoc() {
            //assigne les variables par default
            _TotalPage = 0;
            _TotalPagePrinted = 1;
            _TotalLine = 0;
            _HeaderPrinted = false;
            _LinesPerPage = 0;
            _LinePrinted = -1;

            PrintRelever.DefaultPageSettings.Landscape = true;

#if DEBUG
            PrintPreviewDialog prev = new PrintPreviewDialog
            {
                Document = PrintRelever
            };
            prev.ShowDialog();

#else

			//Lance l'impression
			PrintDialog printConfig = new PrintDialog();			
			printConfig.PrinterSettings = PrintRelever.PrinterSettings; 

			if(printConfig.ShowDialog(this) == DialogResult.OK)
				PrintRelever.Print();
#endif
        }

        /// <summary>
        /// Detruit le group selectionné et transfere tous les eleves vers le groupe 0.
        /// </summary>
        private void DeleteSelectedGroup() {
            if (ListGroup.SelectedItems.Count > 0) {
                Cursor.Current = Cursors.WaitCursor; 
                if (MessageBox.Show(this, "Voulez vous vraiment supprimer le groupe d'élève numéro : " + ListGroup.SelectedItems[0].Text + @" ?

Cette opération ne supprimera pas les clients. Par contre tous les clients du groupe seront déplacé dans le groupe '0'", _FormMain.AppConfig.ApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                    int numeroGroupe = Convert.ToInt32(ListGroup.SelectedItems[0].Text);

                    //Déplace les éleve du groupe vers le groupe 0
                    foreach (Customer client in _ClientList) {
                        if (client.NumeroGroupe == numeroGroupe)
                            client.NumeroGroupe = 0; 
                    }

                    //Supprime le groupe sélectionné
                    foreach (StudentGroup group in _StudentGroup) {
                        if (group.GroupeNumber == numeroGroupe) {
                            _StudentGroup.Remove(group);
                            RefreshAll();
                            break;                            
                        }
                    }

                }

                Cursor.Current = Cursors.Default;
            }
        }

        /// <summary>
        /// Supprime l'étudiant sélectionné et le transfère dans le groupe 0
        /// </summary>
        private void DeleteSelectedStudent() {
            Customer client;

            foreach (ListViewItem item in listFindResult.SelectedItems) {
                client = _ClientList.GetClient(item.Text);

                if (client != null) {
                    client.NumeroGroupe = 0;
                    item.Remove();
                    UpdateNbEleve();
                }               
            }                        
        }

        private void RefreshAll() {
            RefreshGroupList();
            if (ListGroup.SelectedItems.Count > 0)
                RefreshClientList(Convert.ToInt32(ListGroup.SelectedItems[0].Text));
            else
                listFindResult.Items.Clear();
        }


        /// <summary>
        /// Rafraichir la list de groupe
        /// </summary>
        private void RefreshClientList(int NumeroGroup) {
            //Vide la liste de groupes
            listFindResult.Items.Clear();

            foreach (Customer client in _ClientList.GetClient(NumeroGroup)) {
                AddClientToList(client);
            }        
        }


        /// <summary>
        /// Rafraichir la list de groupe
        /// </summary>
        private void RefreshGroupList() {
            ListViewItem itm = null;

            //Vide la liste de groupes
            ListGroup.Items.Clear();

            foreach (StudentGroup group in _StudentGroup) {
                itm = new ListViewItem
                {
                    Text = group.GroupeNumber.ToString()
                };
                itm.SubItems.Add(group.Name);
                itm.SubItems.Add(GetNbEleve(group.GroupeNumber).ToString());
                itm.SubItems.Add(group.Type.ToString());

                ListGroup.Items.Add(itm);
            }
        }

        /// <summary>
        /// Met a jour le nombre d'etudiant dans chaque groupe
        /// </summary>
        private void UpdateNbEleve() {
            foreach (ListViewItem item in ListGroup.Items) {
                item.SubItems[2].Text = GetNbEleve(Convert.ToInt32(item.Text)).ToString(); 
            }
        }

        /// <summary>
        /// Retourne le nombre d'élève dans le groupe
        /// </summary>
        /// <param name="NumeroGroupe"></param>
        /// <returns></returns>
        private int GetNbEleve(int NumeroGroupe) {            
            int total = (from v in _ClientList.Cast<Customer>()
                         where v.NumeroGroupe == NumeroGroupe
                         select v).Count();

            return total;
        }

        /// <summary>
        /// Ajoute un client a la liste
        /// (Finir cette fonction)
        /// </summary>
        /// <param name="client"></param>
        private void AddClientToList(Customer client) {
            ListViewItem itm = new ListViewItem
            {
                Text = client.ContratNumber
            };
            itm.SubItems.Add(client.DateInscription.ToShortDateString());

            itm.SubItems.Add(client.FirstName + " " + client.Name);
            itm.SubItems.Add(client.NumeroPermis);
            itm.SubItems.Add(client.Phone);

            itm.SubItems.Add(client.PhoneBureau);

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

        private void timerActivateButton_Tick(object sender, EventArgs e) {
            try {
                //Liste de groupe
                if (ListGroup.SelectedItems.Count > 0) {
                    if (ListGroup.SelectedItems[0].Text != "0") {
                        tbbDeleteGroupe.Enabled = true;
                        tbbAddStudentInGroup.Enabled = true;
                        tbbEdit.Enabled = true;
                    }
                    else {
                        tbbAddStudentInGroup.Enabled = false;
                        tbbEdit.Enabled = false;                        
                    }

                    tbbPrint.Enabled = true;
                    tbStudentsList.Enabled = true;
                }
                else {
                    tbbPrint.Enabled = false;
                    tbbDeleteGroupe.Enabled = false;
                    tbStudentsList.Enabled = false;
                    tbbEdit.Enabled = false;
                }

                //Liste de client
                if (listFindResult.SelectedItems.Count > 0) {
                    tbbDeleteStudentFromGroup.Enabled = true;
                    tbbShowClient.Enabled = true;
                }
                else {
                    tbbDeleteStudentFromGroup.Enabled = false;
                    tbbShowClient.Enabled = false;
                }

                if (listFindResult.Items.Count == 0 || ListGroup.SelectedItems[0].Text == "0") {
                    tbbModifieSeancePratique.Enabled = false;
                    tbbModifieSeanceTheorique.Enabled = false;
                    tbbDeleteStudentFromGroup.Enabled = false;
                }
                else {
                    tbbModifieSeancePratique.Enabled = true;
                    tbbModifieSeanceTheorique.Enabled = true;
                }
            }
            catch {
            }
        }

        private void ListGroup_SelectedIndexChanged(object sender, EventArgs e) {
            if (ListGroup.SelectedItems.Count > 0)
                RefreshClientList(Convert.ToInt32(ListGroup.SelectedItems[0].Text));
            else
                listFindResult.Items.Clear();
        }

        private void tbStudentsList_ButtonClick(object sender, ToolBarButtonClickEventArgs e) {
            switch (e.Button.Tag.ToString()) {
                case "REFRESH":
                    if (ListGroup.SelectedItems.Count > 0)
                        RefreshClientList(Convert.ToInt32(ListGroup.SelectedItems[0].Text));
                    else
                        listFindResult.Items.Clear();
                    break;
                case "ADD":
                    ShowAddStudentForm();
                    break;
                case "DELETE":
                    DeleteSelectedStudent();
                    break;
                case "SEANCEPRATIQUE":
                    ModifieSeancePratique();
                    break;
                case "SEANCETHEORIQUE":
                    ModifieSeanceTheorique();
                    break;
                case "PRINTALL":
                    PrintAllStudentPratique();
                    break;
                case "PRINTTHEORIE":
                    PrintAllStudentTheorie();
                    break;                    
                case "SHOWCLIENT":
                    try {
                        _FormMain.CreationListClient(listFindResult.SelectedItems[0].Text);
                    }
                    catch { };
                    break;
            }
        }

        private void PrintAllStudentTheorie()
        {
            Customer client;

            foreach (ListViewItem item in listFindResult.Items)
            {
                client = _ClientList.GetClient(item.Text);

                if (client != null)
                {
                    clientControl1.Client = client;
                    clientControl1.PrintDoc(false, true, true, PrintDocumentType.InfoClientTheorique);
                }
            }
        }

        private void PrintAllStudentPratique()
        {
            Customer client;

            foreach (ListViewItem item in listFindResult.Items)
            {
                client = _ClientList.GetClient(item.Text);

                if (client != null)
                {
                    clientControl1.Client = client;
                    clientControl1.PrintDoc(false, true, true, PrintDocumentType.InfoClient);
                }
            }
        }

        /// <summary>
        /// Affiche la boite de modification de la seance theorique.
        /// </summary>
        private void ModifieSeanceTheorique() {
            _FormMain.CloseClient();
            new FormGroupSeanceTheorique(GetSelectedGroup(), _ClientList, _EmployerList, _FormMain.AppConfig).ShowDialog();
        }

        /// <summary>
        /// Affiche la boite de modification de la seance pratique.
        /// </summary>
        private void ModifieSeancePratique() {
            _FormMain.CloseClient();
            new FormGroupSeancePratique(GetSelectedGroup(), _ClientList, _EmployerList, _FormMain.AppConfig).ShowDialog();
        }

        private void ShowAddStudentForm() {
            _FormMain.CloseClient();

            if (new FormAddStudent(_ClientList, GetSelectedGroup(), _FormMain.AppConfig).ShowDialog(this) == DialogResult.OK) {
                if (ListGroup.SelectedItems.Count > 0)
                    RefreshClientList(Convert.ToInt32(ListGroup.SelectedItems[0].Text));
                else
                    listFindResult.Items.Clear();
            }

            UpdateNbEleve();
        }

        /// <summary>
        /// Lance la boite d'edition avec le group a modifier
        /// </summary>
        private void ShowEditGroupBox() {
            if (ListGroup.SelectedItems.Count > 0) {
                StudentGroup Group = null;

                foreach (StudentGroup group in _StudentGroup)
                    if (group.GroupeNumber == Convert.ToInt32(ListGroup.SelectedItems[0].Text))
                        Group = group;

                if (Group != null)
                    if (new FormModifieGroup(Group).ShowDialog(this) == DialogResult.OK)
                        RefreshAll();
            } else {
                MessageBox.Show(this, "Sélectionnez un group dans la liste.", _FormMain.AppConfig.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Aller chercher le groupe selectioner
        /// </summary>
        /// <returns></returns>
        private StudentGroup GetSelectedGroup() {
            if (ListGroup.SelectedItems.Count > 0) {

                StudentGroup group = new StudentGroup();
                foreach (StudentGroup groupe in _StudentGroup) {
                    if (groupe.GroupeNumber == Convert.ToInt32(ListGroup.SelectedItems[0].Text)) {
                        group = groupe;
                        break;
                    }
                }
                return group;
            }
            else
                return null;
        }

        private void PrintRelever_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
            float topMargin = 30;
            float leftMargin = 0;//e.MarginBounds.Left;

            //Defini le style de l'alignement
            StringFormat style = new StringFormat
            {
                Alignment = StringAlignment.Near
            };

            //Facrication de la font
            Font printFont = new Font("Times New Roman", 8, FontStyle.Regular);
            Font printFontBold = new Font("Times New Roman", 10, FontStyle.Bold);
            Font printFontBold16 = new Font("Times New Roman", 14, FontStyle.Bold);

            float yPos = 0f;

            #region Header
            if (_HeaderPrinted == false) {
                //Ecriture du header (image)                
                Stream strm = Type.GetType("Barette.IDE.Forms.GestionGroup.FormGestionGroupe").Assembly.GetManifestResourceStream("Barette.IDE.Resources.Printlogo.png");
                Bitmap img = new Bitmap(strm);
                e.Graphics.DrawImage(img, 0, 0, 192, 104);
                //topMargin = img.Height + 20;

                //Initialisation des variables dans le bloc header pour q'il ne le face qu'a la premiere page
                _TotalLine = listFindResult.Items.Count;
                _LinesPerPage = Convert.ToInt32((e.MarginBounds.Height - 30) / printFont.GetHeight(e.Graphics));
                _TotalPage = Convert.ToInt32(Decimal.Round(Convert.ToDecimal(_TotalLine) / Convert.ToDecimal(_LinesPerPage), 0));

                if (_TotalLine > 41) _TotalPage += 1;

                if (_TotalPage == 0) _TotalPage = 1;

                //Date(s) de relever : Choisi le bon type de Header a écrire
                yPos = topMargin + 5;
                e.Graphics.DrawString("Liste du groupe No : " + ListGroup.SelectedItems[0].Text, printFontBold16, Brushes.Black, leftMargin + 200, yPos, new StringFormat());
                yPos += printFontBold16.Height + 15;
                e.Graphics.DrawString("Nom groupe : " + ListGroup.SelectedItems[0].SubItems[1].Text, printFontBold16, Brushes.Black, leftMargin + 200, yPos, new StringFormat());

                _HeaderPrinted = true; //Header Imprimé
            }
            #endregion

            //Entete des colones
            yPos += 50;
 
            e.Graphics.DrawString("No.", printFontBold, Brushes.Black, leftMargin + 50, yPos, new StringFormat());
            e.Graphics.DrawString("Contrat", printFontBold, Brushes.Black, leftMargin + 50, yPos + printFont.Height, new StringFormat());
 
            e.Graphics.DrawString("Date", printFontBold, Brushes.Black, leftMargin + 125, yPos, new StringFormat());
            e.Graphics.DrawString("inscription", printFontBold, Brushes.Black, leftMargin + 125, yPos + printFont.Height, new StringFormat());

            e.Graphics.DrawString("Nom du client", printFontBold, Brushes.Black, leftMargin + 200, yPos, new StringFormat());
            e.Graphics.DrawString("No. Permis.", printFontBold, Brushes.Black, leftMargin + 400, yPos, new StringFormat());
                       
            e.Graphics.DrawString("Téléphone", printFontBold, Brushes.Black, leftMargin + 500, yPos, new StringFormat());

            e.Graphics.DrawString("Téléphone", printFontBold, Brushes.Black, leftMargin + 600, yPos, new StringFormat());
            e.Graphics.DrawString("Autre", printFontBold, Brushes.Black, leftMargin + 600, yPos + printFont.Height, new StringFormat());

            //Creation de l'objet client
            Customer client = null;

            yPos += printFont.Height + 20;
            //Impression de toute les lignes du tableau
            while (_LinePrinted < listFindResult.Items.Count - 1) {
                _LinePrinted++;

                client = _ClientList.GetClient(listFindResult.Items[_LinePrinted].Text);

                if (client != null) {

                    yPos += printFont.Height;
                    e.Graphics.DrawString(_LinePrinted + 1 + " - ", printFont, Brushes.Black, leftMargin + 5, yPos, new StringFormat());

                    e.Graphics.DrawString(listFindResult.Items[_LinePrinted].Text, printFont, Brushes.Black, leftMargin + 50, yPos, new StringFormat());                    
                    e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[1].Text, printFont, Brushes.Black, leftMargin + 125, yPos, new StringFormat());
                    e.Graphics.DrawString(client.FirstName + " " + client.Name, printFont, Brushes.Black, leftMargin + 200, yPos, new StringFormat());
                    e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[3].Text, printFont, Brushes.Black, leftMargin + 400, yPos, new StringFormat());
                    e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[4].Text, printFont, Brushes.Black, leftMargin + 500, yPos, new StringFormat());
                    e.Graphics.DrawString(listFindResult.Items[_LinePrinted].SubItems[5].Text, printFont, Brushes.Black, leftMargin + 600, yPos, new StringFormat());
 
                    #region Creation d'une nouvelle page et numéro de page
                    string PageNumber = "Page : " + _TotalPagePrinted.ToString(); // +"/" + _TotalPage.ToString();

                    if (yPos >= e.MarginBounds.Height + 50) {
                        //Numéro de page
                        e.Graphics.DrawString(PageNumber,
                            printFontBold,
                            Brushes.Black,
                            e.MarginBounds.Right - e.Graphics.MeasureString(PageNumber, printFontBold).Width,
                            e.MarginBounds.Bottom,
                            new StringFormat());

                        e.Graphics.DrawString("Date impression : " + DateTime.Now.ToLongDateString(), printFontBold, Brushes.Black, leftMargin, e.MarginBounds.Bottom, new StringFormat());

                        _TotalPagePrinted++;
                        e.HasMorePages = true; // Imprimer une nouvelle page ... sorte de boucle qui me fait mettre des maudite variable global grr lol
                        return;
                    } else {
                        //Numéro de page
                        e.Graphics.DrawString(PageNumber,
                            printFontBold,
                            Brushes.Black,
                            e.MarginBounds.Right - e.Graphics.MeasureString(PageNumber, printFontBold).Width,
                            e.MarginBounds.Bottom,
                            new StringFormat());

                        e.Graphics.DrawString("Date impression : " + DateTime.Now.ToLongDateString(), printFontBold, Brushes.Black, leftMargin, e.MarginBounds.Bottom, new StringFormat());
                    }
                    #endregion

                }
            }

            yPos += printFont.Height * 3;
            e.Graphics.DrawString("Date / Heure : ___________________ ", printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
            yPos += printFont.Height * 2;
            e.Graphics.DrawString("Signature du professeur \t\t: ___________________ ", printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("Nom du professeur \t\t: François Laberge", printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
            yPos += printFont.Height;
            e.Graphics.DrawString("No. Permis \t\t: L-14003", printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
        }
    }
}
