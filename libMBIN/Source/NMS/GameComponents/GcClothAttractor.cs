using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xA0, GUID = 0x41C48F2B382BA11E, NameHash = 0xDF6FAA4A31B4C454)]
    public class GcClothAttractor : NMSTemplate
    {
        /* 0x00 */ public float AttractionStrength;
        /* 0x04 */ public bool UseInitialShapeAsAttractorShape;
        /* 0x08 */ public float AttractionRadiusAtTop;
        /* 0x0C */ public float AttractionRadiusAtBottom;
        /* 0x10 */ public GcCapeLikeInitialShape CapeLikeAttractorShape;
    }
}
