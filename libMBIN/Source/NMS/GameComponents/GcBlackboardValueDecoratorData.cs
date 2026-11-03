namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x245DE92E1123A717, NameHash = 0x427F44B)]
    public class GcBlackboardValueDecoratorData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSTemplate Child;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Key;
        [NMS(Index = 1)]
        /* 0x20 */ public bool ClearOnSuccess;
    }
}
