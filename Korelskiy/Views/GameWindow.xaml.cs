using Korelskiy.Models;
using Korelskiy.Models.Maps;
using Korelskiy.Models.Units;
using Korelskiy.Models.Units.Airplanes.Fighters;
using Korelskiy.Models.Units.Infantry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Korelskiy.Views
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        private BaseMap _map;
        private List<Player> _players;
        private int playerIndex = 0;

        public GameWindow(BaseMap map, string operation)
        {
            InitializeComponent();
            SetMap(map);
            SetPlayers(operation);
            ShowAvalibleUnits(_players[playerIndex]);
            mapTitleLable.Content = operation;
            
        }

        private void ShowAvalibleUnits(Player player)
        {
            unitsStack.Children.Clear();
            foreach (var item in player.GetAvalibleUnits())
            {
                Button newBtn = new Button();
                item.Draw(newBtn);
                unitsStack.Children.Add(newBtn);
            }
        }

        private void SetPlayers(string operation)
        {
            _players = new List<Player>();

            switch (operation)
            {
                case @"Операция ""Вайс""(1939)":
                        _players.Add(new Player("Третий Рейх", Nations.Germany));
                        _players.Add(new Player("Польская Республика", Nations.Poland)); 
                    break;
                default:
                    break;
            }

            playerDisplayLabel.Content = "Ходит: " + _players[0].Name;
        }

        private void SetMap(BaseMap map)
        {
            _map = map;
            DrawMap();
        }

        private void DrawMap()
        {
            _map.Draw(mapGrid);
        }

        private void backToGameSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            GameSettingsWindow window = new GameSettingsWindow();
            window.Show();
            this.Close();
        }

        private void NewTurn(Player player)
        {
            playerDisplayLabel.Content = "Ходит: " + player.Name;
            ShowAvalibleUnits(player);
        }

        private void endTurnButton_Click(object sender, RoutedEventArgs e)
        {

            if (++playerIndex < _players.Count)
            {
                NewTurn(_players[playerIndex]);
            }
            else
            {
                NewTurn(_players[0]);
                playerIndex = 0;
            }
        }
    }
}
