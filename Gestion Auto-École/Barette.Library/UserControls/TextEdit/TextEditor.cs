#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Imaging;
using System.Data;
using System.Text;
using System.Windows.Forms;

#endregion

namespace Barette.Library.UserControls.TextEdit {
	/// <summary>
	/// Composant éditeur de texte.
	/// </summary>
	public partial class TextEditor : UserControl {
		/// <summary>
		/// Définit/récupère La source RTF du contrôle.
		/// </summary>
		/// <value>La source RTF du contrôle.</value>
		[CategoryAttribute("Text attributes"),
		DescriptionAttribute("Text rtf source.")]
		public string RTFCode {
			set { this.richTextBox1.Rtf = value; }
			get { return this.richTextBox1.Rtf; }
		}

		/// <summary>
		/// Définit/récupère le texte sans formatage RTF.
		/// </summary>
		/// <value>String Standard.</value>
		[CategoryAttribute("Text attributes"),
		DescriptionAttribute("Text rtf source.")]
		public string PlainText {
			set { this.richTextBox1.Text = value; }
			get { return this.richTextBox1.Text; }
		}

		private bool m_RTFTextChanged = false;
		/// <summary>
		/// Définit/récupère le flag permettant de savoir si le texte à changé ou non.
		/// </summary>
		/// <value>Le flag permettant de savoir si le texte a changé ou non.</value>
		[CategoryAttribute("Text attributes"),
		DescriptionAttribute("Set or gets the RTFTextChanged flag."),
		DefaultValue(false)]
		public bool RTFTextChanged {
			set { m_RTFTextChanged = value; }
			get { return m_RTFTextChanged; }
		}

		/// <summary>
		/// Evènement survenant lorsqu'un changement est effectué sur la source RTF du contrôle.
		/// </summary>
		/// <param name="sender">Voir la documentation MSDN.</param>
		/// <param name="e">Voir la documentation MSDN.</param>
		public delegate void NewEventHandler(object sender, EventArgs e);
		/// <summary>
		/// Survient lorsque le texte change.
		/// </summary>
		[CategoryAttribute("Text events"), DescriptionAttribute("Occurs when the RTFTextChanged flag changes.")]
		public event NewEventHandler OnChange;

		/// <summary>
		/// Constructeur.
		/// </summary>
		public TextEditor() {
			InitializeComponent();

			//Je rétablire le support des couleur bientot
//			Array Colors = Enum.GetValues(typeof(KnownColor));
//
//			foreach (object clr in Colors) {
//				if (!Color.FromKnownColor((KnownColor)clr).IsSystemColor) {
//					ToolStripMenuItem it = new ToolStripMenuItem();
//					it.Text = clr.ToString();
//					Bitmap bmp = new Bitmap(16, 16, PixelFormat.Format32bppArgb);
//					Graphics objGraphics = Graphics.FromImage(bmp);
//					objGraphics.Clear(Color.FromKnownColor((KnownColor)clr));
//					objGraphics.Flush();
//
//					it.Image = bmp;
//
//					it.Tag = Color.FromKnownColor((KnownColor)clr);
//
//					it.Click += new EventHandler(ColorToolStripButton_Click);
//					colorToolStripDropDownButton.DropDownItems.Add(it);
//				}
//			}

			InstalledFontCollection ifc = new InstalledFontCollection();
			FontFamily[] ffs = ifc.Families;
			richTextBox1.Clear();
			this.fontToolStripComboBox.Text = "";
			foreach (FontFamily ff in ffs) {
				this.fontToolStripComboBox.Items.Add(ff.Name);
			}

			//this.toolStripFormat.Location = new Point(this.toolStripEdit.Width, 0);

			Barette.Library.Win32.StaticBorder.ThinBorder(richTextBox1.Handle.ToInt32(), true);
		}

		/// <summary>
		/// Est activé lors du clic sur une couleur.
		/// </summary>
		/// <param name="sender">Voir la documentation MSDN.</param>
		/// <param name="e">Voir la documentation MSDN.</param>
		private void ColorToolStripButton_Click(object sender, EventArgs e) {
			this.richTextBox1.SelectionColor = Color.FromName(sender.ToString());
		}

		/// <summary>
		/// Bouton imprimer (fonction non encore implémentée.
		/// </summary>
		/// <param name="sender">Voir la documentation MSDN.</param>
		/// <param name="e">Voir la documentation MSDN.</param>
		private void printToolStripButton_Click(object sender, EventArgs e) {
		}

