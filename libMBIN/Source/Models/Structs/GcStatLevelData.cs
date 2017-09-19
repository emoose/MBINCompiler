namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x40)]
    public class GcStatLevelData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string LevelName;
        /* 0x20 */ public GcStatValueData Value;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2C */ public byte[] Padding2C;
        [NMS(Size = 0x10)]
        /* 0x30 */ public string TrophyToUnlock;
    }
}
