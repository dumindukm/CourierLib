using CourierLib.Core;
using CourierLib.Factories;
using CourierLib.Tests.UnitTestData;

namespace CourierLib.Tests
{
    public class ParcelUnitTest
    {
        [Fact]
        public void ParcelCreateIsNotNull()
        {
            decimal dimension = 10;
            ParcelType parcelType = ParcelType.Create(dimension);
            Parcel parcel = ParcelFactory.Create(ParcelTestData.smallParcelDto);

            Assert.NotNull(parcel);
        }

        [Fact]
        public void ParcelCreateWithTypeAndDimension()
        {
            Parcel parcel = ParcelFactory.Create(ParcelTestData.smallParcelDto);

            Assert.Equal(ParcelTestData.smallParcelDto.Dimension, parcel.Dimension);
        }


    }
}