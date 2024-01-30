using System.Net.Http.Headers;

namespace CourierLib.Core
{
    public abstract class Parcel
    {
        public Guid Id { get; private set; }
        public Decimal Weight { get; set; }
        public Decimal Dimension { get; set; }

        protected decimal _price = 0;
        protected decimal _defaultWeight = 0;
        protected Parcel( decimal dimension, decimal weight, decimal price, decimal defaultWeight)
        {
            Id = Guid.NewGuid();
            Dimension = dimension;
            Weight = weight;
            _price = price;
            _defaultWeight = defaultWeight;
        }

        public decimal GetPrice()
        {
            CalculatePrice();
            return _price;
        }

        public virtual decimal CalculatePrice()
        {
            _price = _price + (_defaultWeight <= Weight ? (Weight - _defaultWeight) * 2 :0 );
            return _price;
        }

        public override string ToString() { return $"Parcel Id {Id} - Cost {_price}"; }
    }

}