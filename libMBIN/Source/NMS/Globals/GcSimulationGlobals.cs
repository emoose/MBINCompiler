using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0xBF0, GUID = 0x49EEE64199B4DFF2, NameHash = 0xD1D7201E3228DD7B)]
    public class GcSimulationGlobals : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string StartingSceneFile;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string MultitoolFile;
        /* 0x100 */ public ulong ProceduralBuildingsGenerationSeed;
        [NMS(Size = 0x80)]
        /* 0x108 */ public string SpaceStationFile;
        [NMS(Size = 0x80)]
        /* 0x188 */ public string NexusFile;
        [NMS(Size = 0x80)]
        /* 0x208 */ public string NexusExteriorFile;
        [NMS(Size = 0x80)]
        /* 0x288 */ public string PlaceMarkerFile;
        [NMS(Size = 0x80)]
        /* 0x308 */ public string AbandonedSpaceStationFile;
        /* 0x388 */ public List<NMSString0x80> BlackHoleAnomalies;
        /* 0x398 */ public List<NMSString0x80> AtlasStationAnomalies;
        [NMS(Size = 0x80)]
        /* 0x3A8 */ public string None;
        [NMS(Size = 0x80)]
        /* 0x428 */ public string PlacementDroneFile;
        [NMS(Size = 0x80)]
        /* 0x4A8 */ public string HeavyAirCave;
        [NMS(Size = 0x80)]
        /* 0x528 */ public string HeavyAirUnderwater;
        [NMS(Size = 0x80)]
        /* 0x5A8 */ public string HeavyAirAbandonedFreighter;
        /* 0x628 */ public List<NMSString0x80> PrefetchScenegraphResources;
        /* 0x638 */ public List<NMSString0x80> PrefetchMaterialResources;
        [NMS(Size = 0x80)]
        /* 0x648 */ public string PlanetAtmosphereFile;
        [NMS(Size = 0x80)]
        /* 0x6C8 */ public string PlanetAtmosphereMaterialFile;
        [NMS(Size = 0x80)]
        /* 0x748 */ public string PlanetRingFile;
        [NMS(Size = 0x80)]
        /* 0x7C8 */ public string PlanetRingMaterialFile;
        [NMS(Size = 0x80)]
        /* 0x848 */ public string PlanetMaterialFile;
        [NMS(Size = 0x80)]
        /* 0x8C8 */ public string PlaterWaterMaterialFile;
        /* 0x948 */ public List<NMSString0x80> PlanetTerrainMaterials;
        /* 0x958 */ public List<NMSString0x80> PrefetchTextureResources;
        /* 0x968 */ public float WarpTunnelScale;
        [NMS(Size = 0x80)]
        /* 0x96C */ public string WarpTunnelFile;
        [NMS(Size = 0x80)]
        /* 0x9EC */ public string BlackHoleTunnelFile;
        [NMS(Size = 0x80)]
        /* 0xA6C */ public string TeleportTunnelFile;
        [NMS(Size = 0x80)]
        /* 0xAEC */ public string PortalTunnelFile;
        [NMS(Size = 0x80)]
        /* 0xB6C */ public string PortalStoryTunnelFile;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xBEC */ public byte[] EndPadding;
    }
}
