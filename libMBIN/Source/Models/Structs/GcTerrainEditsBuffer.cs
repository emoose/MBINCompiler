using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcTerrainEditsBuffer : NMSTemplate      // size: 0xACC0
    {
        [NMS(Size = 0x80)]
        /* 0x0000 */ public ulong[] GalacticAddresses;       // maybe?
        [NMS(Size = 0x80)]
        /* 0x0400 */ public int[] BufferOffsets;
        [NMS(Size = 0x80)]
        /* 0x0600 */ public int[] BufferSizes;
        [NMS(Size = 0x80)]
        /* 0x0800 */ public byte[] BufferAges;
        [NMS(Size = 0x80)]
        /* 0x0880 */ public Vector4f[] BufferAnchors;
        [NMS(Size = 0x1388)]
        /* 0x1080 */ public GcTerrainEdit[] Edits;
    }
}
