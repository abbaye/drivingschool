using System.Collections;

namespace UtilityLibrary.Menus
{
    public class MenuControlDesigner :  System.Windows.Forms.Design.ParentControlDesigner
	{
		public override ICollection AssociatedComponents
		{
			get 
			{
                return base.Control is MenuControl ? ((MenuControl)base.Control).MenuCommands : base.AssociatedComponents;
            }
		}

		protected override bool DrawGrid
		{
			get { return false; }
		}
	}
}
