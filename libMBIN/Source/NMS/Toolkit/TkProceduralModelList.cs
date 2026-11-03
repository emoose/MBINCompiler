using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9CECF00378A2A7F1, NameHash = 0x43BDFA5)]
    public class TkProceduralModelList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcFilename> List;
    }
}
