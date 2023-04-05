using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x40239FC2C01D82C7, NameHash = 0x458D53EF402BA3C9)]
    public class GcPlanetInfo : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 PlanetDescription;
        /* 0x080 */ public NMSString0x80 PlanetType;
        /* 0x100 */ public NMSString0x80 Weather;
        /* 0x180 */ public NMSString0x80 Resources;
        /* 0x200 */ public NMSString0x80 Flora;
        /* 0x280 */ public NMSString0x80 Fauna;
        [NMS(Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x300 */ public NMSString0x80[] SentinelsPerDifficulty;
        [NMS(Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x500 */ public bool[] SentinelHighlightPerDifficulty;
        /* 0x504 */ public bool IsWeatherExtreme;
    }
}
