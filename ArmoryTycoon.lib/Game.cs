using ArmoryTycoon.lib.Common;
using ArmoryTycoon.lib.DAL.Objects;

namespace ArmoryTycoon.lib
{
    public class Game
    {
        public SaveGame CurrentGame;
        
        public Game()
        {
            CurrentGame = new SaveGame();
        }

        public void LoadGame(SaveGame saveGame)
        {
            CurrentGame = saveGame;
        }
        
        public void NextQuarter()
        {
            if (CurrentGame.Quarter == 4)
            {
                CurrentGame.Year++;
                CurrentGame.Quarter = Constants.STARTING_QUARTER;
            }
            else
            {
                CurrentGame.Quarter++;
            }
        }
    }
}