using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierLib.Core
{
    public class XlParcel : Parcel
    {
        public XlParcel(decimal dimension, decimal weight, decimal price, decimal defaultWeight) : base(dimension, weight, price,defaultWeight)
        {
        }
    }
}
