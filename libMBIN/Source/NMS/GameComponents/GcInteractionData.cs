namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2DCBFB2387EE5636, NameHash = 0x55ACD870)]
    public class GcInteractionData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector4f Position;
        [NMS(Index = 0)]
        /* 0x10 */ public ulong GalacticAddress;
        [NMS(Index = 1)]
        /* 0x18 */ public ulong Value;
    }
}
