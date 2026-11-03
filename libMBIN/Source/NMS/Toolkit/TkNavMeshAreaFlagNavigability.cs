using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x701A3C836FBF4153, NameHash = 0x80C899CB)]
    public class TkNavMeshAreaFlagNavigability : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public TkNavMeshAreaNavigability Navigability;
        [NMS(Index = 0)]
        /* 0xC */ public TkNavMeshAreaFlags AreaFlag;
    }
}
