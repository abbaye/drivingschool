using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Barette.Library.UserControls
{
    /// <summary>
    /// Label avec un degrader
    /// </summary>
    [ToolboxItem(true)]
	public class GradientLabel : Label {
		private Color _ColorLeft  = SystemColors.ControlLightLight;
		private Color _ColorRight = SystemColors.Control;

		/// <summary>
		/// Creation du degrader en arriere plan
		/// </summary>		
		protected override void OnPaintBackground(PaintEventArgs pe) {
			base.OnPaintBackground(pe);
			Graphics g = pe.Graphics;
			g.FillRectangle(new SolidBrush(SystemColors.Control), pe.ClipRectangle);
		
			g.FillRectangle(new LinearGradientBrush(new Point(0, 0), new Point(Width, Height),
                _ColorLeft, _ColorRight),
				new Rectangle(0, 0, Width, Height));
		}

		[Category("Couleur")]
		public Color CouleurGauche{
			get{
				return _ColorLeft;
			}
			set{
                _ColorLeft = value;
			}
		}

		[Category("Couleur")]
		public Color CouleurDroite{
			get{
				return _ColorRight;
			}
			set{
                _ColorRight = value;				
			}
		}
	}
}
