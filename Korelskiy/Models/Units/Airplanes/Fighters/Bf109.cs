using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Korelskiy.Models.Units.Airplanes.Fighters
{
    public class Bf109 : BaseFighterAirplane
    {
        public Bf109()
            :base("Bf.109E-1", "bf109.jpg", 60, Nations.Germany)
        {
            //Draw(buttonForDraw);
        }

        public override Button Draw(Button buttonForDraw)
        {
            buttonForDraw.Width = 160;
            buttonForDraw.Height = 120;
            buttonForDraw.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            Image photo = new Image() { Source = new BitmapImage(new Uri($"{ImagePath}", UriKind.Relative)), Height = 80 };
            Label title = new Label() { HorizontalAlignment = System.Windows.HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center, Content = $"{Title}", Height = 20, FontSize = 10 };
            Label price = new Label() { HorizontalAlignment = System.Windows.HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center, Content = $"Цена: {Price}", Height = 20, FontSize = 10 };
            StackPanel elements = new StackPanel();
            List<UIElement> uIElements = new List<UIElement> { title, photo, price };
            foreach (var item in uIElements)
            {
                elements.Children.Add(item);
            }
            buttonForDraw.Content = elements;
            return buttonForDraw;
        }
    }
}
