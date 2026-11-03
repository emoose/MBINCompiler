using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1119E1B413924B48, NameHash = 0x77B18AA4)]
    public class GcMissionConditionHasValidSaveContext : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcSaveContextQuery CurrentContext;
        [NMS(Index = 1)]
        /* 0x4 */ public GcSaveContextQuery DesiredContext;
    }
}
