using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCD3212C5B64C7B14, NameHash = 0x3246DB9846FF8B70)]
    public class GcPlayerCommunicatorMessageWeighted : NMSTemplate
    {
        /* 0x00 */ public GcPlayerCommunicatorMessage Message;
        /* 0x58 */ public int Weight;
    }
}
