namespace Barette.Library.Collections
{
    /// <summary>
    /// Collection de Client.
    /// Des fonctions seront ajouté plus tard en rapport avec la collectionB
    /// </summary>
    public class PostItCollection : CollectionWithEvents {
		public PostIt Add(PostIt value) {
			base.List.Add(value as object);

			return value;
		}

		public void AddRange(PostIt[] values) {
			foreach(PostIt item in values)
				Add(item);
		}

        public void Remove(PostIt value) => base.List.Remove(value as object);

        public void Insert(int index, PostIt value) => base.List.Insert(index, value as object);

        public bool Contains(PostIt value) {
			foreach(PostIt s in base.List)
				if (value.Equals(s))
					return true;

			return false;
		}

		public bool Contains(PostItCollection values) {
			foreach(PostIt c in values) {
				if (Contains(c))
					return true;
			}

			return false;
		}

		public PostIt this[int index] {
			get { return base.List[index] as PostIt; }
		}

        public int IndexOf(PostIt value) => base.List.IndexOf(value);
    }
}
