using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0xB80, GUID = 0x49EEE64199B4DFF2)]
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
        /* 0x0318 */ public List<NMSString0x80> BlackHoleAnomalies;
        /* 0x0328 */ public List<NMSString0x80> AtlasStationAnomalies;
        [NMS(Size = 0x80)]
        /* 0x0338 */ public string None;
        [NMS(Size = 0x80)]
        /* 0x03B8 */ public string PlacementDroneFile;
        [NMS(Size = 0x80)]
        /* 0x0438 */ public string HeavyAirCave;
        [NMS(Size = 0x80)]
        /* 0x04B8 */ public string HeavyAirUnderwater;
        [NMS(Size = 0x80)]
        /* 0x0538 */ public string HeavyAirAbandonedFreighter;
        /* 0x05B8 */ public List<NMSString0x80> PrefetchScenegraphResources;
        /* 0x05C8 */ public List<NMSString0x80> PrefetchMaterialResources;
        [NMS(Size = 0x80)]
        /* 0x05D8 */ public string PlanetAtmosphereFile;
        [NMS(Size = 0x80)]
        /* 0x0658 */ public string PlanetAtmosphereMaterialFile;
        [NMS(Size = 0x80)]
        /* 0x06D8 */ public string PlanetRingFile;
        [NMS(Size = 0x80)]
        /* 0x0758 */ public string PlanetRingMaterialFile;
        [NMS(Size = 0x80)]
        /* 0x07D8 */ public string PlanetMaterialFile;
        [NMS(Size = 0x80)]
        /* 0x0858 */ public string PlaterWaterMaterialFile;
        /* 0x08D8 */ public List<NMSString0x80> PlanetTerrainMaterials;
        /* 0x08E8 */ public List<NMSString0x80> PrefetchTextureResources;
        /* 0x08F8 */ public float WarpTunnelScale;
        [NMS(Size = 0x80)]
        /* 0x08FC */ public string WarpTunnelFile;
        [NMS(Size = 0x80)]
        /* 0x097C */ public string BlackHoleTunnelFile;
        [NMS(Size = 0x80)]
        /* 0x09FC */ public string TeleportTunnelFile;
        [NMS(Size = 0x80)]
        /* 0x0A7C */ public string PortalTunnelFile;
        [NMS(Size = 0x80)]
        /* 0x0AFC */ public string PortalStoryTunnelFile;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0B7C */ public byte[] EndPadding;
    }
}
