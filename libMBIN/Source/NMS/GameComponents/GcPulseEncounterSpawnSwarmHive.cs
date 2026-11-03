namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x63A6AC509F0F5ACD, NameHash = 0x7EBE25C0)]
    public class GcPulseEncounterSpawnSwarmHive : NMSTemplate
    {
        [NMS(Index = 11)]
        /* 0x00 */ public NMSString0x10 AttackDefinition;
        [NMS(Index = 5)]
        /* 0x10 */ public float LeaveIfPlayerThisClose;
        [NMS(Index = 6)]
        /* 0x14 */ public float LeaveIfPlayerThisFar;
        [NMS(Index = 0)]
        /* 0x18 */ public float Pitch;
        [NMS(Index = 2)]
        /* 0x1C */ public float Roll;
        [NMS(Index = 3)]
        /* 0x20 */ public float UpOffset;
        [NMS(Index = 1)]
        /* 0x24 */ public float Yaw;
        [NMS(Index = 4)]
        /* 0x28 */ public bool LeaveIfAttacked;
        [NMS(Index = 8, MxmlName = "LeaveIfPlayerNotInSpace ")]
        /* 0x29 */ public bool LeaveIfPlayerNotInSpace;
        [NMS(Index = 7)]
        /* 0x2A */ public bool LeaveIfPlayerPulseDrives;
        [NMS(Index = 9)]
        /* 0x2B */ public bool WarpIn;
        [NMS(Index = 10)]
        /* 0x2C */ public bool WarpOut;
    }
}
