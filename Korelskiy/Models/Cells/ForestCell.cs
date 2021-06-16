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
    public class ForestCell : BaseCell
    {
        public ForestCell(int xCoordinate, int yCoordinate)
            : base(xCoordinate, yCoordinate) { }


        public override void Draw(Button buttonForDraw)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#076d0b");
            buttonForDraw.Background = new SolidColorBrush(color);
            buttonForDraw.Tag = this;
            buttonForDraw.Click += (q, e) => Reaction(q);
        }

        public override void Reaction(object q)
        {
            SetUnit(q as Button);
            //MessageBox.Show($"В этом квадрате лес. Его координаты: ({XCoordinate};{YCoordinate})");
        }
    }
}
