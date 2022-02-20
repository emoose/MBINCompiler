using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x14, GUID = 0xFBCD29DD6A052E9F, NameHash = 0xF41CD566C844982A)]
    public class GcProceduralTechnologyStatLevel : NMSTemplate
    {
        /* 0x00 */ public GcStatsTypes Stat;
        /* 0x04 */ public float ValueMin;
        /* 0x08 */ public float ValueMax;
        /* 0x0C */ public GcWeightingCurve WeightingCurve;
        /* 0x10 */ public bool AlwaysChoose;
    }
}
