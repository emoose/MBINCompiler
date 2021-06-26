using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x320, GUID = 0xAE168EB8E846799D, NameHash = 0x61E014828AD14CD)]
    public class GcPulseEncounterSpawnTrader : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement CustomShipResource;
        /* 0x2A8 */ public bool UseCustomMessage;
        /* 0x2B0 */ public NMSString0x20A CustomHailOSD;
        /* 0x2D0 */ public GcPlayerCommunicatorMessage HailingMessage;
    }
}
