using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7E50420BA98B940A, NameHash = 0x85DDBDB8)]
    public class GcSyncBufferSaveDataArray : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcSyncBufferSaveData> Data;
    }
}
