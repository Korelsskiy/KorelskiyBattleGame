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
    public class TerrainCell : BaseCell
    {

        public TerrainCell(int xCoordinate, int yCoordinate)
            : base(xCoordinate, yCoordinate) { }

        public override void Draw(Button buttonForDraw)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#10d34f");
            buttonForDraw.Background = new SolidColorBrush(color);
            buttonForDraw.Tag = $"{XCoordinate}|{YCoordinate}";
            buttonForDraw.Click += (q, e) => Reaction();
        }

        public override void Reaction()
        {
            MessageBox.Show($"В этом квадрате луг. Его координаты: ({XCoordinate};{YCoordinate})");
        }
    }
}
