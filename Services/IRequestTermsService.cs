using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Services
{
    public interface IRequestTermsService
    {
        Task<RootContainer> GetTermsAsync(string lang, Dictionary<TypeField, string> words_search, TypeField typeField);
    }
}
