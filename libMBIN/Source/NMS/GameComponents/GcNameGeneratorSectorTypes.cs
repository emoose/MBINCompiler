namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3B01C230DC8E0D75, NameHash = 0x2FBB792E633BA89B)]
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
            Ice
        }
        /* 0x0 */ public SectorNameEnum SectorName;
    }
}
