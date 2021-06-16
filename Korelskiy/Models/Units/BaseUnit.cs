using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Korelskiy.Models.Units
{
    public abstract class BaseUnit
    {
        public string Title { get; }
        public string ImagePath { get; }
        public int Price { get; }

        public Nations Nation { get; set; }

        public BaseUnit(string title, string imagePath, int price, Nations nation)
        {
            Title = title;
            ImagePath = imagePath;
            Price = price;
            Nation = nation;
        }

        public abstract Button Draw(Button buttonForDraw);
    }
}
