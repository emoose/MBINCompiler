namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5ADCA89B35808439, NameHash = 0x4BB811D8)]
    public class GcInventoryFilterOptions : NMSTemplate
    {
        // size: 0x5
        public enum InventoryFilterEnum : uint {
            All,
            Substance,
            HighValue,
            Consumable,
            Deployable,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InventoryFilterEnum InventoryFilter;
    }
}
