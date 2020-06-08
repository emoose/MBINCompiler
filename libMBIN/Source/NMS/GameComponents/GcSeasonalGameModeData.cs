using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xE8, GUID = 0x3A6C2A69DD2B7A01, NameHash = 0xFD6B0BE30E218605)]
    public class GcSeasonalGameModeData : NMSTemplate
    {
        /* 0x00 */ public long StartTimeUTC;
        /* 0x08 */ public long EndTimeUTC;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string Title;
        [NMS(Size = 0x20)]
        /* 0x30 */ public string Subtitle;
        [NMS(Size = 0x20)]
        /* 0x50 */ public string Description;
        /* 0x70 */ public GcGameMode GameMode;
        [NMS(Size = 0x20)]
        /* 0x74 */ public string SeasonalUAOverride;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x94 */ public byte[] Padding94;
        /* 0x98 */ public ulong UAOverrideValue;
        /* 0xA0 */ public GcSeed WeaponSeed;
        /* 0xB0 */ public GcSeed ShipSeed;
        /* 0xC0 */ public GcSpaceshipClasses ShipType;
        /* 0xC4 */ public bool StartNextToShip;
        /* 0xC5 */ public bool ShipStartsDamaged;
        /* 0xC6 */ public bool AllowMissionDetailMessages;
        /* 0xC8 */ public List<GcSeasonalMilestone> Milestones;
        /* 0xD8 */ public List<NMSString0x10> SecondaryStats;
    }
}
