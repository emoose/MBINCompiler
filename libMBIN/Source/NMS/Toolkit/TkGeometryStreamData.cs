using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCCB46895A8B36313, NameHash = 0x40025754)]
    public class TkGeometryStreamData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkMeshData> StreamDataArray;
    }
}
