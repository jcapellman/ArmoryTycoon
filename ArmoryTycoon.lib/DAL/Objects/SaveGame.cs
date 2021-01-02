using ArmoryTycoon.lib.Common;

namespace ArmoryTycoon.lib.DAL.Objects
{
    public class SaveGame
    {
        public string Name { get; set; }
        
        public int Cash { get; set; }
        
        public int Year { get; set; }
        
        public int Quarter { get; set; }

        public SaveGame()
        {
            Year = Constants.STARTING_YEAR;
            Quarter = Constants.STARTING_QUARTER;

            Cash = Constants.STARTING_CASH;
        }
    }
}