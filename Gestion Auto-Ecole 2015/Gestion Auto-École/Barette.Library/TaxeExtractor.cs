namespace Barette.Library
{
    /// <summary>
    /// Classe servant à extraire la taxe d'un montant donnée
    /// </summary>
    public class TaxeExtractor
    {
        /// <summary>
        /// Structure gerant la taxe
        /// </summary>
        public struct Taxe
        {
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
            public decimal Total => NoTaxe + TPS + TVQ;

            /// <summary>
            /// Retourne la valeur total sous form "0,00 $"
            /// </summary>
            public override string ToString() => (NoTaxe + TPS + TVQ).ToString() + " $";
        }

        /// <summary>
        /// Annee sur lequel calculer la taxe
        /// </summary>
        public enum Years
        {
            Y2008_to_2010,
            Y2011,
            Y2012,
            Y2014
        }

        /// <summary>
        /// Cree un objet de type TaxeExtractor selon les parametres
        /// </summary>
        public TaxeExtractor(decimal montant, Years years)
        {
            Montant = montant;
            this.years = years;
        }

        /// <summary>
        /// Cree un objet de type TaxeExtractor vide
        /// </summary>
        public TaxeExtractor() { }

        /// <summary>
        /// Extrait les taxe de this.montant et renvoie une structure de taxe
        /// </summary>
        private Taxe Extract()
        {
            Taxe tax = new Taxe();

            switch (years)
            {
                case Years.Y2008_to_2010:
                    tax.NoTaxe = decimal.Round(Montant / 112.875M * 100, 2);
                    tax.TPS = decimal.Round(tax.NoTaxe * 0.05M, 2);
                    tax.TVQ = decimal.Round((tax.NoTaxe + tax.TPS) * 0.075M, 2);
                    tax.TauxTPS = 0.05M;
                    tax.TauxTVQ = 0.075M;
                    break;
                case Years.Y2011:
                    tax.NoTaxe = decimal.Round(Montant / 113.925M * 100, 2);
                    tax.TPS = decimal.Round(tax.NoTaxe * 0.05M, 2);
                    tax.TVQ = decimal.Round((tax.NoTaxe + tax.TPS) * 0.085M, 2);
                    tax.TauxTPS = 0.05M;
                    tax.TauxTVQ = 0.085M;
                    break;
                case Years.Y2012:
                    tax.NoTaxe = decimal.Round(Montant / 114.975M * 100, 2);
                    tax.TPS = decimal.Round(tax.NoTaxe * 0.05M, 2);
                    tax.TVQ = decimal.Round((tax.NoTaxe + tax.TPS) * 0.095M, 2);
                    tax.TauxTPS = 0.05M;
                    tax.TauxTVQ = 0.095M;
                    break;
                case Years.Y2014:
                    tax.NoTaxe = decimal.Round(Montant / 114.975M * 100, 2);
                    tax.TPS = decimal.Round(tax.NoTaxe * 0.05M, 2);
                    tax.TVQ = decimal.Round(tax.NoTaxe * 0.09975M, 2);
                    tax.TauxTPS = 0.05M;
                    tax.TauxTVQ = 0.09975M;
                    break;
            }

            return tax;
        }

        /// <summary>
        /// Get/Set l'annee sur lequel calculer la taxe
        /// </summary>
        public Years years { get; set; }

        /// <summary>
        /// Get/Set le sur lequel extraire la taxe
        /// </summary>
        public decimal Montant { get; set; }

        /// <summary>
        /// Retourne le une structure de taxe remplie.
        /// </summary>
        public Taxe Value => Extract();
    }
}
