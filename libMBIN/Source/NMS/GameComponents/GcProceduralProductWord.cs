using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4BE5EEB51B67AB01, NameHash = 0xB732A8EFDEA74BA)]
    public class GcProceduralProductWord : NMSTemplate
    {
        /* 0x00 */ public GcNameGeneratorWord Word;
        /* 0x28 */ public GcNameGeneratorWord UncommonWord;
        /* 0x50 */ public GcNameGeneratorWord RareWord;
        /* 0x78 */ public NMSString0x20 ReplaceKey;
    }
}
