using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonEntities
{
    public class FieldConfig
    {
        public string FieldName { get; set; }
        public List<ConfigValue> MultipliersConfig { get; set; }
        
    }

    public class ConfigValue
    {
        public string KeyWord { get; set; }
        public int Multiplier { get; set; }
    }
}
