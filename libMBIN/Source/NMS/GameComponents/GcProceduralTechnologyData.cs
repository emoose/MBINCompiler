using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8DDA5D01792AEF7E, NameHash = 0x6B8472FADE3C492C)]
    public class GcProceduralTechnologyData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 ID;
        /* 0x010 */ public NMSString0x10 Template;
        /* 0x020 */ public NMSString0x20A Group;
        /* 0x040 */ public NMSString0x80 Name;
        /* 0x0C0 */ public NMSString0x80 NameLower;
        /* 0x140 */ public NMSString0x80 Subtitle;
        /* 0x1C0 */ public NMSString0x80 Description;
        /* 0x240 */ public Colour Colour;
        // size: 0x7
        public enum QualityEnum : uint {
            Normal,
            Rare,
            Epic,
            Legendary,
            Illegal,
            Sentinel,
            Robot,
        }
        /* 0x250 */ public QualityEnum Quality;
        /* 0x254 */ public GcProceduralTechnologyCategory Category;
        /* 0x258 */ public int NumStatsMin;
        /* 0x25C */ public int NumStatsMax;
        /* 0x260 */ public GcWeightingCurve WeightingCurve;
        /* 0x270 */ public Colour UpgradeColour;
        /* 0x280 */ public List<GcProceduralTechnologyStatLevel> StatLevels;
    }
}
