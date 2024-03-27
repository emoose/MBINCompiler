using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9F7DF3031B4F2429, NameHash = 0x6CDCC5ED743D58A1)]
    public class GcRepShopDonation : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ProductID;
        /* 0x10 */ public int DonationValue;
        /* 0x14 */ public int MaxDonations;
        [NMS(Size = 0x1A, EnumType = typeof(GcProceduralProductCategory.ProceduralProductCategoryEnum))]
        /* 0x18 */ public bool[] ValidProcProdCategories;
        /* 0x38 */ public List<NMSString0x10> AltIDs;
    }
}
