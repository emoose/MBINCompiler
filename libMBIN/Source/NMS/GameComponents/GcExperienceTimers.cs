namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5E1BC36FA0FDBBC7, NameHash = 0x18D6647A)]
    public class GcExperienceTimers : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector2f High;
        [NMS(Index = 4)]
        /* 0x08 */ public Vector2f Low;
        [NMS(Index = 3)]
        /* 0x10 */ public Vector2f Normal;
        [NMS(Index = 0)]
        /* 0x18 */ public int HighChance;
        [NMS(Index = 1)]
        /* 0x1C */ public int LowChance;
    }
}
