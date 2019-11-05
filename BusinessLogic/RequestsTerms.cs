using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Entities;
using HtmlAgilityPack;

namespace BusinessLogic
{
    public class RequestsTerms : IRequestTerms
    {
        static readonly HttpClient client = new HttpClient();

        private static string Url_Path = "https://synonyms.reverso.net/synonym/{0}/{1}";
        private static List<Field> _fieldsContainer = new List<Field>();

        public static async Task<List<Field>> GetTermsAsync(string lang, Dictionary<string, TypeField> wordsSearch)
        {
            List<Field> listConfigs = new List<Field>();
            foreach (var typeValue in Enum.GetValues(typeof(TypeField)))
            {
                var filteredValues = wordsSearch.Where(x => x.Value == (TypeField)typeValue).Select(x => x.Key).ToList();
                var fields = await Field(lang, filteredValues, (TypeField)typeValue, listConfigs);
                _fieldsContainer = fields;
            }
            return _fieldsContainer;
        }

        private static async Task<List<Field>> Field(string lang, List<string> wordsSearch, TypeField typeField,
            List<Field> fields)
        {
            
            foreach (var word in wordsSearch)
            {
                fields.Add(new Field
                {
                    Name = word,
                    Multiplier = 500,
                    TypeFields = typeField
                });

                string baseUrl = string.Format(Url_Path, lang, word);
                using var client = new HttpClient();
                string data = await client.GetStringAsync(baseUrl);

                HtmlDocument doc = new HtmlDocument();

                doc.LoadHtml(data);
                var relevantSynonyms = doc.DocumentNode.SelectNodes("//a[@class='synonym  relevant']");
                if (relevantSynonyms != null)
                {
                    foreach (var item in relevantSynonyms)
                    {
                        var pivotField = new Field
                        {
                            Name = item.InnerText,
                            Multiplier = 500,
                            TypeFields = typeField
                        };
                        fields.Add(pivotField);
                    }
                }

                var synonyms = doc.DocumentNode.SelectNodes("//a[@class='synonym ']");
                if (synonyms != null)
                {
                    foreach (var item in synonyms)
                    {
                        var pivotField = new Field
                        {
                            Name = item.InnerText,
                            Multiplier = 300,
                            TypeFields = typeField
                        };
                        fields.Add(pivotField);
                    }
                }
            }
            return fields;
        }

        Task<List<Field>> IRequestTerms.GetTermsAsync(string lang, Dictionary<string, TypeField> wordsSearch)
        {
            return GetTermsAsync(lang, wordsSearch);
        }
    }
}
