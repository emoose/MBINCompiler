using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x768DB232C55E105A, NameHash = 0xA2483F68)]
    public class GcMissionSequenceCreateSpecificPulseEncounter : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public NMSString0x20A ShipHUDOverrideWhenReady;
        [NMS(Index = 15)]
        /* 0x20 */ public VariableSizeString DebugText;
        [NMS(Index = 14)]
        /* 0x30 */ public List<NMSString0x10> ExtraEncounterIDs;
        [NMS(Index = 0)]
        /* 0x40 */ public VariableSizeString Message;
        [NMS(Index = 4)]
        /* 0x50 */ public VariableSizeString MessageEncounterReady;
        [NMS(Index = 1)]
        /* 0x60 */ public VariableSizeString MessageNoShip;
        [NMS(Index = 2)]
        /* 0x70 */ public VariableSizeString MessageNotPulsing;
        [NMS(Index = 3)]
        /* 0x80 */ public VariableSizeString MessageSignalBlocked;
        [NMS(Index = 7)]
        /* 0x90 */ public NMSString0x10 PulseEncounterID;
        [NMS(Index = 6)]
        /* 0xA0 */ public float MinTimeInPulse;
        [NMS(Index = 9)]
        /* 0xA4 */ public bool AllowAnyEncounter;
        [NMS(Index = 12)]
        /* 0xA5 */ public bool AllowAnywhere;
        [NMS(Index = 11)]
        /* 0xA6 */ public bool AllowOutsideShipInSpace;
        [NMS(Index = 13)]
        /* 0xA7 */ public bool EnsureClearOfSolarSystemObjects;
        [NMS(Index = 10)]
        /* 0xA8 */ public bool Silent;
        [NMS(Index = 8)]
        /* 0xA9 */ public bool TakeEncounterIDFromSeasonData;
    }
}
