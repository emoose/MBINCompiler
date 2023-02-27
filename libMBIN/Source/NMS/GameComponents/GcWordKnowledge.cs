using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x83B984F88079F831, NameHash = 0x30324FBB2A97B16E)]
    public class GcWordKnowledge : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Word;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x10 */ public bool[] Races;
    }
}
