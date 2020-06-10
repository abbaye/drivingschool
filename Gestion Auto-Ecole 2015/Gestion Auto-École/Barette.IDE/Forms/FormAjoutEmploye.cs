using System;
using System.Windows.Forms;

namespace Barette.IDE.Forms
{
    public partial class FormAjoutEmploye : Form {
        readonly FormMain _formMain;
        readonly FormEmploye _formEmploye;

		public FormAjoutEmploye(FormMain formMain, FormEmploye formEmploye) {
			InitializeComponent();

            _formMain = formMain;
            _formEmploye = formEmploye; 
		}

		private void cmdAdd_Click(object sender, EventArgs e) {
			Cursor.Current = Cursors.WaitCursor;

            _formEmploye.AddEmploye(employeControl1.Employer);

            DialogResult = DialogResult.OK;
					
			Cursor.Current = Cursors.Default;

            Close();
		}
	}
}