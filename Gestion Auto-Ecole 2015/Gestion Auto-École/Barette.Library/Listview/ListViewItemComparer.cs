using System;
using System.Collections;
using System.Windows.Forms;

namespace Barette.Library.Listview
{
	/// <summary>
	/// Permet de faire un trie selon une colone
	/// ref: ms-help://MS.VSCC.2003/MS.MSDNQTR.2003FEB.1036/cpref/html/frlrfsystemwindowsformslistviewclasslistviewitemsortertopic.htm
	/// </summary>
	public class ListViewItemComparer : IComparer {
		private int col;

		public ListViewItemComparer() {
			col=0;
		}
		public ListViewItemComparer(int column) {
			col=column;
		}
		public int Compare(object x, object y) {
			return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
		}
	}
}
