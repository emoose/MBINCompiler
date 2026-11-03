using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x44DA1F7B2883024D, NameHash = 0x8F8722D1)]
    public class GcMissionConditionHasGalacticFeature : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcMissionGalacticFeature Type;
        [NMS(Index = 1)]
        /* 0x4 */ public bool RequireUnusedAtlas;
    }
}
