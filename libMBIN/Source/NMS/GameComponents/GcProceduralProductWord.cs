using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB13C7CCE85229113, NameHash = 0xD43CE876)]
    public class GcProceduralProductWord : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcNameGeneratorWord RareWord;
        [NMS(Index = 1)]
        /* 0x28 */ public GcNameGeneratorWord UncommonWord;
        [NMS(Index = 0)]
        /* 0x50 */ public GcNameGeneratorWord Word;
        [NMS(Index = 3)]
        /* 0x78 */ public NMSString0x20 ReplaceKey;
    }
}
