namespace Barette.Library.Collections
{
    /// <summary>
    /// Collection de Client.
    /// Des fonctions seront ajouté plus tard en rapport avec la collectionB
    /// </summary>
    public class OffDateCollection : CollectionWithEvents {
		public OffDate Add(OffDate value) {
			base.List.Add(value as object);

			return value;
		}

		public void AddRange(OffDate[] values) {
			foreach (OffDate item in values)
				Add(item);
		}

		public void Remove(OffDate value) {
			base.List.Remove(value as object);
		}

		public void Insert(int index, OffDate value) {
			base.List.Insert(index, value as object);
		}

		public bool Contains(OffDate value) {
			foreach (OffDate s in base.List)
				if (value.Equals(s))
					return true;

			return false;
		}

		public bool Contains(OffDateCollection values) {
			foreach (OffDate c in values) {
				if (Contains(c))
					return true;
			}

			return false;
		}

		public OffDate this[int index] {
			get { return base.List[index] as OffDate; }
		}

		public int IndexOf(OffDate value) {
			return base.List.IndexOf(value);
		}
	}
}
