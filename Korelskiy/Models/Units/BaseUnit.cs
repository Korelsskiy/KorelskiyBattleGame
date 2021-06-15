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
        public string ImageTitle { get; }
        public int Price { get; }

        public Nations Nation { get; set; }

        public BaseUnit(string title, string imageTitle, int price, Nations nation)
        {
            Title = title;
            ImageTitle = imageTitle;
            Price = price;
            Nation = nation;
        }

        public abstract Button Draw(Button buttonForDraw);
    }
}
