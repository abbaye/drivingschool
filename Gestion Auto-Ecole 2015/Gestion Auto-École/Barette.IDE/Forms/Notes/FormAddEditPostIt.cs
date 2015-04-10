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

				notes.Alerte = this.cbAlerte.Checked;
				notes.AlerteDateTime = this.DateTimeAlerte.Value;
				notes.Message = this.txtMessage.Text;
				notes.Date = DatePostIt.Value;

				return notes;
			}
			set {
				this.cbAlerte.Checked = value.Alerte;
				this.DateTimeAlerte.Value = value.AlerteDateTime;
				this.txtMessage.Text = value.Message;
				this.DatePostIt.Value = value.Date;
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