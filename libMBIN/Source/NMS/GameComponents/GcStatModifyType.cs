namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF59EB8E8977288BF, NameHash = 0xA2CE4FB30A13249B)]
    public class GcStatModifyType : NMSTemplate
    {
        // size: 0x3
        public enum ModifyTypeEnum {
            Set,
            Add,
            Subtract
        }
        /* 0x0 */ public ModifyTypeEnum ModifyType;
    }
}
