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
    public class OfferOFR003Tests
    {
        [Fact]
        public void Should_Give_Discount_When_Criteria_Matches()
        {
            Package package = new Package
            {
                Weight = 100,
                Distance = 100,
                OfferCode = "OFR003"
            };

            OfferOFR003 offer = new OfferOFR003();
            double cost = 1000;

            double discount = offer.GetDiscount(cost);

            Assert.Equal(50, discount);
        }

        [Fact]
        public void Should_Not_Apply_When_Criteria_Not_Matched()
        {
            Package package = new Package
            {
                Weight = 10,
                Distance = 300,
                OfferCode = "OFR003"
            };

            OfferOFR003 offer = new OfferOFR003();

            bool result = offer.IsApplicable(package);

            Assert.False(result);
        }
    }
}
