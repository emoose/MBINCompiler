using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4B614F22F93DD5B8, NameHash = 0x7FCC79CB46AA30F3)]
    public class GcCostRaceItemCombo : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public int Amount;
        /* 0x14 */ public GcAlienRace AlienRace;
    }
}