		/// <summary>
		/// Bouton couper.
		/// </summary>
		/// <param name="sender">Voir la documentation MSDN.</param>
		/// <param name="e">Voir la documentation MSDN.</param>
		private void cutToolStripButton_Click(object sender, EventArgs e) {
			this.richTextBox1.Cut();
		}

		/// <summary>
		/// Bouton copier.
		/// </summary>
		/// <param name="sender">Voir la documentation MSDN.</param>
		/// <param name="e">Voir la documentation MSDN.</param>
		private void copyToolStripButton_Click(object sender, EventArgs e) {
			this.richTextBox1.Copy();
		}

		/// <summary>
		/// Bouton coller.
		/// </summary>
		/// <param name="sender">Voir la documentation MSDN.</param>
		/// <param name="e">Voir la documentation MSDN.</param>
		private void pasteToolStripButton_Click(object sender, EventArgs e) {
			this.richTextBox1.Paste();
		}

		/// <summary>
		/// Mise à jour des boutons lorsque la sélection du texte change.
		/// </summary>
		/// <param name="sender">Voir la documentation MSDN.</param>
		/// <param name="e">Voir la documentation MSDN.</param>
		private void richTextBox1_SelectionChanged(object sender, EventArgs e) {
			if (this.richTextBox1.SelectionFont == null) return;
			this.boldToolStripButton.Checked = this.richTextBox1.SelectionFont.Bold;
			this.italicToolStripButton.Checked = this.richTextBox1.SelectionFont.Italic;
			this.underlineToolStripButton.Checked = this.richTextBox1.SelectionFont.Underline;
			this.StrikeouttoolStripButton.Checked = this.richTextBox1.SelectionFont.Strikeout;
			this.fontToolStripComboBox.Text = this.richTextBox1.SelectionFont.Name;
			this.fontSizeToolStripButton.Text = this.richTextBox1.SelectionFont.Size.ToString();
			leftToolStripButton.Checked = (this.richTextBox1.SelectionAlignment == HorizontalAlignment.Left);
			centerToolStripButton.Checked = (this.richTextBox1.SelectionAlignment == HorizontalAlignment.Center);
			rightToolStripButton.Checked = (this.richTextBox1.SelectionAlignment == HorizontalAlignment.Right);
			bulletToolStripButton.Checked = this.richTextBox1.SelectionBullet;
            this.toolStripColorPicker1.Color = this.richTextBox1.SelectionColor;
		}

		/// <summary>
		/// Fonction de mise à jour de la police utilisée.
		/// </summary>
		/// <param name="sender">Voir la documentation MSDN.</param>
		/// <param name="e">Voir la documentation MSDN.</param>
		private void UpdateFontStyle(object sender, EventArgs e) {
			int style = (int)this.richTextBox1.SelectionFont.Style;
			if (sender == boldToolStripButton && boldToolStripButton.Checked) style += (int)FontStyle.Bold;
			if (sender == boldToolStripButton && !boldToolStripButton.Checked) style -= (int)FontStyle.Bold;
			if (sender == italicToolStripButton && italicToolStripButton.Checked) style += (int)FontStyle.Italic;
			if (sender == italicToolStripButton && !italicToolStripButton.Checked) style -= (int)FontStyle.Italic;
			if (sender == underlineToolStripButton && underlineToolStripButton.Checked) style += (int)FontStyle.Underline;
			if (sender == underlineToolStripButton && !underlineToolStripButton.Checked) style -= (int)FontStyle.Underline;
			if (sender == StrikeouttoolStripButton && StrikeouttoolStripButton.Checked) style += (int)FontStyle.Strikeout;
			if (sender == StrikeouttoolStripButton && !StrikeouttoolStripButton.Checked) style -= (int)FontStyle.Strikeout;

			this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, (FontStyle)style);
		}

