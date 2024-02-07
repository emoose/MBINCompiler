namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA0F0668C0842FFC2, NameHash = 0x682423D13B8E79EF)]
    public class GcMissionConditionRefinerHasInput : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 InputProduct;
        /* 0x10 */ public int InputAmount;
        /* 0x14 */ public bool MustBeCooker;
    }
}
