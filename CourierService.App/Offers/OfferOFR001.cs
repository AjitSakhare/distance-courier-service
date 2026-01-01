using CourierService.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.App.Offers
{
    public class OfferOFR001 : IOffer
    {
        public string Code
        {
            get
            {
                return "OFR001";
            }
        }

        public bool IsApplicable(Package package)
        {
            if (package.Weight >= 70 &&
                package.Weight <= 200 &&
                package.Distance < 200)
            {
                return true;
            }

            return false;
        }

        public double GetDiscount(double deliveryCost)
        {
            double discount = deliveryCost * 0.10;
            return discount;
        }
    }
}
