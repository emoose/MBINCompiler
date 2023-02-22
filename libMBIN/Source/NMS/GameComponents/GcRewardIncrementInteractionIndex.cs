using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x27D37C5056DB167A, NameHash = 0x317FB72CFB424340)]
    public class GcRewardIncrementInteractionIndex : NMSTemplate
    {
        /* 0x0 */ public GcInteractionType InteractionToIncrement;
        /* 0x4 */ public GcAlienRace Race;
    }
}
