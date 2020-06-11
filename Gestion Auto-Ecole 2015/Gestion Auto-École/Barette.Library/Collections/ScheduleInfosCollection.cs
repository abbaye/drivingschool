
using Barette.Library.UserControls.Schedule;

namespace Barette.Library.Collections
{
    /// <summary>
    /// Collection d'information sur les schedules de cours.
    /// Des fonctions seront ajouté plus tard en rapport avec la collectionB
    /// </summary>
    public class ScheduleInfosCollection : CollectionWithEvents {
		public ScheduleInfos Add(ScheduleInfos value) {
			base.List.Add(value as object);

			return value;
		}

		public void AddRange(ScheduleInfos[] values) {
			foreach(ScheduleInfos item in values)
				Add(item);
		}

		public void Remove(ScheduleInfos value) {
			base.List.Remove(value as object);
		}

		public void Insert(int index, ScheduleInfos value) {
			base.List.Insert(index, value as object);
		}

		public bool Contains(ScheduleInfos value) {
			foreach(ScheduleInfos s in base.List)
				if (value.Equals(s))
					return true;

			return false;
		}

		public bool Contains(ScheduleInfosCollection values) {
			foreach(ScheduleInfos c in values) {
				if (Contains(c))
					return true;
			}

			return false;
		}

		public ScheduleInfos this[int index] {
			get { return base.List[index] as ScheduleInfos; }
		}

		public int IndexOf(ScheduleInfos value) {
			return base.List.IndexOf(value);
		}
	}
}
