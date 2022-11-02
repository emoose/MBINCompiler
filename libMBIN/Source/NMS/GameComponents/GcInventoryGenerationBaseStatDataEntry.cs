namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF5F6FC48C8AD3605, NameHash = 0xBE33B4E320477672)]
    public class GcInventoryGenerationBaseStatDataEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 BaseStatID;
        /* 0x10 */ public float Min;
        /* 0x14 */ public float Max;
        /* 0x18 */ public float MinFixedAdd;
        /* 0x1C */ public float MaxFixedAdd;
    }
}
