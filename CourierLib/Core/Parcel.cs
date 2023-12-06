using System.Net.Http.Headers;

namespace CourierLib.Core
{
    public class Parcel
    {
        public Decimal Weight { get; set; }
        public Decimal Dimension { get; set; }
        public ParcelType ParcelType { get; set; }
        private Parcel(ParcelType parcelType,decimal dimension, decimal weight )
        {
            ParcelType = parcelType;
            Dimension = dimension;
            Weight = weight;
        }

        public static Parcel Create(ParcelType parcelType, decimal dimension, decimal weight)
        {
            return new Parcel(parcelType,dimension,weight);
        }

        public decimal GetPrice()
        {
            return ParcelType.Price + (ParcelType.MaxWeight<= Weight ? (Weight - ParcelType.MaxWeight) * 2 :0 );
        }
    }

}