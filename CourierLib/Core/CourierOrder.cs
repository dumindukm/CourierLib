using CourierLib.Models;
using CourierLib.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierLib.Core
{
    public enum ShippingTypes
    {
        Normal,
        SpeedyShipping
    }
    public class CourierOrder
    {
        private List<Parcel> _Parcels = new List<Parcel>();
        private ShippingTypes _shippingType;

        public IList<Parcel> Parcels { get { return _Parcels.AsReadOnly(); } }

        public CourierOrder(List<Parcel> parcels, ShippingTypes shippingType) 
        {
            _Parcels = parcels;
            _shippingType = shippingType;
        }

        public static CourierOrder Create(List<Parcel> parcel, ShippingTypes shippingType)
        {
            var courierOrder = new CourierOrder(parcel, shippingType);
            return courierOrder;
        }
        public OrderAmount CaculateOrderAmount()
        {
            IShippingFeeCalculator shippingFeeCalculator = _shippingType == ShippingTypes.SpeedyShipping ?
                                                            new SpeedyShippingFeeCalculator() : new NormalShippingFeeCalculator();

            return shippingFeeCalculator.CaculateOrderAmount(this);
        }
    }
}
