using Korelskiy.Models.Maps;
using Korelskiy.Models.Units;
using Korelskiy.Models.Units.Airplanes.Fighters;
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
        private IMap map;

        public GameWindow(IMap map)
        {
            InitializeComponent();
            this.map = map;
            DrawMap();
            AddUnitsToStack();
            mapTitleLable.Content = map.Title;
        }

        private void DrawMap()
        {
            map.Draw(mapGrid);
        }

        private void AddUnitsToStack()
        {
            IUnit bf = new Bf109(new Button());
            unitsStack.Children.Add(bf.Display());
        }

        private void backToGameSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            GameSettingsWindow window = new GameSettingsWindow();
            window.Show();
            this.Close();
        }
    }
}
