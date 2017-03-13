using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcPlayerStateData : NMSTemplate        // size: 0x3DA00
    {
        /* 0x00000 */ public GcUniverseAddressData UniverseAddress;

        /* 0x00018 */ public GcInventoryContainer Inventory;
        /* 0x00078 */ public GcInventoryContainer ShipInventory;
        /* 0x000D8 */ public GcInventoryContainer WeaponInventory;
        /* 0x00138 */ public GcInventoryContainer GraveInventory;

        /* 0x00198 */ public bool SpawnGrave;
        /* 0x00199 */ public bool SpaceGrave;
        [NMS(Size = 2, Ignore = true)]
        /* 0x0019A */ public byte[] Padding19A;

        /* 0x0019C */ public GcUniverseAddressData GraveUniverseAddress;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x001B4 */ public byte[] Padding1B4;

        /* 0x001C0 */ public Vector4f GravePosition;
        /* 0x001D0 */ public Vector4f GraveMatrixLookAt;
        /* 0x001E0 */ public Vector4f GraveMatrixUp;

        /* 0x001F0 */ public GcInventoryLayout ShipLayout;
        /* 0x00210 */ public GcInventoryLayout WeaponLayout;

        /* 0x00230 */ public GcResourceElement CurrentShip;

        /* 0x004D8 */ public GcExactResource CurrentWeapon;

        /* 0x00568 */ public List<NMSString0x10> KnownTech;
        /* 0x00578 */ public List<NMSString0x10> KnownProducts;

        /* 0x00588 */ public List<GcWordKnowledge> KnownWords;

        /* 0x00598 */ public List<GcPlayerMissionProgress> MissionProgress;

        /* 0x005A8 */ public int PostMissionIndex;
        /* 0x005AC */ public int Health;
		/* 0x005B0 */ public int ShipHealth;
        /* 0x005B4 */ public int Shield;
		/* 0x005B8 */ public int ShipShield;
		/* 0x005BC */ public int Energy;
        /* 0x005C0 */ public int Units;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x005C4 */ public byte[] Padding5C4;

        /* 0x005C8 */ public ulong TimeAlive;
        /* 0x005D0 */ public ulong TotalPlayTime;

        /* 0x005D8 */ public List<GcScanEventSave> MarkerStack;
        [NMS(Size = 0x3E8)]
        /* 0x005E8 */ public ulong[] CompletedInteractions;

        /* 0x02528 */ public List<GcPlayerStatsGroup> Stats;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x02538 */ public byte[] Padding2538;

        [NMS(Size = 7)]
        /* 0x02540 */ public GcInteractionBuffer[] StoredInteractions;

        [NMS(Size = 6)]
        /* 0x390B0 */ public float[] Hazard;

        /* 0x390C8 */ public int BoltAmmo;
        /* 0x390CC */ public int LaserAmmo;
        /* 0x390D0 */ public int GrenadeAmmo;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x390D4 */ public byte[] Padding38FD4;

        /* 0x390E0 */ public Vector4f FirstSpawnPosition;

        [NMS(Size = 0x2F)]
        /* 0x390F0 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;

        [NMS(Size = 0xA)]
        /* 0x39614 */ public GcUniverseAddressData[] AtlasStationAdressData;

        /* 0x39704 */ public bool FirstAtlasStationDiscovered;

        /* 0x39708 */ public int ProgressionLevel;

        /* 0x3970C */ public bool IsNew;

        /* 0x3970D */ public bool UseSmallerBlackholeJumps;

        //[NMS(Size = 0x6, Ignore = true)]
        ///* 0x3970E */ public byte[] Padding3970E;

        /* 0x39710 */ public List<GcSavedEntitlement> UsedEntitlements;

        [NMS(Size = 0x10)]
        /* 0x39720 */ public Vector4f[] PlanetPositions;

        [NMS(Size = 0x10)]
        /* 0x39820 */ public GcSeed[] PlanetSeeds;

        /* 0x39920 */ public int PrimaryPlanet;
        [NMS(Size = 4, Ignore = true)]
        /* 0x39924 */ public byte[] Padding39924;

        /* 0x39928 */ public ulong TimeLastSpaceBattle;
        /* 0x39930 */ public int WarpsLastSpaceBattle;
        [NMS(Size = 4, Ignore = true)]
        /* 0x39934 */ public byte[] Padding39934;

        /* 0x39938 */ public ulong TimeLastMiniStation;
        /* 0x39940 */ public int WarpsLastMiniStation;
        [NMS(Size = 4, Ignore = true)]
        /* 0x39944 */ public byte[] Padding39944;

        /* 0x39948 */ public ulong MiniStationUA;

        /* 0x39950 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x39968 */ public GcUniverseAddressData GameStartAddress2;

        [NMS(Size = 0x10)]
        /* 0x39980 */ public bool[] GalacticMapRequests;

        /* 0x39990 */ public Vector4f FirstShipPosition;

        /* 0x399A0 */ public float SavedSunAngle;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x399A4 */ public byte[] Padding399A4;

        /* 0x399B0 */ public Vector4f SavedSunAxis;

        /* 0x399C0 */ public ulong HazardTimeAlive;

        /* 0x399C8 */ public bool RevealBlackHoles;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x399C9 */ public byte[] Padding399C9;

        [NMS(Size = 0xB)]
        /* 0x399CC */ public GcUniverseAddressData[] NewAtlasStationAdressData;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x39AD4 */ public byte[] Padding39AD4;

        /* 0x39AD8 */ public GcResourceElement CurrentFreighter;
        /* 0x39D80 */ public GcInventoryLayout FreighterLayout;
        /* 0x39DA0 */ public GcInventoryContainer FreighterInventory;
        /* 0x39E00 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x39E18 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        [NMS(Size = 0x5)]
        /* 0x39E28 */ public GcNPCWorkerData[] NPCWorkers;
        [NMS(Size = 0x3)]
        /* 0x3ABC0 */ public GcPersistentBase[] PersistentPlayerBases;
        /* 0x3B070 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        [NMS(Size = 0x2F)]
        /* 0x3B080 */ public ulong[] SavedInteractionTimes;

        // I am just going to forget about fixing the offsets here... too much effort... The correct offsets will continue afterwards...

        /* 0x3B1F8 */ public GcInventoryLayout Chest1Layout;
        /* 0x3B218 */ public GcInventoryContainer Chest1Inventory;
        /* 0x3AC60 */ public GcInventoryLayout Chest2Layout;
        /* 0x3AC80 */ public GcInventoryContainer Chest2Inventory;
        /* 0x3ACA0 */ public GcInventoryLayout Chest3Layout;
        /* 0x3ACC0 */ public GcInventoryContainer Chest3Inventory;
        /* 0x3ACE0 */ public GcInventoryLayout Chest4Layout;
        /* 0x3AD00 */ public GcInventoryContainer Chest4Inventory;
        /* 0x3AD20 */ public GcInventoryLayout Chest5Layout;
        /* 0x3AD40 */ public GcInventoryContainer Chest5Inventory;
        /* 0x3AD60 */ public GcInventoryLayout Chest6Layout;
        /* 0x3AD80 */ public GcInventoryContainer Chest6Inventory;
        /* 0x3ADA0 */ public GcInventoryLayout Chest7Layout;
        /* 0x3ADC0 */ public GcInventoryContainer Chest7Inventory;
        /* 0x3ADE0 */ public GcInventoryLayout Chest8Layout;
        /* 0x3AE00 */ public GcInventoryContainer Chest8Inventory;
        /* 0x3AE20 */ public GcInventoryLayout Chest9Layout;
        /* 0x3AE40 */ public GcInventoryContainer Chest9Inventory;
        /* 0x3AE60 */ public GcInventoryLayout Chest10Layout;
        /* 0x3AE80 */ public GcInventoryContainer Chest10Inventory;
        /* 0x3AEA0 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x3AEC0 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x3AEE0 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x3AF00 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x3B7F8 */ public GcResourceElement CurrentFreighterNPC;

        [NMS(Size = 0x3)]
        /* 0x3BAA0 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x3C4F0 */ public int PrimaryVehicle;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x3C4F4 */ public byte[] Padding3C4F4;
        [NMS(Size = 0x6)]
        /* 0x3C500 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x3D9A0 */ public int PrimaryShip;

        /* 0x3D9A4 */ public bool MultiShipEnabled;
        [NMS(Size = 0x20)]
        /* 0x3D9A5 */ public string PlayerWeaponName;
        [NMS(Size = 0x20)]
        /* 0x3D9C5 */ public string PlayerFreighterName;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x3D9E5 */ public byte[] Padding3D9E5;
        /* 0x3D9F0 */ public Vector4f StartGameShipPosition;

    }
}
