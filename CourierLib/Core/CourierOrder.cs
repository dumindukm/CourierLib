using CourierLib.Factories;
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


        private CourierOrder(ShippingTypes shippingType)
        {
            _shippingType = shippingType;
        }

        public OrderAmount CaculateOrderAmount()
        {
            IShippingFeeCalculator shippingFeeCalculator = _shippingType == ShippingTypes.SpeedyShipping ?
                                                            new SpeedyShippingFeeCalculator() : new NormalShippingFeeCalculator();

            return shippingFeeCalculator.CaculateOrderAmount(this);
        }

        public static CourierOrder Create(ShippingTypes shippingType)
        {
            var courierOrder = new CourierOrder( shippingType);
            return courierOrder;
        }

        public void AddParcel(ParcelDto parcelDto)
        {
            _Parcels.Add(ParcelFactory.Create(parcelDto));
        }
    }
}
