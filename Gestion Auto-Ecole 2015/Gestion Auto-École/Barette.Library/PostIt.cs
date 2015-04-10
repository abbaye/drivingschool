#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Barette.Library {
	/// <summary>
	/// Classe PostIt, Cette classe est utilisé pour le module de notes
	/// </summary>
	public class PostIt {
		private string _Message = "";
		private bool _Alerte = false;
		private DateTime _AlerteDateTime;
		private DateTime _Date;
		private string _Employe;

		public PostIt() {

		}

		public string Employe {
			get {
				return this._Employe;
			}
			set {
				this._Employe = value;
			}
		}


		public string Message {
			get {
				return this._Message;
			}
			set {
				this._Message = value;
			}
		}

		public bool Alerte {
			get {
				return this._Alerte;
			}
			set {
				this._Alerte = value;
			}
		}

		public DateTime AlerteDateTime {
			get {
				return this._AlerteDateTime;
			}
			set {
				this._AlerteDateTime = value;
			}
		}

		/// <summary>
		/// Date du postit
		/// </summary>
		/// <value></value>
		public DateTime Date {
			get {
				return this._Date;
			}
			set {
				this._Date = value;
			}
		}
	}
}
