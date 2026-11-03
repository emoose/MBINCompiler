namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC9CCB583E8CBCF99, NameHash = 0x7CE24504)]
    public class GcAlienPuzzleTableIndex : NMSTemplate
    {
        // size: 0x3
        public enum IndexTypeEnum : uint {
            Regular,
            Seeded,
            Random,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public IndexTypeEnum IndexType;
    }
}
