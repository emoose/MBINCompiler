namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x95D7E51CBBB0370B, NameHash = 0x27C076F10CE0DEC2)]
    public class GcBlackboardValueDecoratorData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Key;
        /* 0x10 */ public bool ClearOnSuccess;
        /* 0x18 */ public NMSTemplate Child;
    }
}
