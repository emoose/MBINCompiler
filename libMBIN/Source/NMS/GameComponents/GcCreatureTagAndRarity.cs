using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x61AE7C6CD6687A47, NameHash = 0x3DFFD10C388635E7)]
    public class GcCreatureTagAndRarity : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Tag;
        /* 0x10 */ public GcCreatureRarity RarityOverride;
    }
}
