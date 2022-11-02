namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x865E9558438DF2CB, NameHash = 0x950617F05949472B)]
    public class GcInventoryStoreBalance : NMSTemplate
    {
        /* 0x00 */ public int PlayerPersonalInventoryTechWidth;
        /* 0x04 */ public int PlayerPersonalInventoryTechHeight;
        /* 0x08 */ public int PlayerPersonalInventoryCargoWidth;
        /* 0x0C */ public int PlayerPersonalInventoryCargoHeight;
        /* 0x10 */ public float DeconstructRefundPercentage;
    }
}
