using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korelskiy.Models.Units.Infantry
{
    public abstract class BaseInfantry : BaseUnit
    {
        public BaseInfantry(string title, string imageTitle, int price, Nations nation) : base(title, imageTitle, price, nation) { }
    }
}
