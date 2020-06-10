using System.Collections;

namespace UtilityLibrary.Menus
{
    public class MenuControlDesigner :  System.Windows.Forms.Design.ParentControlDesigner
	{
		public override ICollection AssociatedComponents
		{
			get 
			{
				if (base.Control is MenuControl)
					return ((MenuControl)base.Control).MenuCommands;
				else
					return base.AssociatedComponents;
			}
		}

		protected override bool DrawGrid
		{
			get { return false; }
		}
	}
}
