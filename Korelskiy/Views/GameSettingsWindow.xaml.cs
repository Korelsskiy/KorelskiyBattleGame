using Korelskiy.Models.Maps;
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
    /// Interaction logic for GameSettingsWindow.xaml
    /// </summary>
    public partial class GameSettingsWindow : Window
    {
        public GameSettingsWindow()
        {
            InitializeComponent();
            LoadMapBox();
        }

        private void LoadMapBox()
        {
            List<BaseMap> allMaps = new List<BaseMap> { new AlfaMap(), new BetaMap(), new CharlyMap(), new DeltaMap()};
            string[] places = new string[] { @"Операция ""Вайс""(1939)" };

            operationComboBox.ItemsSource = places;
            mapSelectBox.ItemsSource = allMaps;

            mapSelectBox.DisplayMemberPath = "Title";

            operationComboBox.SelectedIndex = 0;
            mapSelectBox.SelectedIndex = 0;


        }

        private void startGameButton_Click(object sender, RoutedEventArgs e)
        {
            GameWindow game = new GameWindow(mapSelectBox.SelectedItem as BaseMap, operationComboBox.SelectedItem.ToString());
            game.Show();
            this.Close();
        }

        private void backToMainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
