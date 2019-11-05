using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BusinessLogic
{
    public class Profiler : IProfiler
    {
        public List<int> GenerateProfile(List<Field> configs, List<PersonProfile> persons)
        {
            var ProfilesByIndustry = from config in configs
                from person in persons
                where person.Industry.Contains(config.Name) && config.TypeFields == TypeField.Industry
                select new { Multiplier = config.Multiplier, IdProfile = person.IdProfile, CurrentRole = person.CurrentRole, Industry = person.Industry, Score = (config.Multiplier * (person.NumberOfConnections == 0 ? 1 : person.NumberOfConnections)) + (config.Multiplier * (person.NumberOfRecommendations == 0 ? 1 : person.NumberOfRecommendations)) };

            var ProfilesByRole = from config in configs
                from person in persons
                where person.CurrentRole.Contains(config.Name) && config.TypeFields == TypeField.Role
                select new { Multiplier = config.Multiplier, IdProfile = person.IdProfile, CurrentRole = person.CurrentRole, Industry = person.Industry, Score = (config.Multiplier * (person.NumberOfConnections == 0 ? 1 : person.NumberOfConnections)) + (config.Multiplier * (person.NumberOfRecommendations == 0 ? 1 : person.NumberOfRecommendations)) };

            var FinalProfiles = (from t in ProfilesByIndustry.Union(ProfilesByRole)
                group t by t.IdProfile
                into g
                select new { IdProfile = g.Key, TotalScore = g.Sum(c => c.Score) }).OrderByDescending(x => x.TotalScore).Take(100).Select(x => x.IdProfile).ToList();

            return FinalProfiles;
        }
    }
}
