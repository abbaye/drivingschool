using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Barette.IDE.Forms;

namespace Barette.IDE.Forms {
	public partial class FormAjoutEmploye : Form {
		FormMain _formMain;
		FormEmploye _formEmploye;

		public FormAjoutEmploye(FormMain formMain, FormEmploye formEmploye) {
			InitializeComponent();

			this._formMain = formMain;
			this._formEmploye = formEmploye; 
		}

		private void cmdAdd_Click(object sender, EventArgs e) {
			Cursor.Current = Cursors.WaitCursor;
				
				this._formEmploye.AddEmploye(employeControl1.Employer);

				this.DialogResult = DialogResult.OK;
					
			Cursor.Current = Cursors.Default;

			this.Close();
		}
	}
}