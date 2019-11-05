﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BusinessLogic
{
    public interface IRequestTerms
    {
        Task<List<Field>> GetTermsAsync(string lang, Dictionary<string, TypeField> words_search);
    }
}
