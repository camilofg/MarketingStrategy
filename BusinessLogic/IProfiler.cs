using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BusinessLogic
{
    public interface IProfiler
    {
        List<int> GenerateProfile(List<Field> configsContainer, List<PersonProfile> persons);
    }
}
