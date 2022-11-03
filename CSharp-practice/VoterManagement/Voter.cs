namespace CSharp_practice.VoterManagement
{
    public class Voter
    {
        public readonly string? NationalId;
        public readonly string? Name;
        public readonly string? RelativeName;
        public readonly int? Age;
        public readonly string? Address;
        public readonly string? Province;
        public Voter(string nationalId,
                     string name,
                     string relativeName,
                     int age,
                     string address,
                     string province)
        {
            this.NationalId = nationalId;
            this.Name = name;
            this.RelativeName = relativeName;
            this.Age = age;
            this.Address = address;
            this.Province = province;
        }
      
    }
}
