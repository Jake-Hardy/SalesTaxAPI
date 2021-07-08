using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NcSalesTaxCalculatorApi.Models
{
    // A simple interface for the db context
    public interface INcSalesTaxContext
    {
        public DbSet<NcSalesTax> County { get; set; }
    }    
}
