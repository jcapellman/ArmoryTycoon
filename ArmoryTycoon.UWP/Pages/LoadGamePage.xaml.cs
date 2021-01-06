using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using ArmoryTycoon.lib.DAL;
using ArmoryTycoon.UWP.ViewModels;

namespace ArmoryTycoon.UWP.Pages
{
    public sealed partial class LoadGamePage : Page
    {
        private LoadGameViewModel Vm => (LoadGameViewModel) DataContext;
        
        public LoadGamePage()
        {
            this.InitializeComponent();

            DataContext = new LoadGameViewModel();
            
            Vm.Initialize(new LitedbDAL());
        }

        private void btnBack_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void btnLoadGame_OnClick(object sender, RoutedEventArgs e)
        {
            var game = Vm.LoadGame(((LoadGameViewModel.LoadGameListing) sender).ID);

            Frame.Navigate(typeof(MainGamePage), game);
        }
    }
}