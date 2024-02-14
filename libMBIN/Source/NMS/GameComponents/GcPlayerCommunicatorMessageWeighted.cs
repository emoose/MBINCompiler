using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4D15A0D5DF33A3D8, NameHash = 0x3246DB9846FF8B70)]
    public class GcPlayerCommunicatorMessageWeighted : NMSTemplate
    {
        /* 0x00 */ public GcPlayerCommunicatorMessage Message;
        /* 0x58 */ public int Weight;
    }
}
