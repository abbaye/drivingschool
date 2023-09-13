namespace Barette.Library.UserControls.Client
{

    /// <summary>
    /// Mode d'édition des paiments.
    /// </summary>
    public enum PaiementMode{
		Nouveau,
		Modifier
	}

    /// <summary>
    /// Defini quel type de document sera imprime
    /// </summary>
    public enum PrintDocumentType {
        InfoClient,
        InfoClientTheorique,
        Contract,
        PaimentList,
        Moto2015,
        AttestationMoto2015,
    }
}
