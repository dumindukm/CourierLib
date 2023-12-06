using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierLib.Models
{
    public class OrderAmount
    {
        public decimal ParcelCost { get; internal set; }
        public decimal ShippingFee { get; internal set; }
        public decimal TotalFee => ParcelCost+ShippingFee;
        public List<string> Parcels = new();
    }
}
