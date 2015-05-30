using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barette.Library {



    /// <summary>
    /// Groupe d'étudiant
    /// Les élèves du groupe sont rechercher à chaque access.
    /// </summary> 
    public class StudentGroup {
        public enum GroupType {
            Automobile,
            Moto,
            Cyclomoteur,
            Autre
        }

        public StudentGroup() {
        }

        public StudentGroup(string name, int Number, GroupType type) {
            GroupeNumber = Number;
            Name = name;
            Type = type; 
        }

        public int GroupeNumber {
            get;
            set;
        }

        public string Name {
            get;
            set;
        }

        public GroupType Type {
            get;
            set;
        }            
    }
}
