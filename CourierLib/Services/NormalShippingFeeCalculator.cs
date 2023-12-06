using CourierLib.Core;
using CourierLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierLib.Services
{

    public class NormalShippingFeeCalculator : IShippingFeeCalculator
    {
        public OrderAmount CaculateOrderAmount(CourierOrder courierOrder)
        {
            OrderAmount orderAmount = new OrderAmount();
            var amount = courierOrder.Parcels.Sum(x => x.GetPrice());

            orderAmount.ParcelCost = amount;

            return orderAmount;
        }
    }
}
