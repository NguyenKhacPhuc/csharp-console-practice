// See https://aka.ms/new-console-template for more information

using CSharp_practice.VoterManagement;

namespace CSharp_practice.DegreeEquationCalculator
{
    class Program
    {
        private const float NO_RESULT = -1f;
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the choice for program: ");
            Console.WriteLine("1, Degree Equation Resolver ");
            Console.WriteLine("2, Voter Program");
            try
            {
                int chosenOption = Convert.ToInt32(Console.ReadLine());
                switch (chosenOption)
                {
                    case 1:
                        CalculatorManagement calculatorManagement = new CalculatorManagement();
                        calculatorManagement.Execute();
                        break;
                    case 2:
                        VoterManager voterManager = new VoterManager();
                        voterManager.Execute();
                        break;
                    default:
                        break;
                }
            }
            catch (FormatException format)
            {
                Console.WriteLine("Input must be number " + format.Message);
            }

        }
    }
}





