namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD6B341FC8D162E0E, NameHash = 0x454547C8)]
    public class GcMissionConditionItemRewardedBySeason : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ItemID;
        [NMS(Index = 1)]
        /* 0x10 */ public bool TakeIDFromSeasonData;
    }
}
