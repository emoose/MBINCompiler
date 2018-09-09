using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x10, GUID = 0x602CB74A9031204B)]
    public class TkGeometryStreamData : NMSTemplate
    {
        /* 0x00 */ public List<TkMeshData> StreamDataArray;
    }
}
