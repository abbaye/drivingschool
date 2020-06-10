namespace Barette.Library.TypeCours
{

    /// <summary>
    /// Cette classe represente un type de cours. Example : Automobile, Moto ...
    /// </summary>
    class TypeCours {

        /// <summary>
        /// Nombre de cours Pratique a effectuer
        /// </summary>
        public int QuantiterPratique{
            get;
            set;
        }
        
        /// <summary>
        /// Nombre de cours theorique a effectuer
        /// </summary>
        public int QuantiterTheorique {
            get;
            set;
        }

        /// <summary>
        /// Nom du type de cours
        /// </summary>
        public string Name {
            get;
            set;
        }
    }
}
