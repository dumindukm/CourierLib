using CourierLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierLib.Core
{
    public class CourierOrder
    {
        private List<Parcel> _Parcels = new List<Parcel>();
        public IList<Parcel> Parcels { get { return _Parcels.AsReadOnly(); } }
        public CourierOrder(List<Parcel> parcels) 
        {
            _Parcels = parcels;
        }

        public static CourierOrder Create(List<Parcel> parcel)
        {
            var courierOrder = new CourierOrder(parcel);
            return courierOrder;
        }
        public OrderAmount CaculateOrderAmount()
        {
            OrderAmount orderAmount = new OrderAmount();
            var amount = Parcels.Sum(x => x.GetPrice());

            orderAmount.Total = amount;

            return orderAmount;
        }
    }
}
