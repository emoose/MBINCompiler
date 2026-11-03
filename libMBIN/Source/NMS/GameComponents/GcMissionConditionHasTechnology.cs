namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x24A1EE0BC8B4ADD3, NameHash = 0x121D912E)]
    public class GcMissionConditionHasTechnology : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Technology;
        [NMS(Index = 4)]
        /* 0x10 */ public bool AllowedToSetPageHint;
        [NMS(Index = 1)]
        /* 0x11 */ public bool AllowPartiallyInstalled;
        [NMS(Index = 3)]
        /* 0x12 */ public bool TakeTechFromSeasonData;
        [NMS(Index = 2)]
        /* 0x13 */ public bool TeachIfNotKnown;
    }
}
