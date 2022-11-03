namespace CSharp_practice.VoterManagement
{
    class VoterManager
    {
        private VoterManagement voterManagement = new VoterManagement();
        public void Execute()
        {
            var chosenOptions = 0;
            do
            {
                Console.WriteLine("Voter Registration Form: ");
                Console.WriteLine("\t 1. Add New Voter ");
                Console.WriteLine("\t 2. List all voters ");
                Console.WriteLine("\t 3. Find a Voter by name ");
                Console.WriteLine("\t 4. Exit ");
                chosenOptions = Convert.ToInt32(Console.ReadLine());
                switch (chosenOptions)
                {
                    case 1:
                        executeAddVoter();
                        break;
                    case 2:
                        executeListAllVoters();
                        break;
                    case 3:
                        findVoterByName();
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
            }
            while (chosenOptions != 4);
        }

        private bool executeAddVoter()
        {
            try
            {
                Console.WriteLine("National ID: ");
                var nationalId = Console.ReadLine();
                Console.WriteLine("Name ");
                var name = Console.ReadLine();
                Console.WriteLine("Relative name: ");
                var relativeName = Console.ReadLine();
                Console.WriteLine("Province: ");
                var province = Console.ReadLine();
                Console.WriteLine("Address: ");
                var address = Console.ReadLine();
                Console.WriteLine("Age: ");
                var age = Convert.ToInt32(Console.ReadLine());
                voterManagement.AddVoter(new Voter(nationalId, name, relativeName, age, address, province));
                return true;
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("Error Input " + formatException.Message);
                return false;
            }

        }

        private void executeListAllVoters()
        {
            var listOfVoter = voterManagement.GetAllVoter();
            Console.Write("National ID ");
            Console.Write("\t Name ");
            Console.Write("\t Address ");
            Console.Write("\t Age ");
            Console.Write("\t Relative Name ");
            Console.Write("\t Province ");
            if (listOfVoter != null)
            {
                foreach (Voter voter in listOfVoter)
                {
                    Console.WriteLine("");
                    Console.Write("\t" + voter.NationalId);
                    Console.Write("\t" + voter.Name);
                    Console.Write("\t" + voter.Address);
                    Console.Write("\t\t" + voter.Age);
                    Console.Write("\t\t" + voter.RelativeName);
                    Console.Write("\t\t" + voter.Province);
                    Console.WriteLine("");
                }
            }
        }

        private void findVoterByName()
        {
            Console.WriteLine("Enter name: ");
            var name = Console.ReadLine();
            Voter? voter = voterManagement.FindAVoterByName(name);
            if (voter != null)
            {
                Console.WriteLine("\t" + voter.NationalId);
                Console.WriteLine("\t" + voter.Name);
                Console.WriteLine("\t" + voter.Address);
                Console.WriteLine("\t" + voter.Age);
                Console.WriteLine("\t" + voter.RelativeName);
                Console.WriteLine("\t" + voter.Province);
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
    }
}
