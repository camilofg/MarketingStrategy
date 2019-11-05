using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Services
{
    public interface IServiceManager
    {
        Task<List<Field>> GetTermsAsync(string lang, Dictionary<string, TypeField> words_search);

        List<PersonProfile> LoadFile(string pathFile);

        List<int> GenerateProfile(List<Field> configsContainer, List<PersonProfile> personsList);
        string GenerateProfilesFile(List<int> profilesIds);
    }
}
