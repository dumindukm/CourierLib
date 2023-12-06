using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierLib.Core
{
    public class ParcelType
    {

        public ParcelType(decimal maxDimension, decimal price, decimal maxWeight, decimal extraWeightCharge)
        {
            Dimension = maxDimension;
            Price = price;
            MaxWeight = maxWeight;
            ExtraWeightCharge = extraWeightCharge;
        }

        public decimal Dimension { get; }
        public decimal Price { get; }
        public decimal MaxWeight { get; }
        public decimal ExtraWeightCharge { get; }

        public static ParcelType Create(decimal dimension)
        {
            ParcelType parcelType;
            if (dimension < 10)
            {
                parcelType = new ParcelType(9, 3,1,2); 
            }
            else if (dimension < 50)
            {
                parcelType = new ParcelType(49, 8,3,2);
            }
            else if (dimension < 100)
            {
                parcelType = new ParcelType(99, 15,6, 2);
            }
            else 
            { 
                parcelType = new ParcelType(1000, 25,10, 2); // Assume there is a max size for a parcel
            }

            return parcelType;
        }
    }
}
