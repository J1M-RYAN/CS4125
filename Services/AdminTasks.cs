using CS4125.Controllers;
using CS4125.Data.Finance;
using CS4125.Data.Finance.State;
using CS4125.Data.UserData;

namespace CS4125.Services;

public class AdminTasks
{
    public static void CreateInvoiceForAllUsers()
    {
        var system = SystemController.System;
        var users = SystemController.System.GetUsers();
        foreach (var user in users)
            if (user is Farmer farmer)
                switch (farmer.Tier)
                {
                    case Tier.Bronze:
                    {
                        var bronzeTierInvoice = new BronzeTierInvoice(farmer);
                        //tier is bronze, so make a new BronzeTierSub state
                        farmer.State = new BronzeTierSub(farmer.State);
                        var invoiceTotal = farmer.State.CalculateTotalInvoicePrice(bronzeTierInvoice);
                        var invoice = new Invoice(farmer, invoiceTotal, system.GetCompanyData().getName(),
                            system.GetCompanyData().getAddress());

                        farmer.AddInvoice(invoice);
                        break;
                    }
                    case Tier.Silver:
                    {
                        var silverTierInvoice = new SilverTierInvoice(farmer);
                        farmer.State = new SilverTierSub(farmer.State);
                        var invoiceTotal = farmer.State.CalculateTotalInvoicePrice(silverTierInvoice);
                        var invoice = new Invoice(farmer, invoiceTotal, system.GetCompanyData().getName(),
                            system.GetCompanyData().getAddress());

                        farmer.AddInvoice(invoice);
                        break;
                    }
                    case Tier.Gold:
                    {
                        var baseInvoice = new SilverTierInvoice(farmer);
                        //tier is gold, so make a new GoldTierSub state
                        farmer.State = new SilverTierSub(farmer.State);
                        var invoiceTotal = farmer.State.CalculateTotalInvoicePrice(baseInvoice);
                        farmer.State = new GoldTierSub(farmer.State);
                        var invoiceGoldTotal = farmer.State.CalculateTotalInvoicePrice(baseInvoice);

                        var invoice = new Invoice(farmer, invoiceGoldTotal, system.GetCompanyData().getName(),
                            system.GetCompanyData().getAddress());

                        Invoice newInvoice = GoldTierSub.ImportInvoice(invoice,baseInvoice,invoiceTotal);

                        farmer.AddInvoice(newInvoice);
                        break;
                    }
                    default:
                        throw new ArgumentOutOfRangeException();
                }
    }
}