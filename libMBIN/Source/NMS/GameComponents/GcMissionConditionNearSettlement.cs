namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8D4E170804CD8747, NameHash = 0xAC710289)]
    public class GcMissionConditionNearSettlement : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float Distance;
        [NMS(Index = 1)]
        /* 0x4 */ public bool AllowBuildersSettlement;
        [NMS(Index = 2)]
        /* 0x5 */ public bool MustMatchThisMissionSeed;
    }
}
