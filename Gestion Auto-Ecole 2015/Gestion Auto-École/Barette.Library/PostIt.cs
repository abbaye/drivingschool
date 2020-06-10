#region Using directives

using System;

#endregion

namespace Barette.Library
{
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
				return _Employe;
			}
			set {
                _Employe = value;
			}
		}


		public string Message {
			get {
				return _Message;
			}
			set {
                _Message = value;
			}
		}

		public bool Alerte {
			get {
				return _Alerte;
			}
			set {
                _Alerte = value;
			}
		}

		public DateTime AlerteDateTime {
			get {
				return _AlerteDateTime;
			}
			set {
                _AlerteDateTime = value;
			}
		}

		/// <summary>
		/// Date du postit
		/// </summary>
		/// <value></value>
		public DateTime Date {
			get {
				return _Date;
			}
			set {
                _Date = value;
			}
		}
	}
}
