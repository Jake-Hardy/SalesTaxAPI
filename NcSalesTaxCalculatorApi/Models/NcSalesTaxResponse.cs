namespace NcSalesTaxCalculatorApi.Models 
{
	public class NcSalesTaxResponse 
	{
		// NcSalesTaxResponse is an object that maps to the response sent back to the API user.
		public NcSalesTaxResponse(decimal price, decimal taxRate)
        {
			OriginalPrice = price;
			TaxAmount = GetTaxAmount(price, taxRate);
			TotalAmount = GetTotalAmount(price, TaxAmount);
		}

		public decimal OriginalPrice { get; set; }
		public decimal TaxAmount { get; set; }
		public decimal TotalAmount { get; set; }

		public static decimal GetTaxAmount(decimal price, decimal taxRate)
        {
			return decimal.Round(price * (taxRate / 100), 2, System.MidpointRounding.AwayFromZero);
		}

		public static decimal GetTotalAmount(decimal price, decimal taxAmount)
        {
			return decimal.Round(price + taxAmount, 2, System.MidpointRounding.AwayFromZero);
		}
	}
}