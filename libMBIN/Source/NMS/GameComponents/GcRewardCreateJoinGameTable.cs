using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3FDBED0F48C5ABE5, NameHash = 0x3E83209E)]
    public class GcRewardCreateJoinGameTable : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A GameConfigOverride;
        // size: 0x2
        public enum GameTableInteractionTypeEnum : uint {
            Create,
            Join,
        }
        [NMS(Index = 0)]
        /* 0x20 */ public GameTableInteractionTypeEnum GameTableInteractionType;
        [NMS(Index = 1)]
        /* 0x24 */ public GcGameTableMode Mode;
    }
}
