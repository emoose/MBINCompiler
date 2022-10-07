namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFC036F35930AC621, NameHash = 0x83E66770853FCA27)]
    public class GcAlienPuzzleTableIndex : NMSTemplate
    {
        // size: 0x3
        public enum IndexTypeEnum {
            Regular,
            Seeded,
            Random
        }
        /* 0x0 */ public IndexTypeEnum IndexType;
    }
}
