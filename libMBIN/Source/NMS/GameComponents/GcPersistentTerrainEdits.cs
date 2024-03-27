using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC359CE7CE22DC772, NameHash = 0xC6506D02A6391EEB)]
    public class GcPersistentTerrainEdits : NMSTemplate
    {
        /* 0x00 */ public ulong GalacticAddress;
        /* 0x08 */ public List<int> BufferSizes;
        /* 0x18 */ public List<Vector3f> BufferAnchors;
        /* 0x28 */ public List<GcTerrainEdit> Edits;
    }
}
