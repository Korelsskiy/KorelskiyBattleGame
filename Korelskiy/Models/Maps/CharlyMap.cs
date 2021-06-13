using Korelskiy.Models.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Korelskiy.Models.Maps
{
    public class CharlyMap : BaseMap
    {
        public string Title { get => "Карта №3"; }

        string[] forestCells = new string[]
        {
            "7,0", "7,1", "7,2", "7,3", "7,12", "7,13", "7,14", "7,15",
            "8,0", "8,1", "8,2", "8,3", "8,12", "8,13", "8,14", "8,15"
        };

        string[] riverCells = new string[]
        {
            "3,9",
            "4,8", "4,9",
            "5,8", "5,9",
            "6,7", "6,8", "6,9",
            "7,6", "7,7", "7,8", "7,9",
            "8,6", "8,7", "8,8", "8,9",
            "9,7", "9,8", "9,9",
            "10,7", "10,8", "10,9",
            "11,7", "11,8",
            "12,7"
        };

        string[] mountainCells = new string[]
        {
            "2,2", "2,3", "2,12", "2,13",
            "3,2", "3,3", "3,12", "3,13",
            "12,2", "12,3", "12,12", "12,13",
            "13,2", "13,3", "13,12", "13,13"
        };

        public override void Draw(Grid gridForDraw)
        {
            gridForDraw.Children.Clear();
            gridForDraw.RowDefinitions.Clear();
            gridForDraw.ColumnDefinitions.Clear();

            for (int i = 0; i < 16; i++)
            {
                gridForDraw.RowDefinitions.Add(new RowDefinition() { Height = new System.Windows.GridLength(50) });
                gridForDraw.ColumnDefinitions.Add(new ColumnDefinition() { Width = new System.Windows.GridLength(50) });
            }

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {

                    Button buttonForDraw = new Button() { Height = 45, Width = 45 };
                    BaseCell cellForAdd;
                    if (forestCells.Contains($"{i},{j}"))
                        cellForAdd = new ForestCell(j, i);
                    else if (riverCells.Contains($"{i},{j}"))
                        cellForAdd = new RiverCell(j, i);
                    else if (mountainCells.Contains($"{i},{j}"))
                        cellForAdd = new MountainCell(j, i);
                    else
                        cellForAdd = new TerrainCell(j, i);
                    cellForAdd.Draw(buttonForDraw);
                    gridForDraw.Children.Add(buttonForDraw);
                    Grid.SetRow(buttonForDraw, i);
                    Grid.SetColumn(buttonForDraw, j);
                }
            }
        }
    }
}
