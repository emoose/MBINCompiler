using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D77A4B3C1BBA25C, NameHash = 0x87FB8E825C599E66)]
    public class GcDefaultMissionItemsTable : NMSTemplate
    {
        /* 0x00 */ public List<GcDefaultMissionSubstance> PrimarySubstances;
        /* 0x10 */ public List<GcDefaultMissionSubstance> SecondarySubstances;
        /* 0x20 */ public List<GcDefaultMissionProduct> PrimaryProducts;
        /* 0x30 */ public List<GcDefaultMissionProduct> SecondaryProducts;
    }
}
