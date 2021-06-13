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
        private string[] forestCells;
        private string[] riverCells;
        private string[] mountainCells;

        public string Title { get; }

        public abstract void Draw(Grid gridForDraw);
    }
}
