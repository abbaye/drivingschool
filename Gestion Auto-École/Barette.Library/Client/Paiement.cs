using System;

namespace Barette.Library.Client {
	/// <summary>
	/// Description résumée de Paiment.
	/// </summary>
	public class Paiement {
		private DateTime		_date;
		private TypePaiment		_typePaiment;
		private string			_PaimentAutre;
		private string			_montant;
		private int				_numeroRecu;
		private PaiementType	_Type; //retour de livre

		public Paiement() {
            this.Montant = "0,00 $";
            this._date = DateTime.Now;
            this._numeroRecu = 0;
            this._PaimentAutre = "";
            this._Type = PaiementType.Nothing;
            this._typePaiment = Client.TypePaiment.Nothing;
		}

		/// <summary>
		/// Donne la valeur du textbox sans le $ (integer)
		/// </summary>
		public double Value {
			get {
				//if (this.Text == "") this.Text = "0 $";
				try {
					string temp = "";
					//Corrige une bug lors de la rentrer d<une virgule
					temp = this._montant.Replace(".", ",");
					
					return Convert.ToDouble(this._montant.Replace(" $", ""));
				} catch {
					return 0;
				}
			}
		}

		public DateTime DatePaiment{
			get{
				return this._date;
			}
			set{
				this._date = value;
			}
		}

		public TypePaiment TypePaiment {
			get{
				return this._typePaiment;
			}
			set{
				this._typePaiment = value;
			}
		}
		
		public string Montant{
			get{
				return this._montant;
			}
			set{
				this._montant = value;
			}
		}

		public string PaimentAutre{
			get{
				return this._PaimentAutre;
			}
			set{
				this._PaimentAutre = value;
			}
		}

		public int NumeroRecu{
			get{
				return this._numeroRecu;
			}
			set{
				this._numeroRecu = value;
			}
		}

		public PaiementType Type{
			get{
				return this._Type;
			}
			set{
				this._Type = value;
			}
		}
	}
}
