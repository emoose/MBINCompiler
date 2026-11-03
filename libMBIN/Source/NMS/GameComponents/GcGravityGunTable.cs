using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCBDA7513A787CD7B, NameHash = 0x48B8C73A)]
    public class GcGravityGunTable : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcGravityGunTableItem> GravityGuns;
        [NMS(Index = 0)]
        /* 0x10 */ public GcFilename Resource;
    }
}
