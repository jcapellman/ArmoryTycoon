using System.Collections.Generic;

using ArmoryTycoon.lib.Common;

namespace ArmoryTycoon.lib.DAL.Objects
{
    public class Game
    {
        public int Id { get; set; }
        
        public string SaveGameName { get; set; }
        
        public string Name { get; set; }
        
        public int Cash { get; set; }
        
        public int Year { get; set; }
        
        public int Quarter { get; set; }

        public List<ArmoryItem> ArmoryItems { get; set; }
        
        public Game()
        {
            Year = Constants.STARTING_YEAR;
            Quarter = Constants.STARTING_QUARTER;

            Cash = Constants.STARTING_CASH;

            ArmoryItems = new List<ArmoryItem>();
        }

        private void IterateQuarter()
        {
            if (Quarter == 4)
            {
                Year++;
                Quarter = Constants.STARTING_QUARTER;
            }
            else
            {
                Quarter++;
            }
        }
        
        public void CompleteTurn()
        {
            IterateQuarter();
            
            
        }
    }
}