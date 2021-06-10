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
    public class RiverCell : ICell
    {
        public int XCoordinate { get; set; }

        public int YCoordinate { get; set; }

        public RiverCell(int xCoordinate, int yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }

        public void Draw(Button buttonForDraw)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#149ee3");
            buttonForDraw.Background = new SolidColorBrush(color);
            buttonForDraw.Tag = $"{XCoordinate}|{YCoordinate}";
            buttonForDraw.Click += (q, e) => Reaction();
        }

        public void Reaction()
        {
            MessageBox.Show($"В этом квадрате река. Его координаты: ({XCoordinate};{YCoordinate})");
        }
    }
}
