using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x60, GUID = 0x04C1187EB004E79D, NameHash = 0xE5DC8328938D3562)]
    public class GcClothAttachmentCirlce : NMSTemplate
    {
        /* 0x00 */ public bool Enabled;
        /* 0x01 */ public NMSString0x20 BoneName;
        /* 0x24 */ public float Radius;
        /* 0x28 */ public float CenterX;
        /* 0x2C */ public float CenterY;
        /* 0x30 */ public float CenterZ;
        /* 0x34 */ public int RightAxisIndex;
        /* 0x38 */ public int ForwardAxisIndex;
        /* 0x3C */ public int ClothDirectionAxis;
        /* 0x40 */ public float StartAngle;
        /* 0x44 */ public float EndAngle;
        /* 0x48 */ public bool WrapIAround;
        /* 0x49 */ public bool WrapJAround;
        /* 0x4C */ public int NumRowsOfSameJToFix;
        /* 0x50 */ public int RowToFixJ;
        /* 0x54 */ public int NumRowsOfSameIToFix;
        /* 0x58 */ public int RowToFixI;
        /* 0x5C */ public bool Unwrinkle;
    }
}
