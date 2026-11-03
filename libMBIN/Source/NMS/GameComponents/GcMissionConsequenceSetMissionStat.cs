namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3E530B2E674A76F3, NameHash = 0xB83591BC)]
    public class GcMissionConsequenceSetMissionStat : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int ValueToAdd;
        [NMS(Index = 0)]
        /* 0x4 */ public int ValueToSet;
    }
}
