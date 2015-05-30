#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#endregion

using Barette.Library; 

namespace Barette.IDE.Forms.Notes {
	partial class FormAddEditPostIt : Form {
		public FormAddEditPostIt() {
			InitializeComponent();
		}

		public FormAddEditPostIt(PostIt notes) {
			InitializeComponent();

			Notes = notes;
		}

		public PostIt Notes {
			get {
				PostIt notes = new PostIt();

				notes.Alerte = cbAlerte.Checked;
				notes.AlerteDateTime = DateTimeAlerte.Value;
				notes.Message = txtMessage.Text;
				notes.Date = DatePostIt.Value;

				return notes;
			}
			set {
                cbAlerte.Checked = value.Alerte;
                DateTimeAlerte.Value = value.AlerteDateTime;
                txtMessage.Text = value.Message;
                DatePostIt.Value = value.Date;
			}
		}

		private void cbAlerte_CheckedChanged(object sender, EventArgs e)
		{
			DateTimeAlerte.Enabled = cbAlerte.Checked;
		}

		private void txtMessage_TextChanged(object sender, EventArgs e)
		{
			cmdClose.Enabled = (txtMessage.Text.Length > 0);
		}
	}
}