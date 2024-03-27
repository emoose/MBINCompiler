using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFC8CD57827D81843, NameHash = 0x28A143D89E217108)]
    public class GcTerrainEditsBuffer : NMSTemplate
    {
        [NMS(Size = 0x100)]
        /* 0x0000 */ public ulong[] GalacticAddresses;
        [NMS(Size = 0x100)]
        /* 0x0800 */ public int[] BufferSizes;
        [NMS(Size = 0x100)]
        /* 0x0C00 */ public byte[] BufferAges;
        [NMS(Size = 0x100)]
        /* 0x0D00 */ public Vector3f[] BufferAnchors;
        [NMS(Size = 0x100)]
        /* 0x1D00 */ public bool[] BufferProtected;
        [NMS(Size = 0x7530)]
        /* 0x1E00 */ public GcTerrainEdit[] Edits;
    }
}
