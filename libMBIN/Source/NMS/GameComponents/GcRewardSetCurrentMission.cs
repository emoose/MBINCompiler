namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2F9933C0D2DAA0F4, NameHash = 0x901E9005)]
    public class GcRewardSetCurrentMission : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Mission;
        [NMS(Index = 2)]
        /* 0x10 */ public bool Seeded;
        [NMS(Index = 1)]
        /* 0x11 */ public bool Silent;
    }
}
