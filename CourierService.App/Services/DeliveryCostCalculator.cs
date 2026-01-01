using CourierService.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.App.Services
{
    public class DeliveryCostCalculator
    {
        public double Calculate(double baseCost, Package package)
        {
            return baseCost
                 + (package.Weight * 10)
                 + (package.Distance * 5);
        }
    }
}
