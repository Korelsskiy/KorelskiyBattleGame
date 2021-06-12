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
            List<IMap> allMaps = new List<IMap> { new AlfaMap(), new BetaMap(), new CharlyMap()};
            mapSelectBox.ItemsSource = allMaps;
            mapSelectBox.DisplayMemberPath = "Title";
            mapSelectBox.SelectedIndex = 0;
        }

        private void startGameButton_Click(object sender, RoutedEventArgs e)
        {
            GameWindow game = new GameWindow(mapSelectBox.SelectedItem as IMap);
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
