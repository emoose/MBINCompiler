using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3EC99665C9BEDA73, NameHash = 0xCB8A0459)]
    public class TkParticleBurstData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkEmitterFloatProperty BurstAmount;
        [NMS(Index = 1)]
        /* 0x38 */ public TkEmitterFloatProperty BurstInterval;
        [NMS(Index = 2)]
        /* 0x70 */ public int LoopCount;
    }
}
