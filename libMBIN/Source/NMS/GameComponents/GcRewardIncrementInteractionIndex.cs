using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD49444EE54DA9B1, NameHash = 0x317FB72CFB424340)]
    public class GcRewardIncrementInteractionIndex : NMSTemplate
    {
        /* 0x0 */ public GcInteractionType InteractionToIncrement;
        /* 0x4 */ public GcAlienRace Race;
    }
}
