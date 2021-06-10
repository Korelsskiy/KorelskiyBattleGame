using Korelskiy.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Korelskiy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetBackgroundImage();
        }
        private void SetBackgroundImage()
        {
            int randomPhoto = new Random().Next(0, 4);
            mainMenuBackgroundImage.Source = new BitmapImage(new Uri($"../Images/MainMenuBacground/{randomPhoto}.jpg", UriKind.Relative));
        }

        private void startGameButton_Click(object sender, RoutedEventArgs e)
        {
            GameWindow window = new GameWindow();
            window.Show();
            this.Close();
        }
    }
}
