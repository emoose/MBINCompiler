using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBC8BF2EA3F3EEA7F, NameHash = 0x89A5D7902BDAFE9B)]
    public class GcClothComponentData : NMSTemplate
    {
        /* 0x00 */ public bool Enabled;
        /* 0x04 */ public int NumConstraintSolvingIterations;
        /* 0x08 */ public List<GcClothPiece> ClothPieces;
        /* 0x18 */ public float ClothScale;
        /* 0x1C */ public float CollisionScale;
        /* 0x20 */ public float AttachmentScale;
    }
}
