namespace CourierLib.Tests
{
    public class ParcelUnitTest
    {
        [Fact]
        public void ParcelCreateIsNotNull()
        {
            Parcel parcel = Parcel.Create();

            Assert.NotNull(parcel);
        }
        

    }
}