using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x64439A039C09CE1F, NameHash = 0x7BFA6E42)]
    public class GcCreatureRoleFilenameList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureRoleFilename> Options;
    }
}
