using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcPlayerStateData : NMSTemplate
    {
        public GcUniverseAddressData UniverseAddress;

        public GcInventoryContainer Inventory;
        public GcInventoryContainer ShipInventory;
        public GcInventoryContainer WeaponInventory;
        public GcInventoryContainer GraveInventory;

        public bool SpawnGrave;
        public bool SpaceGrave;

        public GcUniverseAddressData GraveUniverseAddress;

        public GcInventoryLayout ShipLayout;
        public GcInventoryLayout WeaponLayout;

        public GcResourceElement CurrentShip;

        public GcExactResource CurrentWeapon;

        public List<string> KnownTech;
        public List<string> KnownProducts;

        public List<GcWordKnowledge> KnownWords;

        public List<GcPlayerMissionProgress> MissionProgress;

        public int PostMissionIndex;
        public int Health;
        public int Shield;
        public int Units;
        public int ShipHealth;

        public string TimeAlive;
        public string TotalPlayTime;

        public List<GcScanEventSave> MarkerStack;
        public List<string> CompletedInteractions;

        public List<GcPlayerStatsGroup> Stats;

        [NMS(Size = 7)]
        public GcInteractionBuffer[] StoredInteractions;

        [NMS(Size = 6)]
        public float[] Hazards;

        public int BoltAmmo;
        public int LaserAmmo;
        public int GrenadeAmmo;

        [NMS(Size = 24)]
        public GcSavedInteractionRaceData[] SavedInteractionIndicies;

        public List<GcUniverseAddressData> AtlasStationAdressData;

        public bool FirstAtlasStationDiscovered;

        public int ProgressionLevel;

        public bool IsNew;

        public bool UseSmallerBlackholeJumps;

        public List<GcSavedEntitlement> UsedEntitlements;

        [NMS(Size = 16)]
        public string[] PlanetPositions; // ? not sure about this one

        [NMS(Size = 16)]
        public PlanetSeed[] PlanetSeeds;

        public int PrimaryPlanet;

        public string TimeLastSpaceBattle;
        public int WarpsLastSpaceBattle;
        public string TimeLastMiniStation;
        public int WarpsLastMiniStation;

        public string MiniStationUA;

        public GcUniverseAddressData GameStartAddress1;
        public GcUniverseAddressData GameStartAddress2;

        [NMS(Size = 16)]
        public bool[] GalacticMapRequests;

        public float SavedSunAngle;

        public string HazardTimeAlive;

        public bool RevealBlackHoles;

        [NMS(Size = 11)]
        public GcUniverseAddressData[] NewAtlasStationAdressData;
    }

    public class PlanetSeed : NMSTemplate
    {
        public bool Use_Seed_Value;

        public string Seed;
    }
}
