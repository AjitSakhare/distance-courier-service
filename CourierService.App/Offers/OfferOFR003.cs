using CourierService.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.App.Offers
{
    public class OfferOFR003 : IOffer
    {
        public string Code
        {
            get
            {
                return "OFR003";
            }
        }

        public bool IsApplicable(Package package)
        {
            if (package.Distance >= 50 &&
                package.Distance <= 250 &&
                package.Weight >= 10 &&
                package.Weight <= 150)
            {
                return true;
            }

            return false;
        }

        public double GetDiscount(double deliveryCost)
        {
            double discount = deliveryCost * 0.05;
            return discount;
        }
    }
}
