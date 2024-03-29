using System;
using System.Drawing;
using System.Windows.Forms;

namespace UtilityLibrary.WinControls
{
    /// <summary>
    /// Summary description for NumericTextBox.
    /// </summary>
    public class NumericTextBox : TextBox
    {
		private int minimum = -1;
		private int maximum = -1;
		private bool useRange = false;
		private string lastChar;
		
		public NumericTextBox()
		{
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
		}

		public Size SetRange
		{
			get 
			{
                return useRange ? new Size(minimum, maximum) : new Size(-1, -1);
            }
			set 
			{
				minimum = value.Width;
				maximum = value.Height;
				useRange = true;
			}
			
		}

		private void InitializeComponent()
		{
            this.SuspendLayout();
            // 
            // NumericTextBox
            // 
            this.ShortcutsEnabled = false;
            this.TextChanged += new EventHandler(this.NumericTextBox_TextChanged);
            this.ResumeLayout(false);

		}

	

		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			// Allow only numeric characters
			base.OnKeyPress(e);
			e.Handled = Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSeparator(e.KeyChar);
        }

        /// <summary>
        /// Valeur numerique du control
        /// Retourne -1 en cas de probleme
        /// </summary>
        public int Value {
            get {
                try {
                    return Convert.ToInt32(this.Text);
                } catch {
                    return -1;
                }
            }
            set {
                this.Text = value.ToString();
            }
        }
				

		private void NumericTextBox_TextChanged(object sender, EventArgs e)
		{
			if ( useRange ) 
			{
				if ( Text != "" ) 
				{
					int val = Convert.ToInt32(Text);
					if ( val > maximum )
					{
						Text = maximum.ToString();
					}
					else if ( val < minimum ) 
					{
						Text = minimum.ToString();
					}

					if ( Text.Length == 1 ) 
					{
						// If use delete the last character remaining
						// remember it so that if the user jumps to another
						// edit control we can put back the last digit so that
						// we don't have an empty numeric control which is not good
						lastChar = Text;
					}

				}

			}
		}


		
		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);
			if ( Text.Length == 0 && useRange )
			{
				Text = lastChar;
			}
		}
			

	}
}
