using System;
using System.Collections;

using Barette.Library.Client;

namespace Barette.Library.Collections {
	/// <summary>
	/// Collection de Client.
	/// Des fonctions seront ajouté plus tard en rapport avec la collectionB
	/// </summary>
	public class SeanceCollection : CollectionWithEvents {
		public Seance Add(Seance value) {
			base.List.Add(value as object);

			return value;
		}

		public void AddRange(Seance[] values) {
			foreach(Seance item in values)
				Add(item);
		}

		public void Remove(Seance value) {
			base.List.Remove(value as object);
		}

		public void Insert(int index, Seance value) {
			base.List.Insert(index, value as object);
		}

		public bool Contains(Seance value) {
			foreach(Seance s in base.List)
				if (value.Equals(s))
					return true;

			return false;
		}

		public bool Contains(SeanceCollection values) {
			foreach(Seance c in values) {
				if (Contains(c))
					return true;
			}

			return false;
		}

		public Seance this[int index] {
			get { return (base.List[index] as Seance); }
		}

		public int IndexOf(Seance value) {
			return base.List.IndexOf(value);
		}		
	}
}
