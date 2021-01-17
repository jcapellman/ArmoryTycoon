namespace ArmoryTycoon.lib.DAL.Objects
{
    public class ManufacturingItem
    {
        public int QuarterlyCost { get; set; }

        public int MaxThroughput { get; set; }

        public int MaxQuality { get; set; }
        
        public int Worth { get; set; }

        public int Level { get; set; }
        
        public ManufacturingItem()
        {
            MaxThroughput = 1000;

            MaxQuality = 10;

            Worth = 0;

            QuarterlyCost = 25000;

            Level = 1;
        }
    }
}