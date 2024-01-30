using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierLib.Core
{
    public class LargeParcel : Parcel
    {
        public LargeParcel(decimal dimension, decimal weight, decimal price, decimal defaultWeight) : base(dimension, weight, price, defaultWeight)
        {
        }
    }
}
