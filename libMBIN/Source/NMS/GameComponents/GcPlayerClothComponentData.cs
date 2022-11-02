using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x213859FDDD70008E, NameHash = 0x7095201046A71EFE, Alignment = 0x10)]
    public class GcPlayerClothComponentData : NMSTemplate
    {
        /* 0x00 */ public bool Enabled;
        /* 0x04 */ public int NumConstraintSolvingIterations;
        /* 0x08 */ public List<GcClothPiece> ClothPieces;
        /* 0x18 */ public float ClothScale;
        /* 0x1C */ public float CollisionScale;
        /* 0x20 */ public float AttachmentScale;
    }
}
