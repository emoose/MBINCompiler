namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE82CC5A682AAFFAA, NameHash = 0x123BB0B7)]
    public class GcMissionConditionHasProcTechnology : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A ProcTechGroupID;
        [NMS(Index = 1)]
        /* 0x20 */ public int Count;
    }
}
