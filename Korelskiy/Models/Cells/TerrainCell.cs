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
    public class TerrainCell : ICell
    {

        public int XCoordinate { get; set; }

        public int YCoordinate { get; set; }

        public TerrainCell(int xCoordinate, int yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }

        public void Draw(Button buttonForDraw)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#10d34f");
            buttonForDraw.Background = new SolidColorBrush(color);
            buttonForDraw.Tag = $"{XCoordinate}|{YCoordinate}";
            buttonForDraw.Click += (q, e) => Reaction();
        }

        public void Reaction()
        {
            MessageBox.Show($"В этом квадрате луг. Его координаты: ({XCoordinate};{YCoordinate})");
        }
    }
}
