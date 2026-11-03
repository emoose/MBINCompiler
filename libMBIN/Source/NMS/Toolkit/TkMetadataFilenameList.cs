using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8138D43FBA9C8C70, NameHash = 0x4775FB9B)]
    public class TkMetadataFilenameList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFilename> Filenames;
    }
}
