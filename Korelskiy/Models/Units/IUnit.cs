using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Korelskiy.Models.Units
{
    public interface IUnit
    {
        string Title { get; }
        string ImageName { get; }
        int Cost { get; }
        void Draw(Button buttonForDraw);
        Button Display();
    }
}
