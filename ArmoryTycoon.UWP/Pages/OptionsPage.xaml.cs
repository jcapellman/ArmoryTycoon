using Windows.UI.Xaml.Controls;

using ArmoryTycoon.UWP.ViewModels;

namespace ArmoryTycoon.UWP.Pages
{
    public sealed partial class OptionsPage : Page
    {
        public OptionsPage()
        {
            this.InitializeComponent();

            DataContext = new OptionsViewModel();
        }
    }
}