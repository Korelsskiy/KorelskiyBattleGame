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

        public GameWindow()
        {
            InitializeComponent();
            map = new AlfaMap();
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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Вы уверены, что хотите выйти из игры?", "Выход из игры", MessageBoxButton.YesNo);
            if(messageBoxResult != MessageBoxResult.Yes)
            {
                e.Cancel = true;
                return;
            }
            else
            {
                Application.Current.Shutdown();
            }
        }
    }
}
