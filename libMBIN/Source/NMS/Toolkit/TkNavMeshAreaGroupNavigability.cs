using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA17531643A3F8C3F, NameHash = 0x81C54715)]
    public class TkNavMeshAreaGroupNavigability : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 AreaGroupId;
        [NMS(Index = 1)]
        /* 0x10 */ public TkNavMeshAreaNavigability Navigability;
    }
}
