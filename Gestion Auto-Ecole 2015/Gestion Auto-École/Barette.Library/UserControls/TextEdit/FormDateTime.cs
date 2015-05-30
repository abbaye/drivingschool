#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#endregion

namespace Barette.Library.UserControls.TextEdit {
	partial class FormDateTime : Form {
		public FormDateTime() {
			InitializeComponent();

			lstDateTime.Items.Add(DateTime.Now.Date.ToLongDateString());
			lstDateTime.Items.Add(DateTime.Now.Date.ToShortDateString());
			lstDateTime.Items.Add(DateTime.Now.Date.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
			lstDateTime.Items.Add(DateTime.Now.Date.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
			lstDateTime.Items.Add(DateTime.Now.ToLongTimeString());
			lstDateTime.Items.Add(DateTime.Now.ToShortTimeString());
			lstDateTime.Items.Add(DateTime.Now.Hour + " h " + DateTime.Now.Minute);
			lstDateTime.Items.Add(DateTime.Now.Year);

			lstDateTime.SelectedIndex = 0;
		}

		private void lstDateTime_DoubleClick(object sender, EventArgs e)
		{
            DialogResult = DialogResult.OK;
            Close();
		}
	}
}