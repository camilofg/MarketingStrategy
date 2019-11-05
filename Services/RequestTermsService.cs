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

        public Task<List<Field>> GetTermsAsync(string lang, Dictionary<string, TypeField> words_search,
            TypeField typeField)
        {
            return _iRequestTerms.GetTermsAsync(lang, words_search);
        }
    }
}
