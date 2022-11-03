namespace CSharp_practice.VoterManagement
{
    public class VoterManagement
    {
        public void AddVoter(Voter voter)
        {
            JsonManager.AddVoter(voter);
        }

        public List<Voter>? GetAllVoter()
        {
            return JsonManager.GetAllVoters();
        }

        public Voter? FindAVoterByName(String name)
        {
            var voters = GetAllVoter();
            Console.WriteLine("VoterManagement" + voters);
            if (voters != null && voters.Count > 0)
            {
                return voters.Find(voter => voter.Name == name);
            }
            else
            {
                return null;
            }

        }
    }
}
