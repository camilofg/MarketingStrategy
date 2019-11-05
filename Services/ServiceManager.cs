using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using Entities;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IRequestTerms _RequestTerms;
        private readonly IFileManager _FileManager;
        private readonly IProfiler _Profiler;
        public ServiceManager(IRequestTerms iRequestTerms, IFileManager iFileManager, IProfiler iProfiler)
        {
            _RequestTerms = iRequestTerms;
            _FileManager = iFileManager;
            _Profiler = iProfiler;
        }

        public Task<List<Field>> GetTermsAsync(string lang, Dictionary<string, TypeField> wordsSearch)
        {
            return _RequestTerms.GetTermsAsync(lang, wordsSearch);
        }

        public List<PersonProfile> LoadFile(string pathFile)
        {
            return _FileManager.LoadFile(pathFile);
        }

        public List<int> GenerateProfile(List<Field> configsContainer, List<PersonProfile> personsList)
        {
            return _Profiler.GenerateProfile(configsContainer, personsList);
        }

        public string GenerateProfilesFile(List<int> profilesIds)
        {
            return _FileManager.GenerateProfilesFile(profilesIds);
        }
    }
}
