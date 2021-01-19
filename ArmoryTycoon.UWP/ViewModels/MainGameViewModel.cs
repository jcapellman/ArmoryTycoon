﻿using System.ComponentModel;
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

        private ArmoryItem _newArmoryItem;

        public ArmoryItem NewArmoryItem
        {
            get => _newArmoryItem;

            set
            {
                _newArmoryItem = value;
                
                OnPropertyChanged();
            }
        }

        private ArmoryItem _selectedArmoryItem;

        public ArmoryItem SelectedArmoryItem
        {
            get => _selectedArmoryItem;

            set
            {
                _selectedArmoryItem = value;
                
                OnPropertyChanged();
            }
        }
        
        private bool _upgradeAvailable;

        public bool UpgradeAvailable
        {
            get => _upgradeAvailable;

            set
            {
                _upgradeAvailable = value;
                
                OnPropertyChanged();
            }
        }

        private string _upgradeText;

        public string UpgradeText
        {
            get => _upgradeText;

            set
            {
                _upgradeText = value;
                
                OnPropertyChanged();
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        // todo: cleanup
        public void UpdateBindings()
        {
            UpgradeAvailable = CurrentGame.Cash >= CurrentGame.Manufacturing.NextLevelCost;

            UpgradeText = $"Next upgrade cost is ${CurrentGame.Manufacturing.NextLevelCost}";
            
            OnPropertyChanged(nameof(CurrentGame));

            NewArmoryItem = new ArmoryItem();
            
            OnPropertyChanged(nameof(NewArmoryItem));
        }

        public void AddArmoryItem()
        {
            CurrentGame.AddArmoryItem(NewArmoryItem);
            
            UpdateBindings();
        }
        
        public void UpgradeManufacturing()
        {
            CurrentGame.Cash -= CurrentGame.Manufacturing.NextLevelCost;
            
            CurrentGame.Manufacturing.LevelUp();
            
            UpdateBindings();
        }
        
        public void CompleteTurn()
        {
            CurrentGame.CompleteTurn();

            UpdateBindings();
        }
    }
}