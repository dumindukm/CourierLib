using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierLib.Models
{
    public record ParcelDto(decimal Weight, decimal Price, decimal Dimension, decimal DefaultWeight);

}
