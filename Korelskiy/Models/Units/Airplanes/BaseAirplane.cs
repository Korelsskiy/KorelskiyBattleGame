using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korelskiy.Models.Units.Airplanes
{
    public abstract class BaseAirplane : BaseUnit
    {
        public BaseAirplane(string title, string imageTitle, int price, Nations nation) : base(title, imageTitle, price, nation) { }
    }
}
