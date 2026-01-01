using CourierService.App.Models;
using CourierService.App.Offers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.App.Services
{
    public class OfferService
    {
        public double CalculateDiscount(Package package, double cost)
        {
            IOffer offer = null;

            if (package.OfferCode == "OFR001")
            {
                offer = new OfferOFR001();
            }
            else if (package.OfferCode == "OFR002")
            {
                offer = new OfferOFR002();
            }
            else if (package.OfferCode == "OFR003")
            {
                offer = new OfferOFR003();
            }

            if (offer == null)
            {
                return 0;
            }

            if (!offer.IsApplicable(package))
            {
                return 0;
            }

            return offer.GetDiscount(cost);
        }

    }
}
