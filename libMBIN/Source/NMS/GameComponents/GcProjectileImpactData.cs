using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7B8919E91759922E, NameHash = 0x2F2FAFA4A7023B71)]
    public class GcProjectileImpactData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Effect;
        /* 0x10 */ public GcProjectileImpactType Impact;
        // size: 0x3
        public enum ImpactAlignmentEnum : uint {
            ImpactNormal,
            ImpactReflected,
            GravityUp,
        }
        /* 0x14 */ public ImpactAlignmentEnum ImpactAlignment;
        // size: 0x2
        public enum ImpactAttachmentEnum : uint {
            World,
            HitBody,
        }
        /* 0x18 */ public ImpactAttachmentEnum ImpactAttachment;
    }
}
