namespace MBINCompiler.Models.Structs
{
    public class GcCostJourneyStatLevel : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string StatName;
        public int RequiredLevel;
    }
}
