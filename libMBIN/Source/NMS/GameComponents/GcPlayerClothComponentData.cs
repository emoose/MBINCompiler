using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x71B286D4EF3F176D, NameHash = 0x7095201046A71EFE)]
    public class GcPlayerClothComponentData : NMSTemplate
    {
        /* 0x0 */ public bool Enabled;
        /* 0x4 */ public int NumConstraintSolvingIterations;
        /* 0x8 */ public List<GcClothPiece> ClothPieces;
    }
}
