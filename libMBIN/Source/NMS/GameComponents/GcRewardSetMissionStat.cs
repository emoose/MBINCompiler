namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7E8710EC5ABAC8A2, NameHash = 0x2CEF47EC)]
    public class GcRewardSetMissionStat : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 AddStatValue;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 SetToStatValue;
        [NMS(Index = 5)]
        /* 0x20 */ public int ValueToAdd;
        [NMS(Index = 4)]
        /* 0x24 */ public int ValueToSet;
        [NMS(Index = 2)]
        /* 0x28 */ public bool AddAmountFromSeasonData;
        [NMS(Index = 3)]
        /* 0x29 */ public bool SetAmountFromSeasonData;
    }
}
