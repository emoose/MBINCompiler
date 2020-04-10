using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x1F10, GUID = 0x64CF5D726CE7144A)]
    public class GcSimulationGlobals : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x0 */ public string StartingSceneFile;
        [NMS(Size = 0x80)]
        /* 0x80 */ public string MultitoolFile;
        /* 0x100 */ public long ProceduralBuildingsGenerationSeed;
        [NMS(Size = 0x80)]
        /* 0x108 */ public string SpaceStationFile;
        [NMS(Size = 0x80)]
        /* 0x188 */ public string NexusFile;
        [NMS(Size = 0x80)]
        /* 0x208 */ public string NexusInteriorFile;
        [NMS(Size = 0x80)]
        /* 0x288 */ public string PlaceMarkerFile;
        [NMS(Size = 0x80)]
        /* 0x308 */ public string AbandonedSpaceStationFile;
        [NMS(Size = 0x80)]
        /* 0x388 */ public string BlackHoleAnomalies;
        [NMS(Size = 0xC)]
        /* 0x408 */ public NMSString0x80[] AtlasStationAnomalies;
        [NMS(Size = 0x80)]
        /* 0xA08 */ public string None;
        [NMS(Size = 0x80)]
        /* 0xA88 */ public string PlacementDroneFile;
        [NMS(Size = 0x80)]
        /* 0xB08 */ public string HeavyAirCave;
        [NMS(Size = 0x80)]
        /* 0xB88 */ public string HeavyAirUnderwater;
        [NMS(Size = 3)]
        /* 0xC08 */ public NMSString0x80[] PrefetchScenegraphResources;
        [NMS(Size = 2)]
        /* 0xD88 */ public NMSString0x80[] PrefetchMaterialResources;
        [NMS(Size = 0x80)]
        /* 0xE88 */ public string PlanetAtmosphereFile;
        [NMS(Size = 0x80)]
        /* 0xF08 */ public string PlanetAtmosphereMaterialFile;
        [NMS(Size = 0x80)]
        /* 0xF88 */ public string PlanetRingFile;
        [NMS(Size = 0x80)]
        /* 0x1008 */ public string PlanetRingMaterialFile;
        [NMS(Size = 0x80)]
        /* 0x1088 */ public string PlanetMaterialFile;
        [NMS(Size = 0x80)]
        /* 0x1108 */ public string PlaterWaterMaterialFile;
        [NMS(Size = 6)]
        /* 0x1188 */ public NMSString0x80[] PlanetTerrainMaterials;
        [NMS(Size = 0x10)]
        /* 0x1488 */ public NMSString0x80[] PrefetchTextureResources;
        /* 0x1C88 */ public float Unknown0x1C88;
        [NMS(Size = 0x80)]
        /* 0x1C8C */ public string WarpTunnelFile;
        [NMS(Size = 0x80)]
        /* 0x1D0C */ public string BlackHoleTunnelFile;
        [NMS(Size = 0x80)]
        /* 0x1D8C */ public string TeleportTunnelFile;
        [NMS(Size = 0x80)]
        /* 0x1E0C */ public string PortalTunnelFile;
        [NMS(Size = 0x80)]
        /* 0x1E8C */ public string PortalStoryTunnelFile;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
