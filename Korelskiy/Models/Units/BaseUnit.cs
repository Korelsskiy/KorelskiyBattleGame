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
        string Title { get; }
        string ImageName { get; }
        int Cost { get; }
        public abstract void Draw(Button buttonForDraw);
        public abstract Button Display();
    }
}
