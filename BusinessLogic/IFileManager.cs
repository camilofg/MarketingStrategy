using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BusinessLogic
{
    public interface IFileManager
    {
        List<PersonProfile> LoadFile(string Path);

        string GenerateProfilesFile(List<int> listProfiles);
    }
}
