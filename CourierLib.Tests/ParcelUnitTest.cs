using CourierLib.Core;

namespace CourierLib.Tests
{
    public class ParcelUnitTest
    {
        [Fact]
        public void ParcelCreateIsNotNull()
        {
            decimal dimension = 10;
            ParcelType parcelType = ParcelType.Create(dimension);
            Parcel parcel = Parcel.Create(parcelType , dimension);

            Assert.NotNull(parcel);
        }

        [Fact]
        public void ParcelCreateWithTypeAndDimension()
        {
            decimal dimension = 10;
            ParcelType parcelType = ParcelType.Create(dimension);
            Parcel parcel = Parcel.Create(parcelType, dimension);

            Assert.Equal(dimension, parcel.Dimension);
            Assert.NotNull(parcel.ParcelType);
        }


    }
}