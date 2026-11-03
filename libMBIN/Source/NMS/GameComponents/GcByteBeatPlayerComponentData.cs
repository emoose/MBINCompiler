namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC225435BEA01DCB9, NameHash = 0xBA259D77)]
    public class GcByteBeatPlayerComponentData : NMSTemplate
    {
        // size: 0x2
        public enum ByteBeatPlayerTypeEnum : uint {
            Player,
            Settlement,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ByteBeatPlayerTypeEnum ByteBeatPlayerType;
    }
}
