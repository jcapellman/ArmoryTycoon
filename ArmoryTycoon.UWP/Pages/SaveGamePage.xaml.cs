using System;

using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

using ArmoryTycoon.lib.DAL.Objects;
using ArmoryTycoon.UWP.ViewModels;

namespace ArmoryTycoon.UWP.Pages
{
    public sealed partial class SaveGamePage : Page
    {
        private SaveGameViewModel Vm => (SaveGameViewModel) DataContext;
        
        public SaveGamePage()
        {
            InitializeComponent();

            DataContext = new SaveGameViewModel();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            Vm.Initialize((Game)e.Parameter);
        }
        
        private void btnBack_OnClick(object sender, RoutedEventArgs e) => Frame.GoBack();

        private async void btnSave_OnClick(object sender, RoutedEventArgs e)
        {
            var result = Vm.SaveGame();
            
            var dShow = new MessageDialog(result ? "Game saved successfully" : "Game failed to save");

            await dShow.ShowAsync();
        }
    }
}