using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcBiomeData : NMSTemplate
    {
        public GcMiningSubstanceData MiningSubstance1;
        public GcMiningSubstanceData MiningSubstance2;
        public GcMiningSubstanceData MiningSubstance3;
        public GcMiningSubstanceData MiningSubstance4;
        public GcPlanetWaterData Water;

        [NMS(Size = 0x80)]
        public string DiffuseMap;
        [NMS(Size = 0x80)]
        public string NormalMap;

        [NMS(Size = 10)]
        public GcTileTypeOptions[] TileTypes;

        public List<GcExternalObjectListOptions> ExternalObjectLists;

        [NMS(Size = 7, EnumValue = new string[7] { "Clear", "Dust", "Humid", "Snow", "Toxic", "Scorched", "Radioactive" } )]
        public NMSBool[] WeatherOptions;

        public GcTerrainControls Terrain;

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding408;
    }
}
