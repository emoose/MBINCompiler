using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x21D7432D8569F6A2, NameHash = 0x3BA26D6E)]
    public class GcMissionConditionHasFossilComponent : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcFossilCategory SpecificCategory;
    }
}
