namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC525AE2F8309FBD0, NameHash = 0x7DC88F68)]
    public class GcStatModifyType : NMSTemplate
    {
        // size: 0x3
        public enum ModifyTypeEnum : uint {
            Set,
            Add,
            Subtract,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ModifyTypeEnum ModifyType;
    }
}
