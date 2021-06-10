using System.Windows.Controls;

namespace Korelskiy.Models.Cells
{
    //HELLO KIRILL YOOOOOO
    public interface ICell
    {
        int XCoordinate { get; }
        int YCoordinate { get; }
        void Draw(Button buttonForDraw);
        void Reaction();
    }
}
