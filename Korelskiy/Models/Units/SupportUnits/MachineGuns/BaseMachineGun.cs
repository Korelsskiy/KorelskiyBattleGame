using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korelskiy.Models.Units.SupportUnits.MachineGuns
{
    public abstract class BaseMachineGun : BaseSupportUnit
    {
        public BaseMachineGun(string title, string imageTitle, int price, Nations nation) : base(title, imageTitle, price, nation) { }
    }
}
