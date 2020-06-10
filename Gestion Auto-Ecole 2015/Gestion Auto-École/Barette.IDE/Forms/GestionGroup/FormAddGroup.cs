using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Barette.Library;

namespace Barette.IDE.Forms.GestionGroup
{
    public partial class FormAddGroup : Form {

        /// <summary>
        /// Liste de groupe
        /// </summary>
        private readonly List<StudentGroup> _groupList;

        private readonly Config _appconfig;

        /// <summary>
        /// Type de groupe
        /// </summary>
        private StudentGroup.GroupType _GroupeType = StudentGroup.GroupType.Automobile;

        public FormAddGroup(List<StudentGroup> group, Config appconfig) {
            InitializeComponent();

            //List de groupe
            _groupList = group;

            _appconfig = appconfig;
        }

        private void cmdCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void cmdNumeroAuto_Click(object sender, EventArgs e) {
            MakeAutoNumber();
        }

        /// <summary>
        /// Cree un numero de groupe automatiquement
        /// </summary>
        private void MakeAutoNumber() {
            var req = from v in _groupList
                      select (v.GroupeNumber);

            try {
                ntbGroupNumber.Text = (req.Max() + 1).ToString();
            }
            catch { ntbGroupNumber.Text = "0"; };
        }

        private void cmdValidate_Click(object sender, EventArgs e) {
            int numGroup;

            //Verifie que le numero de group est valide
            try {
                numGroup = Convert.ToInt32(ntbGroupNumber.Text);
            }
            catch {
                MessageBox.Show(this, "Entré un numéro de groupe valide", _appconfig.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ntbGroupNumber.Focus();
                return;
            }

            //Valide que le numero est unique
            if (IsUnique(numGroup)) {
                //Ajoute à la liste du groupe


                _groupList.Add(new StudentGroup(txtName.Text, Convert.ToInt32(ntbGroupNumber.Text), _GroupeType));
                Close();
            }
            else {
                MessageBox.Show(this, "Ce numéro de group est déja existant.", _appconfig.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ntbGroupNumber.Focus();
            }
        }

        /// <summary>
        /// Valide que le numéro de groupe est unique.
        /// </summary>
        /// <returns></returns>
        private bool IsUnique(int number) {
            foreach (StudentGroup group in _groupList) {
                if (group.GroupeNumber == number)
                    return false; 
            }

            return true;
        }

        private void cbAutomobile_CheckedChanged(object sender, EventArgs e) {
            _GroupeType = StudentGroup.GroupType.Automobile;
        }

        private void cbMoto_CheckedChanged(object sender, EventArgs e) {
            _GroupeType = StudentGroup.GroupType.Moto;
        }

        private void cbCyclomoteur_CheckedChanged(object sender, EventArgs e) {
            _GroupeType = StudentGroup.GroupType.Cyclomoteur;
        }
    }
}
