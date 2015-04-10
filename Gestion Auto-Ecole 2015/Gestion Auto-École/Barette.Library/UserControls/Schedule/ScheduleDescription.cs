using System;
using System.Collections.Generic;
using System.Text;

using Barette.Library.Collections;

namespace Barette.Library.UserControls.Schedule {
	public class ScheduleDescription {
		private ScheduleInfosCollection _Schedule = new ScheduleInfosCollection();
		private DateTime _Day;
		private string _MonitorName;

		/// <summary>
		/// Date du jours
		/// </summary>
		public DateTime Jour {
			get {
				return this._Day;
			}
			set {
				this._Day = value;
			}
		}

		/// <summary>
		/// Nom du moniteur
		/// </summary>
		public string NomMoniteur {
			get {
				return this._MonitorName;
			}
			set {
				this._MonitorName = value;
			}
		}


		/// <summary>
		/// Horaire du jour
		/// </summary>
		public ScheduleInfosCollection HoraireJour {
			get {
				return this._Schedule;
			}
			set {
				this._Schedule = value;
			}
		}
	}
}
