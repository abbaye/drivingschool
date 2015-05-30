using System;

namespace Barette.Library.Client {
	/// <summary>
	/// Description résumée de Seance.
	/// </summary>
	public class Seance {
		private DateTime _DateHeure;
		private DateTime _DateModified;
		private bool _DateModifiedChecked;
		private bool _Active;
		private int _SceanceNumber;
		private string _code;
		private string _Employer;
		private bool _Absence;
		private string _Montant;

		/// <summary>
		/// Variable utilisé seulement dans les horaires (ne pas enregistrer)
		/// Client Parent
		/// </summary>
		public Customer Client;

		public Seance() {
			
		}

		public DateTime DateHeure{
			get{
				return _DateHeure;
			}
			set{
                _DateHeure = value;
			}
		}

		public DateTime DateModified{
			get{
				return _DateModified;
			}
			set{
                _DateModified = value;
			}
		}

		public bool Active{
			get{
				return _Active;
			}
			set{
                _Active = value;
			}
		}

		public bool Absence {
			get{
				return _Absence;
			}
			set{
                _Absence = value;
			}
		}

		public bool DateModifiedChecked {
			get{
				return _DateModifiedChecked;
			}
			set{
                _DateModifiedChecked = value;
			}
		}

		public int SceanceNumber{
			get{
				return _SceanceNumber;
			}
			set{
                _SceanceNumber = value;
			}
		}

		public string Code{
			get{
				return _code;
			}
			set{
                _code = value;
			}
		}

		public string Employer{
			get{
				return _Employer;
			}
			set{
                _Employer = value;
			}
		}

		public string Montant{
			get{
				return _Montant;
			}
			set{
                _Montant = value;
			}
		}
	}
}
