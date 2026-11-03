namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xECCE1183BC8923F9, NameHash = 0xE3F21EDA)]
    public class GcMissionConditionFeedingCreatures : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int MinCreatures;
        [NMS(Index = 1)]
        /* 0x4 */ public bool TakeNumFromSeasonData;
    }
}
