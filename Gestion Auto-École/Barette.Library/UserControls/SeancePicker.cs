using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

using Barette.Library.Client;
using Barette.Library.Forms;
using Barette.Library.Collections;

namespace Barette.Library.UserControls {
	public partial class SeancePicker : UserControl {
		public SeancePicker() {
			InitializeComponent();

			LoadCode();
		}
        
		public Seance Seance {
			get {
				Seance tmp = new Seance();
				tmp.Active = this.Checked;
				tmp.Code = this.Code;
				tmp.DateHeure = DateSceance.Value;
				tmp.DateModified = DateModifiedPicker.Value;
				tmp.Employer = this.Employer;
				tmp.SceanceNumber = this.NumeroSeance;
				tmp.DateModifiedChecked = this.DateModifiedChecked;
				tmp.Absence = this.cbAbsence.Checked;
				tmp.Montant = this.ctbMontantCours.Text;
				return tmp;
			}
			set {
				this.Checked = value.Active;
				this.Code = value.Code;
				
				try {
					DateSceance.Value = value.DateHeure;
				} catch {
					DateSceance.Value = DateTime.Now;
				}

				try {
					DateModifiedPicker.Value = value.DateModified;
				} catch {
					DateModifiedPicker.Value = DateTime.Now;
				}

				this.Employer = value.Employer;
				this.NumeroSeance = value.SceanceNumber;
				this.DateModifiedChecked = value.DateModifiedChecked;
				this.cbAbsence.Checked = value.Absence;
				this.ctbMontantCours.Text = value.Montant;
			}
		}

		public EmployeCollection ListEmploye {
			set {				
				LoadListEmploye(value);
			}
		}

		public int NumeroSeance {
			get {
				return int.Parse(lblSceanceNumber.Tag.ToString());
			}
			set {
				lblSceanceNumber.Text = "Séance : " + value;
				lblSceanceNumber.Tag = value;
			}
		}

		public string Code {
			get {
				return lstChoice.Text;
			}
			set {
				lstChoice.Text = value;
			}

		}

		public string Employer {
			get {
				return lstEmploye.Text;
			}
			set {
				lstEmploye.Text = value;
			}

		}

		public bool Checked {
			get {
				return lblSceanceNumber.Checked;
			}
			set {
				lblSceanceNumber.Checked = value;
			}
		}

		public bool DateModifiedChecked {
			get {
				return DateModifiedPicker.Checked;
			}
			set {
				DateModifiedPicker.Checked = value;
			}
		}

		public bool Absence {
			get {
				return cbAbsence.Checked;
			}
			set {
				cbAbsence.Checked = value;
			}
		}

        //public void ShowCodeDialog() {
        //    new FormSeanceCode().ShowDialog(this);
        //}

		public DateTime SeanceDateTime {
			get {
				return DateSceance.Value;
			}
			set {
				DateSceance.Value = value;
			}
		}
		public DateTime DateModified {
			get {
				return DateModifiedPicker.Value;
			}
			set {
				DateModifiedPicker.Value = value;
			}
		}

		private void SeancePicker_Resize(object sender, System.EventArgs e) {
			this.Height = 25;
		}

		private void lblSceanceNumber_CheckedChanged(object sender, System.EventArgs e) {

			if (lblSceanceNumber.Checked == true)
				DateSceance.Value = DateTime.Now;

			DateModifiedPicker.Enabled = lblSceanceNumber.Checked;
			DateSceance.Enabled = lblSceanceNumber.Checked;
			lstChoice.Enabled = lblSceanceNumber.Checked;
			lstEmploye.Enabled = lblSceanceNumber.Checked;
			cbAbsence.Enabled = lblSceanceNumber.Checked;
			ctbMontantCours.Enabled = lblSceanceNumber.Checked;

            
		}

		/// <summary>
		/// Chargement de la liste des codes de seances
		/// </summary>
		private void LoadCode() {
			if (File.Exists(@"data\code.xml")) {
				//Creation du reader
				XmlDocument doc = new XmlDocument();
				XmlTextReader reader = new XmlTextReader(@"data\code.xml");

				//Lecture du document
				doc.Load(reader);

				//Lecture des includes : TextFile
				XmlNodeList CodeNodes = doc.ChildNodes.Item(0).ChildNodes;
				XmlNodeList AllCode = doc.ChildNodes.Item(0).ChildNodes.Item(0).ChildNodes;

				//Chargement de la liste de client
				XmlNode node = null;
				lstChoice.Items.Add(""); //Ajout d'une entre vide
				for (int i = 0; i < AllCode.Count; i++) {
					//client
					node = AllCode[i];

					lstChoice.Items.Add(node.Attributes["Code"].Value);
				}
				reader.Close();
			}
		}

		/// <summary>
		/// Charge la liste des employés
		/// </summary>
		private void LoadListEmploye(EmployeCollection ListEmploye) {
			lstEmploye.Items.Clear();

			lstEmploye.Items.Add(""); //Ajout d'un employe vide
			for (int i = 0; i < ListEmploye.Count; i++) {
				lstEmploye.Items.Add(ListEmploye[i].Nom + " " + ListEmploye[i].Prenom);
			}			
		}

		/// <summary>
		/// Dessiner un cadrage autour du control
		/// </summary>
		/// <example>
		/// Cadrage de la meme couleurs que les controls windows
		/// DessinerCadrage(new Pen(Color.FromKnownColor(KnownColor.Control)));
		/// </example>
		/// <param name="pen"></param>
		public void DessinerCadrage(Pen pen) {
			Graphics gfx = CreateGraphics();

			Rectangle rec = new Rectangle(0,0, this.Width - 1, this.Height - 1);
			gfx.DrawRectangle(pen , rec);
		}

		private void cbAbsence_CheckedChanged(object sender, EventArgs e) {
			if (cbAbsence.Checked) {
				cbAbsence.ForeColor = Color.Red;
			} else {
				cbAbsence.ForeColor = SystemColors.ControlText;
			}
		}
	}
}