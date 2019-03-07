using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spotlight_technical_test.Services.Impl
{
    public class PrimeService : IPrimeService
    {
        public async Task<IEnumerable<long>> GetPrimesAsync(long n)
        {
            return await Task.Run(() =>
            {
                if (n <= 0)
                    return Enumerable.Empty<long>();

                HashSet<long> primeNumbers = new HashSet<long>() { 2 };

                for (long i = 3; i <= long.MaxValue; i += 2)
                {
                    if (primeNumbers.Count == n)
                        break;

                    if (IsPrime(i))
                        primeNumbers.Add(i);
                }

                return primeNumbers;
            }
            );
        }

        public bool IsPrime(long num)
        {
            bool isPrime = true;

            long sqRoot = (long)Math.Sqrt(num);

            for (long j = 3; j <= sqRoot; j++)
            {
                if (num != j && num % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }
}
