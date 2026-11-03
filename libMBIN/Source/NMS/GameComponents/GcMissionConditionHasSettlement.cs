using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2846F5F8D6B706C1, NameHash = 0x8C53F231)]
    public class GcMissionConditionHasSettlement : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcAlienRace SpecificAlienRace;
    }
}
