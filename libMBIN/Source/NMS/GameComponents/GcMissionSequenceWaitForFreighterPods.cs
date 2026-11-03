namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB2997639ABDD5B44, NameHash = 0xC8793BE)]
    public class GcMissionSequenceWaitForFreighterPods : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public int Amount;
        [NMS(Index = 2)]
        /* 0x24 */ public bool TakeAmountFromPulseEncounter;
    }
}
