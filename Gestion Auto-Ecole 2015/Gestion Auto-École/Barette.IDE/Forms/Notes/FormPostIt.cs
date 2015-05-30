#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Barette.Library;

#endregion

namespace Barette.IDE.Forms.Notes {
	partial class FormPostIt : Form {

		private FormMain _FormMain = null;

		public FormPostIt(FormMain formMain) {
			InitializeComponent();

            _FormMain = formMain;

			LoadList();
		}

		public FormMain ParentMain {
			get {
				return _FormMain;
			}
		}

		private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch (e.Button.Tag.ToString()) {
				case "ADD":
					AddNotes();
					break;
				case "EDIT":
					EditNotes();
					break;
				case "DELETE":
					DeleteNotes();
					break;
			}
		}

		private void AddNotes() {
			FormAddEditPostIt frmPostit = new FormAddEditPostIt();
			string[] msg;

			frmPostit.ShowDialog();

			if (frmPostit.DialogResult == DialogResult.OK) {
				ListViewItem itm = new ListViewItem();

				if (frmPostit.Notes.Alerte == true)
					itm.ImageIndex = 1;
				else
					itm.ImageIndex = 0;

				itm.Tag = frmPostit.Notes.Message;

				msg = frmPostit.Notes.Message.Split('\n');
				itm.Text = msg[0].Substring(0, msg[0].Length -1) + "...";
				itm.SubItems.Add(frmPostit.Notes.Alerte.ToString()); 
				itm.SubItems.Add(frmPostit.Notes.AlerteDateTime.ToString());
				itm.SubItems.Add(frmPostit.Notes.Date.ToString());

				itm.ToolTipText = frmPostit.Notes.Message;

				lvNote.Items.Add(itm);
			}

			ReloadPostItList();
		}

		private void AddNotes(PostIt notes, bool reloadList) {
			string[] msg;

			ListViewItem itm = new ListViewItem();

			if (notes.Alerte == true)
				itm.ImageIndex = 1;
			else
				itm.ImageIndex = 0;

			itm.Tag = notes.Message;

			msg = notes.Message.Split('\n');
			itm.Text = msg[0].Substring(0, msg[0].Length - 1) + "...";
			itm.SubItems.Add(notes.Alerte.ToString());
			itm.SubItems.Add(notes.AlerteDateTime.ToString());
			itm.SubItems.Add(notes.Date.ToString());

			itm.ToolTipText = notes.Message;

			lvNote.Items.Add(itm);

			if (reloadList == true)
				ReloadPostItList();
		}

		/// <summary>
		/// Modifier une notes
		/// </summary>
		private void EditNotes() {
			try {
				if (lvNote.SelectedItems.Count > 0) {
					FormAddEditPostIt frmPostit = new FormAddEditPostIt();

					string[] msg;

					frmPostit.Notes = NotesSelected;
					frmPostit.ShowDialog();

					//Code apres edition
					if (frmPostit.DialogResult == DialogResult.OK) {
						msg = frmPostit.Notes.Message.Split('\n');

						if (frmPostit.Notes.Alerte == true)
							lvNote.SelectedItems[0].ImageIndex = 1;
						else
							lvNote.SelectedItems[0].ImageIndex = 0;

						lvNote.SelectedItems[0].Tag = frmPostit.Notes.Message;
						lvNote.SelectedItems[0].Text = msg[0].Substring(0, msg[0].Length - 1) + "...";
						lvNote.SelectedItems[0].SubItems[1].Text = frmPostit.Notes.Alerte.ToString();
						lvNote.SelectedItems[0].SubItems[2].Text = frmPostit.Notes.AlerteDateTime.ToString();
						lvNote.SelectedItems[0].SubItems[3].Text = frmPostit.Notes.Date.ToString();
						lvNote.SelectedItems[0].ToolTipText = frmPostit.Notes.Message;

					}
				}
			} catch {
			}

			ReloadPostItList();
		}

		private void lvNote_DoubleClick(object sender, EventArgs e)
		{
			EditNotes();
		}

		private void DeleteNotes() {
			if (lvNote.SelectedItems.Count > 0) {
				for (int i = 0; i < lvNote.SelectedItems.Count; i++) {
					lvNote.Items[lvNote.SelectedItems[i].Index].Remove();
				}

				ReloadPostItList();
			}
		}

		public void LoadList() {
			lvNote.Items.Clear();

			for (int i = 0; i < _FormMain.PostItList.Count; i++) {
				AddNotes(_FormMain.PostItList[i], false);
			}
		}

		private void lvNote_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete) {
				DeleteNotes();
			}
		}

		private void SelectionTimer_Tick(object sender, EventArgs e)
		{
			if (lvNote.SelectedItems.Count > 0)
				tbbDelete.Enabled = tbbEdit.Enabled = true;
			else
				tbbDelete.Enabled = tbbEdit.Enabled = false;
		}

		private void ReloadPostItList() {
            //Efface la liste des notes
            _FormMain.PostItList.Clear();

			//reload la liste des client
			for (int i = 0; i < lvNote.Items.Count; i++) {
                _FormMain.PostItList.Add(Notes(i));
			}
		}

		public PostIt NotesSelected {
			get {
				PostIt notes = new PostIt();

				notes.Message = (string)lvNote.SelectedItems[0].Tag;
				notes.Alerte = Convert.ToBoolean(lvNote.SelectedItems[0].SubItems[1].Text);
				notes.AlerteDateTime = DateTime.Parse(lvNote.SelectedItems[0].SubItems[2].Text);
				notes.Date = DateTime.Parse(lvNote.SelectedItems[0].SubItems[3].Text);

				return notes;
			}
		}

		public PostIt Notes(int index) {
			PostIt notes = new PostIt();

			notes.Message = (string)lvNote.Items[index].Tag;
			notes.Alerte = Convert.ToBoolean(lvNote.Items[index].SubItems[1].Text);
			notes.AlerteDateTime = DateTime.Parse(lvNote.Items[index].SubItems[2].Text);
			notes.Date = DateTime.Parse(lvNote.Items[index].SubItems[3].Text);

			return notes;
		}

	}
}