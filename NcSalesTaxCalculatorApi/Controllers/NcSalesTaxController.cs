using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NcSalesTaxCalculatorApi.Models;

namespace NcSalesTaxCalculatorApi.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/nc/salesTax")]
    [ApiController]
    public class NcSalesTaxController : ControllerBase
    {
        //private readonly INcSalesTaxContext _context;
        private readonly INcSalesTaxRepository _repo;

        public NcSalesTaxController(INcSalesTaxRepository repo)
        {
            _repo = repo;
        }

        /// <summary>
        /// Takes a county name and a transaction price as query string paramaters.
        /// </summary>
        /// <param name="request">A model containing a county name and transaction price.</param>
        /// <returns>A model containing the original transaction price, the tax amount, and total of both values.</returns>        
        [HttpGet()]
        public async Task<ActionResult<NcSalesTaxResponse>> GetNcSalesTax([FromQuery] NcSalesTaxRequest request)
        {           
            // Get the tax rate for the county in which the transaction originates
            var ncSalesTax = await _repo.GetCounty(request.County);

            if (ncSalesTax == null)
            {
                return NotFound();
            }

            // The response could be cut down to just return the tax amount,
            // but I thought it best to return all relevant data
            // (i.e., the original amount, the tax amount, and the new total)
            var response = new NcSalesTaxResponse(request.Price, ncSalesTax.TaxRate);
            return new OkObjectResult(response);
        }
    }
}