		/// <summary>
		/// Mise à jour de la police utilisée.
		/// </summary>
		/// <param name="sender">Voir la documentation MSDN.</param>
		/// <param name="e">Voir la documentation MSDN.</param>
		private void fontToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			this.richTextBox1.SelectionFont = new Font(this.fontToolStripComboBox.Text, this.richTextBox1.SelectionFont.Size, this.richTextBox1.SelectionFont.Style);
		}

		/// <summary>
		/// Mise à jour de la taille de la police.
		/// </summary>
		/// <param name="sender">Voir la documentation MSDN.</param>
		/// <param name="e">Voir la documentation MSDN.</param>
		private void fontSizeToolStripButton_SelectedIndexChanged(object sender, EventArgs e) {
			try {
				int i = System.Convert.ToInt16(fontSizeToolStripButton.Text);
				this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont.Name, i, this.richTextBox1.SelectionFont.Style);
			} catch {
				//TODO: MessageBox.Show("La valeur doit être un entier !");
				return;
			}
			this.fontSizeToolStripButton.Text = this.richTextBox1.SelectionFont.Size.ToString();
		}

		/// <summary>
		/// Mise à jour de la taille de la police lorsque l'on entre un texte sois même dans la combobox.
		/// </summary>
		/// <param name="sender">Voir la documentation MSDN.</param>
		/// <param name="e">Voir la documentation MSDN.</param>
		private void fontSizeToolStripButton_KeyUp(object sender, KeyEventArgs e) {
			if (e.KeyCode != Keys.Enter) return;
			try {
				int i = System.Convert.ToInt16(fontSizeToolStripButton.Text);
				this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont.Name, i, this.richTextBox1.SelectionFont.Style);
			} catch {
				//TODO: MessageBox.Show("La valeur doit être un entier !");
				return;
			}
			this.fontSizeToolStripButton.Text = this.richTextBox1.SelectionFont.Size.ToString();
		}

		/// <summary>
		/// Alignement à gauche de la police.
		/// </summary>
		/// <param name="sender">Voir la documentation MSDN.</param>
		/// <param name="e">Voir la documentation MSDN.</param>
		private void leftToolStripButton_Click(object sender, EventArgs e) {
			richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
			leftToolStripButton.Checked = true;
			rightToolStripButton.Checked = false;
			centerToolStripButton.Checked = false;
		}

		/// <summary>
		/// Centrage du texte.
		/// </summary>
		/// <param name="sender">Voir la documentation MSDN.</param>
		/// <param name="e">Voir la documentation MSDN.</param>
		private void centerToolStripButton_Click(object sender, EventArgs e) {
			richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
			leftToolStripButton.Checked = false;
			centerToolStripButton.Checked = true;
			rightToolStripButton.Checked = false;
		}

		/// <summary>
		/// Alignement à droite de la police.
		/// </summary>
		/// <param name="sender">Voir la documentation MSDN.</param>
		/// <param name="e">Voir la documentation MSDN.</param>
		private void rightToolStripButton_Click(object sender, EventArgs e) {
			richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
			leftToolStripButton.Checked = false;
			centerToolStripButton.Checked = false;
			rightToolStripButton.Checked = true;
		}

		/// <summary>
		/// Création d'une liste dans le texte.
		/// </summary>
		/// <param name="sender">Voir la documentation MSDN.</param>
		/// <param name="e">Voir la documentation MSDN.</param>
		private void bulletToolStripButton_Click(object sender, EventArgs e) {
			this.richTextBox1.SelectionBullet = bulletToolStripButton.Checked;
		}

		/// <summary>
		/// Survient lorsque le texte change.
		/// </summary>
		/// <param name="sender">Voir la documentation MSDN.</param>
		/// <param name="e">Voir la documentation MSDN.</param>
		private void richTextBox1_RTFTextChanged(object sender, EventArgs e) {
			if (OnChange != null) OnChange(this, EventArgs.Empty);
			m_RTFTextChanged = true;
		}

		private void UndoToolStripButton_Click(object sender, EventArgs e) {
			this.richTextBox1.Undo();
		}

		private void RedoToolStripButton_Click(object sender, EventArgs e) {
			this.richTextBox1.Redo();
		}

		private void DateToolStripButton_Click(object sender, EventArgs e) {
			FormDateTime frmDateTime = new FormDateTime();


			if (frmDateTime.ShowDialog(this) == DialogResult.OK) {
				this.richTextBox1.InsertTextAsRtf(frmDateTime.lstDateTime.Text, richTextBox1.SelectionFont);
				this.richTextBox1.Focus();
			}
		}

		private void SurligneToolStripButton_Click(object sender, EventArgs e) {
			if (richTextBox1.SelectionBackColor != Color.Yellow)
				richTextBox1.SelectionBackColor = Color.Yellow;
			else
				richTextBox1.SelectionBackColor = Color.Transparent;
		}

        private void toolStripColorPicker1_SelectedColorChanged(object sender, EventArgs e) {
            richTextBox1.SelectionColor = toolStripColorPicker1.Color;
        }
	}
}
