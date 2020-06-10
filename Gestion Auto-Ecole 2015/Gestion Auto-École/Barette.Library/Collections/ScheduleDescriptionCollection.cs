
using Barette.Library.UserControls.Schedule;

namespace Barette.Library.Collections
{
    /// <summary>
    /// Collection d'information sur les schedules de cours.
    /// Des fonctions seront ajouté plus tard en rapport avec la collectionB
    /// </summary>
    public class ScheduleDescriptionCollection : CollectionWithEvents {
		public ScheduleDescription Add(ScheduleDescription value) {
			base.List.Add(value as object);

			return value;
		}

		public void AddRange(ScheduleDescription[] values) {
			foreach(ScheduleDescription item in values)
				Add(item);
		}

		public void Remove(ScheduleDescription value) {
			base.List.Remove(value as object);
		}

		public void Insert(int index, ScheduleDescription value) {
			base.List.Insert(index, value as object);
		}

		public bool Contains(ScheduleDescription value) {
			foreach(ScheduleDescription s in base.List)
				if (value.Equals(s))
					return true;

			return false;
		}

		public bool Contains(ScheduleDescriptionCollection values) {
			foreach(ScheduleDescription c in values) {
				if (Contains(c))
					return true;
			}

			return false;
		}

		public ScheduleDescription this[int index] {
			get { return (base.List[index] as ScheduleDescription); }
		}

		public int IndexOf(ScheduleDescription value) {
			return base.List.IndexOf(value);
		}
	}
}
