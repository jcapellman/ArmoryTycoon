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
    }
}