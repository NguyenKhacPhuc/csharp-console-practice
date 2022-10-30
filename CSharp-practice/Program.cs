// See https://aka.ms/new-console-template for more information

using DegreeEquationResolver;

using System;

namespace DegreeEquationResolver
{
    class Program
    {
        private const float NO_RESULT = -1f;
        static void Main(string[] args)
        {
            var equationElements = getUserInput();
            Console.WriteLine(equationElements);
            var result = caculatedEquation(equationElements);
            if (result == null)
            {
                Console.WriteLine("No result");
            }
            else
            {
                Console.WriteLine("The result is " + result.Result1 + " And " + result.Result2);
            }
        }

        static EquationElements getUserInput()
        {
            Console.WriteLine("Please enter a: ");
            double numberA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter b: ");
            double numberB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter c: ");
            double numberC = Convert.ToDouble(Console.ReadLine());

            return new EquationElements(numberA, numberB, numberC);
        }

        static EquationResult? caculatedEquation(EquationElements equationElements)
        {
            double numberA = equationElements.NumberA;
            double numberB = equationElements.NumberB;
            double numberC = equationElements.NumberC;

            if (numberA == 0 && numberB == 0)
            {
                return null;
            }
            else if (numberA == 0 && numberB != 0)
            {
                return new EquationResult(-numberC / numberB);
            }
            else
            {
                double delta = numberB * numberB - 4 * numberA * numberC;
                Console.WriteLine("Delta " + delta);

                if (delta > 0)
                {
                    return new EquationResult(((-numberB + Math.Sqrt(delta)) / (2 * numberA)), ((-numberB - Math.Sqrt(delta)) / (2 * numberA)));
                }
                else if (delta == 0)
                {
                    return new EquationResult((-numberB / (2 * numberA)));
                }
                else
                {
                    return null;
                }
            }
        }
    }
}





