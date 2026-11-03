namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x62C45FD8CD92FDB9, NameHash = 0x76BBEA43)]
    public class GcMissionConditionCriticalMissionsDone : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public bool OnlyCheckSeasonalCriticals;
        [NMS(Index = 0)]
        /* 0x1 */ public bool Warped;
    }
}
