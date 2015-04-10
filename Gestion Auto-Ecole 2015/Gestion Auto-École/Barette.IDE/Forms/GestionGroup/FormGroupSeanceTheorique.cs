using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Barette.Library;
using Barette.Library.Client;
using Barette.Library.Collections;

namespace Barette.IDE.Forms.GestionGroup {
    public partial class FormGroupSeanceTheorique : Form {

        /// <summary>
        /// Liste de client
        /// </summary>
        private CustomerCollection _ClientList;

        /// <summary>
        /// Liste d'employe
        /// </summary>
        private EmployeCollection _EmployerList;

        /// <summary>
        /// Groupe sur lequel les modification seront effectué
        /// </summary>
        private StudentGroup _Groupe;

        private Config _AppConfig;

        public FormGroupSeanceTheorique(StudentGroup group, CustomerCollection clientlist, EmployeCollection EmployerList, Config Appconfig) {
            InitializeComponent();

            this._ClientList = clientlist;
            this._Groupe = group;
            this._EmployerList = EmployerList;
            this._AppConfig = Appconfig;

            this.seancePicker1.ListEmploye = EmployerList;

            ChangeSeanceUpdateType(group.Type);
        }

        
        private void rb_CheckedChanged(object sender, EventArgs e) {

            RadioButton rbseance = (RadioButton)sender;

            seancePicker1.NumeroSeance = Convert.ToInt32(rbseance.Text); 
        }

        /// <summary>
        /// Change le style de form.
        /// - Automobile
        /// - Moto
        /// - Cylclomoteur
        /// </summary>
        private void ChangeSeanceUpdateType(StudentGroup.GroupType type) {
            switch (type) {
                case StudentGroup.GroupType.Automobile :
                    //Tous active
                    break;
                case StudentGroup.GroupType.Cyclomoteur:
                    rb4.Visible = rb5.Visible = rb6.Visible = rb7.Visible = rb8.Visible = rb9.Visible = rb10.Visible = rb11.Visible = rb12.Visible = false;
                    break;
                case StudentGroup.GroupType.Moto:
                    rb4.Visible = rb5.Visible = rb6.Visible = rb7.Visible = rb8.Visible = rb9.Visible = rb10.Visible = rb11.Visible = rb12.Visible = false;
                    break;
            }
        }

        private void cmdAddClient_Click(object sender, EventArgs e) {

            if (MessageBox.Show(this, "Voulez-vous vraiment effectuer les changements sur tous les élèves de votre groupe ?", _AppConfig.ApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                foreach (Customer client in this._ClientList.GetClient(this._Groupe.GroupeNumber)) {
                    //Supprimer la seance No. Seancepicker1.seancenumber de chaque client
                    foreach (Seance cours in client.SeancesTheorique) {
                        if (cours.SceanceNumber == seancePicker1.NumeroSeance) {
                            client.SeancesTheorique.Remove(cours);
                            break;
                        }
                    }

                    client.SeancesTheorique.Add(seancePicker1.Seance);
                }
        }
    }
}
