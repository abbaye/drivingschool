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

using Crownwood.Magic.Controls;

namespace Crownwood.Magic.Collections
{
    public class WizardPageCollection : CollectionWithEvents
    {
        public WizardPage Add(TabPage value)
        {
            // Create a WizardPage from the TabPage
            WizardPage wp = new WizardPage
            {
                Title = value.Title,
                Control = value.Control,
                ImageIndex = value.ImageIndex,
                ImageList = value.ImageList,
                Icon = value.Icon,
                Selected = value.Selected,
                StartFocus = value.StartFocus
            };

            return Add(wp);           
        }
    
        public WizardPage Add(WizardPage value)
        {
            // Use base class to process actual collection operation
            base.List.Add(value as object);

            return value;
        }

        public void AddRange(WizardPage[] values)
        {
            // Use existing method to add each array entry
            foreach(WizardPage page in values)
                Add(page);
        }

        public void Remove(WizardPage value)
        {
            // Use base class to process actual collection operation
            base.List.Remove(value as object);
        }

        public void Insert(int index, WizardPage value)
        {
            // Use base class to process actual collection operation
            base.List.Insert(index, value as object);
        }
        public bool Contains(WizardPage value)
        {
            // Use base class to process actual collection operation
            return base.List.Contains(value as object);
        }

        public WizardPage this[int index]
        {
            // Use base class to process actual collection operation
            get { return base.List[index] as WizardPage; }
        }

        public WizardPage this[string title]
        {
            get 
            {
                // Search for a Page with a matching title
                foreach(WizardPage page in base.List)
                    if (page.Title == title)
                        return page;

                return null;
            }
        }

        public int IndexOf(WizardPage value)
        {
            // Find the 0 based index of the requested entry
            return base.List.IndexOf(value);
        }
    }
}
