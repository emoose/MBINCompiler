namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE94F183E7A3AB861, NameHash = 0x779C608FD9761375)]
    public class GcMissionSequenceWaitForFreighterPods : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public int Amount;
        /* 0x84 */ public bool TakeAmountFromPulseEncounter;
        /* 0x85 */ public NMSString0x80 DebugText;
    }
}
