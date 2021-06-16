using Korelskiy.Models;
using Korelskiy.Models.Cells;
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
        private Action<Button, BaseUnit> unitSpawned;

        public GameWindow(BaseMap map, string operation)
        {
            InitializeComponent();
            unitSpawned += OnUnitSpawned;
            SetMap(map);
            SetPlayers(operation);
            NewTurn(_players[playerIndex]);
            mapTitleLable.Content = operation;
            
        }

        private void ShowAvalibleUnits(Player player)
        {
            unitsStack.Children.Clear();
            foreach (var item in player.GetAvalibleUnits())
            {
                Button newBtn = new Button();
                item.Draw(newBtn);
                newBtn.Tag = item;
                newBtn.Click += OnBuy;
                unitsStack.Children.Add(newBtn);
            }
        }

        private void OnUnitSpawned(Button button, BaseUnit unit)
        {
            Player player = _players[playerIndex];
            player.Units.Remove(unit);
            UpdatePlayerUnitsStackView(player);
        }

        private void UpdatePlayerUnitsStackView(Player player)
        {
            playerUnitsStack.Children.Clear();
            foreach (var item in player.Units)
            {
                Button newBtn = new Button();
                item.Draw(newBtn);
                newBtn.Tag = item;
                newBtn.Click += OnSelectForSpawn;
                (newBtn.Content as StackPanel).Children.RemoveAt(2);
                playerUnitsStack.Children.Add(newBtn);
            }
        }

        private void OnSelectForSpawn(object sender, RoutedEventArgs e)
        {
            foreach (Button button in playerUnitsStack.Children)
            {
                button.Background = new SolidColorBrush(Colors.LightGray);
            }
            _map.UnitForSpawn = (sender as Button).Tag as BaseUnit;
            (sender as Button).Background = new SolidColorBrush(Colors.LightBlue);
        }

        private void OnBuy(object sender, RoutedEventArgs e)
        {
            Player player = _players[playerIndex];
            BaseUnit unit = (sender as Button).Tag as BaseUnit;

            if (player.ReservePoints >= unit.Price)
            {
                player.BuyUnit(unit);
                playerMoneyDisplayLabel.Content = "Очков резерва: " + player.ReservePoints;
                UpdatePlayerUnitsStackView(player);
            }
                
            else
            {
                MessageBox.Show("У вас недостаточно очков резерва");
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
            _map.UnitSpawned = unitSpawned;
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
            playerMoneyDisplayLabel.Content = "Очков резерва: " + player.ReservePoints;
            ShowAvalibleUnits(player);
            UpdatePlayerUnitsStackView(player);
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
