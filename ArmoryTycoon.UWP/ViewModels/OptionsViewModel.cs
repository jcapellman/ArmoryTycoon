using System.ComponentModel;
using System.Runtime.CompilerServices;

using ArmoryTycoon.UWP.Annotations;

namespace ArmoryTycoon.UWP.ViewModels
{
    public class OptionsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}