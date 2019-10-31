using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using Entities;

namespace Services
{
    public class RequestTermsService : IRequestTermsService
    {
        private readonly IRequestTerms _iRequestTerms;
        public RequestTermsService(IRequestTerms iRequestTerms)
        {
            _iRequestTerms = iRequestTerms;
        }

        public Task<RootContainer> GetTermsAsync(string lang, Dictionary<TypeField, string> words_search,
            TypeField typeField)
        {
            return _iRequestTerms.GetTermsAsync(lang, words_search, typeField);
        }
    }
}
