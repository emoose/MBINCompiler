using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x218E385DB86CA46F, NameHash = 0x5180E7C9)]
    public class GcSceneSettings : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x000 */ public GcPlayerSpawnStateData PlayerState;
        [NMS(Index = 4, Size = 0x5)]
        /* 0x0E0 */ public GcFilename[] PlanetFiles;
        [NMS(Index = 9)]
        /* 0x130 */ public List<NMSTemplate> Events;
        [NMS(Index = 0)]
        /* 0x140 */ public GcFilename NextSettingFile;
        [NMS(Index = 2)]
        /* 0x150 */ public List<GcFilename> PlanetSceneFiles;
        [NMS(Index = 10)]
        /* 0x160 */ public List<NMSTemplate> PostWarpEvents;
        [NMS(Index = 1)]
        /* 0x170 */ public GcFilename SceneFile;
        [NMS(Index = 5)]
        /* 0x180 */ public List<GcFilename> ShipPreloadFiles;
        [NMS(Index = 3)]
        /* 0x190 */ public GcFilename SolarSystemFile;
        [NMS(Index = 11)]
        /* 0x1A0 */ public NMSString0x10 SpawnerOptionId;
        [NMS(Index = 7)]
        /* 0x1B0 */ public bool SpawnInsideShip;
        [NMS(Index = 6)]
        /* 0x1B1 */ public bool SpawnShip;
    }
}
