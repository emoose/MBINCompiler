namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1082F0D32435D837, NameHash = 0x8F4041AD)]
    public class GcRewardReinitialise : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A OverrideMessage;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x10 OverrideStartWithIntroQuizID;
        [NMS(Index = 1)]
        /* 0x30 */ public bool DoIntroNextWarp;
        [NMS(Index = 3)]
        /* 0x31 */ public bool ShowPlanetDiscoveryMessage;
    }
}
