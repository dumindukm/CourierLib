using CourierLib.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierLib.Tests
{
    public class CourierOrderUnitTest
    {
        [Fact]
        public void OrderHasAtleastOneParcel()
        {
            decimal dimension = 10;

            List<Parcel> parcel = new List<Parcel>();
            parcel.Add(Parcel.Create(ParcelType.Create(dimension), dimension));

            CourierOrder courierOrder = CourierOrder.Create(parcel);

            Assert.NotEmpty(courierOrder.Parcels);
        }
    }
}
