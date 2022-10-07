using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x234DE601620B66D9, NameHash = 0xCC978CCE3CFE915B)]
    public class GcPlayerHazardTable : NMSTemplate
    {
        // size: 0x6
        public enum TableEnum {
            None,
            NoOxygen,
            ExtremeHeat,
            ExtremeCold,
            ToxicGas,
            Radiation
        }
        [NMS(Size = 0x6, EnumType = typeof(TableEnum))]
        /* 0x0 */ public GcPlayerHazardData[] Table;
    }
}
