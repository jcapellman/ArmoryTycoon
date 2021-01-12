using System.ComponentModel;
using System.Runtime.CompilerServices;

using ArmoryTycoon.lib.DAL.Objects;
using ArmoryTycoon.UWP.Annotations;

namespace ArmoryTycoon.UWP.ViewModels
{
    public class SaveGameViewModel : INotifyPropertyChanged
    {
        private string _saveGameName;

        public string SaveGameName
        {
            get => _saveGameName;

            set
            {
                _saveGameName = value;

                OnPropertyChanged();
            }
        }

        public void Initialize(Game currentGame)
        {
            CurrentGame = currentGame;

            SaveGameName = currentGame.SaveGameName;
        }
        
        public Game CurrentGame;
        
        public bool SaveGame()
        {
            CurrentGame.SaveGameName = SaveGameName;

            return App.DAL.SaveNewGame(CurrentGame);
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}