using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x733243E5EBAAE07F, NameHash = 0x11ED2FD0)]
    public class GcGameTableAIPlayerConfig : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Id;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSTemplate GameConfig;
        [NMS(Index = 1)]
        /* 0x30 */ public GcGameTableAIDifficulty Difficulty;
    }
}
