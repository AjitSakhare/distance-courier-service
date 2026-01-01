using CourierService.App.Models;
using CourierService.App.Offers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CourierService.Tests.Offers
{
    public class OfferOFR002Tests
    {
        [Fact]
        public void Should_Give_Discount_When_Criteria_Matches()
        {
            Package package = new Package
            {
                Weight = 100,
                Distance = 100,
                OfferCode = "OFR002"
            };

            OfferOFR002 offer = new OfferOFR002();
            double cost = 1000;

            double discount = offer.GetDiscount(cost);

            Assert.Equal(70, discount);
        }

        [Fact]
        public void Should_Not_Apply_When_Criteria_Not_Matched()
        {
            Package package = new Package
            {
                Weight = 10,
                Distance = 300,
                OfferCode = "OFR002"
            };

            OfferOFR002 offer = new OfferOFR002();

            bool result = offer.IsApplicable(package);

            Assert.False(result);
        }
    }
}
