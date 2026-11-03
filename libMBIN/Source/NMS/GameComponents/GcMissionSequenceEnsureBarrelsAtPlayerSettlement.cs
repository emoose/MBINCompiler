namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xECBC3274BF187B8E, NameHash = 0xA812A5BF)]
    public class GcMissionSequenceEnsureBarrelsAtPlayerSettlement : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 2)]
        /* 0x20 */ public int MinBarrelsThreshold;
        [NMS(Index = 1, MxmlName = "NumBarrels ")]
        /* 0x24 */ public int NumBarrels;
    }
}
