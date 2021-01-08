using System.ComponentModel;
using System.Runtime.CompilerServices;

using ArmoryTycoon.lib.DAL.Objects;
using ArmoryTycoon.UWP.Annotations;

namespace ArmoryTycoon.UWP.ViewModels
{
    public class NewGameViewModel : INotifyPropertyChanged
    {
        private string _name;

        public string Name
        {
            get => _name;

            set
            {
                _name = value;
                
                OnPropertyChanged();
                
                ValidateForm();
            }
        }

        private bool _enableNewGameButton;

        public bool EnableNewGameButton
        {
            get => _enableNewGameButton;

            set
            {
                _enableNewGameButton = value;
                
                OnPropertyChanged();
            }
        }

        private void ValidateForm()
        {
            EnableNewGameButton = !string.IsNullOrEmpty(Name);
        }
        
        public NewGameViewModel()
        {
            Name = string.Empty;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Game CreateGame() =>
            new Game
            {
                Name = Name
            };
    }
}