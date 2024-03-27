using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x35B9E521B8A19330, NameHash = 0x702F7B1A0F3F0830)]
    public class GcUnlockableTreeCostType : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 CostTypeID;
        // size: 0x3
        public enum TypeOfCostEnum : uint {
            Currency,
            Substance,
            Product,
        }
        /* 0x10 */ public TypeOfCostEnum TypeOfCost;
        /* 0x14 */ public GcCurrency CurrencyType;
        /* 0x18 */ public NMSString0x10 TypeID;
        /* 0x28 */ public NMSString0x20A CantAffordString;
    }
}
