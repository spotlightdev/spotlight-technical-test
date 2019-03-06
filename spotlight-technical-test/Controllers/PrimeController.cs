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

        public PrimeController(IPrimeService primeService)
        {
            _primeService = primeService;
        }

        [HttpGet]
        [Route("GetPrimes")]
        public async Task<IEnumerable<long>> GetPrimes([FromQuery]long numberOfPrimes)
        {
            return await _primeService.GetPrimesAsync(numberOfPrimes);
        }

    }
}