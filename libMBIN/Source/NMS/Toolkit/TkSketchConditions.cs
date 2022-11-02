namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6D210250ED24025C, NameHash = 0x42F1604851DA7F02)]
    public class TkSketchConditions : NMSTemplate
    {
        // size: 0x6
        public enum ConditionEnum {
            Equal,
            NotEqual,
            Greater,
            Less,
            GreaterEqual,
            LessEqual
        }
        /* 0x0 */ public ConditionEnum Condition;
    }
}
