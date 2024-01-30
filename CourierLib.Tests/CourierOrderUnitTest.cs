using CourierLib.Core;
using CourierLib.Models;
using CourierLib.Tests.UnitTestData;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierLib.Tests
{
    public class CourierOrderUnitTest
    {
        [Fact]
        public void OrderContainsParcel()
        {
            CourierOrder courierOrder = CourierOrder.Create(ShippingTypes.Normal);
            courierOrder.AddParcel(ParcelTestData.smallParcelDto);

            Assert.NotEmpty(courierOrder.Parcels);
        }

        [Theory]
        [InlineData(3, 0, 3)]
        public void OrderAmountShouldEqualToIndividualParcelPriceSum(decimal ParcelCost, decimal ShippingFee, decimal TotalFee)
        {
            CourierOrder courierOrder = CourierOrder.Create(ShippingTypes.Normal);
            courierOrder.AddParcel(ParcelTestData.smallParcelDto);

            var orderAmount = courierOrder.CaculateOrderAmount();
            Assert.Equal(ParcelCost, orderAmount.ParcelCost);
            Assert.Equal(ShippingFee, orderAmount.ShippingFee);
            Assert.Equal(TotalFee, orderAmount.TotalFee);

        }

        [Theory]
        [InlineData(3, 3, 6)]
        public void OrderAmountSholdMatchWithSpeedyShipping(decimal ParcelCost, decimal ShippingFee, decimal TotalFee)
        {
            CourierOrder courierOrder = CourierOrder.Create(ShippingTypes.SpeedyShipping);
            courierOrder.AddParcel(ParcelTestData.smallParcelDto);

            var orderAmount = courierOrder.CaculateOrderAmount();
            Assert.Equal(ParcelCost, orderAmount.ParcelCost);
            Assert.Equal(ShippingFee, orderAmount.ShippingFee);
            Assert.Equal(TotalFee, orderAmount.TotalFee);

        }

        [Theory]
        [InlineData(3+2, 0, 5)]
        public void OrderAmountShouldEqualToIndividualParcelPriceSumWithExtraWeight(decimal ParcelCost, decimal ShippingFee, decimal TotalFee)
        {
            CourierOrder courierOrder = CourierOrder.Create(ShippingTypes.Normal);
            var smallParcelWithExtraWeight = ParcelTestData.smallParcelDto with { Weight = 2 };
            courierOrder.AddParcel(smallParcelWithExtraWeight);

            var orderAmount = courierOrder.CaculateOrderAmount();
            Assert.Equal(ParcelCost, orderAmount.ParcelCost);
            Assert.Equal(ShippingFee, orderAmount.ShippingFee);
            Assert.Equal(TotalFee, orderAmount.TotalFee);

        }
        
        /*
        [Fact]
        public void OrderAmountSholdMatchWithSpeedyShippingAndOverWeight()
        {
            decimal dimension = 10;
            decimal weight = 3;
            decimal price = 4;

            CourierOrder courierOrder = CourierOrder.Create(ShippingTypes.SpeedyShipping);
            courierOrder.AddParcel(ParcelTestData.smallParcelDto);

            var orderAmount = courierOrder.CaculateOrderAmount();
            Assert.Equal(8+2, orderAmount.ParcelCost);
            Assert.Equal(8+2, orderAmount.ShippingFee);
            Assert.Equal(20, orderAmount.TotalFee);

        }*/

        [Fact]
        public void OrderTotalParcelCountMustMatchAfterCalculateParcelPrice()
        {
            CourierOrder courierOrder = CourierOrder.Create(ShippingTypes.Normal);
            courierOrder.AddParcel(ParcelTestData.smallParcelDto);
            var orderAmount = courierOrder.CaculateOrderAmount();

            Assert.Equal(1, orderAmount.Parcels.Count);
        }

        [Fact]
        public void CreateCouierOrderWithShipingType()
        {
            CourierOrder courierOrder = CourierOrder.Create(ShippingTypes.Normal);
            
            Assert.NotNull(courierOrder);
        }

    }
}
