using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0xB80, GUID = 0x061B9FE2DCCC1BA4, NameHash = 0xD1D7201E3228DD7B)]
    public class GcSimulationGlobals : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 StartingSceneFile;
        /* 0x080 */ public List<GcMultitoolPoolData> MultitoolPool;
        /* 0x090 */ public ulong ProceduralBuildingsGenerationSeed;
        /* 0x098 */ public NMSString0x80 SpaceStationFile;
        /* 0x118 */ public NMSString0x80 NexusFile;
        /* 0x198 */ public NMSString0x80 NexusExteriorFile;
        /* 0x218 */ public NMSString0x80 PlaceMarkerFile;
        /* 0x298 */ public NMSString0x80 AbandonedSpaceStationFile;
        /* 0x318 */ public List<NMSString0x80> BlackHoleAnomalies;
        /* 0x328 */ public List<NMSString0x80> AtlasStationAnomalies;
        /* 0x338 */ public NMSString0x80 None;
        /* 0x3B8 */ public NMSString0x80 PlacementDroneFile;
        /* 0x438 */ public NMSString0x80 HeavyAirCave;
        /* 0x4B8 */ public NMSString0x80 HeavyAirUnderwater;
        /* 0x538 */ public NMSString0x80 HeavyAirAbandonedFreighter;
        /* 0x5B8 */ public List<NMSString0x80> PrefetchScenegraphResources;
        /* 0x5C8 */ public List<NMSString0x80> PrefetchMaterialResources;
        /* 0x5D8 */ public NMSString0x80 PlanetAtmosphereFile;
        /* 0x658 */ public NMSString0x80 PlanetAtmosphereMaterialFile;
        /* 0x6D8 */ public NMSString0x80 PlanetRingFile;
        /* 0x758 */ public NMSString0x80 PlanetRingMaterialFile;
        /* 0x7D8 */ public NMSString0x80 PlanetMaterialFile;
        /* 0x858 */ public NMSString0x80 PlaterWaterMaterialFile;
        /* 0x8D8 */ public List<NMSString0x80> PlanetTerrainMaterials;
        /* 0x8E8 */ public List<NMSString0x80> PrefetchTextureResources;
        /* 0x8F8 */ public float WarpTunnelScale;
        /* 0x8FC */ public NMSString0x80 WarpTunnelFile;
        /* 0x97C */ public NMSString0x80 BlackHoleTunnelFile;
        /* 0x9FC */ public NMSString0x80 TeleportTunnelFile;
        /* 0xA7C */ public NMSString0x80 PortalTunnelFile;
        /* 0xAFC */ public NMSString0x80 PortalStoryTunnelFile;
    }
}
