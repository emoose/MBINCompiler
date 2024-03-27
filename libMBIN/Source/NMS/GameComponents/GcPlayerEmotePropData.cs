using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3E4771511FBAD7C7, NameHash = 0x7E08658A660A58D4)]
    public class GcPlayerEmotePropData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Model;
        /* 0x080 */ public float Scale;
        /* 0x084 */ public GcHand Hand;
        /* 0x088 */ public bool IsHologram;
        /* 0x089 */ public NMSString0x40 ScanEffectNodeName;
        /* 0x0D0 */ public GcScanEffectData ScanEffect;
        /* 0x120 */ public float DelayTime;
    }
}
