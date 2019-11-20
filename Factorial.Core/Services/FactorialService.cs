namespace Factorial.Core.Services
{
    public class FactorialService : IFactorialService
    {
        public double CalculateFactorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return n * CalculateFactorial(n - 1);
        }
    }
}
