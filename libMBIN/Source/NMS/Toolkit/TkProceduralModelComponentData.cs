using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB76A6A0932780D6D, NameHash = 0x8D90EB3D)]
    public class TkProceduralModelComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFilename> List;
    }
}
