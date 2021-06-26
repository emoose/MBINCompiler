using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1F2C0, GUID = 0x437F3DD67FC0547F, NameHash = 0x28A143D89E217108)]
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
        [NMS(Size = 0x3A98)]
        /* 0x1E00 */ public GcTerrainEdit[] Edits;
    }
}
