using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB1217E0AC222B4FA, NameHash = 0x10BF023A)]
    public class GcCostRaceItemCombo : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 2)]
        /* 0x10 */ public GcAlienRace AlienRace;
        [NMS(Index = 1)]
        /* 0x14 */ public int Amount;
    }
}
