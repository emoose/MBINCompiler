using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3FBCDC0BE5D1B629, NameHash = 0x9756E001A603A3B1)]
    public class TkAttachmentData : NMSTemplate
    {
        /* 0x00 */ public List<NMSTemplate> Components;
        [NMS(Size = 0x5)]
        /* 0x10 */ public float[] LodDistances;
    }
}
