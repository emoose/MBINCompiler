using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x54, GUID = 0x7CA1886F47DABEE1, NameHash = 0x44CED54C76C8DDA0)]
    public class GcClothAttachmentLine : NMSTemplate
    {
        /* 0x00 */ public bool Enabled;
        /* 0x01 */ public NMSString0x20 BoneName;
        /* 0x24 */ public float StartX;
        /* 0x28 */ public float StartY;
        /* 0x2C */ public float StartZ;
        /* 0x30 */ public float EndX;
        /* 0x34 */ public float EndY;
        /* 0x38 */ public float EndZ;
        /* 0x3C */ public int NumRowsOfSameJToFix;
        /* 0x40 */ public int RowToFixJ;
        /* 0x44 */ public int NumRowsOfSameIToFix;
        /* 0x48 */ public int RowToFixI;
        /* 0x4C */ public bool Unwrinkle;
        /* 0x50 */ public float LengthScale;
    }
}
