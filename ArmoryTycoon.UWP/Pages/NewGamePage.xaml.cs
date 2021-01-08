using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using ArmoryTycoon.UWP.ViewModels;

namespace ArmoryTycoon.UWP.Pages
{
    public sealed partial class NewGamePage : Page
    {
        private NewGameViewModel Vm => (NewGameViewModel) DataContext;
        
        public NewGamePage()
        {
            InitializeComponent();

            DataContext = new NewGameViewModel();
        }

        private void btnBack_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void btnNewGame_OnClick(object sender, RoutedEventArgs e)
        {
            var game = Vm.CreateGame();

            Frame.Navigate(typeof(MainGamePage), game);
        }
    }
}