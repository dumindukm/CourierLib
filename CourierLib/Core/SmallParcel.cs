using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierLib.Core
{
    public class SmallParcel : Parcel
    {
        public SmallParcel(decimal dimension, decimal weight, decimal price, decimal defaultWeight):base(dimension,weight, price, defaultWeight)
        {
        }
    }
}
