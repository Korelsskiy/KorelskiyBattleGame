using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korelskiy.Models.Units.SupportUnits.Artillery
{
    public abstract class BaseArtillery : BaseSupportUnit
    {
        public BaseArtillery(string title, string imageTitle, int price, Nations nation) : base(title, imageTitle, price, nation) { }
    }
}
