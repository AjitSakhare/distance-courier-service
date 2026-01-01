using CourierService.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.App.Offers
{
    public class OfferOFR002 : IOffer
    {
        public string Code
        {
            get
            {
                return "OFR002";
            }
        }

        public bool IsApplicable(Package package)
        {
            if (package.Distance >= 50 &&
                 package.Distance <= 150 &&
                 package.Weight >= 100 &&
                 package.Weight <= 250)
            {
                return true;
            }

            return false;
        }

        public double GetDiscount(double deliveryCost)
        {
            double discount = deliveryCost * 0.07;
            return discount;
        }
    }
}
