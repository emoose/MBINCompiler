using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDF62468D0B76D218, NameHash = 0x3DFFD10C388635E7)]
    public class GcCreatureTagAndRarity : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Tag;
        /* 0x10 */ public GcCreatureRarity RarityOverride;
    }
}
