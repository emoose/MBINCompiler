namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7524BB7A0B6BAF0, NameHash = 0x913236FB)]
    public class GcMissionConditionRefinerHasInput : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 InputProduct;
        [NMS(Index = 1)]
        /* 0x10 */ public int InputAmount;
        [NMS(Index = 2)]
        /* 0x14 */ public bool MustBeCooker;
        [NMS(Index = 3)]
        /* 0x15 */ public bool MustBeCorvetteModule;
    }
}
