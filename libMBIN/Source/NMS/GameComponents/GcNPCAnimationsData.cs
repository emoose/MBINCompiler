using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C2FAF7511369854, NameHash = 0x5344C3D579450D7B)]
    public class GcNPCAnimationsData : NMSTemplate
    {
        /* 0x000 */ public GcNPCAnimationSetData StandingAnimatons;
        /* 0x170 */ public GcNPCAnimationSetData StandingIPadAnimatons;
        /* 0x2E0 */ public GcNPCAnimationSetData StandingStaffAnimatons;
        /* 0x450 */ public GcNPCAnimationSetData SittingAnimatons;
        /* 0x5C0 */ public GcNPCAnimationSetData SittingIPadAnimatons;
    }
}
