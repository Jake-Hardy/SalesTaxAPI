using NcSalesTaxCalculatorApi.Models;
using System;
using Xunit;

namespace NcSalesTaxTests
{
    public class NcSalesTaxResponseTests
    {
        [Fact]
        public void GetTaxAmount_WithNonZeroTaxRate_WithPositivePrice()
        {
            var taxAmount = NcSalesTaxResponse.GetTaxAmount(100, 10.00M);

            Assert.Equal(10, taxAmount);
        }

        [Fact]
        public void GetTotalAmount_WithNonZeroPrice_WithTaxAmount()
        {
            var totalAmount = NcSalesTaxResponse.GetTotalAmount(100, 10.00M);

            Assert.Equal(110, totalAmount);
        }
    }
}
