using ArmoryTycoon.lib.Common;

namespace ArmoryTycoon.lib.DAL.Objects
{
    public class Game
    {
        public string Name { get; set; }
        
        public int Cash { get; set; }
        
        public int Year { get; set; }
        
        public int Quarter { get; set; }

        public Game()
        {
            Year = Constants.STARTING_YEAR;
            Quarter = Constants.STARTING_QUARTER;

            Cash = Constants.STARTING_CASH;
        }

        public void NextQuarter()
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
    }
}