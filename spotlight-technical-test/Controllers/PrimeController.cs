using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using spotlight_technical_test.Caching;
using spotlight_technical_test.Services;

namespace spotlight_technical_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class PrimeController : ControllerBase
    {
        private readonly IPrimeService _primeService;
        private readonly ICache _cache;

        public PrimeController(IPrimeService primeService, ICache cache)
        {
            _primeService = primeService;
            _cache = cache;
        }

        [HttpGet]
        [Route("GetPrimes")]
        public async Task<IEnumerable<long>> GetPrimes([FromQuery]long numberOfPrimes)
        {
            if (!_cache.TryGetValue(numberOfPrimes, out object result))
            {
                result = await _primeService.GetPrimesAsync(numberOfPrimes);
                _cache.Add(numberOfPrimes, result);
            }
            else
            {
                Response.Headers.Add("ReturnedFromCache", "True");
            }

            return (IEnumerable<long>)result;
        }

    }
}