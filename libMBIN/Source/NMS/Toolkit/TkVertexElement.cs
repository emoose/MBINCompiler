namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7B45114B1556765A, NameHash = 0xC4D67634)]
    public class TkVertexElement : NMSTemplate
    {
        // size: 0x2
        public enum InstancingEnum : uint {
            PerVertex,
            PerModel,
        }
        [NMS(Index = 5)]
        /* 0x0 */ public InstancingEnum Instancing;
        [NMS(Index = 0)]
        /* 0x4 */ public int Type;
        [NMS(Index = 2)]
        /* 0x8 */ public byte Normalise;
        [NMS(Index = 4)]
        /* 0x9 */ public byte Offset;
        [NMS(Index = 1)]
        /* 0xA */ public byte SemanticID;
        [NMS(Index = 3)]
        /* 0xB */ public byte Size;
    }
}
