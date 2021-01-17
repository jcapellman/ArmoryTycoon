namespace ArmoryTycoon.lib.DAL.Objects
{
    public class ManufacturingItem
    {
        private const int Multiplier_Quality = 2;
        private const int Multiplier_Throughput = 1000;
        private const int Multiplier_Cost = 25000;
        private const int Initial_Level = 1;
        private const int Multiplier_Worth = 50000;
        
        public int QuarterlyCost { get; set; }

        public int MaxThroughput { get; set; }

        public int MaxQuality { get; set; }
        
        public int Worth { get; set; }

        public int Level { get; set; }
        
        public ManufacturingItem()
        {
            MaxThroughput = Multiplier_Throughput;

            MaxQuality = Multiplier_Quality;

            Worth = 0;

            QuarterlyCost = Multiplier_Cost;

            Level = Initial_Level;
        }

        public int NextLevelCost => Level * Multiplier_Cost;

        public void LevelUp()
        {
            Level++;
            
            QuarterlyCost = Level * Multiplier_Cost;
            MaxQuality += Multiplier_Quality;
            MaxThroughput = Level * Multiplier_Throughput;
            Worth = Level * Multiplier_Worth;
        }
    }
}