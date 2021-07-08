using NcSalesTaxCalculatorApi.Controllers;
using NcSalesTaxCalculatorApi.Models;
using System;
using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace NcSalesTaxTests
{
    public class NcSalesTaxControllerTests
    {
        private readonly Mock<INcSalesTaxRepository> _mockRepo;
        private readonly NcSalesTaxController _controller;

        public NcSalesTaxControllerTests() {
            _mockRepo = new Mock<INcSalesTaxRepository>();
            _mockRepo.Setup(r => r.GetCounty(It.IsAny<string>())).ReturnsAsync(new NcSalesTax() { Id = 1, County = "Test", TaxRate = 10.00M });            
            _controller = new NcSalesTaxController(_mockRepo.Object);
        }

        [Fact]
        public async Task Get_WhenCalled_ReturnsOkResult()
        {
            var request = new NcSalesTaxRequest()
            {
                County = "Test",
                Price = 100.00M
            };

            var okResult = await _controller.GetNcSalesTax(request);

            Assert.IsType<OkObjectResult>(okResult.Result);            
        }        
    }
}
