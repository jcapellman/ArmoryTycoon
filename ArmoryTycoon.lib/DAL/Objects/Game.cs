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

        public List<ArmoryItem> DesignArmoryItems { get; set; }

        public ManufacturingItem Manufacturing { get; set; }
        
        public Game()
        {
            Year = Constants.STARTING_YEAR;
            Quarter = Constants.STARTING_QUARTER;

            Cash = Constants.STARTING_CASH;

            ArmoryItems = new List<ArmoryItem>();

            DesignArmoryItems = new List<ArmoryItem>();
            
            Manufacturing = new ManufacturingItem();
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

            ManufactureItems();
        }

        private void ManufactureItems()
        {
            foreach (var item in ArmoryItems)
            {
                if (item.QuarterlyManufacture == 0)
                {
                    continue;
                }

                Cash -= item.QuarterlyManufacture * item.ManufactureCost;
            }

            Cash -= Manufacturing.QuarterlyCost;
        }

        public void AddArmoryItem(ArmoryItem newArmoryItem)
        {
            DesignArmoryItems.Add(newArmoryItem);
        }
    }
}