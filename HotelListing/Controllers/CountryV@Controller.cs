using HotelListing.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelListing.Controllers
{
    //[ApiVersion("2.0",Deprecated = true)]
    //[Route("api/{v:apiverison}/controller")]
    [Route("api/[controller]")]
    [ApiController]
    public class CountryV_Controller : ControllerBase
    {
        private DatabaseContext _context;

        public CountryV_Controller(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCountries()
        {
            return Ok(_context.Countries);
        }
    }
}
