using CourierLib.Core;
using CourierLib.Factories;
using CourierLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierLib.Tests.UnitTestData
{
    public class ParcelTestData
    {
        public static ParcelDto smallParcelDto = new ParcelDto(Weight: 1, Price: 3, Dimension: 10, DefaultWeight : 1);
        public static ParcelDto mediumParcelDto = new ParcelDto(Weight: 3, Price: 8, Dimension: 50, DefaultWeight: 3);
        public static ParcelDto largeParcelDto = new ParcelDto(Weight: 6, Price: 15, Dimension: 100, DefaultWeight: 6);
        public static ParcelDto xlParcelDto = new ParcelDto(Weight: 10, Price: 25, Dimension: 200, DefaultWeight: 10);
    }
}
