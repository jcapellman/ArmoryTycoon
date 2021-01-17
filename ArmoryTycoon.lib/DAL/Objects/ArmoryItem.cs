using ArmoryTycoon.lib.Enums;

namespace ArmoryTycoon.lib.DAL.Objects
{
    public class ArmoryItem
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public ArmoryItemType ArmoryType { get; set; }
        
        public ArmoryCalibers Caliber { get; set; }
        
        public int Price { get; set; }
        
        public int ManufactureCost { get; set; }
        
        public int YearIntroduced { get; set; }
        
        public int NumberSold { get; set; }
        
        public int Inventory { get; set; }
        
        public int QuarterlyManufacture { get; set; }
        
        public int Rating_BuildQuality { get; set; }
        
        public int Rating_Reliability { get; set; }
        
        public int Rating_Capacity { get; set; }
        
        public int Rating_Price { get; set; }
    }
}