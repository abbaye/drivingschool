
using Barette.Library.Employer;

namespace Barette.Library.Collections
{
    /// <summary>
    /// Collection d'employé.
    /// </summary>
    public class EmployeCollection : CollectionWithEvents {
		public Employe Add(Employe value) {
			base.List.Add(value as object);

			return value;
		}

		public void AddRange(Employe[] values) {
			foreach(Employe item in values)
				Add(item);
		}

		public void Remove(Employe value) {
			base.List.Remove(value as object);
		}

		public void Insert(int index, Employe value) {
			base.List.Insert(index, value as object);
		}

		public bool Contains(Employe value) {
			foreach(Employe s in base.List)
				if (value.Equals(s))
					return true;

			return false;
		}

		public bool Contains(EmployeCollection values) {
			foreach(Employe c in values) {
				if (Contains(c))
					return true;
			}

			return false;
		}

		public Employe this[int index] {
			get { return (base.List[index] as Employe); }
		}

		public int IndexOf(Employe value) {
			return base.List.IndexOf(value);
		}

        public Employe GetFromName(string Name)
        {
            foreach (Employe emp in this)
            {
                if (emp.Nom.Trim() == Name.Trim())
                    return emp;
            }

            return null;
        }

        public Employe GetFromNameOrDefault(string Name)
        {
            foreach (Employe emp in this)
            {
                if (emp.Nom.Trim() == Name.Trim())
                    return emp;
            }

            return new Employe();
        }

        ///// <summary>
        ///// Remplir avec un fichier xml (TODO: gestion d'erreur)
        ///// </summary>
        ///// <param name="filename"></param>
        ///// <returns></returns>
        //public bool LoadFromXML(string filename){
        //	if (File.Exists(filename)){
        //      Clear();

        //		//Creation du reader
        //		XmlDocument doc = new XmlDocument();
        //		XmlTextReader reader = new XmlTextReader(filename);

        //		//Lecture du document
        //		doc.Load(reader);

        //		//Lecture des includes : TextFile
        //		XmlNodeList CodeNodes = doc.ChildNodes.Item(0).ChildNodes;
        //		XmlNodeList AllCode = doc.ChildNodes.Item(0).ChildNodes.Item(0).ChildNodes;

        //		//Chargement de la liste de client
        //		XmlNode node = null;
        //		for (int i=0; i<AllCode.Count; i++){
        //			//client
        //			node = AllCode[i];

        //			//Employe emp = new Employe(node.Attributes["Nom"].Value, 
        //			//	node.Attributes["Phone"].Value);

        //			//Ajout du code
        //			//this.Add(emp); 
        //		}

        //		return true;
        //	}
        //	else
        //		return false;
        //}
    }
}
