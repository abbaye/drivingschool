// *****************************************************************************
// 
//  (c) Crownwood Consulting Limited 2002-2003
//  All rights reserved. The software and associated documentation 
//  supplied hereunder are the proprietary information of Crownwood Consulting 
//	Limited, Crownwood, Bracknell, Berkshire, England and are supplied subject 
//  to licence terms.
// 
//  Magic Version 1.7.4.0 	www.dotnetmagic.com
// *****************************************************************************

using System.Collections;

namespace Crownwood.Magic.Menus
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
