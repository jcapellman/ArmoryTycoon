using System.ComponentModel;
using System.Runtime.CompilerServices;

using ArmoryTycoon.lib.GameObjects;
using ArmoryTycoon.UWP.Annotations;

namespace ArmoryTycoon.UWP.ViewModels
{
    public class OptionsViewModel : INotifyPropertyChanged
    {
        private Settings _setting;
        
        public Settings Setting
        {
            get => _setting;

            set
            {
                _setting = value;
                
                OnPropertyChanged();
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}