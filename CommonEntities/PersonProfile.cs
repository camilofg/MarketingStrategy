using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonEntities
{
    public class PersonProfile
    {
        public int IDProfile { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string CurrentRole { get; set; }
        public string Country { get; set; }
        public string Industry { get; set; }
        public int NumberOfRecommendations { get; set; }
        public int NumberOfConnections { get; set; }
        public int TotalScore { get; set; }
    }
}
