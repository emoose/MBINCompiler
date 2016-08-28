using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcPlayerStateData : NMSTemplate // 0x396E0 bytes
    {
        /* 0x00000 */ public GcUniverseAddressData UniverseAddress;

        /* 0x00018 */ public GcInventoryContainer Inventory;
        /* 0x00038 */ public GcInventoryContainer ShipInventory;
        /* 0x00058 */ public GcInventoryContainer WeaponInventory;
        /* 0x00078 */ public GcInventoryContainer GraveInventory;

        /* 0x00098 */ public bool SpawnGrave;
        /* 0x00099 */ public bool SpaceGrave;
        [NMS(Size = 2, Ignore = true)]
        /* 0x0009A */ public byte[] Padding9A;

        /* 0x0009C */ public GcUniverseAddressData GraveUniverseAddress;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x000B4 */ public byte[] PaddingB4;

        /* 0x000C0 */ public Vector4f GravePosition;
        /* 0x000D0 */ public Vector4f GraveMatrixLookAt;
        /* 0x000E0 */ public Vector4f GraveMatrixUp;

        /* 0x000F0 */ public GcInventoryLayout ShipLayout;
        /* 0x00110 */ public GcInventoryLayout WeaponLayout;

        /* 0x00130 */ public GcResourceElement CurrentShip;

        /* 0x003D8 */ public GcExactResource CurrentWeapon;

        /* 0x00468 */ public List<string> KnownTech;
        /* 0x00478 */ public List<string> KnownProducts;

        /* 0x00488 */ public List<GcWordKnowledge> KnownWords;

        /* 0x00498 */ public List<GcPlayerMissionProgress> MissionProgress;

        /* 0x004A8 */ public int PostMissionIndex;
        /* 0x004AC */ public int Health;
        /* 0x004B0 */ public int Shield;
        /* 0x004B4 */ public int Units;
        /* 0x004B8 */ public int ShipHealth;

        /* 0x004C0 */ public ulong TimeAlive;
        /* 0x004C8 */ public ulong TotalPlayTime;

        /* 0x004D0 */ public List<GcScanEventSave> MarkerStack;
        [NMS(Size = 0x3E8)]
        /* 0x004E0 */ public ulong[] CompletedInteractions;

        /* 0x02420 */ public List<GcPlayerStatsGroup> Stats;

        [NMS(Size = 7)]
        /* 0x02430 */ public GcInteractionBuffer[] StoredInteractions;

        [NMS(Size = 6)]
        /* 0x38FA0 */ public float[] Hazard;

        /* 0x38FB8 */ public int BoltAmmo;
        /* 0x38FBC */ public int LaserAmmo;
        /* 0x38FC0 */ public int GrenadeAmmo;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x38FC4 */ public byte[] Padding38FC4;

        /* 0x38FD0 */ public Vector4f FirstSpawnPosition;

        [NMS(Size = 0x18)]
        /* 0x38FE0 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies; // element size = 6, num elements = 0x18, total size = 0x90, end offset = 0x38FE0 + 0x90 = 0x39070, but next field is 0x39220?

        [NMS(Size = 0xA)]
        /* 0x39220 */ public GcUniverseAddressData[] AtlasStationAdressData;

        /* 0x39310 */ public bool FirstAtlasStationDiscovered;

        /* 0x39314 */ public int ProgressionLevel;

        /* 0x39318 */ public bool IsNew;

        /* 0x39319 */ public bool UseSmallerBlackholeJumps;

        /* 0x39320 */ public List<GcSavedEntitlement> UsedEntitlements;

        [NMS(Size = 0x10)]
        /* 0x39330 */ public Vector4f[] PlanetPositions;

        [NMS(Size = 0x10)]
        /* 0x39430 */ public GcSeed[] PlanetSeeds;

        /* 0x39530 */ public int PrimaryPlanet;
        [NMS(Size = 4, Ignore = true)]
        /* 0x39534 */ public byte[] Padding39534;

        /* 0x39538 */ public ulong TimeLastSpaceBattle; // unsure what type, seems to be 8 bytes
        /* 0x39540 */ public int WarpsLastSpaceBattle;
        [NMS(Size = 4, Ignore = true)]
        /* 0x39544 */ public byte[] Padding39544;

        /* 0x39548 */ public ulong TimeLastMiniStation; // unsure what type, seems to be 8 bytes
        /* 0x39550 */ public int WarpsLastMiniStation;
        [NMS(Size = 4, Ignore = true)]
        /* 0x39554 */ public byte[] Padding39554;

        /* 0x39558 */ public ulong MiniStationUA; // unsure what type, seems to be 8 bytes

        /* 0x39560 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x39578 */ public GcUniverseAddressData GameStartAddress2;

        [NMS(Size = 0x10)]
        /* 0x39590 */ public bool[] GalacticMapRequests;

        /* 0x395A0 */ public float SavedSunAngle;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x395A4 */ public byte[] Padding395A4;

        /* 0x395B0 */ public Vector4f SavedSunAxis;

        /* 0x395C0 */ public ulong HazardTimeAlive; // unsure what type, seems to be 8 bytes

        /* 0x395C8 */ public bool RevealBlackHoles;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x395C9 */ public byte[] Padding395C9;

        [NMS(Size = 0xB)]
        /* 0x395CC */ public GcUniverseAddressData[] NewAtlasStationAdressData;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding396D4;
    }
}
