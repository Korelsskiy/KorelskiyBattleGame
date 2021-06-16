using Korelskiy.Models.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Korelskiy.Models.Cells
{
    public abstract class BaseCell
    {
        public int XCoordinate { get; }
        public int YCoordinate { get; }
        public BaseUnit Unit { get; set; }

        public BaseCell(int xCoordinate, int yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }

        public void SetUnit(Button button)
        {
            //Unit = button.Tag as BaseUnit;
            //button.Content = new Image() { Source = new BitmapImage(new Uri($"{Unit.ImagePath}", UriKind.Relative)) };
        }

        public abstract void Draw(Button buttonForDraw);
        public abstract void Reaction(object q);
    }
}
