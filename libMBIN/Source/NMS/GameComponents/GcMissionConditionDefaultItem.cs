using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7972DF469D601F07, NameHash = 0x6F38B975D5E86126)]
    public class GcMissionConditionDefaultItem : NMSTemplate
    {
        /* 0x0 */ public GcDefaultMissionProductEnum ProductType;
        /* 0x4 */ public GcDefaultMissionSubstanceEnum SubstanceType;
        /* 0x8 */ public NMSString0x10 ID;
    }
}
