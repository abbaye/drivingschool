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
				return this._DateHeure;
			}
			set{
				this._DateHeure = value;
			}
		}

		public DateTime DateModified{
			get{
				return this._DateModified;
			}
			set{
				this._DateModified = value;
			}
		}

		public bool Active{
			get{
				return this._Active;
			}
			set{
				this._Active = value;
			}
		}

		public bool Absence {
			get{
				return this._Absence;
			}
			set{
				this._Absence = value;
			}
		}

		public bool DateModifiedChecked {
			get{
				return this._DateModifiedChecked;
			}
			set{
				this._DateModifiedChecked = value;
			}
		}

		public int SceanceNumber{
			get{
				return this._SceanceNumber;
			}
			set{
				this._SceanceNumber = value;
			}
		}

		public string Code{
			get{
				return this._code;
			}
			set{
				this._code = value;
			}
		}

		public string Employer{
			get{
				return this._Employer;
			}
			set{
				this._Employer = value;
			}
		}

		public string Montant{
			get{
				return this._Montant;
			}
			set{
				this._Montant = value;
			}
		}
	}
}
