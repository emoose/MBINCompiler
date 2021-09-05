using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x8, GUID = 0x81F06D407996A7B3, NameHash = 0x56A47F95DD76DC72)]
    public class TkEmitFromParticleInfo : NMSTemplate
    {
        /* 0x0 */ public int OtherEmitterIndex;
        public enum EmissionRateTypeEnum { PerParticle }
        /* 0x4 */ public EmissionRateTypeEnum EmissionRateType;
    }
}
