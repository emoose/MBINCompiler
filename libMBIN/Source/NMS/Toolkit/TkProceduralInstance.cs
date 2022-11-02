using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCA76169BDE71BB63, NameHash = 0x4D8A5C89BC8B3F)]
    public class TkProceduralInstance : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x0 */ public TkProceduralInstanceData[] Data;
    }
}
