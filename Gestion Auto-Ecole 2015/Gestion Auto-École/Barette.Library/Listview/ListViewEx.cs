#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

#endregion

namespace Barette.Library.Listview {
	public partial class ListViewEx : ListView {
		public ListViewEx() {
			InitializeComponent();
		}

		private void ListViewEx_ColumnClick(object sender, ColumnClickEventArgs e) {
			this.ListViewItemSorter = new ListViewItemComparer(e.Column);

			this.Sort();
		}

		public void SortColumn(int col) {
			this.ListViewItemSorter = new ListViewItemComparer(col);

			this.Sort();
		}
	}
}
