using System.ComponentModel.DataAnnotations;

namespace NcSalesTaxCalculatorApi.Models 
{
	// NcSalesTaxRequest maps to the query string parameters that are expected to be passed
	// to the GET endpoint of the API, and do some simple validation. Sending an empty value
	// for County or a non-positive/non-numeric value for price will send a validation error
	// response back to the user containing details describing any issues with the request.
	public class NcSalesTaxRequest 
	{
		[Required]
		public string County { get; set; }
		[Required]
		[RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "A non-negative decimal value is required for price.")]
		public decimal Price { get; set; }
	}
}