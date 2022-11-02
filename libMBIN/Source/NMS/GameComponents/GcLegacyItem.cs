namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE7CB34F729F04A63, NameHash = 0x132E24BDAE218C83)]
    public class GcLegacyItem : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public NMSString0x10 ConvertID;
        /* 0x20 */ public float ConvertRatio;
        /* 0x24 */ public bool AddNewRecipe;
        /* 0x25 */ public bool RemoveOldRecipe;
    }
}
