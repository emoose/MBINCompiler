using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x450, GUID = 0x352AB6DFBF7B1FD8, NameHash = 0xFD6B0BE30E218605)]
    public class GcSeasonalGameModeData : NMSTemplate
    {
        /* 0x000 */ public int SeasonId;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x004 */ public byte[] Padding4;
        /* 0x008 */ public ulong StartTimeUTC;
        /* 0x010 */ public ulong EndTimeUTC;
        /* 0x018 */ public ulong Hash;
        [NMS(Size = 0x20)]
        /* 0x020 */ public string Title;
        [NMS(Size = 0x20)]
        /* 0x040 */ public string Subtitle;
        [NMS(Size = 0x20)]
        /* 0x060 */ public string Description;
        /* 0x080 */ public GcGameMode GameMode;
        [NMS(Size = 0x20)]
        /* 0x084 */ public string SeasonalUAOverride;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0A4 */ public byte[] PaddingA4;
        /* 0x0A8 */ public ulong UAOverrideValue;
        [NMS(Size = 0x10)]
        /* 0x0B0 */ public string FinalReward;
        [NMS(Size = 0x200)]
        /* 0x0C0 */ public string FinalRewardDescription;
        /* 0x2C0 */ public TkTextureResource MainIcon;
        /* 0x344 */ public int SeasonNumber;
        [NMS(Size = 0x20)]
        /* 0x348 */ public string SeasonName;
        [NMS(Size = 0x20)]
        /* 0x368 */ public string SeasonNameUpper;
        /* 0x388 */ public int StartingSuitSlots;
        /* 0x38C */ public int StartingSuitTechSlots;
        /* 0x390 */ public int StartingSuitCargoSlots;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x394 */ public byte[] Padding394;
        /* 0x398 */ public GcSeed WeaponSeed;
        /* 0x3A8 */ public GcSeed ShipSeed;
        /* 0x3B8 */ public GcSpaceshipClasses ShipType;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3BC */ public byte[] Padding3BC;
        /* 0x3C0 */ public GcInventoryLayout WeaponInventoryLayout;
        /* 0x3E0 */ public GcInventoryLayout ShipInventoryLayout;
        /* 0x400 */ public GcInventoryLayout ShipTechInventoryLayout;
        /* 0x420 */ public bool UseDefaultAppearance;
        /* 0x421 */ public bool StartNextToShip;
        /* 0x424 */ public float DistanceFromShipAtStartOfGame;
        /* 0x428 */ public bool ShipStartsDamaged;
        /* 0x429 */ public bool AllowMissionDetailMessages;
        /* 0x430 */ public List<GcSeasonalStage> Stages;
        /* 0x440 */ public GcScanEventTable ScanEventTable;
    }
}
