namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBB60B220A255A7B3, NameHash = 0xD8850AC59C3175E1)]
    public class GcRewardSetCurrentMission : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Mission;
        /* 0x10 */ public bool Silent;
        /* 0x11 */ public bool Seeded;
    }
}
