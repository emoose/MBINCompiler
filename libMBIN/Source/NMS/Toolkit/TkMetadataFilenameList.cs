using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x75310C981BE904BC, NameHash = 0x3F42E6C415489AAF)]
    public class TkMetadataFilenameList : NMSTemplate
    {
        /* 0x0 */ public List<NMSString0x80> Filenames;
    }
}
