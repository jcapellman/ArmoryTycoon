using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using ArmoryTycoon.UWP.Pages;

namespace ArmoryTycoon.UWP
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnLoadGame_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(LoadGamePage));
        }

        private void btnNewGame_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(NewGamePage));
        }
    }
}