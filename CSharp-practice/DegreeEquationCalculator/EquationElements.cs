namespace CSharp_practice.DegreeEquationCalculator
{
    internal class EquationElements
    {
        private double numberA = 0;
        private double numberB = 0;
        private double numberC = 0;
        public EquationElements(double numberA, double numberB, double numberC)
        {
            this.numberA = numberA;
            this.numberB = numberB;
            this.numberC = numberC;
        }

        public double NumberA
        {
            get { return numberA; }
            set { numberA = value; }
        }
        public double NumberB
        {
            get { return numberB; }
            set { numberB = value; }
        }
        public double NumberC
        {
            get { return numberC; }
            set { numberC = value; }
        }

    }

    internal class EquationResult
    {
        private readonly double result1;
        private readonly double result2;

        public EquationResult(double result1, double result2)
        {
            this.result1 = result1;
            this.result2 = result2;
        }

        public EquationResult(double result1)
        {
            this.result1 = result1;
        }

        public double Result1
        {
            get { return result1; }
        }
        public double Result2
        {
            get { return result2; }
        }
    }
}
