namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBD2BC029069D4E1F, NameHash = 0x84279994558A47D)]
    public class GcInteractionData : NMSTemplate
    {
        /* 0x00 */ public ulong GalacticAddress;
        /* 0x08 */ public ulong Value;
        /* 0x10 */ public Vector4f Position;
    }
}
