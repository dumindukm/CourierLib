using CourierLib.Core;
using CourierLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierLib.Services
{
    public interface IShippingFeeCalculator
    {
        OrderAmount CaculateOrderAmount(CourierOrder courierOrder);
    }
}
