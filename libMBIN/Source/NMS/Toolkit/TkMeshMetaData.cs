namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD4F028FB952E77D3, NameHash = 0x6C564DBA)]
    public class TkMeshMetaData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcFilename IdString;
        [NMS(Index = 1)]
        /* 0x10 */ public ulong Hash;
        [NMS(Index = 7)]
        /* 0x18 */ public int IndexDataOffset;
        [NMS(Index = 6)]
        /* 0x1C */ public int IndexDataSize;
        [NMS(Index = 3)]
        /* 0x20 */ public int VertexDataOffset;
        [NMS(Index = 2)]
        /* 0x24 */ public int VertexDataSize;
        [NMS(Index = 5)]
        /* 0x28 */ public int VertexPositionDataOffset;
        [NMS(Index = 4)]
        /* 0x2C */ public int VertexPositionDataSize;
        [NMS(Index = 8)]
        /* 0x30 */ public bool DoubleBufferGeometry;
    }
}
