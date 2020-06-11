using System;
using System.Collections;
using UtilityLibrary.WinControls;

namespace UtilityLibrary.Collections
{
    /// <summary>
    /// Summary description for OutlookBarBandCollection.
    /// </summary>
    public class OutlookBarBandCollection  : CollectionBase, IEnumerable
	{
		
		#region Events
        public event EventHandler Changed;
        #endregion

        #region Class Variables
        // Back reference to the parent control
        readonly OutlookBar parentBar = null;
		#endregion

		#region Constructors
		public OutlookBarBandCollection(OutlookBar bar)
		{
			parentBar = bar;
		}
		#endregion

		#region Methods
        public int Add(OutlookBarBand band)
		{
			
			if (Contains(band)) return -1;
			int index = InnerList.Add(band);
			RaiseChanged();
			return index;
		}

		public bool Contains(OutlookBarBand band)
		{
			return InnerList.Contains(band);
		}
	
		public int IndexOf(OutlookBarBand band)
		{
			return InnerList.IndexOf(band);
		}
	
		public void Remove(OutlookBarBand band)
		{
			// Make sure currentBandIndex is always valid
			int currentBandIndex = parentBar.GetCurrentBand();
			bool updateCurrentIndex = currentBandIndex != -1 && currentBandIndex == Count - 1;
			InnerList.Remove(band);
			if ( updateCurrentIndex )
			{
                // Since we just removed the currently selected band,
                // set the new selected band to last band
				if ( Count > 0 )
					parentBar.SetCurrentBand(Count-1);
			}
			
			RaiseChanged();		
		}
		
		public OutlookBarBand this[int index]
		{
			get {
                return index < 0 || index >= Count ? null : (OutlookBarBand) InnerList[index];
            }
        }
		#endregion
	
		#region Implementation
        void RaiseChanged()
		{
			if (Changed != null) Changed(this, null);
		}
		#endregion

	}
}
