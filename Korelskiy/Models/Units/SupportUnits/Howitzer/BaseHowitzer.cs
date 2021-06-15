using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korelskiy.Models.Units.SupportUnits.Howitzer
{
    public abstract class BaseHowitzer : BaseSupportUnit
    {
        public BaseHowitzer(string title, string imageTitle, int price, Nations nation) : base(title, imageTitle, price, nation) { }
    }
}
