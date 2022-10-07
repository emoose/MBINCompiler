namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE7B910E9C497C58E, NameHash = 0xDF9F37F8504FFE4D)]
    public class GcCameraAmbientBuildingData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Animation;
        /* 0x10 */ public NMSString0x10 DroneAnimation;
        /* 0x20 */ public float Offset;
        /* 0x24 */ public bool UseLookAt;
        /* 0x25 */ public bool AvoidTerrain;
        // size: 0x34
        public enum AvailableBuildingsEnum {
            None,
            TerrainResource,
            Shelter,
            Abandoned,
            Terminal,
            Shop,
            Outpost,
            Waypoint,
            Beacon,
            RadioTower,
            Observatory,
            Depot,
            Factory,
            Harvester,
            Plaque,
            Monolith,
            Portal,
            Ruin,
            Debris,
            DamagedMachine,
            DistressSignal,
            LandingPad,
            Base,
            MissionTower,
            CrashedFreighter,
            GraveInCave,
            StoryGlitch,
            TreasureRuins,
            GameStartSpawn,
            WaterCrashedFreighter,
            WaterTreasureRuins,
            WaterAbandoned,
            WaterDistressSignal,
            NPCDistressSignal,
            NPCDebris,
            LargeBuilding,
            Settlement_Hub,
            Settlement_LandingZone,
            Settlement_Bar,
            Settlement_Tower,
            Settlement_Market,
            Settlement_Small,
            Settlement_SmallIndustrial,
            Settlement_Medium,
            Settlement_Large,
            Settlement_Monument,
            Settlement_SheriffsOffice,
            Settlement_Double,
            Settlement_Farm,
            Settlement_Factory,
            Settlement_Clump,
            DroneHive
        }
        [NMS(Size = 0x34, EnumType = typeof(AvailableBuildingsEnum))]
        /* 0x26 */ public bool[] AvailableBuildings;
        // size: 0x8
        public enum AvailableRacesEnum {
            Traders,
            Warriors,
            Explorers,
            Robots,
            Atlas,
            Diplomats,
            Exotics,
            None
        }
        [NMS(Size = 0x8, EnumType = typeof(AvailableRacesEnum))]
        /* 0x5A */ public bool[] AvailableRaces;
    }
}
