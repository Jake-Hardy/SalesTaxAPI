using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NcSalesTaxCalculatorApi.Models
{
    public interface INcSalesTaxRepository
    {
        // An interface for the NcSalesTaxRepository class. Used primarily for mocking.
        public Task<NcSalesTax> GetCounty(string county);
    }
}
