using System;

using Barette.Library.Client;
using Barette.Library.Collections;

namespace Barette.Library.UserControls.Schedule
{
    /// <summary>
    /// CLASSE NON COMPLETE
    /// </summary>
    public class ScheduleOverlaps {
		CustomerCollection _Clientlist = null;
		string _Employe = null;

		public CustomerCollection ClientList {
			set {
                _Clientlist = value;
			}
			get {
				return _Clientlist;
			}
		}

		public string Employer {
			set {
                _Employe = value;
			}
			get {
				return _Employe;
			}
		}

		/// <summary>
		/// Cette fonction verifie qu'il n'y a pas de cours de seduler pour l'employer a la date inscrite dans la valeur date
		/// </summary>
		/// <param name="date"></param>
		/// <param name="Employer"></param>
		/// <returns></returns>
		public bool IsScheduleOverlaps(DateTime date) {
			Customer client = null;
			Seance cours = null;
			DateTime HeureBasse = new DateTime();
			//DateTime HeureHaute = new DateTime();

			//Calcule de l'heure basse
			HeureBasse = date;
			

			//Cacule de l'heure haute
			
			//TODO: Verifier les variavle this._employer et this._ClientList pour quel soit initialiser


			//Parcour la liste de client
			for (int i = 0; i < _Clientlist.Count; i++) {
				//Parcour chaque seance de cours pour le client en cours
				client = _Clientlist[i];
				for (int j = 0; j < client.Seances.Count; j++) {
					//Verifie qu'il n'y a pas deja un cours a la date et l'heure pour l'employer
					cours = client.Seances[j];
					if (Employer == cours.Employer) {
						//Verifie pour la date et l'heure
						//if (DateTimeFunc.HoursIsBetween())
					}
				}
			}

			//Retourne false si la fonction n'a rien trouver
			return false;
		}
	}
}
