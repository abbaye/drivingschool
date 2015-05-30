using System;
using Barette.Library;

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
            Montant = "0,00 $";
            _date = DateTime.Now;
            _numeroRecu = 0;
            _PaimentAutre = "";
            _Type = PaiementType.Nothing;
            _typePaiment = Client.TypePaiment.Nothing;
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
					temp = _montant.Replace(".", ",");
					
					return Convert.ToDouble(_montant.Replace(" $", ""));
				} catch {
					return 0;
				}
			}
		}

        /// <summary>
        /// Retourne un objet TaxeExtractor detaillant la valeur de l'objet
        /// </summary>
        public TaxeExtractor ValueDetails {
            get {
                TaxeExtractor taxe = new TaxeExtractor();

                if (_date.Year == 2011)
                    taxe = new TaxeExtractor(Convert.ToDecimal(Value), TaxeExtractor.Years.Y2011);
                else if (_date.Year < 2011)
                    taxe = new TaxeExtractor(Convert.ToDecimal(Value), TaxeExtractor.Years.Y2008_to_2010);
                else if (_date.Year >= 2012)
                    taxe = new TaxeExtractor(Convert.ToDecimal(Value), TaxeExtractor.Years.Y2012); 

                return taxe;
            }
        }

		public DateTime DatePaiment{
			get{
				return _date;
			}
			set{
                _date = value;
			}
		}

		public TypePaiment TypePaiment {
			get{
				return _typePaiment;
			}
			set{
                _typePaiment = value;
			}
		}
		
		public string Montant{
			get{
				return _montant;
			}
			set{
                _montant = value;
			}
		}

		public string PaimentAutre{
			get{
				return _PaimentAutre;
			}
			set{
                _PaimentAutre = value;
			}
		}

		public int NumeroRecu{
			get{
				return _numeroRecu;
			}
			set{
                _numeroRecu = value;
			}
		}

		public PaiementType Type{
			get{
				return _Type;
			}
			set{
                _Type = value;
			}
		}
	}
}
