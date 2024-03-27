namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAAF0F26B8FB365A8, NameHash = 0x16AA46E72671EDE7)]
    public class GcBlackboardIntModifyData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Key;
        /* 0x10 */ public int Value;
        // size: 0x2
        public enum ModifyIntTypeEnum : uint {
            SetValue,
            IncrementValue,
        }
        /* 0x14 */ public ModifyIntTypeEnum ModifyIntType;
    }
}
