using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcBiomeData : NMSTemplate      // size: 0x400
    {
        /* 0x000 */ public GcMiningSubstanceData MiningSubstance1;
        /* 0x00C */ public GcMiningSubstanceData MiningSubstance2;
        /* 0x018 */ public GcMiningSubstanceData MiningSubstance3;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x024 */ public byte[] Padding24;
        /* 0x030 */ public GcPlanetWaterData Water;

        [NMS(Size = 0x80)]
        /* 0x1E0 */ public string DiffuseMap;
        [NMS(Size = 0x80)]
        /* 0x260 */ public string NormalMap;
        [NMS(Size = 0x80)]
        /* 0x02E0 */ public string OverlayTexture;

        /* 0x360 */ public List<GcTileTypeSet> TileTypeSets;         // something 0x64 long...

        /* 0x370 */ public List<GcExternalObjectListOptions> ExternalObjectLists;

        [NMS(Size = 7, EnumValue = new string[7] { "Clear", "Dust", "Humid", "Snow", "Toxic", "Scorched", "Radioactive" } )]
        /* 0x380 */ public bool[] WeatherOptions;

        /* 0x388 */ public GcTerrainControls Terrain;

        [NMS(Size = 8, Ignore = true)]
        /* 0x3F8 */ public byte[] Padding3F8;
    }
}
