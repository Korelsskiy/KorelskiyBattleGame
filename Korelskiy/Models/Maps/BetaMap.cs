using Korelskiy.Models.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Korelskiy.Models.Maps
{
    public class BetaMap : BaseMap
    {
        string[] forestCells = new string[]
        {
            "0,0", "0,1", "0,2", "0,3",
            "1,0", "1,1", "1,2", "1,3",
            "2,0", 
            "3,0", "3,2", "3,3", "3,10", "3,11",
            "4,0", "4,2", "4,10", "4,11",
            "5,0", "5,10", "5,11", "5,15",
            "6,0", "6,15",
            "7,0", "7,15",
            "8,0", "8,15",
            "9,0", "9,10", "9,11", "9,15",
            "10,0", "10,10", "10,11", "10,15",
            "11,0", "11,2", "11,10", "11,11",
            "12,0", "12,3", "12,2",
            "13,0",
            "14,0", "14,1", "14,2", "14,3",
            "15,0", "15,1", "15,2", "15,3", "15,4", "15,5", "15,6"
        };

        string[] riverCells = new string[]
        {
            "0,7",
            "1,7", "1,6", "1,5", "1,4",
            "2,1", "2,2", "2,3", "2,4", 
            "3,1",
            "4,1",
            "5,1",
            "6,1",
            "7,1",
            "8,1",
            "9,1",
            "10,1",
            "11,1",
            "12,1",
            "13,1", "13,2", "13,3", "13,4",
            "14,7", "14,6", "14,5", "14,4",
            "15,7",
        };

        string[] mountainCells = new string[]
        {
            "2,12", "2,13",
            "3,12", "3,13",
            "4,12", "4,13",
            "5,12", "5,13",
            "6,12", "6,13", "6,14",
            "7,12", "7,13",
            "8,12", "8,13",
            "9,12", "9,13",
            "10,12", "10,13",
            "11,12", "11,13",
            "12,12", "12,13",
            "13,12", "13,13",
        };

        public BetaMap() : base("Карта №2") { }

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
