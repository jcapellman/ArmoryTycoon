using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

using ArmoryTycoon.lib.DAL.Objects;

namespace ArmoryTycoon.UWP.ViewModels
{
    public class LoadGameViewModel : INotifyPropertyChanged
    {
        public class LoadGameListing
        {
            public int ID { get; set; }

            public string Name { get; set; }
        }

        private List<LoadGameListing> _gameListing;

        public List<LoadGameListing> GameListing
        {
            get => _gameListing;

            set
            {
                _gameListing = value;

                OnPropertyChanged();
            }
        }

        public void Initialize()
        {
            GameListing = App.DAL.GetSaveGameList().Select(a => new LoadGameListing
            {
                ID = a.Key, Name = a.Value
            }).ToList();
        }

        public Game LoadGame(int gameId) => App.DAL.LoadSaveGame(gameId);

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}