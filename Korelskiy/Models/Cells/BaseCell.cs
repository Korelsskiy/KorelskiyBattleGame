using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Korelskiy.Models.Cells
{
    public abstract class BaseCell
    {
        public int XCoordinate { get; }
        public int YCoordinate { get; }
        public BaseCell(int xCoordinate, int yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }
        public abstract void Draw(Button buttonForDraw);
        public abstract void Reaction();
    }
}
