namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x285BD69F980B0FF0, NameHash = 0x150B7D498E249B47)]
    public class GcInventoryFilterOptions : NMSTemplate
    {
        // size: 0x5
        public enum InventoryFilterEnum {
            All,
            Substance,
            HighValue,
            Consumable,
            Deployable
        }
        /* 0x0 */ public InventoryFilterEnum InventoryFilter;
    }
}
