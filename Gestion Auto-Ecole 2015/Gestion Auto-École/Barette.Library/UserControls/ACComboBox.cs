using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Barette.Library.UserControls {
	/// <summary>
	/// Combox Box supportant l'auto-complation
	/// </summary>
	public class ACComboBox : System.Windows.Forms.ComboBox {
		private bool autoComplete;

		[DefaultValue(true),
		Description("Auto-completes le texte s'il est trouvé dans la collection."),
		Category("Behavior")]
		public bool AutoComplete {
			get {
				return autoComplete;
			}
			set {
				autoComplete = value;
			}
		}

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public ACComboBox() {
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Add any initialization after the InitComponent call
			this.autoComplete = true;
			this.KeyPress += new KeyPressEventHandler( this.OnKeyPress );
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if( components != null )
					components.Dispose();
			}
			base.Dispose( disposing );
		}

		private void OnKeyPress( object sender, KeyPressEventArgs e ) {
			if ( autoComplete ) {
				ACComboBox acComboBox = (ACComboBox)sender;
				if ( !e.KeyChar.Equals( (char)8 ) ) {
					SearchItems( acComboBox, ref e );
				}
				else
					e.Handled = false;
			}
			else
				e.Handled = false;
		}

		/// <summary>
		/// Searches the combo box item list for a match and selects it.
		/// If no match is found, then selected index defaults to -1.
		/// </summary>
		/// <param name="acComboBox"></param>
		/// <param name="e"></param>
		private void SearchItems( ACComboBox acComboBox, ref KeyPressEventArgs e ) {
			int selectionStart = acComboBox.SelectionStart;
			int selectionLength = acComboBox.SelectionLength;
			int selectionEnd = selectionStart + selectionLength;
			int index;
			StringBuilder sb = new StringBuilder();

			sb.Append( acComboBox.Text.Substring( 0, selectionStart ) )
				.Append( e.KeyChar.ToString() )
				.Append( acComboBox.Text.Substring( selectionEnd ) );
			index = acComboBox.FindString( sb.ToString() );
			
			if ( index == -1 )
				e.Handled = false;
			else {
				acComboBox.SelectedIndex = index;
				acComboBox.Select( selectionStart+1, acComboBox.Text.Length-(selectionStart+1) );
				e.Handled = true;
			}
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			components = new System.ComponentModel.Container();
		}
		#endregion
	}
}
