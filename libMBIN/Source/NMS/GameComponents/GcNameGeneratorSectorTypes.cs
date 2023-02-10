namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDDB65B2E1B0A92F5, NameHash = 0x2FBB792E633BA89B)]
    public class GcNameGeneratorSectorTypes : NMSTemplate
    {
        // size: 0xC
        public enum SectorNameEnum {
            Generic,
            Elevated,
            Low,
            Trees,
            LushTrees,
            Lush,
            Wet,
            Cave,
            Dead,
            Buildings,
            Water,
            Ice,
        }
        /* 0x0 */ public SectorNameEnum SectorName;
    }
}
