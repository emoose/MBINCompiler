using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2255269E4D31976E, NameHash = 0x3EF3FDEF)]
    public class GcPetBattlerPayloadApplyPayloadData : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public NMSString0x20A ChatMessageOnTrigger;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSTemplate Payload;
        // size: 0x2
        public enum ApplyConditionEnum : uint {
            ApplyOnExpire,
            ApplyOnDispel,
        }
        [NMS(Index = 4)]
        /* 0x30 */ public ApplyConditionEnum ApplyCondition;
        [NMS(Index = 3)]
        /* 0x34 */ public int Delay;
        [NMS(Index = 1)]
        /* 0x38 */ public GcPetBattlerMoveEffect Effect;
        [NMS(Index = 5)]
        /* 0x3C */ public float ScoreMultiplier;
        [NMS(Index = 0)]
        /* 0x40 */ public GcPetBattlerTarget Target;
    }
}
