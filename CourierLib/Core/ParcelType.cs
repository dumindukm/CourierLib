using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierLib.Core
{
    public class ParcelType
    {

        private ParcelType(decimal maxDimension, decimal price)
        {
            Dimension = maxDimension;
            Price = price;
        }

        public decimal Dimension { get; }
        public decimal Price { get; }

        public static ParcelType Create(decimal dimension)
        {
            ParcelType parcelType;
            if (dimension < 10)
            {
                parcelType = new ParcelType(9, 3); 
            }
            else if (dimension < 50)
            {
                parcelType = new ParcelType(49, 8);
            }
            else if (dimension < 100)
            {
                parcelType = new ParcelType(99, 15);
            }
            else 
            { 
                parcelType = new ParcelType(1000, 25); // Assume there is a max size for a parcel
            }

            return parcelType;
        }
    }
}
