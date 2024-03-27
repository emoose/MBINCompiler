using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x12B81DB44F5724FF, NameHash = 0x53D72723F082671D)]
    public class GcRewardOSDMessage : NMSTemplate
    {
        /* 0x00 */ public float Time;
        /* 0x08 */ public NMSString0x20A Message;
        /* 0x28 */ public GcAudioWwiseEvents AudioEvent;
        /* 0x2C */ public TkTextureResource Icon;
        /* 0xB0 */ public Colour MessageColour;
        /* 0xC0 */ public bool UseTimedMessage;
    }
}
