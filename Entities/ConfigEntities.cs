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
    }

    public class ListFields
    {
        public TypeField TypeFields { get; set; }
        public List<Field> Fields { get; set; }
    }

    public class RootContainer
    {
        public List<ListFields> ContainerFields { get; set; }
    }
}
