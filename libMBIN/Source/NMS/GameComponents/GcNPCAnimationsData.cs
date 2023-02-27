using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5316AB210357681B, NameHash = 0x5344C3D579450D7B)]
    public class GcNPCAnimationsData : NMSTemplate
    {
        /* 0x000 */ public GcNPCAnimationSetData StandingAnimatons;
        /* 0x170 */ public GcNPCAnimationSetData StandingIPadAnimatons;
        /* 0x2E0 */ public GcNPCAnimationSetData SittingAnimatons;
        /* 0x450 */ public GcNPCAnimationSetData SittingIPadAnimatons;
    }
}
