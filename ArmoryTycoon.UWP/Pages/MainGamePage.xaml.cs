using System;

using Windows.UI.Popups;
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
            
            Vm.UpdateBindings();
        }

        private void mfiLoadGame_OnClick(object sender, RoutedEventArgs e) => Frame.Navigate(typeof(LoadGamePage));

        private void mfiExitGame_OnClick(object sender, RoutedEventArgs e) => Frame.Navigate(typeof(MainPage));

        private void mfiSaveGame_OnClick(object sender, RoutedEventArgs e) => Frame.Navigate(typeof(SaveGamePage), Vm.CurrentGame);

        private void btnCompleteTurn_OnClick(object sender, RoutedEventArgs e)
        {
            Vm.CompleteTurn();
        }
        
        private void btnUpgradeManufacturing_OnClick(object sender, RoutedEventArgs e) => Vm.UpgradeManufacturing();

        private async void btnAddArmoryItem_OnClick(object sender, RoutedEventArgs e)
        {
            Vm.AddArmoryItem();

            var md = new MessageDialog("Successfully added armory item");

            await md.ShowAsync();
        }
    }
}