using Korelskiy.Models.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Korelskiy.Models.Maps
{
    public abstract class BaseMap
    {
        public string Title { get; }
        public BaseUnit UnitForSpawn { get; set; }
        public Action<Button, BaseUnit> UnitSpawned { get; set; }
        public BaseMap(string title)
        {
            Title = title;
        }

        public abstract void Draw(Grid gridForDraw);
    }
}
