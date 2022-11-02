using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAA14F7D09A9FEDB5, NameHash = 0xF75874C269CFFEA3)]
    public class GcSceneSettings : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 NextSettingFile;
        /* 0x080 */ public NMSString0x80 SceneFile;
        /* 0x100 */ public List<NMSString0x80> PlanetSceneFiles;
        /* 0x110 */ public NMSString0x80 SolarSystemFile;
        [NMS(Size = 0x5)]
        /* 0x190 */ public NMSString0x80[] PlanetFiles;
        /* 0x410 */ public List<NMSString0x80> ShipPreloadFiles;
        /* 0x420 */ public bool SpawnShip;
        /* 0x421 */ public bool SpawnInsideShip;
        /* 0x430 */ public GcPlayerSpawnStateData PlayerState;
        /* 0x500 */ public List<NMSTemplate> Events;
        /* 0x510 */ public List<NMSTemplate> PostWarpEvents;
        /* 0x520 */ public NMSString0x10 SpawnerOptionId;
    }
}
