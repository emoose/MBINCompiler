using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA337A9D308CFDDD3, NameHash = 0xDB998DBB6155E40C)]
    public class GcMissionConditionHasGalacticFeature : NMSTemplate
    {
        /* 0x0 */ public GcMissionGalacticFeature Type;
        /* 0x4 */ public bool RequireUnusedAtlas;
    }
}
