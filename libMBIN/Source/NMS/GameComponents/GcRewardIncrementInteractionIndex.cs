using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBAA21A99B2AADF69, NameHash = 0x317FB72CFB424340)]
    public class GcRewardIncrementInteractionIndex : NMSTemplate
    {
        /* 0x0 */ public GcInteractionType InteractionToIncrement;
        /* 0x4 */ public GcAlienRace Race;
    }
}
