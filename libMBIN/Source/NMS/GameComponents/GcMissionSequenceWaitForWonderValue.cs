using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x61693F94A8C79D7C, NameHash = 0xCD3C7F9BB940D9EF)]
    public class GcMissionSequenceWaitForWonderValue : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public GcWonderType WonderTypeToUse;
        /* 0x84 */ public GcWonderPlanetCategory PlanetWonderType;
        /* 0x88 */ public GcWonderCreatureCategory CreatureWonderType;
        /* 0x8C */ public GcWonderFloraCategory FloraWonderType;
        /* 0x90 */ public GcWonderMineralCategory MineralWonderType;
        /* 0x94 */ public float Value;
        /* 0x98 */ public int Decimals;
        /* 0x9C */ public bool TakeAmountFromSeasonalData;
        /* 0xA0 */ public TkEqualityEnum Test;
        /* 0xA4 */ public NMSString0x80 DebugText;
    }
}
