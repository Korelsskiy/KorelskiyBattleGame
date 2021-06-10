using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Korelskiy.Models.Maps
{
    public interface IMap
    {
         string Title { get; }
         void Draw(Grid gridForDraw);
    }
}
