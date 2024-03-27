namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xADA26EA67A0AA85C, NameHash = 0xB6F9D0E7CC7397EC)]
    public class GcWonderRecord : NMSTemplate
    {
        [NMS(Size = 0x2)]
        /* 0x00 */ public ulong[] GenerationID;
        /* 0x10 */ public float WonderStatValue;
        /* 0x14 */ public bool SeenInFrontend;
    }
}
