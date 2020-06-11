
using Barette.Library.Client;

namespace Barette.Library.Collections
{
    /// <summary>
    /// Collection de Paiment.
    /// Des fonctions seront ajouté plus tard en rapport avec la collectionB
    /// </summary>
    public class PaimentCollection : CollectionWithEvents {
		public Paiement Add(Paiement value) {
			base.List.Add(value as object);

			return value;
		}

		public void AddRange(Paiement[] values) {
			foreach(Paiement item in values)
				Add(item);
		}

		public void Remove(Paiement value) {
			base.List.Remove(value as object);
		}

		public void Insert(int index, Paiement value) {
			base.List.Insert(index, value as object);
		}

		public bool Contains(Paiement value) {
			foreach(Paiement s in base.List)
				if (value.Equals(s))
					return true;

			return false;
		}

		public bool Contains(PaimentCollection values) {
			foreach(Paiement c in values) {
				if (Contains(c))
					return true;
			}

			return false;
		}

		public Paiement this[int index] {
			get { return base.List[index] as Paiement; }
		}

		public int IndexOf(Paiement value) {
			return base.List.IndexOf(value);
		}

        /// <summary>
        /// Retourne la valeur total des paiments dans la collection (Taxe incluse)
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalPaiment() {
            decimal total = 0;

            foreach (Paiement paiment in this)
                total += (decimal)paiment.Value;

            return total;
        }
	}
}
