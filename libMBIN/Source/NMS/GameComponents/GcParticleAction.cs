using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x485DCE7CBEDE05A2, NameHash = 0x88C11D6208F25864)]
    public class GcParticleAction : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Effect;
        /* 0x10 */ public NMSString0x20 Joint;
        /* 0x30 */ public bool Exact;
        /* 0x34 */ public GcBroadcastLevel FindRange;
    }
}
