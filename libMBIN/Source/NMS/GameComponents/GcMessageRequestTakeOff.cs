namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFEC52895DF3E843E, NameHash = 0xB0AB7777BBC667DD)]
    public class GcMessageRequestTakeOff : NMSTemplate
    {
        /* 0x0 */ public float Delay;
        /* 0x4 */ public bool ImmediatelyDissolveNPC;
    }
}
