namespace FRACTION
{
    public class Fraction
    {
        private int denominator;

        //===================== CONSTRUCTORS ===================//
        public Fraction()
        {

        }

        public Fraction(int _numerator)
        {

        }

        public Fraction(int _numerator, int _denominator)
        {

        }

        public Fraction(Fraction _fraction)
        {

        }

        //================== GETTERS & SETTERS =================//
        public int Numerator { get; }
        
        public int Denominator
        {
            get => denominator;

            set
            {
                if (value == 0)
                    return;
                denominator = value;
            }
        }

        //======================= METHODS ======================//
        public override string ToString()
        {
            return "";
        }

        public bool Oppose()
        {
            return true;
        }

        public bool Inverse()
        {
            return true;
        }

        public bool IsHigherThan(Fraction _fraction)
        {
            return true;
        }

        public bool IsEqualTo(Fraction _fraction)
        {
            return true;
        }

        private bool Reduce()
        {
            return true;
        }

        private int GetHcf()
        {
            return 0;
        }

        public Fraction Add(Fraction _fraction)
        {
            return new Fraction();
        }

        public Fraction Substract(Fraction _fraction)
        {
            return new Fraction();
        }

        public Fraction Multiply(Fraction _fraction)
        {
            return new Fraction();
        }

        public Fraction Divide(Fraction _fraction)
        {
            return new Fraction();
        }
    }
}