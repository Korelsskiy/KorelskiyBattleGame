using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Korelskiy.Models.Maps
{
    public class BetaMap : IMap
    {
        public string Title { get => "Карта №2"; }

        public void Draw(Grid gridForDraw)
        {
            throw new NotImplementedException();
        }
    }
}
