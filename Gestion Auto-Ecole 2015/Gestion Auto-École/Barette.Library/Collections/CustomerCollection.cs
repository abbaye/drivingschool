using System.Collections;

using Barette.Library.Client;

namespace Barette.Library.Collections
{
    /// <summary>
    /// Collection de Client.
    /// Des fonctions seront ajouté plus tard en rapport avec la collectionB
    /// </summary>
    public class CustomerCollection : CollectionWithEvents, IEnumerable {

		public Customer Add(Customer value) {
			base.List.Add(value as object);

			return value;
		}

		public void AddRange(Customer[] values) {
			foreach(Customer item in values)
				Add(item);
		}

        public void Remove(Customer value) => base.List.Remove(value as object);

        public void Insert(int index, Customer value) => base.List.Insert(index, value as object);

        public bool Contains(Customer value) {
			foreach(Customer s in base.List)
				if (value.Equals(s))
					return true;

			return false;
		}

		public bool Contains(CustomerCollection values) {
			foreach(Customer c in values) {
				if (Contains(c))
					return true;
			}

			return false;
		}

		public Customer this[int index] {
			get { return base.List[index] as Customer; }
		}

        public int IndexOf(Customer value) => base.List.IndexOf(value);

        #region Methodes
        /// <summary>
        /// Obtien le client demandé par le parametre ContratNumber
        /// </summary>
        /// <param name="ContratNumber">Numéro de contrat</param>
        /// <returns>Retourne le client demandé. Si la valeur est null, c'est qu'il n'a pas trouvé de client correspondante</returns>
        public Customer GetClient(string ContratNumber) {
            foreach (Customer client in this) {
                if (client.ContratNumber == ContratNumber)
                    return client;
            }

			//Rien trouvé alors on retourne un null;
			return null;
		}

        /// <summary>
        /// Obtien tous les client demandé par le parametre NumeroGroupe
        /// </summary>
        /// <param name="GroupNumber">Numéro de Groupe</param>        
        public CustomerCollection GetClient(int GroupNumber) {
            CustomerCollection clientlist = new CustomerCollection();

            foreach (Customer client in this) {
                if (client.NumeroGroupe == GroupNumber)
                    clientlist.Add(client);
            }

            //Rien trouvé alors on retourne un null;
            return clientlist;
        }

        /// <summary>
        /// Retour tous les seances pratique de tous les clients
        /// </summary>
        /// <returns></returns>
        public SeanceCollection GetAllSeancesPratique() {
            SeanceCollection seances = new SeanceCollection();

            foreach (Customer client in this)
                foreach (Seance seance in client.Seances)
                    seances.Add(seance);

            return seances;
        }

        /// <summary>
        /// Retour tous les seances theorique de tous les clients
        /// </summary>
        /// <returns></returns>
        public SeanceCollection GetAllSeancesTheorique() {
            SeanceCollection seances = new SeanceCollection();

            foreach (Customer client in this)
                foreach (Seance seance in client.SeancesTheorique)
                    seances.Add(seance);
            
            return seances;
        }
		#endregion
	}
}
