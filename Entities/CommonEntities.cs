using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public enum TypeField
    {
        Role,
        Industry
    }

    public class Field
    {
        public string Name { get; set; }
        public int Multiplier { get; set; }
        public TypeField TypeFields { get; set; }
    }

    public class PersonProfile
    {
        public int IdProfile { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string CurrentRole { get; set; }
        public string Country { get; set; }
        public string Industry { get; set; }
        public int NumberOfRecommendations { get; set; }
        public int NumberOfConnections { get; set; }
    }
}
