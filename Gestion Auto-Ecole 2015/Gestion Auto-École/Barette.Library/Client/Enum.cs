using System;

namespace Barette.Library.Client {
	/// <summary>
	/// Type de vethicule
	/// </summary>
	public enum VehiculeType{
		Manuel,
		Cyclomoteur,
		Automatique,
		Moto,
        Automobile,
		Nothing //Sert juste pour une asignation null
	}

	/// <summary>
	/// Type de profile du client
	/// </summary>
	public enum ProfileType{
		Actif,
		//Absence,
		//Theorie,
		//SoldSouffrance,
		CoursTerminer,
		Nothing
	}

	/// <summary>
	/// Type de paiment
	/// </summary>
	public enum TypePaiment {
		Nothing,
		ArgentComptant,
		Cheque,
        VISA,
        MasterCard,
		PaimentDirect,
		Autre	
	}

	/// <summary>
	/// Type de paiement
	/// </summary>
	public enum PaiementType {
		Nothing,
		RetourLivre,
		LocationAuto,
		Absence
	}

    public enum ProgramMoto
    {
        ProgramNormal,
        Program2015,
        Nothing
    }
}
