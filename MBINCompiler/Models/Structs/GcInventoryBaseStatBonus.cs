namespace MBINCompiler.Models.Structs
{
    public class GcInventoryBaseStatBonus : NMSTemplate     // size: 0x8
    {
        public GcStatsTypes StatType;
        public bool LessIsBetter;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
