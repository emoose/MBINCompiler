using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBDC5F5A956887BFF, NameHash = 0x724191EA)]
    public class GcWFCDecorationItem : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x000 */ public List<NMSString0x10> ApplicableModules;
        [NMS(Index = 1)]
        /* 0x010 */ public NMSString0x10 Group;
        [NMS(Index = 0)]
        /* 0x020 */ public NMSString0x10 Name;
        [NMS(Index = 6)]
        /* 0x030 */ public List<GcWeightedResource> Scenes;
        [NMS(Index = 18)]
        /* 0x040 */ public GcWFCDecorationFace Back;
        [NMS(Index = 17)]
        /* 0x0C4 */ public GcWFCDecorationFace Down;
        [NMS(Index = 21)]
        /* 0x148 */ public GcWFCDecorationFace Forward;
        [NMS(Index = 16)]
        /* 0x1CC */ public GcWFCDecorationFace Left;
        [NMS(Index = 19)]
        /* 0x250 */ public GcWFCDecorationFace Right;
        [NMS(Index = 20)]
        /* 0x2D4 */ public GcWFCDecorationFace Up;
        // size: 0x3
        public enum InsideOutsideEnum : uint {
            Both,
            InteriorOnly,
            ExteriorOnly,
        }
        [NMS(Index = 14)]
        /* 0x358 */ public InsideOutsideEnum InsideOutside;
        // size: 0x3
        public enum LevelEnum : uint {
            Everywhere,
            GroundLevelOnly,
            AboveGroundOnly,
        }
        [NMS(Index = 15)]
        /* 0x35C */ public LevelEnum Level;
        [NMS(Index = 10)]
        /* 0x360 */ public int MaxPerBuilding;
        [NMS(Index = 11)]
        /* 0x364 */ public int MinPerBuilding;
        [NMS(Index = 3, MxmlName = "No Scene Probability")]
        /* 0x368 */ public float NoSceneProbability;
        [NMS(Index = 2, MxmlName = "Relative Probability")]
        /* 0x36C */ public float RelativeProbability;
        [NMS(Index = 5, Size = 0x5, EnumType = typeof(GcWFCDecorationTheme.WFCDecorationThemeEnum))]
        /* 0x370 */ public bool[] DecorationThemes;
        [NMS(Index = 4)]
        /* 0x375 */ public bool Include;
        [NMS(Index = 13)]
        /* 0x376 */ public bool IsRoof;
        [NMS(Index = 12)]
        /* 0x377 */ public bool RequireAboveTerrain;
        [NMS(Index = 9)]
        /* 0x378 */ public bool RequireReachable;
        [NMS(Index = 8)]
        /* 0x379 */ public bool Rotate;
    }
}
