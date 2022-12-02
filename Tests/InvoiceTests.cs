using CS4125.Controllers;
using CS4125.Data.Finance;
using CS4125.Data.UserData;
using CS4125.Services;
using Xunit;
using Xunit.Abstractions;

namespace CS4125.Tests
{
    public class InvoiceTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public InvoiceTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Create_BronzeInvoice()
        {
            // Testing the creation of a new user and giving that user an invoice using the decorator and state patterns
            Data.System.System system = SystemController.System;
            system.RegisterFarmer("Garry@gmail.com", "first", "Farmer", "Password1234!!!AAAA");
            
            var expected = typeof(Invoice);

            var farmers = system.GetFarmers();
            var firstFarmer = farmers[0];
            AdminTasks.CreateInvoiceForAllUsers();
            
            Assert.IsType(expected, firstFarmer.GetInvoiceToPay());
            _testOutputHelper.WriteLine(firstFarmer.GetInvoiceToPay().ToString());
            var invoice = firstFarmer.GetInvoiceToPay();
            _testOutputHelper.WriteLine(invoice.GetTotal().ToString());
            _testOutputHelper.WriteLine(firstFarmer.Tier.ToString());
        }

        [Fact]
        public void Create_SilverInvoice()
        {
            // Testing the creation of a new user and giving that user an invoice using the decorator and state patterns
            Data.System.System system = SystemController.System;
            system.RegisterFarmer("Greg@gmail.com", "second", "Farmer", "Password1235!!!AAAA");

            var expected = typeof(Invoice);

            var farmers = system.GetFarmers();
            var secondFarmer = farmers[1];
            secondFarmer.Tier = Tier.Silver;
            AdminTasks.CreateInvoiceForAllUsers();

            Assert.IsType(expected, secondFarmer.GetInvoiceToPay());
            _testOutputHelper.WriteLine(secondFarmer.GetInvoiceToPay().ToString());
            var invoice = secondFarmer.GetInvoiceToPay();
            _testOutputHelper.WriteLine(invoice.GetTotal().ToString());
            _testOutputHelper.WriteLine(secondFarmer.Tier.ToString());
        }
    }
}