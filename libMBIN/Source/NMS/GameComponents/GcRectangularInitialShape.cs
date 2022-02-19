using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, GUID = 0x644AADD53AAD01C1, NameHash = 0xD1F40E0F6517D194)]
    public class GcRectangularInitialShape : NMSTemplate
    {
        /* 0x00 */ public float TopLineStartX;
        /* 0x04 */ public float TopLineStartY;
        /* 0x08 */ public float TopLineStartZ;
        /* 0x0C */ public float TopLineEndX;
        /* 0x10 */ public float TopLineEndY;
        /* 0x14 */ public float TopLineEndZ;
        /* 0x18 */ public float BottomLineStartX;
        /* 0x1C */ public float BottomLineStartY;
        /* 0x20 */ public float BottomLineStartZ;
        /* 0x24 */ public float BottomLineEndX;
        /* 0x28 */ public float BottomLineEndY;
        /* 0x2C */ public float BottomLineEndZ;
    }
}
