namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1CE70970224A6067, NameHash = 0xBA9101F9B520DE21)]
    public class GcWonderType : NMSTemplate
    {
        // size: 0x6
        public enum WonderTypeEnum {
            Treasure,
            WeirdBasePart,
            Planet,
            Creature,
            Flora,
            Mineral,
        }
        /* 0x0 */ public WonderTypeEnum WonderType;
    }
}
