﻿using CourierLib.Core;
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
            parcel.Add(Parcel.Create(ParcelType.Create(dimension), dimension,3));

            CourierOrder courierOrder = CourierOrder.Create(parcel, ShippingTypes.Normal);

            Assert.NotEmpty(courierOrder.Parcels);
        }

        [Fact]
        public void OrderAmountShouldEqualToIndividualParcelPriceSum()
        {
            decimal dimension = 10;

            List<Parcel> parcel = new List<Parcel>();
            parcel.Add(Parcel.Create(ParcelType.Create(dimension), dimension,3));

            CourierOrder courierOrder = CourierOrder.Create(parcel, ShippingTypes.Normal);

            var orderAmount = courierOrder.CaculateOrderAmount();
            Assert.Equal(8, orderAmount.ParcelCost);
            Assert.Equal(0, orderAmount.ShippingFee);

        }

        [Fact]
        public void OrderAmountSholdMatchWithSpeedyShipping()
        {
            decimal dimension = 10;

            List<Parcel> parcel = new List<Parcel>();
            parcel.Add(Parcel.Create(ParcelType.Create(dimension), dimension, 3));

            CourierOrder courierOrder = CourierOrder.Create(parcel, ShippingTypes.SpeedyShipping);

            var orderAmount = courierOrder.CaculateOrderAmount();
            Assert.Equal(8, orderAmount.ParcelCost);
            Assert.Equal(8, orderAmount.ShippingFee);
            Assert.Equal(16, orderAmount.TotalFee);

        }

        [Fact]
        public void OrderAmountShouldEqualToIndividualParcelPriceSumWithExtraWeight()
        {
            decimal dimension = 10;

            List<Parcel> parcel = new List<Parcel>();
            parcel.Add(Parcel.Create(ParcelType.Create(dimension), dimension, 4));

            CourierOrder courierOrder = CourierOrder.Create(parcel, ShippingTypes.Normal);

            var orderAmount = courierOrder.CaculateOrderAmount();
            Assert.Equal(8 + 2, orderAmount.ParcelCost);
            Assert.Equal(0, orderAmount.ShippingFee);
            Assert.Equal(10, orderAmount.TotalFee);

        }

        [Fact]
        public void OrderAmountSholdMatchWithSpeedyShippingAndOverWeight()
        {
            decimal dimension = 10;

            List<Parcel> parcel = new List<Parcel>();
            parcel.Add(Parcel.Create(ParcelType.Create(dimension), dimension, 4));

            CourierOrder courierOrder = CourierOrder.Create(parcel, ShippingTypes.SpeedyShipping);

            var orderAmount = courierOrder.CaculateOrderAmount();
            Assert.Equal(8+2, orderAmount.ParcelCost);
            Assert.Equal(8+2, orderAmount.ShippingFee);
            Assert.Equal(20, orderAmount.TotalFee);

        }

        [Fact]
        public void OrderTotalParcelCountMustMatchAfterCalculateParcelPrice()
        {
            decimal dimension = 10;

            List<Parcel> parcel = new List<Parcel>();
            parcel.Add(Parcel.Create(ParcelType.Create(dimension), dimension, 3));

            CourierOrder courierOrder = CourierOrder.Create(parcel, ShippingTypes.Normal);
            var orderAmount = courierOrder.CaculateOrderAmount();

            Assert.Equal(1, orderAmount.Parcels.Count);
        }

    }
}
