using System.Net.Http.Headers;

namespace CourierLib.Core
{
    public class Parcel
    {
        public Guid Id { get; private set; }
        public Decimal Weight { get; set; }
        public Decimal Dimension { get; set; }
        public ParcelType ParcelType { get; set; }

        private decimal _price = 0;
        private Parcel(ParcelType parcelType,decimal dimension, decimal weight )
        {
            Id = Guid.NewGuid();
            ParcelType = parcelType;
            Dimension = dimension;
            Weight = weight;
            CalculatePrice();
        }

        public static Parcel Create(ParcelType parcelType, decimal dimension, decimal weight)
        {
            return new Parcel(parcelType,dimension,weight);
        }

        public decimal GetPrice()
        {
            return _price;
        }

        public decimal CalculatePrice()
        {
            _price = ParcelType.Price + (ParcelType.MaxWeight<= Weight ? (Weight - ParcelType.MaxWeight) * 2 :0 );
            return _price;
        }

        public override string ToString() { return $"Parcel Id {Id} - Cost {_price}"; }
    }

}