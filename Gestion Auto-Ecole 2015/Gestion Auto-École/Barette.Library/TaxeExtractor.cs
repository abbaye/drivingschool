using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barette.Library {
    
    /// <summary>
    /// Classe servant à extraire la taxe d'un montant donnée
    /// </summary>
    public class TaxeExtractor {

        /// <summary>
        /// Structure gerant la taxe
        /// </summary>
        public struct Taxe {
            /// <summary>
            /// Valeur de la TPS
            /// </summary>
            public decimal TPS;
            /// <summary>
            /// Valeur de la TVQ
            /// </summary>
            public decimal TVQ;
            /// <summary>
            /// Valeur avant taxe
            /// </summary>
            public decimal NoTaxe;
            /// <summary>
            /// Taux de la TPS
            /// </summary>
            public decimal TauxTPS;
            /// <summary>
            /// Taux de la TVQ
            /// </summary>
            public decimal TauxTVQ;

            /// <summary>
            /// Retourne le valeur total de la structure
            /// </summary>
            public decimal Total {
                get {
                    return NoTaxe + TPS + TVQ;
                }
            }

            /// <summary>
            /// Retourne la valeur total sous form "0,00 $"
            /// </summary>
            /// <returns></returns>
            public override string ToString() {
                return (NoTaxe + TPS + TVQ).ToString() + " $";
            }
        }

        /// <summary>
        /// Annee sur lequel calculer la taxe
        /// </summary>
        public enum Years {
            Y2008_to_2010,
            Y2011,
            Y2012,
            Y2014
        }

        private decimal _montant;
        private Years _years;
                
        /// <summary>
        /// Cree un objet de type TaxeExtractor selon les parametres
        /// </summary>
        public TaxeExtractor(decimal montant, Years years) {
            _montant = montant;
            _years = years;
        }

        /// <summary>
        /// Cree un objet de type TaxeExtractor vide
        /// </summary>
        public TaxeExtractor() {
        }

        /// <summary>
        /// Extrait les taxe de this.montant et renvoie une structure de taxe
        /// </summary>
        /// <returns></returns>
        private Taxe Extract() {
            Taxe tax = new Taxe();
                                    
            switch (_years)
            {
                case Years.Y2008_to_2010:
                    tax.NoTaxe = decimal.Round((_montant / 112.875M) * 100, 2);

                    tax.TPS = decimal.Round(tax.NoTaxe * 0.05M, 2);
                    tax.TVQ = decimal.Round((tax.NoTaxe + tax.TPS) * 0.075M, 2);
                    tax.TauxTPS = 0.05M;
                    tax.TauxTVQ = 0.075M;
                    break;
                case Years.Y2011:
                    tax.NoTaxe = decimal.Round((_montant / 113.925M) * 100, 2);

                    tax.TPS = decimal.Round(tax.NoTaxe * 0.05M, 2);
                    tax.TVQ = decimal.Round((tax.NoTaxe + tax.TPS) * 0.085M, 2);
                    tax.TauxTPS = 0.05M;
                    tax.TauxTVQ = 0.085M;
                    break;
                case Years.Y2012:
                    tax.NoTaxe = decimal.Round((_montant / 114.975M) * 100, 2);

                    tax.TPS = decimal.Round(tax.NoTaxe * 0.05M, 2);
                    tax.TVQ = decimal.Round((tax.NoTaxe + tax.TPS) * 0.095M, 2);
                    tax.TauxTPS = 0.05M;
                    tax.TauxTVQ = 0.095M;
                    break;
                case Years.Y2014:
                    tax.NoTaxe = decimal.Round((_montant / 114.975M) * 100, 2);

                    tax.TPS = decimal.Round(tax.NoTaxe * 0.05M, 2);
                    tax.TVQ = decimal.Round(tax.NoTaxe * 0.0975M, 2);
                    tax.TauxTPS = 0.05M;
                    tax.TauxTVQ = 0.0975M;
                    break;
            }

            return tax;
        }

        /// <summary>
        /// Get/Set l'annee sur lequel calculer la taxe
        /// </summary>
        public Years years {
            get {
                return _years;
            }
            set {
                _years = value;
            }
        }

        /// <summary>
        /// Get/Set le sur lequel extraire la taxe
        /// </summary>
        public decimal Montant {
            get {
                return _montant;
            }
            set {
                _montant = value;
            }
        }
        
        /// <summary>
        /// Retourne le une structure de taxe remplie.
        /// </summary>
        public Taxe Value {
            get {
                return Extract();
            }
        }
    }
}
