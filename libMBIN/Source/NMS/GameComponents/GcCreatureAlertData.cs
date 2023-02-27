using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8344B26B24BE8FFF, NameHash = 0xFFF2D3D18F84C008)]
    public class GcCreatureAlertData : NMSTemplate
    {
        /* 0x00 */ public GcCreatureTypes AlertTarget;
        /* 0x04 */ public GcCreatureTypes AlertInitiator;
        /* 0x08 */ public float HearingRange;
        /* 0x0C */ public float SightRange;
        /* 0x10 */ public float SightAngle;
        /* 0x14 */ public float FleeRange;
    }
}
