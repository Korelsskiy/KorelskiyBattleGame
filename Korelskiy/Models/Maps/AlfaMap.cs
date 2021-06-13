using Korelskiy.Models.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Korelskiy.Models.Maps
{
    public class AlfaMap : BaseMap
    {
        public string Title { get => "Карта №1"; }

        string[] forestCells = new string[]
        {
            "0,11", "0,12",
            "1,2", "1,5", "1,6", "1,9", "1,10", "1,11",
            "2,0", "2,1", "2,5", "2,6", "2,8",
            "3,3", "3,4", "3,6", "3,7", "3,15",
            "4,3", "4,6", "4,14", "4,15",
            "5,5", "5,14", "5,15",
            "6,1", "6,2", "6,14", "6,15",
            "7,1", "7,2", "7,3", "7,5",
            "8,1", "8,2", "8,3", "8,4", "8,6",
            "12,8", "12,9",
            "13,0", "13,4", "13,5", "13,8", "13,9",
            "14,0", "14,1", "14,2", "14,7", "14,9", "14,10",
            "15,0", "15,1", "15,2"

        };

        string[] riverCells = new string[]
        {
            "7,15",
            "8,14", "8,15",
            "9,6", "9,7", "9,8", "9,9", "9,10", "9,11", "9,12", "9,13", "9,14", "9,15",
            "10,0","10,5", "10,6", "10,7", "10,8", "10,9", "10,10", "10,11", "10,12", "10,13", "10,14", "10,15",
            "11,0", "11,1", "11,2", "11,3", "11,4","11,5", "11,6", "11,7", "11,8", "11,9", "11,10", "11,11", "11,12", "11,13", "11,14", "11,15",
            "12,0", "12,1", "12,14", "12,15",
            "13,15"
        };

        string[] mountainCells = new string[]
        {
            "3,11", "3,12",
            "4,9", "4,10", "4,11", "4,12",
            "5,8", "5,9", "5,10", "5,11", "5,12",
            "6,6", "6,7", "6,8", "6,9", "6,10", "6,11",
            "7,7", "7,8", "7,9", "7,10",

            "13,10", "13,11", "13,12",
            "14,11", "14,12", "14,13",
            "15,12", "15,13", "15,14"

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
