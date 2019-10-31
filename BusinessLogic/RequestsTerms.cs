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
        private static RootContainer _fieldsContainer = new RootContainer { ContainerFields = new List<ListFields>() };

        public static async Task<RootContainer> GetTermsAsync(string lang, Dictionary<TypeField, string> wordsSearch, TypeField typeField)
        {
            foreach (var typeValue in Enum.GetValues(typeof(TypeField)))
            {
                var filteredValues = wordsSearch.Where(x => x.Key == (TypeField)typeValue).Select(x => x.Value).ToList();
                var fields = await ListFields(lang, filteredValues, (TypeField)typeValue);
                _fieldsContainer.ContainerFields.Add(fields);
            }
            return _fieldsContainer;
        }

        private static async Task<ListFields> ListFields(string lang, List<string> wordsSearch, TypeField typeField)
        {
            var fields = new ListFields
            {
                TypeFields = typeField,
                Fields = new List<Field>()
            };

            foreach (var word in wordsSearch)
            {
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
                            Multiplier = 5
                        };
                        fields.Fields.Add(pivotField);
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
                            Multiplier = 3
                        };
                        fields.Fields.Add(pivotField);
                    }
                }
            }
            return fields;
        }

        Task<RootContainer> IRequestTerms.GetTermsAsync(string lang, Dictionary<TypeField, string> wordsSearch, TypeField typeField)
        {
            return GetTermsAsync(lang, wordsSearch, typeField);
        }
    }
}
