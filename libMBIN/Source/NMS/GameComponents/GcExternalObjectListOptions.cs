using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEFAA1C87F6DC6350, NameHash = 0x8CB0F581)]
    public class GcExternalObjectListOptions : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Name;
        [NMS(Index = 9)]
        /* 0x10 */ public List<GcFilename> Options;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 ResourceHint;
        [NMS(Index = 2)]
        /* 0x30 */ public NMSString0x10 ResourceHintIcon;
        [NMS(Index = 10)]
        /* 0x40 */ public int Order;
        [NMS(Index = 3)]
        /* 0x44 */ public float Probability;
        [NMS(Index = 4)]
        /* 0x48 */ public float SeasonalProbabilityOverride;
        [NMS(Index = 5)]
        /* 0x4C */ public GcTerrainTileType TileType;
        [NMS(Index = 7)]
        /* 0x50 */ public bool AddToFilenameHashmapWhenOptional;
        [NMS(Index = 6)]
        /* 0x51 */ public bool AllowLimiting;
        [NMS(Index = 8)]
        /* 0x52 */ public bool ChooseUsingLifeLevel;
        [NMS(Index = 11)]
        /* 0x53 */ public bool SuppressSpawn;
    }
}
