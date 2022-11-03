using Newtonsoft.Json;
using System.IO;

namespace CSharp_practice.VoterManagement
{
    internal class JsonManager
    {
        public static List<Voter>? GetAllVoters()
        {
            using (StreamReader streamReader = new StreamReader("E:\\ASP Net Practice\\csharp-practice\\CSharp-practice\\CSharp-practice\\VoterManagement\\voter_storage.json"))
            {
                string json = streamReader.ReadToEnd();
                Console.WriteLine(json);
                List<Voter>? items = JsonConvert.DeserializeObject<List<Voter>>(json);
                streamReader.Close();
                return items;
            }
        }

        public static void AddVoter(Voter voter)
        {
            var currentVoters = GetAllVoters();
            if (currentVoters != null)
            {
                currentVoters.Add(voter);
                string json = JsonConvert.SerializeObject(currentVoters, Formatting.Indented);
                using (StreamWriter outputFile = new StreamWriter("E:\\ASP Net Practice\\csharp-practice\\CSharp-practice\\CSharp-practice\\VoterManagement\\voter_storage.json"))
                {
                    outputFile.WriteLine(json);
                    outputFile.Close();
                }
            }
            else
            {
                return;
            }


        }
    }
}
