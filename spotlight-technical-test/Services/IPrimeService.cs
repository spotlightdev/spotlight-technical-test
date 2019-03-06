using System.Collections.Generic;
using System.Threading.Tasks;

namespace spotlight_technical_test.Services
{
    public interface IPrimeService
    {

        /// <summary>
        /// Returns the first <paramref name="n"/> number of primes
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        Task<IEnumerable<long>> GetPrimesAsync(long n);

    }
}