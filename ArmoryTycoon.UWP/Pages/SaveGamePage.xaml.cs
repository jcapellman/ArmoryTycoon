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

            Vm.CurrentGame = (Game)e.Parameter;
        }
        
        private void btnBack_OnClick(object sender, RoutedEventArgs e) => Frame.GoBack();

        private void btnSave_OnClick(object sender, RoutedEventArgs e)
        {
            var result = Vm.SaveGame();

            if (result)
            {
                // Display
            }
        }
    }
}