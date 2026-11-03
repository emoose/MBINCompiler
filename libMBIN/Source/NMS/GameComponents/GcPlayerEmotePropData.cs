using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3346732A689F5B1, NameHash = 0x367BEA5)]
    public class GcPlayerEmotePropData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public GcScanEffectData ScanEffect;
        [NMS(Index = 0)]
        /* 0x50 */ public GcFilename Model;
        [NMS(Index = 6)]
        /* 0x60 */ public float DelayTime;
        [NMS(Index = 2)]
        /* 0x64 */ public GcHand Hand;
        [NMS(Index = 1)]
        /* 0x68 */ public float Scale;
        [NMS(Index = 4)]
        /* 0x6C */ public NMSString0x40 ScanEffectNodeName;
        [NMS(Index = 3)]
        /* 0xAC */ public bool IsHologram;
    }
}
