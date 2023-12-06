using CourierLib.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierLib.Tests
{
    public class CourierOrderUnitTest
    {
        [Fact]
        public void OrderHasAtleastOneParcel()
        {
            decimal dimension = 10;

            List<Parcel> parcel = new List<Parcel>();
            parcel.Add(Parcel.Create(ParcelType.Create(dimension), dimension));

            CourierOrder courierOrder = CourierOrder.Create(parcel, ShippingTypes.Normal);

            Assert.NotEmpty(courierOrder.Parcels);
        }

        [Fact]
        public void OrderAmountShouldEqualToIndividualParcelPriceSum()
        {
            decimal dimension = 10;

            List<Parcel> parcel = new List<Parcel>();
            parcel.Add(Parcel.Create(ParcelType.Create(dimension), dimension));

            CourierOrder courierOrder = CourierOrder.Create(parcel, ShippingTypes.Normal);

            Assert.Equal(8, courierOrder.CaculateOrderAmount().ParcelCost);

        }

        [Fact]
        public void OrderAmountSholdMatchWithSpeedyShipping()
        {
            decimal dimension = 10;

            List<Parcel> parcel = new List<Parcel>();
            parcel.Add(Parcel.Create(ParcelType.Create(dimension), dimension));

            CourierOrder courierOrder = CourierOrder.Create(parcel, ShippingTypes.SpeedyShipping);

            var orderAmount = courierOrder.CaculateOrderAmount();
            Assert.Equal(8, orderAmount.ParcelCost);
            Assert.Equal(8, orderAmount.ShippingFee);
            Assert.Equal(16, orderAmount.TotalFee);

        }
    }
}
