namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x56391F2A883D3EE3, NameHash = 0x7A9148E7)]
    public class GcMissionConditionRefinerHasOutput : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 OutputProduct;
        [NMS(Index = 1)]
        /* 0x10 */ public int OutputAmount;
        [NMS(Index = 3)]
        /* 0x14 */ public bool MustBeCooker;
        [NMS(Index = 4)]
        /* 0x15 */ public bool MustBeCorvetteModule;
        [NMS(Index = 2)]
        /* 0x16 */ public bool UseDefaultAmount;
    }
}
