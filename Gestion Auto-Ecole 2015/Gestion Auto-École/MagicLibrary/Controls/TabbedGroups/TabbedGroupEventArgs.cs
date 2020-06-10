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

using System.Xml;
using Crownwood.Magic.Menus;

namespace Crownwood.Magic.Controls
{
    public class TGCloseRequestEventArgs
	{
	    protected TabGroupLeaf _tgl;
	    protected TabControl _tc;
	    protected TabPage _tp;
	    protected bool _cancel;
	
		public TGCloseRequestEventArgs(TabGroupLeaf tgl, TabControl tc, TabPage tp)
		{
		    // Definie initial state
		    _tgl = tgl;
		    _tc = tc;
		    _tp = tp;
		    _cancel = false;
		}
		
		public TabGroupLeaf Leaf
		{
		    get { return _tgl; }
		}
    
        public TabControl TabControl
        {
            get { return _tc; }
        }

        public TabPage TabPage
        {
            get { return _tp; }
        }
        
        public bool Cancel
        {
            get { return _cancel; }
            set { _cancel = value; }
        }
    }

    public class TGContextMenuEventArgs : TGCloseRequestEventArgs
    {
        protected PopupMenu _contextMenu;
	
        public TGContextMenuEventArgs(TabGroupLeaf tgl, TabControl tc,
                                      TabPage tp, PopupMenu contextMenu)
            : base(tgl, tc, tp)
        {
            // Definie initial state
            _contextMenu = contextMenu;
        }
		
        public PopupMenu ContextMenu
        {
            get { return _contextMenu; }
        }    
    }
    
    public class TGPageLoadingEventArgs
    {
        protected TabPage _tp;
        protected XmlTextReader _xmlIn;
        protected bool _cancel;
        
        public TGPageLoadingEventArgs(TabPage tp, XmlTextReader xmlIn)
        {
            // Definie initial state
            _tp = tp;
            _xmlIn = xmlIn;
            _cancel = false;
        }
        
        public TabPage TabPage
        {
            get { return _tp; }
        }
        
        public XmlTextReader XmlIn
        {
            get { return _xmlIn; }
        }
        
        public bool Cancel
        {
            get { return _cancel; }
            set { _cancel = value; }
        }
    }    

    public class TGPageSavingEventArgs
    {
        protected TabPage _tp;
        protected XmlTextWriter _xmlOut;
        
        public TGPageSavingEventArgs(TabPage tp, XmlTextWriter xmlOut)
        {
            // Definie initial state
            _tp = tp;
            _xmlOut = xmlOut;
        }
        
        public TabPage TabPage
        {
            get { return _tp; }
        }
        
        public XmlTextWriter XmlOut
        {
            get { return _xmlOut; }
        }
    }    
}
