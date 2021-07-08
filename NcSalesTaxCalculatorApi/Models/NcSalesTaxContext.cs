using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;

namespace NcSalesTaxCalculatorApi.Models
{
	public class NcSalesTaxContext : DbContext, INcSalesTaxContext
	{
		// A simple database context. Implements an interface to allow mocking for unit tests.
		public NcSalesTaxContext(DbContextOptions<NcSalesTaxContext> options) : base(options)
		{
		}

		public DbSet<NcSalesTax> County { get; set; }
	}
}