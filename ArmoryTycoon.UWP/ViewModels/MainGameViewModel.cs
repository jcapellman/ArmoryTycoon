using System.ComponentModel;
using System.Runtime.CompilerServices;

using ArmoryTycoon.lib.DAL.Objects;

namespace ArmoryTycoon.UWP.ViewModels
{
    public class MainGameViewModel : INotifyPropertyChanged
    {
        private Game _currentGame;

        public Game CurrentGame
        {
            get => _currentGame;

            set
            {
                _currentGame = value;

                OnPropertyChanged();
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void CompleteTurn()
        {
            CurrentGame.CompleteTurn();
            
            OnPropertyChanged(nameof(CurrentGame));
        }
    }
}