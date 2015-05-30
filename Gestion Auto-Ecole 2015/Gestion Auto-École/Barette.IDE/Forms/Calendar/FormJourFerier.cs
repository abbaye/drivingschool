using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Barette.Library.Collections;
using Barette.Library;

namespace Barette.IDE.Forms.Calendar {
	public partial class FormJourFerier : Form {
		OffDateCollection _ColOffDate = null;
        Config _AppConfig;

		public FormJourFerier(OffDateCollection col, Config appconfig) {
			InitializeComponent();

			_ColOffDate = col;
            _AppConfig = appconfig;

			LoadDateList();

			//Calendrier			
			monthCalendar1.TodayDate = DateTime.Now;
			monthCalendar1.SelectionRange = new Voroshkov.Calendar.DateSelectionRange(DateTime.Now, DateTime.Now);
			monthCalendar1.SelectionStart = monthCalendar1.SelectionEnd = DateTime.Now;	
		}

		/// <summary>
		/// Chargement de la liste
		/// </summary>
		private void LoadDateList() {
			ListViewItem itm = new ListViewItem();
			ListViewItem.ListViewSubItem subitm = new ListViewItem.ListViewSubItem();			

			for (int i = 0; i < _ColOffDate.Count; i++) {
				itm = new ListViewItem();
				subitm = new ListViewItem.ListViewSubItem();
				itm.Text = _ColOffDate[i].Date.ToShortDateString();
				subitm.Text = _ColOffDate[i].Description;
				itm.SubItems.Add(subitm);

				lvDate.Items.Add(itm);
			}

			UpdateBoldedDate();				
		}

		private void tbFunction_ButtonClick(object sender, ToolBarButtonClickEventArgs e) {
			switch (e.Button.Tag.ToString()) {
				case "ADD":
					AddDate();					
					break;
				case "DELETE":
					DeleteDate();					
					break;
			}

			UpdateBoldedDate();
		}

		/// <summary>
		/// Effacer une date de la liste.
		/// </summary>
		private void DeleteDate() {
            if (MessageBox.Show(this, "Voullez vous vraiment effacer la date sélectioné ?", _AppConfig.ApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
				lvDate.Items.RemoveAt(lvDate.SelectedIndices[0]);
				UpdateBoldedDate();
			}
		}

		/// <summary>
		/// Ajoute une Date dans la liste.
		/// </summary>
		private void AddDate() {
			ListViewItem itm = new ListViewItem();
			ListViewItem.ListViewSubItem subitm = new ListViewItem.ListViewSubItem();
			bool exist = false;
			
			//Recherche d'une date existante
			for (int i = 0; i < lvDate.Items.Count; i++)
				if (lvDate.Items[i].Text == monthCalendar1.SelectionStart.Date.ToShortDateString()) {
                    MessageBox.Show(this, "Cette date existe déjà, veuillez en choisir une autre.", _AppConfig.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					exist = true;
				} else
					exist = false;

			if (txtDescription.Text != "") {
				//Ajout de la nouvelle date
				if (!exist) {
					itm.Text = monthCalendar1.SelectionStart.Date.ToShortDateString();
					subitm.Text = txtDescription.Text;
					itm.SubItems.Add(subitm);

					lvDate.Items.Add(itm);
					txtDescription.Text = "";
					tbbAddDate.Enabled = false;
				}
			} else {
                MessageBox.Show(this, "Une description pour votre jour férié est obligatoire", _AppConfig.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtDescription.Focus();
			}
		}

		private void txtDescription_TextChanged(object sender, EventArgs e) {
			if (txtDescription.Text.Length > 0)
				tbbAddDate.Enabled = true;
			else
				tbbDeleteDate.Enabled = false;
		}

		private void lvDate_SelectedIndexChanged(object sender, EventArgs e) {
			if (lvDate.SelectedItems.Count > 0)
				tbbDeleteDate.Enabled = true;
			else
				tbbDeleteDate.Enabled = false;
		}

		//Afficher tous les jours dans le calendrié
		private void UpdateBoldedDate() {
			//Effacer le tableau de AnnuallyBoldedDates
			monthCalendar1.RemoveAllAnnuallyBoldedDates();

			for (int i = 0; i < lvDate.Items.Count; i++) {
				monthCalendar1.AddAnnualDate(Convert.ToDateTime(lvDate.Items[i].Text), lvDate.Items[i].SubItems[1].Text);				
			}
						
			monthCalendar1.UpdateBoldedDates();
		}

		private void cmdApply_Click(object sender, EventArgs e) {
			OffDate offDate = new OffDate();			

			_ColOffDate.Clear();

			for (int i = 0; i < lvDate.Items.Count; i++){
				offDate = new OffDate();
				offDate.Date = Convert.ToDateTime(lvDate.Items[i].Text);
				offDate.Description = lvDate.Items[i].SubItems[1].Text;
				_ColOffDate.Add(offDate);
			}

            Close();
		}

		private void lvDate_KeyDown(object sender, KeyEventArgs e) {
			switch (e.KeyCode) {
				case Keys.Delete:
					DeleteDate();
					break;
			}
		}
	}
}