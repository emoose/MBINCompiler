using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD6E11F73C873F45, NameHash = 0x523281BEC01AA0F4)]
    public class TkParticleBurstData : NMSTemplate
    {
        /* 0x000 */ public TkEmitterFloatProperty BurstAmount;
        /* 0x080 */ public TkEmitterFloatProperty BurstInterval;
        /* 0x100 */ public int LoopCount;
    }
}
