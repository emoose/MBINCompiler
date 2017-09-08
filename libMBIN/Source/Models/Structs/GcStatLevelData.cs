namespace libMBIN.Models.Structs
{
    public class GcStatLevelData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string LevelName;
        public GcStatValueData Value;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding2C;
        [NMS(Size = 0x10)]
        public string TrophyToUnlock;
    }
}
