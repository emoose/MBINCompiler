using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x990A0508C5DCEEE6, NameHash = 0xF671716161E708E3)]
    public class TkMeshData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 IdString;
        /* 0x80 */ public ulong Hash;
        /* 0x88 */ public int VertexDataSize;
        /* 0x8C */ public int IndexDataSize;
        /* 0x90 */ public List<byte> MeshDataStream;
    }
}
