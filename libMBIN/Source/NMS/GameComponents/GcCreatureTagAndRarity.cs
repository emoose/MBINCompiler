using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x541B622CB34F0EBB, NameHash = 0x3DFFD10C388635E7)]
    public class GcCreatureTagAndRarity : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Tag;
        /* 0x10 */ public GcCreatureRarity RarityOverride;
    }
}
