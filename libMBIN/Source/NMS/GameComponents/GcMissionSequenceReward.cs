namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x202C3B247BBD701F, NameHash = 0x7471FD77815538C2)]
    public class GcMissionSequenceReward : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public NMSString0x10 Reward;
        /* 0x90 */ public bool DoMissionBoardOverride;
        /* 0x91 */ public bool Silent;
        // size: 0x5
        public enum RewardInventoryOverrideEnum {
            None,
            Suit,
            Ship,
            Vehicle,
            Freighter
        }
        /* 0x94 */ public RewardInventoryOverrideEnum RewardInventoryOverride;
        /* 0x98 */ public NMSString0x80 DebugText;
    }
}
