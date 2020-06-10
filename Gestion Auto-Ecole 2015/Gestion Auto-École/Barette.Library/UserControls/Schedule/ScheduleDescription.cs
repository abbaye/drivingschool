using System;

using Barette.Library.Collections;

namespace Barette.Library.UserControls.Schedule
{
    public class ScheduleDescription {
		private ScheduleInfosCollection _Schedule = new ScheduleInfosCollection();
		private DateTime _Day;
		private string _MonitorName;

		/// <summary>
		/// Date du jours
		/// </summary>
		public DateTime Jour {
			get {
				return _Day;
			}
			set {
                _Day = value;
			}
		}

		/// <summary>
		/// Nom du moniteur
		/// </summary>
		public string NomMoniteur {
			get {
				return _MonitorName;
			}
			set {
                _MonitorName = value;
			}
		}


		/// <summary>
		/// Horaire du jour
		/// </summary>
		public ScheduleInfosCollection HoraireJour {
			get {
				return _Schedule;
			}
			set {
                _Schedule = value;
			}
		}
	}
}
