namespace CourierLib.Core
{
    public class Parcel
    {
        public Decimal Dimension { get; set; }
        public ParcelType ParcelType { get; set; }
        public Parcel(ParcelType parcelType,decimal dimension )
        {
            ParcelType = parcelType;
            Dimension = dimension;
        }

        public static Parcel Create(ParcelType parcelType, decimal dimension)
        {
            return new Parcel(parcelType , dimension);
        }
        public decimal GetPrice()
        {
            return ParcelType.Price;
        }
    }
}