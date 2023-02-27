using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7A6AB24B3910461E, NameHash = 0xBB7B4EAD531E3D6)]
    public class GcNPCInteractionData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public TkAttachmentData Data;
    }
}
