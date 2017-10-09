namespace libMBIN.Models.Structs
{
    public class GcMissionConsequenceRemoveCommunicatorMessage : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string Comms;
    }
}
