using CS4125.Controllers;
using CS4125.Data.Finance;
using CS4125.Data.UserData;
using CS4125.Data.System;

namespace CS4125.Services;

public class AdminTasks
{
    public static void CreateInvoiceForAllUsers()
    {
        Data.System.System system = SystemController.System;
        var users = SystemController.System.GetUsers();
        foreach (var user in users)
            if (user is Farmer farmer)
                switch (farmer.Tier)
                {
                    case Tier.Bronze:
                    {
                        var bronzeTierInvoice = new BronzeTierInvoice(farmer);
                        var invoiceTotal = bronzeTierInvoice.CalculateTotalInvoicePrice();
                        var invoice = new Invoice(farmer, invoiceTotal, system.GetCompanyData().getName(), system.GetCompanyData().getAddress() );

                        farmer.AddInvoice(invoice);
                        break;
                    }
                    case Tier.Silver:
                    {
                        var silverTierInvoice = new SilverTierInvoice(farmer);
                        var invoiceTotal = silverTierInvoice.CalculateTotalInvoicePrice();
                        var invoice = new Invoice(farmer, invoiceTotal, system.GetCompanyData().getName(), system.GetCompanyData().getAddress() );

                        farmer.AddInvoice(invoice);
                        break;
                    }
                    case Tier.Gold:
                    {
                        var baseInvoice = new SilverTierInvoice(farmer);
                        var goldTierInvoice = new GoldTierInvoice(baseInvoice);
                        var invoiceTotal = goldTierInvoice.CalculateTotalInvoicePrice();
                        var invoice = new Invoice(farmer, invoiceTotal, system.GetCompanyData().getName(), system.GetCompanyData().getAddress() );

                        farmer.AddInvoice(invoice);
                        break;
                    }
                    default:
                        throw new ArgumentOutOfRangeException();
                }
    }
}