using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9A9746739829F9A6, NameHash = 0xD2FC1AF5)]
    public class GcParticleAction : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Effect;
        [NMS(Index = 3)]
        /* 0x10 */ public GcBroadcastLevel FindRange;
        [NMS(Index = 1)]
        /* 0x14 */ public NMSString0x20 Joint;
        [NMS(Index = 2)]
        /* 0x34 */ public bool Exact;
    }
}
