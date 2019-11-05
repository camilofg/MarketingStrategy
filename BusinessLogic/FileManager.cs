using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Entities;

namespace BusinessLogic
{
    public class FileManager : IFileManager
    {
        public List<PersonProfile> LoadFile(string pathFile)
        {
            string strRegexp = @"[^\d]";

            Regex rx = new Regex(strRegexp);
            int counter = 0;
            try
            {
                var listProfiles = new List<PersonProfile>();
                using (StreamReader sr = new StreamReader(pathFile))
                {
                    string currentLine;
                    char separator = '|';
                    while ((currentLine = sr.ReadLine()) != null)
                    {
                        if (counter == 0)
                        {
                            separator = rx.Match(currentLine).Value.ToCharArray()[0];
                        }
                        var profile = new PersonProfile();
                        var splitLine = currentLine.Split(separator);
                        profile.IdProfile = Convert.ToInt32(splitLine[0]);
                        profile.FirstName = Convert.ToString(splitLine[1]);
                        profile.SecondName = Convert.ToString(splitLine[2]);
                        profile.CurrentRole = Convert.ToString(splitLine[3]);
                        profile.Country = Convert.ToString(splitLine[4]);
                        profile.Industry = Convert.ToString(splitLine[5]);
                        profile.NumberOfRecommendations = string.IsNullOrEmpty((string)splitLine[6]) ? 1 : Convert.ToInt32(splitLine[6]);
                        profile.NumberOfConnections = string.IsNullOrEmpty((string)splitLine[7]) ? 1 : Convert.ToInt32(splitLine[7]);
                        listProfiles.Add(profile);
                    }
                }
                return listProfiles;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GenerateProfilesFile(List<int> ListProfiles)
        {
            string path = @"C:\Users\Public\people.out";

            try
            {
                using System.IO.StreamWriter file =
                    new System.IO.StreamWriter(path);
                foreach (var line in ListProfiles)
                {
                    file.WriteLine(line.ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return path;
        }
    }
}
