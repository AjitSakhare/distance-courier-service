using CourierService.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.App.Offers
{
    public interface IOffer
    {
        string Code { get; }
        bool IsApplicable(Package package);
        double GetDiscount(double deliveryCost);
    }
}
