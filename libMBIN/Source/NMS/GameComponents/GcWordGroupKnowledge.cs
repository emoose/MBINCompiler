using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x60CD2350D67CE55F, NameHash = 0xE88CB3D4)]
    public class GcWordGroupKnowledge : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Group;
        [NMS(Index = 1, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x20 */ public bool[] Races;
    }
}
