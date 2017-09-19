using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x28)]
    public class TkAttachmentData : NMSTemplate
    {
        /* 0x00 */ public List<NMSTemplate> Components;
        [NMS(Size = 0x5)]
        /* 0x10 */ public float[] LodDistances;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x24 */ public byte[] EndPadding;
    }
}
