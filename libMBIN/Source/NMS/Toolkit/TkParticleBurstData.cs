using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6026455A2E436CAA, NameHash = 0x523281BEC01AA0F4)]
    public class TkParticleBurstData : NMSTemplate
    {
        /* 0x00 */ public TkEmitterFloatProperty BurstAmount;
        /* 0x78 */ public TkEmitterFloatProperty BurstInterval;
        /* 0xF0 */ public int LoopCount;
    }
}
