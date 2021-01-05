using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

using ArmoryTycoon.lib.DAL.Base;

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

        private BaseDAL _baseDal;

        public void Initialize(BaseDAL baseDal)
        {
            _baseDal = baseDal;

            GameListing = _baseDal.GetSaveGameList().Select(a => new LoadGameListing
            {
                ID = a.Key, Name = a.Value
            }).ToList();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
