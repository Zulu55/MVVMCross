namespace Factorial.Core.Services
{
    public class FactorialService : IFactorialService
    {
        public double GetFactorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return n * GetFactorial(n - 1);
        }
    }
}
