using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x98FAEC01CF3A50C7, NameHash = 0x8A35BC3F94D0949F)]
    public class GcPunctuationDelayTable : NMSTemplate
    {
        // size: 0x5
        public enum PunctuationDelaysEnum {
            Default,
            Gek,
            Korvax,
            Vykeen,
            FourthRace,
        }
        [NMS(Size = 0x5, EnumType = typeof(PunctuationDelaysEnum))]
        /* 0x0 */ public GcPunctuationDelayData[] PunctuationDelays;
    }
}
