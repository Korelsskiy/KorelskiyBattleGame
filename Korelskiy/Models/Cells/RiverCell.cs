using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Korelskiy.Models.Cells
{
    public class RiverCell : BaseCell
    {
        public RiverCell(int xCoordinate, int yCoordinate)
            : base(xCoordinate, yCoordinate) { }

        public override void Draw(Button buttonForDraw)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#149ee3");
            buttonForDraw.Background = new SolidColorBrush(color);
            buttonForDraw.Tag = this;
            buttonForDraw.Click += (q, e) => Reaction(q);
        }

        public override void Reaction(object q)
        {
            SetUnit(q as Button);
            //MessageBox.Show($"В этом квадрате река. Его координаты: ({XCoordinate};{YCoordinate})");
        }
    }
}
