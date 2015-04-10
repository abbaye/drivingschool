using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Barette.Library;

namespace Barette.IDE.Forms.GestionGroup {
    public partial class FormModifieGroup : Form {

        /// <summary>
        /// Liste de groupe
        /// </summary>
        private StudentGroup _group;
        
        public FormModifieGroup(StudentGroup group) {
            InitializeComponent();

            //List de groupe
            _group = group;

            txtName.Text = group.Name;
            ntbGroupNumber.Text = group.GroupeNumber.ToString();
        }

        private void cmdCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        
        private void cmdValidate_Click(object sender, EventArgs e) {
            _group.Name = txtName.Text;
            _group.GroupeNumber = ntbGroupNumber.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
