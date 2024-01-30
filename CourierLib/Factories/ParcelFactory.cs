using CourierLib.Core;
using CourierLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierLib.Factories
{
    public class ParcelFactory
    {
        public static Parcel Create(ParcelDto parcelDto)
        {
            Parcel parcel;
            if (parcelDto.Dimension < 10)
            {
                parcel = new SmallParcel(parcelDto.Dimension, parcelDto.Weight, parcelDto.Price, parcelDto.DefaultWeight);
            }
            else if (parcelDto.Dimension < 50)
            {
                parcel = new MediumParcel(parcelDto.Dimension, parcelDto.Weight, parcelDto.Price, parcelDto.DefaultWeight);
            }
            else if (parcelDto.Dimension < 100)
            {
                parcel = new LargeParcel(parcelDto.Dimension, parcelDto.Weight, parcelDto.Price, parcelDto.DefaultWeight);
            }
            else
            {
                parcel = new XlParcel(parcelDto.Dimension, parcelDto.Weight, parcelDto.Price,parcelDto.DefaultWeight); // Assume there is a max size for a parcel
            }

            return parcel;

        }
    }
}
