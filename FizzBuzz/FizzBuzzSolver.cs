using System.Globalization;

namespace FizzBuzz
{
    public class FizzBuzzSolver : FizzBuzz.IFizzBuzzSolver
    {
        public string Solve(int numberToPrint)
        {
            if (numberToPrint % 3 == 0 && numberToPrint % 5 == 0)
            {
                return "FizzBuzz";
            }
            if (numberToPrint % 3 == 0)
            {
                return "Fizz";
            }
            if (numberToPrint % 5 == 0)
            {
                return "Buzz";
            }

            return numberToPrint.ToString(CultureInfo.InvariantCulture);
        }
    }
}
