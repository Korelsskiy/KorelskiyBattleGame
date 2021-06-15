using Korelskiy.Models.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Korelskiy.Models.Maps
{
    public class DeltaMap : BaseMap
    {
        string[] forestCells = new string[]
        {
            "2,7", "2,8",
            "3,7", "3,8",
            "4,7", "4,8",
            "11,7", "11,8",
            "12,7", "12,8",
            "13,7", "13,8"
        };

        string[] riverCells = new string[]
        {
            "5,5", "5,6", "5,7", "5,8", "5,9", "5,10",
            "6,5", "6,6", "6,7", "6,8", "6,9", "6,10",
            "7,5", "7,6", "7,9", "7,10",
            "8,5", "8,6", "8,9", "8,10",
            "9,5", "9,6", "9,7", "9,8", "9,9", "9,10",
            "10,5", "10,6", "10,7", "10,8", "10,9", "10,10"
        };

        string[] mountainCells = new string[]
        {
            "5,14", "5,15",
            "6,13", "6,14", "6,15",
            "7,13", 
            "8,13",
            "9,11", "9,12", "9,13",
            "10,11", "10,12"
            
        };

        public DeltaMap() : base("Карта №4") { }

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
