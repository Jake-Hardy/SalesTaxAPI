using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NcSalesTaxCalculatorApi.Models
{
    public class NcSalesTaxRepository : INcSalesTaxRepository
    {
        // A repository that brokers communication between the controller and the database (the context).
        // The repository pattern may not have been absolutely necessary for this project, but I 
        // prefer this approach, as it makes the data layer more flexible and makes unit testing the 
        // controller *much* easier.
        private readonly NcSalesTaxContext _context;

        public NcSalesTaxRepository(NcSalesTaxContext context)
        {
            _context = context;
        }
        public async Task<NcSalesTax> GetCounty(string county)
        {
            return await _context.County.FirstOrDefaultAsync(r => r.County == county);
        }
    }
}
