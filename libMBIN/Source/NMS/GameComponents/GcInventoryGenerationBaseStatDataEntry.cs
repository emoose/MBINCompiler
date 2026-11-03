namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE40C5C6EC6A7FB18, NameHash = 0xA5F21A82)]
    public class GcInventoryGenerationBaseStatDataEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 BaseStatID;
        [NMS(Index = 2)]
        /* 0x10 */ public float Max;
        [NMS(Index = 4)]
        /* 0x14 */ public float MaxFixedAdd;
        [NMS(Index = 1)]
        /* 0x18 */ public float Min;
        [NMS(Index = 3)]
        /* 0x1C */ public float MinFixedAdd;
    }
}
