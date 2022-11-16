namespace CS4125.Services;
using CS4125.Data.UserData;
using CS4125.Data.System;
using CS4125.Controllers;
using CS4125.Data.Finance;
public class AdminTasks
{

    public static void CreateInvoiceForAllUsers()
    {
        var users = SystemController.System.GetUsers();
        foreach (var user in users)
        {
            if (user is Farmer farmer)
            {
                if (farmer.tier == Tier.Bronze)
                {
                    var bronzeTierInvoice = new BronzeTierInvoice(farmer);
                    double invoiceTotal = bronzeTierInvoice.CalculateTotalInvoicePrice();
                    Invoice invoice = new Invoice(farmer, invoiceTotal);

                    farmer.AddInvoice(invoice);
                }
                else if (farmer.tier == Tier.Silver)
                {
                    var silverTierInvoice = new SilverTierInvoice(farmer);
                    double invoiceTotal = silverTierInvoice.CalculateTotalInvoicePrice();
                    Invoice invoice = new Invoice(farmer, invoiceTotal);

                    farmer.AddInvoice(invoice);
                }
                else if (farmer.tier == Tier.Gold)
                {
                    var baseInvoice = new SilverTierInvoice(farmer);
                    var goldTierInvoice = new GoldTierInvoice(baseInvoice);
                    double invoiceTotal = goldTierInvoice.CalculateTotalInvoicePrice();
                    Invoice invoice = new Invoice(farmer, invoiceTotal);

                    farmer.AddInvoice(invoice);
                }
            }
        }
    }
}