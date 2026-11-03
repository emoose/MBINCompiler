namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x61A4702AF6AB0731, NameHash = 0xB8BEDD3C)]
    public class GcBlackboardIntModifyData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Key;
        // size: 0x2
        public enum ModifyIntTypeEnum : uint {
            SetValue,
            IncrementValue,
        }
        [NMS(Index = 2)]
        /* 0x10 */ public ModifyIntTypeEnum ModifyIntType;
        [NMS(Index = 1)]
        /* 0x14 */ public int Value;
    }
}
