using System;

namespace Barette.Library
{
    public static class DateTimeFunc {		
		/// <summary>
		/// Format l'heure sous forme 00h00
		/// </summary>
		/// <param name="hoursToFormat">Heure � formater</param>
		/// <returns></returns>
		public static string FormatHour(DateTime hoursToFormat) {
			string minute = "";
			string hours = "";

			if (hoursToFormat.Minute == 0)
				minute = "00";
			else minute = hoursToFormat.Minute < 10 ? "0" + hoursToFormat.Minute : hoursToFormat.Minute.ToString();

            hours = hoursToFormat.Hour < 10 ? "0" + hoursToFormat.Hour : hoursToFormat.Hour.ToString();

            return hours + "h" + minute;
		}

		/// <summary>
		/// Retourne un DateTime a partir d'une strign de format 00h00;
		/// </summary>
		/// <param name="hours"></param>
		/// <returns></returns>
		public static DateTime HoursFromString(string hours) {
			return DateTime.Parse(hours.ToUpper().Replace("H", ":")); 
		}

		/// <summary>
		/// Verifie si une heures est entre une autre.
		/// </summary>
		/// <param name="HeureBasse">Heure la plus basse</param>
		/// <param name="HeureEntre">Heure � v�rifier si elle est entre HeureBasse et HeureHaute</param>
		/// <param name="HeureHaute">Heure la plus haute</param>
		/// <returns>Retourne vrai si l'heure est entre HeureBasse et HeureHaute</returns>
		public static bool HoursIsBetween(DateTime HeureBasse, DateTime HeureEntre, DateTime HeureHaute) {
            return HeureBasse.TimeOfDay <= HeureEntre.TimeOfDay &&
				HeureHaute.TimeOfDay > HeureEntre.TimeOfDay;
        }

		/// <summary>
		/// Retourne la valeur francaise de DayofWeek
		/// </summary>
		/// <param name="day"></param>
		/// <returns></returns>
		public static string DayOfWeekFRShort(DayOfWeek day) {
			switch (day) {
				case DayOfWeek.Friday:
					return "Ven.";
				case DayOfWeek.Monday:
					return "Lun.";
				case DayOfWeek.Saturday:
					return "Sam.";
				case DayOfWeek.Sunday:
					return "Dim.";
				case DayOfWeek.Thursday:
					return "Jeu.";
				case DayOfWeek.Tuesday:
					return "Mar.";
				case DayOfWeek.Wednesday:
					return "Mer.";
			}

			return "";
		}

		/// <summary>
		/// Retourne la valeur francaise de DayofWeek
		/// </summary>
		/// <param name="day"></param>
		/// <returns></returns>
		public static string DayOfWeekFRLong(DayOfWeek day) {
			switch (day) {
				case DayOfWeek.Friday:
					return "Vendredi";
				case DayOfWeek.Monday:
					return "Lundi";
				case DayOfWeek.Saturday:
					return "Samedi";
				case DayOfWeek.Sunday:
					return "Dimanche";
				case DayOfWeek.Thursday:
					return "Jeudi";
				case DayOfWeek.Tuesday:
					return "Mardi";
				case DayOfWeek.Wednesday:
					return "Mercredi";
			}

			return "";
		}
	}
}
