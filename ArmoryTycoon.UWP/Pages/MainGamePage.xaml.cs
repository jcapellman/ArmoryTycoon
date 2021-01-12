using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

using ArmoryTycoon.lib.DAL.Objects;
using ArmoryTycoon.UWP.ViewModels;

namespace ArmoryTycoon.UWP.Pages
{
    public sealed partial class MainGamePage : Page
    {
        private MainGameViewModel Vm => (MainGameViewModel) DataContext;
        
        public MainGamePage()
        {
            this.InitializeComponent();

            DataContext = new MainGameViewModel();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            Vm.CurrentGame = (Game) e.Parameter;
        }

        private void mfiLoadGame_OnClick(object sender, RoutedEventArgs e) => Frame.Navigate(typeof(LoadGamePage));

        private void mfiExitGame_OnClick(object sender, RoutedEventArgs e) => Frame.Navigate(typeof(MainPage));

        private void mfiSaveGame_OnClick(object sender, RoutedEventArgs e) => Frame.Navigate(typeof(SaveGamePage), Vm.CurrentGame);
    }
}