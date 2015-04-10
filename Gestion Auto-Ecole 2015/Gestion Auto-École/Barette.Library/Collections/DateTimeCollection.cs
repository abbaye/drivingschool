using System;
using System.Collections;

using Barette.Library.Client;

namespace Barette.Library.Collections {
	/// <summary>
	/// Collection typé DateTime.
	/// Des fonctions seront ajouté plus tard en rapport avec la collectionB
	/// </summary>
	public class DateTimeCollection : CollectionWithEvents {
		public DateTime Add(DateTime value) {
			base.List.Add(value as object);

			return value;
		}

		public void AddRange(DateTime[] values) {
			foreach(DateTime item in values)
				Add(item);
		}

		public void Remove(DateTime value) {
			base.List.Remove(value as object);
		}

		public void Insert(int index, DateTime value) {
			base.List.Insert(index, value as object);
		}

		public bool Contains(DateTime value) {
			foreach(DateTime s in base.List)
				if (value.Equals(s))
					return true;

			return false;
		}

		public bool Contains(DateTimeCollection values) {
			foreach(DateTime c in values) {
				if (Contains(c))
					return true;
			}

			return false;
		}

		public DateTime this[int index] {
			//get { return (base.List[index] as System.DateTime); }
			get{
				return  Convert.ToDateTime(base.List[index]); 
			}
		}

		public int IndexOf(DateTime value) {
			return base.List.IndexOf(value);
		}		
	}
}
