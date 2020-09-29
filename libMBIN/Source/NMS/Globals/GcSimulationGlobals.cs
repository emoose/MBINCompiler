using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x1F90, GUID = 0x49EEE64199B4DFF2)]
    public class GcSimulationGlobals : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x0000 */ public string StartingSceneFile;
        [NMS(Size = 0x80)]
        /* 0x0080 */ public string MultitoolFile;
        /* 0x0100 */ public ulong ProceduralBuildingsGenerationSeed;
        [NMS(Size = 0x80)]
        /* 0x0108 */ public string SpaceStationFile;
        [NMS(Size = 0x80)]
        /* 0x0188 */ public string NexusFile;
        [NMS(Size = 0x80)]
        /* 0x0208 */ public string NexusExteriorFile;
        [NMS(Size = 0x80)]
        /* 0x0288 */ public string PlaceMarkerFile;
        [NMS(Size = 0x80)]
        /* 0x0308 */ public string AbandonedSpaceStationFile;
        [NMS(Size = 0x1)]
        /* 0x0388 */ public NMSString0x80[] BlackHoleAnomalies;
        [NMS(Size = 0xC)]
        /* 0x0408 */ public NMSString0x80[] AtlasStationAnomalies;
        [NMS(Size = 0x80)]
        /* 0x0A08 */ public string None;
        [NMS(Size = 0x80)]
        /* 0x0A88 */ public string PlacementDroneFile;
        [NMS(Size = 0x80)]
        /* 0x0B08 */ public string HeavyAirCave;
        [NMS(Size = 0x80)]
        /* 0x0B88 */ public string HeavyAirUnderwater;
        [NMS(Size = 0x80)]
        /* 0x0C08 */ public string HeavyAirAbandonedFreighter;
        [NMS(Size = 0x3)]
        /* 0x0C88 */ public NMSString0x80[] PrefetchScenegraphResources;
        [NMS(Size = 0x2)]
        /* 0x0E08 */ public NMSString0x80[] PrefetchMaterialResources;
        [NMS(Size = 0x80)]
        /* 0x0F08 */ public string PlanetAtmosphereFile;
        [NMS(Size = 0x80)]
        /* 0x0F88 */ public string PlanetAtmosphereMaterialFile;
        [NMS(Size = 0x80)]
        /* 0x1008 */ public string PlanetRingFile;
        [NMS(Size = 0x80)]
        /* 0x1088 */ public string PlanetRingMaterialFile;
        [NMS(Size = 0x80)]
        /* 0x1108 */ public string PlanetMaterialFile;
        [NMS(Size = 0x80)]
        /* 0x1188 */ public string PlaterWaterMaterialFile;
        [NMS(Size = 0x6)]
        /* 0x1208 */ public NMSString0x80[] PlanetTerrainMaterials;
        [NMS(Size = 0x10)]
        /* 0x1508 */ public NMSString0x80[] PrefetchTextureResources;
        /* 0x1D08 */ public float WarpTunnelScale;
        [NMS(Size = 0x80)]
        /* 0x1D0C */ public string WarpTunnelFile;
        [NMS(Size = 0x80)]
        /* 0x1D8C */ public string BlackHoleTunnelFile;
        [NMS(Size = 0x80)]
        /* 0x1E0C */ public string TeleportTunnelFile;
        [NMS(Size = 0x80)]
        /* 0x1E8C */ public string PortalTunnelFile;
        [NMS(Size = 0x80)]
        /* 0x1F0C */ public string PortalStoryTunnelFile;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1F8C */ public byte[] EndPadding;
    }
}
