#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

using Barette.Library;

#endregion

namespace Barette.Library.Forms {
	public partial class AlertForm : Form {
		private PostIt _notes = null;

		public AlertForm(PostIt notes) {
			InitializeComponent();
			Barette.Library.Win32.StaticBorder.ThinBorder(lblText.Handle.ToInt32(), true);

			this._notes = notes;
			
			cbRappelle.SelectedIndex = 0;
			lblDate.Text = this._notes.Date.ToLongDateString();
			lblText.Text = this._notes.Message;
			
		}

		private void cmdRappelle_Click(object sender, EventArgs e) {
			switch (cbRappelle.Text) {
				case "1 minute":
					this._notes.AlerteDateTime = DateTime.Now.AddMinutes(1); 
					break;
				case "5 minutes":
					this._notes.AlerteDateTime = DateTime.Now.AddMinutes(5); 
					break;
				case "10 minutes":
					this._notes.AlerteDateTime = DateTime.Now.AddMinutes(10); 
					break;
				case "30 minutes":
					this._notes.AlerteDateTime = DateTime.Now.AddMinutes(30); 
					break;
				case "1 heure":
					this._notes.AlerteDateTime = DateTime.Now.AddHours(1);
					break;
				case "2 heures":
					this._notes.AlerteDateTime = DateTime.Now.AddHours(2);
					break;
				case "5 heures":
					this._notes.AlerteDateTime = DateTime.Now.AddHours(5);
					break;
				case "1 jour":
					this._notes.AlerteDateTime = DateTime.Now.AddDays(1);
					break;
				case "2 jours":
					this._notes.AlerteDateTime = DateTime.Now.AddDays(2);
					break;
			}

			_notes.Alerte = true;
			this.Close();
		}

		private void cmdClose_Click(object sender, EventArgs e) {
			_notes.Alerte = false;
		}
	}
}