#region Using directives

using System;
using System.Windows.Forms;

#endregion

namespace Barette.Library.Forms
{
    public partial class AlertForm : Form {
		private readonly PostIt _notes = null;

		public AlertForm(PostIt notes) {
			InitializeComponent();
			Barette.Library.Win32.StaticBorder.ThinBorder(lblText.Handle.ToInt32(), true);

            _notes = notes;
			
			cbRappelle.SelectedIndex = 0;
			lblDate.Text = _notes.Date.ToLongDateString();
			lblText.Text = _notes.Message;
			
		}

		private void cmdRappelle_Click(object sender, EventArgs e) {
			switch (cbRappelle.Text) {
				case "1 minute":
                    _notes.AlerteDateTime = DateTime.Now.AddMinutes(1); 
					break;
				case "5 minutes":
                    _notes.AlerteDateTime = DateTime.Now.AddMinutes(5); 
					break;
				case "10 minutes":
                    _notes.AlerteDateTime = DateTime.Now.AddMinutes(10); 
					break;
				case "30 minutes":
                    _notes.AlerteDateTime = DateTime.Now.AddMinutes(30); 
					break;
				case "1 heure":
                    _notes.AlerteDateTime = DateTime.Now.AddHours(1);
					break;
				case "2 heures":
                    _notes.AlerteDateTime = DateTime.Now.AddHours(2);
					break;
				case "5 heures":
                    _notes.AlerteDateTime = DateTime.Now.AddHours(5);
					break;
				case "1 jour":
                    _notes.AlerteDateTime = DateTime.Now.AddDays(1);
					break;
				case "2 jours":
                    _notes.AlerteDateTime = DateTime.Now.AddDays(2);
					break;
			}

			_notes.Alerte = true;
            Close();
		}

		private void cmdClose_Click(object sender, EventArgs e) {
			_notes.Alerte = false;
		}
	}
}