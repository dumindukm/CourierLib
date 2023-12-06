using CourierLib.Core;
using CourierLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierLib.Services
{
    public class SpeedyShippingFeeCalculator : IShippingFeeCalculator
    {
        public OrderAmount CaculateOrderAmount(CourierOrder courierOrder)
        {
            OrderAmount orderAmount = new OrderAmount();
            var amount = courierOrder.Parcels.Sum(x => x.GetPrice());

            orderAmount.ParcelCost = amount;
            orderAmount.ShippingFee = orderAmount.ParcelCost;
            orderAmount.Parcels.AddRange(courierOrder.Parcels.Select(x => x.ToString()));
            return orderAmount;
        }
    }
}
