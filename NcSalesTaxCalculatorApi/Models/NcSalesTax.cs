using System;

namespace NcSalesTaxCalculatorApi.Models
{
	// NcSalesTax is the base object that maps to items in the 
	// County table of the database. 
	public class NcSalesTax
	{
		public long Id { get; set; }
		public string County { get; set; }
		public decimal TaxRate { get; set; }
	}
}